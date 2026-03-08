// ListActivitiesFilter.cs
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
    #region ListActivitiesFilter

    public class ListActivitiesFilter: IInput
    {
        #region members

        //      C# -> List<System.String>? ActivityIds
        // GraphQL -> activityIds: [UUID!] (scalar)
        [JsonProperty("activityIds")]
        public List<System.String>? ActivityIds { get; set; }

        //      C# -> List<System.String>? ActorIds
        // GraphQL -> actorIds: [String!] (scalar)
        [JsonProperty("actorIds")]
        public List<System.String>? ActorIds { get; set; }

        //      C# -> List<System.String>? TargetEntityIds
        // GraphQL -> targetEntityIds: [String!] (scalar)
        [JsonProperty("targetEntityIds")]
        public List<System.String>? TargetEntityIds { get; set; }

        //      C# -> DateTimeRange? ActivityDateRange
        // GraphQL -> activityDateRange: DateTimeRange (input)
        [JsonProperty("activityDateRange")]
        public DateTimeRange? ActivityDateRange { get; set; }

        //      C# -> IdentityFilter? IdentityFilters
        // GraphQL -> identityFilters: IdentityFilter (input)
        [JsonProperty("identityFilters")]
        public IdentityFilter? IdentityFilters { get; set; }

        //      C# -> List<ActivityCategory>? Categories
        // GraphQL -> categories: [ActivityCategory!] (enum)
        [JsonProperty("categories")]
        public List<ActivityCategory>? Categories { get; set; }

        //      C# -> List<System.String>? EntityIds
        // GraphQL -> entityIds: [String!] (scalar)
        [JsonProperty("entityIds")]
        public List<System.String>? EntityIds { get; set; }

        //      C# -> ActivityAuditorAttributeChangeFilter? AttributeChangeFilter
        // GraphQL -> attributeChangeFilter: ActivityAuditorAttributeChangeFilter (input)
        [JsonProperty("attributeChangeFilter")]
        public ActivityAuditorAttributeChangeFilter? AttributeChangeFilter { get; set; }

        //      C# -> List<System.String>? SourceDcIds
        // GraphQL -> sourceDcIds: [String!] (scalar)
        [JsonProperty("sourceDcIds")]
        public List<System.String>? SourceDcIds { get; set; }

        //      C# -> List<EventProvider>? EventProviders
        // GraphQL -> eventProviders: [EventProvider!] (enum)
        [JsonProperty("eventProviders")]
        public List<EventProvider>? EventProviders { get; set; }

        //      C# -> List<System.String>? Titles
        // GraphQL -> titles: [String!] (scalar)
        [JsonProperty("titles")]
        public List<System.String>? Titles { get; set; }

        //      C# -> List<System.String>? TargetTypes
        // GraphQL -> targetTypes: [String!] (scalar)
        [JsonProperty("targetTypes")]
        public List<System.String>? TargetTypes { get; set; }

        //      C# -> List<System.String>? ActionTypes
        // GraphQL -> actionTypes: [String!] (scalar)
        [JsonProperty("actionTypes")]
        public List<System.String>? ActionTypes { get; set; }

        //      C# -> List<LambdaEventStatus>? Statuses
        // GraphQL -> statuses: [LambdaEventStatus!] (enum)
        [JsonProperty("statuses")]
        public List<LambdaEventStatus>? Statuses { get; set; }


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

    } // class ListActivitiesFilter
    #endregion

} // namespace RubrikSecurityCloud.Types