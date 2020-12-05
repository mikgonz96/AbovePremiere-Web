using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbovePremierWeb.Models
{
    public class Usuario
    {
        public string mail { get; set; }
        public string pass { get; set; }


        public Usuario(string mail, string pass)
        {
            this.mail = mail;
            this.pass = pass;
        }

        public Usuario(string mail)
        {
            this.mail = mail;
        }


    }
}
