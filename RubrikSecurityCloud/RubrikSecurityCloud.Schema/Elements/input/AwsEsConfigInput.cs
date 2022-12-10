// AwsEsConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AwsEsConfigInput

    public class AwsEsConfigInput
    {
        #region members
        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String (scalar)
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.Boolean? ShouldCreateBucket
        // GraphQL -> shouldCreateBucket: Boolean (scalar)
        [JsonProperty("shouldCreateBucket")]
        public System.Boolean? ShouldCreateBucket { get; set; }

        //      C# -> System.Boolean? EnableObjectLock
        // GraphQL -> enableObjectLock: Boolean (scalar)
        [JsonProperty("enableObjectLock")]
        public System.Boolean? EnableObjectLock { get; set; }

        //      C# -> System.Boolean? EnableImmutability
        // GraphQL -> enableImmutability: Boolean (scalar)
        [JsonProperty("enableImmutability")]
        public System.Boolean? EnableImmutability { get; set; }

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

    } // class AwsEsConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types