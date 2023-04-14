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

namespace Rubrik.SecurityCloud.Types
{
    #region AwsFeatureConfig
    public class AwsFeatureConfig: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> AwsCloudAccount? AwsCloudAccount
            // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
            if (this.AwsCloudAccount != null)
            {
                 s += ind + "awsCloudAccount\n";

                 s += ind + "{\n" + 
                 this.AwsCloudAccount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
            // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
            if (this.ExocomputeConfigs != null)
            {
                 s += ind + "exocomputeConfigs\n";

                 s += ind + "{\n" + 
                 this.ExocomputeConfigs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FeatureDetail? FeatureDetail
            // GraphQL -> featureDetail: FeatureDetail! (type)
            if (this.FeatureDetail != null)
            {
                 s += ind + "featureDetail\n";

                 s += ind + "{\n" + 
                 this.FeatureDetail.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AwsCloudAccount? AwsCloudAccount
            // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
            if (this.AwsCloudAccount == null && Exploration.Includes(parent + ".awsCloudAccount"))
            {
                this.AwsCloudAccount = new AwsCloudAccount();
                this.AwsCloudAccount.ApplyExploratoryFragment(parent + ".awsCloudAccount");
            }
            //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
            // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
            if (this.ExocomputeConfigs == null && Exploration.Includes(parent + ".exocomputeConfigs"))
            {
                this.ExocomputeConfigs = new List<AwsExocomputeGetConfigResponse>();
                this.ExocomputeConfigs.ApplyExploratoryFragment(parent + ".exocomputeConfigs");
            }
            //      C# -> FeatureDetail? FeatureDetail
            // GraphQL -> featureDetail: FeatureDetail! (type)
            if (this.FeatureDetail == null && Exploration.Includes(parent + ".featureDetail"))
            {
                this.FeatureDetail = new FeatureDetail();
                this.FeatureDetail.ApplyExploratoryFragment(parent + ".featureDetail");
            }
        }


    #endregion

    } // class AwsFeatureConfig
    #endregion

    public static class ListAwsFeatureConfigExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AwsFeatureConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsFeatureConfig> list, 
            String parent = "")
        {
            var item = new AwsFeatureConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types