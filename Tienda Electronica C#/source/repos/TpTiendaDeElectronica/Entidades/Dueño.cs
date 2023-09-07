using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dueño : Vendedor
    {
        /// <summary>
        /// Contructor que hereda los atributos cargados por defecto
        /// </summary>
        public Dueño(): base ()
        {
            
        }
        
        /// <summary>
        /// Contructor carga los atributos 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        public Dueño(string usuario,string password) : base(usuario,password)
        {
            
        }
        
        /// <summary>
        /// Metodo override que setea el string en el usuario
        /// </summary>
        public override void CrearUsuario()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("roberto@gmail.com");
            this.usuario = sb.ToString();
        }

        /// <summary>
        ///  Metodo override que setea el string en el password
        /// </summary>
        public override void CrearPassword()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("roberto1234");
            this.password = sb.ToString();
        }
        
        /// <summary>
        /// Metodo override que vailda que el usuario sea creado si no lo crea 
        /// retorna usuario
        /// </summary>
        /// <returns></returns>
        public override string GetUsuario()
        {
            if (this.usuario == "NN")
            {
                CrearUsuario();
            }

            return this.usuario;
        }

        /// <summary>
        /// Metodo override que vailda que el usuario sea creado si no lo crea
        /// retorna password
        /// </summary>
        /// <returns></returns>
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
