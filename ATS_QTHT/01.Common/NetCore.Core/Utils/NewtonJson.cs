﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Core.Utils
{
    public class NewtonJson
    {
        private static readonly JsonSerializerSettings MicrosoftDateFormatSettings;

        static NewtonJson()
        {
            var settings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat
            };
            MicrosoftDateFormatSettings = settings;
        }
        /// <summary>
        /// Deserialize
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, MicrosoftDateFormatSettings);
        }
        /// <summary>
        /// Deserialize
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <param name="dateTimeFormat"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string jsonString, string dateTimeFormat)
        {
            var converters = new JsonConverter[1];
            var converter = new IsoDateTimeConverter
            {
                DateTimeFormat = dateTimeFormat
            };
            converters[0] = converter;
            return JsonConvert.DeserializeObject<T>(jsonString, converters);
        }
        /// <summary>
        /// DeserializeObject
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object DeserializeObject(string jsonString, Type type)
        {
            return JsonConvert.DeserializeObject(jsonString, type);
        }
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        public static string Serialize(object @object)
        {
            return JsonConvert.SerializeObject(@object, MicrosoftDateFormatSettings);
        }
        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="object"></param>
        /// <param name="dateTimeFormat"></param>
        /// <returns></returns>
        public static string Serialize(object @object, string dateTimeFormat)
        {

            var converters = new JsonConverter[1];
            var converter = new IsoDateTimeConverter
            {
                DateTimeFormat = dateTimeFormat
            };
            converters[0] = converter;
            return JsonConvert.SerializeObject(@object, converters);
        }
    }
}
