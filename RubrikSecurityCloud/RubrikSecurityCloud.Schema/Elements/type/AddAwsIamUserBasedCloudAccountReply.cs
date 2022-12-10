// AddAwsIamUserBasedCloudAccountReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
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
    #region AddAwsIamUserBasedCloudAccountReply
    public class AddAwsIamUserBasedCloudAccountReply: IFragment
    {
        #region members
        //      C# -> AwsCloudAccount? AwsAccount
        // GraphQL -> awsAccount: AwsCloudAccount (type)
        [JsonProperty("awsAccount")]
        public AwsCloudAccount? AwsAccount { get; set; }

        #endregion

    #region methods

    public AddAwsIamUserBasedCloudAccountReply Set(
        AwsCloudAccount? AwsAccount = null
    ) 
    {
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
            //      C# -> AwsCloudAccount? AwsAccount
            // GraphQL -> awsAccount: AwsCloudAccount (type)
            if (this.AwsAccount == null && Exploration.Includes(parent + ".awsAccount"))
            {
                this.AwsAccount = new AwsCloudAccount();
                this.AwsAccount.ApplyExploratoryFragment(parent + ".awsAccount");
            }
        }


    #endregion

    } // class AddAwsIamUserBasedCloudAccountReply
    #endregion

    public static class ListAddAwsIamUserBasedCloudAccountReplyExtensions
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
            this List<AddAwsIamUserBasedCloudAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddAwsIamUserBasedCloudAccountReply> list, 
            String parent = "")
        {
            var item = new AddAwsIamUserBasedCloudAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types