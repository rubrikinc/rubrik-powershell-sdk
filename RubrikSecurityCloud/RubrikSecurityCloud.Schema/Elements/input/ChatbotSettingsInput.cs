// ChatbotSettingsInput.cs
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
    #region ChatbotSettingsInput

    public class ChatbotSettingsInput: IInput
    {
        #region members

        //      C# -> System.Boolean? EnableDocLevelAccessControl
        // GraphQL -> enableDocLevelAccessControl: Boolean (scalar)
        [JsonProperty("enableDocLevelAccessControl")]
        public System.Boolean? EnableDocLevelAccessControl { get; set; }

        //      C# -> System.String? SystemMessage
        // GraphQL -> systemMessage: String (scalar)
        [JsonProperty("systemMessage")]
        public System.String? SystemMessage { get; set; }

        //      C# -> System.Int32? NumChunksToRetrieve
        // GraphQL -> numChunksToRetrieve: Int (scalar)
        [JsonProperty("numChunksToRetrieve")]
        public System.Int32? NumChunksToRetrieve { get; set; }


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

    } // class ChatbotSettingsInput
    #endregion

} // namespace RubrikSecurityCloud.Types