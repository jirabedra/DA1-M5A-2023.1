using Dominio;
using Excepciones;
using LogicaDeNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Logic.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Exception ext = null;

            try
            {
                LogicaDeCliente logic = new LogicaDeCliente();
                Cliente unCliente = new Cliente()
                {
                    Nombre = "dsfsd",
                    FechaDeNacimiento = DateTime.Now,
                    Id=1,
                    EsSocio= true
                };
                logic.AgregarCliente(unCliente);

                //Act
                logic.AgregarCliente(unCliente);
            }catch(Exception ex)
            {
                ext = ex;
            }
            //Assert
            Assert.IsNotNull(ext);
            Assert.IsInstanceOfType(ext, typeof(ClienteExceptions));
            Assert.AreEqual(ext.Message, "Ya existe un cliente con el nombre: dsfsd");
        }
    }
}
