// TestWebhookReply.cs
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
    #region TestWebhookReply
    public class TestWebhookReply: IFragment
    {
        #region members
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

    public TestWebhookReply Set(
        System.Boolean? IsSuccessful = null,
        ErrorInfo? ErrorInfo = null
    ) 
    {
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
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
            //      C# -> System.Boolean? IsSuccessful
            // GraphQL -> isSuccessful: Boolean! (scalar)
            if (this.IsSuccessful != null)
            {
                 s += ind + "isSuccessful\n";

            }
            //      C# -> ErrorInfo? ErrorInfo
            // GraphQL -> errorInfo: ErrorInfo (type)
            if (this.ErrorInfo != null)
            {
                 s += ind + "errorInfo\n";

                 s += ind + "{\n" + 
                 this.ErrorInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsSuccessful
            // GraphQL -> isSuccessful: Boolean! (scalar)
            if (this.IsSuccessful == null && Exploration.Includes(parent + ".isSuccessful$"))
            {
                this.IsSuccessful = new System.Boolean();
            }
            //      C# -> ErrorInfo? ErrorInfo
            // GraphQL -> errorInfo: ErrorInfo (type)
            if (this.ErrorInfo == null && Exploration.Includes(parent + ".errorInfo"))
            {
                this.ErrorInfo = new ErrorInfo();
                this.ErrorInfo.ApplyExploratoryFragment(parent + ".errorInfo");
            }
        }


    #endregion

    } // class TestWebhookReply
    #endregion

    public static class ListTestWebhookReplyExtensions
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
            this List<TestWebhookReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TestWebhookReply> list, 
            String parent = "")
        {
            var item = new TestWebhookReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types