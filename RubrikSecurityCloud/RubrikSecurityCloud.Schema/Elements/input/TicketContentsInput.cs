// TicketContentsInput.cs
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
    #region TicketContentsInput

    public class TicketContentsInput: IInput
    {
        #region members

        //      C# -> System.String? Title
        // GraphQL -> title: String (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Comment
        // GraphQL -> comment: String (scalar)
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }

        //      C# -> System.String? ProjectKey
        // GraphQL -> projectKey: String (scalar)
        [JsonProperty("projectKey")]
        public System.String? ProjectKey { get; set; }

        //      C# -> System.String? TicketTypeId
        // GraphQL -> ticketTypeId: String (scalar)
        [JsonProperty("ticketTypeId")]
        public System.String? TicketTypeId { get; set; }

        //      C# -> List<TicketFieldEntryInput>? RequiredFields
        // GraphQL -> requiredFields: [TicketFieldEntryInput!] (input)
        [JsonProperty("requiredFields")]
        public List<TicketFieldEntryInput>? RequiredFields { get; set; }


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

    } // class TicketContentsInput
    #endregion

} // namespace RubrikSecurityCloud.Types