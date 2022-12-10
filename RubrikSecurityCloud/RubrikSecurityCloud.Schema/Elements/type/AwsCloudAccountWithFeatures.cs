// AwsCloudAccountWithFeatures.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:25.
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
    #region AwsCloudAccountWithFeatures
    public class AwsCloudAccountWithFeatures: IFragment
    {
        #region members
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<FeatureDetail>? FeatureDetails { get; set; }

        #endregion

    #region methods

    public AwsCloudAccountWithFeatures Set(
        AwsCloudAccount? AwsCloudAccount = null,
        List<FeatureDetail>? FeatureDetails = null
    ) 
    {
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
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
            // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
            if (this.AwsCloudAccount != null)
            {
                 s += ind + "awsCloudAccount\n";

                 s += ind + "{\n" + 
                 this.AwsCloudAccount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FeatureDetail>? FeatureDetails
            // GraphQL -> featureDetails: [FeatureDetail!]! (type)
            if (this.FeatureDetails != null)
            {
                 s += ind + "featureDetails\n";

                 s += ind + "{\n" + 
                 this.FeatureDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AwsCloudAccount? AwsCloudAccount
            // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
            if (this.AwsCloudAccount == null && Exploration.Includes(parent + ".awsCloudAccount"))
            {
                this.AwsCloudAccount = new AwsCloudAccount();
                this.AwsCloudAccount.ApplyExploratoryFragment(parent + ".awsCloudAccount");
            }
            //      C# -> List<FeatureDetail>? FeatureDetails
            // GraphQL -> featureDetails: [FeatureDetail!]! (type)
            if (this.FeatureDetails == null && Exploration.Includes(parent + ".featureDetails"))
            {
                this.FeatureDetails = new List<FeatureDetail>();
                this.FeatureDetails.ApplyExploratoryFragment(parent + ".featureDetails");
            }
        }


    #endregion

    } // class AwsCloudAccountWithFeatures
    #endregion

    public static class ListAwsCloudAccountWithFeaturesExtensions
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
            this List<AwsCloudAccountWithFeatures> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCloudAccountWithFeatures> list, 
            String parent = "")
        {
            var item = new AwsCloudAccountWithFeatures();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types