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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSuccess\n" ;
            } else {
                s += ind + "isSuccess\n" ;
            }
        }
        //      C# -> List<AzureCloudAccountSubscription>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscription!]! (type)
        if (this.Subscriptions != null) {
            var fspec = this.Subscriptions.AsFieldSpec(conf.Child("subscriptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscriptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (ec.Includes("isSuccess",true))
        {
            if(this.IsSuccess == null) {

                this.IsSuccess = true;

            } else {


            }
        }
        else if (this.IsSuccess != null && ec.Excludes("isSuccess",true))
        {
            this.IsSuccess = null;
        }
        //      C# -> List<AzureCloudAccountSubscription>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscription!]! (type)
        if (ec.Includes("subscriptions",false))
        {
            if(this.Subscriptions == null) {

                this.Subscriptions = new List<AzureCloudAccountSubscription>();
                this.Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("subscriptions"));

            } else {

                this.Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("subscriptions"));

            }
        }
        else if (this.Subscriptions != null && ec.Excludes("subscriptions",false))
        {
            this.Subscriptions = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CompleteAzureCloudAccountOauthReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CompleteAzureCloudAccountOauthReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CompleteAzureCloudAccountOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CompleteAzureCloudAccountOauthReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types