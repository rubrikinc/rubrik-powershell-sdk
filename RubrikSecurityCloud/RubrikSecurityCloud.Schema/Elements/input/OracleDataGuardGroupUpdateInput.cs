// OracleDataGuardGroupUpdateInput.cs
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
    #region OracleDataGuardGroupUpdateInput

    public class OracleDataGuardGroupUpdateInput: IInput
    {
        #region members

        //      C# -> List<System.String>? PreferredDgMemberUniqueNames
        // GraphQL -> preferredDgMemberUniqueNames: [String!] (scalar)
        [JsonProperty("preferredDgMemberUniqueNames")]
        public List<System.String>? PreferredDgMemberUniqueNames { get; set; }

        //      C# -> System.Boolean? ShouldBackupFromPrimaryOnly
        // GraphQL -> shouldBackupFromPrimaryOnly: Boolean (scalar)
        [JsonProperty("shouldBackupFromPrimaryOnly")]
        public System.Boolean? ShouldBackupFromPrimaryOnly { get; set; }

        //      C# -> OracleUpdateCommonInput? OracleUpdateCommon
        // GraphQL -> oracleUpdateCommon: OracleUpdateCommonInput (input)
        [JsonProperty("oracleUpdateCommon")]
        public OracleUpdateCommonInput? OracleUpdateCommon { get; set; }

        //      C# -> System.Boolean? ShouldUseSepsWallet
        // GraphQL -> shouldUseSepsWallet: Boolean (scalar)
        [JsonProperty("shouldUseSepsWallet")]
        public System.Boolean? ShouldUseSepsWallet { get; set; }

        //      C# -> System.Boolean? ShouldForceDisableDgDiscovery
        // GraphQL -> shouldForceDisableDgDiscovery: Boolean (scalar)
        [JsonProperty("shouldForceDisableDgDiscovery")]
        public System.Boolean? ShouldForceDisableDgDiscovery { get; set; }


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

    } // class OracleDataGuardGroupUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types