// O365PdlAndWorkloadPairInput.cs
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
    #region O365PdlAndWorkloadPairInput

    public class O365PdlAndWorkloadPairInput: IInput
    {
        #region members

        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("pdl")]
        public System.String? Pdl { get; set; }

        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("workload")]
        public WorkloadLevelHierarchy? Workload { get; set; }


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

    } // class O365PdlAndWorkloadPairInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types