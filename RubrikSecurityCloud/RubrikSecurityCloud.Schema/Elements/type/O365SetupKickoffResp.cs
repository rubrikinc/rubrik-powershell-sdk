// O365SetupKickoffResp.cs
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
    #region O365SetupKickoffResp
    public class O365SetupKickoffResp: BaseType
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

        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        [JsonProperty("appClientIdsPerType")]
        public List<AppIdForType>? AppClientIdsPerType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365SetupKickoffResp";
    }

    public O365SetupKickoffResp Set(
        System.String? AppClientId = null,
        System.String? CsrfToken = null,
        List<AppIdForType>? AppClientIdsPerType = null
    ) 
    {
        if ( AppClientId != null ) {
            this.AppClientId = AppClientId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( AppClientIdsPerType != null ) {
            this.AppClientIdsPerType = AppClientIdsPerType;
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
        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        if (this.AppClientIdsPerType != null) {
            var fspec = this.AppClientIdsPerType.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "appClientIdsPerType {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        if (this.AppClientIdsPerType == null && Exploration.Includes(parent + ".appClientIdsPerType"))
        {
            this.AppClientIdsPerType = new List<AppIdForType>();
            this.AppClientIdsPerType.ApplyExploratoryFieldSpec(parent + ".appClientIdsPerType");
        }
    }


    #endregion

    } // class O365SetupKickoffResp
    
    #endregion

    public static class ListO365SetupKickoffRespExtensions
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
            this List<O365SetupKickoffResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365SetupKickoffResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SetupKickoffResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types