using System;
using System.Collections.Generic;

namespace NetCore.Core.Base
{
    [Serializable]
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public bool Status { get; set; }
        public int? OrganizationId { get; set; }
        public int? ApplicationId { get; set; }
        public bool IsAdmin { get; set; }
        public string Mobile { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public bool IsLockedOut { get; set; }
        public int? FailedPasswordAttemptCount { get; set; }
        public int? PositionId { get; set; }
        public int? EthnicId { get; set; }
        public string EthnicName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccessToken { get; set; }
        public bool IsSystem { get; set; } //Phân biệt user login từ Hệ thống QT or NV
        public List<GroupRoleBase> GroupRoles { get; set; }
        public List<RoleBase> Roles { get; set; }
        public List<RightBase> Rights { get; set; }
    }
    [Serializable]
    public class GroupRoleBase
    {
        public int GroupRoleId { get; set; }
        public string GroupRoleName { get; set; }
        public string GroupRoleCode { get; set; }
    }
    [Serializable]
    public class RoleBase
    {
        public int NodeId { get; set; }
        public int? ParentRoleId { get; set; }
        public int RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
    }
    [Serializable]
    public class RightBase
    {
        public int RoleId { get; set; }
        public int RightId { get; set; }
        public string RightCode { get; set; }
        public string RightName { get; set; }
    }
}
