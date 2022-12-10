// LambdaSettings.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    #region LambdaSettings
    public class LambdaSettings: IFragment
    {
        #region members
        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        [JsonProperty("anomalyThreshold")]
        public System.Single? AnomalyThreshold { get; set; }

        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        [JsonProperty("isAnomalyAlertEnabled")]
        public System.Boolean? IsAnomalyAlertEnabled { get; set; }

        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        [JsonProperty("ransomwareThreshold")]
        public System.Single? RansomwareThreshold { get; set; }

        #endregion

    #region methods

    public LambdaSettings Set(
        System.Single? AnomalyThreshold = null,
        System.Boolean? IsAnomalyAlertEnabled = null,
        System.Single? RansomwareThreshold = null
    ) 
    {
        if ( AnomalyThreshold != null ) {
            this.AnomalyThreshold = AnomalyThreshold;
        }
        if ( IsAnomalyAlertEnabled != null ) {
            this.IsAnomalyAlertEnabled = IsAnomalyAlertEnabled;
        }
        if ( RansomwareThreshold != null ) {
            this.RansomwareThreshold = RansomwareThreshold;
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
            //      C# -> System.Single? AnomalyThreshold
            // GraphQL -> anomalyThreshold: Float (scalar)
            if (this.AnomalyThreshold != null)
            {
                 s += ind + "anomalyThreshold\n";

            }
            //      C# -> System.Boolean? IsAnomalyAlertEnabled
            // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
            if (this.IsAnomalyAlertEnabled != null)
            {
                 s += ind + "isAnomalyAlertEnabled\n";

            }
            //      C# -> System.Single? RansomwareThreshold
            // GraphQL -> ransomwareThreshold: Float (scalar)
            if (this.RansomwareThreshold != null)
            {
                 s += ind + "ransomwareThreshold\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? AnomalyThreshold
            // GraphQL -> anomalyThreshold: Float (scalar)
            if (this.AnomalyThreshold == null && Exploration.Includes(parent + ".anomalyThreshold$"))
            {
                this.AnomalyThreshold = new System.Single();
            }
            //      C# -> System.Boolean? IsAnomalyAlertEnabled
            // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
            if (this.IsAnomalyAlertEnabled == null && Exploration.Includes(parent + ".isAnomalyAlertEnabled$"))
            {
                this.IsAnomalyAlertEnabled = new System.Boolean();
            }
            //      C# -> System.Single? RansomwareThreshold
            // GraphQL -> ransomwareThreshold: Float (scalar)
            if (this.RansomwareThreshold == null && Exploration.Includes(parent + ".ransomwareThreshold$"))
            {
                this.RansomwareThreshold = new System.Single();
            }
        }


    #endregion

    } // class LambdaSettings
    #endregion

    public static class ListLambdaSettingsExtensions
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
            this List<LambdaSettings> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LambdaSettings> list, 
            String parent = "")
        {
            var item = new LambdaSettings();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types