// GcpCloudAccountOauthInitiateReply.cs
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
    #region GcpCloudAccountOauthInitiateReply
    public class GcpCloudAccountOauthInitiateReply: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        [JsonProperty("redirectUrl")]
        public System.String? RedirectUrl { get; set; }

        //      C# -> List<System.String>? Scope
        // GraphQL -> scope: [String!]! (scalar)
        [JsonProperty("scope")]
        public List<System.String>? Scope { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountOauthInitiateReply";
    }

    public GcpCloudAccountOauthInitiateReply Set(
        System.String? ClientId = null,
        System.String? RedirectUrl = null,
        List<System.String>? Scope = null,
        System.String? SessionId = null,
        System.String? State = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( RedirectUrl != null ) {
            this.RedirectUrl = RedirectUrl;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
        }
        if ( State != null ) {
            this.State = State;
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
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            s += ind + "clientId\n" ;
        }
        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        if (this.RedirectUrl != null) {
            s += ind + "redirectUrl\n" ;
        }
        //      C# -> List<System.String>? Scope
        // GraphQL -> scope: [String!]! (scalar)
        if (this.Scope != null) {
            s += ind + "scope\n" ;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            s += ind + "sessionId\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && ec.Includes("clientId",true))
        {
            this.ClientId = "FETCH";
        }
        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        if (this.RedirectUrl == null && ec.Includes("redirectUrl",true))
        {
            this.RedirectUrl = "FETCH";
        }
        //      C# -> List<System.String>? Scope
        // GraphQL -> scope: [String!]! (scalar)
        if (this.Scope == null && ec.Includes("scope",true))
        {
            this.Scope = new List<System.String>();
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId == null && ec.Includes("sessionId",true))
        {
            this.SessionId = "FETCH";
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State == null && ec.Includes("state",true))
        {
            this.State = "FETCH";
        }
    }


    #endregion

    } // class GcpCloudAccountOauthInitiateReply
    
    #endregion

    public static class ListGcpCloudAccountOauthInitiateReplyExtensions
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
            this List<GcpCloudAccountOauthInitiateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountOauthInitiateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountOauthInitiateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GcpCloudAccountOauthInitiateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types