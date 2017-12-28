using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

//Ref from: https://googleauthcsharp.codeplex.com/

namespace Google_Authenticator_TOTP
{
    public partial class GoogleOTP : Form
    {
        public GoogleOTP()
        {
            InitializeComponent();
            
            Secret = new byte[] { 0x19, 0x65, 0x60, 0x6B, 0x4F, 0x21, 0xAE, 0xAE, 0xBF, 0x3F };
            txtSecretBase32.Text=SecretBase32;
            txtIdentity.Text = "my@email.com";
            Identity = txtIdentity.Text;

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.
            timer1.Enabled = true;
            
        }
        private int _secondsToGo;

        public int SecondsToGo
        {
            get { return _secondsToGo; }
            private set { _secondsToGo = value; OnPropertyChanged("SecondsToGo"); if (SecondsToGo == 30) CalculateOneTimePassword(); }
        }


        private string _identity;

        public string Identity
        {
            get { return _identity; }
            set { _identity = value; OnPropertyChanged("Identity"); OnPropertyChanged("QRCodeUrl"); CalculateOneTimePassword(); }
        }

        public string SecretBase32
        {
            get { return Base32.ToString(Secret); }
            set { try { Secret = Base32.ToBytes(value); } catch { }; OnPropertyChanged("SecretBase32"); }
        }

        private byte[] _secret;

        public byte[] Secret
        {
            get { return _secret; }
            set { _secret = value; OnPropertyChanged("Secret"); OnPropertyChanged("QRCodeUrl"); CalculateOneTimePassword(); OnPropertyChanged("SecretBase32"); }
        }

        public string QRCodeUrl
        {
            get { return GetQRCodeUrl(); }
        }

        private Int64 _timestamp;

        public Int64 Timestamp
        {
            get { return _timestamp; }
            private set { _timestamp = value; OnPropertyChanged("Timestamp"); }
        }

        private byte[] _hmac;

        public byte[] Hmac
        {
            get { return _hmac; }
            private set { _hmac = value; OnPropertyChanged("Hmac"); OnPropertyChanged("HmacPart1"); OnPropertyChanged("HmacPart2"); OnPropertyChanged("HmacPart3"); }
        }

        public byte[] HmacPart1
        {
            get { return _hmac.Take(Offset).ToArray(); }
        }

        public byte[] HmacPart2
        {
            get { return _hmac.Skip(Offset).Take(4).ToArray(); }
        }

        public byte[] HmacPart3
        {
            get { return _hmac.Skip(Offset + 4).ToArray(); }
        }

        private int _offset;

        public int Offset
        {
            get { return _offset; }
            private set { _offset = value; OnPropertyChanged("Offset"); }
        }

        private int _oneTimePassword;

        public int OneTimePassword
        {
            get { return _oneTimePassword; }
            set { _oneTimePassword = value; OnPropertyChanged("OneTimePassword"); txtOTP.Text = _oneTimePassword.ToString(); }
        }

        private string GetQRCodeUrl()
        {
            // https://code.google.com/p/google-authenticator/wiki/KeyUriFormat
            return String.Format("https://www.google.com/chart?chs=200x200&chld=M|0&cht=qr&chl=otpauth://totp/{0}%3Fsecret%3D{1}", Identity, SecretBase32);
        }

        private void CalculateOneTimePassword()
        {
            // https://tools.ietf.org/html/rfc4226
            Timestamp = Convert.ToInt64(GetUnixTimestamp() / 30);
            var data = BitConverter.GetBytes(Timestamp).Reverse().ToArray();
            Hmac = new HMACSHA1(Secret).ComputeHash(data);
            Offset = Hmac.Last() & 0x0F;
            OneTimePassword = (
                ((Hmac[Offset + 0] & 0x7f) << 24) |
                ((Hmac[Offset + 1] & 0xff) << 16) |
                ((Hmac[Offset + 2] & 0xff) << 8) |
                (Hmac[Offset + 3] & 0xff)
                    ) % 1000000;
        }

        private static Int64 GetUnixTimestamp()
        {
            return Convert.ToInt64(Math.Round((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void cmdOTP_Click(object sender, EventArgs e)
        {
            CalculateOTP();
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            txtTimeToGO.Text = SecondsToGo.ToString();
            CalculateOTP();
        }

        private void CalculateOTP()
        {
            SecondsToGo = 30 - Convert.ToInt32(GetUnixTimestamp() % 30);
            SecretBase32 = txtSecretBase32.Text;
            CalculateOneTimePassword();


            txtSecretHex.Text = BitConverter.ToString(Secret).Replace("-", "");
            txtTimestamp.Text = Timestamp.ToString();
            txtHMAC.Text = BitConverter.ToString(Hmac).Replace("-", "");
        }
    }
}
