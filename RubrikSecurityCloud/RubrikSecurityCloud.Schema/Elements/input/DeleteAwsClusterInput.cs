// DeleteAwsClusterInput.cs
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
    #region DeleteAwsClusterInput

    public class DeleteAwsClusterInput: IInput
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

        //      C# -> System.Boolean? IsEsType
        // GraphQL -> isEsType: Boolean (scalar)
        [JsonProperty("isEsType")]
        public System.Boolean? IsEsType { get; set; }

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String (scalar)
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.Boolean? IsNewContainer
        // GraphQL -> isNewContainer: Boolean (scalar)
        [JsonProperty("isNewContainer")]
        public System.Boolean? IsNewContainer { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }


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

    } // class DeleteAwsClusterInput
    #endregion

} // namespace RubrikSecurityCloud.Types