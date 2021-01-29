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
        public static string clave = "INGRESAR CADENA A PROCESAR";
        public static string LoadValues()
        {
            AESObjectEnc Encriptacion = new AESObjectEnc();

            MailPassword = Encriptacion.Decrypt(clave); //CAMBIAR A ENCRYPYT O DESCRYPT SEGUN CORRESPONDA
            return MailPassword;
        }



    }
}

