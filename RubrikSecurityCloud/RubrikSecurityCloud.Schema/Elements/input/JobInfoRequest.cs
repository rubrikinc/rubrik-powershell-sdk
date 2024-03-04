// JobInfoRequest.cs
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
    #region JobInfoRequest

    public class JobInfoRequest: IInput
    {
        #region members

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? RequestId
        // GraphQL -> requestId: String (scalar)
        [JsonProperty("requestId")]
        public System.String? RequestId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> JobType? Type
        // GraphQL -> type: JobType (enum)
        [JsonProperty("type")]
        public JobType? Type { get; set; }

        //      C# -> JobInfoRequestDetails? AdditionalInfo
        // GraphQL -> additionalInfo: JobInfoRequestDetails! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("additionalInfo")]
        public JobInfoRequestDetails? AdditionalInfo { get; set; }


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

    } // class JobInfoRequest
    #endregion

} // namespace RubrikSecurityCloud.Types