using Amazon.S3;
using Amazon.S3.Model;
using NetCore.Core.Utils;
using NetCore.Models;
using Serilog;
using SV.QTHT.Core;

namespace ATS_QTHT_Service.AwsS3.Logic.ProcessAwsS3
{
    ///<Summary>
    ///</Summary>
    public class DbProcessAwsS3Handler : IDbProcessAwsS3Handler
    {
        private readonly ILogger<DbProcessAwsS3Handler> _logger;
        private readonly string _hostAWSS3 = AppSettings.Instance.GetEnviromentVariable("AWSS3:ServiceURL");
        private readonly string _accessKeyAWSS3 = AppSettings.Instance.GetEnviromentVariable("AWSS3:accessKey");
        private readonly string _secretKeyAWSS3 = AppSettings.Instance.GetEnviromentVariable("AWSS3:secretKey");
        private readonly string _bucketAWSS3 = AppSettings.Instance.GetEnviromentVariable("AWSS3:bucket");
        private AmazonS3Client _s3Client { get; set; }

        /// <summary>
        /// DbProcessAwsS3Handler
        /// </summary>
        /// <param name="logger"></param>
        public DbProcessAwsS3Handler(ILogger<DbProcessAwsS3Handler> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Kiểm tra bucket đã tồn tại chưa
        /// </summary>
        public async Task<bool> CheckS3BucketExist(string bucketName)
        {
            var res = await _s3Client.ListBucketsAsync();
            if (res != null)
            {
                var listData = res.Buckets;
                var bucket = listData.Any(x => x.BucketName.Trim() == bucketName?.Trim());
                if (bucket)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Tạo bucket(Folder)
        /// </summary>
        public async Task<Response<bool>> CreateBucketAsync(MakeBucketASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);

                bool bucketExists = await CheckS3BucketExist(param.BucketName);
                if (bucketExists)
                {
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_EXITS, false);
                }
                else if (param.BucketName.Length < 3 || param.BucketName.Length > 61)
                {
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_NAME_EXITS, false);
                }
                else
                {
                    await _s3Client.PutBucketAsync(param.BucketName);
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, true);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }

        }
        /// <summary>
        /// CheckConnection
        /// </summary>
        public async Task<Response<bool>> CheckConnection(ConnectASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                var res = await _s3Client.ListBucketsAsync();
                return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.CONNECT_SUCCESS, true);
            }
            catch (Exception ex)
            {
                Log.Error(ex,"log 1 aThis is an informational message.");

                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }
        }

        /// <summary>
        /// Lấy toàn bộ bucket(Folder)
        /// </summary>
        public async Task<Response<List<S3Bucket>>> GetAllBucketAsync(ConnectASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                var res = await _s3Client.ListBucketsAsync();
                if (res != null)
                {
                    var listData = (List<S3Bucket>)res.Buckets;
                    return new Response<List<S3Bucket>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, listData, listData.Count);
                }
                return new Response<List<S3Bucket>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<List<S3Bucket>>(Constant.ErrorCode.FAIL_CODE, ex.Message, null);
            }
        }


        /// <summary>
        /// Lấy toàn bộ file trong bucket(Folder)
        /// </summary>
        public async Task<Response<List<AwsS3DTO>>> GetAllFilesAsync(DonwloadObjectASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                bool bucketExist = await CheckS3BucketExist(param.BucketName);
                if (!bucketExist)
                {
                    return new Response<List<AwsS3DTO>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_EXITS, null);
                }
                else
                {
                    var request = new ListObjectsV2Request()
                    {
                        BucketName = param.BucketName,
                        Prefix = param.ObjectName
                    };
                    var result = await _s3Client.ListObjectsV2Async(request);
                    var s3Objects = result.S3Objects.Select(s =>
                    {
                        var urlRequest = new GetPreSignedUrlRequest()
                        {
                            BucketName = param.BucketName,
                            Key = s.Key,
                            Expires = DateTime.UtcNow.AddMinutes(5)
                        };
                        return new AwsS3DTO()
                        {
                            Key = s.Key.ToString(),
                            PresignedUrl = _s3Client.GetPreSignedURL(urlRequest),
                        };
                    });
                    return new Response<List<AwsS3DTO>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, s3Objects.ToList());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<List<AwsS3DTO>>(Constant.ErrorCode.FAIL_CODE, ex.Message, null);
            }
        }

        /// <summary>
        /// upload file
        /// </summary>
        public async Task<Response<bool>> UploadFileAsync(UploadDataMinIOByIfromFile param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                bool bucketExist = await CheckS3BucketExist(param.BucketName);
                if (!bucketExist)
                {
                    var createBucketStatus = (await CreateBucketAsync(new MakeBucketASW3
                    {
                        AccessKey = strAccessKey,
                        Host = strHost,
                        SecretKey = strSecretKey,
                        BucketName = param.BucketName
                    })).Data;
                    if (!createBucketStatus)
                    {
                        return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_DONT_EXITS, true);
                    }
                }
                var requests = new PutObjectRequest()
                {
                    BucketName = param.BucketName,
                    Key = string.IsNullOrEmpty(param.ObjectName) ? param.File.FileName : param.ObjectName,
                    InputStream = param.File.OpenReadStream()
                };
                requests.Metadata.Add("Content-Type", param.File.ContentType);
                await _s3Client.PutObjectAsync(requests);
                return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }

        }

        /// <summary>
        /// upload file
        /// </summary>
        public async Task<Response<bool>> UpLoadFileByStreamAWS3(UploadDataAWS3ByIStream data)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(data.Host) ? _hostAWSS3 : data.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(data.AccessKey) ? _accessKeyAWSS3 : data.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(data.SecretKey) ? _secretKeyAWSS3 : data.SecretKey;
                data.BucketName = string.IsNullOrWhiteSpace(data.BucketName) ? _bucketAWSS3 : data.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                bool bucketExist = await CheckS3BucketExist(data.BucketName);
                if (!bucketExist)
                {
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_EXITS, true);
                }
                else
                {
                    var requests = new PutObjectRequest()
                    {
                        BucketName = data.BucketName,
                        Key = data.ObjectName,
                        InputStream = data.stream,
                    };
                    await _s3Client.PutObjectAsync(requests);
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, true);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }

        }

        public async Task<Response<bool>> UpLoadFileByPathAWS3(UploadDataAWS3ByPath data)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(data.Host) ? _hostAWSS3 : data.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(data.AccessKey) ? _accessKeyAWSS3 : data.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(data.SecretKey) ? _secretKeyAWSS3 : data.SecretKey;
                data.BucketName = string.IsNullOrWhiteSpace(data.BucketName) ? _bucketAWSS3 : data.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                bool bucketExist = await CheckS3BucketExist(data.BucketName);
                if (!bucketExist)
                {
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_EXITS, true);
                }
                else
                {
                    if (File.Exists(data.Path))
                    {
                        using (var stream = File.Open(data.Path, FileMode.Open)) {
                            var requests = new PutObjectRequest()
                            {
                                BucketName = data.BucketName,
                                Key = data.ObjectName,
                                InputStream = stream,
                            };
                            await _s3Client.PutObjectAsync(requests);
                            return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, true);
                        }
                    }
                    else
                    {
                        return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.FILE_DONT_EXIST_MESS, false);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }

        }

        /// <summary>
        /// Xóa bucket(Folder)
        /// </summary>
        public async Task<Response<bool>> DeleteBucketAsync(MakeBucketASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);

                await _s3Client.DeleteBucketAsync(param.BucketName);
                return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, true);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }
        }

        /// <summary>
        /// Xóa file trong bucket(Folder)
        /// </summary>
        public async Task<Response<bool>> DeleteFileAsync(DonwloadObjectASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                var bucketExists = await CheckS3BucketExist(param.BucketName);
                if (!bucketExists)
                {
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_EXITS, true);
                }
                else
                {
                    await _s3Client.DeleteObjectAsync(param.BucketName, param.ObjectName);
                    return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, true);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }
        }

        /// <summary>
        /// Tải xuống tệp có URL thời gian 
        /// </summary>
        public async Task<Response<string>> DownloadFileWithTimeURL(DonwloadObjecASW3tURL param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = param.BucketName,
                    Key = param.ObjectName,
                    Expires = DateTime.Now.AddSeconds(param.Expiration),
                };
                String url = _s3Client.GetPreSignedURL(request);
                return new  Response<string>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, url);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return new Response<string>(Constant.ErrorCode.FAIL_CODE, Constant.ErrorCode.FAIL_MESS, string.Empty);
            }
        }

        /// <summary>
        /// kiểm tra bucket(Folder) đã tồn tại chưa
        /// </summary>
        public async Task<Response<bool>> CheckBucketExits(MakeBucketASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                if (param.BucketName != null && param.BucketName != string.Empty)
                {
                    bool bucketExists = await CheckS3BucketExist(param.BucketName);
                    if (bucketExists)
                    {
                        return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.BUCKET_EXITS, true);
                    }
                }
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, Constant.ErrorCode.ERRORSYSTEM_MESS, false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }
        }

        /// <summary>
        /// kiểm tra bucket(Folder) đã tồn tại file chưa
        /// </summary>
        public async Task<Response<bool>> CheckFileExists(DonwloadObjectASW3 param)
        {
            string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
            string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
            string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
            param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
            AmazonS3Config config = new AmazonS3Config();
            config.ServiceURL = strHost;
            _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
            GetObjectMetadataRequest request = new GetObjectMetadataRequest()
            {
                BucketName = param.BucketName,
                Key = param.ObjectName,
            };
            try
            {
                await _s3Client.GetObjectMetadataAsync(request);
                return new Response<bool>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.FILE_EXITS, true);
            }
            catch (AmazonS3Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }
        }

        /// <summary>
        /// kiểm tra bucket(Folder) đã có file chưa
        /// </summary>
        public async Task<Response<bool>> CheckBucketExistFileS3(MakeBucketASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                param.BucketName = string.IsNullOrWhiteSpace(param.BucketName) ? _bucketAWSS3 : param.BucketName;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);

                ListObjectsRequest getObjArgs = new ListObjectsRequest()
                {
                    BucketName = param.BucketName,
                };
                var lstFile = await _s3Client.ListObjectsAsync(getObjArgs);
                bool exist = lstFile.S3Objects.Count() > 0 ? true : false;
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, Constant.ErrorCode.CHECK_BUCKET_EXITS_FILE, exist);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }

        }

        /// <summary>
        /// xóa bucket(Folder) đã chứa file
        /// </summary>
        public async Task<Response<bool>> RemoveBucketS3(DeleteBucketASW3 param)
        {
            try
            {
                string strHost = string.IsNullOrWhiteSpace(param.Host) ? _hostAWSS3 : param.Host;
                string strAccessKey = string.IsNullOrWhiteSpace(param.AccessKey) ? _accessKeyAWSS3 : param.AccessKey;
                string strSecretKey = string.IsNullOrWhiteSpace(param.SecretKey) ? _secretKeyAWSS3 : param.SecretKey;
                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = strHost;
                _s3Client = new AmazonS3Client(strAccessKey, strSecretKey, config);
                if (param.isDeleteObject)
                {
                    DeleteBucketRequest rmArgs = new DeleteBucketRequest()
                    {
                        BucketName = param.BucketName,
                    };
                    await _s3Client.DeleteBucketAsync(rmArgs);
                    return new Response<bool>(Constant.ErrorCode.FAIL_CODE, Constant.ErrorCode.SUCCESS_MESS, true);
                }
                await _s3Client.DeleteBucketAsync(param.BucketName);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, Constant.ErrorCode.FAIL_MESS, false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new Response<bool>(Constant.ErrorCode.FAIL_CODE, ex.Message, false);
            }

        }


    }
}
