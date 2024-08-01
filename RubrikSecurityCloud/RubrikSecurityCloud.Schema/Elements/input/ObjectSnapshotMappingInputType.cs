// ObjectSnapshotMappingInputType.cs
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
    #region ObjectSnapshotMappingInputType

    public class ObjectSnapshotMappingInputType: IInput
    {
        #region members

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> List<System.String>? SnapshotFid
        // GraphQL -> snapshotFid: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public List<System.String>? SnapshotFid { get; set; }


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

    } // class ObjectSnapshotMappingInputType
    #endregion

} // namespace RubrikSecurityCloud.Types