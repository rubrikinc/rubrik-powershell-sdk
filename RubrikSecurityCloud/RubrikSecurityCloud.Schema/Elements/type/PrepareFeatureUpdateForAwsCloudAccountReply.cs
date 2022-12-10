// PrepareFeatureUpdateForAwsCloudAccountReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:21.
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
    #region PrepareFeatureUpdateForAwsCloudAccountReply
    public class PrepareFeatureUpdateForAwsCloudAccountReply: IFragment
    {
        #region members
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        [JsonProperty("cloudFormationUrl")]
        public System.String? CloudFormationUrl { get; set; }

        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        [JsonProperty("templateUrl")]
        public System.String? TemplateUrl { get; set; }

        #endregion

    #region methods

    public PrepareFeatureUpdateForAwsCloudAccountReply Set(
        System.String? CloudFormationUrl = null,
        System.String? TemplateUrl = null
    ) 
    {
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( TemplateUrl != null ) {
            this.TemplateUrl = TemplateUrl;
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
            //      C# -> System.String? CloudFormationUrl
            // GraphQL -> cloudFormationUrl: String! (scalar)
            if (this.CloudFormationUrl != null)
            {
                 s += ind + "cloudFormationUrl\n";

            }
            //      C# -> System.String? TemplateUrl
            // GraphQL -> templateUrl: String! (scalar)
            if (this.TemplateUrl != null)
            {
                 s += ind + "templateUrl\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CloudFormationUrl
            // GraphQL -> cloudFormationUrl: String! (scalar)
            if (this.CloudFormationUrl == null && Exploration.Includes(parent + ".cloudFormationUrl$"))
            {
                this.CloudFormationUrl = new System.String("FETCH");
            }
            //      C# -> System.String? TemplateUrl
            // GraphQL -> templateUrl: String! (scalar)
            if (this.TemplateUrl == null && Exploration.Includes(parent + ".templateUrl$"))
            {
                this.TemplateUrl = new System.String("FETCH");
            }
        }


    #endregion

    } // class PrepareFeatureUpdateForAwsCloudAccountReply
    #endregion

    public static class ListPrepareFeatureUpdateForAwsCloudAccountReplyExtensions
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
            this List<PrepareFeatureUpdateForAwsCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PrepareFeatureUpdateForAwsCloudAccountReply> list, 
            String parent = "")
        {
            var item = new PrepareFeatureUpdateForAwsCloudAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types