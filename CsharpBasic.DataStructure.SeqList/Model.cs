using System;
using System.Collections.Generic;
using System.Text;
using CsharpBasic.Utilities;

namespace CsharpBasic.DataStructure.SeqList
{
    public class Model<T>
    {
        private const int _maxSize = 100;

        /// <summary>
        /// 表支持最大长度
        /// </summary>
        public int MaxSize => _maxSize;

        /// <summary>
        /// 表长度
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public T[] Data { get; set; }

        public override string ToString()
        {
            var str = new StringBuilder();
            for (var i = 0; i < this.Length; i++)
            {
                str.Append(Helpers.GetProperties<T>(this.Data[i]).TrimEnd(',')).Append(";");
            }

            return str.ToString();
        }

        /// <summary>
        /// 构造
        /// </summary>
        public Model()
        {
            this.Length = 0;
            this.Data = new T[_maxSize];
        }
    }
}
