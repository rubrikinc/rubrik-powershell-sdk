// OauthRequestPayload.cs
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
    #region OauthRequestPayload
    public class OauthRequestPayload: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? CodeChallenge
        // GraphQL -> codeChallenge: String! (scalar)
        [JsonProperty("codeChallenge")]
        public System.String? CodeChallenge { get; set; }

        //      C# -> System.String? CodeChallengeMethod
        // GraphQL -> codeChallengeMethod: String! (scalar)
        [JsonProperty("codeChallengeMethod")]
        public System.String? CodeChallengeMethod { get; set; }

        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        [JsonProperty("redirectUri")]
        public System.String? RedirectUri { get; set; }

        //      C# -> System.String? ResponseType
        // GraphQL -> responseType: String! (scalar)
        [JsonProperty("responseType")]
        public System.String? ResponseType { get; set; }

        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        [JsonProperty("scope")]
        public System.String? Scope { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OauthRequestPayload";
    }

    public OauthRequestPayload Set(
        System.String? ClientId = null,
        System.String? CodeChallenge = null,
        System.String? CodeChallengeMethod = null,
        System.String? RedirectUri = null,
        System.String? ResponseType = null,
        System.String? Scope = null,
        System.String? State = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( CodeChallenge != null ) {
            this.CodeChallenge = CodeChallenge;
        }
        if ( CodeChallengeMethod != null ) {
            this.CodeChallengeMethod = CodeChallengeMethod;
        }
        if ( RedirectUri != null ) {
            this.RedirectUri = RedirectUri;
        }
        if ( ResponseType != null ) {
            this.ResponseType = ResponseType;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> System.String? CodeChallenge
        // GraphQL -> codeChallenge: String! (scalar)
        if (this.CodeChallenge != null) {
            if (conf.Flat) {
                s += conf.Prefix + "codeChallenge\n" ;
            } else {
                s += ind + "codeChallenge\n" ;
            }
        }
        //      C# -> System.String? CodeChallengeMethod
        // GraphQL -> codeChallengeMethod: String! (scalar)
        if (this.CodeChallengeMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "codeChallengeMethod\n" ;
            } else {
                s += ind + "codeChallengeMethod\n" ;
            }
        }
        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        if (this.RedirectUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redirectUri\n" ;
            } else {
                s += ind + "redirectUri\n" ;
            }
        }
        //      C# -> System.String? ResponseType
        // GraphQL -> responseType: String! (scalar)
        if (this.ResponseType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "responseType\n" ;
            } else {
                s += ind + "responseType\n" ;
            }
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.String? CodeChallenge
        // GraphQL -> codeChallenge: String! (scalar)
        if (ec.Includes("codeChallenge",true))
        {
            if(this.CodeChallenge == null) {

                this.CodeChallenge = "FETCH";

            } else {


            }
        }
        else if (this.CodeChallenge != null && ec.Excludes("codeChallenge",true))
        {
            this.CodeChallenge = null;
        }
        //      C# -> System.String? CodeChallengeMethod
        // GraphQL -> codeChallengeMethod: String! (scalar)
        if (ec.Includes("codeChallengeMethod",true))
        {
            if(this.CodeChallengeMethod == null) {

                this.CodeChallengeMethod = "FETCH";

            } else {


            }
        }
        else if (this.CodeChallengeMethod != null && ec.Excludes("codeChallengeMethod",true))
        {
            this.CodeChallengeMethod = null;
        }
        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        if (ec.Includes("redirectUri",true))
        {
            if(this.RedirectUri == null) {

                this.RedirectUri = "FETCH";

            } else {


            }
        }
        else if (this.RedirectUri != null && ec.Excludes("redirectUri",true))
        {
            this.RedirectUri = null;
        }
        //      C# -> System.String? ResponseType
        // GraphQL -> responseType: String! (scalar)
        if (ec.Includes("responseType",true))
        {
            if(this.ResponseType == null) {

                this.ResponseType = "FETCH";

            } else {


            }
        }
        else if (this.ResponseType != null && ec.Excludes("responseType",true))
        {
            this.ResponseType = null;
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (ec.Includes("scope",true))
        {
            if(this.Scope == null) {

                this.Scope = "FETCH";

            } else {


            }
        }
        else if (this.Scope != null && ec.Excludes("scope",true))
        {
            this.Scope = null;
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

    } // class OauthRequestPayload
    
    #endregion

    public static class ListOauthRequestPayloadExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OauthRequestPayload> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OauthRequestPayload> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OauthRequestPayload> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OauthRequestPayload());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OauthRequestPayload> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types