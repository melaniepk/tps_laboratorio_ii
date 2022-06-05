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
    public class Test_MembresiaCorrespondiente
    {
        [TestMethod]
        public void Test_WhenInputIsIncorrect_ShoulReturnNull()
        {
            Base.CargarClientes();
            string stringIncorrecto = "lkaskls";

            Membresia membresia = Membresia.MembresiaCorrespondiente(stringIncorrecto);

            Assert.IsNull(membresia);
        }

        [TestMethod]
        public void Test_WhenInputIsCorrect_ShoulReturnMembresia()
        {
            Base.CargarClientes();
            string stringCorrecto = "Full";

            Membresia membresia = Membresia.MembresiaCorrespondiente(stringCorrecto);

            Assert.IsNotNull(membresia);
        }
    }
}
