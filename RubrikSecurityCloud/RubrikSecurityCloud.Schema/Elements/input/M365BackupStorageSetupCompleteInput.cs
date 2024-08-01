// M365BackupStorageSetupCompleteInput.cs
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
    #region M365BackupStorageSetupCompleteInput

    public class M365BackupStorageSetupCompleteInput: IInput
    {
        #region members

        //      C# -> System.String? StateToken
        // GraphQL -> stateToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("stateToken")]
        public System.String? StateToken { get; set; }

        //      C# -> List<System.String>? AppTypes
        // GraphQL -> appTypes: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appTypes")]
        public List<System.String>? AppTypes { get; set; }

        //      C# -> List<AuthInfoForTypeInput>? AuthInfoForType
        // GraphQL -> authInfoForType: [AuthInfoForTypeInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("authInfoForType")]
        public List<AuthInfoForTypeInput>? AuthInfoForType { get; set; }


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

    } // class M365BackupStorageSetupCompleteInput
    #endregion

} // namespace RubrikSecurityCloud.Types