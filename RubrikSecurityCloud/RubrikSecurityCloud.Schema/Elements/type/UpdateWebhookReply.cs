// UpdateWebhookReply.cs
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
    #region UpdateWebhookReply
    public class UpdateWebhookReply: BaseType
    {
        #region members

        //      C# -> ErrorInfo? TestError
        // GraphQL -> testError: ErrorInfo (type)
        [JsonProperty("testError")]
        public ErrorInfo? TestError { get; set; }

        //      C# -> Webhook? Webhook
        // GraphQL -> webhook: Webhook! (type)
        [JsonProperty("webhook")]
        public Webhook? Webhook { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateWebhookReply";
    }

    public UpdateWebhookReply Set(
        ErrorInfo? TestError = null,
        Webhook? Webhook = null
    ) 
    {
        if ( TestError != null ) {
            this.TestError = TestError;
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
        //      C# -> ErrorInfo? TestError
        // GraphQL -> testError: ErrorInfo (type)
        if (this.TestError != null) {
            var fspec = this.TestError.AsFieldSpec(conf.Child("testError"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "testError" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Webhook? Webhook
        // GraphQL -> webhook: Webhook! (type)
        if (this.Webhook != null) {
            var fspec = this.Webhook.AsFieldSpec(conf.Child("webhook"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "webhook" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ErrorInfo? TestError
        // GraphQL -> testError: ErrorInfo (type)
        if (ec.Includes("testError",false))
        {
            if(this.TestError == null) {

                this.TestError = new ErrorInfo();
                this.TestError.ApplyExploratoryFieldSpec(ec.NewChild("testError"));

            } else {

                this.TestError.ApplyExploratoryFieldSpec(ec.NewChild("testError"));

            }
        }
        else if (this.TestError != null && ec.Excludes("testError",false))
        {
            this.TestError = null;
        }
        //      C# -> Webhook? Webhook
        // GraphQL -> webhook: Webhook! (type)
        if (ec.Includes("webhook",false))
        {
            if(this.Webhook == null) {

                this.Webhook = new Webhook();
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

    } // class UpdateWebhookReply
    
    #endregion

    public static class ListUpdateWebhookReplyExtensions
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
            this List<UpdateWebhookReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateWebhookReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateWebhookReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateWebhookReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateWebhookReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types