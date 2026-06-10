// GetLatestGpoSettingsReq.cs
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
    #region GetLatestGpoSettingsReq

    public class GetLatestGpoSettingsReq: IInput
    {
        #region members

        //      C# -> System.String? GpoFid
        // GraphQL -> gpoFid: String (scalar)
        [JsonProperty("gpoFid")]
        public System.String? GpoFid { get; set; }

        //      C# -> System.Boolean? ShouldReturnXml
        // GraphQL -> shouldReturnXml: Boolean (scalar)
        [JsonProperty("shouldReturnXml")]
        public System.Boolean? ShouldReturnXml { get; set; }

        //      C# -> System.Boolean? ReturnUniformJson
        // GraphQL -> returnUniformJson: Boolean (scalar)
        [JsonProperty("returnUniformJson")]
        public System.Boolean? ReturnUniformJson { get; set; }

        //      C# -> System.Boolean? JsonDisplayFieldsOnly
        // GraphQL -> jsonDisplayFieldsOnly: Boolean (scalar)
        [JsonProperty("jsonDisplayFieldsOnly")]
        public System.Boolean? JsonDisplayFieldsOnly { get; set; }


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

    } // class GetLatestGpoSettingsReq
    #endregion

} // namespace RubrikSecurityCloud.Types