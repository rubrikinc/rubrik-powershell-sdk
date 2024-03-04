// ArchivalLocationInfo.cs
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
    #region ArchivalLocationInfo

    public class ArchivalLocationInfo: IInput
    {
        #region members

        //      C# -> System.String? PolarisManagedLocId
        // GraphQL -> polarisManagedLocId: String (scalar)
        [JsonProperty("polarisManagedLocId")]
        public System.String? PolarisManagedLocId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        //      C# -> System.String? LocationType
        // GraphQL -> locationType: String (scalar)
        [JsonProperty("locationType")]
        public System.String? LocationType { get; set; }

        //      C# -> ArchivalLocationOperationType? OperationType
        // GraphQL -> operationType: ArchivalLocationOperationType (enum)
        [JsonProperty("operationType")]
        public ArchivalLocationOperationType? OperationType { get; set; }

        //      C# -> System.String? OperationId
        // GraphQL -> operationId: String (scalar)
        [JsonProperty("operationId")]
        public System.String? OperationId { get; set; }


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

    } // class ArchivalLocationInfo
    #endregion

} // namespace RubrikSecurityCloud.Types