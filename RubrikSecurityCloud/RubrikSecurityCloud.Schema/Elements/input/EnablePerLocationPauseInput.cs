// EnablePerLocationPauseInput.cs
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
    #region EnablePerLocationPauseInput

    public class EnablePerLocationPauseInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldCancelImmediately
        // GraphQL -> shouldCancelImmediately: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCancelImmediately")]
        public System.Boolean? ShouldCancelImmediately { get; set; }

        //      C# -> List<System.String>? SourceClusterUuids
        // GraphQL -> sourceClusterUuids: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceClusterUuids")]
        public List<System.String>? SourceClusterUuids { get; set; }

        //      C# -> System.Boolean? ShouldPauseImmediately
        // GraphQL -> shouldPauseImmediately: Boolean (scalar)
        [JsonProperty("shouldPauseImmediately")]
        public System.Boolean? ShouldPauseImmediately { get; set; }


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

    } // class EnablePerLocationPauseInput
    #endregion

} // namespace RubrikSecurityCloud.Types