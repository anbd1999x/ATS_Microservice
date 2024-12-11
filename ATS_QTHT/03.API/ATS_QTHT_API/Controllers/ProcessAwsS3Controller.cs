using Amazon.S3.Model;
using Microsoft.AspNetCore.Mvc;
using SV.QTHT.Core;
using NetCore.Core.Utils;
using NetCore.Models;
using ATS_QTHT_Service.AwsS3.Logic.ProcessAwsS3;
using NetCore.Core.Caching.Interface;
using System.ComponentModel;

namespace ATS_QTHT_API.Controllers
{
    /// <summary>
    /// <ControllerDes>Quản lý AwsS3</ControllerDes>
    /// <ControllerName>ProcessAwsS3Controller</ControllerName>
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [Description("Nhóm chức năng xử lý file trên AWS3")]

    public class ProcessAwsS3Controller : ControllerBase
    {

        private readonly ILogger<ProcessAwsS3Controller> _logger;
        private readonly IDbProcessAwsS3HttpService _dbProcessAwsS3Handler;
        private readonly ICached _cached;

        /// <summary>
        /// </summary>
        public ProcessAwsS3Controller(ILogger<ProcessAwsS3Controller> logger, IDbProcessAwsS3HttpService dbProcessAwsS3Handler, ICached cached)
        {
            _logger = logger;
            _dbProcessAwsS3Handler = dbProcessAwsS3Handler;
            _cached = cached;
        }
        /// <summary>
        /// kiểm tra kết nôi vơi s3
        /// </summary>
        /// <param name="param"></param>
        /// <action>CHECK</action>
        [HttpPost]
        public async Task<Response<bool>> CheckConnection(ConnectASW3 param)
        {

            try
            {
                var res = await _cached.GetAsync<ConnectASW3>("ATS");
                await _cached.AddAsync("ATS", param, 10);
                var res2 = await _cached.GetAsync<ConnectASW3>("ATS");
                return await _dbProcessAwsS3Handler.CheckConnection(param);
            }
            catch (Exception ex)
            {

                throw;
            }
          

        }
        /// <summary>
        /// Tạo bucket(Folder)
        /// </summary>
        /// <param name="param"></param>
        /// <action>CREATE</action>

        [HttpPost]
        public async Task<Response<bool>> CreateBucketAsync(MakeBucketASW3 param)
        {
            return await _dbProcessAwsS3Handler.CreateBucketAsync(param);
            
        }

        /// <summary>
        /// Lấy toàn bộ bucket(Folder)
        /// </summary>
        /// <param name="param"></param>
        /// <action>VIEW</action>

        [HttpPost]
        public async Task<Response<List<S3Bucket>>> GetAllBucketAsync(ConnectASW3 param)
        {
            return await _dbProcessAwsS3Handler.GetAllBucketAsync(param);
        }

        /// <summary>
        /// Lấy toàn bộ file trong bucket(Folder)
        /// </summary>
        /// <param name="param"></param>
        /// <action>VIEW</action>

        [HttpPost]
        public async Task<Response<List<AwsS3DTO>>> GetAllFilesAsync(DonwloadObjectASW3 param)
        {
            return await _dbProcessAwsS3Handler.GetAllFilesAsync(param);
        }

        /// <summary>
        /// Tải file vào bucket(Folder)
        /// </summary>
        /// <param name="data"></param>
        /// <action>UPDATE</action>
        [HttpPost]
        [RequestSizeLimit(Constant.REQUEST_MAX_SIZE)]
        public async Task<Response<bool>> UploadFileAsync([FromForm] UploadDataMinIOByIfromFile data)
        {
            return await _dbProcessAwsS3Handler.UploadFileAsync(data);
        }


        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="data"></param>
        /// <action>UPDATE</action>
        [HttpPost]
        [RequestSizeLimit(Constant.REQUEST_MAX_SIZE)]
        public async Task<Response<bool>> UpLoadFileByStreamAWS3([FromForm] UploadDataAWS3ByIStream data)
        {
            return await _dbProcessAwsS3Handler.UpLoadFileByStreamAWS3(data);
        }
        /// <summary>
        /// upload file bằng đường dẫn
        /// </summary>
        /// <param name="data"></param>
        /// <action>UPDATE</action>
        [HttpPost]
        [RequestSizeLimit(Constant.REQUEST_MAX_SIZE)]
        public async Task<Response<bool>> UpLoadFileByPathAWS3(UploadDataAWS3ByPath data)
        {
            return await _dbProcessAwsS3Handler.UpLoadFileByPathAWS3(data);
        }

        /// <summary>
        /// Xóa bucket(Folder)
        /// </summary>
        /// <param name="param"></param>
        /// <action>DELETE</action>

        [HttpPost]
        public async Task<Response<bool>> DeleteBucketAsync(MakeBucketASW3 param)
        {
            return await _dbProcessAwsS3Handler.DeleteBucketAsync(param);
        }

        /// <summary>
        /// Xóa file trong bucket(Folder)
        /// </summary>
        /// <param name="param"></param>
        /// <action>DELETE</action>
        [HttpPost]
        [RequestSizeLimit(Constant.REQUEST_MAX_SIZE)]
        public async Task<Response<bool>> DeleteFileAsync(DonwloadObjectASW3 param)
        {
            return await _dbProcessAwsS3Handler.DeleteFileAsync(param);
        }

        /// <summary>
        /// tính theo giây, nếu trong thời gian link không được sử dụng thì sẽ bị vô hiệu hóa
        /// </summary>
        /// <param name="param"></param>
        /// <action>DOWNLOAD</action>
        [HttpPost]
        public async Task<Response<string>> DownloadFileWithTimeURL(DonwloadObjecASW3tURL param)
        {
            return await _dbProcessAwsS3Handler.DownloadFileWithTimeURL(param);
        }

        /// <summary>
        /// Check Bucket Exits
        /// </summary>
        /// <param name="param"></param>
        /// <action>CHECK</action>
        [HttpPost]
        public async Task<Response<bool>> CheckBucketExits(MakeBucketASW3 param)
        {
            return await _dbProcessAwsS3Handler.CheckBucketExits(param);
        }

        /// <summary>
        ///  Check File Exits
        /// </summary>
        /// <param name="param"></param>
        /// <action>CHECK</action>
        [HttpPost]
        public async Task<Response<bool>> CheckFileExists(DonwloadObjectASW3 param)
        {
            return await _dbProcessAwsS3Handler.CheckFileExists(param);
        }

        /// <summary>
        /// Check Bucket Exist File
        /// </summary>
        /// <param name="param"></param>
        /// <action>CHECK</action>
        [HttpPost]
        public async Task<Response<bool>> CheckBucketExistFileS3(MakeBucketASW3 param)
        {
            return await _dbProcessAwsS3Handler.CheckBucketExistFileS3(param);
        }

        /// <summary>
        /// Xóa bucket(Folder)
        /// </summary>
        /// <param name="param"></param>
        /// <action>DELETE</action>
        [HttpPost]
        public async Task<Response<bool>> RemoveBucketS3(DeleteBucketASW3 param)
        {
            return await _dbProcessAwsS3Handler.RemoveBucketS3(param);
        }

    }
}
