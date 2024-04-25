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

    public override string GetGqlTypeName() {
        return "AwsCloudAccountCreateResponse";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        if (this.AwsRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRegions\n" ;
            } else {
                s += ind + "awsRegions\n" ;
            }
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudFormationUrl\n" ;
            } else {
                s += ind + "cloudFormationUrl\n" ;
            }
        }
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (this.ExternalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalId\n" ;
            } else {
                s += ind + "externalId\n" ;
            }
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleArn\n" ;
            } else {
                s += ind + "roleArn\n" ;
            }
        }
        //      C# -> System.String? StackName
        // GraphQL -> stackName: String (scalar)
        if (this.StackName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stackName\n" ;
            } else {
                s += ind + "stackName\n" ;
            }
        }
        //      C# -> System.String? StackSetName
        // GraphQL -> stackSetName: String (scalar)
        if (this.StackSetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stackSetName\n" ;
            } else {
                s += ind + "stackSetName\n" ;
            }
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (this.TemplateUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateUrl\n" ;
            } else {
                s += ind + "templateUrl\n" ;
            }
        }
        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
        // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
        if (this.FeatureVersions != null) {
            var fspec = this.FeatureVersions.AsFieldSpec(conf.Child("featureVersions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureVersions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        if (ec.Includes("awsRegions",true))
        {
            if(this.AwsRegions == null) {

                this.AwsRegions = new List<AwsCloudAccountRegion>();

            } else {


            }
        }
        else if (this.AwsRegions != null && ec.Excludes("awsRegions",true))
        {
            this.AwsRegions = null;
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (ec.Includes("cloudFormationUrl",true))
        {
            if(this.CloudFormationUrl == null) {

                this.CloudFormationUrl = "FETCH";

            } else {


            }
        }
        else if (this.CloudFormationUrl != null && ec.Excludes("cloudFormationUrl",true))
        {
            this.CloudFormationUrl = null;
        }
        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        if (ec.Includes("externalId",true))
        {
            if(this.ExternalId == null) {

                this.ExternalId = "FETCH";

            } else {


            }
        }
        else if (this.ExternalId != null && ec.Excludes("externalId",true))
        {
            this.ExternalId = null;
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (ec.Includes("roleArn",true))
        {
            if(this.RoleArn == null) {

                this.RoleArn = "FETCH";

            } else {


            }
        }
        else if (this.RoleArn != null && ec.Excludes("roleArn",true))
        {
            this.RoleArn = null;
        }
        //      C# -> System.String? StackName
        // GraphQL -> stackName: String (scalar)
        if (ec.Includes("stackName",true))
        {
            if(this.StackName == null) {

                this.StackName = "FETCH";

            } else {


            }
        }
        else if (this.StackName != null && ec.Excludes("stackName",true))
        {
            this.StackName = null;
        }
        //      C# -> System.String? StackSetName
        // GraphQL -> stackSetName: String (scalar)
        if (ec.Includes("stackSetName",true))
        {
            if(this.StackSetName == null) {

                this.StackSetName = "FETCH";

            } else {


            }
        }
        else if (this.StackSetName != null && ec.Excludes("stackSetName",true))
        {
            this.StackSetName = null;
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (ec.Includes("templateUrl",true))
        {
            if(this.TemplateUrl == null) {

                this.TemplateUrl = "FETCH";

            } else {


            }
        }
        else if (this.TemplateUrl != null && ec.Excludes("templateUrl",true))
        {
            this.TemplateUrl = null;
        }
        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureVersions
        // GraphQL -> featureVersions: [AwsCloudAccountFeatureVersion!]! (type)
        if (ec.Includes("featureVersions",false))
        {
            if(this.FeatureVersions == null) {

                this.FeatureVersions = new List<AwsCloudAccountFeatureVersion>();
                this.FeatureVersions.ApplyExploratoryFieldSpec(ec.NewChild("featureVersions"));

            } else {

                this.FeatureVersions.ApplyExploratoryFieldSpec(ec.NewChild("featureVersions"));

            }
        }
        else if (this.FeatureVersions != null && ec.Excludes("featureVersions",false))
        {
            this.FeatureVersions = null;
        }
    }


    #endregion

    } // class AwsCloudAccountCreateResponse
    
    #endregion

    public static class ListAwsCloudAccountCreateResponseExtensions
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
            this List<AwsCloudAccountCreateResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountCreateResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountCreateResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountCreateResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountCreateResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types