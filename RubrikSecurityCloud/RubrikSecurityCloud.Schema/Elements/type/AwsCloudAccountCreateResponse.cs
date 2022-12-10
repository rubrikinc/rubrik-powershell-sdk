// AwsCloudAccountCreateResponse.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:20.
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
    #region AwsCloudAccountCreateResponse
    public class AwsCloudAccountCreateResponse: IFragment
    {
        #region members
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        [JsonProperty("cloudFormationUrl")]
        public System.String? CloudFormationUrl { get; set; }

        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        [JsonProperty("externalId")]
        public System.String? ExternalId { get; set; }

        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        [JsonProperty("roleArn")]
        public System.String? RoleArn { get; set; }

        //      C# -> System.String? StackName
        // GraphQL -> stackName: String (scalar)
        [JsonProperty("stackName")]
        public System.String? StackName { get; set; }

        //      C# -> System.String? StackSetName
        // GraphQL -> stackSetName: String (scalar)
        [JsonProperty("stackSetName")]
        public System.String? StackSetName { get; set; }

        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        [JsonProperty("templateUrl")]
        public System.String? TemplateUrl { get; set; }

        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
        // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
        [JsonProperty("featureVersions")]
        public List<AwsCloudAccountFeatureVersion>? FeatureVersions { get; set; }

        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        [JsonProperty("awsRegions")]
        public List<AwsCloudAccountRegion>? AwsRegions { get; set; }

        #endregion

    #region methods

    public AwsCloudAccountCreateResponse Set(
        System.String? CloudFormationUrl = null,
        System.String? ExternalId = null,
        System.String? RoleArn = null,
        System.String? StackName = null,
        System.String? StackSetName = null,
        System.String? TemplateUrl = null,
        List<AwsCloudAccountFeatureVersion>? FeatureVersions = null,
        List<AwsCloudAccountRegion>? AwsRegions = null
    ) 
    {
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( ExternalId != null ) {
            this.ExternalId = ExternalId;
        }
        if ( RoleArn != null ) {
            this.RoleArn = RoleArn;
        }
        if ( StackName != null ) {
            this.StackName = StackName;
        }
        if ( StackSetName != null ) {
            this.StackSetName = StackSetName;
        }
        if ( TemplateUrl != null ) {
            this.TemplateUrl = TemplateUrl;
        }
        if ( FeatureVersions != null ) {
            this.FeatureVersions = FeatureVersions;
        }
        if ( AwsRegions != null ) {
            this.AwsRegions = AwsRegions;
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
            //      C# -> System.String? CloudFormationUrl
            // GraphQL -> cloudFormationUrl: String! (scalar)
            if (this.CloudFormationUrl != null)
            {
                 s += ind + "cloudFormationUrl\n";

            }
            //      C# -> System.String? ExternalId
            // GraphQL -> externalId: String! (scalar)
            if (this.ExternalId != null)
            {
                 s += ind + "externalId\n";

            }
            //      C# -> System.String? RoleArn
            // GraphQL -> roleArn: String! (scalar)
            if (this.RoleArn != null)
            {
                 s += ind + "roleArn\n";

            }
            //      C# -> System.String? StackName
            // GraphQL -> stackName: String (scalar)
            if (this.StackName != null)
            {
                 s += ind + "stackName\n";

            }
            //      C# -> System.String? StackSetName
            // GraphQL -> stackSetName: String (scalar)
            if (this.StackSetName != null)
            {
                 s += ind + "stackSetName\n";

            }
            //      C# -> System.String? TemplateUrl
            // GraphQL -> templateUrl: String! (scalar)
            if (this.TemplateUrl != null)
            {
                 s += ind + "templateUrl\n";

            }
            //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
            // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
            if (this.FeatureVersions != null)
            {
                 s += ind + "featureVersions\n";

                 s += ind + "{\n" + 
                 this.FeatureVersions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AwsCloudAccountRegion>? AwsRegions
            // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
            if (this.AwsRegions != null)
            {
                 s += ind + "awsRegions\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CloudFormationUrl
            // GraphQL -> cloudFormationUrl: String! (scalar)
            if (this.CloudFormationUrl == null && Exploration.Includes(parent + ".cloudFormationUrl$"))
            {
                this.CloudFormationUrl = new System.String("FETCH");
            }
            //      C# -> System.String? ExternalId
            // GraphQL -> externalId: String! (scalar)
            if (this.ExternalId == null && Exploration.Includes(parent + ".externalId$"))
            {
                this.ExternalId = new System.String("FETCH");
            }
            //      C# -> System.String? RoleArn
            // GraphQL -> roleArn: String! (scalar)
            if (this.RoleArn == null && Exploration.Includes(parent + ".roleArn$"))
            {
                this.RoleArn = new System.String("FETCH");
            }
            //      C# -> System.String? StackName
            // GraphQL -> stackName: String (scalar)
            if (this.StackName == null && Exploration.Includes(parent + ".stackName$"))
            {
                this.StackName = new System.String("FETCH");
            }
            //      C# -> System.String? StackSetName
            // GraphQL -> stackSetName: String (scalar)
            if (this.StackSetName == null && Exploration.Includes(parent + ".stackSetName$"))
            {
                this.StackSetName = new System.String("FETCH");
            }
            //      C# -> System.String? TemplateUrl
            // GraphQL -> templateUrl: String! (scalar)
            if (this.TemplateUrl == null && Exploration.Includes(parent + ".templateUrl$"))
            {
                this.TemplateUrl = new System.String("FETCH");
            }
            //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
            // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
            if (this.FeatureVersions == null && Exploration.Includes(parent + ".featureVersions"))
            {
                this.FeatureVersions = new List<AwsCloudAccountFeatureVersion>();
                this.FeatureVersions.ApplyExploratoryFragment(parent + ".featureVersions");
            }
            //      C# -> List<AwsCloudAccountRegion>? AwsRegions
            // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
            if (this.AwsRegions == null && Exploration.Includes(parent + ".awsRegions$"))
            {
                this.AwsRegions = new List<AwsCloudAccountRegion>();
            }
        }


    #endregion

    } // class AwsCloudAccountCreateResponse
    #endregion

    public static class ListAwsCloudAccountCreateResponseExtensions
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
            this List<AwsCloudAccountCreateResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCloudAccountCreateResponse> list, 
            String parent = "")
        {
            var item = new AwsCloudAccountCreateResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types