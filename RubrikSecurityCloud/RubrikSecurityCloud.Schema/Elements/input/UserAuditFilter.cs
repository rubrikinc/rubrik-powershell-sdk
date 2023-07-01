// UserAuditFilter.cs
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
    #region UserAuditFilter

    public class UserAuditFilter: IInput
    {
        #region members

        //      C# -> List<AuditSeverity>? AuditSeverity
        // GraphQL -> auditSeverity: [AuditSeverity!] (enum)
        [JsonProperty("auditSeverity")]
        public List<AuditSeverity>? AuditSeverity { get; set; }

        //      C# -> List<AuditStatus>? AuditStatus
        // GraphQL -> auditStatus: [AuditStatus!] (enum)
        [JsonProperty("auditStatus")]
        public List<AuditStatus>? AuditStatus { get; set; }

        //      C# -> List<AuditType>? AuditType
        // GraphQL -> auditType: [AuditType!] (enum)
        [JsonProperty("auditType")]
        public List<AuditType>? AuditType { get; set; }

        //      C# -> List<AuditObjectType>? AuditObjectType
        // GraphQL -> auditObjectType: [AuditObjectType!] (enum)
        [JsonProperty("auditObjectType")]
        public List<AuditObjectType>? AuditObjectType { get; set; }

        //      C# -> List<System.String>? ClusterId
        // GraphQL -> clusterId: [UUID!] (scalar)
        [JsonProperty("clusterId")]
        public List<System.String>? ClusterId { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!] (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [String!] (scalar)
        [JsonProperty("objectFids")]
        public List<System.String>? ObjectFids { get; set; }

        //      C# -> DateTime? TimeGt
        // GraphQL -> timeGt: DateTime (scalar)
        [JsonProperty("timeGt")]
        public DateTime? TimeGt { get; set; }

        //      C# -> DateTime? TimeLt
        // GraphQL -> timeLt: DateTime (scalar)
        [JsonProperty("timeLt")]
        public DateTime? TimeLt { get; set; }

        //      C# -> System.Boolean? HasUserNote
        // GraphQL -> hasUserNote: Boolean (scalar)
        [JsonProperty("hasUserNote")]
        public System.Boolean? HasUserNote { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> List<System.String>? OrgIds
        // GraphQL -> orgIds: [String!] (scalar)
        [JsonProperty("orgIds")]
        public List<System.String>? OrgIds { get; set; }


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

    } // class UserAuditFilter
    #endregion

} // namespace RubrikSecurityCloud.Types