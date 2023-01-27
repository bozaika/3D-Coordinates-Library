using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3DCoordinatesLibrary;


namespace UnitTest3DCoordinates
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PropertiesTest() // constructurs
        {
            Cartesian Cood = new Cartesian();

            Cood.X = 10;
            Cood.Y = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.X);
            Assert.AreEqual(20, Cood.Y);
            Assert.AreEqual(30, Cood.Z);

        }

        public void PropertiesTest2()
        {
            Cylindrical Cood = new Cylindrical();

            Cood.R = 10;
            Cood.ThetaC = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.R);
            Assert.AreEqual(20, Cood.ThetaC);
            Assert.AreEqual(30, Cood.Z);

        }
        public void PropertiesTest3()
        {
            Spherical Cood = new Spherical();

            Cood.Rho = 10;
            Cood.ThetaS = 20;
            Cood.Phi = 30;

            Assert.AreEqual(10, Cood.Rho);
            Assert.AreEqual(20, Cood.ThetaS);
            Assert.AreEqual(30, Cood.Phi);

        }

        [TestMethod]
        public void SetterGetterTest()
        {
            Cartesian Cood = new Cartesian();

            Cood.X = 10;
            Cood.Y = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.X);
            Assert.AreEqual(20, Cood.Y);
            Assert.AreEqual(30, Cood.Z);
        }
        public void SetterGetterTest2()
        {
            Cylindrical Cood = new Cylindrical();

            Cood.R = 10;
            Cood.ThetaC = 20;
            Cood.Z = 30;

            Assert.AreEqual(10, Cood.R);
            Assert.AreEqual(20, Cood.ThetaC);
            Assert.AreEqual(30, Cood.Z);

        }
        public void SetterGetterTest3()
        {
            Spherical Cood = new Spherical();

            Cood.Rho = 10;
            Cood.ThetaS = 20;
            Cood.Phi = 30;

            Assert.AreEqual(10, Cood.Rho);
            Assert.AreEqual(20, Cood.ThetaS);
            Assert.AreEqual(30, Cood.Phi);

        }

      
         [TestMethod]
        public void SubtractionTest() // For distance
        {
            Cartesian P1 = new Cartesian();
            Cartesian P2 = new Cartesian();
            double result;

            P1.X = 1;
            P1.Y = 1;
            P1.Z = 1;

            P2.X = 2;
            P2.Y = 2;
            P2.Z = 2;


            result = P1 - P2;

            Assert.AreEqual(result, 1.7320508075688772935274463415059);
        }

    }


}
