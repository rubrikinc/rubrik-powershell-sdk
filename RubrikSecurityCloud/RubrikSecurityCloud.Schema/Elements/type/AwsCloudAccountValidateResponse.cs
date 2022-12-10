// AwsCloudAccountValidateResponse.cs
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
    #region AwsCloudAccountValidateResponse
    public class AwsCloudAccountValidateResponse: IFragment
    {
        #region members
        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        [JsonProperty("invalidAwsAccounts")]
        public List<AwsAccountValidationResponse>? InvalidAwsAccounts { get; set; }

        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        [JsonProperty("invalidAwsAdminAccount")]
        public AwsAccountValidationResponse? InvalidAwsAdminAccount { get; set; }

        #endregion

    #region methods

    public AwsCloudAccountValidateResponse Set(
        List<AwsAccountValidationResponse>? InvalidAwsAccounts = null,
        AwsAccountValidationResponse? InvalidAwsAdminAccount = null
    ) 
    {
        if ( InvalidAwsAccounts != null ) {
            this.InvalidAwsAccounts = InvalidAwsAccounts;
        }
        if ( InvalidAwsAdminAccount != null ) {
            this.InvalidAwsAdminAccount = InvalidAwsAdminAccount;
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
            //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
            // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
            if (this.InvalidAwsAccounts != null)
            {
                 s += ind + "invalidAwsAccounts\n";

                 s += ind + "{\n" + 
                 this.InvalidAwsAccounts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
            // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
            if (this.InvalidAwsAdminAccount != null)
            {
                 s += ind + "invalidAwsAdminAccount\n";

                 s += ind + "{\n" + 
                 this.InvalidAwsAdminAccount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
            // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
            if (this.InvalidAwsAccounts == null && Exploration.Includes(parent + ".invalidAwsAccounts"))
            {
                this.InvalidAwsAccounts = new List<AwsAccountValidationResponse>();
                this.InvalidAwsAccounts.ApplyExploratoryFragment(parent + ".invalidAwsAccounts");
            }
            //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
            // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
            if (this.InvalidAwsAdminAccount == null && Exploration.Includes(parent + ".invalidAwsAdminAccount"))
            {
                this.InvalidAwsAdminAccount = new AwsAccountValidationResponse();
                this.InvalidAwsAdminAccount.ApplyExploratoryFragment(parent + ".invalidAwsAdminAccount");
            }
        }


    #endregion

    } // class AwsCloudAccountValidateResponse
    #endregion

    public static class ListAwsCloudAccountValidateResponseExtensions
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
            this List<AwsCloudAccountValidateResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCloudAccountValidateResponse> list, 
            String parent = "")
        {
            var item = new AwsCloudAccountValidateResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types