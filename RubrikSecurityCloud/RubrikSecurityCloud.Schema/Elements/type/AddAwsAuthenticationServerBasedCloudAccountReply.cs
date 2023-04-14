// AddAwsAuthenticationServerBasedCloudAccountReply.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region AddAwsAuthenticationServerBasedCloudAccountReply
    public class AddAwsAuthenticationServerBasedCloudAccountReply: IFragment
    {
        #region members
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        [JsonProperty("awsAccount")]
        public AwsCloudAccount? AwsAccount { get; set; }

        #endregion

    #region methods

    public AddAwsAuthenticationServerBasedCloudAccountReply Set(
        System.String? Message = null,
        AwsCloudAccount? AwsAccount = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( AwsAccount != null ) {
            this.AwsAccount = AwsAccount;
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
            //      C# -> System.String? Message
            // GraphQL -> message: String (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> AwsCloudAccount? AwsAccount
            // GraphQL -> awsAccount: AwsCloudAccount (type)
            if (this.AwsAccount != null)
            {
                 s += ind + "awsAccount\n";

                 s += ind + "{\n" + 
                 this.AwsAccount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Message
            // GraphQL -> message: String (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> AwsCloudAccount? AwsAccount
            // GraphQL -> awsAccount: AwsCloudAccount (type)
            if (this.AwsAccount == null && Exploration.Includes(parent + ".awsAccount"))
            {
                this.AwsAccount = new AwsCloudAccount();
                this.AwsAccount.ApplyExploratoryFragment(parent + ".awsAccount");
            }
        }


    #endregion

    } // class AddAwsAuthenticationServerBasedCloudAccountReply
    #endregion

    public static class ListAddAwsAuthenticationServerBasedCloudAccountReplyExtensions
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
            this List<AddAwsAuthenticationServerBasedCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddAwsAuthenticationServerBasedCloudAccountReply> list, 
            String parent = "")
        {
            var item = new AddAwsAuthenticationServerBasedCloudAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types