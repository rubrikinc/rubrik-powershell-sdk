// IdentityMetadata.cs
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
    #region IdentityMetadata
 
    public class IdentityMetadata: BaseType, ResourceMetadataUnion
    {
        #region members

        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!]! (enum)
        [JsonProperty("identityTags")]
        public List<IdentityTag>? IdentityTags { get; set; }

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        [JsonProperty("nativeType")]
        public NativeType? NativeType { get; set; }

        //      C# -> PrincipalOrigin? PrincipalOrigin
        // GraphQL -> principalOrigin: PrincipalOrigin! (enum)
        [JsonProperty("principalOrigin")]
        public PrincipalOrigin? PrincipalOrigin { get; set; }

        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        [JsonProperty("principalType")]
        public ViolationPrincipalType? PrincipalType { get; set; }

        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        [JsonProperty("privilegeType")]
        public PrivilegeType? PrivilegeType { get; set; }

        //      C# -> IdentityResolutionType? ResolutionType
        // GraphQL -> resolutionType: IdentityResolutionType! (enum)
        [JsonProperty("resolutionType")]
        public IdentityResolutionType? ResolutionType { get; set; }

        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        [JsonProperty("status")]
        public IdentityStatus? Status { get; set; }

        //      C# -> System.Int64? AccessibleObjectsCount
        // GraphQL -> accessibleObjectsCount: Long! (scalar)
        [JsonProperty("accessibleObjectsCount")]
        public System.Int64? AccessibleObjectsCount { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        [JsonProperty("domainUniqueId")]
        public System.String? DomainUniqueId { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.String? UniqueId
        // GraphQL -> uniqueId: String! (scalar)
        [JsonProperty("uniqueId")]
        public System.String? UniqueId { get; set; }

        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        [JsonProperty("userPrincipalName")]
        public System.String? UserPrincipalName { get; set; }

        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        [JsonProperty("sensitiveHits")]
        public SensitiveHits? SensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityMetadata";
    }

    public IdentityMetadata Set(
        List<IdentityTag>? IdentityTags = null,
        IdpType? IdpType = null,
        NativeType? NativeType = null,
        PrincipalOrigin? PrincipalOrigin = null,
        ViolationPrincipalType? PrincipalType = null,
        PrivilegeType? PrivilegeType = null,
        IdentityResolutionType? ResolutionType = null,
        IdentityStatus? Status = null,
        System.Int64? AccessibleObjectsCount = null,
        System.String? DisplayName = null,
        System.String? DomainName = null,
        System.String? DomainUniqueId = null,
        System.String? Source = null,
        System.String? Title = null,
        System.String? UniqueId = null,
        System.String? UserPrincipalName = null,
        SensitiveHits? SensitiveHits = null
    ) 
    {
        if ( IdentityTags != null ) {
            this.IdentityTags = IdentityTags;
        }
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( NativeType != null ) {
            this.NativeType = NativeType;
        }
        if ( PrincipalOrigin != null ) {
            this.PrincipalOrigin = PrincipalOrigin;
        }
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( PrivilegeType != null ) {
            this.PrivilegeType = PrivilegeType;
        }
        if ( ResolutionType != null ) {
            this.ResolutionType = ResolutionType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( AccessibleObjectsCount != null ) {
            this.AccessibleObjectsCount = AccessibleObjectsCount;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( DomainUniqueId != null ) {
            this.DomainUniqueId = DomainUniqueId;
        }
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( UniqueId != null ) {
            this.UniqueId = UniqueId;
        }
        if ( UserPrincipalName != null ) {
            this.UserPrincipalName = UserPrincipalName;
        }
        if ( SensitiveHits != null ) {
            this.SensitiveHits = SensitiveHits;
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
        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!]! (enum)
        if (this.IdentityTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identityTags\n" ;
            } else {
                s += ind + "identityTags\n" ;
            }
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        if (this.NativeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeType\n" ;
            } else {
                s += ind + "nativeType\n" ;
            }
        }
        //      C# -> PrincipalOrigin? PrincipalOrigin
        // GraphQL -> principalOrigin: PrincipalOrigin! (enum)
        if (this.PrincipalOrigin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalOrigin\n" ;
            } else {
                s += ind + "principalOrigin\n" ;
            }
        }
        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        if (this.PrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privilegeType\n" ;
            } else {
                s += ind + "privilegeType\n" ;
            }
        }
        //      C# -> IdentityResolutionType? ResolutionType
        // GraphQL -> resolutionType: IdentityResolutionType! (enum)
        if (this.ResolutionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resolutionType\n" ;
            } else {
                s += ind + "resolutionType\n" ;
            }
        }
        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int64? AccessibleObjectsCount
        // GraphQL -> accessibleObjectsCount: Long! (scalar)
        if (this.AccessibleObjectsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessibleObjectsCount\n" ;
            } else {
                s += ind + "accessibleObjectsCount\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        if (this.DomainUniqueId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainUniqueId\n" ;
            } else {
                s += ind + "domainUniqueId\n" ;
            }
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> System.String? UniqueId
        // GraphQL -> uniqueId: String! (scalar)
        if (this.UniqueId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniqueId\n" ;
            } else {
                s += ind + "uniqueId\n" ;
            }
        }
        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        if (this.UserPrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userPrincipalName\n" ;
            } else {
                s += ind + "userPrincipalName\n" ;
            }
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits != null) {
            var fspec = this.SensitiveHits.AsFieldSpec(conf.Child("sensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!]! (enum)
        if (ec.Includes("identityTags",true))
        {
            if(this.IdentityTags == null) {

                this.IdentityTags = new List<IdentityTag>();

            } else {


            }
        }
        else if (this.IdentityTags != null && ec.Excludes("identityTags",true))
        {
            this.IdentityTags = null;
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        if (ec.Includes("nativeType",true))
        {
            if(this.NativeType == null) {

                this.NativeType = new NativeType();

            } else {


            }
        }
        else if (this.NativeType != null && ec.Excludes("nativeType",true))
        {
            this.NativeType = null;
        }
        //      C# -> PrincipalOrigin? PrincipalOrigin
        // GraphQL -> principalOrigin: PrincipalOrigin! (enum)
        if (ec.Includes("principalOrigin",true))
        {
            if(this.PrincipalOrigin == null) {

                this.PrincipalOrigin = new PrincipalOrigin();

            } else {


            }
        }
        else if (this.PrincipalOrigin != null && ec.Excludes("principalOrigin",true))
        {
            this.PrincipalOrigin = null;
        }
        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        if (ec.Includes("privilegeType",true))
        {
            if(this.PrivilegeType == null) {

                this.PrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.PrivilegeType != null && ec.Excludes("privilegeType",true))
        {
            this.PrivilegeType = null;
        }
        //      C# -> IdentityResolutionType? ResolutionType
        // GraphQL -> resolutionType: IdentityResolutionType! (enum)
        if (ec.Includes("resolutionType",true))
        {
            if(this.ResolutionType == null) {

                this.ResolutionType = new IdentityResolutionType();

            } else {


            }
        }
        else if (this.ResolutionType != null && ec.Excludes("resolutionType",true))
        {
            this.ResolutionType = null;
        }
        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new IdentityStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int64? AccessibleObjectsCount
        // GraphQL -> accessibleObjectsCount: Long! (scalar)
        if (ec.Includes("accessibleObjectsCount",true))
        {
            if(this.AccessibleObjectsCount == null) {

                this.AccessibleObjectsCount = new System.Int64();

            } else {


            }
        }
        else if (this.AccessibleObjectsCount != null && ec.Excludes("accessibleObjectsCount",true))
        {
            this.AccessibleObjectsCount = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        if (ec.Includes("domainUniqueId",true))
        {
            if(this.DomainUniqueId == null) {

                this.DomainUniqueId = "FETCH";

            } else {


            }
        }
        else if (this.DomainUniqueId != null && ec.Excludes("domainUniqueId",true))
        {
            this.DomainUniqueId = null;
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = "FETCH";

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> System.String? UniqueId
        // GraphQL -> uniqueId: String! (scalar)
        if (ec.Includes("uniqueId",true))
        {
            if(this.UniqueId == null) {

                this.UniqueId = "FETCH";

            } else {


            }
        }
        else if (this.UniqueId != null && ec.Excludes("uniqueId",true))
        {
            this.UniqueId = null;
        }
        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        if (ec.Includes("userPrincipalName",true))
        {
            if(this.UserPrincipalName == null) {

                this.UserPrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.UserPrincipalName != null && ec.Excludes("userPrincipalName",true))
        {
            this.UserPrincipalName = null;
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (ec.Includes("sensitiveHits",false))
        {
            if(this.SensitiveHits == null) {

                this.SensitiveHits = new SensitiveHits();
                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            } else {

                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            }
        }
        else if (this.SensitiveHits != null && ec.Excludes("sensitiveHits",false))
        {
            this.SensitiveHits = null;
        }
    }


    #endregion

    } // class IdentityMetadata
    
    #endregion

    public static class ListIdentityMetadataExtensions
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
            this List<IdentityMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types