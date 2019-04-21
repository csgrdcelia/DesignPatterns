using System.Runtime.InteropServices;
using System.Reflection;
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
            parentFolder.Add(textFile);
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

        [TestMethod]
        public void Should_link_reference_be_identical()
        {
            var file1 = new File("file 1");
            var file2 = new File("file 2");
            var linkToFile1 = new Link("link to file 1", file1);

            Assert.AreNotEqual(file1, file2);
            Assert.AreEqual(file1, linkToFile1.Element);
        }

        [TestMethod]
        public void Should_folder_contain_two_links()
        {
            var parentFolder = new Folder("parent folder");
            var file1 = new File("file 1");
            var folder1 = new Folder("folder 1");
            parentFolder.Add(new Link("link to file 1", file1));
            parentFolder.Add(new Link("link to folder 1", folder1));
            Assert.AreEqual(2, parentFolder.GetContainsNumber());
        }

        [TestMethod]
        public void Should_folder_not_contain_two_elements_with_same_name()
        {
            var parentFolder = new Folder("parent folder");
            var file1 = new File("file 1");
            var file2 = new File("file 1");
            
            parentFolder.Add(file1);
            Assert.ThrowsException<NameAlreadyExistsException>(() => parentFolder.Add(file2));
        }

        private static Folder CreateFolderTree()
        {
            var textFile = new File("data.txt");
            var firstFolder = new Folder("Data Folder");
            var secondFolder = new Folder("Folder");
            var parentFolder = new Folder("Parent Folder");
            parentFolder.Add(textFile);
            parentFolder.Add(firstFolder);

            return parentFolder;
        }
    }
}
