// SetShareExclusionsInput.cs
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
    #region SetShareExclusionsInput

    public class SetShareExclusionsInput: IInput
    {
        #region members

        //      C# -> System.String? ShareFid
        // GraphQL -> shareFid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shareFid")]
        public System.String? ShareFid { get; set; }

        //      C# -> List<Exclusion>? Exclusions
        // GraphQL -> exclusions: [Exclusion!] (input)
        [JsonProperty("exclusions")]
        public List<Exclusion>? Exclusions { get; set; }


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

    } // class SetShareExclusionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types