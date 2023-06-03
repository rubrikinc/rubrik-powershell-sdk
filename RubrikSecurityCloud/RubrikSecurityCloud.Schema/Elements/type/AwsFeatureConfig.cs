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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AwsFeatureConfig
    public class AwsFeatureConfig: BaseType
    {
        #region members

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


        #endregion

    #region methods

    public AwsFeatureConfig Set(
        AwsCloudAccount? AwsCloudAccount = null,
        List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs = null,
        FeatureDetail? FeatureDetail = null
    ) 
    {
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
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
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount != null) {
            s += ind + "awsCloudAccount {\n" + this.AwsCloudAccount.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.ExocomputeConfigs != null) {
            s += ind + "exocomputeConfigs {\n" + this.ExocomputeConfigs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail != null) {
            s += ind + "featureDetail {\n" + this.FeatureDetail.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount == null && Exploration.Includes(parent + ".awsCloudAccount"))
        {
            this.AwsCloudAccount = new AwsCloudAccount();
            this.AwsCloudAccount.ApplyExploratoryFieldSpec(parent + ".awsCloudAccount");
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.ExocomputeConfigs == null && Exploration.Includes(parent + ".exocomputeConfigs"))
        {
            this.ExocomputeConfigs = new List<AwsExocomputeGetConfigResponse>();
            this.ExocomputeConfigs.ApplyExploratoryFieldSpec(parent + ".exocomputeConfigs");
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail == null && Exploration.Includes(parent + ".featureDetail"))
        {
            this.FeatureDetail = new FeatureDetail();
            this.FeatureDetail.ApplyExploratoryFieldSpec(parent + ".featureDetail");
        }
    }


    #endregion

    } // class AwsFeatureConfig
    
    #endregion

    public static class ListAwsFeatureConfigExtensions
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
            this List<AwsFeatureConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsFeatureConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsFeatureConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types