// RegisterAwsFeatureArtifactsInput.cs
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
    #region RegisterAwsFeatureArtifactsInput

    public class RegisterAwsFeatureArtifactsInput: IInput
    {
        #region members

        //      C# -> List<AwsAccountFeatureArtifact>? AwsArtifacts
        // GraphQL -> awsArtifacts: [AwsAccountFeatureArtifact!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("awsArtifacts")]
        public List<AwsAccountFeatureArtifact>? AwsArtifacts { get; set; }

        //      C# -> System.String? RoleChainingAccountId
        // GraphQL -> roleChainingAccountId: UUID (scalar)
        [JsonProperty("roleChainingAccountId")]
        public System.String? RoleChainingAccountId { get; set; }

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType (enum)
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }


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

    } // class RegisterAwsFeatureArtifactsInput
    #endregion

} // namespace RubrikSecurityCloud.Types