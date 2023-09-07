using System;

namespace TpUtiles
{
    public abstract class Util
    {
        protected double precio;
        protected string marca;
        protected int id;
        public Util()
        {
            this.precio = 0;
            this.marca = "Sin marca";
            this.id = 0;   
        }

        public Util(double precio, string marca)
        {
            this.precio = precio;
            this.marca = marca; 
        }

        public Util(int id)
        {
            this.id = id;
        }

        public double Precio
        {
            get { return this.precio; }
            set
            {
                this.precio = value;
            }
        }

        public string Marca 
        {
            get { return this.marca; }
            set
            {
                this.marca = value;
            }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        /// <summary>
        /// Sobrecarga del operador = si son igules las marcas es true.
        /// </summary>
        /// <param name="util1"></param>
        /// <param name="util2"></param>
        /// <returns></returns>
        public static bool operator == (Util util1, Util util2)
        {
            return util1.Marca == util2.Marca;
        }

        public static bool operator !=(Util util1, Util util2)
        {
            return !(util1.Marca == util2.Marca);
        }
    }
}
