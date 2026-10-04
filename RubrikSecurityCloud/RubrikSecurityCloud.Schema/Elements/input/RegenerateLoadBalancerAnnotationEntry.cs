// RegenerateLoadBalancerAnnotationEntry.cs
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
    #region RegenerateLoadBalancerAnnotationEntry

    public class RegenerateLoadBalancerAnnotationEntry: IInput
    {
        #region members

        //      C# -> System.String? AnnotationKey
        // GraphQL -> annotationKey: String (scalar)
        [JsonProperty("annotationKey")]
        public System.String? AnnotationKey { get; set; }

        //      C# -> System.String? AnnotationValue
        // GraphQL -> annotationValue: String (scalar)
        [JsonProperty("annotationValue")]
        public System.String? AnnotationValue { get; set; }


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

    } // class RegenerateLoadBalancerAnnotationEntry
    #endregion

} // namespace RubrikSecurityCloud.Types