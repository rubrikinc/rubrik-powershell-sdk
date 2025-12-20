// GlobalCertificatesQueryInput.cs
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
    #region GlobalCertificatesQueryInput

    public class GlobalCertificatesQueryInput: IInput
    {
        #region members

        //      C# -> System.String? SearchText
        // GraphQL -> searchText: String (scalar)
        [JsonProperty("searchText")]
        public System.String? SearchText { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> List<GlobalCertificateStatus>? Statuses
        // GraphQL -> statuses: [GlobalCertificateStatus!] (enum)
        [JsonProperty("statuses")]
        public List<GlobalCertificateStatus>? Statuses { get; set; }

        //      C# -> List<System.String>? ClusterIds
        // GraphQL -> clusterIds: [UUID!] (scalar)
        [JsonProperty("clusterIds")]
        public List<System.String>? ClusterIds { get; set; }

        //      C# -> System.Boolean? IsTrustedAny
        // GraphQL -> isTrustedAny: Boolean (scalar)
        [JsonProperty("isTrustedAny")]
        public System.Boolean? IsTrustedAny { get; set; }

        //      C# -> System.Boolean? IsRscBorn
        // GraphQL -> isRscBorn: Boolean (scalar)
        [JsonProperty("isRscBorn")]
        public System.Boolean? IsRscBorn { get; set; }

        //      C# -> System.Boolean? IsCa
        // GraphQL -> isCa: Boolean (scalar)
        [JsonProperty("isCa")]
        public System.Boolean? IsCa { get; set; }

        //      C# -> List<IssuerType>? IssuerTypes
        // GraphQL -> issuerTypes: [IssuerType!] (enum)
        [JsonProperty("issuerTypes")]
        public List<IssuerType>? IssuerTypes { get; set; }

        //      C# -> List<CertificateRotationStatus>? RenewalStatuses
        // GraphQL -> renewalStatuses: [CertificateRotationStatus!] (enum)
        [JsonProperty("renewalStatuses")]
        public List<CertificateRotationStatus>? RenewalStatuses { get; set; }

        //      C# -> List<CdmCertificateUsage>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsage!] (enum)
        [JsonProperty("cdmUsages")]
        public List<CdmCertificateUsage>? CdmUsages { get; set; }

        //      C# -> System.Boolean? IsRubrikManaged
        // GraphQL -> isRubrikManaged: Boolean (scalar)
        [JsonProperty("isRubrikManaged")]
        public System.Boolean? IsRubrikManaged { get; set; }


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

    } // class GlobalCertificatesQueryInput
    #endregion

} // namespace RubrikSecurityCloud.Types