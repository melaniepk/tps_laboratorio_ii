using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TestUnitarios
{
    [TestClass]
    public class Test_CrearCliente
    {
        [TestMethod]
        public void Test_CrearCliente_WhenIncorrectInput_ShouldReturnNull()
        {
            Base.CargarClientes();
            int dniIncorrecto = 1025478966;
            Membresia membresia = new Membresia(ENombre.Full,ETurnos.CincoTurnos,EPrecio.TresMil);

            Cliente nuevoCliente =  Cliente.CrearCliente("Juan", "Pedroso", EGenero.Femenino,
                dniIncorrecto, 1522558899,"Full", true);


            Assert.IsNull(nuevoCliente);
        }

        [TestMethod]
        public void Test_CrearCliente_WhenCorrectInput_ShouldReturnCliente()
        {
            Base.CargarClientes();
            int dniCorrecto = 10254789;
            Membresia membresia = new Membresia(ENombre.Full,ETurnos.CincoTurnos, EPrecio.TresMil);

            Cliente nuevoCliente = Cliente.CrearCliente("Juan", "Pedroso", EGenero.Femenino,
                dniCorrecto, 1522558899, "Full", true);


            Assert.IsNotNull(nuevoCliente);
        }
    }
}
