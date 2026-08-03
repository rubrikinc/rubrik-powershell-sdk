// QuiesceTargetInput.cs
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
    #region QuiesceTargetInput

    public class QuiesceTargetInput: IInput
    {
        #region members

        //      C# -> VmBackupScriptInput? PostSnapScript
        // GraphQL -> postSnapScript: VmBackupScriptInput (input)
        [JsonProperty("postSnapScript")]
        public VmBackupScriptInput? PostSnapScript { get; set; }

        //      C# -> VmBackupScriptInput? PreBackupScript
        // GraphQL -> preBackupScript: VmBackupScriptInput (input)
        [JsonProperty("preBackupScript")]
        public VmBackupScriptInput? PreBackupScript { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: UUID (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> QuiesceTargetTargetType? TargetType
        // GraphQL -> targetType: QuiesceTargetTargetType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("targetType")]
        public QuiesceTargetTargetType? TargetType { get; set; }

        //      C# -> VmBackupScriptInput? PostBackupScript
        // GraphQL -> postBackupScript: VmBackupScriptInput (input)
        [JsonProperty("postBackupScript")]
        public VmBackupScriptInput? PostBackupScript { get; set; }


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

    } // class QuiesceTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types