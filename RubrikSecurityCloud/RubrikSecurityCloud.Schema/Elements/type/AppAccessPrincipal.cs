// AppAccessPrincipal.cs
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
    #region AppAccessPrincipal
    public class AppAccessPrincipal: BaseType
    {
        #region members

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> AppLogoId? LogoId
        // GraphQL -> logoId: AppLogoId! (enum)
        [JsonProperty("logoId")]
        public AppLogoId? LogoId { get; set; }

        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        [JsonProperty("nativeType")]
        public NativeType? NativeType { get; set; }

        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType! (enum)
        [JsonProperty("principalType")]
        public PrincipalRiskySummaryPrincipalType? PrincipalType { get; set; }

        //      C# -> System.Int32? AppCount
        // GraphQL -> appCount: Int! (scalar)
        [JsonProperty("appCount")]
        public System.Int32? AppCount { get; set; }

        //      C# -> System.String? ApplicationLogoId
        // GraphQL -> applicationLogoId: String! (scalar)
        [JsonProperty("applicationLogoId")]
        public System.String? ApplicationLogoId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? MemberCount
        // GraphQL -> memberCount: Int! (scalar)
        [JsonProperty("memberCount")]
        public System.Int32? MemberCount { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppAccessPrincipal";
    }

    public AppAccessPrincipal Set(
        IdpType? IdpType = null,
        AppLogoId? LogoId = null,
        NativeType? NativeType = null,
        PrincipalRiskySummaryPrincipalType? PrincipalType = null,
        System.Int32? AppCount = null,
        System.String? ApplicationLogoId = null,
        System.String? Id = null,
        System.Int32? MemberCount = null,
        System.String? Name = null
    ) 
    {
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( LogoId != null ) {
            this.LogoId = LogoId;
        }
        if ( NativeType != null ) {
            this.NativeType = NativeType;
        }
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( AppCount != null ) {
            this.AppCount = AppCount;
        }
        if ( ApplicationLogoId != null ) {
            this.ApplicationLogoId = ApplicationLogoId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MemberCount != null ) {
            this.MemberCount = MemberCount;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> AppLogoId? LogoId
        // GraphQL -> logoId: AppLogoId! (enum)
        if (this.LogoId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logoId\n" ;
            } else {
                s += ind + "logoId\n" ;
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
        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> System.Int32? AppCount
        // GraphQL -> appCount: Int! (scalar)
        if (this.AppCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appCount\n" ;
            } else {
                s += ind + "appCount\n" ;
            }
        }
        //      C# -> System.String? ApplicationLogoId
        // GraphQL -> applicationLogoId: String! (scalar)
        if (this.ApplicationLogoId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationLogoId\n" ;
            } else {
                s += ind + "applicationLogoId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int32? MemberCount
        // GraphQL -> memberCount: Int! (scalar)
        if (this.MemberCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memberCount\n" ;
            } else {
                s += ind + "memberCount\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> AppLogoId? LogoId
        // GraphQL -> logoId: AppLogoId! (enum)
        if (ec.Includes("logoId",true))
        {
            if(this.LogoId == null) {

                this.LogoId = new AppLogoId();

            } else {


            }
        }
        else if (this.LogoId != null && ec.Excludes("logoId",true))
        {
            this.LogoId = null;
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
        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new PrincipalRiskySummaryPrincipalType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> System.Int32? AppCount
        // GraphQL -> appCount: Int! (scalar)
        if (ec.Includes("appCount",true))
        {
            if(this.AppCount == null) {

                this.AppCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AppCount != null && ec.Excludes("appCount",true))
        {
            this.AppCount = null;
        }
        //      C# -> System.String? ApplicationLogoId
        // GraphQL -> applicationLogoId: String! (scalar)
        if (ec.Includes("applicationLogoId",true))
        {
            if(this.ApplicationLogoId == null) {

                this.ApplicationLogoId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationLogoId != null && ec.Excludes("applicationLogoId",true))
        {
            this.ApplicationLogoId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.Int32? MemberCount
        // GraphQL -> memberCount: Int! (scalar)
        if (ec.Includes("memberCount",true))
        {
            if(this.MemberCount == null) {

                this.MemberCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.MemberCount != null && ec.Excludes("memberCount",true))
        {
            this.MemberCount = null;
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
    }


    #endregion

    } // class AppAccessPrincipal
    
    #endregion

    public static class ListAppAccessPrincipalExtensions
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
            this List<AppAccessPrincipal> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppAccessPrincipal> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppAccessPrincipal> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppAccessPrincipal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppAccessPrincipal> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types