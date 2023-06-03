// ValidateOracleAcoFileInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ValidateOracleAcoFileInput

    public class ValidateOracleAcoFileInput: IInput
    {
        #region members

        //      C# -> System.String? AcoContentsBase64
        // GraphQL -> acoContentsBase64: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("acoContentsBase64")]
        public System.String? AcoContentsBase64 { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isLiveMount")]
        public System.Boolean? IsLiveMount { get; set; }

        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dbId")]
        public System.String? DbId { get; set; }


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

    } // class ValidateOracleAcoFileInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types