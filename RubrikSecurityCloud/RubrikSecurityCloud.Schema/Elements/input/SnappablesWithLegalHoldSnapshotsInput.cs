// SnappablesWithLegalHoldSnapshotsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SnappablesWithLegalHoldSnapshotsInput

    public class SnappablesWithLegalHoldSnapshotsInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> List<LegalHoldQueryFilter>? FilterParams
        // GraphQL -> filterParams: [LegalHoldQueryFilter!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filterParams")]
        public List<LegalHoldQueryFilter>? FilterParams { get; set; }

        //      C# -> LegalHoldSortParam? SortParam
        // GraphQL -> sortParam: LegalHoldSortParam (input)
        [JsonProperty("sortParam")]
        public LegalHoldSortParam? SortParam { get; set; }


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

    } // class SnappablesWithLegalHoldSnapshotsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types