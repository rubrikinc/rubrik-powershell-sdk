// GcpCloudAccountAddManualAuthProjectInput.cs
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
    #region GcpCloudAccountAddManualAuthProjectInput

    public class GcpCloudAccountAddManualAuthProjectInput: IInput
    {
        #region members

        //      C# -> System.String? GcpNativeProjectId
        // GraphQL -> gcpNativeProjectId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("gcpNativeProjectId")]
        public System.String? GcpNativeProjectId { get; set; }

        //      C# -> System.String? GcpProjectName
        // GraphQL -> gcpProjectName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("gcpProjectName")]
        public System.String? GcpProjectName { get; set; }

        //      C# -> System.Int64? GcpProjectNumber
        // GraphQL -> gcpProjectNumber: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("gcpProjectNumber")]
        public System.Int64? GcpProjectNumber { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? ServiceAccountJwtConfig
        // GraphQL -> serviceAccountJwtConfig: String (scalar)
        [JsonProperty("serviceAccountJwtConfig")]
        public System.String? ServiceAccountJwtConfig { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }


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

    } // class GcpCloudAccountAddManualAuthProjectInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types