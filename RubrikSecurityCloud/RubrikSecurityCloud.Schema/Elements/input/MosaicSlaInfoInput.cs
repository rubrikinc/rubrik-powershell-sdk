// MosaicSlaInfoInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MosaicSlaInfoInput

    public class MosaicSlaInfoInput: IInput
    {
        #region members

        //      C# -> MosaicBackupStoreInfoInput? MosaicBackupStoreInfo
        // GraphQL -> mosaicBackupStoreInfo: MosaicBackupStoreInfoInput (input)
        [JsonProperty("mosaicBackupStoreInfo")]
        public MosaicBackupStoreInfoInput? MosaicBackupStoreInfo { get; set; }

        //      C# -> MosaicMonitorInfoInput? MosaicMonitorInfo
        // GraphQL -> mosaicMonitorInfo: MosaicMonitorInfoInput (input)
        [JsonProperty("mosaicMonitorInfo")]
        public MosaicMonitorInfoInput? MosaicMonitorInfo { get; set; }

        //      C# -> System.Boolean? ShouldBackupIndex
        // GraphQL -> shouldBackupIndex: Boolean (scalar)
        [JsonProperty("shouldBackupIndex")]
        public System.Boolean? ShouldBackupIndex { get; set; }

        //      C# -> System.Boolean? ShouldDelete
        // GraphQL -> shouldDelete: Boolean (scalar)
        [JsonProperty("shouldDelete")]
        public System.Boolean? ShouldDelete { get; set; }

        //      C# -> System.Boolean? ShouldDeleteData
        // GraphQL -> shouldDeleteData: Boolean (scalar)
        [JsonProperty("shouldDeleteData")]
        public System.Boolean? ShouldDeleteData { get; set; }


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

    } // class MosaicSlaInfoInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types