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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        if (this.RedirectUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redirectUrl\n" ;
            } else {
                s += ind + "redirectUrl\n" ;
            }
        }
        //      C# -> List<System.String>? Scope
        // GraphQL -> scope: [String!]! (scalar)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
            }
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionId\n" ;
            } else {
                s += ind + "sessionId\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        if (ec.Includes("redirectUrl",true))
        {
            if(this.RedirectUrl == null) {

                this.RedirectUrl = "FETCH";

            } else {


            }
        }
        else if (this.RedirectUrl != null && ec.Excludes("redirectUrl",true))
        {
            this.RedirectUrl = null;
        }
        //      C# -> List<System.String>? Scope
        // GraphQL -> scope: [String!]! (scalar)
        if (ec.Includes("scope",true))
        {
            if(this.Scope == null) {

                this.Scope = new List<System.String>();

            } else {


            }
        }
        else if (this.Scope != null && ec.Excludes("scope",true))
        {
            this.Scope = null;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (ec.Includes("sessionId",true))
        {
            if(this.SessionId == null) {

                this.SessionId = "FETCH";

            } else {


            }
        }
        else if (this.SessionId != null && ec.Excludes("sessionId",true))
        {
            this.SessionId = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
    }


    #endregion

    } // class GcpCloudAccountOauthInitiateReply
    
    #endregion

    public static class ListGcpCloudAccountOauthInitiateReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<GcpCloudAccountOauthInitiateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountOauthInitiateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<GcpCloudAccountOauthInitiateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types