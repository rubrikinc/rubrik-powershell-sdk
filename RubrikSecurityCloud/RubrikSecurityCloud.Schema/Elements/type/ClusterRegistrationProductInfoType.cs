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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            this List<ClusterRegistrationProductInfoType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterRegistrationProductInfoType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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