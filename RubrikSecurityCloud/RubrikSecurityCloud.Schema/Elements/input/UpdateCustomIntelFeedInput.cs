// UpdateCustomIntelFeedInput.cs
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
    #region UpdateCustomIntelFeedInput

    public class UpdateCustomIntelFeedInput: IInput
    {
        #region members

        //      C# -> System.String? FeedId
        // GraphQL -> feedId: String (scalar)
        [JsonProperty("feedId")]
        public System.String? FeedId { get; set; }

        //      C# -> List<System.String>? EntriesToRemove
        // GraphQL -> entriesToRemove: [String!] (scalar)
        [JsonProperty("entriesToRemove")]
        public List<System.String>? EntriesToRemove { get; set; }

        //      C# -> FeedName? Name
        // GraphQL -> name: FeedName (input)
        [JsonProperty("name")]
        public FeedName? Name { get; set; }

        //      C# -> FeedDescription? Description
        // GraphQL -> description: FeedDescription (input)
        [JsonProperty("description")]
        public FeedDescription? Description { get; set; }

        //      C# -> List<CustomEntries>? EntriesToAdd
        // GraphQL -> entriesToAdd: [CustomEntries!] (input)
        [JsonProperty("entriesToAdd")]
        public List<CustomEntries>? EntriesToAdd { get; set; }


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

    } // class UpdateCustomIntelFeedInput
    #endregion

} // namespace RubrikSecurityCloud.Types