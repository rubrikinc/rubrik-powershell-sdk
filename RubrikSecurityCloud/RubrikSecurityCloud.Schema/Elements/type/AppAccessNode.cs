// AppAccessNode.cs
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
    #region AppAccessNode
    public class AppAccessNode: BaseType
    {
        #region members

        //      C# -> AppAccessNodeId? Id
        // GraphQL -> id: AppAccessNodeId! (enum)
        [JsonProperty("id")]
        public AppAccessNodeId? Id { get; set; }

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

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        [JsonProperty("principalName")]
        public System.String? PrincipalName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppAccessNode";
    }

    public AppAccessNode Set(
        AppAccessNodeId? Id = null,
        IdpType? IdpType = null,
        AppLogoId? LogoId = null,
        NativeType? NativeType = null,
        PrincipalRiskySummaryPrincipalType? PrincipalType = null,
        System.Int32? Count = null,
        System.String? PrincipalId = null,
        System.String? PrincipalName = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
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
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( PrincipalName != null ) {
            this.PrincipalName = PrincipalName;
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
        //      C# -> AppAccessNodeId? Id
        // GraphQL -> id: AppAccessNodeId! (enum)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
            }
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (this.PrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalName\n" ;
            } else {
                s += ind + "principalName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AppAccessNodeId? Id
        // GraphQL -> id: AppAccessNodeId! (enum)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new AppAccessNodeId();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (ec.Includes("principalName",true))
        {
            if(this.PrincipalName == null) {

                this.PrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalName != null && ec.Excludes("principalName",true))
        {
            this.PrincipalName = null;
        }
    }


    #endregion

    } // class AppAccessNode
    
    #endregion

    public static class ListAppAccessNodeExtensions
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
            this List<AppAccessNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppAccessNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppAccessNode> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppAccessNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppAccessNode> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types