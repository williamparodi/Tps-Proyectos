using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        private string nombre;
        private double cuil;
        private List<Productos> listaProductos;

        public Proveedor()
        {
            this.nombre = "NN";
            this.cuil = 0;
            this.listaProductos = new List<Productos>();
        }

        public Proveedor(string nombre,double cuil) : this()
        {
            this.nombre = nombre;
            this.cuil = cuil;
        }

        public Proveedor(string nombre, double cuil, List<Productos> listaProductos) : this(nombre,cuil)
        {
            this.listaProductos = listaProductos;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Cuil
        {
            get { return cuil; }
            set { cuil = value; }
        }

        public List<Productos> ListaProductos
        {
            get { return listaProductos; }
            set  { listaProductos = value;}
        }

        public Proveedor EligeProveedor(string nombreProveedor)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            Proveedor proveedorElegido = new Proveedor();
            proveedores = HardcodeaProveedor();

            foreach(Proveedor pro in proveedores)
            {
                if(pro.nombre == nombreProveedor)
                {
                    proveedorElegido = pro;
                }
            }

            return proveedorElegido;
        }

        public List<Proveedor>  HardcodeaProveedor()
        {
            List<Proveedor> listaProveedores = new List<Proveedor> ();

            Productos producto1 = new Productos(ECategorias.Microprocesador,"Intel 9",545454,10);
            Productos producto2 = new Productos(ECategorias.Monitor, "LG ", 545454, 10);
            Productos producto3 = new Productos(ECategorias.Mother, "Intel 9", 4545, 15);
            Productos producto4 = new Productos(ECategorias.Gabinete, "Gabo ", 9000, 20);
            Productos producto5 = new Productos(ECategorias.Perisfericos, "Logitech", 545454, 6);

            List<Productos> listaProductos1 = new List<Productos>();
            listaProductos1.Add(producto1);
            listaProductos1.Add (producto2);
            listaProductos1.Add(producto3);

            List<Productos> listaProductos2 = new List<Productos>();
            listaProductos2.Add(producto4);
            listaProductos2.Add(producto5);
            listaProductos2.Add(producto1);

            List<Productos> listaProductos3 = new List<Productos>();
            listaProductos3.Add(producto1);
            listaProductos3.Add(producto4);
            listaProductos3.Add(producto3);

            Proveedor proveedor1 = new Proveedor("Pedro",20310066555,listaProductos1);
            Proveedor proveedor2 = new Proveedor("Juan",503333265,listaProductos2);
            Proveedor proveedor3 = new Proveedor("Carlos",65656566,listaProductos3);

            listaProveedores.Add(proveedor1);
            listaProveedores.Add(proveedor2);
            listaProveedores.Add(proveedor3);

            return listaProveedores;
        }
    }
}
