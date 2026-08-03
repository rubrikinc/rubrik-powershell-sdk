// WebhookReadOnlyOauth2InfoV2.cs
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
    #region WebhookReadOnlyOauth2InfoV2
    public class WebhookReadOnlyOauth2InfoV2: BaseType
    {
        #region members

        //      C# -> WebhookOauth2ClientAuthMethodV2? ClientAuthMethod
        // GraphQL -> clientAuthMethod: WebhookOauth2ClientAuthMethodV2! (enum)
        [JsonProperty("clientAuthMethod")]
        public WebhookOauth2ClientAuthMethodV2? ClientAuthMethod { get; set; }

        //      C# -> WebhookOauth2GrantTypeV2? GrantType
        // GraphQL -> grantType: WebhookOauth2GrantTypeV2! (enum)
        [JsonProperty("grantType")]
        public WebhookOauth2GrantTypeV2? GrantType { get; set; }

        //      C# -> System.String? Audience
        // GraphQL -> audience: String (scalar)
        [JsonProperty("audience")]
        public System.String? Audience { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? Resource
        // GraphQL -> resource: String (scalar)
        [JsonProperty("resource")]
        public System.String? Resource { get; set; }

        //      C# -> System.String? Scope
        // GraphQL -> scope: String (scalar)
        [JsonProperty("scope")]
        public System.String? Scope { get; set; }

        //      C# -> System.String? TokenUrl
        // GraphQL -> tokenUrl: String! (scalar)
        [JsonProperty("tokenUrl")]
        public System.String? TokenUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WebhookReadOnlyOauth2InfoV2";
    }

    public WebhookReadOnlyOauth2InfoV2 Set(
        WebhookOauth2ClientAuthMethodV2? ClientAuthMethod = null,
        WebhookOauth2GrantTypeV2? GrantType = null,
        System.String? Audience = null,
        System.String? ClientId = null,
        System.String? Resource = null,
        System.String? Scope = null,
        System.String? TokenUrl = null
    ) 
    {
        if ( ClientAuthMethod != null ) {
            this.ClientAuthMethod = ClientAuthMethod;
        }
        if ( GrantType != null ) {
            this.GrantType = GrantType;
        }
        if ( Audience != null ) {
            this.Audience = Audience;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( Resource != null ) {
            this.Resource = Resource;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
        }
        if ( TokenUrl != null ) {
            this.TokenUrl = TokenUrl;
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
        //      C# -> WebhookOauth2ClientAuthMethodV2? ClientAuthMethod
        // GraphQL -> clientAuthMethod: WebhookOauth2ClientAuthMethodV2! (enum)
        if (this.ClientAuthMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientAuthMethod\n" ;
            } else {
                s += ind + "clientAuthMethod\n" ;
            }
        }
        //      C# -> WebhookOauth2GrantTypeV2? GrantType
        // GraphQL -> grantType: WebhookOauth2GrantTypeV2! (enum)
        if (this.GrantType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "grantType\n" ;
            } else {
                s += ind + "grantType\n" ;
            }
        }
        //      C# -> System.String? Audience
        // GraphQL -> audience: String (scalar)
        if (this.Audience != null) {
            if (conf.Flat) {
                s += conf.Prefix + "audience\n" ;
            } else {
                s += ind + "audience\n" ;
            }
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? Resource
        // GraphQL -> resource: String (scalar)
        if (this.Resource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resource\n" ;
            } else {
                s += ind + "resource\n" ;
            }
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String (scalar)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
            }
        }
        //      C# -> System.String? TokenUrl
        // GraphQL -> tokenUrl: String! (scalar)
        if (this.TokenUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tokenUrl\n" ;
            } else {
                s += ind + "tokenUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> WebhookOauth2ClientAuthMethodV2? ClientAuthMethod
        // GraphQL -> clientAuthMethod: WebhookOauth2ClientAuthMethodV2! (enum)
        if (ec.Includes("clientAuthMethod",true))
        {
            if(this.ClientAuthMethod == null) {

                this.ClientAuthMethod = new WebhookOauth2ClientAuthMethodV2();

            } else {


            }
        }
        else if (this.ClientAuthMethod != null && ec.Excludes("clientAuthMethod",true))
        {
            this.ClientAuthMethod = null;
        }
        //      C# -> WebhookOauth2GrantTypeV2? GrantType
        // GraphQL -> grantType: WebhookOauth2GrantTypeV2! (enum)
        if (ec.Includes("grantType",true))
        {
            if(this.GrantType == null) {

                this.GrantType = new WebhookOauth2GrantTypeV2();

            } else {


            }
        }
        else if (this.GrantType != null && ec.Excludes("grantType",true))
        {
            this.GrantType = null;
        }
        //      C# -> System.String? Audience
        // GraphQL -> audience: String (scalar)
        if (ec.Includes("audience",true))
        {
            if(this.Audience == null) {

                this.Audience = "FETCH";

            } else {


            }
        }
        else if (this.Audience != null && ec.Excludes("audience",true))
        {
            this.Audience = null;
        }
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
        //      C# -> System.String? Resource
        // GraphQL -> resource: String (scalar)
        if (ec.Includes("resource",true))
        {
            if(this.Resource == null) {

                this.Resource = "FETCH";

            } else {


            }
        }
        else if (this.Resource != null && ec.Excludes("resource",true))
        {
            this.Resource = null;
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String (scalar)
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
        //      C# -> System.String? TokenUrl
        // GraphQL -> tokenUrl: String! (scalar)
        if (ec.Includes("tokenUrl",true))
        {
            if(this.TokenUrl == null) {

                this.TokenUrl = "FETCH";

            } else {


            }
        }
        else if (this.TokenUrl != null && ec.Excludes("tokenUrl",true))
        {
            this.TokenUrl = null;
        }
    }


    #endregion

    } // class WebhookReadOnlyOauth2InfoV2
    
    #endregion

    public static class ListWebhookReadOnlyOauth2InfoV2Extensions
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
            this List<WebhookReadOnlyOauth2InfoV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WebhookReadOnlyOauth2InfoV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WebhookReadOnlyOauth2InfoV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WebhookReadOnlyOauth2InfoV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WebhookReadOnlyOauth2InfoV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types