﻿using System.Text.Json;

namespace NetCore.Logging.NLogCustom
{
    public class NlogMessageCustom
    {
        public string Messages { get; set; }
        public object[] Params { get; set; }

        public static string ObjectSerialize(string mesage, params object[] paramsObjects)
        {
            return JsonSerializer.Serialize(new
            { Messages = mesage, Params = paramsObjects });
        }
    }
}