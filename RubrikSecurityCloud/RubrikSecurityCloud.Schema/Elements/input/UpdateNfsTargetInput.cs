// UpdateNfsTargetInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateNfsTargetInput

    public class UpdateNfsTargetInput
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? ExportDir
        // GraphQL -> exportDir: String (scalar)
        [JsonProperty("exportDir")]
        public System.String? ExportDir { get; set; }

        //      C# -> AuthTypeEnum? NfsAuthType
        // GraphQL -> nfsAuthType: AuthTypeEnum (enum)
        [JsonProperty("nfsAuthType")]
        public AuthTypeEnum? NfsAuthType { get; set; }

        //      C# -> System.Int32? FileLockPeriodInSeconds
        // GraphQL -> fileLockPeriodInSeconds: Int (scalar)
        [JsonProperty("fileLockPeriodInSeconds")]
        public System.Int32? FileLockPeriodInSeconds { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean (scalar)
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

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

    } // class UpdateNfsTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types