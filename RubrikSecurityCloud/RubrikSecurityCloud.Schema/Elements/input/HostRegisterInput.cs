// HostRegisterInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region HostRegisterInput

    public class HostRegisterInput: IInput
    {
        #region members

        //      C# -> System.Boolean? HasAgent
        // GraphQL -> hasAgent: Boolean (scalar)
        [JsonProperty("hasAgent")]
        public System.Boolean? HasAgent { get; set; }

        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        [JsonProperty("oracleQueryUser")]
        public System.String? OracleQueryUser { get; set; }

        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        [JsonProperty("oracleSysDbaUser")]
        public System.String? OracleSysDbaUser { get; set; }

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        [JsonProperty("alias")]
        public System.String? Alias { get; set; }

        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        [JsonProperty("isOracleHost")]
        public System.Boolean? IsOracleHost { get; set; }

        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: String (scalar)
        [JsonProperty("orgNetworkId")]
        public System.String? OrgNetworkId { get; set; }

        //      C# -> HostRegisterOsType? OsType
        // GraphQL -> osType: HostRegisterOsType (enum)
        [JsonProperty("osType")]
        public HostRegisterOsType? OsType { get; set; }

        //      C# -> HdfsConfigInput? HdfsConfig
        // GraphQL -> hdfsConfig: HdfsConfigInput (input)
        [JsonProperty("hdfsConfig")]
        public HdfsConfigInput? HdfsConfig { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> SddUserCredentialsInput? MssqlSddUserCredentials
        // GraphQL -> mssqlSddUserCredentials: SddUserCredentialsInput (input)
        [JsonProperty("mssqlSddUserCredentials")]
        public SddUserCredentialsInput? MssqlSddUserCredentials { get; set; }

        //      C# -> NasConfigInput? NasConfig
        // GraphQL -> nasConfig: NasConfigInput (input)
        [JsonProperty("nasConfig")]
        public NasConfigInput? NasConfig { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class HostRegisterInput
    #endregion

} // namespace RubrikSecurityCloud.Types