// AwsCloudAccountCreateResponse.cs
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
    #region AwsCloudAccountCreateResponse
    public class AwsCloudAccountCreateResponse: BaseType
    {
        #region members

        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        [JsonProperty("awsRegions")]
        public List<AwsCloudAccountRegion>? AwsRegions { get; set; }

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


        #endregion

    #region methods

    public AwsCloudAccountCreateResponse Set(
        List<AwsCloudAccountRegion>? AwsRegions = null,
        System.String? CloudFormationUrl = null,
        System.String? ExternalId = null,
        System.String? RoleArn = null,
        System.String? StackName = null,
        System.String? StackSetName = null,
        System.String? TemplateUrl = null,
        List<AwsCloudAccountFeatureVersion>? FeatureVersions = null
    ) 
    {
        if ( AwsRegions != null ) {
            this.AwsRegions = AwsRegions;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        if (this.AwsRegions != null) {
            s += ind + "awsRegions\n" ;
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            s += ind + "cloudFormationUrl\n" ;
        }
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (this.ExternalId != null) {
            s += ind + "externalId\n" ;
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn != null) {
            s += ind + "roleArn\n" ;
        }
        //      C# -> System.String? StackName
        // GraphQL -> stackName: String (scalar)
        if (this.StackName != null) {
            s += ind + "stackName\n" ;
        }
        //      C# -> System.String? StackSetName
        // GraphQL -> stackSetName: String (scalar)
        if (this.StackSetName != null) {
            s += ind + "stackSetName\n" ;
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (this.TemplateUrl != null) {
            s += ind + "templateUrl\n" ;
        }
        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
        // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
        if (this.FeatureVersions != null) {
            var fspec = this.FeatureVersions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureVersions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        if (this.AwsRegions == null && Exploration.Includes(parent + ".awsRegions", true))
        {
            this.AwsRegions = new List<AwsCloudAccountRegion>();
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl == null && Exploration.Includes(parent + ".cloudFormationUrl", true))
        {
            this.CloudFormationUrl = "FETCH";
        }
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (this.ExternalId == null && Exploration.Includes(parent + ".externalId", true))
        {
            this.ExternalId = "FETCH";
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn == null && Exploration.Includes(parent + ".roleArn", true))
        {
            this.RoleArn = "FETCH";
        }
        //      C# -> System.String? StackName
        // GraphQL -> stackName: String (scalar)
        if (this.StackName == null && Exploration.Includes(parent + ".stackName", true))
        {
            this.StackName = "FETCH";
        }
        //      C# -> System.String? StackSetName
        // GraphQL -> stackSetName: String (scalar)
        if (this.StackSetName == null && Exploration.Includes(parent + ".stackSetName", true))
        {
            this.StackSetName = "FETCH";
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (this.TemplateUrl == null && Exploration.Includes(parent + ".templateUrl", true))
        {
            this.TemplateUrl = "FETCH";
        }
        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
        // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
        if (this.FeatureVersions == null && Exploration.Includes(parent + ".featureVersions"))
        {
            this.FeatureVersions = new List<AwsCloudAccountFeatureVersion>();
            this.FeatureVersions.ApplyExploratoryFieldSpec(parent + ".featureVersions");
        }
    }


    #endregion

    } // class AwsCloudAccountCreateResponse
    
    #endregion

    public static class ListAwsCloudAccountCreateResponseExtensions
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
            this List<AwsCloudAccountCreateResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountCreateResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountCreateResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types