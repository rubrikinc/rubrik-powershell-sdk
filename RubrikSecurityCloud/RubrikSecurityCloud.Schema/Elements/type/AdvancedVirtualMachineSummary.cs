// AdvancedVirtualMachineSummary.cs
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
    #region AdvancedVirtualMachineSummary
    public class AdvancedVirtualMachineSummary: IFragment
    {
        #region members
        //      C# -> List<System.String>? ExcludedVmdks
        // GraphQL -> excludedVmdks: [String!]! (scalar)
        [JsonProperty("excludedVmdks")]
        public List<System.String>? ExcludedVmdks { get; set; }

        //      C# -> VirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
        [JsonProperty("postBackupScript")]
        public VirtualMachineScriptDetail? PostBackupScript { get; set; }

        //      C# -> VirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
        [JsonProperty("postSnapScript")]
        public VirtualMachineScriptDetail? PostSnapScript { get; set; }

        //      C# -> VirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
        [JsonProperty("preBackupScript")]
        public VirtualMachineScriptDetail? PreBackupScript { get; set; }

        #endregion

    #region methods

    public AdvancedVirtualMachineSummary Set(
        List<System.String>? ExcludedVmdks = null,
        VirtualMachineScriptDetail? PostBackupScript = null,
        VirtualMachineScriptDetail? PostSnapScript = null,
        VirtualMachineScriptDetail? PreBackupScript = null
    ) 
    {
        if ( ExcludedVmdks != null ) {
            this.ExcludedVmdks = ExcludedVmdks;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PostSnapScript != null ) {
            this.PostSnapScript = PostSnapScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
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
            //      C# -> List<System.String>? ExcludedVmdks
            // GraphQL -> excludedVmdks: [String!]! (scalar)
            if (this.ExcludedVmdks != null)
            {
                 s += ind + "excludedVmdks\n";

            }
            //      C# -> VirtualMachineScriptDetail? PostBackupScript
            // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
            if (this.PostBackupScript != null)
            {
                 s += ind + "postBackupScript\n";

                 s += ind + "{\n" + 
                 this.PostBackupScript.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VirtualMachineScriptDetail? PostSnapScript
            // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
            if (this.PostSnapScript != null)
            {
                 s += ind + "postSnapScript\n";

                 s += ind + "{\n" + 
                 this.PostSnapScript.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VirtualMachineScriptDetail? PreBackupScript
            // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
            if (this.PreBackupScript != null)
            {
                 s += ind + "preBackupScript\n";

                 s += ind + "{\n" + 
                 this.PreBackupScript.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ExcludedVmdks
            // GraphQL -> excludedVmdks: [String!]! (scalar)
            if (this.ExcludedVmdks == null && Exploration.Includes(parent + ".excludedVmdks$"))
            {
                this.ExcludedVmdks = new List<System.String>();
            }
            //      C# -> VirtualMachineScriptDetail? PostBackupScript
            // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
            if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript"))
            {
                this.PostBackupScript = new VirtualMachineScriptDetail();
                this.PostBackupScript.ApplyExploratoryFragment(parent + ".postBackupScript");
            }
            //      C# -> VirtualMachineScriptDetail? PostSnapScript
            // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
            if (this.PostSnapScript == null && Exploration.Includes(parent + ".postSnapScript"))
            {
                this.PostSnapScript = new VirtualMachineScriptDetail();
                this.PostSnapScript.ApplyExploratoryFragment(parent + ".postSnapScript");
            }
            //      C# -> VirtualMachineScriptDetail? PreBackupScript
            // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
            if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
            {
                this.PreBackupScript = new VirtualMachineScriptDetail();
                this.PreBackupScript.ApplyExploratoryFragment(parent + ".preBackupScript");
            }
        }


    #endregion

    } // class AdvancedVirtualMachineSummary
    #endregion

    public static class ListAdvancedVirtualMachineSummaryExtensions
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
            this List<AdvancedVirtualMachineSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AdvancedVirtualMachineSummary> list, 
            String parent = "")
        {
            var item = new AdvancedVirtualMachineSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types