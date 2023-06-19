// AzureOauthConsentKickoffReply.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureOauthConsentKickoffReply
    public class AzureOauthConsentKickoffReply: BaseType
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

        //      C# -> System.String? GovAppClientId
        // GraphQL -> govAppClientId: String! (scalar)
        [JsonProperty("govAppClientId")]
        public System.String? GovAppClientId { get; set; }


        #endregion

    #region methods

    public AzureOauthConsentKickoffReply Set(
        System.String? AppClientId = null,
        System.String? CsrfToken = null,
        System.String? GovAppClientId = null
    ) 
    {
        if ( AppClientId != null ) {
            this.AppClientId = AppClientId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( GovAppClientId != null ) {
            this.GovAppClientId = GovAppClientId;
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
        //      C# -> System.String? GovAppClientId
        // GraphQL -> govAppClientId: String! (scalar)
        if (this.GovAppClientId != null) {
            s += ind + "govAppClientId\n" ;
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
        //      C# -> System.String? GovAppClientId
        // GraphQL -> govAppClientId: String! (scalar)
        if (this.GovAppClientId == null && Exploration.Includes(parent + ".govAppClientId", true))
        {
            this.GovAppClientId = "FETCH";
        }
    }


    #endregion

    } // class AzureOauthConsentKickoffReply
    
    #endregion

    public static class ListAzureOauthConsentKickoffReplyExtensions
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
            this List<AzureOauthConsentKickoffReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureOauthConsentKickoffReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureOauthConsentKickoffReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types