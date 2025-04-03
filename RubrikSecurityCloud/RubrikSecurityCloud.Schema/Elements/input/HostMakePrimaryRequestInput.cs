// HostMakePrimaryRequestInput.cs
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
    #region HostMakePrimaryRequestInput

    public class HostMakePrimaryRequestInput: IInput
    {
        #region members

        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!] (scalar)
        [JsonProperty("ids")]
        public List<System.String>? Ids { get; set; }

        //      C# -> System.String? OldPrimaryClusterUuid
        // GraphQL -> oldPrimaryClusterUuid: String (scalar)
        [JsonProperty("oldPrimaryClusterUuid")]
        public System.String? OldPrimaryClusterUuid { get; set; }

        //      C# -> HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters? ShouldSkipCertificateUpdateOnSecondaryClusters
        // GraphQL -> shouldSkipCertificateUpdateOnSecondaryClusters: HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters (enum)
        [JsonProperty("shouldSkipCertificateUpdateOnSecondaryClusters")]
        public HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters? ShouldSkipCertificateUpdateOnSecondaryClusters { get; set; }


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

    } // class HostMakePrimaryRequestInput
    #endregion

} // namespace RubrikSecurityCloud.Types