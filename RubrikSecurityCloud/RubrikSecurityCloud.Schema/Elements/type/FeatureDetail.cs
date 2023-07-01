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

        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        [JsonProperty("status")]
        public CloudAccountStatus? Status { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeatureDetail";
    }

    public FeatureDetail Set(
        List<AwsCloudAccountRegion>? AwsRegions = null,
        CloudAccountFeature? Feature = null,
        CloudAccountStatus? Status = null,
        System.String? AccessKey = null,
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
        if ( Status != null ) {
            this.Status = Status;
        }
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
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
        if (this.AwsRegions != null) {
            s += ind + "awsRegions\n" ;
        }
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            s += ind + "feature\n" ;
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        if (this.AccessKey != null) {
            s += ind + "accessKey\n" ;
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn != null) {
            s += ind + "roleArn\n" ;
        }
        //      C# -> System.String? StackArn
        // GraphQL -> stackArn: String! (scalar)
        if (this.StackArn != null) {
            s += ind + "stackArn\n" ;
        }
        //      C# -> System.String? UserArn
        // GraphQL -> userArn: String (scalar)
        if (this.UserArn != null) {
            s += ind + "userArn\n" ;
        }
        //      C# -> AwsAuthServerDetail? AuthServerDetail
        // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
        if (this.AuthServerDetail != null) {
            var fspec = this.AuthServerDetail.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "authServerDetail {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!]! (enum)
        if (this.AwsRegions == null && Exploration.Includes(parent + ".awsRegions", true))
        {
            this.AwsRegions = new List<AwsCloudAccountRegion>();
        }
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature == null && Exploration.Includes(parent + ".feature", true))
        {
            this.Feature = new CloudAccountFeature();
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new CloudAccountStatus();
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        if (this.AccessKey == null && Exploration.Includes(parent + ".accessKey", true))
        {
            this.AccessKey = "FETCH";
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn == null && Exploration.Includes(parent + ".roleArn", true))
        {
            this.RoleArn = "FETCH";
        }
        //      C# -> System.String? StackArn
        // GraphQL -> stackArn: String! (scalar)
        if (this.StackArn == null && Exploration.Includes(parent + ".stackArn", true))
        {
            this.StackArn = "FETCH";
        }
        //      C# -> System.String? UserArn
        // GraphQL -> userArn: String (scalar)
        if (this.UserArn == null && Exploration.Includes(parent + ".userArn", true))
        {
            this.UserArn = "FETCH";
        }
        //      C# -> AwsAuthServerDetail? AuthServerDetail
        // GraphQL -> authServerDetail: AwsAuthServerDetail (type)
        if (this.AuthServerDetail == null && Exploration.Includes(parent + ".authServerDetail"))
        {
            this.AuthServerDetail = new AwsAuthServerDetail();
            this.AuthServerDetail.ApplyExploratoryFieldSpec(parent + ".authServerDetail");
        }
    }


    #endregion

    } // class FeatureDetail
    
    #endregion

    public static class ListFeatureDetailExtensions
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
            this List<FeatureDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FeatureDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FeatureDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types