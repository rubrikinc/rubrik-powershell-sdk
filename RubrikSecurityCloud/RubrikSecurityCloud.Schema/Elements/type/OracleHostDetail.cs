// OracleHostDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
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
    #region OracleHostDetail
    public class OracleHostDetail: IFragment
    {
        #region members
        //      C# -> OracleHostSummary? OracleHostSummary
        // GraphQL -> oracleHostSummary: OracleHostSummary (type)
        [JsonProperty("oracleHostSummary")]
        public OracleHostSummary? OracleHostSummary { get; set; }

        //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
        // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
        [JsonProperty("oracleNonSlaProperties")]
        public OracleNonSlaProperties? OracleNonSlaProperties { get; set; }

        #endregion

    #region methods

    public OracleHostDetail Set(
        OracleHostSummary? OracleHostSummary = null,
        OracleNonSlaProperties? OracleNonSlaProperties = null
    ) 
    {
        if ( OracleHostSummary != null ) {
            this.OracleHostSummary = OracleHostSummary;
        }
        if ( OracleNonSlaProperties != null ) {
            this.OracleNonSlaProperties = OracleNonSlaProperties;
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
            //      C# -> OracleHostSummary? OracleHostSummary
            // GraphQL -> oracleHostSummary: OracleHostSummary (type)
            if (this.OracleHostSummary != null)
            {
                 s += ind + "oracleHostSummary\n";

                 s += ind + "{\n" + 
                 this.OracleHostSummary.AsFragment(indent+1) + 
                 ind + "}\n";
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
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> OracleHostSummary? OracleHostSummary
            // GraphQL -> oracleHostSummary: OracleHostSummary (type)
            if (this.OracleHostSummary == null && Exploration.Includes(parent + ".oracleHostSummary"))
            {
                this.OracleHostSummary = new OracleHostSummary();
                this.OracleHostSummary.ApplyExploratoryFragment(parent + ".oracleHostSummary");
            }
            //      C# -> OracleNonSlaProperties? OracleNonSlaProperties
            // GraphQL -> oracleNonSlaProperties: OracleNonSlaProperties (type)
            if (this.OracleNonSlaProperties == null && Exploration.Includes(parent + ".oracleNonSlaProperties"))
            {
                this.OracleNonSlaProperties = new OracleNonSlaProperties();
                this.OracleNonSlaProperties.ApplyExploratoryFragment(parent + ".oracleNonSlaProperties");
            }
        }


    #endregion

    } // class OracleHostDetail
    #endregion

    public static class ListOracleHostDetailExtensions
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
            this List<OracleHostDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleHostDetail> list, 
            String parent = "")
        {
            var item = new OracleHostDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types