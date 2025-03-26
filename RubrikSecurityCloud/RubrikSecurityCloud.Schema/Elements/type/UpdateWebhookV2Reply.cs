// UpdateWebhookV2Reply.cs
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
    #region UpdateWebhookV2Reply
    public class UpdateWebhookV2Reply: BaseType
    {
        #region members

        //      C# -> WebhookErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: WebhookErrorInfo (type)
        [JsonProperty("errorInfo")]
        public WebhookErrorInfo? ErrorInfo { get; set; }

        //      C# -> WebhookV2? Webhook
        // GraphQL -> webhook: WebhookV2 (type)
        [JsonProperty("webhook")]
        public WebhookV2? Webhook { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateWebhookV2Reply";
    }

    public UpdateWebhookV2Reply Set(
        WebhookErrorInfo? ErrorInfo = null,
        WebhookV2? Webhook = null
    ) 
    {
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
        }
        if ( Webhook != null ) {
            this.Webhook = Webhook;
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
        //      C# -> WebhookErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: WebhookErrorInfo (type)
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
        //      C# -> WebhookV2? Webhook
        // GraphQL -> webhook: WebhookV2 (type)
        if (this.Webhook != null) {
            var fspec = this.Webhook.AsFieldSpec(conf.Child("webhook"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "webhook" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> WebhookErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: WebhookErrorInfo (type)
        if (ec.Includes("errorInfo",false))
        {
            if(this.ErrorInfo == null) {

                this.ErrorInfo = new WebhookErrorInfo();
                this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));

            } else {

                this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));

            }
        }
        else if (this.ErrorInfo != null && ec.Excludes("errorInfo",false))
        {
            this.ErrorInfo = null;
        }
        //      C# -> WebhookV2? Webhook
        // GraphQL -> webhook: WebhookV2 (type)
        if (ec.Includes("webhook",false))
        {
            if(this.Webhook == null) {

                this.Webhook = new WebhookV2();
                this.Webhook.ApplyExploratoryFieldSpec(ec.NewChild("webhook"));

            } else {

                this.Webhook.ApplyExploratoryFieldSpec(ec.NewChild("webhook"));

            }
        }
        else if (this.Webhook != null && ec.Excludes("webhook",false))
        {
            this.Webhook = null;
        }
    }


    #endregion

    } // class UpdateWebhookV2Reply
    
    #endregion

    public static class ListUpdateWebhookV2ReplyExtensions
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
            this List<UpdateWebhookV2Reply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateWebhookV2Reply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateWebhookV2Reply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateWebhookV2Reply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateWebhookV2Reply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types