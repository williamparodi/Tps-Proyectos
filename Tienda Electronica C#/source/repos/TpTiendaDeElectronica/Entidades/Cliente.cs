using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private double dni;
        private double telefono;

        public Cliente()
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
            this.dni = 0000;
            this.telefono = 0000;
        }

        public Cliente(string nombre, string apellido, double dni, double telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
        }

        public string Nombre
        {
           get { return this.nombre; }
           set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public double Dni
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public double Telefono
        {
            get { return this.telefono;}
            set { this.telefono = value; }
        }

        public bool ValidaDatosCliente(string nombre,string apellido, string dni, string telefono)
        {
            bool retorno = false;
            double dniAIngresar;
            double telefonoAIngresar;

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) 
                && double.TryParse(dni,out dniAIngresar) && double.TryParse(telefono,out telefonoAIngresar))
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.dni = dniAIngresar;
                this.telefono = telefonoAIngresar;
                retorno =  true;
            }

            return retorno;
        }
        public string MostarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre} Apellido : {this.apellido}");
            sb.AppendLine($"Dni : {this.dni} Telefono : {this.telefono}");
            return sb.ToString();
        }

        public List<Cliente> HardcodeaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente("Pablo","Fernandez",40000444,45695841);
            Cliente cliente2 = new Cliente("Carlos", "Hernandez", 26000444, 45695841);
            Cliente cliente3 = new Cliente("Juan", "Cristol", 30000444, 1500241);
            Cliente cliente4 = new Cliente("Diego", "Guitierrez", 36000444, 45695841);
            Cliente cliente5 = new Cliente("Sabrina", "Pujol", 29000924, 45695841);
            Cliente cliente6 = new Cliente("Karen", "Armendia", 23000484, 45695841);
            Cliente cliente7 = new Cliente("Mariela", "Salomino", 5000694, 45695841);
            Cliente cliente8 = new Cliente("Laura", "Rinaldi", 1000604, 45695841);
            Cliente cliente9 = new Cliente("Rafael", "Candia", 6000454, 45695841);
            Cliente cliente10 = new Cliente("Rodrigo", "Durand", 33000444, 45695841);

            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            listaClientes.Add(cliente4);
            listaClientes.Add(cliente5);
            listaClientes.Add(cliente6);
            listaClientes.Add(cliente7);
            listaClientes.Add(cliente8);
            listaClientes.Add(cliente9);
            listaClientes.Add(cliente10);

            return listaClientes;
        }
    }
}
