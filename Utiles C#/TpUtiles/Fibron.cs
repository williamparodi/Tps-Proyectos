using TpUtiles;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Fibron : Util, ISerializa<Util>, IDeserealiza<Util>
    {
        public delegate void DelegadoSinTinta(string mensaje);
        public delegate void DelegadoGuardaError(string mensaje);
        private int cantidadTinta;
        private EColor color;
        public event DelegadoSinTinta EventoSinTinta;
        public event DelegadoGuardaError EventoError;
     
        public Fibron() : base()
        {
            this.cantidadTinta = 0;
            this.color = EColor.SinColor;
        }

        public Fibron(int cantidadTinta, EColor color)
        {
            this.cantidadTinta = cantidadTinta;
            this.color = color;
        }

        public int CantidadTinta
        {
            get { return this.cantidadTinta; }
            set { this.cantidadTinta = value; }
        }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public  EColor CargaColor(string color)
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
        /// Si la cantidad de tinta en el fibron es mayor descuenta la cantidad ingresada por parametro, si no lanza dos eventos un sin tinta y 
        /// otro que va a mostrar el fibron y cuanta tinta falataba, ademas tambien lanza una excepcion "SinTinta" . 
        /// </summary>
        /// <param name="cantidadTinta"></param>
        /// <exception cref="SinTintaException"></exception>
        public void Resaltar(int cantidadTinta)
        {
            int cantidadFaltante;
            if (this.CantidadTinta > cantidadTinta)
            {
                this.cantidadTinta -= cantidadTinta;
            }
            else
            {
                if (EventoSinTinta is not null && EventoError is not null)
                {
                    cantidadFaltante = cantidadTinta - this.CantidadTinta;
                    EventoSinTinta.Invoke("Evento sin tinta");
                    EventoError.Invoke(MuestraFibronSintinta(this,cantidadFaltante));
                    throw new SinTintaException("Te quedaste sin tinta");
                }
                
            }
        }

        /// <summary>
        /// Se sobreecarga el metodo To string para mostrar los datos del fibron.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fibron :");
            sb.AppendLine($"Color : {this.Color}");
            sb.AppendLine($"Cantidad tinta : {this.CantidadTinta}");
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve un string con el fibron y la tinta que faltaba.
        /// </summary>
        /// <param name="fibron"></param>
        /// <param name="cantidadDeTintaFaltante"></param>
        /// <returns></returns>
        public string MuestraFibronSintinta(object fibron, int cantidadDeTintaFaltante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(fibron.ToString());
            sb.AppendLine($"Cantidad de tinta faltante : {cantidadDeTintaFaltante}");
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve un string con la cantidad de tinta que se necesita y la que contiene el fibron 
        /// </summary>
        /// <param name="cantidadFibron"></param>
        /// <param name="cantidadAUsar"></param>
        /// <returns></returns>
        public string MuestraCantidadDeTinta(int cantidadFibron, int cantidadAUsar)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tinta en el Fibron : {cantidadFibron}");
            sb.AppendLine($"Tinta a Usar : {cantidadAUsar}");
            return sb.ToString();
        }

        /// <summary>
        /// Se Cargan unos tres fibrones con datos en una lista
        /// </summary>
        /// <param name="cartuchera"></param>
        public void HarcodeaFibrones(Cartuchera<Util> cartuchera)
        {
            Fibron fibron1 = new Fibron(5, EColor.Rojo);
            Fibron fibron2 = new Fibron(10, EColor.Azul);
            Fibron fibron3 = new Fibron(6, EColor.Amarillo);
            if(cartuchera is not null)
            {
                cartuchera.ListaUtiles.Add(fibron1);
                cartuchera.ListaUtiles.Add(fibron2);
                cartuchera.ListaUtiles.Add(fibron3);
            }
        }

        /// <summary>
        /// Carga los datos del util Lapiz
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public Util CargaDatosFibron(string color, string cantidad)
        {
            int cantidadAsumar = int.Parse(cantidad);
            Fibron auxFibron = new Fibron();

            auxFibron.CantidadTinta = cantidadAsumar;
        
            auxFibron.Color = auxFibron.CargaColor(color);
           

            return auxFibron;
        }



        //Serealiza y Deserealiza
        /// <summary>
        /// Serealiza un lapiz a formato Json
        /// </summary>
        /// <param name="lapiz"></param>
        public void SerializaLapizJson(Util Fibron)
        {
            string fibronTexto;

            if (Fibron is not null)
            {
                fibronTexto = JsonSerializer.Serialize(Fibron);
                File.WriteAllText("lapiz.json", fibronTexto);
            }
        }

        /// <summary>
        /// Deserealiza un lapiz a objeto Lapiz
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Util DeseralizaJsonLapiz(string str)
        {
            Fibron fibron= new Fibron();
            if (!string.IsNullOrEmpty(str))
            {
                str = File.ReadAllText(str);
                fibron = JsonSerializer.Deserialize<Fibron>(str);
            }

            return fibron;
        }

        /// <summary>
        /// Serealiza un lapiz a formato Xml
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="lapiz"></param>
        public void SerializaLapizXml(string nombreArchivo, Util fibron)
        {
            if (string.IsNullOrEmpty(nombreArchivo) && fibron is not null)
            {
                using (StreamWriter writer = new StreamWriter(nombreArchivo, true))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Fibron));
                    serializer.Serialize(writer, fibron);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Fibron));
                    serializer.Serialize(writer, fibron);
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
            Fibron fibron = new Fibron();

            if (!string.IsNullOrEmpty(nombreDelArchivo))
            {
                using (StreamReader streamReader = new StreamReader(nombreDelArchivo, true))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Fibron));
                    fibron = (Fibron)deserializer.Deserialize(streamReader);
                }
            }
            else
            {
                throw new ExceptionArchivo("Error al deserealizar xml");
            }

            return fibron;
        }

    }
}
