// BackupNodePreferenceInput.cs
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
    #region BackupNodePreferenceInput

    public class BackupNodePreferenceInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ExcludedReplicaIds
        // GraphQL -> excludedReplicaIds: [String!] (scalar)
        [JsonProperty("excludedReplicaIds")]
        public List<System.String>? ExcludedReplicaIds { get; set; }

        //      C# -> List<System.String>? OrderedReplicaPreferences
        // GraphQL -> orderedReplicaPreferences: [String!] (scalar)
        [JsonProperty("orderedReplicaPreferences")]
        public List<System.String>? OrderedReplicaPreferences { get; set; }

        //      C# -> BackupNodePreferenceStrategy? Strategy
        // GraphQL -> strategy: BackupNodePreferenceStrategy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("strategy")]
        public BackupNodePreferenceStrategy? Strategy { get; set; }


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

    } // class BackupNodePreferenceInput
    #endregion

} // namespace RubrikSecurityCloud.Types