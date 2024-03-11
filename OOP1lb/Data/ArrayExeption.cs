using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1lb.Data
{
    internal class ArrayExeption : ArgumentOutOfRangeException
    {

        public string Index;
        public ArrayExeption() : base() { }
        public ArrayExeption(string message) : base(message) { }

        public ArrayExeption(string message, string index) : base(message) { Index = index; }
        public ArrayExeption(string message, Exception innerException) : base(message, innerException) { }
    }
}
