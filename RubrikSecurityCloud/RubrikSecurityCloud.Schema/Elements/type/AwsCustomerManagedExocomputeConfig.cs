// AwsCustomerManagedExocomputeConfig.cs
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
    #region AwsCustomerManagedExocomputeConfig
 
    public class AwsCustomerManagedExocomputeConfig: BaseType, AwsExocomputeGetConfigurationResponse
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

        //      C# -> System.String? ByokClusterId
        // GraphQL -> byokClusterId: String! (scalar)
        [JsonProperty("byokClusterId")]
        public System.String? ByokClusterId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

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

        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String (scalar)
        [JsonProperty("pcrImagePullAwsNativeId")]
        public System.String? PcrImagePullAwsNativeId { get; set; }

        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String (scalar)
        [JsonProperty("pcrLatestApprovedBundleVersion")]
        public System.String? PcrLatestApprovedBundleVersion { get; set; }

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String (scalar)
        [JsonProperty("pcrUrl")]
        public System.String? PcrUrl { get; set; }

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
        return "AwsCustomerManagedExocomputeConfig";
    }

    public AwsCustomerManagedExocomputeConfig Set(
        AwsAuthServerBasedCloudAccountRegion? AuthServerRegion = null,
        AwsCloudAccountRegion? Region = null,
        System.String? ByokClusterId = null,
        System.String? ClusterName = null,
        System.String? ConfigUuid = null,
        System.Boolean? HasPcr = null,
        System.String? Message = null,
        System.String? PcrImagePullAwsNativeId = null,
        System.String? PcrLatestApprovedBundleVersion = null,
        System.String? PcrUrl = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null,
        ExocomputeClusterDetails? LatestExoclusterDetails = null
    ) 
    {
        if ( AuthServerRegion != null ) {
            this.AuthServerRegion = AuthServerRegion;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ByokClusterId != null ) {
            this.ByokClusterId = ByokClusterId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
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
        if ( PcrImagePullAwsNativeId != null ) {
            this.PcrImagePullAwsNativeId = PcrImagePullAwsNativeId;
        }
        if ( PcrLatestApprovedBundleVersion != null ) {
            this.PcrLatestApprovedBundleVersion = PcrLatestApprovedBundleVersion;
        }
        if ( PcrUrl != null ) {
            this.PcrUrl = PcrUrl;
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
        //      C# -> System.String? ByokClusterId
        // GraphQL -> byokClusterId: String! (scalar)
        if (this.ByokClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "byokClusterId\n" ;
            } else {
                s += ind + "byokClusterId\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
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
        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String (scalar)
        if (this.PcrImagePullAwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrImagePullAwsNativeId\n" ;
            } else {
                s += ind + "pcrImagePullAwsNativeId\n" ;
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
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
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

    } // class AwsCustomerManagedExocomputeConfig
    
    #endregion

    public static class ListAwsCustomerManagedExocomputeConfigExtensions
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
            this List<AwsCustomerManagedExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsCustomerManagedExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCustomerManagedExocomputeConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCustomerManagedExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCustomerManagedExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types