// AwsCloudAccountInput.cs
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
    #region AwsCloudAccountInput

    public class AwsCloudAccountInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean (scalar)
        [JsonProperty("seamlessFlowEnabled")]
        public System.Boolean? SeamlessFlowEnabled { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String (scalar)
        [JsonProperty("outpostAwsNativeId")]
        public System.String? OutpostAwsNativeId { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType (enum)
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }


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

    } // class AwsCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types