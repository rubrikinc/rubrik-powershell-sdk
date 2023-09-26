// ClusterRegistrationProductInfoType.cs
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
    #region ClusterRegistrationProductInfoType
    public class ClusterRegistrationProductInfoType: BaseType
    {
        #region members

        //      C# -> System.String? LatestProductType
        // GraphQL -> latestProductType: String! (scalar)
        [JsonProperty("latestProductType")]
        public System.String? LatestProductType { get; set; }

        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        [JsonProperty("productTypes")]
        public List<System.String>? ProductTypes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterRegistrationProductInfoType";
    }

    public ClusterRegistrationProductInfoType Set(
        System.String? LatestProductType = null,
        List<System.String>? ProductTypes = null
    ) 
    {
        if ( LatestProductType != null ) {
            this.LatestProductType = LatestProductType;
        }
        if ( ProductTypes != null ) {
            this.ProductTypes = ProductTypes;
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
        //      C# -> System.String? LatestProductType
        // GraphQL -> latestProductType: String! (scalar)
        if (this.LatestProductType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestProductType\n" ;
            } else {
                s += ind + "latestProductType\n" ;
            }
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (this.ProductTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productTypes\n" ;
            } else {
                s += ind + "productTypes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? LatestProductType
        // GraphQL -> latestProductType: String! (scalar)
        if (ec.Includes("latestProductType",true))
        {
            if(this.LatestProductType == null) {

                this.LatestProductType = "FETCH";

            } else {


            }
        }
        else if (this.LatestProductType != null && ec.Excludes("latestProductType",true))
        {
            this.LatestProductType = null;
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (ec.Includes("productTypes",true))
        {
            if(this.ProductTypes == null) {

                this.ProductTypes = new List<System.String>();

            } else {


            }
        }
        else if (this.ProductTypes != null && ec.Excludes("productTypes",true))
        {
            this.ProductTypes = null;
        }
    }


    #endregion

    } // class ClusterRegistrationProductInfoType
    
    #endregion

    public static class ListClusterRegistrationProductInfoTypeExtensions
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
            this List<ClusterRegistrationProductInfoType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterRegistrationProductInfoType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterRegistrationProductInfoType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterRegistrationProductInfoType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types