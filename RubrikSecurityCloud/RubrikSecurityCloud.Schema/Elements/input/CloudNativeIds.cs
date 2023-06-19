// CloudNativeIds.cs
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
    #region CloudNativeIds

    public class CloudNativeIds: IInput
    {
        #region members

        //      C# -> List<System.String>? AwsNativeAccountIds
        // GraphQL -> awsNativeAccountIds: [String!] (scalar)
        [JsonProperty("awsNativeAccountIds")]
        public List<System.String>? AwsNativeAccountIds { get; set; }

        //      C# -> List<System.String>? AzureNativeSubscriptionIds
        // GraphQL -> azureNativeSubscriptionIds: [String!] (scalar)
        [JsonProperty("azureNativeSubscriptionIds")]
        public List<System.String>? AzureNativeSubscriptionIds { get; set; }

        //      C# -> List<System.String>? GcpNativeProjectIds
        // GraphQL -> gcpNativeProjectIds: [String!] (scalar)
        [JsonProperty("gcpNativeProjectIds")]
        public List<System.String>? GcpNativeProjectIds { get; set; }


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

    } // class CloudNativeIds
    #endregion

} // namespace RubrikSecurityCloud.Types