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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region O365TeamsConversations
    public class O365TeamsConversations: BaseType
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

    public override string GetGqlTypeName() {
        return "O365TeamsConversations";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String! (scalar)
        if (this.ChannelId != null) {
            s += ind + "channelId\n" ;
        }
        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        if (this.ChannelName != null) {
            s += ind + "channelName\n" ;
        }
        //      C# -> System.Int32? ChannelPostCount
        // GraphQL -> channelPostCount: Int! (scalar)
        if (this.ChannelPostCount != null) {
            s += ind + "channelPostCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String! (scalar)
        if (this.ChannelId == null && Exploration.Includes(parent + ".channelId", true))
        {
            this.ChannelId = "FETCH";
        }
        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        if (this.ChannelName == null && Exploration.Includes(parent + ".channelName", true))
        {
            this.ChannelName = "FETCH";
        }
        //      C# -> System.Int32? ChannelPostCount
        // GraphQL -> channelPostCount: Int! (scalar)
        if (this.ChannelPostCount == null && Exploration.Includes(parent + ".channelPostCount", true))
        {
            this.ChannelPostCount = Int32.MinValue;
        }
    }


    #endregion

    } // class O365TeamsConversations
    
    #endregion

    public static class ListO365TeamsConversationsExtensions
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
            this List<O365TeamsConversations> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365TeamsConversations> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365TeamsConversations());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types