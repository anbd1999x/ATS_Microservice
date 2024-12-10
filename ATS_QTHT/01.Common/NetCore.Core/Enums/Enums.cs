namespace NetCore.Core.Enums
{
    public enum ResponseEnum
    {
        ExperiedToken = -1,
        UserNotFound = -2,
        UserLocked = -3,
        UserNotEnable = -4,
        UserNoRole = -5
    }

    public enum KeyCloak_ResponseStatus
    {
        Created,
        NoContent
    }

    public enum Wso2_ResponseStatus
    {
        NoContent,
        OK,
        Created
    }
}
