// AwsS3BucketRecoveryTargetInput.cs
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
    #region AwsS3BucketRecoveryTargetInput

    public class AwsS3BucketRecoveryTargetInput: IInput
    {
        #region members

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.Boolean? ShouldRecoverFullBucket
        // GraphQL -> shouldRecoverFullBucket: Boolean (scalar)
        [JsonProperty("shouldRecoverFullBucket")]
        public System.Boolean? ShouldRecoverFullBucket { get; set; }

        //      C# -> List<System.String>? RegexPatterns
        // GraphQL -> regexPatterns: [String!] (scalar)
        [JsonProperty("regexPatterns")]
        public List<System.String>? RegexPatterns { get; set; }

        //      C# -> AwsS3BucketDestinationInput? Destination
        // GraphQL -> destination: AwsS3BucketDestinationInput (input)
        [JsonProperty("destination")]
        public AwsS3BucketDestinationInput? Destination { get; set; }


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

    } // class AwsS3BucketRecoveryTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types