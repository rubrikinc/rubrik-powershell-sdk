// StartThreatHuntV2Input.cs
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
    #region StartThreatHuntV2Input

    public class StartThreatHuntV2Input: IInput
    {
        #region members

        //      C# -> ThreatHuntBaseConfigInputType? BaseConfig
        // GraphQL -> baseConfig: ThreatHuntBaseConfigInputType! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("baseConfig")]
        public ThreatHuntBaseConfigInputType? BaseConfig { get; set; }

        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectFids")]
        public List<System.String>? ObjectFids { get; set; }


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

    } // class StartThreatHuntV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types