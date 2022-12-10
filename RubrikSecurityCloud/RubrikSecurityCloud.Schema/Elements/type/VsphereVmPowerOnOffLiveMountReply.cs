// VsphereVmPowerOnOffLiveMountReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:41.
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
    #region VsphereVmPowerOnOffLiveMountReply
    public class VsphereVmPowerOnOffLiveMountReply: IFragment
    {
        #region members
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        [JsonProperty("nasIp")]
        public System.String? NasIp { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        [JsonProperty("vmwareVmMountSummaryV1")]
        public VmwareVmMountSummaryV1? VmwareVmMountSummaryV1 { get; set; }

        #endregion

    #region methods

    public VsphereVmPowerOnOffLiveMountReply Set(
        System.String? NasIp = null,
        System.String? PowerStatus = null,
        VmwareVmMountSummaryV1? VmwareVmMountSummaryV1 = null
    ) 
    {
        if ( NasIp != null ) {
            this.NasIp = NasIp;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( VmwareVmMountSummaryV1 != null ) {
            this.VmwareVmMountSummaryV1 = VmwareVmMountSummaryV1;
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
            //      C# -> System.String? NasIp
            // GraphQL -> nasIp: String (scalar)
            if (this.NasIp != null)
            {
                 s += ind + "nasIp\n";

            }
            //      C# -> System.String? PowerStatus
            // GraphQL -> powerStatus: String (scalar)
            if (this.PowerStatus != null)
            {
                 s += ind + "powerStatus\n";

            }
            //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
            // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
            if (this.VmwareVmMountSummaryV1 != null)
            {
                 s += ind + "vmwareVmMountSummaryV1\n";

                 s += ind + "{\n" + 
                 this.VmwareVmMountSummaryV1.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NasIp
            // GraphQL -> nasIp: String (scalar)
            if (this.NasIp == null && Exploration.Includes(parent + ".nasIp$"))
            {
                this.NasIp = new System.String("FETCH");
            }
            //      C# -> System.String? PowerStatus
            // GraphQL -> powerStatus: String (scalar)
            if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus$"))
            {
                this.PowerStatus = new System.String("FETCH");
            }
            //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
            // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
            if (this.VmwareVmMountSummaryV1 == null && Exploration.Includes(parent + ".vmwareVmMountSummaryV1"))
            {
                this.VmwareVmMountSummaryV1 = new VmwareVmMountSummaryV1();
                this.VmwareVmMountSummaryV1.ApplyExploratoryFragment(parent + ".vmwareVmMountSummaryV1");
            }
        }


    #endregion

    } // class VsphereVmPowerOnOffLiveMountReply
    #endregion

    public static class ListVsphereVmPowerOnOffLiveMountReplyExtensions
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
            this List<VsphereVmPowerOnOffLiveMountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VsphereVmPowerOnOffLiveMountReply> list, 
            String parent = "")
        {
            var item = new VsphereVmPowerOnOffLiveMountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types