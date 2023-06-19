// UpdatePolicyInput.cs
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
    #region UpdatePolicyInput

    public class UpdatePolicyInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor (enum)
        [JsonProperty("colorEnum")]
        public ClassificationPolicyColor? ColorEnum { get; set; }

        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode (enum)
        [JsonProperty("mode")]
        public ClassificationPolicyMode? Mode { get; set; }

        //      C# -> List<System.String>? AnalyzerIds
        // GraphQL -> analyzerIds: [String!] (scalar)
        [JsonProperty("analyzerIds")]
        public List<System.String>? AnalyzerIds { get; set; }

        //      C# -> System.Boolean? UpdateName
        // GraphQL -> updateName: Boolean (scalar)
        [JsonProperty("updateName")]
        public System.Boolean? UpdateName { get; set; }

        //      C# -> System.Boolean? UpdateDescription
        // GraphQL -> updateDescription: Boolean (scalar)
        [JsonProperty("updateDescription")]
        public System.Boolean? UpdateDescription { get; set; }

        //      C# -> System.Boolean? UpdateMode
        // GraphQL -> updateMode: Boolean (scalar)
        [JsonProperty("updateMode")]
        public System.Boolean? UpdateMode { get; set; }

        //      C# -> System.Boolean? UpdateAnalyzerIds
        // GraphQL -> updateAnalyzerIds: Boolean (scalar)
        [JsonProperty("updateAnalyzerIds")]
        public System.Boolean? UpdateAnalyzerIds { get; set; }


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

    } // class UpdatePolicyInput
    #endregion

} // namespace RubrikSecurityCloud.Types