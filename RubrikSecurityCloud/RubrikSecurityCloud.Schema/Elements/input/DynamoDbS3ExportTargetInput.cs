// DynamoDbS3ExportTargetInput.cs
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
    #region DynamoDbS3ExportTargetInput

    public class DynamoDbS3ExportTargetInput: IInput
    {
        #region members

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.String? Prefix
        // GraphQL -> prefix: String (scalar)
        [JsonProperty("prefix")]
        public System.String? Prefix { get; set; }

        //      C# -> AwsNativeRegion? Region
        // GraphQL -> region: AwsNativeRegion (enum)
        [JsonProperty("region")]
        public AwsNativeRegion? Region { get; set; }


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

    } // class DynamoDbS3ExportTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types