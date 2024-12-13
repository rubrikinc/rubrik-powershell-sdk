// AwsAccountValidationResponse.cs
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
    #region AwsAccountValidationResponse
    public class AwsAccountValidationResponse: BaseType
    {
        #region members

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String! (scalar)
        [JsonProperty("outpostAwsNativeId")]
        public System.String? OutpostAwsNativeId { get; set; }

        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        [JsonProperty("seamlessFlowEnabled")]
        public System.Boolean? SeamlessFlowEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsAccountValidationResponse";
    }

    public AwsAccountValidationResponse Set(
        AwsCloudType? CloudType = null,
        System.String? AccountName = null,
        System.String? Message = null,
        System.String? NativeId = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.String? OutpostAwsNativeId = null,
        System.Boolean? SeamlessFlowEnabled = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( OutpostAwsNativeId != null ) {
            this.OutpostAwsNativeId = OutpostAwsNativeId;
        }
        if ( SeamlessFlowEnabled != null ) {
            this.SeamlessFlowEnabled = SeamlessFlowEnabled;
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
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountName\n" ;
            } else {
                s += ind + "accountName\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeId\n" ;
            } else {
                s += ind + "nativeId\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String! (scalar)
        if (this.OutpostAwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "outpostAwsNativeId\n" ;
            } else {
                s += ind + "outpostAwsNativeId\n" ;
            }
        }
        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        if (this.SeamlessFlowEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "seamlessFlowEnabled\n" ;
            } else {
                s += ind + "seamlessFlowEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new AwsCloudType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (ec.Includes("accountName",true))
        {
            if(this.AccountName == null) {

                this.AccountName = "FETCH";

            } else {


            }
        }
        else if (this.AccountName != null && ec.Excludes("accountName",true))
        {
            this.AccountName = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (ec.Includes("nativeId",true))
        {
            if(this.NativeId == null) {

                this.NativeId = "FETCH";

            } else {


            }
        }
        else if (this.NativeId != null && ec.Excludes("nativeId",true))
        {
            this.NativeId = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> System.String? OutpostAwsNativeId
        // GraphQL -> outpostAwsNativeId: String! (scalar)
        if (ec.Includes("outpostAwsNativeId",true))
        {
            if(this.OutpostAwsNativeId == null) {

                this.OutpostAwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.OutpostAwsNativeId != null && ec.Excludes("outpostAwsNativeId",true))
        {
            this.OutpostAwsNativeId = null;
        }
        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        if (ec.Includes("seamlessFlowEnabled",true))
        {
            if(this.SeamlessFlowEnabled == null) {

                this.SeamlessFlowEnabled = true;

            } else {


            }
        }
        else if (this.SeamlessFlowEnabled != null && ec.Excludes("seamlessFlowEnabled",true))
        {
            this.SeamlessFlowEnabled = null;
        }
    }


    #endregion

    } // class AwsAccountValidationResponse
    
    #endregion

    public static class ListAwsAccountValidationResponseExtensions
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
            this List<AwsAccountValidationResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsAccountValidationResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsAccountValidationResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsAccountValidationResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsAccountValidationResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types