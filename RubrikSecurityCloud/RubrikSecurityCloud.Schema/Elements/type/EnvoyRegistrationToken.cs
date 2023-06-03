// EnvoyRegistrationToken.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region EnvoyRegistrationToken
    public class EnvoyRegistrationToken: BaseType
    {
        #region members

        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String! (scalar)
        [JsonProperty("expiration")]
        public System.String? Expiration { get; set; }

        //      C# -> System.String? TenantNetworkId
        // GraphQL -> tenantNetworkId: String! (scalar)
        [JsonProperty("tenantNetworkId")]
        public System.String? TenantNetworkId { get; set; }

        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        [JsonProperty("token")]
        public System.String? Token { get; set; }


        #endregion

    #region methods

    public EnvoyRegistrationToken Set(
        System.String? Expiration = null,
        System.String? TenantNetworkId = null,
        System.String? Token = null
    ) 
    {
        if ( Expiration != null ) {
            this.Expiration = Expiration;
        }
        if ( TenantNetworkId != null ) {
            this.TenantNetworkId = TenantNetworkId;
        }
        if ( Token != null ) {
            this.Token = Token;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String! (scalar)
        if (this.Expiration != null) {
            s += ind + "expiration\n" ;
        }
        //      C# -> System.String? TenantNetworkId
        // GraphQL -> tenantNetworkId: String! (scalar)
        if (this.TenantNetworkId != null) {
            s += ind + "tenantNetworkId\n" ;
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (this.Token != null) {
            s += ind + "token\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String! (scalar)
        if (this.Expiration == null && Exploration.Includes(parent + ".expiration", true))
        {
            this.Expiration = new System.String("FETCH");
        }
        //      C# -> System.String? TenantNetworkId
        // GraphQL -> tenantNetworkId: String! (scalar)
        if (this.TenantNetworkId == null && Exploration.Includes(parent + ".tenantNetworkId", true))
        {
            this.TenantNetworkId = new System.String("FETCH");
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (this.Token == null && Exploration.Includes(parent + ".token", true))
        {
            this.Token = new System.String("FETCH");
        }
    }


    #endregion

    } // class EnvoyRegistrationToken
    
    #endregion

    public static class ListEnvoyRegistrationTokenExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<EnvoyRegistrationToken> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EnvoyRegistrationToken> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EnvoyRegistrationToken());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types