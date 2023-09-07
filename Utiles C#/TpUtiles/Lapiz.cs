using Entidades;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace TpUtiles
{
    public class Lapiz  : Util, ISerializa<Util>, IDeserealiza<Util>
    {
        private EColor color;
        private ETipoLapiz tipoDeLapiz;

        public Lapiz() : base()
        {
            this.color = EColor.SinColor;
            this.tipoDeLapiz = ETipoLapiz.SinTipo;
        }

        public Lapiz(double precio, string marca) : base(precio, marca)
        {

        }

        public Lapiz(double precio, string marca, EColor color, ETipoLapiz tipoDelapiz) : base(precio, marca)
        {
            this.color = color;
            this.tipoDeLapiz = tipoDelapiz;

        }

        //Propiedades con el convert de enumerados a jason
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ETipoLapiz TipoDeLapiz
        {
            get { return this.tipoDeLapiz; }
            set { this.tipoDeLapiz = value; }
        }

        //Metodos
        /// <summary>
        /// Sobrecarga del metodo ToString devuelve los datos del util lapiz
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Precio : {this.precio}");
            sb.AppendLine($"Marca : {this.marca}");
            sb.AppendLine($"Color : {this.Color}");
            sb.AppendLine($"Tipo de Lapiz: {this.TipoDeLapiz}");
            return sb.ToString();
        }
        /// <summary>
        ///  Devulve un enumerado color denpendiendo del texto pasado por parametro
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public virtual EColor CargaColor(string color)
        {
            EColor auxColor = new EColor();
            switch (color)
            {
                case "Rojo":
                    auxColor = EColor.Rojo;
                    break;
                case "Azul":
                    auxColor = EColor.Azul;
                    break;
                case "Amarillo":
                    auxColor = EColor.Amarillo;
                    break;
                case "Negro":
                    auxColor = EColor.Negro;
                    break;
                default:
                    break;
            }

            return auxColor;
        }

        /// <summary>
        ///  Devulve un enumerado tipo denpendiendo del texto pasado por parametro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public ETipoLapiz CargaTipoLapiz(string tipo)
        {
            ETipoLapiz auxLapiz = new ETipoLapiz();
            switch (tipo)
            {
                case "Normal":
                    auxLapiz = ETipoLapiz.Normal;
                    break;
                case "Grafito":
                    auxLapiz = ETipoLapiz.Grafito;
                    break;
                default:
                    break;
            }

            return auxLapiz;
        }

        /// <summary>
        /// Carga los datos del util Lapiz
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public Lapiz CargaDatosLapiz(string precio, string marca, string color, string tipo)
        {
            double precioAsumar = double.Parse(precio);
            Lapiz auxLapiz = new Lapiz();

            auxLapiz.precio = precioAsumar;
            auxLapiz.marca = marca;
            auxLapiz.Color = auxLapiz.CargaColor(color);
            auxLapiz.TipoDeLapiz = auxLapiz.CargaTipoLapiz(tipo);

            return auxLapiz;
        }



        //Serealiza y Deserealiza
        /// <summary>
        /// Serealiza un lapiz a formato Json
        /// </summary>
        /// <param name="lapiz"></param>
        public void SerializaLapizJson(Util lapiz)
        {
            string lapizTexto;

            if (lapiz is not null)
            {
                lapizTexto = JsonSerializer.Serialize(lapiz);
                File.WriteAllText("lapiz.json", lapizTexto);
            }
        }

        /// <summary>
        /// Deserealiza un lapiz a objeto Lapiz
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Util DeseralizaJsonLapiz(string str)
        {
            Lapiz lapiz = new Lapiz();
            if (!string.IsNullOrEmpty(str))
            {
                str = File.ReadAllText(str);
                lapiz = JsonSerializer.Deserialize<Lapiz>(str);
            }

            return lapiz;
        }

        /// <summary>
        /// Serealiza un lapiz a formato Xml
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="lapiz"></param>
        public void SerializaLapizXml(string nombreArchivo, Util lapiz)
        {
            if (string.IsNullOrEmpty(nombreArchivo) && lapiz is not null)
            {
                using (StreamWriter writer = new StreamWriter(nombreArchivo, true))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                    serializer.Serialize(writer, lapiz);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Util));
                    serializer.Serialize(writer, lapiz);
                }

            }
        }

        /// <summary>
        /// Deserealiza un lapiz a objeto Lapiz
        /// </summary>
        /// <param name="nombreDelArchivo"></param>
        /// <returns></returns>
        /// <exception cref="ExceptionArchivo"></exception>
        public Util DeserealizaLapizXml(string nombreDelArchivo)
        {
            Lapiz lapiz = new Lapiz();

            if (!string.IsNullOrEmpty(nombreDelArchivo))
            {
                using (StreamReader streamReader = new StreamReader(nombreDelArchivo, true))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Lapiz));
                    lapiz = (Lapiz)deserializer.Deserialize(streamReader);
                }
            }
            else
            {
                throw new ExceptionArchivo("Error al deserealizar xml");
            }

            return lapiz;
        }

    }
}
