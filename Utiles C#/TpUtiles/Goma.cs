using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpUtiles
{
    public class Goma : Util
    {
        private ETipoGoma tipoGoma;
        private ETamanio tamanio;
       
        public Goma() : base()
        {
            this.tipoGoma = ETipoGoma.SinTipo;
            this.tamanio = 0;
        }

        public Goma(double precio,string marca,ETipoGoma tipoGoma,ETamanio tamanio) : base(precio,marca)
        {
            this.tipoGoma = tipoGoma;
            this.tamanio = tamanio;
        }
  
        public ETipoGoma TipoGoma
        {
            get { return this.tipoGoma; }
            set { this.tipoGoma = value; }
        }

        public ETamanio Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }

        /// <summary>
        ///Sobrecarga del metodo ToString devuelve un string con los datos del util "Goma" 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Precio : {this.precio}");
            sb.AppendLine($"Marca : {this.marca}");
            sb.AppendLine($"Tipo de goma : {this.tipoGoma}");
            sb.AppendLine($"Tamaño : {this.tamanio}");
            return sb.ToString();
        }

        /// <summary>
        /// Carga  los datos del util goma
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <param name="tamanio"></param>
        /// <returns></returns>
        public  Goma CargaDatosGoma(string precio,string marca,string tipo,string tamanio)
        {
            Goma auxGoma = new Goma();
            double precioASumar;

            precioASumar = double.Parse(precio);
            auxGoma.precio = precioASumar;
            auxGoma.marca = marca;
            auxGoma.tipoGoma = auxGoma.CargaTipoGoma(tipo);
            auxGoma.tamanio = auxGoma.CargaTamanio(tamanio);
          
            return auxGoma;   
        }

        /// <summary>
        /// Devulve un enumerado tipo denpendiendo del texto pasado por parametro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public ETipoGoma CargaTipoGoma(string tipo)
        {
            ETipoGoma auxGoma = new ETipoGoma();

            switch (tipo)
            {
                case "ParaTinta":
                    auxGoma = ETipoGoma.ParaTinta;
                    break;
                case "ParaLapiz":
                    auxGoma = ETipoGoma.ParaLapiz;
                    break;
                default:
                    break;
            }

            return auxGoma;
        }

        /// <summary>
        /// Devulve un enumerado tamanio denpendiendo del texto pasado por parametro
        /// </summary>
        /// <param name="tamanio"></param>
        /// <returns></returns>
        public ETamanio CargaTamanio(string tamanio) 
        {
            ETamanio auxGoma = new ETamanio();

            switch(tamanio) 
            {
                case "Numero1":
                    auxGoma = ETamanio.Numero1;
                    break;
                case "Numero2":
                    auxGoma = ETamanio.Numero2;
                    break;
                case "Numero3":
                    auxGoma = ETamanio.Numero3;
                    break;
                default:
                    break;
            }

            return auxGoma;
        }


    }
}
