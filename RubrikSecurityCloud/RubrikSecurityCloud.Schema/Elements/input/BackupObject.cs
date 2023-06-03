// BackupObject.cs
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
    #region BackupObject

    public class BackupObject: IInput
    {
        #region members

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> System.String? MonitoringId
        // GraphQL -> monitoringId: String (scalar)
        [JsonProperty("monitoringId")]
        public System.String? MonitoringId { get; set; }


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

    } // class BackupObject
    #endregion

} // namespace Rubrik.SecurityCloud.Types