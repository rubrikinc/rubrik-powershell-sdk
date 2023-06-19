// AssignProtectionInput.cs
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
    #region AssignProtectionInput

    public class AssignProtectionInput: IInput
    {
        #region members

        //      C# -> System.String? GlobalSlaOptionalFid
        // GraphQL -> globalSlaOptionalFid: UUID (scalar)
        [JsonProperty("globalSlaOptionalFid")]
        public System.String? GlobalSlaOptionalFid { get; set; }

        //      C# -> SlaAssignTypeEnum? GlobalSlaAssignType
        // GraphQL -> globalSlaAssignType: SlaAssignTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("globalSlaAssignType")]
        public SlaAssignTypeEnum? GlobalSlaAssignType { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> MosaicSlaInfoInput? BackupInput
        // GraphQL -> backupInput: MosaicSlaInfoInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("backupInput")]
        public MosaicSlaInfoInput? BackupInput { get; set; }


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

    } // class AssignProtectionInput
    #endregion

} // namespace RubrikSecurityCloud.Types