using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes.Tests
{
    [TestClass()]
    public class RechteckTests
    {

        [TestMethod()]
        public void Rechteck()
        {
            Linie linieA = new Linie(0);
            Linie linieB = new Linie(0);
            Linie linieC = new Linie(0);


            Action action = () => new Dreieck(linieA, linieB, linieC);

            Assert.ThrowsException<ArgumentException>(() => action());

            Linie linieA1 = new Linie(10);
            Linie linieB1 = new Linie(10);
            Linie linieC1 = new Linie(20);

            Action action1 = () => new Dreieck(linieA1, linieB1, linieC1);

            Assert.ThrowsException<ArgumentException>(() => action1());


        }
        [TestMethod()]
        public void BerechneUmfangTest()
        {
            Linie linieA = new Linie(8);
            Linie linieB = new Linie(2);
            Linie linieC = new Linie(9);

            Dreieck dreieck = new Dreieck(linieA, linieB, linieC);

            Assert.AreEqual(19, dreieck.BerechneUmfang());


            
        }

        [TestMethod()]
        public void BerechneFlaecheTest()
        {
            Linie linieA = new Linie(8);
            Linie linieB = new Linie(2);
            Linie linieC = new Linie(9);

            Dreieck dreieck = new Dreieck(linieA, linieB, linieC);

            Assert.AreEqual(7.3101, dreieck.BerechneFlaeche(), 0.0001);
        }
    }
}