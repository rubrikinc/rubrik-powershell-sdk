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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ErrorInfo? TestError
        // GraphQL -> testError: ErrorInfo (type)
        if (this.TestError != null) {
            var fspec = this.TestError.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "testError {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Webhook? Webhook
        // GraphQL -> webhook: Webhook! (type)
        if (this.Webhook != null) {
            var fspec = this.Webhook.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "webhook {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ErrorInfo? TestError
        // GraphQL -> testError: ErrorInfo (type)
        if (this.TestError == null && Exploration.Includes(parent + ".testError"))
        {
            this.TestError = new ErrorInfo();
            this.TestError.ApplyExploratoryFieldSpec(parent + ".testError");
        }
        //      C# -> Webhook? Webhook
        // GraphQL -> webhook: Webhook! (type)
        if (this.Webhook == null && Exploration.Includes(parent + ".webhook"))
        {
            this.Webhook = new Webhook();
            this.Webhook.ApplyExploratoryFieldSpec(parent + ".webhook");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateWebhookReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateWebhookReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types