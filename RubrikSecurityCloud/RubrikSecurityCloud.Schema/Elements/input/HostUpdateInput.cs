// HostUpdateInput.cs
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
    #region HostUpdateInput

    public class HostUpdateInput: IInput
    {
        #region members

        //      C# -> System.Boolean? CompressionEnabled
        // GraphQL -> compressionEnabled: Boolean (scalar)
        [JsonProperty("compressionEnabled")]
        public System.Boolean? CompressionEnabled { get; set; }

        //      C# -> System.Boolean? HostVfdDriverInstalled
        // GraphQL -> hostVfdDriverInstalled: Boolean (scalar)
        [JsonProperty("hostVfdDriverInstalled")]
        public System.Boolean? HostVfdDriverInstalled { get; set; }

        //      C# -> HostVfdInstallConfig? HostVfdEnabled
        // GraphQL -> hostVfdEnabled: HostVfdInstallConfig (enum)
        [JsonProperty("hostVfdEnabled")]
        public HostVfdInstallConfig? HostVfdEnabled { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? MssqlCbtDriverInstalled
        // GraphQL -> mssqlCbtDriverInstalled: Boolean (scalar)
        [JsonProperty("mssqlCbtDriverInstalled")]
        public System.Boolean? MssqlCbtDriverInstalled { get; set; }

        //      C# -> MssqlCbtStatusType? MssqlCbtEnabled
        // GraphQL -> mssqlCbtEnabled: MssqlCbtStatusType (enum)
        [JsonProperty("mssqlCbtEnabled")]
        public MssqlCbtStatusType? MssqlCbtEnabled { get; set; }

        //      C# -> NasConfigInput? NasConfig
        // GraphQL -> nasConfig: NasConfigInput (input)
        [JsonProperty("nasConfig")]
        public NasConfigInput? NasConfig { get; set; }

        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String (scalar)
        [JsonProperty("oracleQueryUser")]
        public System.String? OracleQueryUser { get; set; }

        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String (scalar)
        [JsonProperty("oracleSysDbaUser")]
        public System.String? OracleSysDbaUser { get; set; }

        //      C# -> System.String? Alias
        // GraphQL -> alias: String (scalar)
        [JsonProperty("alias")]
        public System.String? Alias { get; set; }

        //      C# -> HdfsConfigInput? HdfsConfig
        // GraphQL -> hdfsConfig: HdfsConfigInput (input)
        [JsonProperty("hdfsConfig")]
        public HdfsConfigInput? HdfsConfig { get; set; }

        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean (scalar)
        [JsonProperty("isOracleHost")]
        public System.Boolean? IsOracleHost { get; set; }

        //      C# -> System.Boolean? IsUpdateCertAndAgentIdEnabled
        // GraphQL -> isUpdateCertAndAgentIdEnabled: Boolean (scalar)
        [JsonProperty("isUpdateCertAndAgentIdEnabled")]
        public System.Boolean? IsUpdateCertAndAgentIdEnabled { get; set; }

        //      C# -> System.Boolean? IsRefreshPaused
        // GraphQL -> isRefreshPaused: Boolean (scalar)
        [JsonProperty("isRefreshPaused")]
        public System.Boolean? IsRefreshPaused { get; set; }

        //      C# -> OracleSepsWalletSettingsInput? OracleSepsSettings
        // GraphQL -> oracleSepsSettings: OracleSepsWalletSettingsInput (input)
        [JsonProperty("oracleSepsSettings")]
        public OracleSepsWalletSettingsInput? OracleSepsSettings { get; set; }

        //      C# -> System.String? MssqlSddCertificateId
        // GraphQL -> mssqlSddCertificateId: String (scalar)
        [JsonProperty("mssqlSddCertificateId")]
        public System.String? MssqlSddCertificateId { get; set; }

        //      C# -> System.String? OracleSddWalletPath
        // GraphQL -> oracleSddWalletPath: String (scalar)
        [JsonProperty("oracleSddWalletPath")]
        public System.String? OracleSddWalletPath { get; set; }

        //      C# -> SddUserCredentialsInput? OracleSddUserCredentials
        // GraphQL -> oracleSddUserCredentials: SddUserCredentialsInput (input)
        [JsonProperty("oracleSddUserCredentials")]
        public SddUserCredentialsInput? OracleSddUserCredentials { get; set; }

        //      C# -> SddUserCredentialsInput? MssqlSddUserCredentials
        // GraphQL -> mssqlSddUserCredentials: SddUserCredentialsInput (input)
        [JsonProperty("mssqlSddUserCredentials")]
        public SddUserCredentialsInput? MssqlSddUserCredentials { get; set; }

        //      C# -> System.Boolean? ShouldOracleSddThroughRba
        // GraphQL -> shouldOracleSddThroughRba: Boolean (scalar)
        [JsonProperty("shouldOracleSddThroughRba")]
        public System.Boolean? ShouldOracleSddThroughRba { get; set; }

        //      C# -> System.Boolean? ShouldMssqlSddThroughRba
        // GraphQL -> shouldMssqlSddThroughRba: Boolean (scalar)
        [JsonProperty("shouldMssqlSddThroughRba")]
        public System.Boolean? ShouldMssqlSddThroughRba { get; set; }


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

    } // class HostUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types