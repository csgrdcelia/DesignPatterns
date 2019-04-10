using System;

namespace DataCompression
{
    public class RepetitionCompressor : ICompressor
    {
        public string Compress(string data) 
        {
            return "Repetition";
        }
    }
}