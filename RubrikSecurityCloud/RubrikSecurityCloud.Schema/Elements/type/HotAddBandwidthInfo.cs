// HotAddBandwidthInfo.cs
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
    #region HotAddBandwidthInfo
    public class HotAddBandwidthInfo: IFragment
    {
        #region members
        //      C# -> System.Int32? ExportLimit
        // GraphQL -> exportLimit: Int! (scalar)
        [JsonProperty("exportLimit")]
        public System.Int32? ExportLimit { get; set; }

        //      C# -> System.Int32? IngestLimit
        // GraphQL -> ingestLimit: Int! (scalar)
        [JsonProperty("ingestLimit")]
        public System.Int32? IngestLimit { get; set; }

        #endregion

    #region methods

    public HotAddBandwidthInfo Set(
        System.Int32? ExportLimit = null,
        System.Int32? IngestLimit = null
    ) 
    {
        if ( ExportLimit != null ) {
            this.ExportLimit = ExportLimit;
        }
        if ( IngestLimit != null ) {
            this.IngestLimit = IngestLimit;
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
            //      C# -> System.Int32? ExportLimit
            // GraphQL -> exportLimit: Int! (scalar)
            if (this.ExportLimit != null)
            {
                 s += ind + "exportLimit\n";

            }
            //      C# -> System.Int32? IngestLimit
            // GraphQL -> ingestLimit: Int! (scalar)
            if (this.IngestLimit != null)
            {
                 s += ind + "ingestLimit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? ExportLimit
            // GraphQL -> exportLimit: Int! (scalar)
            if (this.ExportLimit == null && Exploration.Includes(parent + ".exportLimit$"))
            {
                this.ExportLimit = new System.Int32();
            }
            //      C# -> System.Int32? IngestLimit
            // GraphQL -> ingestLimit: Int! (scalar)
            if (this.IngestLimit == null && Exploration.Includes(parent + ".ingestLimit$"))
            {
                this.IngestLimit = new System.Int32();
            }
        }


    #endregion

    } // class HotAddBandwidthInfo
    #endregion

    public static class ListHotAddBandwidthInfoExtensions
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
            this List<HotAddBandwidthInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HotAddBandwidthInfo> list, 
            String parent = "")
        {
            var item = new HotAddBandwidthInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types