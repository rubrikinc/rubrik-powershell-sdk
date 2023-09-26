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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ErrorInfo? TestError
        // GraphQL -> testError: ErrorInfo (type)
        if (this.TestError != null) {
            var fspec = this.TestError.AsFieldSpec(conf.Child("testError"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "testError {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Webhook? Webhook
        // GraphQL -> webhook: Webhook! (type)
        if (this.Webhook != null) {
            var fspec = this.Webhook.AsFieldSpec(conf.Child("webhook"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "webhook {\n" + fspec + ind + "}\n" ;
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
            this List<UpdateWebhookReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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