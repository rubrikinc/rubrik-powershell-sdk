// InitializeUploadSessionInput.cs
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
    #region InitializeUploadSessionInput

    public class InitializeUploadSessionInput: IInput
    {
        #region members

        //      C# -> System.String? PackageName
        // GraphQL -> packageName: String (scalar)
        [JsonProperty("packageName")]
        public System.String? PackageName { get; set; }

        //      C# -> System.Int64? PackageSize
        // GraphQL -> packageSize: Long (scalar)
        [JsonProperty("packageSize")]
        public System.Int64? PackageSize { get; set; }

        //      C# -> System.String? Md5Checksum
        // GraphQL -> md5Checksum: String (scalar)
        [JsonProperty("md5Checksum")]
        public System.String? Md5Checksum { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [String!] (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }


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

    } // class InitializeUploadSessionInput
    #endregion

} // namespace RubrikSecurityCloud.Types