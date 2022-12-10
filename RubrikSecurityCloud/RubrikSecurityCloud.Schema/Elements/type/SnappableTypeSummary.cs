// SnappableTypeSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:28.
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
    #region SnappableTypeSummary
    public class SnappableTypeSummary: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> HierarchyObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("snappableType")]
        public HierarchyObjectTypeEnum? SnappableType { get; set; }

        #endregion

    #region methods

    public SnappableTypeSummary Set(
        System.Int32? Count = null,
        HierarchyObjectTypeEnum? SnappableType = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> HierarchyObjectTypeEnum? SnappableType
            // GraphQL -> snappableType: HierarchyObjectTypeEnum! (enum)
            if (this.SnappableType != null)
            {
                 s += ind + "snappableType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> HierarchyObjectTypeEnum? SnappableType
            // GraphQL -> snappableType: HierarchyObjectTypeEnum! (enum)
            if (this.SnappableType == null && Exploration.Includes(parent + ".snappableType$"))
            {
                this.SnappableType = new HierarchyObjectTypeEnum();
            }
        }


    #endregion

    } // class SnappableTypeSummary
    #endregion

    public static class ListSnappableTypeSummaryExtensions
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
            this List<SnappableTypeSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnappableTypeSummary> list, 
            String parent = "")
        {
            var item = new SnappableTypeSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types