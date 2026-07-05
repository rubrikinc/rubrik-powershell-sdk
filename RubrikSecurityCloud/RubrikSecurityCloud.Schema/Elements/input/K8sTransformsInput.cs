// K8sTransformsInput.cs
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
    #region K8sTransformsInput

    public class K8sTransformsInput: IInput
    {
        #region members

        //      C# -> System.String? PatchesJson
        // GraphQL -> patchesJson: String (scalar)
        [JsonProperty("patchesJson")]
        public System.String? PatchesJson { get; set; }

        //      C# -> ImageMappingInput? Images
        // GraphQL -> images: ImageMappingInput (input)
        [JsonProperty("images")]
        public ImageMappingInput? Images { get; set; }

        //      C# -> ConfigmapNameMappingInput? ConfigmapNames
        // GraphQL -> configmapNames: ConfigmapNameMappingInput (input)
        [JsonProperty("configmapNames")]
        public ConfigmapNameMappingInput? ConfigmapNames { get; set; }

        //      C# -> SecretNameMappingInput? SecretNames
        // GraphQL -> secretNames: SecretNameMappingInput (input)
        [JsonProperty("secretNames")]
        public SecretNameMappingInput? SecretNames { get; set; }


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

    } // class K8sTransformsInput
    #endregion

} // namespace RubrikSecurityCloud.Types