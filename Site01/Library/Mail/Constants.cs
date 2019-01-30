using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class Constants
    {
        /* POP3, IMAP - Ler mmensagensde e-mail
        * SMTP - Envia e-mail
        */

        //Autenticação - Gmail
        public readonly static string Usuario = "everton.l.m.silva@gmail.com";
        public readonly static string Senha = "Dragonsangels@12";


        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;

    }
}
