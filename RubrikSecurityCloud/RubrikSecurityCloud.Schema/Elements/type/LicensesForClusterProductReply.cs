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
            this List<LicensesForClusterProductReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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