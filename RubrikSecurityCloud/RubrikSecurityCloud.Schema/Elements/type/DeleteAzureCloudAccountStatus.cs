// DeleteAzureCloudAccountStatus.cs
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
    #region DeleteAzureCloudAccountStatus
    public class DeleteAzureCloudAccountStatus: BaseType
    {
        #region members

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteAzureCloudAccountStatus";
    }

    public DeleteAzureCloudAccountStatus Set(
        System.String? AzureSubscriptionNativeId = null,
        System.String? Error = null,
        System.Boolean? IsSuccess = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            s += ind + "azureSubscriptionNativeId\n" ;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            s += ind + "isSuccess\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId == null && Exploration.Includes(parent + ".azureSubscriptionNativeId", true))
        {
            this.AzureSubscriptionNativeId = "FETCH";
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && Exploration.Includes(parent + ".error", true))
        {
            this.Error = "FETCH";
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess == null && Exploration.Includes(parent + ".isSuccess", true))
        {
            this.IsSuccess = true;
        }
    }


    #endregion

    } // class DeleteAzureCloudAccountStatus
    
    #endregion

    public static class ListDeleteAzureCloudAccountStatusExtensions
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
            this List<DeleteAzureCloudAccountStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DeleteAzureCloudAccountStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteAzureCloudAccountStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types