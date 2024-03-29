// ApproveRcvPrivateEndpointInput.cs
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
    #region ApproveRcvPrivateEndpointInput

    public class ApproveRcvPrivateEndpointInput: IInput
    {
        #region members

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("privateEndpointId")]
        public System.String? PrivateEndpointId { get; set; }

        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("requestMessage")]
        public System.String? RequestMessage { get; set; }


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

    } // class ApproveRcvPrivateEndpointInput
    #endregion

} // namespace RubrikSecurityCloud.Types