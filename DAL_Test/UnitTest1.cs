using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrazyTechGuys.Filetables.DAL;

namespace CrazyTechGuys.Filetables.DAL_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TemosArquivosNoFileTables()
        {
            var dal = new GenericDAL();

            var qtdArquivos = dal.ListFiles().Count;

            Assert.IsTrue(qtdArquivos > 0);

        }
    }
}
