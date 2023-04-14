// AzureNativeResourceGroupSlaAssignment.cs
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
    #region AzureNativeResourceGroupSlaAssignment
    public class AzureNativeResourceGroupSlaAssignment: IFragment
    {
        #region members
        //      C# -> GlobalSlaReply? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: GlobalSlaReply! (type)
        [JsonProperty("configuredSlaDomain")]
        public GlobalSlaReply? ConfiguredSlaDomain { get; set; }

        //      C# -> GlobalSlaReply? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: GlobalSlaReply! (type)
        [JsonProperty("effectiveSlaDomain")]
        public GlobalSlaReply? EffectiveSlaDomain { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        #endregion

    #region methods

    public AzureNativeResourceGroupSlaAssignment Set(
        GlobalSlaReply? ConfiguredSlaDomain = null,
        GlobalSlaReply? EffectiveSlaDomain = null,
        SlaAssignmentTypeEnum? SlaAssignment = null
    ) 
    {
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
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
            //      C# -> GlobalSlaReply? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: GlobalSlaReply! (type)
            if (this.ConfiguredSlaDomain != null)
            {
                 s += ind + "configuredSlaDomain\n";

                 s += ind + "{\n" + 
                 this.ConfiguredSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GlobalSlaReply? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: GlobalSlaReply! (type)
            if (this.EffectiveSlaDomain != null)
            {
                 s += ind + "effectiveSlaDomain\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> GlobalSlaReply? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: GlobalSlaReply! (type)
            if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
            {
                this.ConfiguredSlaDomain = new GlobalSlaReply();
                this.ConfiguredSlaDomain.ApplyExploratoryFragment(parent + ".configuredSlaDomain");
            }
            //      C# -> GlobalSlaReply? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: GlobalSlaReply! (type)
            if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
            {
                this.EffectiveSlaDomain = new GlobalSlaReply();
                this.EffectiveSlaDomain.ApplyExploratoryFragment(parent + ".effectiveSlaDomain");
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
        }


    #endregion

    } // class AzureNativeResourceGroupSlaAssignment
    #endregion

    public static class ListAzureNativeResourceGroupSlaAssignmentExtensions
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
            this List<AzureNativeResourceGroupSlaAssignment> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeResourceGroupSlaAssignment> list, 
            String parent = "")
        {
            var item = new AzureNativeResourceGroupSlaAssignment();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types