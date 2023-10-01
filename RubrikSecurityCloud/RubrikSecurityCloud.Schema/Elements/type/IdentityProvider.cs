// IdentityProvider.cs
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
    #region IdentityProvider
    public class IdentityProvider: BaseType
    {
        #region members

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        [JsonProperty("ownerOrgId")]
        public System.String? OwnerOrgId { get; set; }

        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        [JsonProperty("signInUrl")]
        public System.String? SignInUrl { get; set; }

        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        [JsonProperty("signOutUrl")]
        public System.String? SignOutUrl { get; set; }

        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        [JsonProperty("spInitiatedSignInUrl")]
        public System.String? SpInitiatedSignInUrl { get; set; }

        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        [JsonProperty("spInitiatedTestUrl")]
        public System.String? SpInitiatedTestUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityProvider";
    }

    public IdentityProvider Set(
        System.String? EntityId = null,
        DateTime? ExpirationDate = null,
        System.String? Name = null,
        System.String? OwnerOrgId = null,
        System.String? SignInUrl = null,
        System.String? SignOutUrl = null,
        System.String? SpInitiatedSignInUrl = null,
        System.String? SpInitiatedTestUrl = null
    ) 
    {
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OwnerOrgId != null ) {
            this.OwnerOrgId = OwnerOrgId;
        }
        if ( SignInUrl != null ) {
            this.SignInUrl = SignInUrl;
        }
        if ( SignOutUrl != null ) {
            this.SignOutUrl = SignOutUrl;
        }
        if ( SpInitiatedSignInUrl != null ) {
            this.SpInitiatedSignInUrl = SpInitiatedSignInUrl;
        }
        if ( SpInitiatedTestUrl != null ) {
            this.SpInitiatedTestUrl = SpInitiatedTestUrl;
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
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (this.EntityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityId\n" ;
            } else {
                s += ind + "entityId\n" ;
            }
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        if (this.OwnerOrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerOrgId\n" ;
            } else {
                s += ind + "ownerOrgId\n" ;
            }
        }
        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        if (this.SignInUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signInUrl\n" ;
            } else {
                s += ind + "signInUrl\n" ;
            }
        }
        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        if (this.SignOutUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signOutUrl\n" ;
            } else {
                s += ind + "signOutUrl\n" ;
            }
        }
        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        if (this.SpInitiatedSignInUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "spInitiatedSignInUrl\n" ;
            } else {
                s += ind + "spInitiatedSignInUrl\n" ;
            }
        }
        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        if (this.SpInitiatedTestUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "spInitiatedTestUrl\n" ;
            } else {
                s += ind + "spInitiatedTestUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (ec.Includes("entityId",true))
        {
            if(this.EntityId == null) {

                this.EntityId = "FETCH";

            } else {


            }
        }
        else if (this.EntityId != null && ec.Excludes("entityId",true))
        {
            this.EntityId = null;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        if (ec.Includes("ownerOrgId",true))
        {
            if(this.OwnerOrgId == null) {

                this.OwnerOrgId = "FETCH";

            } else {


            }
        }
        else if (this.OwnerOrgId != null && ec.Excludes("ownerOrgId",true))
        {
            this.OwnerOrgId = null;
        }
        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        if (ec.Includes("signInUrl",true))
        {
            if(this.SignInUrl == null) {

                this.SignInUrl = "FETCH";

            } else {


            }
        }
        else if (this.SignInUrl != null && ec.Excludes("signInUrl",true))
        {
            this.SignInUrl = null;
        }
        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        if (ec.Includes("signOutUrl",true))
        {
            if(this.SignOutUrl == null) {

                this.SignOutUrl = "FETCH";

            } else {


            }
        }
        else if (this.SignOutUrl != null && ec.Excludes("signOutUrl",true))
        {
            this.SignOutUrl = null;
        }
        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        if (ec.Includes("spInitiatedSignInUrl",true))
        {
            if(this.SpInitiatedSignInUrl == null) {

                this.SpInitiatedSignInUrl = "FETCH";

            } else {


            }
        }
        else if (this.SpInitiatedSignInUrl != null && ec.Excludes("spInitiatedSignInUrl",true))
        {
            this.SpInitiatedSignInUrl = null;
        }
        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        if (ec.Includes("spInitiatedTestUrl",true))
        {
            if(this.SpInitiatedTestUrl == null) {

                this.SpInitiatedTestUrl = "FETCH";

            } else {


            }
        }
        else if (this.SpInitiatedTestUrl != null && ec.Excludes("spInitiatedTestUrl",true))
        {
            this.SpInitiatedTestUrl = null;
        }
    }


    #endregion

    } // class IdentityProvider
    
    #endregion

    public static class ListIdentityProviderExtensions
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
            this List<IdentityProvider> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<IdentityProvider> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityProvider> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityProvider());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityProvider> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types