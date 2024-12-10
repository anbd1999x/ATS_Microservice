using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace NetCore.Core.Utils
{
    public class JSONObject
    {
        /// <summary>
        /// Hàm đọc câu query DB từ file JSON tương ứng
        /// </summary>
        /// <param name="fileName">Tên file JSON</param>
        /// <param name="subsystem">Tên phân hệ chức năng</param>
        /// <param name="sqlQuery">Câu query DB</param>
        /// <returns></returns>
        public static string GetQueryFromJSON(string fileName, string subsystem, string sqlQuery)
        {
            try
            {
                string queryString = "";
                var fileJson = File.ReadAllText(fileName);
                var json = JsonDocument.Parse(fileJson, new JsonDocumentOptions { CommentHandling = JsonCommentHandling.Skip });
                if (string.IsNullOrEmpty(subsystem))
                {
                    queryString = json.RootElement.GetProperty(sqlQuery).GetString();
                }
                else
                {
                    queryString = json.RootElement.GetProperty(subsystem).GetProperty(sqlQuery).GetString();
                }
                return queryString;
            }
            catch(Exception ex)
            {
                return "";
            }
        }
    }
}
