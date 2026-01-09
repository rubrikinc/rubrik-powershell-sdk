// UpdateVcenterInput.cs
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
    #region UpdateVcenterInput

    public class UpdateVcenterInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV50
        // GraphQL -> updatePropertiesV50: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV50")]
        public VcenterConfigInput? UpdatePropertiesV50 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV51
        // GraphQL -> updatePropertiesV51: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV51")]
        public VcenterConfigInput? UpdatePropertiesV51 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV52
        // GraphQL -> updatePropertiesV52: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV52")]
        public VcenterConfigInput? UpdatePropertiesV52 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV53
        // GraphQL -> updatePropertiesV53: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV53")]
        public VcenterConfigInput? UpdatePropertiesV53 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV60
        // GraphQL -> updatePropertiesV60: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV60")]
        public VcenterConfigInput? UpdatePropertiesV60 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV70
        // GraphQL -> updatePropertiesV70: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV70")]
        public VcenterConfigInput? UpdatePropertiesV70 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV80
        // GraphQL -> updatePropertiesV80: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV80")]
        public VcenterConfigInput? UpdatePropertiesV80 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV81
        // GraphQL -> updatePropertiesV81: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV81")]
        public VcenterConfigInput? UpdatePropertiesV81 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV90
        // GraphQL -> updatePropertiesV90: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV90")]
        public VcenterConfigInput? UpdatePropertiesV90 { get; set; }

        //      C# -> VcenterConfigInput? UpdatePropertiesV91
        // GraphQL -> updatePropertiesV91: VcenterConfigInput (input)
        [JsonProperty("updatePropertiesV91")]
        public VcenterConfigInput? UpdatePropertiesV91 { get; set; }

        //      C# -> VcenterUpdateConfigInput? UpdatePropertiesV92
        // GraphQL -> updatePropertiesV92: VcenterUpdateConfigInput (input)
        [JsonProperty("updatePropertiesV92")]
        public VcenterUpdateConfigInput? UpdatePropertiesV92 { get; set; }

        //      C# -> VcenterUpdateConfigInput? UpdatePropertiesV93
        // GraphQL -> updatePropertiesV93: VcenterUpdateConfigInput (input)
        [JsonProperty("updatePropertiesV93")]
        public VcenterUpdateConfigInput? UpdatePropertiesV93 { get; set; }

        //      C# -> VcenterUpdateConfigInput? UpdatePropertiesV94
        // GraphQL -> updatePropertiesV94: VcenterUpdateConfigInput (input)
        [JsonProperty("updatePropertiesV94")]
        public VcenterUpdateConfigInput? UpdatePropertiesV94 { get; set; }

        //      C# -> VcenterUpdateConfigInput? UpdatePropertiesV95
        // GraphQL -> updatePropertiesV95: VcenterUpdateConfigInput (input)
        [JsonProperty("updatePropertiesV95")]
        public VcenterUpdateConfigInput? UpdatePropertiesV95 { get; set; }

        //      C# -> VcenterUpdateConfigInput? UpdatePropertiesV96
        // GraphQL -> updatePropertiesV96: VcenterUpdateConfigInput (input)
        [JsonProperty("updatePropertiesV96")]
        public VcenterUpdateConfigInput? UpdatePropertiesV96 { get; set; }


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

    } // class UpdateVcenterInput
    #endregion

} // namespace RubrikSecurityCloud.Types