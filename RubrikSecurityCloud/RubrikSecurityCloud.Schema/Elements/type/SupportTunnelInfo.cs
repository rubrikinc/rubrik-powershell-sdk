// SupportTunnelInfo.cs
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
    #region SupportTunnelInfo
    public class SupportTunnelInfo: BaseType
    {
        #region members

        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        [JsonProperty("enabledTime")]
        public DateTime? EnabledTime { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        [JsonProperty("inactivityTimeoutInSeconds")]
        public System.Int64? InactivityTimeoutInSeconds { get; set; }

        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        [JsonProperty("isTunnelEnabled")]
        public System.Boolean? IsTunnelEnabled { get; set; }

        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        [JsonProperty("lastActivityTime")]
        public DateTime? LastActivityTime { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportTunnelInfo";
    }

    public SupportTunnelInfo Set(
        DateTime? EnabledTime = null,
        System.String? ErrorMessage = null,
        System.Int64? InactivityTimeoutInSeconds = null,
        System.Boolean? IsTunnelEnabled = null,
        DateTime? LastActivityTime = null,
        System.Int64? Port = null
    ) 
    {
        if ( EnabledTime != null ) {
            this.EnabledTime = EnabledTime;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( InactivityTimeoutInSeconds != null ) {
            this.InactivityTimeoutInSeconds = InactivityTimeoutInSeconds;
        }
        if ( IsTunnelEnabled != null ) {
            this.IsTunnelEnabled = IsTunnelEnabled;
        }
        if ( LastActivityTime != null ) {
            this.LastActivityTime = LastActivityTime;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        if (this.EnabledTime != null) {
            s += ind + "enabledTime\n" ;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage != null) {
            s += ind + "errorMessage\n" ;
        }
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        if (this.InactivityTimeoutInSeconds != null) {
            s += ind + "inactivityTimeoutInSeconds\n" ;
        }
        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        if (this.IsTunnelEnabled != null) {
            s += ind + "isTunnelEnabled\n" ;
        }
        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        if (this.LastActivityTime != null) {
            s += ind + "lastActivityTime\n" ;
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        if (this.EnabledTime == null && ec.Includes("enabledTime",true))
        {
            this.EnabledTime = new DateTime();
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage == null && ec.Includes("errorMessage",true))
        {
            this.ErrorMessage = "FETCH";
        }
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        if (this.InactivityTimeoutInSeconds == null && ec.Includes("inactivityTimeoutInSeconds",true))
        {
            this.InactivityTimeoutInSeconds = new System.Int64();
        }
        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        if (this.IsTunnelEnabled == null && ec.Includes("isTunnelEnabled",true))
        {
            this.IsTunnelEnabled = true;
        }
        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        if (this.LastActivityTime == null && ec.Includes("lastActivityTime",true))
        {
            this.LastActivityTime = new DateTime();
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        if (this.Port == null && ec.Includes("port",true))
        {
            this.Port = new System.Int64();
        }
    }


    #endregion

    } // class SupportTunnelInfo
    
    #endregion

    public static class ListSupportTunnelInfoExtensions
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
            this List<SupportTunnelInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SupportTunnelInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportTunnelInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SupportTunnelInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types