// SharePointFullRestoreConfig.cs
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
    #region SharePointFullRestoreConfig

    public class SharePointFullRestoreConfig: IInput
    {
        #region members

        //      C# -> SharePointObject? SpObjectToRestore
        // GraphQL -> spObjectToRestore: SharePointObject (input)
        [JsonProperty("spObjectToRestore")]
        public SharePointObject? SpObjectToRestore { get; set; }

        //      C# -> SharePointItems? SpItemsToRestore
        // GraphQL -> spItemsToRestore: SharePointItems (input)
        [JsonProperty("spItemsToRestore")]
        public SharePointItems? SpItemsToRestore { get; set; }

        //      C# -> System.String? TargetObjectUuid
        // GraphQL -> targetObjectUuid: UUID (scalar)
        [JsonProperty("targetObjectUuid")]
        public System.String? TargetObjectUuid { get; set; }

        //      C# -> SnappableType? TargetObjectType
        // GraphQL -> targetObjectType: SnappableType (enum)
        [JsonProperty("targetObjectType")]
        public SnappableType? TargetObjectType { get; set; }

        //      C# -> System.Boolean? ShouldCreateNewObject
        // GraphQL -> shouldCreateNewObject: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCreateNewObject")]
        public System.Boolean? ShouldCreateNewObject { get; set; }

        //      C# -> SnappableType? NewObjectType
        // GraphQL -> newObjectType: SnappableType (enum)
        [JsonProperty("newObjectType")]
        public SnappableType? NewObjectType { get; set; }

        //      C# -> System.String? NewObjectName
        // GraphQL -> newObjectName: String (scalar)
        [JsonProperty("newObjectName")]
        public System.String? NewObjectName { get; set; }


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

    } // class SharePointFullRestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types