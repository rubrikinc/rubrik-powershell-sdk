// UpdateWebhookReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:14.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateWebhookReply
    public class UpdateWebhookReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> ErrorInfo? TestError
            // GraphQL -> testError: ErrorInfo (type)
            if (this.TestError != null)
            {
                 s += ind + "testError\n";

                 s += ind + "{\n" + 
                 this.TestError.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Webhook? Webhook
            // GraphQL -> webhook: Webhook! (type)
            if (this.Webhook != null)
            {
                 s += ind + "webhook\n";

                 s += ind + "{\n" + 
                 this.Webhook.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> ErrorInfo? TestError
            // GraphQL -> testError: ErrorInfo (type)
            if (this.TestError == null && Exploration.Includes(parent + ".testError"))
            {
                this.TestError = new ErrorInfo();
                this.TestError.ApplyExploratoryFragment(parent + ".testError");
            }
            //      C# -> Webhook? Webhook
            // GraphQL -> webhook: Webhook! (type)
            if (this.Webhook == null && Exploration.Includes(parent + ".webhook"))
            {
                this.Webhook = new Webhook();
                this.Webhook.ApplyExploratoryFragment(parent + ".webhook");
            }
        }


    #endregion

    } // class UpdateWebhookReply
    #endregion

    public static class ListUpdateWebhookReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<UpdateWebhookReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateWebhookReply> list, 
            String parent = "")
        {
            var item = new UpdateWebhookReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types