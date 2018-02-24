using System;
using System.Collections.Generic;
using System.Text;
namespace CsharpBasic.DataStructure.SeqList
{
    public static class Extension
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <returns></returns>
        public static Model<T> Init<T>(this Model<T> models)
        {
            models.Length = 0;
            return models;
        }

        /// <summary>
        /// 获取长度
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <returns></returns>
        public static int GetLenth<T>(this Model<T> models)
        {
            return models.Length;
        }

        /// <summary>
        /// 在头部插入
        /// 所有元素都要往后移动，时间复杂度为O(Length)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <param name="model"></param>
        public static bool InsertAtHead<T>(this Model<T> models, T model)
        {
            var length = models.GetLenth<T>();
            if (length > models.MaxSize) return false;
            //所有元素向后移动
            for (var i = length - 1; i >= 0; i--)
            {
                models.Data[i + 1] = models.Data[i];
            }

            models.Data[0] = model;
            models.Length++;
            return true;
        }

        /// <summary>
        /// 在末尾插入，时间复杂度为O(1)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool InsertAtEnd<T>(this Model<T> models, T model)
        {
            var length = models.GetLenth<T>();
            if (length > models.MaxSize) return false;
            models.Data[length] = model;
            models.Length++;
            return true;
        }

        /// <summary>
        /// 在指定位置插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <param name="n"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool InsertAt<T>(this Model<T> models, int n, T model)
        {
            var length = models.GetLenth<T>();
            if (length > models.MaxSize) return false;
            if (n < 1 || n > length + 1) return false;
            if (n == length)
            {
                models.Data[length] = model;
            }
            else
            {
                for (int i = length - 1; i >= n - 1; i--)
                {
                    models.Data[i + 1] = models.Data[i];
                }
                models.Data[n - 1] = model;
            }
            models.Length++;
            return true;
        }

        /// <summary>
        /// 删除指定位置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool Delete<T>(this Model<T> models, int n)
        {
            var length = models.GetLenth<T>();
            if (length > models.MaxSize) return false;
            if (n < 1 || n > length) return false;
            if (n < length)
            {
                for (int i = n; i < length; i++)
                {
                    models.Data[i - 1] = models.Data[i];
                }
            }
            models.Length--;
            return true;
        }

        /// <summary>
        /// 按关键字查找元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="W"></typeparam>
        /// <param name="models"></param>
        /// <param name="key"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static T GetByKey<T, W>(this Model<T> models, W key, Func<T, W> where) where W : IComparable
        {
            for (int i = 0; i < models.Length; i++)
            {
                //var f = where(models.Data[i]);
                //var o = where(models.Data[i]).CompareTo(key);
                if (where(models.Data[i]).CompareTo(key) == 0)
                {
                    return models.Data[i];
                }
            }
            return default(T);
        }
    }
}
