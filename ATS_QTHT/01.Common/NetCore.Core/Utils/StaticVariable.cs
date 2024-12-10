using System.Collections.Generic;
namespace NetCore.Core.Utils
{
    public static class StaticVariable
    {
        public static readonly int CacheType = AppSettings.Instance.GetInt32("Cache:Redis:UsingModeImplementation", 0);
        public static readonly int CacheDataExpireShortTime = AppSettings.Instance.GetInt32("Cache:Redis:Data:ShortTime", 30);
        public static readonly int CacheDataExpireMediumTime = AppSettings.Instance.GetInt32("Cache:Redis:Data:MediumTime", 60);
        public static readonly int CacheDataExpireLongTime = AppSettings.Instance.GetInt32("Cache:Redis:Data:LongTime", 180);
        public static readonly int CacheDataExpireOneDay = AppSettings.Instance.GetInt32("Cache:Redis:Data:OneDay", 1440);
        public static readonly string CachePrefix = AppSettings.Instance.GetString("Cache:Redis:PreCacheKey", "QTHT");
        public static readonly int LoginSessionExperidMinute = AppSettings.Instance.GetInt32("LoginSessionExperidMinute", 60);
        public static readonly Dictionary<string, string> EsConfig = AppSettings.Instance.Get<Dictionary<string, string>>("Elasticsearch");
        public static readonly Dictionary<string, string> WFConfig = AppSettings.Instance.Get<Dictionary<string, string>>("Workflow");
        public static readonly Dictionary<string, string> MdmConfig = AppSettings.Instance.Get<Dictionary<string, string>>("Mdm");
        public static readonly Dictionary<string, string> BackupDatabaseConfig = AppSettings.Instance.Get<Dictionary<string, string>>("AppSettings");
        public static readonly Dictionary<string, string> Wso2 = AppSettings.Instance.Get<Dictionary<string, string>>("Wso2");
        public static readonly Dictionary<string, string> KeyCloak = AppSettings.Instance.Get<Dictionary<string, string>>("KeyCloak");
    }
    public static class EsConfig
    {
        public static readonly string Url = StaticVariable.EsConfig["Url"];
        public static readonly string Type = StaticVariable.EsConfig["Type"];
        public static readonly string IndexDocument = StaticVariable.EsConfig["IndexDocument"];
        public static readonly string IndexRecord = StaticVariable.EsConfig["IndexRecord"];
        public static readonly bool Allow = StaticVariable.EsConfig["Allow"].ToBool();
        public static readonly int DateExtendToExpires = StaticVariable.EsConfig["DateExtendToExpires"].ToInt();
    }
    public static class WFConfig
    {
        public static readonly string ApiUrl = StaticVariable.WFConfig["ApiUrl"];
        public static readonly string WebUrl = StaticVariable.WFConfig["WebUrl"];
    }
    public static class MdmConfig
    {
        public static readonly string ApiUri = StaticVariable.MdmConfig["ApiUri"];
        public static readonly string ApplicationId = StaticVariable.MdmConfig["ApplicationId"];
        public static readonly string MdmUserId = StaticVariable.MdmConfig["MdmUserId"];
        public static readonly string Authorization = StaticVariable.MdmConfig["Authorization"];
        public static readonly string FolderMdmUpload = StaticVariable.MdmConfig["FolderMdmUpload"];
        public static readonly string UploadFileUrl = StaticVariable.MdmConfig["UploadFileUrl"];
        public static readonly string GetFileByNodeId = StaticVariable.MdmConfig["GetFileByNodeId"];
        public static readonly string DownloadFileByNodeId = StaticVariable.MdmConfig["DownloadFileByNodeId"];
        public static readonly string DeleteFileByNodeId = StaticVariable.MdmConfig["DeleteFileByNodeId"];
        public static readonly string IdentityName = StaticVariable.MdmConfig["IdentityName"];
        public static readonly string IdentitySercet = StaticVariable.MdmConfig["IdentitySercet"];
        public static readonly string FoldRootPath = StaticVariable.MdmConfig["FoldRootPath"];
        public static readonly string MoveNodeApi = StaticVariable.MdmConfig["MoveNodeApi"];
    }
    public static class BackupDatabaseConfig
    {
        public static readonly string FolderPath = StaticVariable.BackupDatabaseConfig["FolderPath"];
        public static readonly string RestoreHistory = StaticVariable.BackupDatabaseConfig["RestoreHistory"];
        public static readonly string RootPath = StaticVariable.BackupDatabaseConfig["RootPath"];
    }
    public static class Wso2Config
    {
        public static readonly string GetInfoUser = StaticVariable.Wso2["GetInfoUser"];
        public static readonly string CreateUser = StaticVariable.Wso2["CreateUser"];
        public static readonly string UpdateUser = StaticVariable.Wso2["UpdateUser"];
        public static readonly string DeleteUser = StaticVariable.Wso2["DeleteUser"];
        public static readonly string ChangePassword = StaticVariable.Wso2["ChangePassword"];
    }
    public static class KeyCloakConfig
    {
        public static readonly string GetInfoUser = StaticVariable.KeyCloak["GetInfoUser"];
        public static readonly string CreateUser = StaticVariable.KeyCloak["CreateUser"];
        public static readonly string UpdateUser = StaticVariable.KeyCloak["UpdateUser"];
        public static readonly string DeleteUser = StaticVariable.KeyCloak["DeleteUser"];
        public static readonly string ChangePassword = StaticVariable.KeyCloak["ChangePassword"];
    }
}
