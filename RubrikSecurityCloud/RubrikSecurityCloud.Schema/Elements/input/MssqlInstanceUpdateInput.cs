// MssqlInstanceUpdateInput.cs
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
    #region MssqlInstanceUpdateInput

    public class MssqlInstanceUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> MssqlNonSlaPropertiesInput? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaPropertiesInput (input)
        [JsonProperty("mssqlNonSlaProperties")]
        public MssqlNonSlaPropertiesInput? MssqlNonSlaProperties { get; set; }

        //      C# -> MssqlSlaPatchPropertiesInput? MssqlSlaPatchProperties
        // GraphQL -> mssqlSlaPatchProperties: MssqlSlaPatchPropertiesInput (input)
        [JsonProperty("mssqlSlaPatchProperties")]
        public MssqlSlaPatchPropertiesInput? MssqlSlaPatchProperties { get; set; }

        //      C# -> MssqlSlaRelatedPropertiesInput? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedPropertiesInput (input)
        [JsonProperty("mssqlSlaRelatedProperties")]
        public MssqlSlaRelatedPropertiesInput? MssqlSlaRelatedProperties { get; set; }


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

    } // class MssqlInstanceUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types