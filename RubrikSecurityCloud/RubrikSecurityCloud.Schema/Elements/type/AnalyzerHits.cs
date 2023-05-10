// AnalyzerHits.cs
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
    #region AnalyzerHits
    public class AnalyzerHits: IFragment
    {
        #region members
        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        [JsonProperty("highRiskHits")]
        public SummaryHits? HighRiskHits { get; set; }

        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        [JsonProperty("lowRiskHits")]
        public SummaryHits? LowRiskHits { get; set; }

        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        [JsonProperty("mediumRiskHits")]
        public SummaryHits? MediumRiskHits { get; set; }

        #endregion

    #region methods

    public AnalyzerHits Set(
        SummaryHits? HighRiskHits = null,
        SummaryHits? LowRiskHits = null,
        SummaryHits? MediumRiskHits = null
    ) 
    {
        if ( HighRiskHits != null ) {
            this.HighRiskHits = HighRiskHits;
        }
        if ( LowRiskHits != null ) {
            this.LowRiskHits = LowRiskHits;
        }
        if ( MediumRiskHits != null ) {
            this.MediumRiskHits = MediumRiskHits;
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
            //      C# -> SummaryHits? HighRiskHits
            // GraphQL -> highRiskHits: SummaryHits (type)
            if (this.HighRiskHits != null)
            {
                 s += ind + "highRiskHits\n";

                 s += ind + "{\n" + 
                 this.HighRiskHits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SummaryHits? LowRiskHits
            // GraphQL -> lowRiskHits: SummaryHits (type)
            if (this.LowRiskHits != null)
            {
                 s += ind + "lowRiskHits\n";

                 s += ind + "{\n" + 
                 this.LowRiskHits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SummaryHits? MediumRiskHits
            // GraphQL -> mediumRiskHits: SummaryHits (type)
            if (this.MediumRiskHits != null)
            {
                 s += ind + "mediumRiskHits\n";

                 s += ind + "{\n" + 
                 this.MediumRiskHits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> SummaryHits? HighRiskHits
            // GraphQL -> highRiskHits: SummaryHits (type)
            if (this.HighRiskHits == null && Exploration.Includes(parent + ".highRiskHits"))
            {
                this.HighRiskHits = new SummaryHits();
                this.HighRiskHits.ApplyExploratoryFragment(parent + ".highRiskHits");
            }
            //      C# -> SummaryHits? LowRiskHits
            // GraphQL -> lowRiskHits: SummaryHits (type)
            if (this.LowRiskHits == null && Exploration.Includes(parent + ".lowRiskHits"))
            {
                this.LowRiskHits = new SummaryHits();
                this.LowRiskHits.ApplyExploratoryFragment(parent + ".lowRiskHits");
            }
            //      C# -> SummaryHits? MediumRiskHits
            // GraphQL -> mediumRiskHits: SummaryHits (type)
            if (this.MediumRiskHits == null && Exploration.Includes(parent + ".mediumRiskHits"))
            {
                this.MediumRiskHits = new SummaryHits();
                this.MediumRiskHits.ApplyExploratoryFragment(parent + ".mediumRiskHits");
            }
        }


    #endregion

    } // class AnalyzerHits
    #endregion

    public static class ListAnalyzerHitsExtensions
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
            this List<AnalyzerHits> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerHits> list, 
            String parent = "")
        {
            var item = new AnalyzerHits();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types