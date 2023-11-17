using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.MalsagovUA.Sprint5.Task3.V26.Lib;
namespace Tyuiu.MalsagovUA.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.MalsagovUA.Sprint5\Tyuiu.MalsagovUA.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
