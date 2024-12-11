using Dapper;
using System.Data;

namespace NetCore.DataProcess.Helper
{
    class DapperMapping
    {
        /// <summary>
        /// ByteArrayToGuidHandler
        /// </summary>
        public class ByteArrayToGuidHandler : SqlMapper.TypeHandler<Guid>
        {
            public override Guid Parse(object value)
            {
                // Convert byte array to Guid
                return new Guid((byte[])value);
            }

            public override void SetValue(IDbDataParameter parameter, Guid value)
            {
                parameter.Value = value.ToByteArray();
            }
        }
        /// <summary>
        /// BooleanToOracleNumberTypeHandler
        /// </summary>
        public class BooleanToOracleNumberTypeHandler : SqlMapper.TypeHandler<bool>
        {
            public override void SetValue(IDbDataParameter parameter, bool value)
            {
                parameter.Value = value ? 1 : 0;
            }

            public override bool Parse(object value)
            {
                return Convert.ToBoolean(value);
            }
        }
    }
}
