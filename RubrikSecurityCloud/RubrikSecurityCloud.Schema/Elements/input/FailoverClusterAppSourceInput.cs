// FailoverClusterAppSourceInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region FailoverClusterAppSourceInput

    public class FailoverClusterAppSourceInput
    {
        #region members
        //      C# -> List<FailoverClusterNodeOrderInput>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrderInput!] (input)
        [JsonProperty("nodeOrders")]
        public List<FailoverClusterNodeOrderInput>? NodeOrders { get; set; }

        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!] (scalar)
        [JsonProperty("virtualIps")]
        public List<System.String>? VirtualIps { get; set; }

        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!] (scalar)
        [JsonProperty("vips")]
        public List<System.String>? Vips { get; set; }

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

    } // class FailoverClusterAppSourceInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types