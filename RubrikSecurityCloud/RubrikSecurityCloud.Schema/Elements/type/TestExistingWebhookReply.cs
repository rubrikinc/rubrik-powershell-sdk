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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "errorInfo" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<TestExistingWebhookReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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