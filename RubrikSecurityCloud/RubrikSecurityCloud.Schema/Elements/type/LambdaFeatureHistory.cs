// LambdaFeatureHistory.cs
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
    #region LambdaFeatureHistory
    public class LambdaFeatureHistory: IFragment
    {
        #region members
        //      C# -> System.Boolean? WasRansomwareInvestigationEverEnabled
        // GraphQL -> wasRansomwareInvestigationEverEnabled: Boolean! (scalar)
        [JsonProperty("wasRansomwareInvestigationEverEnabled")]
        public System.Boolean? WasRansomwareInvestigationEverEnabled { get; set; }

        //      C# -> System.Boolean? WasSensitiveDataDiscoveryEverEnabled
        // GraphQL -> wasSensitiveDataDiscoveryEverEnabled: Boolean! (scalar)
        [JsonProperty("wasSensitiveDataDiscoveryEverEnabled")]
        public System.Boolean? WasSensitiveDataDiscoveryEverEnabled { get; set; }

        #endregion

    #region methods

    public LambdaFeatureHistory Set(
        System.Boolean? WasRansomwareInvestigationEverEnabled = null,
        System.Boolean? WasSensitiveDataDiscoveryEverEnabled = null
    ) 
    {
        if ( WasRansomwareInvestigationEverEnabled != null ) {
            this.WasRansomwareInvestigationEverEnabled = WasRansomwareInvestigationEverEnabled;
        }
        if ( WasSensitiveDataDiscoveryEverEnabled != null ) {
            this.WasSensitiveDataDiscoveryEverEnabled = WasSensitiveDataDiscoveryEverEnabled;
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
            //      C# -> System.Boolean? WasRansomwareInvestigationEverEnabled
            // GraphQL -> wasRansomwareInvestigationEverEnabled: Boolean! (scalar)
            if (this.WasRansomwareInvestigationEverEnabled != null)
            {
                 s += ind + "wasRansomwareInvestigationEverEnabled\n";

            }
            //      C# -> System.Boolean? WasSensitiveDataDiscoveryEverEnabled
            // GraphQL -> wasSensitiveDataDiscoveryEverEnabled: Boolean! (scalar)
            if (this.WasSensitiveDataDiscoveryEverEnabled != null)
            {
                 s += ind + "wasSensitiveDataDiscoveryEverEnabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? WasRansomwareInvestigationEverEnabled
            // GraphQL -> wasRansomwareInvestigationEverEnabled: Boolean! (scalar)
            if (this.WasRansomwareInvestigationEverEnabled == null && Exploration.Includes(parent + ".wasRansomwareInvestigationEverEnabled$"))
            {
                this.WasRansomwareInvestigationEverEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? WasSensitiveDataDiscoveryEverEnabled
            // GraphQL -> wasSensitiveDataDiscoveryEverEnabled: Boolean! (scalar)
            if (this.WasSensitiveDataDiscoveryEverEnabled == null && Exploration.Includes(parent + ".wasSensitiveDataDiscoveryEverEnabled$"))
            {
                this.WasSensitiveDataDiscoveryEverEnabled = new System.Boolean();
            }
        }


    #endregion

    } // class LambdaFeatureHistory
    #endregion

    public static class ListLambdaFeatureHistoryExtensions
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
            this List<LambdaFeatureHistory> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LambdaFeatureHistory> list, 
            String parent = "")
        {
            var item = new LambdaFeatureHistory();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types