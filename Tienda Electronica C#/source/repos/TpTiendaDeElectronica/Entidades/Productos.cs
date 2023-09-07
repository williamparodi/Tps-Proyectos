using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        protected ECategorias categoria;
        protected string nombre;
        protected double precio;
        protected int cantidad;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Productos()
        {
            this.nombre = "Sin nombre";
            this.precio = 0;
            this.cantidad = 0;
            this.categoria = ECategorias.SinCategoria;
        }

        /// <summary>
        /// Contructor con sobrecarga
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Productos(ECategorias categoria,string nombre, double precio,int cantidad) : this()
        {
            this.categoria = categoria;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Propiedad que retorna y setea el nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Propiedad que retorna y setea categoria
        /// </summary>
        public ECategorias Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        /// <summary>
        ///  Propiedad que retorna y setea precio
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        /// <summary>
        /// Propiedad que retorna y setea la cantidad
        /// </summary>
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        
        
        /// <summary>
        /// Sobrecarga de operador == que compara dos Productos por categoria
        /// </summary>
        /// <param name="prod1"></param>
        /// <param name="prod2"></param>
        /// <returns></returns> true si son iguales o false si no 
        public static bool operator ==(Productos prod1, Productos prod2)
        {
            bool retorno = false;
            
            if(prod1 is not null && prod2 is not null)
            {
                if(prod1.nombre == prod2.nombre)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga que compara dos productos por catergoria
        /// </summary>
        /// <param name="prod1"></param>
        /// <param name="prod2"></param>
        /// <returns></returns> false en caso negativo o true si son iguales
        public static bool operator !=(Productos prod1, Productos prod2)
        {
            return !(prod1 == prod2);
        }
        
        /// <summary>
        /// Crea un string y lo retorna con los datos del producto
        /// </summary>
        /// <returns></returns> string con los datos del producto
        public virtual string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Categoria : {this.categoria} Nombre : {this.nombre} Precio : {this.precio}");
            return sb.ToString();

        }

        
        


    }
}
