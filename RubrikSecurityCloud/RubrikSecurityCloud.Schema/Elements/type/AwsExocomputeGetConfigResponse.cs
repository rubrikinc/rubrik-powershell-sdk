// AwsExocomputeGetConfigResponse.cs
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
    #region AwsExocomputeGetConfigResponse
    public class AwsExocomputeGetConfigResponse: BaseType
    {
        #region members

        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AwsCloudAccountRegion? Region { get; set; }

        //      C# -> System.Boolean? AreSecurityGroupsRscManaged
        // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
        [JsonProperty("areSecurityGroupsRscManaged")]
        public System.Boolean? AreSecurityGroupsRscManaged { get; set; }

        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String! (scalar)
        [JsonProperty("clusterSecurityGroupId")]
        public System.String? ClusterSecurityGroupId { get; set; }

        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        [JsonProperty("configUuid")]
        public System.String? ConfigUuid { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        [JsonProperty("nodeSecurityGroupId")]
        public System.String? NodeSecurityGroupId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        [JsonProperty("healthCheckStatus")]
        public ExocomputeHealthCheckStatus? HealthCheckStatus { get; set; }

        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        [JsonProperty("subnet1")]
        public AwsExocomputeSubnetType? Subnet1 { get; set; }

        //      C# -> AwsExocomputeSubnetType? Subnet2
        // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
        [JsonProperty("subnet2")]
        public AwsExocomputeSubnetType? Subnet2 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsExocomputeGetConfigResponse";
    }

    public AwsExocomputeGetConfigResponse Set(
        AwsCloudAccountRegion? Region = null,
        System.Boolean? AreSecurityGroupsRscManaged = null,
        System.String? ClusterSecurityGroupId = null,
        System.String? ConfigUuid = null,
        System.String? Message = null,
        System.String? NodeSecurityGroupId = null,
        System.String? VpcId = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null,
        AwsExocomputeSubnetType? Subnet1 = null,
        AwsExocomputeSubnetType? Subnet2 = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( AreSecurityGroupsRscManaged != null ) {
            this.AreSecurityGroupsRscManaged = AreSecurityGroupsRscManaged;
        }
        if ( ClusterSecurityGroupId != null ) {
            this.ClusterSecurityGroupId = ClusterSecurityGroupId;
        }
        if ( ConfigUuid != null ) {
            this.ConfigUuid = ConfigUuid;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( NodeSecurityGroupId != null ) {
            this.NodeSecurityGroupId = NodeSecurityGroupId;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( HealthCheckStatus != null ) {
            this.HealthCheckStatus = HealthCheckStatus;
        }
        if ( Subnet1 != null ) {
            this.Subnet1 = Subnet1;
        }
        if ( Subnet2 != null ) {
            this.Subnet2 = Subnet2;
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
        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.Boolean? AreSecurityGroupsRscManaged
        // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
        if (this.AreSecurityGroupsRscManaged != null) {
            s += ind + "areSecurityGroupsRscManaged\n" ;
        }
        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String! (scalar)
        if (this.ClusterSecurityGroupId != null) {
            s += ind + "clusterSecurityGroupId\n" ;
        }
        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        if (this.ConfigUuid != null) {
            s += ind + "configUuid\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        if (this.NodeSecurityGroupId != null) {
            s += ind + "nodeSecurityGroupId\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        if (this.HealthCheckStatus != null) {
            var fspec = this.HealthCheckStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "healthCheckStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        if (this.Subnet1 != null) {
            var fspec = this.Subnet1.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subnet1 {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsExocomputeSubnetType? Subnet2
        // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
        if (this.Subnet2 != null) {
            var fspec = this.Subnet2.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subnet2 {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = new AwsCloudAccountRegion();
        }
        //      C# -> System.Boolean? AreSecurityGroupsRscManaged
        // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
        if (this.AreSecurityGroupsRscManaged == null && ec.Includes("areSecurityGroupsRscManaged",true))
        {
            this.AreSecurityGroupsRscManaged = true;
        }
        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String! (scalar)
        if (this.ClusterSecurityGroupId == null && ec.Includes("clusterSecurityGroupId",true))
        {
            this.ClusterSecurityGroupId = "FETCH";
        }
        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        if (this.ConfigUuid == null && ec.Includes("configUuid",true))
        {
            this.ConfigUuid = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        if (this.NodeSecurityGroupId == null && ec.Includes("nodeSecurityGroupId",true))
        {
            this.NodeSecurityGroupId = "FETCH";
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && ec.Includes("vpcId",true))
        {
            this.VpcId = "FETCH";
        }
        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        if (this.HealthCheckStatus == null && ec.Includes("healthCheckStatus",false))
        {
            this.HealthCheckStatus = new ExocomputeHealthCheckStatus();
            this.HealthCheckStatus.ApplyExploratoryFieldSpec(ec.NewChild("healthCheckStatus"));
        }
        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        if (this.Subnet1 == null && ec.Includes("subnet1",false))
        {
            this.Subnet1 = new AwsExocomputeSubnetType();
            this.Subnet1.ApplyExploratoryFieldSpec(ec.NewChild("subnet1"));
        }
        //      C# -> AwsExocomputeSubnetType? Subnet2
        // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
        if (this.Subnet2 == null && ec.Includes("subnet2",false))
        {
            this.Subnet2 = new AwsExocomputeSubnetType();
            this.Subnet2.ApplyExploratoryFieldSpec(ec.NewChild("subnet2"));
        }
    }


    #endregion

    } // class AwsExocomputeGetConfigResponse
    
    #endregion

    public static class ListAwsExocomputeGetConfigResponseExtensions
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
            this List<AwsExocomputeGetConfigResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsExocomputeGetConfigResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsExocomputeGetConfigResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsExocomputeGetConfigResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types