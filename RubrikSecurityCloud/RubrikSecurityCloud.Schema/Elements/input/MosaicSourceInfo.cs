// MosaicSourceInfo.cs
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
    #region MosaicSourceInfo

    public class MosaicSourceInfo: IInput
    {
        #region members

        //      C# -> List<System.String>? SourceNames
        // GraphQL -> sourceNames: [String!] (scalar)
        [JsonProperty("sourceNames")]
        public List<System.String>? SourceNames { get; set; }

        //      C# -> System.Boolean? RefreshEffectiveSla
        // GraphQL -> refreshEffectiveSla: Boolean (scalar)
        [JsonProperty("refreshEffectiveSla")]
        public System.Boolean? RefreshEffectiveSla { get; set; }

        //      C# -> MosaicSourceNosqlSourceType? SourceType
        // GraphQL -> sourceType: MosaicSourceNosqlSourceType (enum)
        [JsonProperty("sourceType")]
        public MosaicSourceNosqlSourceType? SourceType { get; set; }


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

    } // class MosaicSourceInfo
    #endregion

} // namespace RubrikSecurityCloud.Types