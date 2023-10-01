// TestExistingWebhookReply.cs
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
    #region TestExistingWebhookReply
    public class TestExistingWebhookReply: BaseType
    {
        #region members

        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        [JsonProperty("webhookStatus")]
        public WebhookStatus? WebhookStatus { get; set; }

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }

        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        [JsonProperty("errorInfo")]
        public ErrorInfo? ErrorInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TestExistingWebhookReply";
    }

    public TestExistingWebhookReply Set(
        WebhookStatus? WebhookStatus = null,
        System.Boolean? IsSuccessful = null,
        ErrorInfo? ErrorInfo = null
    ) 
    {
        if ( WebhookStatus != null ) {
            this.WebhookStatus = WebhookStatus;
        }
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
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
        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        if (this.WebhookStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "webhookStatus\n" ;
            } else {
                s += ind + "webhookStatus\n" ;
            }
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSuccessful\n" ;
            } else {
                s += ind + "isSuccessful\n" ;
            }
        }
        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        if (this.ErrorInfo != null) {
            var fspec = this.ErrorInfo.AsFieldSpec(conf.Child("errorInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errorInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        if (ec.Includes("webhookStatus",true))
        {
            if(this.WebhookStatus == null) {

                this.WebhookStatus = new WebhookStatus();

            } else {


            }
        }
        else if (this.WebhookStatus != null && ec.Excludes("webhookStatus",true))
        {
            this.WebhookStatus = null;
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (ec.Includes("isSuccessful",true))
        {
            if(this.IsSuccessful == null) {

                this.IsSuccessful = true;

            } else {


            }
        }
        else if (this.IsSuccessful != null && ec.Excludes("isSuccessful",true))
        {
            this.IsSuccessful = null;
        }
        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        if (ec.Includes("errorInfo",false))
        {
            if(this.ErrorInfo == null) {

                this.ErrorInfo = new ErrorInfo();
                this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));

            } else {

                this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));

            }
        }
        else if (this.ErrorInfo != null && ec.Excludes("errorInfo",false))
        {
            this.ErrorInfo = null;
        }
    }


    #endregion

    } // class TestExistingWebhookReply
    
    #endregion

    public static class ListTestExistingWebhookReplyExtensions
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
            this List<TestExistingWebhookReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<TestExistingWebhookReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TestExistingWebhookReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TestExistingWebhookReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TestExistingWebhookReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types