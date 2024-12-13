// RestoreObjectsDryRunInput.cs
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
    #region RestoreObjectsDryRunInput

    public class RestoreObjectsDryRunInput: IInput
    {
        #region members

        //      C# -> System.String? ExportId
        // GraphQL -> exportId: String (scalar)
        [JsonProperty("exportId")]
        public System.String? ExportId { get; set; }

        //      C# -> System.Boolean? ShouldReportOnlyChangedValues
        // GraphQL -> shouldReportOnlyChangedValues: Boolean (scalar)
        [JsonProperty("shouldReportOnlyChangedValues")]
        public System.Boolean? ShouldReportOnlyChangedValues { get; set; }

        //      C# -> System.Boolean? ShouldReportOnlyChangedAttrs
        // GraphQL -> shouldReportOnlyChangedAttrs: Boolean (scalar)
        [JsonProperty("shouldReportOnlyChangedAttrs")]
        public System.Boolean? ShouldReportOnlyChangedAttrs { get; set; }

        //      C# -> ActiveDirectoryObjectRecoveryConfigInput? Config
        // GraphQL -> config: ActiveDirectoryObjectRecoveryConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public ActiveDirectoryObjectRecoveryConfigInput? Config { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }


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

    } // class RestoreObjectsDryRunInput
    #endregion

} // namespace RubrikSecurityCloud.Types