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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            this List<CompleteAzureCloudAccountOauthReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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