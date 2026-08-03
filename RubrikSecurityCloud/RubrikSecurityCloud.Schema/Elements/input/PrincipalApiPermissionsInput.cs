// PrincipalApiPermissionsInput.cs
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
    #region PrincipalApiPermissionsInput

    public class PrincipalApiPermissionsInput: IInput
    {
        #region members

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? TimelineDate
        // GraphQL -> timelineDate: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("timelineDate")]
        public System.String? TimelineDate { get; set; }

        //      C# -> List<ListApiPermissionsSort>? ApiPermissionsSort
        // GraphQL -> apiPermissionsSort: [ListApiPermissionsSort!] (input)
        [JsonProperty("apiPermissionsSort")]
        public List<ListApiPermissionsSort>? ApiPermissionsSort { get; set; }

        //      C# -> ApiPermissionsFilter? ApiPermissionsFilter
        // GraphQL -> apiPermissionsFilter: ApiPermissionsFilter (input)
        [JsonProperty("apiPermissionsFilter")]
        public ApiPermissionsFilter? ApiPermissionsFilter { get; set; }


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

    } // class PrincipalApiPermissionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types