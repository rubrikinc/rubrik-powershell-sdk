// SendPactsafeEventInput.cs
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
    #region SendPactsafeEventInput

    public class SendPactsafeEventInput: IInput
    {
        #region members

        //      C# -> System.String? VersionId
        // GraphQL -> versionId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("versionId")]
        public System.String? VersionId { get; set; }

        //      C# -> PactsafeEvent? Event
        // GraphQL -> event: PactsafeEvent! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("event")]
        public PactsafeEvent? Event { get; set; }

        //      C# -> CustomPactsafeDataInput? CustomData
        // GraphQL -> customData: CustomPactsafeDataInput (input)
        [JsonProperty("customData")]
        public CustomPactsafeDataInput? CustomData { get; set; }


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

    } // class SendPactsafeEventInput
    #endregion

} // namespace RubrikSecurityCloud.Types