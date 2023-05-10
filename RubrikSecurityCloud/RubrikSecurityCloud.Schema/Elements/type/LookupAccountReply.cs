// LookupAccountReply.cs
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
    #region LookupAccountReply
    public class LookupAccountReply: IFragment
    {
        #region members
        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        [JsonProperty("accountExpiryDate")]
        public DateTime? AccountExpiryDate { get; set; }

        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        [JsonProperty("accountState")]
        public AccountState? AccountState { get; set; }

        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        [JsonProperty("accountType")]
        public AccountType? AccountType { get; set; }

        #endregion

    #region methods

    public LookupAccountReply Set(
        DateTime? AccountExpiryDate = null,
        AccountState? AccountState = null,
        AccountType? AccountType = null
    ) 
    {
        if ( AccountExpiryDate != null ) {
            this.AccountExpiryDate = AccountExpiryDate;
        }
        if ( AccountState != null ) {
            this.AccountState = AccountState;
        }
        if ( AccountType != null ) {
            this.AccountType = AccountType;
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
            //      C# -> DateTime? AccountExpiryDate
            // GraphQL -> accountExpiryDate: DateTime (scalar)
            if (this.AccountExpiryDate != null)
            {
                 s += ind + "accountExpiryDate\n";

            }
            //      C# -> AccountState? AccountState
            // GraphQL -> accountState: AccountState! (enum)
            if (this.AccountState != null)
            {
                 s += ind + "accountState\n";

            }
            //      C# -> AccountType? AccountType
            // GraphQL -> accountType: AccountType! (enum)
            if (this.AccountType != null)
            {
                 s += ind + "accountType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? AccountExpiryDate
            // GraphQL -> accountExpiryDate: DateTime (scalar)
            if (this.AccountExpiryDate == null && Exploration.Includes(parent + ".accountExpiryDate$"))
            {
                this.AccountExpiryDate = new DateTime();
            }
            //      C# -> AccountState? AccountState
            // GraphQL -> accountState: AccountState! (enum)
            if (this.AccountState == null && Exploration.Includes(parent + ".accountState$"))
            {
                this.AccountState = new AccountState();
            }
            //      C# -> AccountType? AccountType
            // GraphQL -> accountType: AccountType! (enum)
            if (this.AccountType == null && Exploration.Includes(parent + ".accountType$"))
            {
                this.AccountType = new AccountType();
            }
        }


    #endregion

    } // class LookupAccountReply
    #endregion

    public static class ListLookupAccountReplyExtensions
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
            this List<LookupAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LookupAccountReply> list, 
            String parent = "")
        {
            var item = new LookupAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types