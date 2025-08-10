// AwsCloudAccountsMigrateInitiateInput.cs
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
    #region AwsCloudAccountsMigrateInitiateInput

    public class AwsCloudAccountsMigrateInitiateInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> AwsRoleCustomization? AwsRoleCustomization
        // GraphQL -> awsRoleCustomization: AwsRoleCustomization (input)
        [JsonProperty("awsRoleCustomization")]
        public AwsRoleCustomization? AwsRoleCustomization { get; set; }

        //      C# -> System.String? RoleChainingAccountId
        // GraphQL -> roleChainingAccountId: UUID (scalar)
        [JsonProperty("roleChainingAccountId")]
        public System.String? RoleChainingAccountId { get; set; }


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

    } // class AwsCloudAccountsMigrateInitiateInput
    #endregion

} // namespace RubrikSecurityCloud.Types