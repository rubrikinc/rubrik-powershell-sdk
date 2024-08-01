// CompleteSaasAppAuthConsentReply.cs
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
    #region CompleteSaasAppAuthConsentReply
    public class CompleteSaasAppAuthConsentReply: BaseType
    {
        #region members

        //      C# -> System.String? AuthorizingUserEmail
        // GraphQL -> authorizingUserEmail: String! (scalar)
        [JsonProperty("authorizingUserEmail")]
        public System.String? AuthorizingUserEmail { get; set; }

        //      C# -> System.String? AuthorizingUserName
        // GraphQL -> authorizingUserName: String! (scalar)
        [JsonProperty("authorizingUserName")]
        public System.String? AuthorizingUserName { get; set; }

        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        [JsonProperty("siteId")]
        public System.String? SiteId { get; set; }

        //      C# -> System.String? SiteName
        // GraphQL -> siteName: String! (scalar)
        [JsonProperty("siteName")]
        public System.String? SiteName { get; set; }

        //      C# -> System.String? SiteUrl
        // GraphQL -> siteUrl: URL! (scalar)
        [JsonProperty("siteUrl")]
        public System.String? SiteUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CompleteSaasAppAuthConsentReply";
    }

    public CompleteSaasAppAuthConsentReply Set(
        System.String? AuthorizingUserEmail = null,
        System.String? AuthorizingUserName = null,
        System.String? SiteId = null,
        System.String? SiteName = null,
        System.String? SiteUrl = null
    ) 
    {
        if ( AuthorizingUserEmail != null ) {
            this.AuthorizingUserEmail = AuthorizingUserEmail;
        }
        if ( AuthorizingUserName != null ) {
            this.AuthorizingUserName = AuthorizingUserName;
        }
        if ( SiteId != null ) {
            this.SiteId = SiteId;
        }
        if ( SiteName != null ) {
            this.SiteName = SiteName;
        }
        if ( SiteUrl != null ) {
            this.SiteUrl = SiteUrl;
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
        //      C# -> System.String? AuthorizingUserEmail
        // GraphQL -> authorizingUserEmail: String! (scalar)
        if (this.AuthorizingUserEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizingUserEmail\n" ;
            } else {
                s += ind + "authorizingUserEmail\n" ;
            }
        }
        //      C# -> System.String? AuthorizingUserName
        // GraphQL -> authorizingUserName: String! (scalar)
        if (this.AuthorizingUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizingUserName\n" ;
            } else {
                s += ind + "authorizingUserName\n" ;
            }
        }
        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        if (this.SiteId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "siteId\n" ;
            } else {
                s += ind + "siteId\n" ;
            }
        }
        //      C# -> System.String? SiteName
        // GraphQL -> siteName: String! (scalar)
        if (this.SiteName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "siteName\n" ;
            } else {
                s += ind + "siteName\n" ;
            }
        }
        //      C# -> System.String? SiteUrl
        // GraphQL -> siteUrl: URL! (scalar)
        if (this.SiteUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "siteUrl\n" ;
            } else {
                s += ind + "siteUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AuthorizingUserEmail
        // GraphQL -> authorizingUserEmail: String! (scalar)
        if (ec.Includes("authorizingUserEmail",true))
        {
            if(this.AuthorizingUserEmail == null) {

                this.AuthorizingUserEmail = "FETCH";

            } else {


            }
        }
        else if (this.AuthorizingUserEmail != null && ec.Excludes("authorizingUserEmail",true))
        {
            this.AuthorizingUserEmail = null;
        }
        //      C# -> System.String? AuthorizingUserName
        // GraphQL -> authorizingUserName: String! (scalar)
        if (ec.Includes("authorizingUserName",true))
        {
            if(this.AuthorizingUserName == null) {

                this.AuthorizingUserName = "FETCH";

            } else {


            }
        }
        else if (this.AuthorizingUserName != null && ec.Excludes("authorizingUserName",true))
        {
            this.AuthorizingUserName = null;
        }
        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        if (ec.Includes("siteId",true))
        {
            if(this.SiteId == null) {

                this.SiteId = "FETCH";

            } else {


            }
        }
        else if (this.SiteId != null && ec.Excludes("siteId",true))
        {
            this.SiteId = null;
        }
        //      C# -> System.String? SiteName
        // GraphQL -> siteName: String! (scalar)
        if (ec.Includes("siteName",true))
        {
            if(this.SiteName == null) {

                this.SiteName = "FETCH";

            } else {


            }
        }
        else if (this.SiteName != null && ec.Excludes("siteName",true))
        {
            this.SiteName = null;
        }
        //      C# -> System.String? SiteUrl
        // GraphQL -> siteUrl: URL! (scalar)
        if (ec.Includes("siteUrl",true))
        {
            if(this.SiteUrl == null) {

                this.SiteUrl = "FETCH";

            } else {


            }
        }
        else if (this.SiteUrl != null && ec.Excludes("siteUrl",true))
        {
            this.SiteUrl = null;
        }
    }


    #endregion

    } // class CompleteSaasAppAuthConsentReply
    
    #endregion

    public static class ListCompleteSaasAppAuthConsentReplyExtensions
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
            this List<CompleteSaasAppAuthConsentReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CompleteSaasAppAuthConsentReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CompleteSaasAppAuthConsentReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CompleteSaasAppAuthConsentReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CompleteSaasAppAuthConsentReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types