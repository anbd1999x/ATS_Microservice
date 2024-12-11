using Newtonsoft.Json;

namespace NetCore.Core.Utils
{
    public class Constant
    {
        public const int REQUEST_MAX_SIZE = 1024000000;
        public const string USER_SESSION = "Session";
        public const string USER_NAVIGATION_CACHE = "Navigation:User";
        public const string USER_PERMISSION_CACHE = "Permission:User";
        public const string USER_LOGIN = "USER_LOGIN";
        public const string DASHBOARD = "DASHBOARD";
        public const string MONTH = "MONTH";
        public const string YEAR = "YEAR";
        public const string QUARTER = "QUARTER";

        public static JsonSerializerSettings SETTING = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        public const bool BOOL_SUCCESS = true;
        public const bool BOOL_ERROR = false;

        public const int STATUS_OK = 1;
        public const int STATUS_NOTOK = 0;

        public const int STATUS_ACTIVE = 1;
        public const int STATUS_DEACTIVE = 0;

        public const int StatusModifiedEnable = 1;
        public const int StatusModifiedDisable = 0;
        public const int StatusLock = 1;
        public const int StatusUnLock = 0;
        public const int StatusEnable = 1;
        public const int StatusDisable = 0;
        public const int StatusDeleted = -1;
        public const int StatusCommentEnable = 1;
        public const int StatusCommentDisable = 0;
        public const int SUCCESS = 1;
        public const int ERROR = -1;
        public const int NODATA = 0;
        public const int DATA_IS_EXIST = 2;
        public const int DEFAULT_PAGE_SIZE = 20;
        public const int STATUS_SUCCESS = 1;
        public const string DEFAULT_PASSWORD = "123456aA@";
        public class HttpStatusCode
        {
            public const int UN_AUTHORIZED = 401;
            public const int BAD_REQUEST = 400;
            public const int SUCCESS = 200;
            public const int CREATED = 201;
            public const int FORBIDDEN = 403;
            public const int NOT_FOUND = 404;
            public const int METHOD_NOT_ALLOWED = 405;
            public const int CONFLICT = 409;
            public const int SERVER_ERROR = 500;
        }
        public class AppSettingOCR
        {
            public const string FolderPathURL = "OCR:FolderPathURL";
            public const string StoragePath = "OCR:StoragePath";
        }
        public class HttpServiceUrl
        {
            public const string CRM = "ServiceUrls:CRMHttpServiceUrl";
            public const string AwS3 = "ServiceUrls:AwS3HttpServiceUrl";

        }

        public class DatabaseType
        {
            public const string MSSQL = "MSSQL";
            public const string POSTGRESQL = "PostgreSQL";
            public const string ORACLE = "Oracle";
            public const string MYSQL = "MySql";
            public const string SQLITE = "Sqlite";
        }
        public class BackupFolder
        {
            public const string DB_BACKUP = "db_backup";
            public const string Files = "files_backup";
            public const string All = "all_backup";
        }
        public class ErrorCode
        {
            #region: Mã lỗi
            /// <summary>
            /// Thành công
            /// </summary>
            public const int SUCCESS_CODE = 1;
            /// <summary>
            /// Không tìm thấy bản ghi
            /// </summary>
            public const int NOTFOUND_CODE = 0;
            /// <summary>
            /// Bản ghi đang được sử dụng, không xóa được
            /// </summary>
            public const int NOTDEL_CASE_1_CODE = 1002;
            /// <summary>
            /// Bản ghi chứa bản ghi con, không xóa được
            /// </summary>
            public const int NOTDEL_CASE_2_CODE = 1003;
            /// <summary>
            /// Lỗi hệ thống
            /// </summary>
            public const int ERRORSYSTEM_CODE = 1004;
            /// <summary>
            /// Dữ liệu bị trùng tên
            /// </summary>
            public const int DUPPLICATE_CODE = 1006;

            /// <summary>
            /// Tên đã tồn tại
            /// </summary>
            public const int DUPPLICATE_NAME = 1007;

            /// <summary>
            /// Email đã tồn tại
            /// </summary>
            public const int DUPPLICATE_EMAIL = 1008;

            /// <summary>
            /// Mã quyền đã tồn tại trên hệ thống
            /// </summary>
            public const int DUPPLICATE_ROLE_CODE = 1009;

            /// <summary>
            /// Mã pronom đã tồn tại trên hệ thống
            /// </summary>
            public const int DUPPLICATE_PRONOM_ID = 1010;

            /// <summary>
            /// Giá trị đã tồn tại trên hệ thống
            /// </summary>
            public const int DUPPLICATE_VALUE = 1011;

            /// <summary>
            /// Thất bại
            /// </summary>
            public const int FAIL_CODE = -1;

            /// <summary>
            /// Mobile đã tồn tại
            /// </summary>
            public const int DUPPLICATE_MOBILE = 1010;

            /// <summary>
            /// Folder không tồn tại
            /// </summary>
            public const int FOLDER_DONT_EXIST = 1011;

            /// <summary>
            /// Folder đã tồn tại
            /// </summary>
            public const int FOLDER_SUCCESS = 1012;

            /// <summary>
            /// File không tồn tại
            /// </summary>
            public const int FILE_DONT_EXIST = 1013;
            /// <summary>
            /// Mã CTS đã tồn tại
            /// </summary>
            public const int DUPPLICATE_CERT_CODE = 1014;
            /// <summary>
            /// tên trong cùng 1 nhóm đã tồn tại
            /// </summary>
            public const int DUPPLICATE_NAME_IN_GROUP = 1015;
            /// <summary>
            /// mã trong cùng 1 nhóm đã tồn tại
            /// </summary>
            public const int DUPPLICATE_CODE_IN_GROUP = 1016;
            /// <summary>
            /// mã trong cùng 1 nhóm đã tồn tại
            /// </summary>
            public const int DUPPLICATE_NAME_AND_PROTOCOL = 1017;

            #endregion

            #region: Message lỗi
            /// <summary>
            /// Thành công
            /// </summary>
            public const string CONNECT_SUCCESS = "Kết nối thành công ";
            /// <summary>
            /// cập nhật không thành công
            /// </summary>
            public const string UPDATE_NOT_SUCCESS_MESS = "Cập nhật không thành công";
            /// <summary>
            /// Thành công
            /// </summary>
            public const string SUCCESS_MESS = "Thành công";
            /// <summary>
            /// Không tìm thấy bản ghi
            /// </summary>
            public const string NOTFOUND_MESS = "Không tìm thấy bản ghi";
            /// <summary>
            /// Bản ghi đang được sử dụng, không xóa được
            /// </summary>
            public const string NOTDEL_CASE_1_MESS = "Bản ghi đang được sử dụng, không xóa được";
            /// <summary>
            /// Bản ghi chứa bản ghi con, không xóa được
            /// </summary>
            public const string NOTDEL_CASE_2_MESS = "Bản ghi chứa bản ghi con, không xóa được";
            /// <summary>
            /// Lỗi hệ thống
            /// </summary>
            public const string ERRORSYSTEM_MESS = "Lỗi hệ thống";
            /// <summary>
            /// Dữ liệu bị trùng tên
            /// </summary>
            public const string DUPPLICATE_CODE_MESS = "Dữ liệu bị trùng tên";

            /// <summary>
            /// Tên đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_NAME_MESS = "Tên đã tồn tại trên hệ thống";

            /// <summary>
            /// Tên đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_USERNAME_MESS = "Tên đăng nhập đã tồn tại trên hệ thống";

            /// <summary>
            /// Giá trị đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_VALUE_MESS = "Giá trị đã tồn tại trên hệ thống";

            /// <summary>
            /// Email đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_EMAIL_MESS = "Email đã tồn tại trên hệ thống";

            /// <summary>
            /// Mobile đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_MOBILE_MESS = "Số điện thoại đã tồn tại trên hệ thống";

            /// <summary>
            /// Mã quyền đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_ROLE_CODE_MESS = "Mã quyền đã tồn tại trên hệ thống";

            /// <summary>
            /// Mã điều hướng đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_NAVIGATION_CODE_MESS = "Mã điều hướng đã tồn tại trên hệ thống";

            /// <summary>
            /// Mã nhóm người dùng đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_GROUP_ROLE_CODE_MESS = "Mã nhóm người dùng đã tồn tại trên hệ thống";

            /// <summary>
            /// Mã nhóm người dùng đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_CODE_MES = "Mã đã tồn tại trên hệ thống";

            /// <summary>
            /// Bạn không có quyền duyệt bài
            /// </summary>
            public const string PERMISSION_NOT_MES = "Tài khoản không có quyền duyệt yêu cầu";

            /// <summary>
            /// Pronom id đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_PRONOM_MES = "Pronom id đã tồn tại trên hệ thống";

            /// <summary>
            /// Mã nhóm người dùng đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_NAME_MES = "Tên nhóm định dạng đã bị trùng";
            /// <summary>
            /// ScanVirus message
            /// </summary>
            public const string SCAN_VIRUS = "Scan request successfully queued, come back later for the report";
            /// <summary>
            /// ScanVirus message success
            /// </summary>
            public const string SCAN_VIRUS_SUCCESS_MESS = "Tệp tin sạch";
            /// <summary>
            /// ScanVirus message faild
            /// </summary>
            public const string SCAN_VIRUS_FAILD = "Tệp tin phát hiện virus";
            /// <summary>
            /// ScanVirus message error
            /// </summary>
            public const string SCAN_VIRUS_ERROR = "Hệ thống quét virus bị lỗi";
            /// <summary>
            /// <summary>
            /// Tên định dạng đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_FNAME_MES = "Tên định dạng đã bị trùng";

            /// <summary>
            /// Tên mục đích đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_PNAME_MES = "Tên mục đích đã bị trùng";

            /// <summary>
            /// Tên lệnh đã tồn tại trên hệ thống
            /// </summary>
            public const string DUPPLICATE_TNAME_MES = "Tên lệnh đã bị trùng";

            /// <summary>
            /// Đường dẫn không đúng định dạng
            /// </summary>
            public const string LOCATION_MES = "Đường dẫn không đúng định dạng";

            /// <summary>
            /// Ký số thất bại
            /// </summary>
            public const string FAIL_SIGN_MESS = "Ký số thất bại";
            /// <summary>
            /// Thất bại
            /// </summary>
            public const string FAIL_MESS = "Thất bại";
            /// <summary>
            /// Thất bại
            /// </summary>
            public const string LOCKED_MESS = "Gói tin đã bị khoá";
            /// <summary>
            /// Thư mục đã tồn tại file
            /// </summary>
            public const string CHECK_BUCKET_EXITS_FILE = "Bucket đã tồn tại dữ liệu";
            /// <summary>
            /// Thư mục tồn tại
            /// </summary>
            public const string BUCKET_EXITS = "Bucket đã tồn tại";
            /// <summary>
            /// Thư mục tồn tại
            /// </summary>
            public const string BUCKET_NAME_EXITS = "Bucket name dài từ 3 đến 63 ký tự";
            /// <summary>
            /// Thư mục không tồn tại
            /// </summary>
            public const string BUCKET_DONT_EXITS = "Bucket không tồn tại";
            /// <summary>
            /// file tồn tại
            /// </summary>
            public const string FILE_EXITS = "File đã tồn tại";
            /// <summary>
            /// CTS đã tồn tại
            /// </summary>
            public const string CERT_EXIST_MESS = "Chứng thư số đã tồn tại";
            /// <summary>
            /// Vị trí không tồn tại
            /// </summary>
            public const string LOCATION_NOT_EXIST = "Vị trí không tồn tại";
            /// <summary>
            /// Vị trí lưu trữ không tồn tại
            /// </summary>
            public const string LOCATION_STORAGE_NOT_EXIST = "Vị trí lưu trữ không tồn tại";

            /// <summary>
            /// Thư mục NAS/SAN chưa tồn tại
            /// </summary>
            public const string FOLDER_DONT_EXIST_MESS = "Thư mục chưa tồn tại";

            /// <summary>
            /// Thư mục NAS/SAN chưa tồn tại
            /// </summary>
            public const string FOLDER_SUCCESS_MESS = "Thư mục đã tồn tại";

            /// <summary>
            /// File trên NAS/SAN không tồn tại
            /// </summary>
            public const string FILE_DONT_EXIST_MESS = "File không tồn tại";
            /// <summary>
            /// File không đúng định dạng
            /// </summary>
            public const string FILE_FORMAT_ERROR = "File không đúng định dạng";
            /// <summary>
            /// Thông tin không đúng định dạng
            /// </summary>
            public const string DETAIL_INVALID = "Thông tin không đúng định dạng";
            /// <summary>
            /// mã CTS đã tồn tại
            /// </summary>
            public const string DUPPLICATE_CERT_CODE_MESS = "Mã chứng thư số đã tồn tại";

            public const string DELETE_FILE_MINiO_AWS3_ERROR = "Xóa file trên MinIo + AWS3 thất bại";

            public const string SIG_SUSSCES = "Ký số thành công";
            public const string SIG_ERROR = "Ký số thất bại";
            public const string VERIFY_SUSSCES = "Xác thực tài liệu thành công";
            public const string VERIFY_ERROR = "Xác thực tài liệu thất bại";
            /// <summary>
            /// Thành công
            /// </summary>
            public const string FILE_OPEN_SUCCESS_MESS = "Đọc file thành công";
            public const string FILE_OPEN_ERR_MESS = "Đọc file thất bại";
            /// <summary>
            /// Đơn vị không hỗ trợ chạy tự động
            /// </summary>
            public const string USER_NOT_SUPPORT_AUTO = "Đơn vị không hỗ trợ chạy tự động";
            /// <summary>
            /// Tập tin đang được xử lý
            /// </summary>
            public const string FILE_PROCESSING = "Tập tin đang được xử lý";
            /// <summary>
            /// Tập tin xử lý bị lỗi
            /// </summary>
            public const string FILE_ERORR = "Tập tin xử lý bị lỗi";
            /// <summary>
            /// Tập tin đã xử lý thành công
            /// </summary>
            public const string FILE_SUCCESS = "Tập tin đã xử lý thành công";
            /// <summary>
            /// Lưu file trên MinIO không thành công
            /// </summary>
            public const string SAVE_MINIO_ERROR = "Lưu file trên MinIO không thành công";
            /// <summary>
            /// Lưu file trên S3 không thành công
            /// </summary>
            public const string SAVE_S3_ERROR = "Lưu file trên S3 không thành công";
            /// <summary>
            /// Lưu file trên OBTA không thành công
            /// </summary>
            public const string SAVE_OBTA_ERROR = "Lưu file trên OBTA không thành công";
            /// <summary>
            /// Lưu file trên Cifs không thành công
            /// </summary>
            public const string SAVE_CIFS_ERROR = "Lưu file trên CIFS không thành công";
            /// <summary>
            /// Lưu file trên Cifs không thành công
            /// </summary>
            public const string SAVE_NFS_ERROR = "Lưu file trên NFS không thành công";
            /// <summary>
            /// Lưu file trên file server không thành công
            /// </summary>
            public const string SAVE_FS_ERROR = "Lưu file trên File Server không thành công";
            /// <summary>
            /// Lưu file trên QStar không thành công
            /// </summary>
            public const string SAVE_QSTAR_ERROR = "Lưu file trên QStar không thành công";
            /// <summary>
            /// Đơn vị không tồn tại
            /// </summary>
            public const string ORGANIZATION_DONT_EXIST = "Đơn vị không tồn tại";
            /// <summary>
            /// Người dùng không tồn tại
            /// </summary>
            public const string USER_DONT_EXIST = "Người dùng không tồn tại";
            /// <summary>
            /// Người dùng không thuộc đơn vị nào
            /// </summary>
            public const string USER_DONT_INLCUDE_ORGANIZATION = "Người dùng không thuộc đơn vị nào.";
            /// <summary>
            /// Xóa file thất bại
            /// </summary>
            public const string DELETE_FILE_ERROR = "Xóa file thất bại.";
            /// <summary>
            /// Tạo file version thất bại
            /// </summary>
            public const string ADD_FILE_VERSION_FAIL = "Tạo file version thất bại.";
            /// <summary>
            /// Xoá quyền thất bại
            /// </summary>
            public const string DELETE_ROLE_FAIL = "Quyền trong nhóm người dùng đang hoạt động, không được phép thực hiện xóa.";
            /// <summary>
            /// Xoá quyền thất bại
            /// </summary>
            public const string DUPPLICATE_NAME_AND_PROTOCOL_MESS = "Tên và giao thức đã tồn tại.";
            /// <summary>
            /// Email chưa được cấu hình
            /// </summary>
            public const string EMAIL_NOT_CONFIG = "Email chưa được cấu hình.";
            /// <summary>
            /// Email gửi không thành công
            /// </summary>
            public const string SEND_MAIL_FAILED = "Gửi mail thông báo không thành công.";
            /// <summary>
            /// Email gửi thành công
            /// </summary>
            public const string SEND_MAIL_SUCCESS = "Gửi mail thông báo thành công.";

            #endregion
        }
        public class SqlDapper
        {
            public class FileName
            {
                public static string GetSystemQueryFile()
                {
                    string queryFile = string.Empty;
                    string dbUsing = AppSettings.Instance.GetString("ConnectionString:DbType");
                    switch (dbUsing)
                    {
                        case DatabaseType.MSSQL:
                            queryFile = "SqlCommand/MSSQL_System_Query.json";
                            break;
                        case DatabaseType.POSTGRESQL:
                            queryFile = "SqlCommand/PostgreSQL_System_Query.json";
                            break;
                        case DatabaseType.ORACLE:
                            queryFile = "SqlCommand/Oracle_System_Query.json";
                            break;
                        default:
                            queryFile = "SqlCommand/PostgreSQL_System_Query.json";
                            break;
                    }
                    return queryFile;
                }
            }
            public class Query
            {
                public static string AppendCount = "_Count";
                public class System
                {
                    public class Base
                    {
                        public const string SUB = "Base";
                        public const string DUPLICATE_FIELD_VALIDATE = "DuplicateFieldValidate";
                    }
                    public class Users
                    {
                        public const string SUB = "Users";
                        public const string GET_ALL = "GetAll";
                    }
                }
            }

            public class AuthenticateType
            {
                public const string MEMBERSHIP = "membership";
                public const string ACTIVE_DIRECTORY = "ad";
                public const string LDAP = "ldap";
            }

            public class StatusRecord
            {
                public const int ACTIVE = 1;
                public const int INACTIVE = 0;
                public const int DELETED = -1;
                public const int WAITING_DELETE = 2;
            }
            public class StatusRecordText
            {
                public const string ACTIVE_TEXT = "Hoạt động ";
                public const string INACTIVE_TEXT = "Không hoạt động";
                public const string DELETE_TEXT = "Đã xóa";
            }

            public class OrderBy
            {
                public const string DESCENDING = "DESC";
                public const string ASCENDING = "ASC";
            }

            public class LogAction
            {
                public const string LOGIN = "Login";
                public const string LOGOUT = "Logout";
                public const string ADD = "Add";
                public const string UPDATE = "Update";
                public const string DELETE = "Delete";
                public const string SEARCH = "Search";
                public const string IMPORT = "Import";
                public const string EXPORT = "Export";
            }
            public class Right
            {
                public const string CREATE = "CREATE";
                public const string UPDATE = "UPDATE";
                public const string UPDATE_TTC = "UPDATE_TTC";
                public const string UPDATE_TTCV = "UPDATE_TTCV";
                public const string UPDATE_TTLH = "UPDATE_TTLH";
                public const string UPDATE_TTK = "UPDATE_TTK";
                public const string DELETE = "DELETE";
                public const string VIEW = "VIEW";
                public const string IMPORT = "IMPORT";
                public const string EXPORT = "EXPORT";
                public const string PWCHANGE = "PWCHANGE"; //Đổi mật khẩu
                public const string LOCK = "LOCK";//Khóa-mở khóa tài khoản
            }
        }

        public class SignatureConstant
        {
            public class SignatureResponseCode
            {
                public const int SUCCESS = 200;
                public const int INTERNAL_SERVER_ERROR = 500;
                public const int CERTIFICATE_EXPIRED = 21001;
                public const int CERTIFICATE_REVOKED = 21002;
                public const int CERTIFICATE_FAILED_TO_CHECK_WITH_CRL = 21003;
                public const int CERTIFICATE_FAILED_TO_CHECK_WITH_OCSP = 21004;
                public const int HASH_DATA_IS_REQUIRED = 31001;
                public const int MESSAGE_DATA_IS_REQUIRED = 32001;
                public const int FAILED_TO_SIGN_MESSAGE = 32002;
                public const int DETECT_STRING_NOT_FOUND = 34001;
                public const int FAILED_TO_READ_FILE_TO_SIGN = 34002;
                public const int FAILED_TO_DETECT_STRING = 34003;
                public const int IMAGE_IS_REQUIRED = 34004;
                public const int DETAIL_INFO_IS_REQUIRED = 34005;
                public const int SIGNATURE_POSITION_INVALID = 34006;
                public const int PAGE_NUMBER_INVALID = 34007;
                public const int FAILED_TO_GET_TIMESTAMP_TOKEN = 34008;
            }

            public class VerifySignatureResponseCode
            {
                public const int SUCCESS = 1;
                public const int ERROR = 0;
                public const int XAC_THUC_THAT_BAI = 401;
                public const int TAI_LIEU_KHONG_TON_TAI = 1001;
                public const int TAI_LIEU_KHONG_DUNG_DINH_DANG = 1002;
                public const int DOC_TAI_LIE_THAT_BAI = 1003;
                public const int KHONG_TIM_THAY_DUONG_DAN_CRL = 2001;
                public const int KHONG_KET_NOI_DUOC_DUONG_DAN_CRL = 2002;
                public const int CHUNG_THU_SO_CONVERT_THAT_BAI = 2003;
                public const int NHA_CUNG_CAP_CHUNG_THU_SO_KHONG_TIN_CAY = 2004;
                public const int LUU_KET_QUA_KIEM_TRA_CHUNG_THU_SO_THAT_BAI = 2005;
                public const int TAI_VE_CRL_THAT_BAI = 3006;
                public const int OCSP_KHONG_HO_TRO_HTTPS = 4001;
                public const int OCSP_KET_NOI_THAT_BAI = 4002;
                public const int DOC_THONG_TIN_CHUNG_THU_SO_THAT_BAI = 9000;
                public const int KHONG_TIM_THAY_THOI_GIAN_KY = 9001;
            }

            public class HashTypes
            {
                public const string BINARY = "BINARY";
                public const string SHA512 = "SHA512";
                public const string MD5 = "MD5";
                public const string SHA256 = "SHA256";
                public const string SHA384 = "SHA384";
            }
            public class QueryFilter
            {
                public const int DefaultPageNumber = 1;
                public const int DefaultPageSize = 20;
            }

        }
    }


}
