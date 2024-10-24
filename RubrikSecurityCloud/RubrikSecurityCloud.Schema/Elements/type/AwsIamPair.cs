// AwsIamPair.cs
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
    #region AwsIamPair
    public class AwsIamPair: BaseType
    {
        #region members

        //      C# -> System.String? AwsIamPairId
        // GraphQL -> awsIamPairId: String! (scalar)
        [JsonProperty("awsIamPairId")]
        public System.String? AwsIamPairId { get; set; }

        //      C# -> System.String? AwsIamRoleArn
        // GraphQL -> awsIamRoleArn: String! (scalar)
        [JsonProperty("awsIamRoleArn")]
        public System.String? AwsIamRoleArn { get; set; }

        //      C# -> System.String? AwsIamRoleName
        // GraphQL -> awsIamRoleName: String! (scalar)
        [JsonProperty("awsIamRoleName")]
        public System.String? AwsIamRoleName { get; set; }

        //      C# -> List<FeatureWithPermissionsGroupsOutputType>? FeaturesWithPermissionsGroups
        // GraphQL -> featuresWithPermissionsGroups: [FeatureWithPermissionsGroupsOutputType!]! (type)
        [JsonProperty("featuresWithPermissionsGroups")]
        public List<FeatureWithPermissionsGroupsOutputType>? FeaturesWithPermissionsGroups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsIamPair";
    }

    public AwsIamPair Set(
        System.String? AwsIamPairId = null,
        System.String? AwsIamRoleArn = null,
        System.String? AwsIamRoleName = null,
        List<FeatureWithPermissionsGroupsOutputType>? FeaturesWithPermissionsGroups = null
    ) 
    {
        if ( AwsIamPairId != null ) {
            this.AwsIamPairId = AwsIamPairId;
        }
        if ( AwsIamRoleArn != null ) {
            this.AwsIamRoleArn = AwsIamRoleArn;
        }
        if ( AwsIamRoleName != null ) {
            this.AwsIamRoleName = AwsIamRoleName;
        }
        if ( FeaturesWithPermissionsGroups != null ) {
            this.FeaturesWithPermissionsGroups = FeaturesWithPermissionsGroups;
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
        //      C# -> System.String? AwsIamPairId
        // GraphQL -> awsIamPairId: String! (scalar)
        if (this.AwsIamPairId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsIamPairId\n" ;
            } else {
                s += ind + "awsIamPairId\n" ;
            }
        }
        //      C# -> System.String? AwsIamRoleArn
        // GraphQL -> awsIamRoleArn: String! (scalar)
        if (this.AwsIamRoleArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsIamRoleArn\n" ;
            } else {
                s += ind + "awsIamRoleArn\n" ;
            }
        }
        //      C# -> System.String? AwsIamRoleName
        // GraphQL -> awsIamRoleName: String! (scalar)
        if (this.AwsIamRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsIamRoleName\n" ;
            } else {
                s += ind + "awsIamRoleName\n" ;
            }
        }
        //      C# -> List<FeatureWithPermissionsGroupsOutputType>? FeaturesWithPermissionsGroups
        // GraphQL -> featuresWithPermissionsGroups: [FeatureWithPermissionsGroupsOutputType!]! (type)
        if (this.FeaturesWithPermissionsGroups != null) {
            var fspec = this.FeaturesWithPermissionsGroups.AsFieldSpec(conf.Child("featuresWithPermissionsGroups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featuresWithPermissionsGroups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsIamPairId
        // GraphQL -> awsIamPairId: String! (scalar)
        if (ec.Includes("awsIamPairId",true))
        {
            if(this.AwsIamPairId == null) {

                this.AwsIamPairId = "FETCH";

            } else {


            }
        }
        else if (this.AwsIamPairId != null && ec.Excludes("awsIamPairId",true))
        {
            this.AwsIamPairId = null;
        }
        //      C# -> System.String? AwsIamRoleArn
        // GraphQL -> awsIamRoleArn: String! (scalar)
        if (ec.Includes("awsIamRoleArn",true))
        {
            if(this.AwsIamRoleArn == null) {

                this.AwsIamRoleArn = "FETCH";

            } else {


            }
        }
        else if (this.AwsIamRoleArn != null && ec.Excludes("awsIamRoleArn",true))
        {
            this.AwsIamRoleArn = null;
        }
        //      C# -> System.String? AwsIamRoleName
        // GraphQL -> awsIamRoleName: String! (scalar)
        if (ec.Includes("awsIamRoleName",true))
        {
            if(this.AwsIamRoleName == null) {

                this.AwsIamRoleName = "FETCH";

            } else {


            }
        }
        else if (this.AwsIamRoleName != null && ec.Excludes("awsIamRoleName",true))
        {
            this.AwsIamRoleName = null;
        }
        //      C# -> List<FeatureWithPermissionsGroupsOutputType>? FeaturesWithPermissionsGroups
        // GraphQL -> featuresWithPermissionsGroups: [FeatureWithPermissionsGroupsOutputType!]! (type)
        if (ec.Includes("featuresWithPermissionsGroups",false))
        {
            if(this.FeaturesWithPermissionsGroups == null) {

                this.FeaturesWithPermissionsGroups = new List<FeatureWithPermissionsGroupsOutputType>();
                this.FeaturesWithPermissionsGroups.ApplyExploratoryFieldSpec(ec.NewChild("featuresWithPermissionsGroups"));

            } else {

                this.FeaturesWithPermissionsGroups.ApplyExploratoryFieldSpec(ec.NewChild("featuresWithPermissionsGroups"));

            }
        }
        else if (this.FeaturesWithPermissionsGroups != null && ec.Excludes("featuresWithPermissionsGroups",false))
        {
            this.FeaturesWithPermissionsGroups = null;
        }
    }


    #endregion

    } // class AwsIamPair
    
    #endregion

    public static class ListAwsIamPairExtensions
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
            this List<AwsIamPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsIamPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsIamPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsIamPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsIamPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types