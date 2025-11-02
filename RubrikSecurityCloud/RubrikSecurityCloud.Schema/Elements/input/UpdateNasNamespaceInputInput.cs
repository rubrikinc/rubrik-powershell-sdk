// UpdateNasNamespaceInputInput.cs
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
    #region UpdateNasNamespaceInputInput

    public class UpdateNasNamespaceInputInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? UserSelectedSmbInterfaces
        // GraphQL -> userSelectedSmbInterfaces: [String!] (scalar)
        [JsonProperty("userSelectedSmbInterfaces")]
        public List<System.String>? UserSelectedSmbInterfaces { get; set; }

        //      C# -> NasShareCredentialsInput? SmbCredentials
        // GraphQL -> smbCredentials: NasShareCredentialsInput (input)
        [JsonProperty("smbCredentials")]
        public NasShareCredentialsInput? SmbCredentials { get; set; }

        //      C# -> List<System.String>? UserSelectedNfsInterfaces
        // GraphQL -> userSelectedNfsInterfaces: [String!] (scalar)
        [JsonProperty("userSelectedNfsInterfaces")]
        public List<System.String>? UserSelectedNfsInterfaces { get; set; }


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

    } // class UpdateNasNamespaceInputInput
    #endregion

} // namespace RubrikSecurityCloud.Types