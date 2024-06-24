// CustomEntries.cs
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
    #region CustomEntries

    public class CustomEntries: IInput
    {
        #region members

        //      C# -> System.String? IocString
        // GraphQL -> iocString: String (scalar)
        [JsonProperty("iocString")]
        public System.String? IocString { get; set; }

        //      C# -> System.String? ThreatFamily
        // GraphQL -> threatFamily: String (scalar)
        [JsonProperty("threatFamily")]
        public System.String? ThreatFamily { get; set; }

        //      C# -> ThreatFeedType? IocType
        // GraphQL -> iocType: ThreatFeedType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("iocType")]
        public ThreatFeedType? IocType { get; set; }


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

    } // class CustomEntries
    #endregion

} // namespace RubrikSecurityCloud.Types