using System;
using CsharpBasic.Models;

namespace CsharpBasic.DataStructure.SeqList
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Model<User>();

            data.Init<User>();
            Console.WriteLine("初始化后顺序表的长度为：{0}", data.GetLenth<User>());

            var flag = data.InsertToHead<User>(new User { UserId = 1, UserName = "张三", Sex = 1 });
            Console.WriteLine("在头部插入：{0}", flag ? string.Format("成功，插入后：{0}",data.ToString()) : "失败");

            flag = data.InsertToEnd<User>(new User { UserId = 2, UserName = "李四", Sex = 1 });
            Console.WriteLine("在末尾插入：{0}", flag ? string.Format("成功，插入后：{0}", data.ToString()) : "失败");
        }
    }
}
