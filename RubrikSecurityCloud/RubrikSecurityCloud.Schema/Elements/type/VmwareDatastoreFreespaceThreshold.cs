// VmwareDatastoreFreespaceThreshold.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:10.
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
    #region VmwareDatastoreFreespaceThreshold
    public class VmwareDatastoreFreespaceThreshold: IFragment
    {
        #region members
        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        [JsonProperty("threshold")]
        public System.Single? Threshold { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        #endregion

    #region methods

    public VmwareDatastoreFreespaceThreshold Set(
        System.Single? Threshold = null,
        System.String? VmId = null
    ) 
    {
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
            //      C# -> System.Single? Threshold
            // GraphQL -> threshold: Float! (scalar)
            if (this.Threshold != null)
            {
                 s += ind + "threshold\n";

            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String (scalar)
            if (this.VmId != null)
            {
                 s += ind + "vmId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? Threshold
            // GraphQL -> threshold: Float! (scalar)
            if (this.Threshold == null && Exploration.Includes(parent + ".threshold$"))
            {
                this.Threshold = new System.Single();
            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String (scalar)
            if (this.VmId == null && Exploration.Includes(parent + ".vmId$"))
            {
                this.VmId = new System.String("FETCH");
            }
        }


    #endregion

    } // class VmwareDatastoreFreespaceThreshold
    #endregion

    public static class ListVmwareDatastoreFreespaceThresholdExtensions
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
            this List<VmwareDatastoreFreespaceThreshold> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareDatastoreFreespaceThreshold> list, 
            String parent = "")
        {
            var item = new VmwareDatastoreFreespaceThreshold();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types