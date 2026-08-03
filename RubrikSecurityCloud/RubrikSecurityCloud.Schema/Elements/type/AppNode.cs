// AppNode.cs
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
    #region AppNode
    public class AppNode: BaseType
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

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? ApplicationLogoId
        // GraphQL -> applicationLogoId: String! (scalar)
        [JsonProperty("applicationLogoId")]
        public System.String? ApplicationLogoId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppNode";
    }

    public AppNode Set(
        IdpType? IdpType = null,
        AppLogoId? LogoId = null,
        NativeType? NativeType = null,
        PrincipalRiskySummaryPrincipalType? PrincipalType = null,
        System.String? AppId = null,
        System.String? AppName = null,
        System.String? ApplicationLogoId = null
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
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( ApplicationLogoId != null ) {
            this.ApplicationLogoId = ApplicationLogoId;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appName\n" ;
            } else {
                s += ind + "appName\n" ;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (ec.Includes("appName",true))
        {
            if(this.AppName == null) {

                this.AppName = "FETCH";

            } else {


            }
        }
        else if (this.AppName != null && ec.Excludes("appName",true))
        {
            this.AppName = null;
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
    }


    #endregion

    } // class AppNode
    
    #endregion

    public static class ListAppNodeExtensions
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
            this List<AppNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppNode> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppNode> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types