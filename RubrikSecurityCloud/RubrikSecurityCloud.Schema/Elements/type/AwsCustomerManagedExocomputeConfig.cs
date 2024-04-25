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

        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AwsCloudAccountRegion? Region { get; set; }

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

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String (scalar)
        [JsonProperty("pcrUrl")]
        public System.String? PcrUrl { get; set; }

        //      C# -> ExocomputeHealthCheckStatus? HealthCheckStatus
        // GraphQL -> healthCheckStatus: ExocomputeHealthCheckStatus! (type)
        [JsonProperty("healthCheckStatus")]
        public ExocomputeHealthCheckStatus? HealthCheckStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCustomerManagedExocomputeConfig";
    }

    public AwsCustomerManagedExocomputeConfig Set(
        AwsCloudAccountRegion? Region = null,
        System.String? ClusterName = null,
        System.String? ConfigUuid = null,
        System.Boolean? HasPcr = null,
        System.String? Message = null,
        System.String? PcrUrl = null,
        ExocomputeHealthCheckStatus? HealthCheckStatus = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
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
        if ( PcrUrl != null ) {
            this.PcrUrl = PcrUrl;
        }
        if ( HealthCheckStatus != null ) {
            this.HealthCheckStatus = HealthCheckStatus;
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
        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "healthCheckStatus" + " " + "{\n" + fspec + ind + "}\n" ;
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
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCustomerManagedExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCustomerManagedExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types