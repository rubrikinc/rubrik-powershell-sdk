// O365OauthConsentKickoffReply.cs
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
    #region O365OauthConsentKickoffReply
    public class O365OauthConsentKickoffReply: BaseType
    {
        #region members

        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        [JsonProperty("appClientId")]
        public System.String? AppClientId { get; set; }

        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }


        #endregion

    #region methods

    public O365OauthConsentKickoffReply Set(
        System.String? AppClientId = null,
        System.String? CsrfToken = null,
        System.String? TenantId = null
    ) 
    {
        if ( AppClientId != null ) {
            this.AppClientId = AppClientId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
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
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (this.AppClientId != null) {
            s += ind + "appClientId\n" ;
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken != null) {
            s += ind + "csrfToken\n" ;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            s += ind + "tenantId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (this.AppClientId == null && Exploration.Includes(parent + ".appClientId", true))
        {
            this.AppClientId = "FETCH";
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken == null && Exploration.Includes(parent + ".csrfToken", true))
        {
            this.CsrfToken = "FETCH";
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId == null && Exploration.Includes(parent + ".tenantId", true))
        {
            this.TenantId = "FETCH";
        }
    }


    #endregion

    } // class O365OauthConsentKickoffReply
    
    #endregion

    public static class ListO365OauthConsentKickoffReplyExtensions
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
            this List<O365OauthConsentKickoffReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365OauthConsentKickoffReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365OauthConsentKickoffReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types