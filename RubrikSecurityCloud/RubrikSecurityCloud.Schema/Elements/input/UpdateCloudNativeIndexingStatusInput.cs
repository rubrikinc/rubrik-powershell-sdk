// UpdateCloudNativeIndexingStatusInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateCloudNativeIndexingStatusInput

    public class UpdateCloudNativeIndexingStatusInput: IInput
    {
        #region members

        //      C# -> List<System.String>? WorkloadIds
        // GraphQL -> workloadIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadIds")]
        public List<System.String>? WorkloadIds { get; set; }

        //      C# -> System.Boolean? IsIndexingEnabled
        // GraphQL -> isIndexingEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isIndexingEnabled")]
        public System.Boolean? IsIndexingEnabled { get; set; }


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

    } // class UpdateCloudNativeIndexingStatusInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types