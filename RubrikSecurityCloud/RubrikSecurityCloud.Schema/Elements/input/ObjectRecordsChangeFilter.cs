// ObjectRecordsChangeFilter.cs
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
    #region ObjectRecordsChangeFilter

    public class ObjectRecordsChangeFilter: IInput
    {
        #region members

        //      C# -> List<AppItemActionType>? ActionTypes
        // GraphQL -> actionTypes: [AppItemActionType!] (enum)
        [JsonProperty("actionTypes")]
        public List<AppItemActionType>? ActionTypes { get; set; }

        //      C# -> List<WhereSqlClauseItem>? ClauseItems
        // GraphQL -> clauseItems: [WhereSqlClauseItem!] (input)
        [JsonProperty("clauseItems")]
        public List<WhereSqlClauseItem>? ClauseItems { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }


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

    } // class ObjectRecordsChangeFilter
    #endregion

} // namespace RubrikSecurityCloud.Types