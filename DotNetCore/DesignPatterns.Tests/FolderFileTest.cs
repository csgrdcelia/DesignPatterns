using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolderFile;
using System.Collections.Generic;

namespace DesignPatterns
{
    [TestClass]
    public class FolderFileTest
    {
        [TestMethod]
        public void Should_folder_contains_one_element_when_gettings_contains()
        {
            var textFile = new File("data.txt");
            var parentFolder = new Folder("Parent Folder");
            parentFolder.Elements = new List<IElement>() { textFile };
            var containsNumber = parentFolder.GetContainsNumber();
            Assert.AreEqual(1, containsNumber);

        }

        [TestMethod]
        public void Should_folder_contains_three_elements_when_gettings_contains()
        {
            var folder = CreateFolderTree();

            var containsNumber = folder.GetContainsNumber();
            
            Assert.AreEqual(2, containsNumber);
        }

        private static Folder CreateFolderTree()
        {
            var textFile = new File("data.txt");
            var firstFolder = new Folder("Data Folder");
            var secondFolder = new Folder("Folder");
            var parentFolder = new Folder("Parent Folder");
            parentFolder.Elements = new List<IElement>() { textFile, firstFolder };

            return parentFolder;
        }
    }
}
