using System;
using System.Collections.Generic;
using System.Text;

namespace Composition3.Entites
{
    class Client
    {
        private string Name;
        private string Email;
        private DateTime Date;

        //Construtor Padrao
        public Client()
        {
        }

        //Construtor Modificado
        public Client(string name,string email,DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        //Sobreescrevendo o metodo ToString
        public override string ToString()
        {
            return "Name: " + Name + " (" + Date.ToString("dd/MM/yyyy") + ") " + "- " + Email;
        }
    }
}
