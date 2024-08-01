// SalesforceApiLimits.cs
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
    #region SalesforceApiLimits

    public class SalesforceApiLimits: IInput
    {
        #region members

        //      C# -> System.Int32? RestApiLimit
        // GraphQL -> restApiLimit: Int (scalar)
        [JsonProperty("restApiLimit")]
        public System.Int32? RestApiLimit { get; set; }

        //      C# -> System.Int32? BulkApiLimit
        // GraphQL -> bulkApiLimit: Int (scalar)
        [JsonProperty("bulkApiLimit")]
        public System.Int32? BulkApiLimit { get; set; }

        //      C# -> System.Int32? BulkApiV2Limit
        // GraphQL -> bulkApiV2Limit: Int (scalar)
        [JsonProperty("bulkApiV2Limit")]
        public System.Int32? BulkApiV2Limit { get; set; }


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

    } // class SalesforceApiLimits
    #endregion

} // namespace RubrikSecurityCloud.Types