// RecursiveCharacterChunkerConfigInput.cs
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
    #region RecursiveCharacterChunkerConfigInput

    public class RecursiveCharacterChunkerConfigInput: IInput
    {
        #region members

        //      C# -> System.Int32? ChunkSize
        // GraphQL -> chunkSize: Int (scalar)
        [JsonProperty("chunkSize")]
        public System.Int32? ChunkSize { get; set; }

        //      C# -> System.Int32? ChunkOverlap
        // GraphQL -> chunkOverlap: Int (scalar)
        [JsonProperty("chunkOverlap")]
        public System.Int32? ChunkOverlap { get; set; }

        //      C# -> List<System.String>? Separators
        // GraphQL -> separators: [String!] (scalar)
        [JsonProperty("separators")]
        public List<System.String>? Separators { get; set; }


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

    } // class RecursiveCharacterChunkerConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types