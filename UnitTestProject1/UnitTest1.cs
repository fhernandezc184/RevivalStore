using Avance_3;
using Avance_3.Inventario;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Login_NoExitoso_False()
        {
            //Arrange
            var expected = false;
            var calculo = new LoginForm().login("123456789", "321");

            //Act
            var actual = calculo;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ObternerValordeConcesionTrue()
        {
            var expected = "TRUE";
            var valorconcesion1 = new InventarioForm().GetConsecionValue("Checked");

            var actual = valorconcesion1;

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void ObternerValordeConcesionFalse()
        {
            var expected = "FALSE";
            var valorconcesion = new InventarioForm().GetConsecionValue("Unchecked");

            var actual = valorconcesion;

            Assert.AreEqual(expected, actual);

        }
      
       
        
    }
}
