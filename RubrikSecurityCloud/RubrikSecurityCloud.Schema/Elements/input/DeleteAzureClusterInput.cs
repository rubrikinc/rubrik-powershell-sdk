// DeleteAzureClusterInput.cs
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
    #region DeleteAzureClusterInput

    public class DeleteAzureClusterInput: IInput
    {
        #region members

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> System.String? NetworkResourceGroup
        // GraphQL -> networkResourceGroup: String (scalar)
        [JsonProperty("networkResourceGroup")]
        public System.String? NetworkResourceGroup { get; set; }

        //      C# -> System.Boolean? IsEsType
        // GraphQL -> isEsType: Boolean (scalar)
        [JsonProperty("isEsType")]
        public System.Boolean? IsEsType { get; set; }

        //      C# -> System.String? StorageAccount
        // GraphQL -> storageAccount: String (scalar)
        [JsonProperty("storageAccount")]
        public System.String? StorageAccount { get; set; }

        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String (scalar)
        [JsonProperty("containerName")]
        public System.String? ContainerName { get; set; }

        //      C# -> System.String? StorageResourceGroup
        // GraphQL -> storageResourceGroup: String (scalar)
        [JsonProperty("storageResourceGroup")]
        public System.String? StorageResourceGroup { get; set; }

        //      C# -> System.Boolean? IsNewContainer
        // GraphQL -> isNewContainer: Boolean (scalar)
        [JsonProperty("isNewContainer")]
        public System.Boolean? IsNewContainer { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


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

    } // class DeleteAzureClusterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types