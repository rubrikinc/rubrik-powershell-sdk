// MosaicRecoveryRangeObject.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region MosaicRecoveryRangeObject
    public class MosaicRecoveryRangeObject: IFragment
    {
        #region members
        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        [JsonProperty("earliestTimestamp")]
        public System.String? EarliestTimestamp { get; set; }

        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        [JsonProperty("latestTimestamp")]
        public System.String? LatestTimestamp { get; set; }

        #endregion

    #region methods

    public MosaicRecoveryRangeObject Set(
        System.String? EarliestTimestamp = null,
        System.String? LatestTimestamp = null
    ) 
    {
        if ( EarliestTimestamp != null ) {
            this.EarliestTimestamp = EarliestTimestamp;
        }
        if ( LatestTimestamp != null ) {
            this.LatestTimestamp = LatestTimestamp;
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
            //      C# -> System.String? EarliestTimestamp
            // GraphQL -> earliestTimestamp: String (scalar)
            if (this.EarliestTimestamp != null)
            {
                 s += ind + "earliestTimestamp\n";

            }
            //      C# -> System.String? LatestTimestamp
            // GraphQL -> latestTimestamp: String (scalar)
            if (this.LatestTimestamp != null)
            {
                 s += ind + "latestTimestamp\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EarliestTimestamp
            // GraphQL -> earliestTimestamp: String (scalar)
            if (this.EarliestTimestamp == null && Exploration.Includes(parent + ".earliestTimestamp$"))
            {
                this.EarliestTimestamp = new System.String("FETCH");
            }
            //      C# -> System.String? LatestTimestamp
            // GraphQL -> latestTimestamp: String (scalar)
            if (this.LatestTimestamp == null && Exploration.Includes(parent + ".latestTimestamp$"))
            {
                this.LatestTimestamp = new System.String("FETCH");
            }
        }


    #endregion

    } // class MosaicRecoveryRangeObject
    #endregion

    public static class ListMosaicRecoveryRangeObjectExtensions
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
            this List<MosaicRecoveryRangeObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicRecoveryRangeObject> list, 
            String parent = "")
        {
            var item = new MosaicRecoveryRangeObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types