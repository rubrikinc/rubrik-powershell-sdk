// IdentityDataLocationsFilter.cs
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
    #region IdentityDataLocationsFilter

    public class IdentityDataLocationsFilter: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? WorkloadIds
        // GraphQL -> workloadIds: [UUID!] (scalar)
        [JsonProperty("workloadIds")]
        public List<System.String>? WorkloadIds { get; set; }

        //      C# -> List<IdentityWorkloadType>? WorkloadTypes
        // GraphQL -> workloadTypes: [IdentityWorkloadType!] (enum)
        [JsonProperty("workloadTypes")]
        public List<IdentityWorkloadType>? WorkloadTypes { get; set; }

        //      C# -> List<EncryptionType>? EncryptionTypes
        // GraphQL -> encryptionTypes: [EncryptionType!] (enum)
        [JsonProperty("encryptionTypes")]
        public List<EncryptionType>? EncryptionTypes { get; set; }


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

    } // class IdentityDataLocationsFilter
    #endregion

} // namespace RubrikSecurityCloud.Types