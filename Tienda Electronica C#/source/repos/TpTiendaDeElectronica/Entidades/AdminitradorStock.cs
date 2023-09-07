using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Entidades
{
    public class AdminitradorStock
    {
        private List<Productos> listaProductos;
        private Productos producto;

        /// <summary>
        /// Contructor que instancia una lista 
        /// </summary>
        public AdminitradorStock()
        {
            this.listaProductos = new List<Productos>();
        }

        /// <summary>
        /// Contructor con sobrecarga
        /// </summary>
        /// <param name="listaProductos"></param>
        public AdminitradorStock(List<Productos> listaProductos)
        {
            this.listaProductos = listaProductos;
        }


        /// <summary>
        /// Propiedad que setea y retorna una lista 
        /// </summary>
        public List<Productos> ListaDeProductos
        {
            get { return this.listaProductos; }
            set { this.listaProductos = value; }
        }

        /// <summary>
        /// Propiedad que seta y retorna un producto
        /// </summary>
        public Productos Productos
        {
            get { return this.producto; }
            set { this.producto = value; }
        }

        /// <summary>
        /// Agrega nombre al producto validando que no sea una cadena vacio
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns> el producto
        public Productos AgregarNombre(string nombre)
        {    
            if (nombre != "")
            {
                this.producto.Nombre = nombre;
            }
            return producto;
        }

        /// <summary>
        /// Agrega una cantidad y valida que no sea una cadena vacia al atributo de producto
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns> Producto
        public Productos AgregarCantidad(string cantidad)
        {
            int cantidadASumar = 0;

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (int.TryParse(cantidad, out cantidadASumar))
                {
                    this.producto.Cantidad = cantidadASumar;
                }
            }
            return producto;
        }

        /// <summary>
        /// Agrega un precio al preducto y valida que no sea una cadena vacia y que sea un numero
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns> Producto
        public Productos AgregarPrecio(string precio)
        {
            double precioASumar = 0;

            if (!string.IsNullOrEmpty(precio))
            {
                if (double.TryParse(precio, out precioASumar))
                {
                    this.producto.Precio = precioASumar;
                }
            }
            return producto;
        }

        /// <summary>
        /// Agregalos campos al producto 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="categoria"></param>
        /// <returns></returns> producto
        public Productos AgregarDatosAProducto(string nombre, string cantidad, string precio, string categoria)
        {
            this.producto = AgregarNombre(nombre);
            this.producto = AgregarCantidad(cantidad);
            this.producto = AgregarPrecio(precio);

            switch (categoria)
            {
                case "Mother":
                    this.producto.Categoria = ECategorias.Mother;
                    break;
                case "Microprocesador":
                    this.producto.Categoria = ECategorias.Microprocesador;
                    break;
                case "Perisfericos":
                    this.producto.Categoria = ECategorias.Perisfericos;
                    break;
                case "Gabinete":
                    this.producto.Categoria = ECategorias.Gabinete;
                    break;
                case "Monitor":
                    this.producto.Categoria = ECategorias.Monitor;
                    break;
                default:
                    break;
            }

            return producto;
        }

        /// <summary>
        /// Agrega el producto a la lista validando que no sea nulo
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarProductoAStock(Productos producto)
        {
            if (producto is not null)
            {
                this.listaProductos.Add(producto);
            }
        }

        /// <summary>
        /// Filtra una lista por categoria 
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns> La lista filtrada
        public List<Productos> FiltrarCategoria(string categoria,List<Productos> listaDeProductos)
        {
            List<Productos> auxListStock = new List<Productos>();

            if (!string.IsNullOrEmpty(categoria))
            {
                foreach (Productos producto in listaDeProductos)
                {
                    if (producto.Categoria.ToString() == categoria)
                    {
                        auxListStock.Add(producto);
                    }
                }
            }

            return auxListStock;
        }

        /// <summary>
        /// Filtra una lista por nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns> lista filrada 
        public List<Productos> FiltrarPorNombre(string nombre,List<Productos> listaDeProductos)
        {
            List<Productos> auxListStock = new List<Productos>();

            if (!string.IsNullOrEmpty(nombre))
            {
                foreach (Productos producto in listaDeProductos)
                {
                    if (producto.Nombre.ToLower() == nombre.ToLower())
                    {
                        auxListStock.Add(producto);
                    }
                }
            }

            return auxListStock;
        }

        /// <summary>
        /// Filtra la lista por precio maximo
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns> lista filtrada
        public List<Productos> FiltrarPorPrecioMaximo(string precio)
        {
            List<Productos> auxListaStock = new List<Productos>();
            double precioAComparar;

            if (double.TryParse(precio, out precioAComparar))
            {
                foreach (Productos producto in auxListaStock)
                {
                    if (precioAComparar >= producto.Precio)
                    {
                        auxListaStock.Add(producto);
                    }
                }
            }

            return auxListaStock;
        }

        /// <summary>
        /// Lista harcodeada para probar el programa
        /// </summary>
        /// <returns></returns> lista con datos cargados
        public List<Productos> HarcodearLista()
        {
            List<Productos> listaHardcodeada = new List<Productos>();

            Productos productos = new Productos(ECategorias.Microprocesador, "Ryzen 5", 55666, 75);
            Productos productos1 = new Productos(ECategorias.Mother, "Asus", 2323, 75);
            Productos productos2 = new Productos(ECategorias.Gabinete, "Terma", 65652, 75);
            Productos productos3 = new Productos(ECategorias.Microprocesador, "Ryzen 7", 9874, 95);
            Productos productos4 = new Productos(ECategorias.Monitor, "Dell", 45555, 10);
            Productos productos5 = new Productos(ECategorias.Monitor, "Samsung", 15655, 10);
            Productos productos6 = new Productos(ECategorias.Perisfericos, "Teclado", 98885, 15);
            Productos productos7 = new Productos(ECategorias.Perisfericos, "Redragon", 10800, 15);
            Productos productos8 = new Productos(ECategorias.Gabinete, "CoolerMaster", 98885, 35);
            Productos productos9 = new Productos(ECategorias.Mother, "Asrock", 35566, 80);
            Productos productos10 = new Productos(ECategorias.Microprocesador, "Intel", 60000, 10);

            listaHardcodeada.Add(productos);
            listaHardcodeada.Add(productos1);
            listaHardcodeada.Add(productos2);
            listaHardcodeada.Add(productos3);
            listaHardcodeada.Add(productos4);
            listaHardcodeada.Add(productos5);
            listaHardcodeada.Add(productos6);
            listaHardcodeada.Add(productos7);
            listaHardcodeada.Add(productos8);
            listaHardcodeada.Add(productos9);
            listaHardcodeada.Add(productos10);

            return listaHardcodeada;

        }

    }
}
