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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String! (scalar)
        if (this.ChannelId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelId\n" ;
            } else {
                s += ind + "channelId\n" ;
            }
        }
        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        if (this.ChannelName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelName\n" ;
            } else {
                s += ind + "channelName\n" ;
            }
        }
        //      C# -> System.Int32? ChannelPostCount
        // GraphQL -> channelPostCount: Int! (scalar)
        if (this.ChannelPostCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "channelPostCount\n" ;
            } else {
                s += ind + "channelPostCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String! (scalar)
        if (ec.Includes("channelId",true))
        {
            if(this.ChannelId == null) {

                this.ChannelId = "FETCH";

            } else {


            }
        }
        else if (this.ChannelId != null && ec.Excludes("channelId",true))
        {
            this.ChannelId = null;
        }
        //      C# -> System.String? ChannelName
        // GraphQL -> channelName: String (scalar)
        if (ec.Includes("channelName",true))
        {
            if(this.ChannelName == null) {

                this.ChannelName = "FETCH";

            } else {


            }
        }
        else if (this.ChannelName != null && ec.Excludes("channelName",true))
        {
            this.ChannelName = null;
        }
        //      C# -> System.Int32? ChannelPostCount
        // GraphQL -> channelPostCount: Int! (scalar)
        if (ec.Includes("channelPostCount",true))
        {
            if(this.ChannelPostCount == null) {

                this.ChannelPostCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ChannelPostCount != null && ec.Excludes("channelPostCount",true))
        {
            this.ChannelPostCount = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365TeamsConversations> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365TeamsConversations());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365TeamsConversations> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types