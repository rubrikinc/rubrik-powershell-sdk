// BlueprintFailoverReportGeneratorJobInfo.cs
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
    #region BlueprintFailoverReportGeneratorJobInfo

    public class BlueprintFailoverReportGeneratorJobInfo: IInput
    {
        #region members

        //      C# -> List<System.String>? FailoverIds
        // GraphQL -> failoverIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("failoverIds")]
        public List<System.String>? FailoverIds { get; set; }

        //      C# -> System.Boolean? IsNewReportEnabled
        // GraphQL -> isNewReportEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isNewReportEnabled")]
        public System.Boolean? IsNewReportEnabled { get; set; }

        //      C# -> System.Single? TimezoneOffset
        // GraphQL -> timezoneOffset: Float (scalar)
        [JsonProperty("timezoneOffset")]
        public System.Single? TimezoneOffset { get; set; }


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

    } // class BlueprintFailoverReportGeneratorJobInfo
    #endregion

} // namespace RubrikSecurityCloud.Types