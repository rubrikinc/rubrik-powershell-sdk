// AmiTypeForAwsNativeArchivedSnapshotExportInput.cs
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
    #region AmiTypeForAwsNativeArchivedSnapshotExportInput

    public class AmiTypeForAwsNativeArchivedSnapshotExportInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> AwsNativeRegion? DestinationRegionId
        // GraphQL -> destinationRegionId: AwsNativeRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegionId")]
        public AwsNativeRegion? DestinationRegionId { get; set; }

        //      C# -> System.String? DestinationAwsAccountRubrikId
        // GraphQL -> destinationAwsAccountRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationAwsAccountRubrikId")]
        public System.String? DestinationAwsAccountRubrikId { get; set; }


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

    } // class AmiTypeForAwsNativeArchivedSnapshotExportInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types