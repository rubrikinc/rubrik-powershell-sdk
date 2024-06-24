// GroupFilterAttribute.cs
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
    #region GroupFilterAttribute

    public class GroupFilterAttribute: IInput
    {
        #region members

        //      C# -> JoinOpType? FilterOpType
        // GraphQL -> filterOpType: JoinOpType (enum)
        [JsonProperty("filterOpType")]
        public JoinOpType? FilterOpType { get; set; }

        //      C# -> AttributeType? AttributeType
        // GraphQL -> attributeType: AttributeType (enum)
        [JsonProperty("attributeType")]
        public AttributeType? AttributeType { get; set; }

        //      C# -> System.String? AttributeKey
        // GraphQL -> attributeKey: String (scalar)
        [JsonProperty("attributeKey")]
        public System.String? AttributeKey { get; set; }

        //      C# -> System.String? AttributeValue
        // GraphQL -> attributeValue: String (scalar)
        [JsonProperty("attributeValue")]
        public System.String? AttributeValue { get; set; }


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

    } // class GroupFilterAttribute
    #endregion

} // namespace RubrikSecurityCloud.Types