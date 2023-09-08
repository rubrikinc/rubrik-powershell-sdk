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
        if ( SeamlessFlowEnabled != null ) {
            this.SeamlessFlowEnabled = SeamlessFlowEnabled;
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
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType != null) {
            s += ind + "cloudType\n" ;
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            s += ind + "accountName\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
        }
        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        if (this.SeamlessFlowEnabled != null) {
            s += ind + "seamlessFlowEnabled\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType == null && ec.Includes("cloudType",true))
        {
            this.CloudType = new AwsCloudType();
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName == null && ec.Includes("accountName",true))
        {
            this.AccountName = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && ec.Includes("message",true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && ec.Includes("nativeId",true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        if (this.SeamlessFlowEnabled == null && ec.Includes("seamlessFlowEnabled",true))
        {
            this.SeamlessFlowEnabled = true;
        }
    }


    #endregion

    } // class AwsAccountValidationResponse
    
    #endregion

    public static class ListAwsAccountValidationResponseExtensions
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
            this List<AwsAccountValidationResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<AwsAccountValidationResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types