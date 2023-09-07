using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contador : Vendedor
    {
        public Contador() : base()
        {

        }

        public Contador(string nombre, string password) : base(nombre, password)
        {

        }

        public override void CrearUsuario()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("contador@gmail.com");
            this.usuario = sb.ToString();
        }

        public override void CrearPassword()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("contador1234");
            this.password = sb.ToString();
        }

        public override string GetUsuario()
        {
            if (this.usuario == "NN")
            {
                CrearUsuario();
            }

            return this.usuario;
        }

        public override string GetPassword()
        {
            if (this.password == "Sin contraseña")
            {
                CrearPassword();
            }

            return this.password;
        }
      
    }
}
