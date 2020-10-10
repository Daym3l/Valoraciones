﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Valoraciones;

namespace ValoracionesTest
{
    [TestClass]
    public class TestValoraciones
    {
        LibroValoraciones libroValoraciones;
        public TestValoraciones()
        {
            libroValoraciones = new LibroValoraciones();
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void calcularValoracionMax()
        {
            libroValoraciones.AgregarValoraciones(5);
            var max = libroValoraciones.getMaxValoracion();
            Assert.AreEqual(int.Parse(max), 10);
            
        }
    }
}