// SharePointObject.cs
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
    #region SharePointObject

    public class SharePointObject: IInput
    {
        #region members

        //      C# -> System.String? ObjectSharepointId
        // GraphQL -> objectSharepointId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectSharepointId")]
        public System.String? ObjectSharepointId { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> SnappableType? ObjectType
        // GraphQL -> objectType: SnappableType (enum)
        [JsonProperty("objectType")]
        public SnappableType? ObjectType { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

        //      C# -> System.String? SiteOwnerEmail
        // GraphQL -> siteOwnerEmail: String (scalar)
        [JsonProperty("siteOwnerEmail")]
        public System.String? SiteOwnerEmail { get; set; }


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

    } // class SharePointObject
    #endregion

} // namespace RubrikSecurityCloud.Types