using System;
using System.Security.Cryptography;
using System.Text;

namespace WebMVCApplication.Domain.Infrastructures
{
    public class Security
    {
        private readonly string serviceKey;
        private SHA1CryptoServiceProvider sHA1CryptoServiceProvider;

        public Security()
        {
            serviceKey = "_WebMVCApplicationByTTVone.COM@";
            sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
        }

        public string PasswordHash(string password)
        {
            var shar1Password = sHA1CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes($"{password}:{serviceKey}"));
            return Convert.ToBase64String(shar1Password);
        }

        public bool PasswordVerify(string passwordHash, string password)
        {
            return passwordHash.Equals(PasswordHash(password));
        }
    }
}
