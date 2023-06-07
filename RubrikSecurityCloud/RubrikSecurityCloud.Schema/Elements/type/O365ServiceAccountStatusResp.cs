// O365ServiceAccountStatusResp.cs
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
    #region O365ServiceAccountStatusResp
    public class O365ServiceAccountStatusResp: BaseType
    {
        #region members

        //      C# -> O365ServiceAccountStatus? Status
        // GraphQL -> status: O365ServiceAccountStatus! (enum)
        [JsonProperty("status")]
        public O365ServiceAccountStatus? Status { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public O365ServiceAccountStatusResp Set(
        O365ServiceAccountStatus? Status = null,
        System.String? Username = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> O365ServiceAccountStatus? Status
        // GraphQL -> status: O365ServiceAccountStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> O365ServiceAccountStatus? Status
        // GraphQL -> status: O365ServiceAccountStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new O365ServiceAccountStatus();
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
    }


    #endregion

    } // class O365ServiceAccountStatusResp
    
    #endregion

    public static class ListO365ServiceAccountStatusRespExtensions
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
            this List<O365ServiceAccountStatusResp> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365ServiceAccountStatusResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ServiceAccountStatusResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types