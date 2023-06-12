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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region VmwareCdpLiveInfo
    public class VmwareCdpLiveInfo: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DateTime? CurrentTime
        // GraphQL -> currentTime: DateTime (scalar)
        if (this.CurrentTime != null) {
            s += ind + "currentTime\n" ;
        }
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (this.LocalRecoveryPoint != null) {
            s += ind + "localRecoveryPoint\n" ;
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (this.RemoteRecoveryPoint != null) {
            s += ind + "remoteRecoveryPoint\n" ;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? CurrentTime
        // GraphQL -> currentTime: DateTime (scalar)
        if (this.CurrentTime == null && Exploration.Includes(parent + ".currentTime", true))
        {
            this.CurrentTime = new DateTime();
        }
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (this.LocalRecoveryPoint == null && Exploration.Includes(parent + ".localRecoveryPoint", true))
        {
            this.LocalRecoveryPoint = new DateTime();
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (this.RemoteRecoveryPoint == null && Exploration.Includes(parent + ".remoteRecoveryPoint", true))
        {
            this.RemoteRecoveryPoint = new DateTime();
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && Exploration.Includes(parent + ".vmId", true))
        {
            this.VmId = "FETCH";
        }
    }


    #endregion

    } // class VmwareCdpLiveInfo
    
    #endregion

    public static class ListVmwareCdpLiveInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<VmwareCdpLiveInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareCdpLiveInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareCdpLiveInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types