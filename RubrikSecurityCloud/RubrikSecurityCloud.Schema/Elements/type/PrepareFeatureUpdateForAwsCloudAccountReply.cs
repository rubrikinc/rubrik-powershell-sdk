// PrepareFeatureUpdateForAwsCloudAccountReply.cs
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
    #region PrepareFeatureUpdateForAwsCloudAccountReply
    public class PrepareFeatureUpdateForAwsCloudAccountReply: BaseType
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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrepareFeatureUpdateForAwsCloudAccountReply";
    }

    public PrepareFeatureUpdateForAwsCloudAccountReply Set(
        System.String? CloudFormationUrl = null,
        System.String? TemplateUrl = null
    ) 
    {
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( TemplateUrl != null ) {
            this.TemplateUrl = TemplateUrl;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudFormationUrl\n" ;
            } else {
                s += ind + "cloudFormationUrl\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
    }


    #endregion

    } // class PrepareFeatureUpdateForAwsCloudAccountReply
    
    #endregion

    public static class ListPrepareFeatureUpdateForAwsCloudAccountReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PrepareFeatureUpdateForAwsCloudAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrepareFeatureUpdateForAwsCloudAccountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrepareFeatureUpdateForAwsCloudAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrepareFeatureUpdateForAwsCloudAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrepareFeatureUpdateForAwsCloudAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types