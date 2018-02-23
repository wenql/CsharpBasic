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
        public static bool InsertToHead<T>(this Model<T> models, T model)
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
        public static bool InsertToEnd<T>(this Model<T> models, T model)
        {
            var length = models.GetLenth<T>();
            if (length > models.MaxSize) return false;
            models.Data[length] = model;
            models.Length++;
            return true;
        }
    }
}
