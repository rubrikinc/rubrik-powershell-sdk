// UserNotifications.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:49.
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
    #region UserNotifications
    public class UserNotifications: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        [JsonProperty("unreadCount")]
        public System.Int64? UnreadCount { get; set; }

        #endregion

    #region methods

    public UserNotifications Set(
        System.String? Id = null,
        System.Int64? UnreadCount = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( UnreadCount != null ) {
            this.UnreadCount = UnreadCount;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? UnreadCount
            // GraphQL -> unreadCount: Long! (scalar)
            if (this.UnreadCount != null)
            {
                 s += ind + "unreadCount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? UnreadCount
            // GraphQL -> unreadCount: Long! (scalar)
            if (this.UnreadCount == null && Exploration.Includes(parent + ".unreadCount$"))
            {
                this.UnreadCount = new System.Int64();
            }
        }


    #endregion

    } // class UserNotifications
    #endregion

    public static class ListUserNotificationsExtensions
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
            this List<UserNotifications> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserNotifications> list, 
            String parent = "")
        {
            var item = new UserNotifications();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types