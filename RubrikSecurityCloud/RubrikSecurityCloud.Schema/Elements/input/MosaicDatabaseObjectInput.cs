// MosaicDatabaseObjectInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MosaicDatabaseObjectInput

    public class MosaicDatabaseObjectInput: IInput
    {
        #region members

        //      C# -> System.String? DbName
        // GraphQL -> dbName: String (scalar)
        [JsonProperty("dbName")]
        public System.String? DbName { get; set; }

        //      C# -> List<System.String>? Tables
        // GraphQL -> tables: [String!] (scalar)
        [JsonProperty("tables")]
        public List<System.String>? Tables { get; set; }


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

    } // class MosaicDatabaseObjectInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types