// AwsS3BucketDestinationInput.cs
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
    #region AwsS3BucketDestinationInput

    public class AwsS3BucketDestinationInput: IInput
    {
        #region members

        //      C# -> AwsS3ExistingBucketTargetInput? ExistingBucket
        // GraphQL -> existingBucket: AwsS3ExistingBucketTargetInput (input)
        [JsonProperty("existingBucket")]
        public AwsS3ExistingBucketTargetInput? ExistingBucket { get; set; }

        //      C# -> AwsS3NewBucketTargetInput? NewBucket
        // GraphQL -> newBucket: AwsS3NewBucketTargetInput (input)
        [JsonProperty("newBucket")]
        public AwsS3NewBucketTargetInput? NewBucket { get; set; }


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

    } // class AwsS3BucketDestinationInput
    #endregion

} // namespace RubrikSecurityCloud.Types