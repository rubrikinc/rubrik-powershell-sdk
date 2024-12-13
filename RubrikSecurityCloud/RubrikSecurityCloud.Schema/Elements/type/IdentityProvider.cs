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

        //      C# -> System.Int32? ActiveUserCount
        // GraphQL -> activeUserCount: Int! (scalar)
        [JsonProperty("activeUserCount")]
        public System.Int32? ActiveUserCount { get; set; }

        //      C# -> System.Int32? AuthorizedGroupsCount
        // GraphQL -> authorizedGroupsCount: Int! (scalar)
        [JsonProperty("authorizedGroupsCount")]
        public System.Int32? AuthorizedGroupsCount { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        [JsonProperty("isDefault")]
        public System.Boolean? IsDefault { get; set; }

        //      C# -> System.String? MetadataJson
        // GraphQL -> metadataJson: String! (scalar)
        [JsonProperty("metadataJson")]
        public System.String? MetadataJson { get; set; }

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

        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        [JsonProperty("signingCertificate")]
        public System.String? SigningCertificate { get; set; }

        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        [JsonProperty("spInitiatedSignInUrl")]
        public System.String? SpInitiatedSignInUrl { get; set; }

        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        [JsonProperty("spInitiatedTestUrl")]
        public System.String? SpInitiatedTestUrl { get; set; }

        //      C# -> List<IdpClaimAttributeType>? IdpClaimAttributes
        // GraphQL -> idpClaimAttributes: [IdpClaimAttributeType!]! (type)
        [JsonProperty("idpClaimAttributes")]
        public List<IdpClaimAttributeType>? IdpClaimAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityProvider";
    }

    public IdentityProvider Set(
        System.Int32? ActiveUserCount = null,
        System.Int32? AuthorizedGroupsCount = null,
        System.String? EntityId = null,
        DateTime? ExpirationDate = null,
        System.String? Id = null,
        System.Boolean? IsDefault = null,
        System.String? MetadataJson = null,
        System.String? Name = null,
        System.String? OwnerOrgId = null,
        System.String? SignInUrl = null,
        System.String? SignOutUrl = null,
        System.String? SigningCertificate = null,
        System.String? SpInitiatedSignInUrl = null,
        System.String? SpInitiatedTestUrl = null,
        List<IdpClaimAttributeType>? IdpClaimAttributes = null
    ) 
    {
        if ( ActiveUserCount != null ) {
            this.ActiveUserCount = ActiveUserCount;
        }
        if ( AuthorizedGroupsCount != null ) {
            this.AuthorizedGroupsCount = AuthorizedGroupsCount;
        }
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDefault != null ) {
            this.IsDefault = IsDefault;
        }
        if ( MetadataJson != null ) {
            this.MetadataJson = MetadataJson;
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
        if ( SigningCertificate != null ) {
            this.SigningCertificate = SigningCertificate;
        }
        if ( SpInitiatedSignInUrl != null ) {
            this.SpInitiatedSignInUrl = SpInitiatedSignInUrl;
        }
        if ( SpInitiatedTestUrl != null ) {
            this.SpInitiatedTestUrl = SpInitiatedTestUrl;
        }
        if ( IdpClaimAttributes != null ) {
            this.IdpClaimAttributes = IdpClaimAttributes;
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
        //      C# -> System.Int32? ActiveUserCount
        // GraphQL -> activeUserCount: Int! (scalar)
        if (this.ActiveUserCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeUserCount\n" ;
            } else {
                s += ind + "activeUserCount\n" ;
            }
        }
        //      C# -> System.Int32? AuthorizedGroupsCount
        // GraphQL -> authorizedGroupsCount: Int! (scalar)
        if (this.AuthorizedGroupsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizedGroupsCount\n" ;
            } else {
                s += ind + "authorizedGroupsCount\n" ;
            }
        }
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
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (this.IsDefault != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDefault\n" ;
            } else {
                s += ind + "isDefault\n" ;
            }
        }
        //      C# -> System.String? MetadataJson
        // GraphQL -> metadataJson: String! (scalar)
        if (this.MetadataJson != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metadataJson\n" ;
            } else {
                s += ind + "metadataJson\n" ;
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
        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        if (this.SigningCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signingCertificate\n" ;
            } else {
                s += ind + "signingCertificate\n" ;
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
        //      C# -> List<IdpClaimAttributeType>? IdpClaimAttributes
        // GraphQL -> idpClaimAttributes: [IdpClaimAttributeType!]! (type)
        if (this.IdpClaimAttributes != null) {
            var fspec = this.IdpClaimAttributes.AsFieldSpec(conf.Child("idpClaimAttributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "idpClaimAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ActiveUserCount
        // GraphQL -> activeUserCount: Int! (scalar)
        if (ec.Includes("activeUserCount",true))
        {
            if(this.ActiveUserCount == null) {

                this.ActiveUserCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveUserCount != null && ec.Excludes("activeUserCount",true))
        {
            this.ActiveUserCount = null;
        }
        //      C# -> System.Int32? AuthorizedGroupsCount
        // GraphQL -> authorizedGroupsCount: Int! (scalar)
        if (ec.Includes("authorizedGroupsCount",true))
        {
            if(this.AuthorizedGroupsCount == null) {

                this.AuthorizedGroupsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AuthorizedGroupsCount != null && ec.Excludes("authorizedGroupsCount",true))
        {
            this.AuthorizedGroupsCount = null;
        }
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
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (ec.Includes("isDefault",true))
        {
            if(this.IsDefault == null) {

                this.IsDefault = true;

            } else {


            }
        }
        else if (this.IsDefault != null && ec.Excludes("isDefault",true))
        {
            this.IsDefault = null;
        }
        //      C# -> System.String? MetadataJson
        // GraphQL -> metadataJson: String! (scalar)
        if (ec.Includes("metadataJson",true))
        {
            if(this.MetadataJson == null) {

                this.MetadataJson = "FETCH";

            } else {


            }
        }
        else if (this.MetadataJson != null && ec.Excludes("metadataJson",true))
        {
            this.MetadataJson = null;
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
        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        if (ec.Includes("signingCertificate",true))
        {
            if(this.SigningCertificate == null) {

                this.SigningCertificate = "FETCH";

            } else {


            }
        }
        else if (this.SigningCertificate != null && ec.Excludes("signingCertificate",true))
        {
            this.SigningCertificate = null;
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
        //      C# -> List<IdpClaimAttributeType>? IdpClaimAttributes
        // GraphQL -> idpClaimAttributes: [IdpClaimAttributeType!]! (type)
        if (ec.Includes("idpClaimAttributes",false))
        {
            if(this.IdpClaimAttributes == null) {

                this.IdpClaimAttributes = new List<IdpClaimAttributeType>();
                this.IdpClaimAttributes.ApplyExploratoryFieldSpec(ec.NewChild("idpClaimAttributes"));

            } else {

                this.IdpClaimAttributes.ApplyExploratoryFieldSpec(ec.NewChild("idpClaimAttributes"));

            }
        }
        else if (this.IdpClaimAttributes != null && ec.Excludes("idpClaimAttributes",false))
        {
            this.IdpClaimAttributes = null;
        }
    }


    #endregion

    } // class IdentityProvider
    
    #endregion

    public static class ListIdentityProviderExtensions
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
            this List<IdentityProvider> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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