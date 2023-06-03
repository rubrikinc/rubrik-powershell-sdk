// EventDigestConfig.cs
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
    #region EventDigestConfig

    public class EventDigestConfig: IInput
    {
        #region members

        //      C# -> List<ActivityObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ActivityObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ActivityObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> List<ActivityStatusEnum>? ActivityStatus
        // GraphQL -> activityStatus: [ActivityStatusEnum!] (enum)
        [JsonProperty("activityStatus")]
        public List<ActivityStatusEnum>? ActivityStatus { get; set; }

        //      C# -> List<System.String>? ActivityType
        // GraphQL -> activityType: [String!] (scalar)
        [JsonProperty("activityType")]
        public List<System.String>? ActivityType { get; set; }

        //      C# -> List<ActivitySeverityEnum>? ActivitySeverity
        // GraphQL -> activitySeverity: [ActivitySeverityEnum!] (enum)
        [JsonProperty("activitySeverity")]
        public List<ActivitySeverityEnum>? ActivitySeverity { get; set; }

        //      C# -> List<System.String>? Clusters
        // GraphQL -> clusters: [String!] (scalar)
        [JsonProperty("clusters")]
        public List<System.String>? Clusters { get; set; }


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

    } // class EventDigestConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types