// AwsFeatureConfig.cs
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
    #region AwsFeatureConfig
    public class AwsFeatureConfig: BaseType
    {
        #region members

        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigurations
        // GraphQL -> exocomputeConfigurations: [AwsExocomputeGetConfigurationResponse!]! (interface)
        [JsonProperty("exocomputeConfigurations")]
        public List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigurations { get; set; }

        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        [JsonProperty("exocomputeConfigs")]
        public List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs { get; set; }

        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        [JsonProperty("featureDetail")]
        public FeatureDetail? FeatureDetail { get; set; }

        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        [JsonProperty("mappedExocomputeAccount")]
        public CloudAccountDetails? MappedExocomputeAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsFeatureConfig";
    }

    public AwsFeatureConfig Set(
        List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigurations = null,
        AwsCloudAccount? AwsCloudAccount = null,
        List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs = null,
        FeatureDetail? FeatureDetail = null,
        CloudAccountDetails? MappedExocomputeAccount = null
    ) 
    {
        if ( ExocomputeConfigurations != null ) {
            this.ExocomputeConfigurations = ExocomputeConfigurations;
        }
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( MappedExocomputeAccount != null ) {
            this.MappedExocomputeAccount = MappedExocomputeAccount;
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
        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigurations
        // GraphQL -> exocomputeConfigurations: [AwsExocomputeGetConfigurationResponse!]! (interface)
        if (this.ExocomputeConfigurations != null) {
                var fspec = this.ExocomputeConfigurations.AsFieldSpec(conf.Child("exocomputeConfigurations"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeConfigurations" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount != null) {
            var fspec = this.AwsCloudAccount.AsFieldSpec(conf.Child("awsCloudAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsCloudAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.ExocomputeConfigs != null) {
            var fspec = this.ExocomputeConfigs.AsFieldSpec(conf.Child("exocomputeConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(conf.Child("featureDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (this.MappedExocomputeAccount != null) {
            var fspec = this.MappedExocomputeAccount.AsFieldSpec(conf.Child("mappedExocomputeAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedExocomputeAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigurations
        // GraphQL -> exocomputeConfigurations: [AwsExocomputeGetConfigurationResponse!]! (interface)
        if (ec.Includes("exocomputeConfigurations",false))
        {
            if(this.ExocomputeConfigurations == null) {

                this.ExocomputeConfigurations = new List<AwsExocomputeGetConfigurationResponse>();
                this.ExocomputeConfigurations.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigurations"));

            } else {

                this.ExocomputeConfigurations.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigurations"));

            }
        }
        else if (this.ExocomputeConfigurations != null && ec.Excludes("exocomputeConfigurations",false))
        {
            this.ExocomputeConfigurations = null;
        }
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (ec.Includes("awsCloudAccount",false))
        {
            if(this.AwsCloudAccount == null) {

                this.AwsCloudAccount = new AwsCloudAccount();
                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            } else {

                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            }
        }
        else if (this.AwsCloudAccount != null && ec.Excludes("awsCloudAccount",false))
        {
            this.AwsCloudAccount = null;
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        if (ec.Includes("exocomputeConfigs",false))
        {
            if(this.ExocomputeConfigs == null) {

                this.ExocomputeConfigs = new List<AwsExocomputeGetConfigResponse>();
                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            } else {

                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            }
        }
        else if (this.ExocomputeConfigs != null && ec.Excludes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = null;
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (ec.Includes("featureDetail",false))
        {
            if(this.FeatureDetail == null) {

                this.FeatureDetail = new FeatureDetail();
                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            } else {

                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            }
        }
        else if (this.FeatureDetail != null && ec.Excludes("featureDetail",false))
        {
            this.FeatureDetail = null;
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (ec.Includes("mappedExocomputeAccount",false))
        {
            if(this.MappedExocomputeAccount == null) {

                this.MappedExocomputeAccount = new CloudAccountDetails();
                this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));

            } else {

                this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));

            }
        }
        else if (this.MappedExocomputeAccount != null && ec.Excludes("mappedExocomputeAccount",false))
        {
            this.MappedExocomputeAccount = null;
        }
    }


    #endregion

    } // class AwsFeatureConfig
    
    #endregion

    public static class ListAwsFeatureConfigExtensions
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
            this List<AwsFeatureConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsFeatureConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsFeatureConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsFeatureConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsFeatureConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types