using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
//using Gimnasio;
namespace TestUnitarios
{
    [TestClass]
    public class Test_Comprobar_Existencia
    {
        [TestMethod]
        public void Test_ComprobarExistencia_When_dni_Exists_should_return_true()
        {
            int dni = 44555666;

            Base.CargarClientes();
            bool resultado = Cliente.ComprobarExistencia(dni);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Test_ComprobarExistencia_When_dni_doesnt_Exists_should_return_false()
        {
            int dni = 15889966;

            Base.CargarClientes();
            bool resultado = Cliente.ComprobarExistencia(dni);

            Assert.IsFalse(resultado);
        }

    }
}
