// TagType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TagType

    public class TagType: IInput
    {
        #region members

        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tagKey")]
        public System.String? TagKey { get; set; }

        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tagValue")]
        public System.String? TagValue { get; set; }

        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }


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

    } // class TagType
    #endregion

} // namespace Rubrik.SecurityCloud.Types