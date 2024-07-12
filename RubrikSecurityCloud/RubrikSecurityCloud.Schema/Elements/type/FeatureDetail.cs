// FeatureDetail.cs
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
    #region FeatureDetail
    public class FeatureDetail: BaseType
    {
        #region members

        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
        [JsonProperty("awsRegions")]
        public List<AwsCloudAccountRegion>? AwsRegions { get; set; }

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!] (enum)
        [JsonProperty("permissionsGroups")]
        public List<PermissionsGroup>? PermissionsGroups { get; set; }

        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        [JsonProperty("status")]
        public CloudAccountStatus? Status { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? AwsIamPairId
        // GraphQL -> awsIamPairId: String (scalar)
        [JsonProperty("awsIamPairId")]
        public System.String? AwsIamPairId { get; set; }

        //      C# -> System.String? IamPairName
        // GraphQL -> iamPairName: String (scalar)
        [JsonProperty("iamPairName")]
        public System.String? IamPairName { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeatureDetail";
    }

    public FeatureDetail Set(
        List<AwsCloudAccountRegion>? AwsRegions = null,
        CloudAccountFeature? Feature = null,
        List<PermissionsGroup>? PermissionsGroups = null,
        CloudAccountStatus? Status = null,
        System.String? AccessKey = null,
        System.String? AwsIamPairId = null,
        System.String? IamPairName = null,
        System.String? RoleArn = null,
        System.String? StackArn = null,
        System.String? UserArn = null,
        AwsAuthServerDetail? AuthServerDetail = null
    ) 
    {
        if ( AwsRegions != null ) {
            this.AwsRegions = AwsRegions;
        }
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( PermissionsGroups != null ) {
            this.PermissionsGroups = PermissionsGroups;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( AccessKey != null ) {
            this.AccessKey = AccessKey;
        }
        if ( AwsIamPairId != null ) {
            this.AwsIamPairId = AwsIamPairId;
        }
        if ( IamPairName != null ) {
            this.IamPairName = IamPairName;
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
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
        if (this.AwsRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRegions\n" ;
            } else {
                s += ind + "awsRegions\n" ;
            }
        }
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!] (enum)
        if (this.PermissionsGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsGroups\n" ;
            } else {
                s += ind + "permissionsGroups\n" ;
            }
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        if (this.AccessKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessKey\n" ;
            } else {
                s += ind + "accessKey\n" ;
            }
        }
        //      C# -> System.String? AwsIamPairId
        // GraphQL -> awsIamPairId: String (scalar)
        if (this.AwsIamPairId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsIamPairId\n" ;
            } else {
                s += ind + "awsIamPairId\n" ;
            }
        }
        //      C# -> System.String? IamPairName
        // GraphQL -> iamPairName: String (scalar)
        if (this.IamPairName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iamPairName\n" ;
            } else {
                s += ind + "iamPairName\n" ;
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
        //      C# -> System.String? StackArn
        // GraphQL -> stackArn: String! (scalar)
        if (this.StackArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stackArn\n" ;
            } else {
                s += ind + "stackArn\n" ;
            }
        }
        //      C# -> System.String? UserArn
        // GraphQL -> userArn: String (scalar)
        if (this.UserArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userArn\n" ;
            } else {
                s += ind + "userArn\n" ;
            }
        }
        //      C# -> AwsAuthServerDetail? AuthServerDetail
        // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
        if (this.AuthServerDetail != null) {
            var fspec = this.AuthServerDetail.AsFieldSpec(conf.Child("authServerDetail"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authServerDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
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
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!] (enum)
        if (ec.Includes("permissionsGroups",true))
        {
            if(this.PermissionsGroups == null) {

                this.PermissionsGroups = new List<PermissionsGroup>();

            } else {


            }
        }
        else if (this.PermissionsGroups != null && ec.Excludes("permissionsGroups",true))
        {
            this.PermissionsGroups = null;
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new CloudAccountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        if (ec.Includes("accessKey",true))
        {
            if(this.AccessKey == null) {

                this.AccessKey = "FETCH";

            } else {


            }
        }
        else if (this.AccessKey != null && ec.Excludes("accessKey",true))
        {
            this.AccessKey = null;
        }
        //      C# -> System.String? AwsIamPairId
        // GraphQL -> awsIamPairId: String (scalar)
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
        //      C# -> System.String? IamPairName
        // GraphQL -> iamPairName: String (scalar)
        if (ec.Includes("iamPairName",true))
        {
            if(this.IamPairName == null) {

                this.IamPairName = "FETCH";

            } else {


            }
        }
        else if (this.IamPairName != null && ec.Excludes("iamPairName",true))
        {
            this.IamPairName = null;
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
        //      C# -> System.String? StackArn
        // GraphQL -> stackArn: String! (scalar)
        if (ec.Includes("stackArn",true))
        {
            if(this.StackArn == null) {

                this.StackArn = "FETCH";

            } else {


            }
        }
        else if (this.StackArn != null && ec.Excludes("stackArn",true))
        {
            this.StackArn = null;
        }
        //      C# -> System.String? UserArn
        // GraphQL -> userArn: String (scalar)
        if (ec.Includes("userArn",true))
        {
            if(this.UserArn == null) {

                this.UserArn = "FETCH";

            } else {


            }
        }
        else if (this.UserArn != null && ec.Excludes("userArn",true))
        {
            this.UserArn = null;
        }
        //      C# -> AwsAuthServerDetail? AuthServerDetail
        // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
        if (ec.Includes("authServerDetail",false))
        {
            if(this.AuthServerDetail == null) {

                this.AuthServerDetail = new AwsAuthServerDetail();
                this.AuthServerDetail.ApplyExploratoryFieldSpec(ec.NewChild("authServerDetail"));

            } else {

                this.AuthServerDetail.ApplyExploratoryFieldSpec(ec.NewChild("authServerDetail"));

            }
        }
        else if (this.AuthServerDetail != null && ec.Excludes("authServerDetail",false))
        {
            this.AuthServerDetail = null;
        }
    }


    #endregion

    } // class FeatureDetail
    
    #endregion

    public static class ListFeatureDetailExtensions
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
            this List<FeatureDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FeatureDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FeatureDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FeatureDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FeatureDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types