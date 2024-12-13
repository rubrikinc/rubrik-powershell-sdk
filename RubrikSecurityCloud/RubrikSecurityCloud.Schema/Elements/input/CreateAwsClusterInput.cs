// CreateAwsClusterInput.cs
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
    #region CreateAwsClusterInput

    public class CreateAwsClusterInput: IInput
    {
        #region members

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.Boolean? IsEsType
        // GraphQL -> isEsType: Boolean (scalar)
        [JsonProperty("isEsType")]
        public System.Boolean? IsEsType { get; set; }

        //      C# -> System.Boolean? KeepClusterOnFailure
        // GraphQL -> keepClusterOnFailure: Boolean (scalar)
        [JsonProperty("keepClusterOnFailure")]
        public System.Boolean? KeepClusterOnFailure { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.Boolean? DisableApiTermination
        // GraphQL -> disableApiTermination: Boolean (scalar)
        [JsonProperty("disableApiTermination")]
        public System.Boolean? DisableApiTermination { get; set; }

        //      C# -> System.Boolean? UsePlacementGroups
        // GraphQL -> usePlacementGroups: Boolean (scalar)
        [JsonProperty("usePlacementGroups")]
        public System.Boolean? UsePlacementGroups { get; set; }

        //      C# -> ClusterConfigInput? ClusterConfig
        // GraphQL -> clusterConfig: ClusterConfigInput (input)
        [JsonProperty("clusterConfig")]
        public ClusterConfigInput? ClusterConfig { get; set; }

        //      C# -> AwsVmConfig? VmConfig
        // GraphQL -> vmConfig: AwsVmConfig (input)
        [JsonProperty("vmConfig")]
        public AwsVmConfig? VmConfig { get; set; }

        //      C# -> List<ClusterCreateValidations>? Validations
        // GraphQL -> validations: [ClusterCreateValidations!] (enum)
        [JsonProperty("validations")]
        public List<ClusterCreateValidations>? Validations { get; set; }


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

    } // class CreateAwsClusterInput
    #endregion

} // namespace RubrikSecurityCloud.Types