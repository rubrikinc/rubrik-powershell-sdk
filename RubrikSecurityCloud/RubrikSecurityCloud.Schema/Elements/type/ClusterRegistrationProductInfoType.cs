// ClusterRegistrationProductInfoType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterRegistrationProductInfoType
    public class ClusterRegistrationProductInfoType: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? LatestProductType
            // GraphQL -> latestProductType: String! (scalar)
            if (this.LatestProductType != null)
            {
                 s += ind + "latestProductType\n";

            }
            //      C# -> List<System.String>? ProductTypes
            // GraphQL -> productTypes: [String!]! (scalar)
            if (this.ProductTypes != null)
            {
                 s += ind + "productTypes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? LatestProductType
            // GraphQL -> latestProductType: String! (scalar)
            if (this.LatestProductType == null && Exploration.Includes(parent + ".latestProductType$"))
            {
                this.LatestProductType = new System.String("FETCH");
            }
            //      C# -> List<System.String>? ProductTypes
            // GraphQL -> productTypes: [String!]! (scalar)
            if (this.ProductTypes == null && Exploration.Includes(parent + ".productTypes$"))
            {
                this.ProductTypes = new List<System.String>();
            }
        }


    #endregion

    } // class ClusterRegistrationProductInfoType
    #endregion

    public static class ListClusterRegistrationProductInfoTypeExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ClusterRegistrationProductInfoType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterRegistrationProductInfoType> list, 
            String parent = "")
        {
            var item = new ClusterRegistrationProductInfoType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types