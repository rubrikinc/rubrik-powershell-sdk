// O365TeamsConversations.cs
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
    #region O365TeamsConversations
    public class O365TeamsConversations: IFragment
    {
        #region members
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String! (scalar)
        [JsonProperty("channelId")]
        public System.String? ChannelId { get; set; }

        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        [JsonProperty("channelName")]
        public System.String? ChannelName { get; set; }

        //      C# -> System.Int32? ChannelPostCount
        // GraphQL -> channelPostCount: Int! (scalar)
        [JsonProperty("channelPostCount")]
        public System.Int32? ChannelPostCount { get; set; }

        #endregion

    #region methods

    public O365TeamsConversations Set(
        System.String? ChannelId = null,
        System.String? ChannelName = null,
        System.Int32? ChannelPostCount = null
    ) 
    {
        if ( ChannelId != null ) {
            this.ChannelId = ChannelId;
        }
        if ( ChannelName != null ) {
            this.ChannelName = ChannelName;
        }
        if ( ChannelPostCount != null ) {
            this.ChannelPostCount = ChannelPostCount;
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
            //      C# -> System.String? ChannelId
            // GraphQL -> channelId: String! (scalar)
            if (this.ChannelId != null)
            {
                 s += ind + "channelId\n";

            }
            //      C# -> System.String? ChannelName
            // GraphQL -> channelName: String (scalar)
            if (this.ChannelName != null)
            {
                 s += ind + "channelName\n";

            }
            //      C# -> System.Int32? ChannelPostCount
            // GraphQL -> channelPostCount: Int! (scalar)
            if (this.ChannelPostCount != null)
            {
                 s += ind + "channelPostCount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ChannelId
            // GraphQL -> channelId: String! (scalar)
            if (this.ChannelId == null && Exploration.Includes(parent + ".channelId$"))
            {
                this.ChannelId = new System.String("FETCH");
            }
            //      C# -> System.String? ChannelName
            // GraphQL -> channelName: String (scalar)
            if (this.ChannelName == null && Exploration.Includes(parent + ".channelName$"))
            {
                this.ChannelName = new System.String("FETCH");
            }
            //      C# -> System.Int32? ChannelPostCount
            // GraphQL -> channelPostCount: Int! (scalar)
            if (this.ChannelPostCount == null && Exploration.Includes(parent + ".channelPostCount$"))
            {
                this.ChannelPostCount = new System.Int32();
            }
        }


    #endregion

    } // class O365TeamsConversations
    #endregion

    public static class ListO365TeamsConversationsExtensions
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
            this List<O365TeamsConversations> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365TeamsConversations> list, 
            String parent = "")
        {
            var item = new O365TeamsConversations();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types