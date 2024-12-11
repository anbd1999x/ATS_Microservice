using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static NetCore.Core.Utils.Constant.SqlDapper.Query.System;
using static NetCore.Core.Utils.Constant.TableInfo;

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

        public class VersionMessageCode
        {
            /// <summary>
            /// Tạo tập tin chuyển giao (1.0)
            /// </summary>
            public const string CREATE_TRANSFER_VERSION = "Tạo gói tin chuyển giao";
            /// <summary>
            /// Tạo file xml mô tả gói tin (1.1)
            /// </summary>
            public const string GENERATE_XML_VERSION = "Tạo file xml mô tả gói tin";
            /// <summary>
            /// Thay đổi phiên bản file pdf
            /// </summary>
            public const string CONVERT_PDF_VERSION = "Thay đổi phiên bản file pdf";
            /// <summary>
            /// Tập tin kí cơ bản (1.2)
            /// </summary>
            public const string SIGN_BASIC_VERSION = "Gói tin kí cơ bản";
            /// <summary>
            /// Tạo gói tin thu thập (1.3)
            /// </summary>
            public const string CREATE_SIP_VERSION = "Tạo gói tin thu thập";
            /// <summary>
            /// Gói tin kí nâng cao (1.4)
            /// </summary>
            public const string SIGN_ADVANCE_VERSION = "Gói tin kí nâng cao";
            /// <summary>
            /// Tạo gói tin lưu trữ (1.5)
            /// </summary>
            public const string CREATE_AIP_VERSION = "Tạo gói tin lưu trữ";
            /// <summary>
            /// Tạo gói tin truy cập (1.6)
            /// </summary>
            public const string CREATE_DIP_VERSION = "Tạo gói tin truy cập";
            /// <summary>
            /// Khôi phục gói tin lưu trữ
            /// </summary>
            public const string RESTORE_AIP_VERSION = "Khôi phục gói tin lưu trữ";
        }

        public class SqlDapper
        {
            public class FileName
            {
                public static string GetSystemQueryFile()
                {
                    string queryFile = string.Empty;
                    string dbUsing = AppSettings.Instance.GetString("Databases:Using");
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

                    public class BaseCombobox
                    {
                        public const string SUB = "BaseCombobox";
                        public const string GET_COMBOBOX_BYFIELD = "GetComboboxByField";
                        public const string GET_COMBOBOX = "GetCombobox";
                        public const string GET_COUNTRIES = "GetCountries";
                        public const string GET_DISTRICTS = "GetDistricts";
                        public const string GET_LOCATIONS = "GetLocations";
                        public const string GET_WARDS = "GetWards";
                        public const string GET_ETHNICS = "GetEthnics";
                    }

                    public class Users
                    {
                        public const string SUB = "Users";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_USER_ID = "GetByUserId";
                        public const string GET_BY_USER_NAME = "GetByUserName";
                        public const string GET_GROUPROLES_BY_USERID = "GetGroupRolesByUserId";
                        public const string GET_ORGANIZATION_BY_USERID = "GetOrganizationByUserId";
                        public const string GET_BY_APPLICATION = "GetByApplication";
                        public const string GET_PASSWORDSALT = "GetPasswordSalt";

                        public const string CHECK_USER_EXIST = "CheckUserExist";
                        public const string CHECK_EMAIL_EXIST = "CheckEmailExist";
                        public const string CHECK_MOBILE_EXIST = "CheckMobileExist";

                        public const string SP_USERS_SEARCH = "sp_Users_Search";
                        public const string SP_USERS_CREATE = "sp_Users_Create";
                        public const string SP_USERS_CREATE_ACCOUNT = "sp_Users_Account_Create";
                        public const string SP_USERS_UPDATE = "sp_Users_Update";
                        public const string SP_USERS_DEL = "sp_Users_Del";
                        public const string SP_USERS_DEL_MANY = "sp_Users_Del_Many";
                        public const string SP_USERS_CHANGEPASSWORD = "sp_Users_ChangePassword";
                        public const string SP_USERS_CHANGEPASSWORD_WITH_OLD_PASSWORD = "sp_Users_ChangePassword_With_Old_Password";
                        public const string SP_USERS_GETBYID = "sp_Users_GetById";
                        public const string SP_USERS_GETPERMISSION = "sp_Users_GetPermission";
                        public const string UPDATE_INFO_USER = "update_info_user";

                        public const string UPDATE_LOGIN_ATTEMPT = "UpdateLoginAttempt";
                        public const string SP_CHECKINDIVIDUALUSER = "sp_CheckIndividualUser";
                        public const string GET_BY_USER_NAME_AND_APP = "GetUserByNameAndApp";
                        public const string SP_USERS_SYNCHRONIZE = "sp_Users_Synchronize";
                    }
                    public class GroupRoles
                    {
                        public const string SUB = "GroupRoles";
                        public const string GET_ALL = "GetAll";
                        public const string GET_LIST_GROUPROLE = "GetListGroupRole";
                        public const string GET_BY_USER_ID = "GetByUserId";
                        public const string GET_BY_APPLICATION = "GetByApplication";
                        public const string SP_GROUP_ROLE_GETBYID = "sp_GroupRole_GetById";
                        public const string SP_GROUP_ROLE_SEARCH = "Sp_GroupRole_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string SP_GROUP_ROLE_CREATEORUPDATE = "sp_GroupRole_CreateOrUpdate";
                        public const string GET_ALL_BY_APPLICATIONID_AND_GROUP_ROLE = "GetAllByApplicationIdAndGroupRole";
                        public const string SP_GROUP_ROLE_GET_PERMISSION = "Sp_GroupRole_GetPermission";
                        public const string SP_ROLES_GETALL = "sp_Roles_GetAll";
                        public const string SP_ROLES_RIGHTS_GETALL = "sp_Roles_Rights_GetAll";
                        public const string SP_GROUP_ROLE_BY_USER_CURRENT = "GetGroupRoleByUserCurrent";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Applications
                    {
                        public const string SUB = "Applications";
                        public const string GET_ALL = "GetAll";
                        public const string GET_LIST_APPLICATION = "GetListApplication";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_APPLICATION_TYPE = "GetByApplicationType";
                        public const string GET_BY_APPLICATIONTYPE_AUTHENTYPE = "GetByApplicationTypeAuthenType";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_CODE = "GetByCode";
                        public const string SP_APPLICATION_SEARCH = "Sp_Application_Search";
                        public const string SP_APPLICATION_CREATE_OR_UPDATE = "Sp_Application_CreateOrUpdate";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECH_EXIST = "CheckExist";
                        public const string GET_APP_AD = "GetAppAdByAppId";
                        public const string GET_APP_LDAP = "GetAppLdapByAppId";
                        public const string GET_APP_WSO2 = "GetAppWso2ByAppId";
                        public const string GET_APP_KEYCLOAK = "GetAppKeyCloakByAppId";
                        //public const string INSERT_APPLICATION_AD = "InsertApplicationAd";
                        //public const string INSERT_APPLICATION_LDAP = "InsertApplicationLdap";
                        //public const string INSERT_APPLICATION_WSO2 = "InsertApplicationWso2";
                        //public const string INSERT_APPLICATION_KEYCLOAK = "InsertApplicationKeyCloak";
                        //public const string DELETE_APPLICATION_AD = "DeleteApplicationAd";
                        //public const string DELETE_APPLICATION_LDAP = "DeleteApplicationLdap";
                        //public const string DELETE_APPLICATION_WSO2 = "DeleteApplicationWso2";
                        //public const string DELETE_APPLICATION_KEYCLOAK = "DeleteApplicationKeyCloak";
                        //public const string CHECH_EXIST_APPLICATION_AD = "CheckExistApplicationAd";
                        //public const string CHECH_EXIST_APPLICATION_LDAP = "CheckExistApplicationLdap";
                        //public const string CHECH_EXIST_APPLICATION_WSO2 = "CheckExistApplicationWso2";
                        //public const string CHECH_EXIST_APPLICATION_KEYCLOAK = "CheckExistApplicationKeyCloak";
                    }

                    public class Organizations
                    {
                        public const string SUB = "Organizations";
                        public const string GET_ALL = "GetAll";
                        public const string GET_LIST_ORGANIZATION = "GetListOrganization";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_CODE = "GetByCode";
                        public const string CHECK_PARENT_ID = "CheckParentId";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_APPLICATION = "GetByApplication";
                        public const string GET_BY_USER = "GetByUser";
                        public const string GET_BY_TRANSFER = "GetByTransfer";
                        public const string GET_BY_PARENT_ID = "GetByParentId";
                        public const string SP_ORGANIZATION_SEARCH = "Sp_Organization_Search";
                        public const string SP_ORGANIZATIONS_CREATEORUPDATE = "sp_Organizations_CreateOrUpdate";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string TREE = "Proc_Recursive_Organization";
                        public const string TreeAll = "Proc_Recursive_Organization_GetAll";
                    }
                    public class Roles
                    {
                        public const string SUB = "Roles";
                        public const string GET_ALL_RIGHTS = "GetAllRights";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_LIST_ROLES = "GetListRoles";
                        public const string SP_ROLES_GETBYID = "sp_Roles_GetById";
                        public const string SP_ROLE_SEARCH = "sp_Role_Search";
                        public const string SP_ROLES_CREATE_OR_UPDATE = "sp_Roles_CreateOrUpdate";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string GET_ROLE_BY_USER_CURRENT = "GetRoleByUserCurrent";
                        public const string GET_BY_USER_ID = "GetByUserId";
                        public const string CHECK_ACTIVE = "CheckActive";

                    }

                    public class Rights
                    {
                        public const string SUB = "Rights";
                        public const string GET_RIGHT_BY_USER_CURRENT = "GetRightByUserCurrent";
                    }

                    public class SystemParameters
                    {
                        public const string SUB = "SystemParameters";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_SYSTEMPARAMETER_SEARCH = "Sp_SystemParameter_Search";
                        public const string SP_SYSTEMPARAMETERS_CREATE_OR_UPDATE = "sp_SystemParameters_CreateOrUpdate";
                        //public const string INSERT = "Insert";
                        //public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string GET_BY_CODE = "GetByCode";

                    }

                    public class GroupRolesNavigations
                    {
                        public const string SUB = "GroupRolesNavigations";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_GROUPROLENAVIGATIONS_SEARCH = "Sp_GroupRolesNavigations_Search";
                        public const string INSERT = "Insert";
                        public const string INSERT_MANY = "InsertMany";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }

                    public class SystemLogs
                    {
                        public const string SUB = "SystemLogs";
                        public const string INSERT = "Insert";
                        public const string SP_SYSTEMLOG_SEARCH = "Sp_SystemLog_Search";
                        public const string GET_BY_ID = "GetById";
                    }

                    public class Navigations
                    {
                        public const string SUB = "Navigations";
                        public const string GET_BY_CURRENT_USER = "GetByCurrentUser";
                        public const string GET_BY_APPLICATION = "GetByApplication";
                        public const string GET_APPLICATION_BY_USER = "GetByApplicationByUser";
                        public const string GET_BY_PARENT_ID = "GetByParentId";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_NAVIGATION_SEARCH = "Sp_Navigation_Search";
                        public const string SP_NAVIGATION_FORGROUPROLE_SEARCH = "sp_Navigation_ForGroupRole_Search";
                        public const string SP_NAVIGATIONS_CREATE_OR_UPDATE = "sp_Navigations_CreateOrUpdate";
                        //public const string UPDATE = "Update";
                        //public const string INSERT = "Insert";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_NAME_EXIST = "CheckNameExist";
                        public const string GET_NAV_BY_USER = "GetNavigationByuserID";
                        public const string TREE_ALL = "Proc_Recursive_Navigation_GetAll";
                    }
                    public class Users_Organizations
                    {
                        public const string SUB = "Users_Organizations";
                        public const string GET_BY_ORGANIZATION = "GetByOrganization";
                    }
                    public class GroupRoles_Navigations
                    {
                        public const string SUB = "GroupRoles_Navigations";
                        public const string GET_BY_NAVIGATION = "GetByNavigation";
                        public const string Detele = "Detele";

                    }
                    public class Countries
                    {
                        public const string SUB = "Countries";
                        public const string GET_LIST_COUNTRIES = "GetListCountries";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_COUNTRY_SEARCH = "Sp_Country_Search";
                        public const string SP_COUNTRY_SEARCH_COUNT = "Sp_Country_Search_Count";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_EXIST_NAME = "CheckExistName";
                    }
                    public class States
                    {
                        public const string SUB = "States";
                        public const string GET_LIST_STATES = "GetListStates";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_STATES_SEARCH = "Sp_States_Search";
                        public const string SP_STATES_SEARCH_COUNT = "Sp_States_Search_Count";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }

                    public class Commands
                    {
                        public const string SUB = "Commands";
                        public const string GET_LIST_COMMAND = "GetListCommand";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_COMMAND_SEARCH = "Sp_Command_Search";
                        public const string SP_COMMAND_SEARCH_COUNT = "Sp_Command_Search_Count";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Provinces
                    {
                        public const string SUB = "Provinces";
                        public const string GET_LIST_PROVINCES = "GetListProvinces";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_PROVINCE_SEARCH = "Sp_Province_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_EXIST_NAME = "CheckExistName";
                    }
                    public class Districts
                    {
                        public const string SUB = "Districts";
                        public const string GET_LIST_DISTRICTS = "GetListDistricts";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_DISTRICT_SEARCH = "Sp_District_Search";
                        public const string SP_DISTRICT_SEARCH_COUNT = "Sp_District_Search_Count";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_EXIST_NAME = "CheckExistName";
                    }

                    public class Notification
                    {
                        public const string SUB = "Notification";
                        public const string GET_LIST_NOTIFICATION = "GetListNotification";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ROLE_ID = "GetByRoleId";
                        public const string GET_ALL_TWO = "GetAllTwo";
                        public const string GET_ALL_THREE = "GetAllThree";
                        public const string GET_ALL_NOT_VIEW = "GetAllNotView";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_NOTIFICATION_SEARCH = "Sp_Notification_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATE_ALL = "UpdateAll";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string UPDATE_SEND = "UpdateSend";
                    }

                    public class NotificationConfig
                    {
                        public const string SUB = "NotificationConfig";
                        public const string GET_LIST_NOTIFICATIONCONFIG = "GetListNotificationConfig";
                        public const string GET_ALL = "GetAll";
                        public const string GET_ROLE_BY_ID = "GetRoleById";
                        public const string ADD_BY_ROLE_ID = "AddRoleById";
                        public const string SP_NOTIFICATIONCONFIG_SEARCH = "Sp_NotificationConfig_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATE_TYPE = "UpdateType";
                        public const string DELETE_BY_ROLE_ID = "DeleteByRoleId";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }

                    public class Feedback
                    {
                        public const string SUB = "Feedback";
                        public const string GET_LIST_FEEDBACK = "GetListFeedback";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_FEEDBACK_SEARCH = "Sp_Feedback_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }

                    public class Request
                    {
                        public const string SUB = "Request";
                        public const string GET_LIST_REQUEST = "GetListRequest";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_REQUEST_SEARCH = "Sp_Request_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATE_TWO = "UpdateTwo";
                        public const string UPDATE_THREE = "UpdateThree";
                        public const string UPDATE_FOUR = "UpdateFour";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }

                    public class Warehouse
                    {
                        public const string SUB = "Warehouse";
                        public const string GET_LIST_DISTRICTS = "GetListWarehouse";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_WAREHOUSE_SEARCH = "Sp_Warehouse_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }

                    public class WarehouseRegister
                    {
                        public const string SUB = "WarehouseRegister";
                        public const string GET_LIST_WAREHOUSEREGISTER = "GetListWarehouseRegister";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_WAREHOUSEREGISTER_SEARCH = "Sp_WarehouseRegister_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_PHONE_EXIST = "CheckPhoneExist";
                    }

                    public class Wards
                    {
                        public const string SUB = "Wards";
                        public const string GET_LIST_WARDS = "GetListWards";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_WARD_SEARCH = "Sp_Ward_Search";
                        public const string SP_WARD_SEARCH_COUNT = "Sp_Ward_Search_Count";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Ethnics
                    {
                        public const string SUB = "Ethnics";
                        public const string GET_LIST_ETHNICS = "GetListEthnics";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_ETHNIC_SEARCH = "Sp_Ethnic_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_EXIST_NAME = "CheckExistName";
                    }
                    public class PipeLines
                    {
                        public const string SUB = "PipeLines";
                        public const string GET_LIST_PIPELINES = "GetListWards";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ORGANIZATION = "GetByOrganization";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_PIPELINES_SEARCH = "Sp_Pipelines_Search";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SET_DEFAULT = "sp_Pipeline_Set_Default";
                        public const string SP_PIPELINES_CREATEORUPDATE = "sp_PipeLines_CreateOrUpdate";
                        public const string SP_PIPELINE_JOB_UPDATE = "Sp_Pipeline_Job_Update";
                        public const string UPDATE_STATUS = "UpdateStatus";
                    }
                    public class SpaceLocations
                    {
                        public const string SUB = "SpaceLocation";
                        public const string GET_LIST_SPACELOCATIONS = "GetListSpaceLocation";
                        public const string GET_ALL = "GetAll";
                        public const string GET_ALL_BY_PIPELINE_ID = "GetAllByPipelineId";
                        public const string GET_BY_STATUS_AND_TYPE = "GetByStatusAndType";
                        public const string GET_BY_ORGCODE_AND_TYPE = "GetByOrgCodeAndType";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_TRANSFER_ID = "GetByTransferId";
                        public const string GET_BY_SIP_ID = "GetBySipId";
                        public const string SP_SPACELOTION_SEARCH = "Sp_Space_Location_Search";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_SPACELOCATION_CREATEORUPDATE = "Sp_SpaceLocation_CreateOrUpdate";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GET_BY_LOCATIONTYPE = "GetByLocationType";
                        public const string GET_INFO_BY_ID = "GetInfoById";
                        public const string GET_INFO_BY_LIST_ID = "GetInfoByListId";
                        public const string GET_INFO_BY_PIPELINE = "GetInfoByPipelineId"; 
                    }
                    public class Spaces
                    {
                        public const string SUB = "Spaces";
                        public const string GET_LIST_SPACES = "GetListSpaces";
                        public const string GET_ALL = "GetAll";
                        public const string GET_ALL_BY_PIPELINE_ID = "GetAllByPipelineId";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_ID_AND_JOIN = "GetByIdAndJoin";
                        public const string SP_SPACES_SEARCH = "Sp_Space_Search";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_EXIST_FS = "CheckExistFs";
                        public const string SP_SPACE_CREATEORUPDATE = "sp_Spaces_CreateOrUpdate";
                        public const string SP_SPACE_FindDetailTable = "FindJoinTable";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                    }
                    public class LocationType
                    {
                        public const string SUB = "LocationType";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_CODE = "GetByCode";
                    }

                    public class Catalogs
                    {
                        public const string SUB = "Catalog";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DeleteMany = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_CATALOG_SEARCH = "Sp_Catalog_Search";
                        public const string CHECK_EXIST_NAME = "CheckExistName";
                    }

                    public class CatalogDetails
                    {
                        public const string SUB = "CatalogDetail";
                        public const string GET_ALL = "GetAll";
                        public const string GET_By_CatalogID = "GetByCatalogID";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string GETBYCATALOG = "GetByCatalog";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_EXIST_KEY = "CheckExistKey";
                        public const string CHECK_EXIST_VALUE = "CheckExistValue";
                        public const string SP_CATALOGDETAIL_SEARCH = "Sp_CatalogDetail_Search";
                    }

                    public class Sips
                    {
                        public const string SUB = "Sip";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_UUID = "GetByUuid";
                        public const string GET_SIP_EXPIRED_DATE = "GetSipExpiredDate";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATE_DELETE_FILE = "UpdateDeleteFile";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_SIP_SEARCH = "Sp_Sip_Search";
                        public const string GET_PIPELINE_ID_BY_SIPID = "GetPipelineIdBySipId";
                    }
                    public class SipFile
                    {
                        public const string SUB = "SipFile";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_SIP = "GetBySip";
                        public const string GET_BY_SIP_ID = "GetBySipId";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_SIP_FILE_SEARCH = "Sp_Sip_File_Search";
                    }


                    public class FileReference
                    {
                        public const string SUB = "FILE_REFERENCE";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_REF_UUID = "GetByRefUuid";
                        public const string GET_BY_Space = "GetBySpace";
                        public const string GET_BY_Location = "GetByLocation";
                        public const string GET_BY_REF = "GetByREF";
                        public const string GET_BY_REF_Space = "GetByREFAndSpace";
                        public const string GET_BY_REF_Location = "GetByREFAndLocation";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                    }

                    public class SipMetaData
                    {
                        public const string SUB = "SipMetaData";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_SIP = "GetBySip";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_SIP_SEARCH = "Sp_Sip_Metadata_Search";
                    }

                    public class Field
                    {
                        public const string SUB = "Field";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_FOR_METADATA = "GetForMetadata";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckCodeExits";
                        public const string SP_FIELD_SEARCH = "Sp_Field_Search";
                        public const string DELETEMANYArchive = "DeleteManyarchivetypefield";
                    }

                    public class FieldGroup
                    {
                        public const string SUB = "FieldGroup";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string INSERT = "Insert";
                        public const string INSERT_FIELD = "Insertfield";
                        public const string INSERT_Archive_FIELD = "InsertachiveTypefield";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETEArchive = "Deletearchivetypefield";
                        public const string DELETEMANYArchive = "DeleteManyarchivetypefield";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckCodeExits";
                        public const string CHECK_NAME_EXIST = "CheckNameExits";
                        public const string SP_FIELDGROUP_SEARCH = "Sp_FieldGroup_Search";
                        public const string SP_FIELDGROUP_SEARCH_ByGroup = "Sp_FieldGroup_Search_By_GroupId";
                        public const string GET_BY_CODE = "GetByCode";
                        public const string GET_ALL_DETAIL = "GetAllDetail";

                    }
                    public class Transfers
                    {
                        public const string SUB = "Transfer";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_STATUS_AND_IDS = "GetByStatusAndIds";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_TRANSFER_EXPIRED_DATE = "GetTransferExpiredDate";
                        public const string DOWNLOAD_BY_ID = "DownloadById";
                        public const string Get_By_Transfer = "GetByTransfer";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATE_DELETE_FILE = "UpdateDeleteFile";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_BACKLOG_EXIST = "CheckBacklogExist";
                        public const string SP_TRANSFER_SEARCH = "Sp_Transfer_Search";
                        public const string SP_CHECK_FILE = "Sp_Check_File";
                    }

                    public class TransferFile
                    {
                        public const string SUB = "TransferFile";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_TRANSFERID = "GetByTransferId";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_TRANSFER = "GetByTransfer";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_BY_TRANSFER = "DeleteByTransfer";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_TRANSFER_FILE_SEARCH = "Sp_Transfer_File_Search";
                    }

                    public class TransferMetaData
                    {
                        public const string SUB = "TransferMetaData";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_TRANSFER = "GetByTransfer";
                        public const string INSERT = "Insert";
                        public const string INSERT_EACH = "InsertEach";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_TRANSFER_METADATA_SEARCH = "Sp_Transfer_Metadata_Search";
                    }

                    public class Backlogs
                    {
                        public const string SUB = "Backlog";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BACKLOG_EXPIRED_DATE = "GetBacklogExpiredDate";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_TRANSFER_EXIST = "CheckTransferExist";
                        public const string SP_BACKLOG_SEARCH = "Sp_Backlog_Search";
                    }

                    public class Jobs
                    {
                        public const string SUB = "Job";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_FILE = "GetByFile";
                        public const string GET_BY_UUID = "GetByUuid";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string SP_JOB_SEARCH = "Sp_Job_Search";
                    }

                    public class JobTypes
                    {
                        public const string SUB = "JobType";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_LIST_ID = "GetByListId";
                        public const string GET_BY_PARENT = "GetByParent";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                    }
                    public class OCR
                    {
                        public const string SUB = "OCR";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_OCR_FILE_SEARCH = "sp_ocr_file_search";
                        public const string SP_OCR_FILE_CREATE = "sp_ocr_file_create";
                        public const string SP_OCR_FILE_GETBYID = "sp_ocr_file_getbyid";
                        public const string SP_OCR_SAVE_REGION = "sp_ocr_save_region";
                        public const string SP_OCR_FILE_DEL = "sp_ocr_file_del";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_CODE_EXIST = "CheckCodeExist";
                    }
                    public class TemplateOCR
                    {
                        public const string SUB = "TemplateOCR";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_OCR_TEMPLATE_SEARCH = "sp_ocr_template_search";
                        public const string SP_OCR_TEMPLATE_CREATE_UPDATE = "sp_ocr_template_create_update";
                        public const string SP_OCR_TEMPLATE_GETBYID = "sp_ocr_template_getbyid";
                        public const string SP_OCR_TEMPLATE_DEL = "sp_ocr_template_del";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string CHECK_CODE_EXIST = "CheckCodeExist";
                        public const string CHECK_NAME_EXIST = "CheckNameExist";
                    }
                    public class GroupFormat
                    {
                        public const string SUB = "GroupFormat";
                        public const string GET_FILTER = "Filter";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GET_ALL = "GetALL";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Format
                    {
                        public const string SUB = "Format";
                        public const string GET_FILTER = "Filter";
                        public const string GET_FILTER_By_GroupID = "FilterByGroupId";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GETALL = "GetALL";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string GET_VERSION_FORMAT = "GetVersionFormat";
                        public const string GET_FORMAT = "GetFormat";
                    }
                    public class FormatSpecificVersion
                    {
                        public const string SUB = "FormatSpecificVersion";
                        public const string GET_FILTER_By_FormatID = "FilterByFormatId";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATEOBJ = "UpdateObj";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Purposes
                    {
                        public const string SUB = "Purposes";
                        public const string GET_FILTER = "Filter";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GETALL = "GetALL";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Tools
                    {
                        public const string SUB = "Tools";
                        public const string GET_FILTER = "Filter";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GETALL = "GetALL";
                        public const string CHECK_EXIST = "CheckExist";

                    }
                    public class ScriptType
                    {
                        public const string SUB = "ScriptType";
                        public const string GET_FILTER = "Filter";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GET_ALL = "GetALL";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class Mode
                    {
                        public const string SUB = "Mode";
                        public const string GET_FILTER = "Filter";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string GET_ALL = "GetALL";
                        public const string CHECK_NAME_EXIST = "CheckExist";
                    }
                    public class Command
                    {
                        public const string SUB = "Command";
                        public const string GET_LIST_PROVINCES = "GetListProvinces";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_SEARCH = "sp_command_search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATESTATUS = "UpdateStatus";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string GET_BY_TOOLID = "GetByToolId";

                    }
                    public class Rules
                    {
                        public const string SUB = "Rules";
                        public const string GET_LIST_PROVINCES = "GetListProvinces";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string SP_RULE_SEARCH = "Sp_prvpl_rule_Search";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string UPDATESTATUS = "UpdateStatus";

                    }
                    public class AipFileError
                    {
                        public const string SUB = "AIPFileError";
                        public const string GET_FILTER = "Filter";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string GetByID = "GetByID";
                        public const string CHECK_AIP_ERR_EXIST = "CheckAIPErrorExits";
                        public const string INSERT_AIP_FILE_ERR = "InsertAipFileError";
                        public const string UPDATE_STATUS_AIP_FILE_ERR = "UpdateStatus";
                        public const string GET_DETAIL = "GetDetail";
                    }
                    public class AipFileErrorJob
                    {
                        public const string SUB = "AIPFileErrorJob";
                        public const string GET_FILTER = "Filter";
                        public const string GetByID = "GetByID";
                        public const string INSERT_AIP_FILE_ERR_JOB = "InsertAipFileErrorJob";
                        public const string UPDATE_AIP_FILE_ERR_JOB = "UpdateAipFileErrorJob";
                        public const string CHECK_AIP_ERROR_JOB_EXIST = "CheckAIPErrorJobExit";

                    }
                    public class AipFileErrorHistory
                    {
                        public const string SUB = "ApiFileErrorHistory";
                        public const string GET_FILTER = "GetFilter";
                        public const string GetByID = "GetByID";
                        public const string INSERT_AIP_FILE_ERR_HISTORY = "InsertAipFileErrorHistory";
                    }

                    public class Aips
                    {
                        public const string SUB = "Aips";
                        public const string NEXTVAL = "NextVal";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_INACCESSIBLE_AIP = "GetInaccessibleAip";
                        public const string INSERT = "Insert";
                        public const string CHANGE_STATUS = "ChangeStatus";
                        public const string UPDATE = "Update";
                        public const string UPDATE_DELETE_FILE = "UpdateDeleteFile";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_AIP_SEARCH = "Sp_Aip_Search";
                    }
                    public class AipFile
                    {
                        public const string SUB = "AipFile";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_AIP_FILE_SEARCH = "Sp_Aip_File_Search";
                        public const string GET_LIMIT_DATA = "GetLimitListAipFile";
                        public const string UPDATE_AIP_FILE_ERR = "UpdateAIPFile";
                        public const string GET_BY_AIPID = "GetByAipId";
                        public const string UPDATE_HASH = "UpdateHash";
                    }
                    public class AipMetaData
                    {
                        public const string SUB = "AipMetaData";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_AIP = "GetByAip";
                        public const string GET_BY_ID = "GetById";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_AIP_SEARCH = "Sp_Aip_Metadata_Search";
                    }

                    public class Dips
                    {
                        public const string SUB = "Dips";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_DIP_EXPIRED_DATE = "GetDipExpiredDate";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string UPDATE_DELETE_FILE = "UpdateDeleteFile";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_DIP_SEARCH = "Sp_Dip_Search";
                    }
                    public class DipFile
                    {
                        public const string SUB = "DipFile";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_DIP = "GetByDip";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_DIP_FILE_SEARCH = "Sp_Dip_File_Search";
                    }

                    public class DipMetaData
                    {
                        public const string SUB = "DipMetaData";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_DIP = "GetByDip";
                        public const string INSERT = "Insert";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string CHECK_EXIST = "CheckExist";
                        public const string SP_DIP_SEARCH = "Sp_Dip_Metadata_Search";
                        public const string GetByDipId = "GetByDipId";

                    }
                    public class MetaData
                    {
                        public const string SUB = "MetaData";
                        public const string SP_METADATA_SEARCH = "sp_metadata_search";
                    }
                    public class Backup
                    {
                        public const string SUB = "Backup";
                        public const string GET_ALL = "GetAll";
                        public const string UPDATE = "Update";
                        public const string GET_BY_ID = "GetById";

                    }
                    public class License
                    {
                        public const string SUB = "License";
                        public const string SP_LICENSE_SEARCH = "sp_license_search";
                        public const string GET_BY_ID = "GetById";
                        public const string UPDATE = "Update";
                        public class SpaceMinIo
                        {
                            public const string SUB = "SpaceMinio";
                            public const string GET_BY_SPACE = "GetBySpace";
                        }
                    }
                    public class SpaceS3
                    {
                        public const string SUB = "SpaceS3";
                        public const string GET_BY_SPACE = "GetBySpace";
                    }
                    public class SpaceMinIO
                    {
                        public const string SUB = "SpaceMinIO";
                        public const string GET_BY_SPACE = "GetbySpaceId";
                    }
                    public class SpaceQStar
                    {
                        public const string SUB = "SpaceQStar";
                        public const string GET_BY_SPACE = "GetBySpace";
                    }
                    public class SpaceOBTA
                    {
                        public const string SUB = "SpaceOBTA";
                        public const string GET_BY_SPACE = "GetBySpace";
                    }
                    public class SpaceCIFS
                    {
                        public const string SUB = "SpaceCIFS";
                        public const string GET_BY_SPACE = "GetBySpace";
                    }
                    public class SpaceNfs
                    {
                        public const string SUB = "SpaceNfs";
                        public const string GET_BY_SPACE = "GetBySpace";
                    }
                    public class PipeLineJobs
                    {
                        public const string SUB = "PipeLineJobs";
                        public const string GET_BY_PIPELINE = "GetByPipeLine";
                        public const string GET_AUTO_JOBS = "GetAutoJobs";
                    }
                    public class AIPFileErrorHistory
                    {
                        public const string SUB = "AIPFileErrorHistory";
                        public const string CREATE = "Create";
                        public const string GET_BY_ID = "GetById";
                    }
                    public class Destroy
                    {
                        public const string SUB = "Destroy";
                        public const string DESTROY_AIP = "AIPS";
                        public const string DESTROY_DIP = "DIPS";
                        public const string DESTROY_SIP = "SIPS";
                        public const string GET_DIP_BY_UUID = "GetDipByUUID";
                        public const string GET_SIP_BY_UUID = "GetSipByUUID";
                        public const string GET_AIP_FILE = "GetAipFile";
                        public const string GET_AIP_FILE_ERROR = "GetAipFileError";

                    }
                    public class DashBoard
                    {
                        public const string Sub = "DashBoard";
                        public const string CountAIP = "CountAIP";
                        public const string GetSumSizeAIP = "GetSumSizeAIP";
                        public const string GetSumAIPError = "GetSumAIPError";
                        public const string GetSumTypeAIPError = "GetSumTypeAIPError";
                        public const string CountDIP = "CountDIP";
                        public const string CountSIP = "CountSIP";
                        public const string GetRequest = "GetRequest"; 
                        public const string GetRequestDestroy = "GetRequestDestroy";
                        public const string GetCountTransfer = "GetCountTransfer";
                        public const string GetCountSip = "GetCountSip";
                        public const string GetCountBacklog = "GetCountBacklog";
                    }

                    public class Version
                    {
                        public const string SUB = "Versions";
                        public const string GET_BY_FILE = "GetByFile";
                        public const string CREATE = "Create";
                    }

                    public class Archive
                    {
                        public const string SUB = "Archive";
                        public const string GET_FILTER = "Filter";
                        public const string GET_LOCATION = "GetLocation";
                        public const string GET_SIP_PACKAGE_MONTH = "GetSipPackgeMonth";
                        public const string GET_SIP_PACKAGE_YEAR = "GetSipPackgeYear";
                        public const string GET_SIP_PACKAGE_QUARTER = "GetSipPackgeQuarter";
                        public const string GET_TRANFER_PACKAGE_MONTH = "GetTranferPackgeMonth";
                        public const string GET_TRANFER_PACKAGE_YEAR = "GetTranferPackgeYear";
                        public const string GET_TRANFER_PACKAGE_QUARTER = "GetTranferPackgeQuarter";
                        public const string GET_DIP_PACKAGE_MONTH = "GetDipPackgeMonth";
                        public const string GET_DIP_PACKAGE_YEAR = "GetDipPackgeYear";
                        public const string GET_DIP_PACKAGE_QUARTER = "GetDipPackgeQuarter";
                        public const string GET_AIP_PACKAGE_MONTH = "GetAipPackgeMonth";
                        public const string GET_AIP_PACKAGE_YEAR = "GetAipPackgeYear";
                        public const string GET_AIP_PACKAGE_QUARTER = "GetAipPackgeQuarter";
                        public const string GET_WARE_PACKAGE_MONTH = "GetWarePackgeMonth";
                        public const string GET_WARE_PACKAGE_YEAR = "GetWarePackgeYear";
                        public const string GET_WARE_PACKAGE_QUARTER = "GetWarePackgeQuarter";
                    }
                }

                public class Signature
                {
                    public class Certificates
                    {
                        public const string SUB = "Certificates";
                        public const string SP_CERTIFICATES_CREATEORUPDATE = "sp_Certificates_CreateOrUpdate";
                        public const string CREATE = "CREATE";
                        public const string UPDATE = "UPDATE";
                        public const string GET_LIST_CERTIFICATES = "GetListCertificates";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string GET_BY_SERIAL = "GetBySerial";
                        public const string SP_CERTIFICATE_SEARCH = "Sp_Certificate_Search";
                        public const string SP_CERTIFICATE_SEARCH_COUNT = "Sp_Certificate_Search_Count";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class SignatureTemplate
                    {
                        public const string SUB = "SignatureTemplate";
                        public const string SignatureTemplate_CREATE = "SignatureTemplate_CREATE";
                        public const string SignatureTemplate_UPDATE = "SignatureTemplate_UPDATE";
                        public const string DELETE = "Delete";
                        public const string DELETE_MANY = "DeleteMany";
                        public const string Sp_SignatureTemplate_Search = "Sp_SignatureTemplate_Search";
                        public const string GET_ALL = "GetAll";
                        public const string GET_BY_STATUS = "GetByStatus";
                        public const string GET_BY_ID = "GetById";
                        public const string CHECK_EXIST = "CheckExist";
                    }
                    public class ConfigurationSignature
                    {
                        public const string SUB = "ConfigurationSignature";
                        public const string CREATE = "Create";
                        public const string UPDATE = "Update";
                        public const string DELETE = "Delete";
                        public const string Get_Configuration = "GetConfigurationSignature";
                    }
                }
            }
        }

        public class TableInfo
        {
            public class Countries
            {
                public const string TABLE_NAME = "Countries";
                public const string FIELD_NAME = "CountryName";
            }

            public class Districts
            {
                public const string TABLE_NAME = "Districts";
                public const string FIELD_NAME = "LocationId";
            }

            public class Wards
            {
                public const string TABLE_NAME = "Wards";
                public const string FIELD_NAME = "DistrictId";
            }

            public class Locations
            {
                public const string TABLE_NAME = "Locations";
                public const string FIELD_NAME = "LocationName";
            }

            public class Ethnics
            {
                public const string TABLE_NAME = "Ethnics";
                public const string FIELD_NAME = "EthnicName";
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
        public class StatusDestroyDocument
        {
            // Đợi duyệt
            public const int WAITING = 1;
            // Đã phê duyệt
            public const int APPROVED = 2;
            // Đã tiêu hủy
            public const int DESTROYED = 3;
            // Đã từ chối
            public const int REJECTED = 4;
        }

        public class StatusFile
        {
            public const int ERROR = 0;
            public const int WAITTING = 1;
            public const int RUNNING = 2;
            public const int COMPLETED = 3;
            public const int DELETED = -1;
            public const int AUTORUN = 4;
        }
        public class StatusJob
        {
            public const int ERROR = 0;
            public const int RUNNING = 1;
            public const int COMPLETED = 2;
            public const int DELETED = -1;
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

        public class Role
        {
            public const string USER_MANAGER = "QLND";
            public const string NAVIGATION_MANAGER = "QLDH";
            public const string ORG_MANAGER = "CCTT";
            public const string ROLE_MANAGER = "QLQ";
            public const string APP_MANAGER = "QLUD";
            public const string PARAMS_MANAGER = "TSHT";
            public const string USERGROUP_MANAGER = "QLNND";
            public const string PIPELINE_MANAGER = "QLDVTC";
            public const string SPACE_MANAGER = "QLKGLT";
            public const string SPACELOCATION_MANAGER = "QLVTLT";
            public const string TRANSFER_MANAGER = "QLCG";
            public const string SIP_MANAGER = "QLTT";
            public const string BACKLOG_MANAGER = "QLBT";
            public const string FIELD_MANAGER = "QLTTT";
            public const string FIELD_GROUP_MANAGER = "QLNTTT";
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

        public class ApplicationType
        {
            public const int UNG_DUNG_XAC_THUC = 1;
            public const int UNG_DUNG_CUNG_CAP_DU_LIEU = 2;
            public const int UNG_DUNG_KHAI_THAC_DU_LIEU = 3;
        }

        public class AuthenType
        {
            public const int JWT = 1;
            public const int AD = 2;
            public const int LDAP = 3;
            public const int WSO2 = 4;
            public const int KEYCLOAK = 5;

            public const string JWT_TEXT = "JWT";
            public const string AD_TEXT = "AD";
            public const string LDAP_TEXT = "LDAP";
            public const string WSO2_TEXT = "WSO2";
            public const string KEYCLOAK_TEXT = "KEYCLOAK";
        }

        public class TransferType
        {
            public const string FOLDER = "FOLDER";
            public const string ZIPPED = "ZIPPED";
            public const string OBJECT_STORAGE = "OBJECT_STORAGE";
        }

        public class FileType
        {
            public const string TRANSFER = "TRANSFER";
            public const string BACKLOG = "BACKLOG";
            public const string SIP = "SIP";
            public const string AIP = "AIP";
            public const string DIP = "DIP";
        }

        public class TransferJobTypeCode
        {
            public const string CREATE_TRANSFER = "CREATE_TRANSFER";
            public const string START_TRANSFER = "START_TRANSFER";
            public const string SCAN_VIRUSS = "SCAN_VIRUSS";
            public const string CHECK_FORMAT = "CHECK_FORMAT";
            public const string CHECK_BASIC_SIGNATURE = "CHECK_BASIC_SIGNATURE";
            public const string SIGN_BASIC = "SIGN_BASIC";
            public const string ENCRYPT = "ENCRYPT";
            public const string GENERATE_METADATA = "GENERATE_METADATA";
            public const string STORE_SIP = "STORE_SIP";
            public const string MOVE_TO_BACKLOG = "MOVE_TO_BACKLOG";
            public const string CHANGE_TO_COMPLETED = "CHANGE_TO_COMPLETED";
            public const string STORE_AIP = "STORE_AIP";
            public const string STORE_DIP = "STORE_DIP";
            public const string TRANFER_BACK = "TRANFER_BACK";
        }

        public class SipJobTypeCode
        {
            public const string CREATE_SIP = "CREATE_SIP";
            public const string PREPARE_STORE_AIP = "PREPARE_STORE_AIP";
            public const string CHECK_ADVANCE_SIGNATURE = "CHECK_ADVANCE_SIGNATURE";
            public const string SIGN_ADVANCE = "SIGN_ADVANCE";
            public const string STORE_AIP = "STORE_AIP";
            public const string STORE_DIP = "STORE_DIP";
            public const string CHANGE_TO_COMPLETED = "CHANGE_TO_COMPLETED";
        }

        public class AipJobTypeCode
        {
            public const string CREATE_AIP = "CREATE_AIP";
        }

        public class DipJobTypeCode
        {
            public const string CREATE_DIP = "CREATE_DIP";
        }

        public class LocationType
        {
            public const string SIP_ORIGINAL = "SO";
            public const string AIP_ORIGINAl = "AO";
            public const string DIP_ORIGINAL = "DO";
            public const string TRANSFER_SOURCE = "TS";
            public const string TRANSFER_BACKLOG = "BL";
            public const string TRANSFER_PROCESSING = "TP";
            public const string VERSION_STORAGE= "VS";
        }
        public class SpaceProtocol
        {
            public const string ARKIVUM = "ARKIVUM";
            public const string DV = "DV";
            public const string DC = "DC";
            public const string DSPACE = "DSPACE";
            public const string DSPC_RST = "DSPC_RST";
            public const string FEDORA = "FEDORA";
            public const string GPG = "GPG";
            /// <summary>
            /// File system
            /// </summary>
            public const string FS = "FS";
            public const string LOM = "LOM";
            public const string NFS = "NFS";
            public const string REPLICA = "REPLICA";
            public const string PIPE_FS = "PIPE_FS";
            public const string SWIFT = "SWIFT";
            public const string S3 = "S3";
            public const string MINIO = "MINIO";
            public const string QSTAR = "QSTAR";
            public const string WEBDAV = "WEBDAV";
            public const string OBTA = "OBTA";
            public const string LTFS = "LTFS";
            public const string CIFS = "CIFS";
        }

        public class DescriptionFileType
        {
            public const string METADATA_RECORD = "METADATA_RECORD";
            public const string METADATA_DOCUMENT = "METADATA_DOCUMENT";
            public const string METADATA_TECH = "METADATA_TECH";
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

        public class CertificateType
        {
            public const int USB_TOKEN = 1;
            public const int HSM = 2;
            public const string USB_TOKEN_TEXT = "Usb Token";
            public const string HSM_TEXT = "HSM";
        }

        public class CertificateStatus
        {
            public const int ACTIVE = 0;
            public const int EXPIRED = 1;
            public const int REVOKED = 2;
            public const int UNKNOWN = 3;
        }

        public class HashTypes
        {
            public const string BINARY = "BINARY";
            public const string SHA512 = "SHA512";
            public const string MD5 = "MD5";
            public const string SHA256 = "SHA256";
            public const string SHA384 = "SHA384";
        }
    }

    public class TypeError
    {
        public const string NO_HAVE_SIGNATURE = "FILE_IS_NOT_SIGNED";
        public const string SIGNATURE_EXPIRED = "SIGNATURE_EXPIRED";
        public const string FILE_FORMAT_ERROR = "FILE_HAS_INCORRECT_FORMAT";
        public const string FILE_OPEN_ERROR = "FILE_OPEN_ERROR";
        public const string FILE_METADATA_ERROR = "FILE_HAS_INCORRECT_METADATA";
    }
}
