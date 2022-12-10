// LicensesForClusterProductReply.cs
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
    #region LicensesForClusterProductReply
    public class LicensesForClusterProductReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<ProductTypeInfo>? Infos
            // GraphQL -> infos: [ProductTypeInfo!]! (type)
            if (this.Infos != null)
            {
                 s += ind + "infos\n";

                 s += ind + "{\n" + 
                 this.Infos.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> LicensedClusterProduct? Overview
            // GraphQL -> overview: LicensedClusterProduct (type)
            if (this.Overview != null)
            {
                 s += ind + "overview\n";

                 s += ind + "{\n" + 
                 this.Overview.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<ProductTypeInfo>? Infos
            // GraphQL -> infos: [ProductTypeInfo!]! (type)
            if (this.Infos == null && Exploration.Includes(parent + ".infos"))
            {
                this.Infos = new List<ProductTypeInfo>();
                this.Infos.ApplyExploratoryFragment(parent + ".infos");
            }
            //      C# -> LicensedClusterProduct? Overview
            // GraphQL -> overview: LicensedClusterProduct (type)
            if (this.Overview == null && Exploration.Includes(parent + ".overview"))
            {
                this.Overview = new LicensedClusterProduct();
                this.Overview.ApplyExploratoryFragment(parent + ".overview");
            }
        }


    #endregion

    } // class LicensesForClusterProductReply
    #endregion

    public static class ListLicensesForClusterProductReplyExtensions
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
            this List<LicensesForClusterProductReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LicensesForClusterProductReply> list, 
            String parent = "")
        {
            var item = new LicensesForClusterProductReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types