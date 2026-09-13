// UnarchiveObjectInfo.cs
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
    #region UnarchiveObjectInfo

    public class UnarchiveObjectInfo: IInput
    {
        #region members

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> ArchivedRecordCriteria? RecordCriteria
        // GraphQL -> recordCriteria: ArchivedRecordCriteria (input)
        [JsonProperty("recordCriteria")]
        public ArchivedRecordCriteria? RecordCriteria { get; set; }

        //      C# -> UnarchiveRecordsInfo? RecordsToUnarchive
        // GraphQL -> recordsToUnarchive: UnarchiveRecordsInfo (input)
        [JsonProperty("recordsToUnarchive")]
        public UnarchiveRecordsInfo? RecordsToUnarchive { get; set; }

        //      C# -> SalesforceArchivalCascadeNodeInput? CascadePolicy
        // GraphQL -> cascadePolicy: SalesforceArchivalCascadeNodeInput (input)
        [JsonProperty("cascadePolicy")]
        public SalesforceArchivalCascadeNodeInput? CascadePolicy { get; set; }

        //      C# -> System.Boolean? AreAutomationsDisabled
        // GraphQL -> areAutomationsDisabled: Boolean (scalar)
        [JsonProperty("areAutomationsDisabled")]
        public System.Boolean? AreAutomationsDisabled { get; set; }


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

    } // class UnarchiveObjectInfo
    #endregion

} // namespace RubrikSecurityCloud.Types