using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    public class User
    {
        public string name;
        public string password;
        public string email;

        public string Hash()
        {
            HashAlgorithm algorithm = SHA256.Create();
            var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hash);
        }
    }


   
}
