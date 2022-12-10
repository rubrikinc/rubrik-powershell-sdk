// VmwareCdpStateInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:09.
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
    #region VmwareCdpStateInfo
    public class VmwareCdpStateInfo: IFragment
    {
        #region members
        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        [JsonProperty("healthPercentage")]
        public System.Single? HealthPercentage { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        [JsonProperty("localStatus")]
        public CdpLocalStatus? LocalStatus { get; set; }

        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        [JsonProperty("replicationStatus")]
        public CdpReplicationStatus? ReplicationStatus { get; set; }

        #endregion

    #region methods

    public VmwareCdpStateInfo Set(
        System.Single? HealthPercentage = null,
        System.String? VmId = null,
        CdpLocalStatus? LocalStatus = null,
        CdpReplicationStatus? ReplicationStatus = null
    ) 
    {
        if ( HealthPercentage != null ) {
            this.HealthPercentage = HealthPercentage;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( LocalStatus != null ) {
            this.LocalStatus = LocalStatus;
        }
        if ( ReplicationStatus != null ) {
            this.ReplicationStatus = ReplicationStatus;
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
            //      C# -> System.Single? HealthPercentage
            // GraphQL -> healthPercentage: Float (scalar)
            if (this.HealthPercentage != null)
            {
                 s += ind + "healthPercentage\n";

            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId != null)
            {
                 s += ind + "vmId\n";

            }
            //      C# -> CdpLocalStatus? LocalStatus
            // GraphQL -> localStatus: CdpLocalStatus (enum)
            if (this.LocalStatus != null)
            {
                 s += ind + "localStatus\n";

            }
            //      C# -> CdpReplicationStatus? ReplicationStatus
            // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
            if (this.ReplicationStatus != null)
            {
                 s += ind + "replicationStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? HealthPercentage
            // GraphQL -> healthPercentage: Float (scalar)
            if (this.HealthPercentage == null && Exploration.Includes(parent + ".healthPercentage$"))
            {
                this.HealthPercentage = new System.Single();
            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId == null && Exploration.Includes(parent + ".vmId$"))
            {
                this.VmId = new System.String("FETCH");
            }
            //      C# -> CdpLocalStatus? LocalStatus
            // GraphQL -> localStatus: CdpLocalStatus (enum)
            if (this.LocalStatus == null && Exploration.Includes(parent + ".localStatus$"))
            {
                this.LocalStatus = new CdpLocalStatus();
            }
            //      C# -> CdpReplicationStatus? ReplicationStatus
            // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
            if (this.ReplicationStatus == null && Exploration.Includes(parent + ".replicationStatus$"))
            {
                this.ReplicationStatus = new CdpReplicationStatus();
            }
        }


    #endregion

    } // class VmwareCdpStateInfo
    #endregion

    public static class ListVmwareCdpStateInfoExtensions
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
            this List<VmwareCdpStateInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareCdpStateInfo> list, 
            String parent = "")
        {
            var item = new VmwareCdpStateInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types