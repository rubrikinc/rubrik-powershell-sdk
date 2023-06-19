// CreateTapeReaderTargetInput.cs
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
    #region CreateTapeReaderTargetInput

    public class CreateTapeReaderTargetInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.Int32? HostPort
        // GraphQL -> hostPort: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostPort")]
        public System.Int32? HostPort { get; set; }

        //      C# -> System.String? IntegralVolumeName
        // GraphQL -> integralVolumeName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("integralVolumeName")]
        public System.String? IntegralVolumeName { get; set; }

        //      C# -> System.String? DestinationFolderName
        // GraphQL -> destinationFolderName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationFolderName")]
        public System.String? DestinationFolderName { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }


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

    } // class CreateTapeReaderTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types