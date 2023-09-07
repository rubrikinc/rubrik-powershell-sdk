// StartAtlassianAuthConsentReply.cs
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
    #region StartAtlassianAuthConsentReply
    public class StartAtlassianAuthConsentReply: BaseType
    {
        #region members

        //      C# -> System.String? AuthorizationUrl
        // GraphQL -> authorizationUrl: URL! (scalar)
        [JsonProperty("authorizationUrl")]
        public System.String? AuthorizationUrl { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartAtlassianAuthConsentReply";
    }

    public StartAtlassianAuthConsentReply Set(
        System.String? AuthorizationUrl = null,
        System.String? SessionId = null
    ) 
    {
        if ( AuthorizationUrl != null ) {
            this.AuthorizationUrl = AuthorizationUrl;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
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
        //      C# -> System.String? AuthorizationUrl
        // GraphQL -> authorizationUrl: URL! (scalar)
        if (this.AuthorizationUrl != null) {
            s += ind + "authorizationUrl\n" ;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            s += ind + "sessionId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AuthorizationUrl
        // GraphQL -> authorizationUrl: URL! (scalar)
        if (this.AuthorizationUrl == null && ec.Includes("authorizationUrl",true))
        {
            this.AuthorizationUrl = "FETCH";
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId == null && ec.Includes("sessionId",true))
        {
            this.SessionId = "FETCH";
        }
    }


    #endregion

    } // class StartAtlassianAuthConsentReply
    
    #endregion

    public static class ListStartAtlassianAuthConsentReplyExtensions
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
            this List<StartAtlassianAuthConsentReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StartAtlassianAuthConsentReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartAtlassianAuthConsentReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<StartAtlassianAuthConsentReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types