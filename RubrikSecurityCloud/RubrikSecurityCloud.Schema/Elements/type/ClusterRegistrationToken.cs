// ClusterRegistrationToken.cs
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
    #region ClusterRegistrationToken
    public class ClusterRegistrationToken: BaseType
    {
        #region members

        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        [JsonProperty("productType")]
        public System.String? ProductType { get; set; }

        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        [JsonProperty("pubkey")]
        public System.String? Pubkey { get; set; }

        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        [JsonProperty("token")]
        public System.String? Token { get; set; }


        #endregion

    #region methods

    public ClusterRegistrationToken Set(
        System.String? ProductType = null,
        System.String? Pubkey = null,
        System.String? Token = null
    ) 
    {
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( Pubkey != null ) {
            this.Pubkey = Pubkey;
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
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (this.ProductType != null) {
            s += ind + "productType\n" ;
        }
        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        if (this.Pubkey != null) {
            s += ind + "pubkey\n" ;
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
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (this.ProductType == null && Exploration.Includes(parent + ".productType", true))
        {
            this.ProductType = "FETCH";
        }
        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        if (this.Pubkey == null && Exploration.Includes(parent + ".pubkey", true))
        {
            this.Pubkey = "FETCH";
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (this.Token == null && Exploration.Includes(parent + ".token", true))
        {
            this.Token = "FETCH";
        }
    }


    #endregion

    } // class ClusterRegistrationToken
    
    #endregion

    public static class ListClusterRegistrationTokenExtensions
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
            this List<ClusterRegistrationToken> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterRegistrationToken> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterRegistrationToken());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types