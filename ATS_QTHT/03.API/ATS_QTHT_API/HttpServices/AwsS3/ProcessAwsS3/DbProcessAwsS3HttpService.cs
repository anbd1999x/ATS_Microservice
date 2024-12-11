
using Amazon.S3;
using Amazon.S3.Model;
using Confluent.Kafka;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NetCore.Core.Helper;
using NetCore.Core.Utils;
using NetCore.Models;
using SV.QTHT.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ATS_QTHT_API.HttpServices.AwsS3.ProcessAwsS3
{
    ///<Summary>
    ///</Summary>
    public class DbProcessAwsS3HttpService : IDbProcessAwsS3HttpService
    {
        private HttpClient _client;
        private IHttpHelper _httpHelper;
        private IHttpContextAccessor _httpContextAccessor;

        ///<Summary>
        ///</Summary>
        public DbProcessAwsS3HttpService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
            _httpHelper = new HttpHelper(_client, _httpContextAccessor);
        }

        /// <summary>
        /// Kiểm tra bucket đã tồn tại chưa
        /// </summary>
        public async Task<bool> CheckS3BucketExist(string bucketName)
        {
            return await _httpHelper.GetAsync<bool>($"ProcessAwsS3/CheckS3BucketExist");

        }

        /// <summary>
        /// Tạo bucket(Folder)
        /// </summary>
        public async Task<Response<bool>> CreateBucketAsync(MakeBucketASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/CreateBucketAsync");

        }
        /// <summary>
        /// CheckConnection
        /// </summary>
        public async Task<Response<bool>> CheckConnection(ConnectASW3 param)
        {
            return await _httpHelper.PostAsync<Response<bool>>($"ProcessAwsS3/CheckConnection", param);
        }

        /// <summary>
        /// Lấy toàn bộ bucket(Folder)
        /// </summary>
        public async Task<Response<List<S3Bucket>>> GetAllBucketAsync(ConnectASW3 param)
        {
            return await _httpHelper.GetAsync<Response<List<S3Bucket>>>($"ProcessAwsS3/GetAllBucketAsync");
        }


        /// <summary>
        /// Lấy toàn bộ file trong bucket(Folder)
        /// </summary>
        public async Task<Response<List<AwsS3DTO>>> GetAllFilesAsync(DonwloadObjectASW3 param)
        {
            return await _httpHelper.GetAsync<Response<List<AwsS3DTO>>>($"ProcessAwsS3/GetAllFilesAsync");
        }

        /// <summary>
        /// upload file
        /// </summary>
        public async Task<Response<bool>> UploadFileAsync(UploadDataMinIOByIfromFile param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/UploadFileAsync");
        }

        /// <summary>
        /// upload file
        /// </summary>
        public async Task<Response<bool>> UpLoadFileByStreamAWS3(UploadDataAWS3ByIStream data)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/UpLoadFileByStreamAWS3");
        }

        public async Task<Response<bool>> UpLoadFileByPathAWS3(UploadDataAWS3ByPath data)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/UpLoadFileByPathAWS3");

        }

        /// <summary>
        /// Xóa bucket(Folder)
        /// </summary>
        public async Task<Response<bool>> DeleteBucketAsync(MakeBucketASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/DeleteBucketAsync");
        }

        /// <summary>
        /// Xóa file trong bucket(Folder)
        /// </summary>
        public async Task<Response<bool>> DeleteFileAsync(DonwloadObjectASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/DeleteFileAsync");
        }

        /// <summary>
        /// Tải xuống tệp có URL thời gian 
        /// </summary>
        public async Task<Response<string>> DownloadFileWithTimeURL(DonwloadObjecASW3tURL param)
        {
            return await _httpHelper.GetAsync<Response<string>>($"ProcessAwsS3/DownloadFileWithTimeURL");

        }

        /// <summary>
        /// kiểm tra bucket(Folder) đã tồn tại chưa
        /// </summary>
        public async Task<Response<bool>> CheckBucketExits(MakeBucketASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/CheckBucketExits");

        }

        /// <summary>
        /// kiểm tra bucket(Folder) đã tồn tại file chưa
        /// </summary>
        public async Task<Response<bool>> CheckFileExists(DonwloadObjectASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/CheckFileExists");

        }

        /// <summary>
        /// kiểm tra bucket(Folder) đã có file chưa
        /// </summary>
        public async Task<Response<bool>> CheckBucketExistFileS3(MakeBucketASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/CheckFileExists");


        }
        /// <summary>
        /// xóa bucket(Folder) đã chứa file
        /// </summary>
        public async Task<Response<bool>> RemoveBucketS3(DeleteBucketASW3 param)
        {
            return await _httpHelper.GetAsync<Response<bool>>($"ProcessAwsS3/RemoveBucketS3");

        }

    }
}
