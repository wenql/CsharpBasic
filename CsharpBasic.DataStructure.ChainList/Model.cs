using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBasic.DataStructure.ChainList
{
    public class Model<T>
    {
        public T Data { get; set; }
        public Model<T> Next { get; set; }
    }
}
