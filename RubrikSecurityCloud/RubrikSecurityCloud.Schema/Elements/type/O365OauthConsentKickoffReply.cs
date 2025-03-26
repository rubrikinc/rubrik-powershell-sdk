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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "O365OauthConsentKickoffReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (this.AppClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appClientId\n" ;
            } else {
                s += ind + "appClientId\n" ;
            }
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csrfToken\n" ;
            } else {
                s += ind + "csrfToken\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (ec.Includes("appClientId",true))
        {
            if(this.AppClientId == null) {

                this.AppClientId = "FETCH";

            } else {


            }
        }
        else if (this.AppClientId != null && ec.Excludes("appClientId",true))
        {
            this.AppClientId = null;
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (ec.Includes("csrfToken",true))
        {
            if(this.CsrfToken == null) {

                this.CsrfToken = "FETCH";

            } else {


            }
        }
        else if (this.CsrfToken != null && ec.Excludes("csrfToken",true))
        {
            this.CsrfToken = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
    }


    #endregion

    } // class O365OauthConsentKickoffReply
    
    #endregion

    public static class ListO365OauthConsentKickoffReplyExtensions
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
            this List<O365OauthConsentKickoffReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365OauthConsentKickoffReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365OauthConsentKickoffReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365OauthConsentKickoffReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365OauthConsentKickoffReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types