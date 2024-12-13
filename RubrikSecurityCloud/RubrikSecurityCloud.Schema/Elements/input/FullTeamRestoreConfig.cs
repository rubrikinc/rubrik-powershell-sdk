// FullTeamRestoreConfig.cs
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
    #region FullTeamRestoreConfig

    public class FullTeamRestoreConfig: IInput
    {
        #region members

        //      C# -> System.String? SourceTeamId
        // GraphQL -> sourceTeamId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceTeamId")]
        public System.String? SourceTeamId { get; set; }

        //      C# -> System.String? TargetTeamOwner
        // GraphQL -> targetTeamOwner: String (scalar)
        [JsonProperty("targetTeamOwner")]
        public System.String? TargetTeamOwner { get; set; }

        //      C# -> System.Int32? SnapshotSequenceNum
        // GraphQL -> snapshotSequenceNum: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotSequenceNum")]
        public System.Int32? SnapshotSequenceNum { get; set; }

        //      C# -> DestTeamInfo? DestTeamInfo
        // GraphQL -> destTeamInfo: DestTeamInfo (input)
        [JsonProperty("destTeamInfo")]
        public DestTeamInfo? DestTeamInfo { get; set; }

        //      C# -> System.String? O365AppId
        // GraphQL -> o365AppId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("o365AppId")]
        public System.String? O365AppId { get; set; }

        //      C# -> System.String? RefreshTokenEncrypted
        // GraphQL -> refreshTokenEncrypted: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("refreshTokenEncrypted")]
        public System.String? RefreshTokenEncrypted { get; set; }


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

    } // class FullTeamRestoreConfig
    #endregion

} // namespace RubrikSecurityCloud.Types