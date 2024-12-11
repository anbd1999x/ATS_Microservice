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

}
