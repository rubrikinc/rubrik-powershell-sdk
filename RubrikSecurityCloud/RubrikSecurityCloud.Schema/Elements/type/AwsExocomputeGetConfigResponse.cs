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

        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        [JsonProperty("hasPcr")]
        public System.Boolean? HasPcr { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        [JsonProperty("nodeSecurityGroupId")]
        public System.String? NodeSecurityGroupId { get; set; }

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        [JsonProperty("pcrUrl")]
        public System.String? PcrUrl { get; set; }

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
        System.Boolean? HasPcr = null,
        System.String? Message = null,
        System.String? NodeSecurityGroupId = null,
        System.String? PcrUrl = null,
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
        if ( HasPcr != null ) {
            this.HasPcr = HasPcr;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( NodeSecurityGroupId != null ) {
            this.NodeSecurityGroupId = NodeSecurityGroupId;
        }
        if ( PcrUrl != null ) {
            this.PcrUrl = PcrUrl;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.Boolean? AreSecurityGroupsRscManaged
        // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
        if (this.AreSecurityGroupsRscManaged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "areSecurityGroupsRscManaged\n" ;
            } else {
                s += ind + "areSecurityGroupsRscManaged\n" ;
            }
        }
        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String! (scalar)
        if (this.ClusterSecurityGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterSecurityGroupId\n" ;
            } else {
                s += ind + "clusterSecurityGroupId\n" ;
            }
        }
        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        if (this.ConfigUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configUuid\n" ;
            } else {
                s += ind + "configUuid\n" ;
            }
        }
        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        if (this.HasPcr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPcr\n" ;
            } else {
                s += ind + "hasPcr\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        if (this.NodeSecurityGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeSecurityGroupId\n" ;
            } else {
                s += ind + "nodeSecurityGroupId\n" ;
            }
        }
        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        if (this.PcrUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrUrl\n" ;
            } else {
                s += ind + "pcrUrl\n" ;
            }
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcId\n" ;
            } else {
                s += ind + "vpcId\n" ;
            }
        }
        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        if (this.HealthCheckStatus != null) {
            var fspec = this.HealthCheckStatus.AsFieldSpec(conf.Child("healthCheckStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "healthCheckStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        if (this.Subnet1 != null) {
            var fspec = this.Subnet1.AsFieldSpec(conf.Child("subnet1"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subnet1" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsExocomputeSubnetType? Subnet2
        // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
        if (this.Subnet2 != null) {
            var fspec = this.Subnet2.AsFieldSpec(conf.Child("subnet2"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subnet2" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AwsCloudAccountRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.Boolean? AreSecurityGroupsRscManaged
        // GraphQL -> areSecurityGroupsRscManaged: Boolean! (scalar)
        if (ec.Includes("areSecurityGroupsRscManaged",true))
        {
            if(this.AreSecurityGroupsRscManaged == null) {

                this.AreSecurityGroupsRscManaged = true;

            } else {


            }
        }
        else if (this.AreSecurityGroupsRscManaged != null && ec.Excludes("areSecurityGroupsRscManaged",true))
        {
            this.AreSecurityGroupsRscManaged = null;
        }
        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String! (scalar)
        if (ec.Includes("clusterSecurityGroupId",true))
        {
            if(this.ClusterSecurityGroupId == null) {

                this.ClusterSecurityGroupId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterSecurityGroupId != null && ec.Excludes("clusterSecurityGroupId",true))
        {
            this.ClusterSecurityGroupId = null;
        }
        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        if (ec.Includes("configUuid",true))
        {
            if(this.ConfigUuid == null) {

                this.ConfigUuid = "FETCH";

            } else {


            }
        }
        else if (this.ConfigUuid != null && ec.Excludes("configUuid",true))
        {
            this.ConfigUuid = null;
        }
        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        if (ec.Includes("hasPcr",true))
        {
            if(this.HasPcr == null) {

                this.HasPcr = true;

            } else {


            }
        }
        else if (this.HasPcr != null && ec.Excludes("hasPcr",true))
        {
            this.HasPcr = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String! (scalar)
        if (ec.Includes("nodeSecurityGroupId",true))
        {
            if(this.NodeSecurityGroupId == null) {

                this.NodeSecurityGroupId = "FETCH";

            } else {


            }
        }
        else if (this.NodeSecurityGroupId != null && ec.Excludes("nodeSecurityGroupId",true))
        {
            this.NodeSecurityGroupId = null;
        }
        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        if (ec.Includes("pcrUrl",true))
        {
            if(this.PcrUrl == null) {

                this.PcrUrl = "FETCH";

            } else {


            }
        }
        else if (this.PcrUrl != null && ec.Excludes("pcrUrl",true))
        {
            this.PcrUrl = null;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (ec.Includes("vpcId",true))
        {
            if(this.VpcId == null) {

                this.VpcId = "FETCH";

            } else {


            }
        }
        else if (this.VpcId != null && ec.Excludes("vpcId",true))
        {
            this.VpcId = null;
        }
        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        if (ec.Includes("healthCheckStatus",false))
        {
            if(this.HealthCheckStatus == null) {

                this.HealthCheckStatus = new ExocomputeHealthCheckStatus();
                this.HealthCheckStatus.ApplyExploratoryFieldSpec(ec.NewChild("healthCheckStatus"));

            } else {

                this.HealthCheckStatus.ApplyExploratoryFieldSpec(ec.NewChild("healthCheckStatus"));

            }
        }
        else if (this.HealthCheckStatus != null && ec.Excludes("healthCheckStatus",false))
        {
            this.HealthCheckStatus = null;
        }
        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        if (ec.Includes("subnet1",false))
        {
            if(this.Subnet1 == null) {

                this.Subnet1 = new AwsExocomputeSubnetType();
                this.Subnet1.ApplyExploratoryFieldSpec(ec.NewChild("subnet1"));

            } else {

                this.Subnet1.ApplyExploratoryFieldSpec(ec.NewChild("subnet1"));

            }
        }
        else if (this.Subnet1 != null && ec.Excludes("subnet1",false))
        {
            this.Subnet1 = null;
        }
        //      C# -> AwsExocomputeSubnetType? Subnet2
        // GraphQL -> subnet2: AwsExocomputeSubnetType! (type)
        if (ec.Includes("subnet2",false))
        {
            if(this.Subnet2 == null) {

                this.Subnet2 = new AwsExocomputeSubnetType();
                this.Subnet2.ApplyExploratoryFieldSpec(ec.NewChild("subnet2"));

            } else {

                this.Subnet2.ApplyExploratoryFieldSpec(ec.NewChild("subnet2"));

            }
        }
        else if (this.Subnet2 != null && ec.Excludes("subnet2",false))
        {
            this.Subnet2 = null;
        }
    }


    #endregion

    } // class AwsExocomputeGetConfigResponse
    
    #endregion

    public static class ListAwsExocomputeGetConfigResponseExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsExocomputeGetConfigResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsExocomputeGetConfigResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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