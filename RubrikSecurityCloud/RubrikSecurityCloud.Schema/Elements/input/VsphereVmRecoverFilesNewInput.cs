// VsphereVmRecoverFilesNewInput.cs
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
    #region VsphereVmRecoverFilesNewInput

    public class VsphereVmRecoverFilesNewInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> RestoreFilesJobConfigInput? Config
        // GraphQL -> config: RestoreFilesJobConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public RestoreFilesJobConfigInput? Config { get; set; }

        //      C# -> DeltaRecoveryInput? DeltaRequest
        // GraphQL -> deltaRequest: DeltaRecoveryInput (input)
        [JsonProperty("deltaRequest")]
        public DeltaRecoveryInput? DeltaRequest { get; set; }


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

    } // class VsphereVmRecoverFilesNewInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types