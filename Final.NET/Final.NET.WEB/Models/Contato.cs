using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.NET.WEB.Models
{
    public class Contato
    {
        public int ContatoID { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public Telefone telefone { get; set; }
        
    }
}