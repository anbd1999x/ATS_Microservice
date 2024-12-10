using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using NetCore.Core;
using NetCore.Models;
using SV.QTHT.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATS_QTHT_Service.AwsS3.Logic.ProcessAwsS3
{
    /// <summary>
    /// IDbProcessAwsS3Handler
    /// </summary>
    public interface IDbProcessAwsS3Handler
    {
        Task<Response<bool>> CheckConnection(ConnectASW3 param);
        Task<Response<bool>> CreateBucketAsync(MakeBucketASW3 param);
        Task<Response<List<S3Bucket>>> GetAllBucketAsync(ConnectASW3 param);
        Task<Response<bool>> DeleteBucketAsync(MakeBucketASW3 param);
        Task<Response<bool>> UploadFileAsync(UploadDataMinIOByIfromFile param);
        Task<Response<List<AwsS3DTO>>> GetAllFilesAsync(DonwloadObjectASW3 param);
        Task<Response<bool>> DeleteFileAsync(DonwloadObjectASW3 param);
        Response<string> DownloadFileWithTimeURL(DonwloadObjecASW3tURL param);
        Task<Response<bool>> UpLoadFileByStreamAWS3(UploadDataAWS3ByIStream data);
        Task<Response<bool>> UpLoadFileByPathAWS3(UploadDataAWS3ByPath data);
        Task<Response<bool>> CheckBucketExits(MakeBucketASW3 param);
        Task<Response<bool>> CheckFileExists(DonwloadObjectASW3 param);
        Task<Response<bool>> CheckBucketExistFileS3(MakeBucketASW3 param);
        Task<Response<bool>> RemoveBucketS3(DeleteBucketASW3 param);
    }
}
