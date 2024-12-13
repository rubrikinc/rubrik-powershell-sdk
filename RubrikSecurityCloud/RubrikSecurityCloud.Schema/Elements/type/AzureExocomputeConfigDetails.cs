// AzureExocomputeConfigDetails.cs
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
    #region AzureExocomputeConfigDetails
    public class AzureExocomputeConfigDetails: BaseType
    {
        #region members

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? ByokClusterId
        // GraphQL -> byokClusterId: String! (scalar)
        [JsonProperty("byokClusterId")]
        public System.String? ByokClusterId { get; set; }

        //      C# -> System.String? ByokClusterName
        // GraphQL -> byokClusterName: String! (scalar)
        [JsonProperty("byokClusterName")]
        public System.String? ByokClusterName { get; set; }

        //      C# -> System.String? ConfigUuid
        // GraphQL -> configUuid: String! (scalar)
        [JsonProperty("configUuid")]
        public System.String? ConfigUuid { get; set; }

        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        [JsonProperty("hasPcr")]
        public System.Boolean? HasPcr { get; set; }

        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? PcrImagePullAzureAppId
        // GraphQL -> pcrImagePullAzureAppId: String! (scalar)
        [JsonProperty("pcrImagePullAzureAppId")]
        public System.String? PcrImagePullAzureAppId { get; set; }

        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String! (scalar)
        [JsonProperty("pcrLatestApprovedBundleVersion")]
        public System.String? PcrLatestApprovedBundleVersion { get; set; }

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        [JsonProperty("pcrUrl")]
        public System.String? PcrUrl { get; set; }

        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        [JsonProperty("podOverlayNetworkCidr")]
        public System.String? PodOverlayNetworkCidr { get; set; }

        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        [JsonProperty("podSubnetNativeId")]
        public System.String? PodSubnetNativeId { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        [JsonProperty("healthCheckStatus")]
        public ExocomputeHealthCheckStatus? HealthCheckStatus { get; set; }

        //      C# -> ExocomputeClusterDetails? LatestExoclusterDetails
        // GraphQL -> latestExoclusterDetails: ExocomputeClusterDetails (type)
        [JsonProperty("latestExoclusterDetails")]
        public ExocomputeClusterDetails? LatestExoclusterDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureExocomputeConfigDetails";
    }

    public AzureExocomputeConfigDetails Set(
        AzureCloudAccountRegion? Region = null,
        System.String? ByokClusterId = null,
        System.String? ByokClusterName = null,
        System.String? ConfigUuid = null,
        System.Boolean? HasPcr = null,
        System.Boolean? IsRscManaged = null,
        System.String? Message = null,
        System.String? PcrImagePullAzureAppId = null,
        System.String? PcrLatestApprovedBundleVersion = null,
        System.String? PcrUrl = null,
        System.String? PodOverlayNetworkCidr = null,
        System.String? PodSubnetNativeId = null,
        System.String? SubnetNativeId = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null,
        ExocomputeClusterDetails? LatestExoclusterDetails = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ByokClusterId != null ) {
            this.ByokClusterId = ByokClusterId;
        }
        if ( ByokClusterName != null ) {
            this.ByokClusterName = ByokClusterName;
        }
        if ( ConfigUuid != null ) {
            this.ConfigUuid = ConfigUuid;
        }
        if ( HasPcr != null ) {
            this.HasPcr = HasPcr;
        }
        if ( IsRscManaged != null ) {
            this.IsRscManaged = IsRscManaged;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( PcrImagePullAzureAppId != null ) {
            this.PcrImagePullAzureAppId = PcrImagePullAzureAppId;
        }
        if ( PcrLatestApprovedBundleVersion != null ) {
            this.PcrLatestApprovedBundleVersion = PcrLatestApprovedBundleVersion;
        }
        if ( PcrUrl != null ) {
            this.PcrUrl = PcrUrl;
        }
        if ( PodOverlayNetworkCidr != null ) {
            this.PodOverlayNetworkCidr = PodOverlayNetworkCidr;
        }
        if ( PodSubnetNativeId != null ) {
            this.PodSubnetNativeId = PodSubnetNativeId;
        }
        if ( SubnetNativeId != null ) {
            this.SubnetNativeId = SubnetNativeId;
        }
        if ( HealthCheckStatus != null ) {
            this.HealthCheckStatus = HealthCheckStatus;
        }
        if ( LatestExoclusterDetails != null ) {
            this.LatestExoclusterDetails = LatestExoclusterDetails;
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
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? ByokClusterId
        // GraphQL -> byokClusterId: String! (scalar)
        if (this.ByokClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "byokClusterId\n" ;
            } else {
                s += ind + "byokClusterId\n" ;
            }
        }
        //      C# -> System.String? ByokClusterName
        // GraphQL -> byokClusterName: String! (scalar)
        if (this.ByokClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "byokClusterName\n" ;
            } else {
                s += ind + "byokClusterName\n" ;
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
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRscManaged\n" ;
            } else {
                s += ind + "isRscManaged\n" ;
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
        //      C# -> System.String? PcrImagePullAzureAppId
        // GraphQL -> pcrImagePullAzureAppId: String! (scalar)
        if (this.PcrImagePullAzureAppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrImagePullAzureAppId\n" ;
            } else {
                s += ind + "pcrImagePullAzureAppId\n" ;
            }
        }
        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String! (scalar)
        if (this.PcrLatestApprovedBundleVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrLatestApprovedBundleVersion\n" ;
            } else {
                s += ind + "pcrLatestApprovedBundleVersion\n" ;
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
        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        if (this.PodOverlayNetworkCidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "podOverlayNetworkCidr\n" ;
            } else {
                s += ind + "podOverlayNetworkCidr\n" ;
            }
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (this.PodSubnetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "podSubnetNativeId\n" ;
            } else {
                s += ind + "podSubnetNativeId\n" ;
            }
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetNativeId\n" ;
            } else {
                s += ind + "subnetNativeId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureCloudAccountRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? ByokClusterId
        // GraphQL -> byokClusterId: String! (scalar)
        if (ec.Includes("byokClusterId",true))
        {
            if(this.ByokClusterId == null) {

                this.ByokClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ByokClusterId != null && ec.Excludes("byokClusterId",true))
        {
            this.ByokClusterId = null;
        }
        //      C# -> System.String? ByokClusterName
        // GraphQL -> byokClusterName: String! (scalar)
        if (ec.Includes("byokClusterName",true))
        {
            if(this.ByokClusterName == null) {

                this.ByokClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ByokClusterName != null && ec.Excludes("byokClusterName",true))
        {
            this.ByokClusterName = null;
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
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (ec.Includes("isRscManaged",true))
        {
            if(this.IsRscManaged == null) {

                this.IsRscManaged = true;

            } else {


            }
        }
        else if (this.IsRscManaged != null && ec.Excludes("isRscManaged",true))
        {
            this.IsRscManaged = null;
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
        //      C# -> System.String? PcrImagePullAzureAppId
        // GraphQL -> pcrImagePullAzureAppId: String! (scalar)
        if (ec.Includes("pcrImagePullAzureAppId",true))
        {
            if(this.PcrImagePullAzureAppId == null) {

                this.PcrImagePullAzureAppId = "FETCH";

            } else {


            }
        }
        else if (this.PcrImagePullAzureAppId != null && ec.Excludes("pcrImagePullAzureAppId",true))
        {
            this.PcrImagePullAzureAppId = null;
        }
        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String! (scalar)
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
        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        if (ec.Includes("podOverlayNetworkCidr",true))
        {
            if(this.PodOverlayNetworkCidr == null) {

                this.PodOverlayNetworkCidr = "FETCH";

            } else {


            }
        }
        else if (this.PodOverlayNetworkCidr != null && ec.Excludes("podOverlayNetworkCidr",true))
        {
            this.PodOverlayNetworkCidr = null;
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (ec.Includes("podSubnetNativeId",true))
        {
            if(this.PodSubnetNativeId == null) {

                this.PodSubnetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.PodSubnetNativeId != null && ec.Excludes("podSubnetNativeId",true))
        {
            this.PodSubnetNativeId = null;
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (ec.Includes("subnetNativeId",true))
        {
            if(this.SubnetNativeId == null) {

                this.SubnetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetNativeId != null && ec.Excludes("subnetNativeId",true))
        {
            this.SubnetNativeId = null;
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
    }


    #endregion

    } // class AzureExocomputeConfigDetails
    
    #endregion

    public static class ListAzureExocomputeConfigDetailsExtensions
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
            this List<AzureExocomputeConfigDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureExocomputeConfigDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeConfigDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeConfigDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureExocomputeConfigDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types