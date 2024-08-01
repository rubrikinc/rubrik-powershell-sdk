// FailoverFilterInput.cs
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
    #region FailoverFilterInput

    public class FailoverFilterInput: IInput
    {
        #region members

        //      C# -> DateTime? TimeGt
        // GraphQL -> timeGt: DateTime (scalar)
        [JsonProperty("timeGt")]
        public DateTime? TimeGt { get; set; }

        //      C# -> DateTime? TimeLt
        // GraphQL -> timeLt: DateTime (scalar)
        [JsonProperty("timeLt")]
        public DateTime? TimeLt { get; set; }

        //      C# -> List<FailoverStatusEnum>? FailoverStatus
        // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
        [JsonProperty("failoverStatus")]
        public List<FailoverStatusEnum>? FailoverStatus { get; set; }

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> List<System.String>? Source
        // GraphQL -> source: [String!] (scalar)
        [JsonProperty("source")]
        public List<System.String>? Source { get; set; }

        //      C# -> List<System.String>? TargetSite
        // GraphQL -> targetSite: [String!] (scalar)
        [JsonProperty("targetSite")]
        public List<System.String>? TargetSite { get; set; }


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

    } // class FailoverFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types