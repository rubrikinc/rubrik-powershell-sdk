// ActivitySeriesFilterInput.cs
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
    #region ActivitySeriesFilterInput

    public class ActivitySeriesFilterInput: IInput
    {
        #region members

        //      C# -> List<ActivityStatusEnum>? LastActivityStatus
        // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
        [JsonProperty("lastActivityStatus")]
        public List<ActivityStatusEnum>? LastActivityStatus { get; set; }

        //      C# -> List<ActivityTypeEnum>? LastActivityType
        // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
        [JsonProperty("lastActivityType")]
        public List<ActivityTypeEnum>? LastActivityType { get; set; }

        //      C# -> List<ActivitySeverityEnum>? Severity
        // GraphQL -> severity: [ActivitySeverityEnum!] (enum)
        [JsonProperty("severity")]
        public List<ActivitySeverityEnum>? Severity { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> List<ActivityObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ActivityObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ActivityObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> DateTime? StartTimeGt
        // GraphQL -> startTimeGt: DateTime (scalar)
        [JsonProperty("startTimeGt")]
        public DateTime? StartTimeGt { get; set; }

        //      C# -> DateTime? StartTimeLt
        // GraphQL -> startTimeLt: DateTime (scalar)
        [JsonProperty("startTimeLt")]
        public DateTime? StartTimeLt { get; set; }

        //      C# -> DateTime? LastUpdatedGt
        // GraphQL -> lastUpdatedGt: DateTime (scalar)
        [JsonProperty("lastUpdatedGt")]
        public DateTime? LastUpdatedGt { get; set; }

        //      C# -> DateTime? LastUpdatedLt
        // GraphQL -> lastUpdatedLt: DateTime (scalar)
        [JsonProperty("lastUpdatedLt")]
        public DateTime? LastUpdatedLt { get; set; }

        //      C# -> CommonClusterFilterInput? Cluster
        // GraphQL -> cluster: CommonClusterFilterInput (input)
        [JsonProperty("cluster")]
        public CommonClusterFilterInput? Cluster { get; set; }

        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [UUID!] (scalar)
        [JsonProperty("objectFids")]
        public List<System.String>? ObjectFids { get; set; }

        //      C# -> System.String? AncestorId
        // GraphQL -> ancestorId: UUID (scalar)
        [JsonProperty("ancestorId")]
        public System.String? AncestorId { get; set; }

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

    } // class ActivitySeriesFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types