// LicensesForClusterProductReply.cs
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
    #region LicensesForClusterProductReply
    public class LicensesForClusterProductReply: BaseType
    {
        #region members

        //      C# -> List<ProductTypeInfo>? Infos
        // GraphQL -> infos: [ProductTypeInfo!]! (type)
        [JsonProperty("infos")]
        public List<ProductTypeInfo>? Infos { get; set; }

        //      C# -> LicensedClusterProduct? Overview
        // GraphQL -> overview: LicensedClusterProduct (type)
        [JsonProperty("overview")]
        public LicensedClusterProduct? Overview { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicensesForClusterProductReply";
    }

    public LicensesForClusterProductReply Set(
        List<ProductTypeInfo>? Infos = null,
        LicensedClusterProduct? Overview = null
    ) 
    {
        if ( Infos != null ) {
            this.Infos = Infos;
        }
        if ( Overview != null ) {
            this.Overview = Overview;
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
        //      C# -> List<ProductTypeInfo>? Infos
        // GraphQL -> infos: [ProductTypeInfo!]! (type)
        if (this.Infos != null) {
            var fspec = this.Infos.AsFieldSpec(conf.Child("infos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "infos {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LicensedClusterProduct? Overview
        // GraphQL -> overview: LicensedClusterProduct (type)
        if (this.Overview != null) {
            var fspec = this.Overview.AsFieldSpec(conf.Child("overview"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "overview {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ProductTypeInfo>? Infos
        // GraphQL -> infos: [ProductTypeInfo!]! (type)
        if (ec.Includes("infos",false))
        {
            if(this.Infos == null) {

                this.Infos = new List<ProductTypeInfo>();
                this.Infos.ApplyExploratoryFieldSpec(ec.NewChild("infos"));

            } else {

                this.Infos.ApplyExploratoryFieldSpec(ec.NewChild("infos"));

            }
        }
        else if (this.Infos != null && ec.Excludes("infos",false))
        {
            this.Infos = null;
        }
        //      C# -> LicensedClusterProduct? Overview
        // GraphQL -> overview: LicensedClusterProduct (type)
        if (ec.Includes("overview",false))
        {
            if(this.Overview == null) {

                this.Overview = new LicensedClusterProduct();
                this.Overview.ApplyExploratoryFieldSpec(ec.NewChild("overview"));

            } else {

                this.Overview.ApplyExploratoryFieldSpec(ec.NewChild("overview"));

            }
        }
        else if (this.Overview != null && ec.Excludes("overview",false))
        {
            this.Overview = null;
        }
    }


    #endregion

    } // class LicensesForClusterProductReply
    
    #endregion

    public static class ListLicensesForClusterProductReplyExtensions
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
            this List<LicensesForClusterProductReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicensesForClusterProductReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicensesForClusterProductReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicensesForClusterProductReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicensesForClusterProductReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types