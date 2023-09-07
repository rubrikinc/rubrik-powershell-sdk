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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        if (this.WebhookStatus != null) {
            s += ind + "webhookStatus\n" ;
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            s += ind + "isSuccessful\n" ;
        }
        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        if (this.ErrorInfo != null) {
            var fspec = this.ErrorInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "errorInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        if (this.WebhookStatus == null && ec.Includes("webhookStatus",true))
        {
            this.WebhookStatus = new WebhookStatus();
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful == null && ec.Includes("isSuccessful",true))
        {
            this.IsSuccessful = true;
        }
        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        if (this.ErrorInfo == null && ec.Includes("errorInfo",false))
        {
            this.ErrorInfo = new ErrorInfo();
            this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<TestExistingWebhookReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types