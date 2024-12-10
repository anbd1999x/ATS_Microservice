using Newtonsoft.Json;
using NetCore.Core.Utils;
using System;

namespace SV.QTHT.Core
{
    [Serializable]
    public class ResponseList<T>
    {
        public T[] Data { get; set; }
        public int TotalCount { get; set; }
        public int DataCount { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
    [Serializable]
    public class ResponseObj<T>
    {
        public T Data { get; set; }
        public int TotalCount { get; set; }
        public int DataCount { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
    [Serializable]
    public class Response<T> : Response
    {
        public T Data { get; set; }

        public int TotalCount { get; set; }

        public int DataCount { get; set; }

        public int TotalPage { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        [JsonConstructor]
        public Response(int status, string message = null, T data = default(T), int dataCount = 0, int totalCount = 0, int totalPage = 0, int pageNumber = 0, int pageSize = Constant.DEFAULT_PAGE_SIZE)
            : base(status, message)
        {
            Data = data;
            TotalCount = totalCount;
            DataCount = dataCount;
            TotalPage = totalPage;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    [Serializable]
    public class Response
    {
        public int Status { get; set; }

        public string Message { get; set; }

        public Response(int status, string message = null)
        {
            Status = status;
            Message = message;
        }
    }
}