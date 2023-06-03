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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? LatestProductType
        // GraphQL -> latestProductType: String! (scalar)
        if (this.LatestProductType != null) {
            s += ind + "latestProductType\n" ;
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (this.ProductTypes != null) {
            s += ind + "productTypes\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? LatestProductType
        // GraphQL -> latestProductType: String! (scalar)
        if (this.LatestProductType == null && Exploration.Includes(parent + ".latestProductType", true))
        {
            this.LatestProductType = new System.String("FETCH");
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (this.ProductTypes == null && Exploration.Includes(parent + ".productTypes", true))
        {
            this.ProductTypes = new List<System.String>();
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterRegistrationProductInfoType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterRegistrationProductInfoType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types