// RestoreConfig.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region RestoreConfig

    public class RestoreConfig: IInput
    {
        #region members

        //      C# -> List<RestoreFileConfig>? RestoreFilesConfig
        // GraphQL -> restoreFilesConfig: [RestoreFileConfig!] (input)
        [JsonProperty("restoreFilesConfig")]
        public List<RestoreFileConfig>? RestoreFilesConfig { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.Boolean? ShouldIgnoreErrors
        // GraphQL -> shouldIgnoreErrors: Boolean (scalar)
        [JsonProperty("shouldIgnoreErrors")]
        public System.Boolean? ShouldIgnoreErrors { get; set; }

        //      C# -> System.Boolean? ShouldSaveCredentials
        // GraphQL -> shouldSaveCredentials: Boolean (scalar)
        [JsonProperty("shouldSaveCredentials")]
        public System.Boolean? ShouldSaveCredentials { get; set; }

        //      C# -> System.Boolean? ShouldUseAgent
        // GraphQL -> shouldUseAgent: Boolean (scalar)
        [JsonProperty("shouldUseAgent")]
        public System.Boolean? ShouldUseAgent { get; set; }

        //      C# -> System.Boolean? ShouldRestoreXattrs
        // GraphQL -> shouldRestoreXAttrs: Boolean (scalar)
        [JsonProperty("shouldRestoreXAttrs")]
        public System.Boolean? ShouldRestoreXattrs { get; set; }

        //      C# -> List<DeltaType>? DeltaTypeFilter
        // GraphQL -> deltaTypeFilter: [DeltaType!] (enum)
        [JsonProperty("deltaTypeFilter")]
        public List<DeltaType>? DeltaTypeFilter { get; set; }

        //      C# -> System.String? NextSnapshotFid
        // GraphQL -> nextSnapshotFid: String (scalar)
        [JsonProperty("nextSnapshotFid")]
        public System.String? NextSnapshotFid { get; set; }


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

    } // class RestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types