// CompleteAtlassianAuthConsentReply.cs
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
    #region CompleteAtlassianAuthConsentReply
    public class CompleteAtlassianAuthConsentReply: BaseType
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
        return "CompleteAtlassianAuthConsentReply";
    }

    public CompleteAtlassianAuthConsentReply Set(
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AuthorizingUserEmail
        // GraphQL -> authorizingUserEmail: String! (scalar)
        if (this.AuthorizingUserEmail != null) {
            s += ind + "authorizingUserEmail\n" ;
        }
        //      C# -> System.String? AuthorizingUserName
        // GraphQL -> authorizingUserName: String! (scalar)
        if (this.AuthorizingUserName != null) {
            s += ind + "authorizingUserName\n" ;
        }
        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        if (this.SiteId != null) {
            s += ind + "siteId\n" ;
        }
        //      C# -> System.String? SiteName
        // GraphQL -> siteName: String! (scalar)
        if (this.SiteName != null) {
            s += ind + "siteName\n" ;
        }
        //      C# -> System.String? SiteUrl
        // GraphQL -> siteUrl: URL! (scalar)
        if (this.SiteUrl != null) {
            s += ind + "siteUrl\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AuthorizingUserEmail
        // GraphQL -> authorizingUserEmail: String! (scalar)
        if (this.AuthorizingUserEmail == null && Exploration.Includes(parent + ".authorizingUserEmail", true))
        {
            this.AuthorizingUserEmail = "FETCH";
        }
        //      C# -> System.String? AuthorizingUserName
        // GraphQL -> authorizingUserName: String! (scalar)
        if (this.AuthorizingUserName == null && Exploration.Includes(parent + ".authorizingUserName", true))
        {
            this.AuthorizingUserName = "FETCH";
        }
        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        if (this.SiteId == null && Exploration.Includes(parent + ".siteId", true))
        {
            this.SiteId = "FETCH";
        }
        //      C# -> System.String? SiteName
        // GraphQL -> siteName: String! (scalar)
        if (this.SiteName == null && Exploration.Includes(parent + ".siteName", true))
        {
            this.SiteName = "FETCH";
        }
        //      C# -> System.String? SiteUrl
        // GraphQL -> siteUrl: URL! (scalar)
        if (this.SiteUrl == null && Exploration.Includes(parent + ".siteUrl", true))
        {
            this.SiteUrl = "FETCH";
        }
    }


    #endregion

    } // class CompleteAtlassianAuthConsentReply
    
    #endregion

    public static class ListCompleteAtlassianAuthConsentReplyExtensions
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
            this List<CompleteAtlassianAuthConsentReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CompleteAtlassianAuthConsentReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CompleteAtlassianAuthConsentReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types