﻿using Lib.helper;
using Lib.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.extension
{
    public static class DictExtension
    {
        /// <summary>
        /// 字典变url格式(a=1&b=3)
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static string ToUrlParam(this IDictionary<string, string> dict)
        {
            return Com.DictToUrlParams(dict.ToDictionary(x => x.Key, x => x.Value));
        }

        /// <summary>
        /// 把一个字典加入另一个字典，重复就覆盖
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="dict"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Dictionary<K, V> AddDict<K, V>(this Dictionary<K, V> dict, Dictionary<K, V> data)
        {
            foreach (var kv in data)
            {
                dict[kv.Key] = kv.Value;
            }
            return dict;
        }
    }
}
