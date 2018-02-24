using System;
using CsharpBasic.Models;
using CsharpBasic.Utilities;

namespace CsharpBasic.DataStructure.SeqList
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Model<User>();

            data.Init<User>();
            Console.WriteLine("初始化后顺序表的长度为：{0}", data.GetLenth<User>());

            var flag = data.InsertAtHead<User>(new User { UserId = 1, UserName = "张三", Sex = 1 });
            Console.WriteLine("在头部插入：{0}", flag ? string.Format("成功，插入后：{0}", data.ToString()) : "失败");

            flag = data.InsertAtEnd<User>(new User { UserId = 2, UserName = "李四", Sex = 1 });
            Console.WriteLine("在末尾插入：{0}", flag ? string.Format("成功，插入后：{0}", data.ToString()) : "失败");

            flag = data.InsertAt<User>(1, new User { UserId = 3, UserName = "王五", Sex = 1 });
            Console.WriteLine("在第一个位置插入：{0}", flag ? string.Format("成功，插入后：{0}", data.ToString()) : "失败");

            flag = data.Delete<User>(2);
            Console.WriteLine("删除第二个：{0}", flag ? string.Format("成功，删除后：{0}", data.ToString()) : "失败");

            var t = data.GetByKey<User, string>("王五", p => p.UserName);
            Console.WriteLine("查找王五：{0}", Helpers.GetProperties<User>(t));

            t = data.GetByKey<User, int>(2, p => p.UserId);
            Console.WriteLine("查找UserId=2：{0}", Helpers.GetProperties<User>(t));
        }
    }
}
