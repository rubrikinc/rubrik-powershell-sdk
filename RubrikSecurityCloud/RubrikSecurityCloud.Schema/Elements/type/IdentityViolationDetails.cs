// IdentityViolationDetails.cs
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
    #region IdentityViolationDetails
 
    public class IdentityViolationDetails: BaseType, ViolationDetailsUnion
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

        //      C# -> PrincipalOrigin? Origin
        // GraphQL -> origin: PrincipalOrigin! (enum)
        [JsonProperty("origin")]
        public PrincipalOrigin? Origin { get; set; }

        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        [JsonProperty("principalType")]
        public ViolationPrincipalType? PrincipalType { get; set; }

        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        [JsonProperty("privilegeType")]
        public PrivilegeType? PrivilegeType { get; set; }

        //      C# -> System.String? DomainFid
        // GraphQL -> domainFid: String! (scalar)
        [JsonProperty("domainFid")]
        public System.String? DomainFid { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        [JsonProperty("domainUniqueId")]
        public System.String? DomainUniqueId { get; set; }

        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        [JsonProperty("entityName")]
        public System.String? EntityName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrincipalUniqueId
        // GraphQL -> principalUniqueId: String! (scalar)
        [JsonProperty("principalUniqueId")]
        public System.String? PrincipalUniqueId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityViolationDetails";
    }

    public IdentityViolationDetails Set(
        List<IdentityTag>? IdentityTags = null,
        IdpType? IdpType = null,
        NativeType? NativeType = null,
        PrincipalOrigin? Origin = null,
        ViolationPrincipalType? PrincipalType = null,
        PrivilegeType? PrivilegeType = null,
        System.String? DomainFid = null,
        System.String? DomainName = null,
        System.String? DomainUniqueId = null,
        System.String? EntityName = null,
        System.String? Name = null,
        System.String? PrincipalUniqueId = null,
        DateTime? Time = null,
        System.String? Title = null,
        System.String? UniqueId = null,
        System.String? UserPrincipalName = null
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
        if ( Origin != null ) {
            this.Origin = Origin;
        }
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( PrivilegeType != null ) {
            this.PrivilegeType = PrivilegeType;
        }
        if ( DomainFid != null ) {
            this.DomainFid = DomainFid;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( DomainUniqueId != null ) {
            this.DomainUniqueId = DomainUniqueId;
        }
        if ( EntityName != null ) {
            this.EntityName = EntityName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrincipalUniqueId != null ) {
            this.PrincipalUniqueId = PrincipalUniqueId;
        }
        if ( Time != null ) {
            this.Time = Time;
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
        //      C# -> PrincipalOrigin? Origin
        // GraphQL -> origin: PrincipalOrigin! (enum)
        if (this.Origin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "origin\n" ;
            } else {
                s += ind + "origin\n" ;
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
        //      C# -> System.String? DomainFid
        // GraphQL -> domainFid: String! (scalar)
        if (this.DomainFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainFid\n" ;
            } else {
                s += ind + "domainFid\n" ;
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
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (this.EntityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityName\n" ;
            } else {
                s += ind + "entityName\n" ;
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
        //      C# -> System.String? PrincipalUniqueId
        // GraphQL -> principalUniqueId: String! (scalar)
        if (this.PrincipalUniqueId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalUniqueId\n" ;
            } else {
                s += ind + "principalUniqueId\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
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
        //      C# -> PrincipalOrigin? Origin
        // GraphQL -> origin: PrincipalOrigin! (enum)
        if (ec.Includes("origin",true))
        {
            if(this.Origin == null) {

                this.Origin = new PrincipalOrigin();

            } else {


            }
        }
        else if (this.Origin != null && ec.Excludes("origin",true))
        {
            this.Origin = null;
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
        //      C# -> System.String? DomainFid
        // GraphQL -> domainFid: String! (scalar)
        if (ec.Includes("domainFid",true))
        {
            if(this.DomainFid == null) {

                this.DomainFid = "FETCH";

            } else {


            }
        }
        else if (this.DomainFid != null && ec.Excludes("domainFid",true))
        {
            this.DomainFid = null;
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
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (ec.Includes("entityName",true))
        {
            if(this.EntityName == null) {

                this.EntityName = "FETCH";

            } else {


            }
        }
        else if (this.EntityName != null && ec.Excludes("entityName",true))
        {
            this.EntityName = null;
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
        //      C# -> System.String? PrincipalUniqueId
        // GraphQL -> principalUniqueId: String! (scalar)
        if (ec.Includes("principalUniqueId",true))
        {
            if(this.PrincipalUniqueId == null) {

                this.PrincipalUniqueId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalUniqueId != null && ec.Excludes("principalUniqueId",true))
        {
            this.PrincipalUniqueId = null;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (ec.Includes("time",true))
        {
            if(this.Time == null) {

                this.Time = new DateTime();

            } else {


            }
        }
        else if (this.Time != null && ec.Excludes("time",true))
        {
            this.Time = null;
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
    }


    #endregion

    } // class IdentityViolationDetails
    
    #endregion

    public static class ListIdentityViolationDetailsExtensions
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
            this List<IdentityViolationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityViolationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityViolationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityViolationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityViolationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types