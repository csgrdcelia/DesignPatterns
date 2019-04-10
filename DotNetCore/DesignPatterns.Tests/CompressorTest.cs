using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCompression;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class CompressorTest
    {
        [TestMethod]
        public void Should_compress_by_dictionary()
        {
            ByDictionaryCompressor compressor = new ByDictionaryCompressor();
            Context context = new Context(compressor);
            Assert.AreEqual("bydictionnary", context.Compress("test"));

        }

        [TestMethod]
        public void Should_compress_repetition()
        {
            RepetitionCompressor compressor = new RepetitionCompressor();
            Context context = new Context(compressor);
            Assert.AreEqual("Repetition", context.Compress("test"));
        }

        [TestMethod]
        public void Should_compress_entropic()
        {
            EntropicCompressor compressor = new EntropicCompressor();
            Context context = new Context(compressor);
            Assert.AreEqual("Entropic", context.Compress("test"));
        }
    }
}
