// AwsRscManagedExocomputeConfig.cs
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
    #region AwsRscManagedExocomputeConfig
 
    public class AwsRscManagedExocomputeConfig: BaseType, AwsExocomputeGetConfigurationResponse
    {
        #region members

        //      C# -> AwsAuthServerBasedCloudAccountRegion? AuthServerRegion
        // GraphQL -> authServerRegion: AwsAuthServerBasedCloudAccountRegion (enum)
        [JsonProperty("authServerRegion")]
        public AwsAuthServerBasedCloudAccountRegion? AuthServerRegion { get; set; }

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
        // GraphQL -> configUuid: UUID! (scalar)
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

        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String (scalar)
        [JsonProperty("pcrImagePullAwsNativeId")]
        public System.String? PcrImagePullAwsNativeId { get; set; }

        //      C# -> System.String? PcrImagePullEksVersion
        // GraphQL -> pcrImagePullEksVersion: String (scalar)
        [JsonProperty("pcrImagePullEksVersion")]
        public System.String? PcrImagePullEksVersion { get; set; }

        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String (scalar)
        [JsonProperty("pcrLatestApprovedBundleVersion")]
        public System.String? PcrLatestApprovedBundleVersion { get; set; }

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String (scalar)
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

        //      C# -> ExocomputeClusterDetails? LatestExoclusterDetails
        // GraphQL -> latestExoclusterDetails: ExocomputeClusterDetails (type)
        [JsonProperty("latestExoclusterDetails")]
        public ExocomputeClusterDetails? LatestExoclusterDetails { get; set; }

        //      C# -> AwsExocomputeOptionalConfigInRegion? OptionalConfig
        // GraphQL -> optionalConfig: AwsExocomputeOptionalConfigInRegion (type)
        [JsonProperty("optionalConfig")]
        public AwsExocomputeOptionalConfigInRegion? OptionalConfig { get; set; }

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
        return "AwsRscManagedExocomputeConfig";
    }

    public AwsRscManagedExocomputeConfig Set(
        AwsAuthServerBasedCloudAccountRegion? AuthServerRegion = null,
        AwsCloudAccountRegion? Region = null,
        System.Boolean? AreSecurityGroupsRscManaged = null,
        System.String? ClusterSecurityGroupId = null,
        System.String? ConfigUuid = null,
        System.Boolean? HasPcr = null,
        System.String? Message = null,
        System.String? NodeSecurityGroupId = null,
        System.String? PcrImagePullAwsNativeId = null,
        System.String? PcrImagePullEksVersion = null,
        System.String? PcrLatestApprovedBundleVersion = null,
        System.String? PcrUrl = null,
        System.String? VpcId = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null,
        ExocomputeClusterDetails? LatestExoclusterDetails = null,
        AwsExocomputeOptionalConfigInRegion? OptionalConfig = null,
        AwsExocomputeSubnetType? Subnet1 = null,
        AwsExocomputeSubnetType? Subnet2 = null
    ) 
    {
        if ( AuthServerRegion != null ) {
            this.AuthServerRegion = AuthServerRegion;
        }
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
        if ( PcrImagePullAwsNativeId != null ) {
            this.PcrImagePullAwsNativeId = PcrImagePullAwsNativeId;
        }
        if ( PcrImagePullEksVersion != null ) {
            this.PcrImagePullEksVersion = PcrImagePullEksVersion;
        }
        if ( PcrLatestApprovedBundleVersion != null ) {
            this.PcrLatestApprovedBundleVersion = PcrLatestApprovedBundleVersion;
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
        if ( LatestExoclusterDetails != null ) {
            this.LatestExoclusterDetails = LatestExoclusterDetails;
        }
        if ( OptionalConfig != null ) {
            this.OptionalConfig = OptionalConfig;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsAuthServerBasedCloudAccountRegion? AuthServerRegion
        // GraphQL -> authServerRegion: AwsAuthServerBasedCloudAccountRegion (enum)
        if (this.AuthServerRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authServerRegion\n" ;
            } else {
                s += ind + "authServerRegion\n" ;
            }
        }
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
        // GraphQL -> configUuid: UUID! (scalar)
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
        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String (scalar)
        if (this.PcrImagePullAwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrImagePullAwsNativeId\n" ;
            } else {
                s += ind + "pcrImagePullAwsNativeId\n" ;
            }
        }
        //      C# -> System.String? PcrImagePullEksVersion
        // GraphQL -> pcrImagePullEksVersion: String (scalar)
        if (this.PcrImagePullEksVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrImagePullEksVersion\n" ;
            } else {
                s += ind + "pcrImagePullEksVersion\n" ;
            }
        }
        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String (scalar)
        if (this.PcrLatestApprovedBundleVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrLatestApprovedBundleVersion\n" ;
            } else {
                s += ind + "pcrLatestApprovedBundleVersion\n" ;
            }
        }
        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String (scalar)
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "healthCheckStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ExocomputeClusterDetails? LatestExoclusterDetails
        // GraphQL -> latestExoclusterDetails: ExocomputeClusterDetails (type)
        if (this.LatestExoclusterDetails != null) {
            var fspec = this.LatestExoclusterDetails.AsFieldSpec(conf.Child("latestExoclusterDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestExoclusterDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsExocomputeOptionalConfigInRegion? OptionalConfig
        // GraphQL -> optionalConfig: AwsExocomputeOptionalConfigInRegion (type)
        if (this.OptionalConfig != null) {
            var fspec = this.OptionalConfig.AsFieldSpec(conf.Child("optionalConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "optionalConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsExocomputeSubnetType? Subnet1
        // GraphQL -> subnet1: AwsExocomputeSubnetType! (type)
        if (this.Subnet1 != null) {
            var fspec = this.Subnet1.AsFieldSpec(conf.Child("subnet1"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subnet2" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsAuthServerBasedCloudAccountRegion? AuthServerRegion
        // GraphQL -> authServerRegion: AwsAuthServerBasedCloudAccountRegion (enum)
        if (ec.Includes("authServerRegion",true))
        {
            if(this.AuthServerRegion == null) {

                this.AuthServerRegion = new AwsAuthServerBasedCloudAccountRegion();

            } else {


            }
        }
        else if (this.AuthServerRegion != null && ec.Excludes("authServerRegion",true))
        {
            this.AuthServerRegion = null;
        }
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
        // GraphQL -> configUuid: UUID! (scalar)
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
        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String (scalar)
        if (ec.Includes("pcrImagePullAwsNativeId",true))
        {
            if(this.PcrImagePullAwsNativeId == null) {

                this.PcrImagePullAwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.PcrImagePullAwsNativeId != null && ec.Excludes("pcrImagePullAwsNativeId",true))
        {
            this.PcrImagePullAwsNativeId = null;
        }
        //      C# -> System.String? PcrImagePullEksVersion
        // GraphQL -> pcrImagePullEksVersion: String (scalar)
        if (ec.Includes("pcrImagePullEksVersion",true))
        {
            if(this.PcrImagePullEksVersion == null) {

                this.PcrImagePullEksVersion = "FETCH";

            } else {


            }
        }
        else if (this.PcrImagePullEksVersion != null && ec.Excludes("pcrImagePullEksVersion",true))
        {
            this.PcrImagePullEksVersion = null;
        }
        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String (scalar)
        if (ec.Includes("pcrLatestApprovedBundleVersion",true))
        {
            if(this.PcrLatestApprovedBundleVersion == null) {

                this.PcrLatestApprovedBundleVersion = "FETCH";

            } else {


            }
        }
        else if (this.PcrLatestApprovedBundleVersion != null && ec.Excludes("pcrLatestApprovedBundleVersion",true))
        {
            this.PcrLatestApprovedBundleVersion = null;
        }
        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String (scalar)
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
        //      C# -> ExocomputeClusterDetails? LatestExoclusterDetails
        // GraphQL -> latestExoclusterDetails: ExocomputeClusterDetails (type)
        if (ec.Includes("latestExoclusterDetails",false))
        {
            if(this.LatestExoclusterDetails == null) {

                this.LatestExoclusterDetails = new ExocomputeClusterDetails();
                this.LatestExoclusterDetails.ApplyExploratoryFieldSpec(ec.NewChild("latestExoclusterDetails"));

            } else {

                this.LatestExoclusterDetails.ApplyExploratoryFieldSpec(ec.NewChild("latestExoclusterDetails"));

            }
        }
        else if (this.LatestExoclusterDetails != null && ec.Excludes("latestExoclusterDetails",false))
        {
            this.LatestExoclusterDetails = null;
        }
        //      C# -> AwsExocomputeOptionalConfigInRegion? OptionalConfig
        // GraphQL -> optionalConfig: AwsExocomputeOptionalConfigInRegion (type)
        if (ec.Includes("optionalConfig",false))
        {
            if(this.OptionalConfig == null) {

                this.OptionalConfig = new AwsExocomputeOptionalConfigInRegion();
                this.OptionalConfig.ApplyExploratoryFieldSpec(ec.NewChild("optionalConfig"));

            } else {

                this.OptionalConfig.ApplyExploratoryFieldSpec(ec.NewChild("optionalConfig"));

            }
        }
        else if (this.OptionalConfig != null && ec.Excludes("optionalConfig",false))
        {
            this.OptionalConfig = null;
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

    } // class AwsRscManagedExocomputeConfig
    
    #endregion

    public static class ListAwsRscManagedExocomputeConfigExtensions
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
            this List<AwsRscManagedExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsRscManagedExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsRscManagedExocomputeConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsRscManagedExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsRscManagedExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types