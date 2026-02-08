// M365MetadataInput.cs
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
    #region M365MetadataInput

    public class M365MetadataInput: IInput
    {
        #region members

        //      C# -> System.String? FileId
        // GraphQL -> fileId: String (scalar)
        [JsonProperty("fileId")]
        public System.String? FileId { get; set; }

        //      C# -> System.String? ParentObjectId
        // GraphQL -> parentObjectId: UUID (scalar)
        [JsonProperty("parentObjectId")]
        public System.String? ParentObjectId { get; set; }

        //      C# -> System.String? ParentObjectType
        // GraphQL -> parentObjectType: UUID (scalar)
        [JsonProperty("parentObjectType")]
        public System.String? ParentObjectType { get; set; }


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

    } // class M365MetadataInput
    #endregion

} // namespace RubrikSecurityCloud.Types