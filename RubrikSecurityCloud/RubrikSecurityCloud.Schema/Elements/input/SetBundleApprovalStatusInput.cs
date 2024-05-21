// SetBundleApprovalStatusInput.cs
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
    #region SetBundleApprovalStatusInput

    public class SetBundleApprovalStatusInput: IInput
    {
        #region members

        //      C# -> System.String? BundleVersion
        // GraphQL -> bundleVersion: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bundleVersion")]
        public System.String? BundleVersion { get; set; }

        //      C# -> ExoBundleApprovalStatus? ApprovalStatus
        // GraphQL -> approvalStatus: ExoBundleApprovalStatus! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("approvalStatus")]
        public ExoBundleApprovalStatus? ApprovalStatus { get; set; }

        //      C# -> BundleMetadataInput? BundleMetadata
        // GraphQL -> bundleMetadata: BundleMetadataInput (input)
        [JsonProperty("bundleMetadata")]
        public BundleMetadataInput? BundleMetadata { get; set; }


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

    } // class SetBundleApprovalStatusInput
    #endregion

} // namespace RubrikSecurityCloud.Types