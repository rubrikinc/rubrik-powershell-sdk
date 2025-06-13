// ManagedVolumeExportRequestInput.cs
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
    #region ManagedVolumeExportRequestInput

    public class ManagedVolumeExportRequestInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldDownloadToLocal
        // GraphQL -> shouldDownloadToLocal: Boolean (scalar)
        [JsonProperty("shouldDownloadToLocal")]
        public System.Boolean? ShouldDownloadToLocal { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> ManagedVolumeExportConfigInput? ManagedVolumeExportConfig
        // GraphQL -> managedVolumeExportConfig: ManagedVolumeExportConfigInput (input)
        [JsonProperty("managedVolumeExportConfig")]
        public ManagedVolumeExportConfigInput? ManagedVolumeExportConfig { get; set; }


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

    } // class ManagedVolumeExportRequestInput
    #endregion

} // namespace RubrikSecurityCloud.Types