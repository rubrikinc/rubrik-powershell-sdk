// TagCondition.cs
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
    #region TagCondition

    public class TagCondition: IInput
    {
        #region members

        //      C# -> TagConditionKeyPrefix? KeyPrefix
        // GraphQL -> keyPrefix: TagConditionKeyPrefix (enum)
        [JsonProperty("keyPrefix")]
        public TagConditionKeyPrefix? KeyPrefix { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> TagConditionOperator? Operator
        // GraphQL -> operator: TagConditionOperator (enum)
        [JsonProperty("operator")]
        public TagConditionOperator? Operator { get; set; }

        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!] (scalar)
        [JsonProperty("values")]
        public List<System.String>? Values { get; set; }


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

    } // class TagCondition
    #endregion

} // namespace RubrikSecurityCloud.Types