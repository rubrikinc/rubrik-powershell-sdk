// ValidateAndCreateAwsCloudAccountReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:20.
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
    #region ValidateAndCreateAwsCloudAccountReply
    public class ValidateAndCreateAwsCloudAccountReply: IFragment
    {
        #region members
        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        [JsonProperty("initiateResponse")]
        public AwsCloudAccountCreateResponse? InitiateResponse { get; set; }

        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        [JsonProperty("validateResponse")]
        public AwsCloudAccountValidateResponse? ValidateResponse { get; set; }

        #endregion

    #region methods

    public ValidateAndCreateAwsCloudAccountReply Set(
        AwsCloudAccountCreateResponse? InitiateResponse = null,
        AwsCloudAccountValidateResponse? ValidateResponse = null
    ) 
    {
        if ( InitiateResponse != null ) {
            this.InitiateResponse = InitiateResponse;
        }
        if ( ValidateResponse != null ) {
            this.ValidateResponse = ValidateResponse;
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
            //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
            // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
            if (this.InitiateResponse != null)
            {
                 s += ind + "initiateResponse\n";

                 s += ind + "{\n" + 
                 this.InitiateResponse.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
            // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
            if (this.ValidateResponse != null)
            {
                 s += ind + "validateResponse\n";

                 s += ind + "{\n" + 
                 this.ValidateResponse.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
            // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
            if (this.InitiateResponse == null && Exploration.Includes(parent + ".initiateResponse"))
            {
                this.InitiateResponse = new AwsCloudAccountCreateResponse();
                this.InitiateResponse.ApplyExploratoryFragment(parent + ".initiateResponse");
            }
            //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
            // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
            if (this.ValidateResponse == null && Exploration.Includes(parent + ".validateResponse"))
            {
                this.ValidateResponse = new AwsCloudAccountValidateResponse();
                this.ValidateResponse.ApplyExploratoryFragment(parent + ".validateResponse");
            }
        }


    #endregion

    } // class ValidateAndCreateAwsCloudAccountReply
    #endregion

    public static class ListValidateAndCreateAwsCloudAccountReplyExtensions
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
            this List<ValidateAndCreateAwsCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ValidateAndCreateAwsCloudAccountReply> list, 
            String parent = "")
        {
            var item = new ValidateAndCreateAwsCloudAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types