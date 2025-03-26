// OauthAccessToken.cs
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
    #region OauthAccessToken
    public class OauthAccessToken: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        [JsonProperty("code")]
        public System.String? Code { get; set; }

        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        [JsonProperty("codeVerifier")]
        public System.String? CodeVerifier { get; set; }

        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        [JsonProperty("expiryTime")]
        public System.String? ExpiryTime { get; set; }

        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        [JsonProperty("redirectUri")]
        public System.String? RedirectUri { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OauthAccessToken";
    }

    public OauthAccessToken Set(
        System.String? ClientId = null,
        System.String? Code = null,
        System.String? CodeVerifier = null,
        System.String? ExpiryTime = null,
        System.String? RedirectUri = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( CodeVerifier != null ) {
            this.CodeVerifier = CodeVerifier;
        }
        if ( ExpiryTime != null ) {
            this.ExpiryTime = ExpiryTime;
        }
        if ( RedirectUri != null ) {
            this.RedirectUri = RedirectUri;
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
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        if (this.CodeVerifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "codeVerifier\n" ;
            } else {
                s += ind + "codeVerifier\n" ;
            }
        }
        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        if (this.ExpiryTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiryTime\n" ;
            } else {
                s += ind + "expiryTime\n" ;
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
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = "FETCH";

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        if (ec.Includes("codeVerifier",true))
        {
            if(this.CodeVerifier == null) {

                this.CodeVerifier = "FETCH";

            } else {


            }
        }
        else if (this.CodeVerifier != null && ec.Excludes("codeVerifier",true))
        {
            this.CodeVerifier = null;
        }
        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        if (ec.Includes("expiryTime",true))
        {
            if(this.ExpiryTime == null) {

                this.ExpiryTime = "FETCH";

            } else {


            }
        }
        else if (this.ExpiryTime != null && ec.Excludes("expiryTime",true))
        {
            this.ExpiryTime = null;
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
    }


    #endregion

    } // class OauthAccessToken
    
    #endregion

    public static class ListOauthAccessTokenExtensions
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
            this List<OauthAccessToken> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OauthAccessToken> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OauthAccessToken> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OauthAccessToken());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OauthAccessToken> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types