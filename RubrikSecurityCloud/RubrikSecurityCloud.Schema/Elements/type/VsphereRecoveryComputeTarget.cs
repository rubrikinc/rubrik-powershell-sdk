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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String! (scalar)
        if (this.ComputeClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterId\n" ;
            } else {
                s += ind + "computeClusterId\n" ;
            }
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterName\n" ;
            } else {
                s += ind + "computeClusterName\n" ;
            }
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (this.DatacenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datacenterId\n" ;
            } else {
                s += ind + "datacenterId\n" ;
            }
        }
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        if (this.DatacenterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datacenterName\n" ;
            } else {
                s += ind + "datacenterName\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String! (scalar)
        if (this.ResourcePoolId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourcePoolId\n" ;
            } else {
                s += ind + "resourcePoolId\n" ;
            }
        }
        //      C# -> System.String? ResourcePoolName
        // GraphQL -> resourcePoolName: String! (scalar)
        if (this.ResourcePoolName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourcePoolName\n" ;
            } else {
                s += ind + "resourcePoolName\n" ;
            }
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vCenterId: String! (scalar)
        if (this.VcenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vCenterId\n" ;
            } else {
                s += ind + "vCenterId\n" ;
            }
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vCenterName: String! (scalar)
        if (this.VcenterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vCenterName\n" ;
            } else {
                s += ind + "vCenterName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String! (scalar)
        if (ec.Includes("computeClusterId",true))
        {
            if(this.ComputeClusterId == null) {

                this.ComputeClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterId != null && ec.Excludes("computeClusterId",true))
        {
            this.ComputeClusterId = null;
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (ec.Includes("computeClusterName",true))
        {
            if(this.ComputeClusterName == null) {

                this.ComputeClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterName != null && ec.Excludes("computeClusterName",true))
        {
            this.ComputeClusterName = null;
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (ec.Includes("datacenterId",true))
        {
            if(this.DatacenterId == null) {

                this.DatacenterId = "FETCH";

            } else {


            }
        }
        else if (this.DatacenterId != null && ec.Excludes("datacenterId",true))
        {
            this.DatacenterId = null;
        }
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        if (ec.Includes("datacenterName",true))
        {
            if(this.DatacenterName == null) {

                this.DatacenterName = "FETCH";

            } else {


            }
        }
        else if (this.DatacenterName != null && ec.Excludes("datacenterName",true))
        {
            this.DatacenterName = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String! (scalar)
        if (ec.Includes("resourcePoolId",true))
        {
            if(this.ResourcePoolId == null) {

                this.ResourcePoolId = "FETCH";

            } else {


            }
        }
        else if (this.ResourcePoolId != null && ec.Excludes("resourcePoolId",true))
        {
            this.ResourcePoolId = null;
        }
        //      C# -> System.String? ResourcePoolName
        // GraphQL -> resourcePoolName: String! (scalar)
        if (ec.Includes("resourcePoolName",true))
        {
            if(this.ResourcePoolName == null) {

                this.ResourcePoolName = "FETCH";

            } else {


            }
        }
        else if (this.ResourcePoolName != null && ec.Excludes("resourcePoolName",true))
        {
            this.ResourcePoolName = null;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vCenterId: String! (scalar)
        if (ec.Includes("vCenterId",true))
        {
            if(this.VcenterId == null) {

                this.VcenterId = "FETCH";

            } else {


            }
        }
        else if (this.VcenterId != null && ec.Excludes("vCenterId",true))
        {
            this.VcenterId = null;
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vCenterName: String! (scalar)
        if (ec.Includes("vCenterName",true))
        {
            if(this.VcenterName == null) {

                this.VcenterName = "FETCH";

            } else {


            }
        }
        else if (this.VcenterName != null && ec.Excludes("vCenterName",true))
        {
            this.VcenterName = null;
        }
    }


    #endregion

    } // class VsphereRecoveryComputeTarget
    
    #endregion

    public static class ListVsphereRecoveryComputeTargetExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VsphereRecoveryComputeTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereRecoveryComputeTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<VsphereRecoveryComputeTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types