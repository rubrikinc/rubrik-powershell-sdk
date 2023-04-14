// OracleRacDetail.cs
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
    #region OracleRacDetail
    public class OracleRacDetail: IFragment
    {
        #region members
        //      C# -> System.String? Scan
        // GraphQL -> scan: String! (scalar)
        [JsonProperty("scan")]
        public System.String? Scan { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }

        //      C# -> OracleRacSummary? OracleRacSummary
        // GraphQL -> oracleRacSummary: OracleRacSummary (type)
        [JsonProperty("oracleRacSummary")]
        public OracleRacSummary? OracleRacSummary { get; set; }

        #endregion

    #region methods

    public OracleRacDetail Set(
        System.String? Scan = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null,
        OracleRacSummary? OracleRacSummary = null
    ) 
    {
        if ( Scan != null ) {
            this.Scan = Scan;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
        }
        if ( OracleRacSummary != null ) {
            this.OracleRacSummary = OracleRacSummary;
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
            //      C# -> System.String? Scan
            // GraphQL -> scan: String! (scalar)
            if (this.Scan != null)
            {
                 s += ind + "scan\n";

            }
            //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
            // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
            if (this.OracleNonSlaProperties != null)
            {
                 s += ind + "oracleNonSlaProperties\n";

                 s += ind + "{\n" + 
                 this.OracleNonSlaProperties.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleRacSummary? OracleRacSummary
            // GraphQL -> oracleRacSummary: OracleRacSummary (type)
            if (this.OracleRacSummary != null)
            {
                 s += ind + "oracleRacSummary\n";

                 s += ind + "{\n" + 
                 this.OracleRacSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Scan
            // GraphQL -> scan: String! (scalar)
            if (this.Scan == null && Exploration.Includes(parent + ".scan$"))
            {
                this.Scan = new System.String("FETCH");
            }
            //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
            // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
            if (this.OracleNonSlaProperties == null && Exploration.Includes(parent + ".oracleNonSlaProperties"))
            {
                this.OracleNonSlaProperties = new OracleNonSlaProperties();
                this.OracleNonSlaProperties.ApplyExploratoryFragment(parent + ".oracleNonSlaProperties");
            }
            //      C# -> OracleRacSummary? OracleRacSummary
            // GraphQL -> oracleRacSummary: OracleRacSummary (type)
            if (this.OracleRacSummary == null && Exploration.Includes(parent + ".oracleRacSummary"))
            {
                this.OracleRacSummary = new OracleRacSummary();
                this.OracleRacSummary.ApplyExploratoryFragment(parent + ".oracleRacSummary");
            }
        }


    #endregion

    } // class OracleRacDetail
    #endregion

    public static class ListOracleRacDetailExtensions
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
            this List<OracleRacDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleRacDetail> list, 
            String parent = "")
        {
            var item = new OracleRacDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types