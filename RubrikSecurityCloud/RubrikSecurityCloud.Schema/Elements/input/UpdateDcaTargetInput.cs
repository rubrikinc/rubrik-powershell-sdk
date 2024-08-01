// UpdateDcaTargetInput.cs
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
    #region UpdateDcaTargetInput

    public class UpdateDcaTargetInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? Agency
        // GraphQL -> agency: String (scalar)
        [JsonProperty("agency")]
        public System.String? Agency { get; set; }

        //      C# -> System.String? Mission
        // GraphQL -> mission: String (scalar)
        [JsonProperty("mission")]
        public System.String? Mission { get; set; }

        //      C# -> System.Int32? TokenDuration
        // GraphQL -> tokenDuration: Int (scalar)
        [JsonProperty("tokenDuration")]
        public System.Int32? TokenDuration { get; set; }

        //      C# -> System.String? CapEndPoint
        // GraphQL -> capEndPoint: String (scalar)
        [JsonProperty("capEndPoint")]
        public System.String? CapEndPoint { get; set; }

        //      C# -> System.String? CertificateContent
        // GraphQL -> certificateContent: String (scalar)
        [JsonProperty("certificateContent")]
        public System.String? CertificateContent { get; set; }

        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass (enum)
        [JsonProperty("storageClass")]
        public AwsStorageClass? StorageClass { get; set; }

        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier (enum)
        [JsonProperty("awsRetrievalTier")]
        public AwsRetrievalTier? AwsRetrievalTier { get; set; }


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

    } // class UpdateDcaTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types