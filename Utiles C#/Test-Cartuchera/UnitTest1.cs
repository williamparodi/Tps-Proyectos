using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TpUtiles;

namespace Test_Cartuchera
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AcumulaPrecio_DeberiaRetorarPrecioTotal()
        {
            //Arrange
            Lapiz lapiz = new Lapiz(100, "Faber Castell", EColor.Rojo, ETipoLapiz.Grafito);
            Goma goma = new Goma(350, "Pelikan", ETipoGoma.ParaTinta, ETamanio.Numero3);
            Sacapunta sacapunta = new Sacapunta(100, "El mejor", ETipoSacapuntas.Portatil);
            Cartuchera<Util> cartuchera = new Cartuchera<Util>();
            cartuchera.ListaUtiles.Add(lapiz);
            cartuchera.ListaUtiles.Add(sacapunta);
            cartuchera.ListaUtiles.Add(goma);
            double expected = 550;

            //Act
            double actual = cartuchera.AcumulaPrecio(cartuchera.ListaUtiles);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Operador_deberiaSumarALaLista()
        {
            //Arrange
            Lapiz lapiz = new Lapiz(100, "Faber Castell", EColor.Rojo, ETipoLapiz.Grafito);
            Cartuchera<Util> cartuchera = new Cartuchera<Util>();

            //Act
            bool actual = false;
            if (cartuchera + lapiz)
            {
                actual = true;
            }
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(CartucheraLLenaException))]
        public void Operador_deberiaLanzarException()
        {
            //Arrange
            Cartuchera<Util> cartuchera = new Cartuchera<Util>();
            Lapiz lapiz = new Lapiz(100, "Faber Castell", EColor.Rojo, ETipoLapiz.Grafito);
            cartuchera.Capacidad = 10;

            //Act

            if (cartuchera + lapiz)
            {

            }

        }

    }
}
