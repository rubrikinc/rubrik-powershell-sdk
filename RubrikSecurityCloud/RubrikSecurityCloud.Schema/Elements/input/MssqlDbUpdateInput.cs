// MssqlDbUpdateInput.cs
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
    #region MssqlDbUpdateInput

    public class MssqlDbUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        [JsonProperty("maxDataStreams")]
        public System.Int32? MaxDataStreams { get; set; }

        //      C# -> MssqlScriptDetailInput? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetailInput (input)
        [JsonProperty("postBackupScript")]
        public MssqlScriptDetailInput? PostBackupScript { get; set; }

        //      C# -> MssqlScriptDetailInput? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetailInput (input)
        [JsonProperty("preBackupScript")]
        public MssqlScriptDetailInput? PreBackupScript { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> System.Boolean? ShouldForceFull
        // GraphQL -> shouldForceFull: Boolean (scalar)
        [JsonProperty("shouldForceFull")]
        public System.Boolean? ShouldForceFull { get; set; }

        //      C# -> MssqlNonSlaPropertiesInput? MssqlNonSlaProperties
        // GraphQL -> mssqlNonSlaProperties: MssqlNonSlaPropertiesInput (input)
        [JsonProperty("mssqlNonSlaProperties")]
        public MssqlNonSlaPropertiesInput? MssqlNonSlaProperties { get; set; }

        //      C# -> MssqlSlaPatchPropertiesInput? MssqlSlaPatchProperties
        // GraphQL -> mssqlSlaPatchProperties: MssqlSlaPatchPropertiesInput (input)
        [JsonProperty("mssqlSlaPatchProperties")]
        public MssqlSlaPatchPropertiesInput? MssqlSlaPatchProperties { get; set; }

        //      C# -> MssqlSlaRelatedPropertiesInput? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedPropertiesInput (input)
        [JsonProperty("mssqlSlaRelatedProperties")]
        public MssqlSlaRelatedPropertiesInput? MssqlSlaRelatedProperties { get; set; }


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

    } // class MssqlDbUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types