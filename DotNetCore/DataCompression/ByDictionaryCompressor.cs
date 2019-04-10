using System;

namespace DataCompression
{
    public class ByDictionaryCompressor : ICompressor
    {
        public string Compress(string data) 
        {
            return "bydictionnary";
        }
    }
}