// VmwareCdpLiveInfo.cs
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
    #region VmwareCdpLiveInfo
    public class VmwareCdpLiveInfo: IFragment
    {
        #region members
        //      C# -> DateTime? CurrentTime
        // GraphQL -> currentTime: DateTime (scalar)
        [JsonProperty("currentTime")]
        public DateTime? CurrentTime { get; set; }

        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        [JsonProperty("localRecoveryPoint")]
        public DateTime? LocalRecoveryPoint { get; set; }

        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        [JsonProperty("remoteRecoveryPoint")]
        public DateTime? RemoteRecoveryPoint { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        #endregion

    #region methods

    public VmwareCdpLiveInfo Set(
        DateTime? CurrentTime = null,
        DateTime? LocalRecoveryPoint = null,
        DateTime? RemoteRecoveryPoint = null,
        System.String? VmId = null
    ) 
    {
        if ( CurrentTime != null ) {
            this.CurrentTime = CurrentTime;
        }
        if ( LocalRecoveryPoint != null ) {
            this.LocalRecoveryPoint = LocalRecoveryPoint;
        }
        if ( RemoteRecoveryPoint != null ) {
            this.RemoteRecoveryPoint = RemoteRecoveryPoint;
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
            //      C# -> DateTime? CurrentTime
            // GraphQL -> currentTime: DateTime (scalar)
            if (this.CurrentTime != null)
            {
                 s += ind + "currentTime\n";

            }
            //      C# -> DateTime? LocalRecoveryPoint
            // GraphQL -> localRecoveryPoint: DateTime (scalar)
            if (this.LocalRecoveryPoint != null)
            {
                 s += ind + "localRecoveryPoint\n";

            }
            //      C# -> DateTime? RemoteRecoveryPoint
            // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
            if (this.RemoteRecoveryPoint != null)
            {
                 s += ind + "remoteRecoveryPoint\n";

            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId != null)
            {
                 s += ind + "vmId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? CurrentTime
            // GraphQL -> currentTime: DateTime (scalar)
            if (this.CurrentTime == null && Exploration.Includes(parent + ".currentTime$"))
            {
                this.CurrentTime = new DateTime();
            }
            //      C# -> DateTime? LocalRecoveryPoint
            // GraphQL -> localRecoveryPoint: DateTime (scalar)
            if (this.LocalRecoveryPoint == null && Exploration.Includes(parent + ".localRecoveryPoint$"))
            {
                this.LocalRecoveryPoint = new DateTime();
            }
            //      C# -> DateTime? RemoteRecoveryPoint
            // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
            if (this.RemoteRecoveryPoint == null && Exploration.Includes(parent + ".remoteRecoveryPoint$"))
            {
                this.RemoteRecoveryPoint = new DateTime();
            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId == null && Exploration.Includes(parent + ".vmId$"))
            {
                this.VmId = new System.String("FETCH");
            }
        }


    #endregion

    } // class VmwareCdpLiveInfo
    #endregion

    public static class ListVmwareCdpLiveInfoExtensions
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
            this List<VmwareCdpLiveInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareCdpLiveInfo> list, 
            String parent = "")
        {
            var item = new VmwareCdpLiveInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types