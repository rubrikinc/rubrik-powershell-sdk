// RefreshReaderTargetInput.cs
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
    #region RefreshReaderTargetInput

    public class RefreshReaderTargetInput: IInput
    {
        #region members

        //      C# -> List<System.String>? LocalDataSourceIds
        // GraphQL -> localDataSourceIds: [String!] (scalar)
        [JsonProperty("localDataSourceIds")]
        public List<System.String>? LocalDataSourceIds { get; set; }

        //      C# -> List<System.String>? ArchivalDataSourceIds
        // GraphQL -> archivalDataSourceIds: [String!] (scalar)
        [JsonProperty("archivalDataSourceIds")]
        public List<System.String>? ArchivalDataSourceIds { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? ExternalLocationId
        // GraphQL -> externalLocationId: String (scalar)
        [JsonProperty("externalLocationId")]
        public System.String? ExternalLocationId { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }


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

    } // class RefreshReaderTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types