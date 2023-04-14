// AnalyzerRiskInstance.cs
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
    #region AnalyzerRiskInstance
    public class AnalyzerRiskInstance: IFragment
    {
        #region members
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        [JsonProperty("analyzerId")]
        public System.String? AnalyzerId { get; set; }

        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        [JsonProperty("riskVersion")]
        public System.Int32? RiskVersion { get; set; }

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        #endregion

    #region methods

    public AnalyzerRiskInstance Set(
        System.String? AnalyzerId = null,
        System.Int32? RiskVersion = null,
        RiskLevelType? Risk = null
    ) 
    {
        if ( AnalyzerId != null ) {
            this.AnalyzerId = AnalyzerId;
        }
        if ( RiskVersion != null ) {
            this.RiskVersion = RiskVersion;
        }
        if ( Risk != null ) {
            this.Risk = Risk;
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
            //      C# -> System.String? AnalyzerId
            // GraphQL -> analyzerId: String! (scalar)
            if (this.AnalyzerId != null)
            {
                 s += ind + "analyzerId\n";

            }
            //      C# -> System.Int32? RiskVersion
            // GraphQL -> riskVersion: Int! (scalar)
            if (this.RiskVersion != null)
            {
                 s += ind + "riskVersion\n";

            }
            //      C# -> RiskLevelType? Risk
            // GraphQL -> risk: RiskLevelType! (enum)
            if (this.Risk != null)
            {
                 s += ind + "risk\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AnalyzerId
            // GraphQL -> analyzerId: String! (scalar)
            if (this.AnalyzerId == null && Exploration.Includes(parent + ".analyzerId$"))
            {
                this.AnalyzerId = new System.String("FETCH");
            }
            //      C# -> System.Int32? RiskVersion
            // GraphQL -> riskVersion: Int! (scalar)
            if (this.RiskVersion == null && Exploration.Includes(parent + ".riskVersion$"))
            {
                this.RiskVersion = new System.Int32();
            }
            //      C# -> RiskLevelType? Risk
            // GraphQL -> risk: RiskLevelType! (enum)
            if (this.Risk == null && Exploration.Includes(parent + ".risk$"))
            {
                this.Risk = new RiskLevelType();
            }
        }


    #endregion

    } // class AnalyzerRiskInstance
    #endregion

    public static class ListAnalyzerRiskInstanceExtensions
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
            this List<AnalyzerRiskInstance> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerRiskInstance> list, 
            String parent = "")
        {
            var item = new AnalyzerRiskInstance();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types