using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.MalsagovUA.Sprint5.Task0.V27.Lib;
namespace Tyuiu.MalsagovUA.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.MalsagovUA.Sprint5\Tyuiu.MalsagovUA.Sprint5.Task0.V27\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
