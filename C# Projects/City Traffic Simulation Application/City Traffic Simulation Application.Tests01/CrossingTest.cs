using System.Windows.Forms;
using System.Drawing;
// <copyright file="CrossingTest.cs">Copyright ©  2019</copyright>

using System;
using City_Traffic_Simulation_Application;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace City_Traffic_Simulation_Application.Tests
{
    [TestClass]
    [PexClass(typeof(Crossing))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CrossingTest
    {

        [PexMethod]
        public Crossing Constructor(
            Graphics gr,
            PictureBox box,
            int x,
            int y,
            ref Crossing[,] crossings
        )
        {
            Crossing target = new Crossing(gr, box, x, y, ref crossings);
            return target;
            // TODO: add assertions to method CrossingTest.Constructor(Graphics, PictureBox, Int32, Int32, Crossing[,]&)
        }
    }
}
