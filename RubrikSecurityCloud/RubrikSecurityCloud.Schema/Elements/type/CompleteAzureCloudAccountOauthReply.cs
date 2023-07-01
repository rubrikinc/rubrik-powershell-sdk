// CompleteAzureCloudAccountOauthReply.cs
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
    #region CompleteAzureCloudAccountOauthReply
    public class CompleteAzureCloudAccountOauthReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }

        //      C# -> List<AzureCloudAccountSubscription>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscription!]! (type)
        [JsonProperty("subscriptions")]
        public List<AzureCloudAccountSubscription>? Subscriptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CompleteAzureCloudAccountOauthReply";
    }

    public CompleteAzureCloudAccountOauthReply Set(
        System.Boolean? IsSuccess = null,
        List<AzureCloudAccountSubscription>? Subscriptions = null
    ) 
    {
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
        }
        if ( Subscriptions != null ) {
            this.Subscriptions = Subscriptions;
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
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            s += ind + "isSuccess\n" ;
        }
        //      C# -> List<AzureCloudAccountSubscription>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscription!]! (type)
        if (this.Subscriptions != null) {
            var fspec = this.Subscriptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subscriptions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess == null && Exploration.Includes(parent + ".isSuccess", true))
        {
            this.IsSuccess = true;
        }
        //      C# -> List<AzureCloudAccountSubscription>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscription!]! (type)
        if (this.Subscriptions == null && Exploration.Includes(parent + ".subscriptions"))
        {
            this.Subscriptions = new List<AzureCloudAccountSubscription>();
            this.Subscriptions.ApplyExploratoryFieldSpec(parent + ".subscriptions");
        }
    }


    #endregion

    } // class CompleteAzureCloudAccountOauthReply
    
    #endregion

    public static class ListCompleteAzureCloudAccountOauthReplyExtensions
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
            this List<CompleteAzureCloudAccountOauthReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CompleteAzureCloudAccountOauthReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CompleteAzureCloudAccountOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types