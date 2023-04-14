// UserLoginContext.cs
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
    #region UserLoginContext
    public class UserLoginContext: IFragment
    {
        #region members
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? OrgFullName
        // GraphQL -> orgFullName: String! (scalar)
        [JsonProperty("orgFullName")]
        public System.String? OrgFullName { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> User? User
        // GraphQL -> user: User! (type)
        [JsonProperty("user")]
        public User? User { get; set; }

        #endregion

    #region methods

    public UserLoginContext Set(
        System.String? AccountName = null,
        System.String? OrgFullName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        User? User = null
    ) 
    {
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( OrgFullName != null ) {
            this.OrgFullName = OrgFullName;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( User != null ) {
            this.User = User;
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
            //      C# -> System.String? AccountName
            // GraphQL -> accountName: String! (scalar)
            if (this.AccountName != null)
            {
                 s += ind + "accountName\n";

            }
            //      C# -> System.String? OrgFullName
            // GraphQL -> orgFullName: String! (scalar)
            if (this.OrgFullName != null)
            {
                 s += ind + "orgFullName\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String! (scalar)
            if (this.OrgName != null)
            {
                 s += ind + "orgName\n";

            }
            //      C# -> User? User
            // GraphQL -> user: User! (type)
            if (this.User != null)
            {
                 s += ind + "user\n";

                 s += ind + "{\n" + 
                 this.User.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccountName
            // GraphQL -> accountName: String! (scalar)
            if (this.AccountName == null && Exploration.Includes(parent + ".accountName$"))
            {
                this.AccountName = new System.String("FETCH");
            }
            //      C# -> System.String? OrgFullName
            // GraphQL -> orgFullName: String! (scalar)
            if (this.OrgFullName == null && Exploration.Includes(parent + ".orgFullName$"))
            {
                this.OrgFullName = new System.String("FETCH");
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String! (scalar)
            if (this.OrgName == null && Exploration.Includes(parent + ".orgName$"))
            {
                this.OrgName = new System.String("FETCH");
            }
            //      C# -> User? User
            // GraphQL -> user: User! (type)
            if (this.User == null && Exploration.Includes(parent + ".user"))
            {
                this.User = new User();
                this.User.ApplyExploratoryFragment(parent + ".user");
            }
        }


    #endregion

    } // class UserLoginContext
    #endregion

    public static class ListUserLoginContextExtensions
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
            this List<UserLoginContext> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserLoginContext> list, 
            String parent = "")
        {
            var item = new UserLoginContext();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types