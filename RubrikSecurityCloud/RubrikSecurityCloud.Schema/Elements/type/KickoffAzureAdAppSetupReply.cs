// KickoffAzureAdAppSetupReply.cs
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
    #region KickoffAzureAdAppSetupReply
    public class KickoffAzureAdAppSetupReply: BaseType
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }


        #endregion

    #region methods

    public KickoffAzureAdAppSetupReply Set(
        System.String? AppId = null,
        System.String? CsrfToken = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            s += ind + "appId\n" ;
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken != null) {
            s += ind + "csrfToken\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId == null && Exploration.Includes(parent + ".appId", true))
        {
            this.AppId = "FETCH";
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken == null && Exploration.Includes(parent + ".csrfToken", true))
        {
            this.CsrfToken = "FETCH";
        }
    }


    #endregion

    } // class KickoffAzureAdAppSetupReply
    
    #endregion

    public static class ListKickoffAzureAdAppSetupReplyExtensions
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
            this List<KickoffAzureAdAppSetupReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KickoffAzureAdAppSetupReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new KickoffAzureAdAppSetupReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types