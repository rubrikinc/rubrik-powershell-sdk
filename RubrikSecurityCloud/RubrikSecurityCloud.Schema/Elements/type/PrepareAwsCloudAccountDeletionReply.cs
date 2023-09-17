// PrepareAwsCloudAccountDeletionReply.cs
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
    #region PrepareAwsCloudAccountDeletionReply
    public class PrepareAwsCloudAccountDeletionReply: BaseType
    {
        #region members

        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        [JsonProperty("cloudFormationUrl")]
        public System.String? CloudFormationUrl { get; set; }

        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        [JsonProperty("templateUrl")]
        public System.String? TemplateUrl { get; set; }

        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureRegionMap
        // GraphQL -> featureRegionMap: [AwsCloudAccountFeatureVersion!]! (type)
        [JsonProperty("featureRegionMap")]
        public List<AwsCloudAccountFeatureVersion>? FeatureRegionMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrepareAwsCloudAccountDeletionReply";
    }

    public PrepareAwsCloudAccountDeletionReply Set(
        System.String? CloudFormationUrl = null,
        System.String? TemplateUrl = null,
        List<AwsCloudAccountFeatureVersion>? FeatureRegionMap = null
    ) 
    {
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( TemplateUrl != null ) {
            this.TemplateUrl = TemplateUrl;
        }
        if ( FeatureRegionMap != null ) {
            this.FeatureRegionMap = FeatureRegionMap;
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
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            s += ind + "cloudFormationUrl\n" ;
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (this.TemplateUrl != null) {
            s += ind + "templateUrl\n" ;
        }
        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureRegionMap
        // GraphQL -> featureRegionMap: [AwsCloudAccountFeatureVersion!]! (type)
        if (this.FeatureRegionMap != null) {
            var fspec = this.FeatureRegionMap.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureRegionMap {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl == null && ec.Includes("cloudFormationUrl",true))
        {
            this.CloudFormationUrl = "FETCH";
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (this.TemplateUrl == null && ec.Includes("templateUrl",true))
        {
            this.TemplateUrl = "FETCH";
        }
        //      C# -> List<AwsCloudAccountFeatureVersion>? FeatureRegionMap
        // GraphQL -> featureRegionMap: [AwsCloudAccountFeatureVersion!]! (type)
        if (this.FeatureRegionMap == null && ec.Includes("featureRegionMap",false))
        {
            this.FeatureRegionMap = new List<AwsCloudAccountFeatureVersion>();
            this.FeatureRegionMap.ApplyExploratoryFieldSpec(ec.NewChild("featureRegionMap"));
        }
    }


    #endregion

    } // class PrepareAwsCloudAccountDeletionReply
    
    #endregion

    public static class ListPrepareAwsCloudAccountDeletionReplyExtensions
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
            this List<PrepareAwsCloudAccountDeletionReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrepareAwsCloudAccountDeletionReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrepareAwsCloudAccountDeletionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrepareAwsCloudAccountDeletionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types