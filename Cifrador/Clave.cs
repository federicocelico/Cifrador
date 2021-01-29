using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cifrador;

namespace ConsoleApp1
{
   public class Clave
    {
        public static string MailPassword;
        public static string clave = "s8ulHr4rP1hIHrd30S+4GQ==";
        public static string LoadValues()
        {
            AESObjectEnc Encriptacion = new AESObjectEnc();

            MailPassword = Encriptacion.Decrypt(clave);
            return MailPassword;
        }



    }
}

