// O365ConsumptionInput.cs
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
    #region O365ConsumptionInput

    public class O365ConsumptionInput: IInput
    {
        #region members

        //      C# -> System.String? MspOrgId
        // GraphQL -> mspOrgId: UUID (scalar)
        [JsonProperty("mspOrgId")]
        public System.String? MspOrgId { get; set; }

        //      C# -> System.String? O365OrgId
        // GraphQL -> o365OrgId: UUID (scalar)
        [JsonProperty("o365OrgId")]
        public System.String? O365OrgId { get; set; }


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

    } // class O365ConsumptionInput
    #endregion

} // namespace RubrikSecurityCloud.Types