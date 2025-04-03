// BulkRecoverySapHanaDbsConfigInput.cs
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
    #region BulkRecoverySapHanaDbsConfigInput

    public class BulkRecoverySapHanaDbsConfigInput: IInput
    {
        #region members

        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        [JsonProperty("recoveryPoint")]
        public DateTime? RecoveryPoint { get; set; }

        //      C# -> List<System.String>? DbIds
        // GraphQL -> dbIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dbIds")]
        public List<System.String>? DbIds { get; set; }

        //      C# -> List<SapHanaSystemCopyConfigInput>? SapHanaSystemCopyMap
        // GraphQL -> sapHanaSystemCopyMap: [SapHanaSystemCopyConfigInput!] (input)
        [JsonProperty("sapHanaSystemCopyMap")]
        public List<SapHanaSystemCopyConfigInput>? SapHanaSystemCopyMap { get; set; }


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

    } // class BulkRecoverySapHanaDbsConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types