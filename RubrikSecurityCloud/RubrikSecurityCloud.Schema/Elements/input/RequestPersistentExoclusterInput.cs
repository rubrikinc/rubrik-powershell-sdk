// RequestPersistentExoclusterInput.cs
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
    #region RequestPersistentExoclusterInput

    public class RequestPersistentExoclusterInput: IInput
    {
        #region members

        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudVendor")]
        public CloudVendor? CloudVendor { get; set; }

        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exocomputeConfigId")]
        public System.String? ExocomputeConfigId { get; set; }

        //      C# -> System.Int32? DurationInDays
        // GraphQL -> durationInDays: Int (scalar)
        [JsonProperty("durationInDays")]
        public System.Int32? DurationInDays { get; set; }

        //      C# -> AzureClusterRequestParams? AzureSpecificClusterParams
        // GraphQL -> azureSpecificClusterParams: AzureClusterRequestParams (input)
        [JsonProperty("azureSpecificClusterParams")]
        public AzureClusterRequestParams? AzureSpecificClusterParams { get; set; }

        //      C# -> AwsClusterRequestParams? AwsSpecificClusterParams
        // GraphQL -> awsSpecificClusterParams: AwsClusterRequestParams (input)
        [JsonProperty("awsSpecificClusterParams")]
        public AwsClusterRequestParams? AwsSpecificClusterParams { get; set; }


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

    } // class RequestPersistentExoclusterInput
    #endregion

} // namespace RubrikSecurityCloud.Types