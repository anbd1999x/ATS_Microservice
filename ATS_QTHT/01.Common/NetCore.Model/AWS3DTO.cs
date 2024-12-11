using Microsoft.AspNetCore.Http;
namespace NetCore.Models
{
    public class Connect
    {
        public string Host { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
    }
    public class UploadDataAWS3ByIfromFile : Connect
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }
        public IFormFile File { get; set; }
    }
    public class UploadDataAWS3ByIStream : Connect
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }
        public Stream stream { get; set; }
    }
    public class UploadDataAWS3ByPath : Connect
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }
        public string Path { get; set; }
    }
    public class UploadDataMinIOByIfromFile : Connect
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }
        public bool IsSSL { get; set; }
        public IFormFile File { get; set; }
    }
    public class UploadDataMinIOByPath : Connect
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }
        public bool IsSSL { get; set; }
        public string Path { get; set; }
    }
    public class UploadDataMinIOByIStream : Connect
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }
        public bool IsSSL { get; set; }
        public Stream stream { get; set; }
    }
    /// <summary>
    /// MINIO
    /// </summary>
    public class ConnectMinIO : Connect
    {
        public bool IsSSL { get; set; }
    }
    public class MakeBucketMinIO : ConnectMinIO
    {
        public string BucketName { get; set; }
    }
    public class DeleteBucketMinIO : MakeBucketMinIO
    {
        public bool isDeleteObject { get; set; }
    }
    public class DonwloadObjectMinIO : MakeBucketMinIO
    {
        public string ObjectName { get; set; }
    }
    public class ReStoreFileMinIO : DonwloadObjectMinIO
    {
        public string PathFileServer { get; set; }
    }
    public class DonwloadObjecMinIOtURL : DonwloadObjectMinIO
    {
        public int Expiration { get; set; }
    }
    /// <summary>
    /// AwsS3DTO
    /// </summary>
    public class AwsS3DTO
    {
        public string? Key { get; set; }
        public string? PresignedUrl { get; set; }
    }

    /// <summary>
    /// ASW3
    /// </summary>

    public class ConnectASW3 : Connect
    {
    }
    public class MakeBucketASW3 : ConnectASW3
    {
        public string BucketName { get; set; }
    }
    public class DeleteBucketASW3 : MakeBucketASW3
    {
        public bool isDeleteObject { get; set; }
    }
    public class DonwloadObjectASW3 : MakeBucketASW3
    {
        public string ObjectName { get; set; }
    }
    public class ReStoreFileASW3 : DonwloadObjectASW3
    {
        public string PathFileServer { get; set; }
    }
    public class DonwloadObjecASW3tURL : DonwloadObjectASW3
    {
        public int Expiration { get; set; }
    }
}
