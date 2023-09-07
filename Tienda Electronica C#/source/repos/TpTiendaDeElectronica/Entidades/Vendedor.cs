using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        protected string usuario;
        protected string password;

        /// <summary>
        /// Contructor con valores por defecto
        /// </summary>
        public Vendedor()
        {
            this.usuario = "NN";
            this.password = "Sin contraseña";
        }

        /// <summary>
        /// Contructor con sobrecarga
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        public Vendedor(string usuario, string password) : this()
        {
            this.usuario = usuario;
            this.password = password;
        }

        /// <summary>
        /// Crea un sting y se lo asigna al atributo usuario
        /// </summary>
        public virtual void CrearUsuario()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("pablo@gmail.com");
            this.usuario = sb.ToString();
        }

        /// <summary>
        /// Crea un string y se lo asigna al atibuto password
        /// </summary>
        public virtual void CrearPassword()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("pablo1234");
            this.password = sb.ToString();
        }

        /// <summary>
        /// valida que no sea un usuario no creado y lo crea si lo es
        /// retorna el atrubuto usuario.
        /// </summary>
        /// <returns></returns>
        public virtual string GetUsuario()
        {
            if (this.usuario == "NN")
            {
                CrearUsuario();
            }

            return this.usuario;

        }

        /// <summary>
        /// valida que no sea un password no creado y lo crea si lo es
        /// retorna el atrubuto password.
        /// </summary>
        /// <returns></returns>
        public virtual string GetPassword()
        {
            if(this.password == "Sin contraseña")
            {
                CrearPassword();
            }
            return this.password;
        }




    }
}
