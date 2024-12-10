using System;
using System.ComponentModel;

namespace NetCore.Logging.NLogCustom
{
    public enum LogSourceTypeEnums
    {
        [Description("SV.QTHT.API")]
        QTHT_API = 1,
        [Description("SV.QTHT.Service.System")]
        QTHT_Service_System = 2,
        [Description("SV.MinIO")]
        QTHT_MinIO = 3,
        [Description("SV.QTHT.Service.Ingest")]
        QTHT_Service_Ingest = 4,
        [Description("SV.QTHT.Service.AwsS3")]
        QTHT_Service_AwsS3 = 5,
        [Description("SV.QTHT.Service.Signature")]
        QTHT_Service_Signature = 6,
        [Description("SV.UserSynchronize.Worker")]
        Worker_User_Synchronize = 7,
        [Description("SV.QTHT.Service.ArchivalStorage")]
        QTHT_Service_ArchivalStorage = 8,
        [Description("SV.QTHT.Service.Access")]
        QTHT_Service_Access = 9,
        [Description("SV.QTHT.Service.FileSystem")]
        QTHT_Service_FileServer = 10,
        [Description("SV.QTHT.Service.NasSan")]
        QTHT_Service_NasSan = 11,
        [Description("SV.QTHT.Service.Obelisk")]
        QTHT_Service_Obelisk = 12,
        [Description("SV.QTHT.Service.PreservationPlanning")]
        QTHT_Service_PreservationPlanning = 13,
        [Description("SV.QTHT.Worker")]
        QTHT_Worker = 14,
        [Description("SV.QTHT.Service.Version")]
        QTHT_Service_Version = 15,
        [Description("SV.QTHT.Service.ProcessPdf")]
        QTHT_Service_ProcessPdf = 16,
        [Description("SV.QTHT.Service.OCR")]
        QTHT_OCR = 17,

    }

    public static class EnumConvert
    {
        public static string GetEnumDescription(Enum value)
        {
            try
            {
                var fi = value.GetType().GetField(value.ToString());

                var attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(
                        typeof(DescriptionAttribute),
                        false);
                return attributes?.Length > 0 ? attributes[0].Description : value.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
