// GcpCloudAccountDeleteProjectsInput.cs
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
    #region GcpCloudAccountDeleteProjectsInput

    public class GcpCloudAccountDeleteProjectsInput: IInput
    {
        #region members

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> List<System.String>? NativeProtectionProjectIds
        // GraphQL -> nativeProtectionProjectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nativeProtectionProjectIds")]
        public List<System.String>? NativeProtectionProjectIds { get; set; }

        //      C# -> List<System.String>? SharedVpcHostProjectIds
        // GraphQL -> sharedVpcHostProjectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sharedVpcHostProjectIds")]
        public List<System.String>? SharedVpcHostProjectIds { get; set; }

        //      C# -> List<System.String>? CloudAccountsProjectIds
        // GraphQL -> cloudAccountsProjectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountsProjectIds")]
        public List<System.String>? CloudAccountsProjectIds { get; set; }

        //      C# -> System.Boolean? SkipResourceDeletion
        // GraphQL -> skipResourceDeletion: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("skipResourceDeletion")]
        public System.Boolean? SkipResourceDeletion { get; set; }


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

    } // class GcpCloudAccountDeleteProjectsInput
    #endregion

} // namespace RubrikSecurityCloud.Types