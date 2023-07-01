// EventClusterSettingReply.cs
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
    #region EventClusterSettingReply
    public class EventClusterSettingReply: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? SettingKey
        // GraphQL -> settingKey: String! (scalar)
        [JsonProperty("settingKey")]
        public System.String? SettingKey { get; set; }

        //      C# -> System.String? SettingValue
        // GraphQL -> settingValue: String! (scalar)
        [JsonProperty("settingValue")]
        public System.String? SettingValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EventClusterSettingReply";
    }

    public EventClusterSettingReply Set(
        System.String? ClusterUuid = null,
        System.String? SettingKey = null,
        System.String? SettingValue = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( SettingKey != null ) {
            this.SettingKey = SettingKey;
        }
        if ( SettingValue != null ) {
            this.SettingValue = SettingValue;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? SettingKey
        // GraphQL -> settingKey: String! (scalar)
        if (this.SettingKey != null) {
            s += ind + "settingKey\n" ;
        }
        //      C# -> System.String? SettingValue
        // GraphQL -> settingValue: String! (scalar)
        if (this.SettingValue != null) {
            s += ind + "settingValue\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? SettingKey
        // GraphQL -> settingKey: String! (scalar)
        if (this.SettingKey == null && Exploration.Includes(parent + ".settingKey", true))
        {
            this.SettingKey = "FETCH";
        }
        //      C# -> System.String? SettingValue
        // GraphQL -> settingValue: String! (scalar)
        if (this.SettingValue == null && Exploration.Includes(parent + ".settingValue", true))
        {
            this.SettingValue = "FETCH";
        }
    }


    #endregion

    } // class EventClusterSettingReply
    
    #endregion

    public static class ListEventClusterSettingReplyExtensions
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
            this List<EventClusterSettingReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EventClusterSettingReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EventClusterSettingReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types