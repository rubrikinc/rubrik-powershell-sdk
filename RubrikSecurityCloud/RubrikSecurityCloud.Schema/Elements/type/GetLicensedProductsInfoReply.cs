// GetLicensedProductsInfoReply.cs
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
    #region GetLicensedProductsInfoReply
    public class GetLicensedProductsInfoReply: BaseType
    {
        #region members

        //      C# -> List<LicensedClusterProduct>? ClusterProducts
        // GraphQL -> clusterProducts: [LicensedClusterProduct!]! (type)
        [JsonProperty("clusterProducts")]
        public List<LicensedClusterProduct>? ClusterProducts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetLicensedProductsInfoReply";
    }

    public GetLicensedProductsInfoReply Set(
        List<LicensedClusterProduct>? ClusterProducts = null
    ) 
    {
        if ( ClusterProducts != null ) {
            this.ClusterProducts = ClusterProducts;
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
        //      C# -> List<LicensedClusterProduct>? ClusterProducts
        // GraphQL -> clusterProducts: [LicensedClusterProduct!]! (type)
        if (this.ClusterProducts != null) {
            var fspec = this.ClusterProducts.AsFieldSpec(conf.Child("clusterProducts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterProducts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<LicensedClusterProduct>? ClusterProducts
        // GraphQL -> clusterProducts: [LicensedClusterProduct!]! (type)
        if (ec.Includes("clusterProducts",false))
        {
            if(this.ClusterProducts == null) {

                this.ClusterProducts = new List<LicensedClusterProduct>();
                this.ClusterProducts.ApplyExploratoryFieldSpec(ec.NewChild("clusterProducts"));

            } else {

                this.ClusterProducts.ApplyExploratoryFieldSpec(ec.NewChild("clusterProducts"));

            }
        }
        else if (this.ClusterProducts != null && ec.Excludes("clusterProducts",false))
        {
            this.ClusterProducts = null;
        }
    }


    #endregion

    } // class GetLicensedProductsInfoReply
    
    #endregion

    public static class ListGetLicensedProductsInfoReplyExtensions
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
            this List<GetLicensedProductsInfoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetLicensedProductsInfoReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetLicensedProductsInfoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetLicensedProductsInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetLicensedProductsInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types