using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SearchEngine;
using System.IO;

namespace SearchEngine.UnitTesting
{
    [TestClass]
    public class Level1UnitTest
    {
        [TestMethod]
        public void PrintAllDrives_WithValidDrives_ShouldPrintStatus()
        {
            Level1 level1 = new Level1();
            DriveInfo[] drives = Level1.GetDrives();
            bool act = level1.PrintAllDrives(drives);
            Assert.AreEqual(true, act);            
        }
    }
    [TestClass]
    public class Level2UnitTest
    {
        [TestMethod]        
        public void SearchFile_WithInDrives_ShouldPrintLocation()
        {
            DriveInfo[] drives = Level1.GetDrives();
            int found = Level2.SearchFile("123.txt", drives);
            Assert.AreEqual(1, found);            
        }
        [TestMethod]      
        [ExpectedException(typeof(SearchEngine.FileNotFoundException))]
        public void SearchFile_WithInvalidFile_ShouldReturnZero()
        {
            DriveInfo[] drives = Level1.GetDrives();
            int found = Level2.SearchFile("32121.txt", drives);           
            Assert.AreEqual(0, found);
        }        
        [TestMethod]      
        public void CheckMethod_WithValidFileNameandPath_ShouldReturnTrue()
        {
            bool actual = Level2.check(@"C:\", "abc.txt");
            Assert.AreEqual(true, actual);
        }                
        [TestMethod]      
        public void CheckMethod_WithInValidFileNameandPath_ShouldReturnFalse()
        {
            bool actual = Level2.check(@"C:\", "abcd.txt");
            Assert.AreEqual(false, actual);
        }
    }
    [TestClass]
    public class Level3UnitTest
    {
        [TestMethod]
        public void SearchFile_WithInDrives_ShouldPrintLocationAndReturn1()
        {
            DriveInfo[] drives = Level1.GetDrives();
            int found = Level3.SearchByParallel("123.txt", drives);
            Assert.AreEqual(1, found);            
        }
        [TestMethod]       
        [ExpectedException(typeof(SearchEngine.FileNotFoundException))]
        public void SearchFile_WithInvalidFile_ShouldReturnZero()
        {
            DriveInfo[] drives = Level1.GetDrives();
            int found = Level3.SearchByParallel("32121.txt", drives);
            Assert.AreEqual(0, found);
        }
        [TestMethod]
        public void CheckMethod_WithValidFileNameandPath_ShouldReturnTrue()
        {
            bool actual = Level3.check(@"C:\", "abc.txt");
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void CheckMethod_WithInValidFileNameandPath_ShouldReturnFalse()
        {
            bool actual = Level3.check(@"C:\", "abcd.txt");
            Assert.AreEqual(false, actual);
        }
    }

    [TestClass]
    public class Level4UnitTest
    {
        [TestMethod]
        public void SearchFile_WithInputFileName_ShouldPrintLocationFromHistory()
        {
            bool found = Level4.SeachHistory("abc.txt");
            Assert.AreEqual(true, found);            
        }
        [TestMethod]
        public void SearchFile_WithInvalidInputFileName_ShouldReturnFalse()
        {
            bool found = Level4.SeachHistory("2131.txt");
            Assert.AreEqual(false, found);
        }       
        [TestMethod]
        public void StoreIntoFile_WithvalidInputFileNameandPath_ShouldReturntrue()
        {
            bool actual = Level4.StoreIntoFile(@"C:\", "xyz.txt");
            Assert.AreEqual(true, actual);
        }
    }
}
