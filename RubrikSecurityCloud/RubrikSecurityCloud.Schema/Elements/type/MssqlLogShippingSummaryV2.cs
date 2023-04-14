// MssqlLogShippingSummaryV2.cs
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
    #region MssqlLogShippingSummaryV2
    public class MssqlLogShippingSummaryV2: IFragment
    {
        #region members
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        [JsonProperty("makeupReseedLimit")]
        public System.Int32? MakeupReseedLimit { get; set; }

        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        [JsonProperty("mssqlLogShippingSummary")]
        public MssqlLogShippingSummary? MssqlLogShippingSummary { get; set; }

        #endregion

    #region methods

    public MssqlLogShippingSummaryV2 Set(
        System.Int32? MakeupReseedLimit = null,
        MssqlLogShippingSummary? MssqlLogShippingSummary = null
    ) 
    {
        if ( MakeupReseedLimit != null ) {
            this.MakeupReseedLimit = MakeupReseedLimit;
        }
        if ( MssqlLogShippingSummary != null ) {
            this.MssqlLogShippingSummary = MssqlLogShippingSummary;
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
            //      C# -> System.Int32? MakeupReseedLimit
            // GraphQL -> makeupReseedLimit: Int (scalar)
            if (this.MakeupReseedLimit != null)
            {
                 s += ind + "makeupReseedLimit\n";

            }
            //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
            // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
            if (this.MssqlLogShippingSummary != null)
            {
                 s += ind + "mssqlLogShippingSummary\n";

                 s += ind + "{\n" + 
                 this.MssqlLogShippingSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? MakeupReseedLimit
            // GraphQL -> makeupReseedLimit: Int (scalar)
            if (this.MakeupReseedLimit == null && Exploration.Includes(parent + ".makeupReseedLimit$"))
            {
                this.MakeupReseedLimit = new System.Int32();
            }
            //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
            // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
            if (this.MssqlLogShippingSummary == null && Exploration.Includes(parent + ".mssqlLogShippingSummary"))
            {
                this.MssqlLogShippingSummary = new MssqlLogShippingSummary();
                this.MssqlLogShippingSummary.ApplyExploratoryFragment(parent + ".mssqlLogShippingSummary");
            }
        }


    #endregion

    } // class MssqlLogShippingSummaryV2
    #endregion

    public static class ListMssqlLogShippingSummaryV2Extensions
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
            this List<MssqlLogShippingSummaryV2> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlLogShippingSummaryV2> list, 
            String parent = "")
        {
            var item = new MssqlLogShippingSummaryV2();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types