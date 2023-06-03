// VmwareCdpStateInfo.cs
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
    #region VmwareCdpStateInfo
    public class VmwareCdpStateInfo: BaseType
    {
        #region members

        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        [JsonProperty("localStatus")]
        public CdpLocalStatus? LocalStatus { get; set; }

        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        [JsonProperty("replicationStatus")]
        public CdpReplicationStatus? ReplicationStatus { get; set; }

        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        [JsonProperty("healthPercentage")]
        public System.Single? HealthPercentage { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


        #endregion

    #region methods

    public VmwareCdpStateInfo Set(
        CdpLocalStatus? LocalStatus = null,
        CdpReplicationStatus? ReplicationStatus = null,
        System.Single? HealthPercentage = null,
        System.String? VmId = null
    ) 
    {
        if ( LocalStatus != null ) {
            this.LocalStatus = LocalStatus;
        }
        if ( ReplicationStatus != null ) {
            this.ReplicationStatus = ReplicationStatus;
        }
        if ( HealthPercentage != null ) {
            this.HealthPercentage = HealthPercentage;
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
        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        if (this.LocalStatus != null) {
            s += ind + "localStatus\n" ;
        }
        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        if (this.ReplicationStatus != null) {
            s += ind + "replicationStatus\n" ;
        }
        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        if (this.HealthPercentage != null) {
            s += ind + "healthPercentage\n" ;
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
        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        if (this.LocalStatus == null && Exploration.Includes(parent + ".localStatus", true))
        {
            this.LocalStatus = new CdpLocalStatus();
        }
        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        if (this.ReplicationStatus == null && Exploration.Includes(parent + ".replicationStatus", true))
        {
            this.ReplicationStatus = new CdpReplicationStatus();
        }
        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        if (this.HealthPercentage == null && Exploration.Includes(parent + ".healthPercentage", true))
        {
            this.HealthPercentage = new System.Single();
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && Exploration.Includes(parent + ".vmId", true))
        {
            this.VmId = new System.String("FETCH");
        }
    }


    #endregion

    } // class VmwareCdpStateInfo
    
    #endregion

    public static class ListVmwareCdpStateInfoExtensions
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
            this List<VmwareCdpStateInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareCdpStateInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareCdpStateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types