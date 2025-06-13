// QueryCertificatesInput.cs
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
    #region QueryCertificatesInput

    public class QueryCertificatesInput: IInput
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String (scalar)
        [JsonProperty("expiration")]
        public System.String? Expiration { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> System.Boolean? IncludeExpired
        // GraphQL -> includeExpired: Boolean (scalar)
        [JsonProperty("includeExpired")]
        public System.Boolean? IncludeExpired { get; set; }

        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        [JsonProperty("isTrusted")]
        public System.Boolean? IsTrusted { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<ExcludeUsages>? ExcludeUsages
        // GraphQL -> excludeUsages: [ExcludeUsages!] (enum)
        [JsonProperty("excludeUsages")]
        public List<ExcludeUsages>? ExcludeUsages { get; set; }

        //      C# -> V1QueryCertificatesRequestSortBy? SortBy
        // GraphQL -> sortBy: V1QueryCertificatesRequestSortBy (enum)
        [JsonProperty("sortBy")]
        public V1QueryCertificatesRequestSortBy? SortBy { get; set; }

        //      C# -> V1QueryCertificatesRequestSortOrder? SortOrder
        // GraphQL -> sortOrder: V1QueryCertificatesRequestSortOrder (enum)
        [JsonProperty("sortOrder")]
        public V1QueryCertificatesRequestSortOrder? SortOrder { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


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

    } // class QueryCertificatesInput
    #endregion

} // namespace RubrikSecurityCloud.Types