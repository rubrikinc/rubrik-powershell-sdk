// UpdateFeedInput.cs
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
    #region UpdateFeedInput

    public class UpdateFeedInput: IInput
    {
        #region members

        //      C# -> System.String? ProviderId
        // GraphQL -> providerId: String (scalar)
        [JsonProperty("providerId")]
        public System.String? ProviderId { get; set; }

        //      C# -> ProviderName? Name
        // GraphQL -> name: ProviderName (input)
        [JsonProperty("name")]
        public ProviderName? Name { get; set; }

        //      C# -> ProviderDescription? Description
        // GraphQL -> description: ProviderDescription (input)
        [JsonProperty("description")]
        public ProviderDescription? Description { get; set; }

        //      C# -> AutoQuarantineMetadataInput? AutoQuarantineMetadata
        // GraphQL -> autoQuarantineMetadata: AutoQuarantineMetadataInput (input)
        [JsonProperty("autoQuarantineMetadata")]
        public AutoQuarantineMetadataInput? AutoQuarantineMetadata { get; set; }


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

    } // class UpdateFeedInput
    #endregion

} // namespace RubrikSecurityCloud.Types