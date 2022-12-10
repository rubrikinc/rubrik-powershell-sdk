// FeatureDetail.cs
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
    #region FeatureDetail
    public class FeatureDetail: IFragment
    {
        #region members
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        [JsonProperty("roleArn")]
        public System.String? RoleArn { get; set; }

        //      C# -> System.String? StackArn
        // GraphQL -> stackArn: String! (scalar)
        [JsonProperty("stackArn")]
        public System.String? StackArn { get; set; }

        //      C# -> System.String? UserArn
        // GraphQL -> userArn: String (scalar)
        [JsonProperty("userArn")]
        public System.String? UserArn { get; set; }

        //      C# -> AwsAuthServerDetail? AuthServerDetail
        // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
        [JsonProperty("authServerDetail")]
        public AwsAuthServerDetail? AuthServerDetail { get; set; }

        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
        [JsonProperty("awsRegions")]
        public List<AwsCloudAccountRegion>? AwsRegions { get; set; }

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        [JsonProperty("status")]
        public CloudAccountStatus? Status { get; set; }

        #endregion

    #region methods

    public FeatureDetail Set(
        System.String? AccessKey = null,
        System.String? RoleArn = null,
        System.String? StackArn = null,
        System.String? UserArn = null,
        AwsAuthServerDetail? AuthServerDetail = null,
        List<AwsCloudAccountRegion>? AwsRegions = null,
        CloudAccountFeature? Feature = null,
        CloudAccountStatus? Status = null
    ) 
    {
        if ( AccessKey != null ) {
            this.AccessKey = AccessKey;
        }
        if ( RoleArn != null ) {
            this.RoleArn = RoleArn;
        }
        if ( StackArn != null ) {
            this.StackArn = StackArn;
        }
        if ( UserArn != null ) {
            this.UserArn = UserArn;
        }
        if ( AuthServerDetail != null ) {
            this.AuthServerDetail = AuthServerDetail;
        }
        if ( AwsRegions != null ) {
            this.AwsRegions = AwsRegions;
        }
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? AccessKey
            // GraphQL -> accessKey: String (scalar)
            if (this.AccessKey != null)
            {
                 s += ind + "accessKey\n";

            }
            //      C# -> System.String? RoleArn
            // GraphQL -> roleArn: String! (scalar)
            if (this.RoleArn != null)
            {
                 s += ind + "roleArn\n";

            }
            //      C# -> System.String? StackArn
            // GraphQL -> stackArn: String! (scalar)
            if (this.StackArn != null)
            {
                 s += ind + "stackArn\n";

            }
            //      C# -> System.String? UserArn
            // GraphQL -> userArn: String (scalar)
            if (this.UserArn != null)
            {
                 s += ind + "userArn\n";

            }
            //      C# -> AwsAuthServerDetail? AuthServerDetail
            // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
            if (this.AuthServerDetail != null)
            {
                 s += ind + "authServerDetail\n";

                 s += ind + "{\n" + 
                 this.AuthServerDetail.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AwsCloudAccountRegion>? AwsRegions
            // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
            if (this.AwsRegions != null)
            {
                 s += ind + "awsRegions\n";

            }
            //      C# -> CloudAccountFeature? Feature
            // GraphQL -> feature: CloudAccountFeature! (enum)
            if (this.Feature != null)
            {
                 s += ind + "feature\n";

            }
            //      C# -> CloudAccountStatus? Status
            // GraphQL -> status: CloudAccountStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccessKey
            // GraphQL -> accessKey: String (scalar)
            if (this.AccessKey == null && Exploration.Includes(parent + ".accessKey$"))
            {
                this.AccessKey = new System.String("FETCH");
            }
            //      C# -> System.String? RoleArn
            // GraphQL -> roleArn: String! (scalar)
            if (this.RoleArn == null && Exploration.Includes(parent + ".roleArn$"))
            {
                this.RoleArn = new System.String("FETCH");
            }
            //      C# -> System.String? StackArn
            // GraphQL -> stackArn: String! (scalar)
            if (this.StackArn == null && Exploration.Includes(parent + ".stackArn$"))
            {
                this.StackArn = new System.String("FETCH");
            }
            //      C# -> System.String? UserArn
            // GraphQL -> userArn: String (scalar)
            if (this.UserArn == null && Exploration.Includes(parent + ".userArn$"))
            {
                this.UserArn = new System.String("FETCH");
            }
            //      C# -> AwsAuthServerDetail? AuthServerDetail
            // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
            if (this.AuthServerDetail == null && Exploration.Includes(parent + ".authServerDetail"))
            {
                this.AuthServerDetail = new AwsAuthServerDetail();
                this.AuthServerDetail.ApplyExploratoryFragment(parent + ".authServerDetail");
            }
            //      C# -> List<AwsCloudAccountRegion>? AwsRegions
            // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
            if (this.AwsRegions == null && Exploration.Includes(parent + ".awsRegions$"))
            {
                this.AwsRegions = new List<AwsCloudAccountRegion>();
            }
            //      C# -> CloudAccountFeature? Feature
            // GraphQL -> feature: CloudAccountFeature! (enum)
            if (this.Feature == null && Exploration.Includes(parent + ".feature$"))
            {
                this.Feature = new CloudAccountFeature();
            }
            //      C# -> CloudAccountStatus? Status
            // GraphQL -> status: CloudAccountStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new CloudAccountStatus();
            }
        }


    #endregion

    } // class FeatureDetail
    #endregion

    public static class ListFeatureDetailExtensions
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
            this List<FeatureDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FeatureDetail> list, 
            String parent = "")
        {
            var item = new FeatureDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types