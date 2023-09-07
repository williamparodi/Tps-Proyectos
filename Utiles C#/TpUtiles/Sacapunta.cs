using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TpUtiles
{
    public class Sacapunta : Util
    {
        private ETipoSacapuntas tipoSacapuntas;

        public Sacapunta() : base()
        {
            this.tipoSacapuntas = ETipoSacapuntas.SinTipo;
        }

        public Sacapunta(double precio,string marca,ETipoSacapuntas tipoSacapuntas): base(precio,marca)
        {
            this.tipoSacapuntas = tipoSacapuntas;
        }

        public ETipoSacapuntas TipoSacapuntas
        {
            get { return this.tipoSacapuntas; }
            set { this.tipoSacapuntas = value; }
        }

        /// <summary>
        /// SobreCarga del metodo ToString con los datos del util "sacapunta"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Precio : {this.precio}");
            sb.AppendLine($"Marca : {this.marca}");
            sb.AppendLine($"Tipo de sacapuntas : {this.TipoSacapuntas}");
            return sb.ToString();
        }

        /// <summary>
        /// Carga el enumerado dependiendo del texto pasado por parametro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public ETipoSacapuntas CargaTipoSacapuntas(string tipo)
        {
            ETipoSacapuntas auxSacapuntas = new ETipoSacapuntas();

            switch(tipo)
            {
                case "Electrico":
                    auxSacapuntas = ETipoSacapuntas.Electrico;
                    break;
                case "Portatil":
                    auxSacapuntas = ETipoSacapuntas.Portatil;
                    break;
                default:
                    break;
            }

            return auxSacapuntas;
        }
        /// <summary>
        /// Carga los datos del util sacapunta
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public Sacapunta CargaDatosSacapuntas(string precio,string marca,string tipo)
        {
            Sacapunta auxSacapuntas = new Sacapunta();

            double precioASumar;

            precioASumar = double.Parse(precio);
            auxSacapuntas.precio = precioASumar;
            auxSacapuntas.marca = marca;
            auxSacapuntas.tipoSacapuntas = auxSacapuntas.CargaTipoSacapuntas(tipo);

            return auxSacapuntas;
        }
    }
}
