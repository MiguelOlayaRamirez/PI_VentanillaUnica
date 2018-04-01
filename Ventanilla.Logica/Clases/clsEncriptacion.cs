using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Ventanilla.Logica.Clases
{
    public class clsEncriptacion
    {
        public string stEncriptar(string stCadena)
        {
            byte[] BtclarBytes;
            BtclarBytes = new UnicodeEncoding().GetBytes(stCadena);
            byte[] BthashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(BtclarBytes);
            string sthashedText = BitConverter.ToString(BthashedBytes);

            return sthashedText;
        }
    }
}
