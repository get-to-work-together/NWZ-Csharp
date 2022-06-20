using TemplateBuilderConsole.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInstantiateConstraint()
        {
            var constraint = new Constraint("01.PTV sd", null, 61.37, 0, 1, "qp");
            Assert.IsNotNull(constraint);
        }

        [TestMethod]
        public void TestMethodInstantiateMultipleConstraints()
        {
            InvoerData data = new InvoerData();
            data.constraints.Add(new Constraint("01.PTV sd", null, 61.37, 0, 1, "qp"));
            data.constraints.Add(new Constraint("01.PTV sd", null, 0.25, 2, 1, "o_q"));
            Assert.IsNotNull(data);
            Assert.AreEqual(2, data.constraints.Count);
        }
    }
}
