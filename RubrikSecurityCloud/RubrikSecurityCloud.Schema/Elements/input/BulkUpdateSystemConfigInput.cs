// BulkUpdateSystemConfigInput.cs
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
    #region BulkUpdateSystemConfigInput

    public class BulkUpdateSystemConfigInput: IInput
    {
        #region members

        //      C# -> List<System.String>? SystemIds
        // GraphQL -> systemIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("systemIds")]
        public List<System.String>? SystemIds { get; set; }

        //      C# -> System.Boolean? IsForceFullOnMasterChangeEnabled
        // GraphQL -> isForceFullOnMasterChangeEnabled: Boolean (scalar)
        [JsonProperty("isForceFullOnMasterChangeEnabled")]
        public System.Boolean? IsForceFullOnMasterChangeEnabled { get; set; }


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

    } // class BulkUpdateSystemConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types