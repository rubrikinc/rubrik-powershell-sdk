// VsphereRecoveryComputeTarget.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region VsphereRecoveryComputeTarget
    public class VsphereRecoveryComputeTarget: BaseType
    {
        #region members

        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String! (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        [JsonProperty("datacenterName")]
        public System.String? DatacenterName { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String! (scalar)
        [JsonProperty("resourcePoolId")]
        public System.String? ResourcePoolId { get; set; }

        //      C# -> System.String? ResourcePoolName
        // GraphQL -> resourcePoolName: String! (scalar)
        [JsonProperty("resourcePoolName")]
        public System.String? ResourcePoolName { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vCenterId: String! (scalar)
        [JsonProperty("vCenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> System.String? VcenterName
        // GraphQL -> vCenterName: String! (scalar)
        [JsonProperty("vCenterName")]
        public System.String? VcenterName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereRecoveryComputeTarget";
    }

    public VsphereRecoveryComputeTarget Set(
        System.String? ComputeClusterId = null,
        System.String? ComputeClusterName = null,
        System.String? DatacenterId = null,
        System.String? DatacenterName = null,
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? ResourcePoolId = null,
        System.String? ResourcePoolName = null,
        System.String? VcenterId = null,
        System.String? VcenterName = null
    ) 
    {
        if ( ComputeClusterId != null ) {
            this.ComputeClusterId = ComputeClusterId;
        }
        if ( ComputeClusterName != null ) {
            this.ComputeClusterName = ComputeClusterName;
        }
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
        }
        if ( DatacenterName != null ) {
            this.DatacenterName = DatacenterName;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( ResourcePoolId != null ) {
            this.ResourcePoolId = ResourcePoolId;
        }
        if ( ResourcePoolName != null ) {
            this.ResourcePoolName = ResourcePoolName;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( VcenterName != null ) {
            this.VcenterName = VcenterName;
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
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String! (scalar)
        if (this.ComputeClusterId != null) {
            s += ind + "computeClusterId\n" ;
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName != null) {
            s += ind + "computeClusterName\n" ;
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (this.DatacenterId != null) {
            s += ind + "datacenterId\n" ;
        }
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        if (this.DatacenterName != null) {
            s += ind + "datacenterName\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String! (scalar)
        if (this.ResourcePoolId != null) {
            s += ind + "resourcePoolId\n" ;
        }
        //      C# -> System.String? ResourcePoolName
        // GraphQL -> resourcePoolName: String! (scalar)
        if (this.ResourcePoolName != null) {
            s += ind + "resourcePoolName\n" ;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vCenterId: String! (scalar)
        if (this.VcenterId != null) {
            s += ind + "vCenterId\n" ;
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vCenterName: String! (scalar)
        if (this.VcenterName != null) {
            s += ind + "vCenterName\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String! (scalar)
        if (this.ComputeClusterId == null && ec.Includes("computeClusterId",true))
        {
            this.ComputeClusterId = "FETCH";
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName == null && ec.Includes("computeClusterName",true))
        {
            this.ComputeClusterName = "FETCH";
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (this.DatacenterId == null && ec.Includes("datacenterId",true))
        {
            this.DatacenterId = "FETCH";
        }
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        if (this.DatacenterName == null && ec.Includes("datacenterName",true))
        {
            this.DatacenterName = "FETCH";
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && ec.Includes("hostId",true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && ec.Includes("hostName",true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String! (scalar)
        if (this.ResourcePoolId == null && ec.Includes("resourcePoolId",true))
        {
            this.ResourcePoolId = "FETCH";
        }
        //      C# -> System.String? ResourcePoolName
        // GraphQL -> resourcePoolName: String! (scalar)
        if (this.ResourcePoolName == null && ec.Includes("resourcePoolName",true))
        {
            this.ResourcePoolName = "FETCH";
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vCenterId: String! (scalar)
        if (this.VcenterId == null && ec.Includes("vCenterId",true))
        {
            this.VcenterId = "FETCH";
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vCenterName: String! (scalar)
        if (this.VcenterName == null && ec.Includes("vCenterName",true))
        {
            this.VcenterName = "FETCH";
        }
    }


    #endregion

    } // class VsphereRecoveryComputeTarget
    
    #endregion

    public static class ListVsphereRecoveryComputeTargetExtensions
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
            this List<VsphereRecoveryComputeTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereRecoveryComputeTarget> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereRecoveryComputeTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereRecoveryComputeTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types