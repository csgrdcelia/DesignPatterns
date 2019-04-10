using System;

namespace DataCompression
{
    public class EntropicCompressor : ICompressor
    {
        public string Compress(string data) 
        {
            return "Entropic";
        }
    }
}