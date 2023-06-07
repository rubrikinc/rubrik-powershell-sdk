// AwsCloudAccount.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AwsCloudAccount
    public class AwsCloudAccount: BaseType
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

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

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

    public AwsCloudAccount Set(
        AwsCloudType? CloudType = null,
        System.String? AccountName = null,
        System.String? Id = null,
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
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType == null && Exploration.Includes(parent + ".cloudType", true))
        {
            this.CloudType = new AwsCloudType();
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName == null && Exploration.Includes(parent + ".accountName", true))
        {
            this.AccountName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && Exploration.Includes(parent + ".nativeId", true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        if (this.SeamlessFlowEnabled == null && Exploration.Includes(parent + ".seamlessFlowEnabled", true))
        {
            this.SeamlessFlowEnabled = true;
        }
    }


    #endregion

    } // class AwsCloudAccount
    
    #endregion

    public static class ListAwsCloudAccountExtensions
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
            this List<AwsCloudAccount> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types