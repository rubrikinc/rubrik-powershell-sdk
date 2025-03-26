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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365TeamsConversations> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365TeamsConversations> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365TeamsConversations> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365TeamsConversations());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365TeamsConversations> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types