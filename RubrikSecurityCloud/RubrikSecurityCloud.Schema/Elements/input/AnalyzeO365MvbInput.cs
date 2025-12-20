// AnalyzeO365MvbInput.cs
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
    #region AnalyzeO365MvbInput

    public class AnalyzeO365MvbInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.Int32? LastNumberOfDays
        // GraphQL -> lastNumberOfDays: Int (scalar)
        [JsonProperty("lastNumberOfDays")]
        public System.Int32? LastNumberOfDays { get; set; }

        //      C# -> List<O365MvbWorkloadType>? Workloads
        // GraphQL -> workloads: [O365MvbWorkloadType!] (enum)
        [JsonProperty("workloads")]
        public List<O365MvbWorkloadType>? Workloads { get; set; }

        //      C# -> System.Boolean? ShouldExcludeArchivedMailbox
        // GraphQL -> shouldExcludeArchivedMailbox: Boolean (scalar)
        [JsonProperty("shouldExcludeArchivedMailbox")]
        public System.Boolean? ShouldExcludeArchivedMailbox { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }


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

    } // class AnalyzeO365MvbInput
    #endregion

} // namespace RubrikSecurityCloud.Types