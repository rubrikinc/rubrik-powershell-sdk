// VappInstantRecoveryOptions.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region VappInstantRecoveryOptions
    public class VappInstantRecoveryOptions: IFragment
    {
        #region members
        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        [JsonProperty("availableVappNetworks")]
        public List<VappNetworkSummary>? AvailableVappNetworks { get; set; }

        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        [JsonProperty("restorableVms")]
        public List<VappVmRestoreSpec>? RestorableVms { get; set; }

        #endregion

    #region methods

    public VappInstantRecoveryOptions Set(
        List<VappNetworkSummary>? AvailableVappNetworks = null,
        List<VappVmRestoreSpec>? RestorableVms = null
    ) 
    {
        if ( AvailableVappNetworks != null ) {
            this.AvailableVappNetworks = AvailableVappNetworks;
        }
        if ( RestorableVms != null ) {
            this.RestorableVms = RestorableVms;
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
            //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
            // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
            if (this.AvailableVappNetworks != null)
            {
                 s += ind + "availableVappNetworks\n";

                 s += ind + "{\n" + 
                 this.AvailableVappNetworks.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<VappVmRestoreSpec>? RestorableVms
            // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
            if (this.RestorableVms != null)
            {
                 s += ind + "restorableVms\n";

                 s += ind + "{\n" + 
                 this.RestorableVms.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
            // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
            if (this.AvailableVappNetworks == null && Exploration.Includes(parent + ".availableVappNetworks"))
            {
                this.AvailableVappNetworks = new List<VappNetworkSummary>();
                this.AvailableVappNetworks.ApplyExploratoryFragment(parent + ".availableVappNetworks");
            }
            //      C# -> List<VappVmRestoreSpec>? RestorableVms
            // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
            if (this.RestorableVms == null && Exploration.Includes(parent + ".restorableVms"))
            {
                this.RestorableVms = new List<VappVmRestoreSpec>();
                this.RestorableVms.ApplyExploratoryFragment(parent + ".restorableVms");
            }
        }


    #endregion

    } // class VappInstantRecoveryOptions
    #endregion

    public static class ListVappInstantRecoveryOptionsExtensions
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
            this List<VappInstantRecoveryOptions> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappInstantRecoveryOptions> list, 
            String parent = "")
        {
            var item = new VappInstantRecoveryOptions();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types