// HypervVmAgentStatus.cs
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
    #region HypervVmAgentStatus
    public class HypervVmAgentStatus: BaseType
    {
        #region members

        //      C# -> HypervVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HypervVmAgentConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public HypervVmAgentConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public HypervVmAgentStatus Set(
        HypervVmAgentConnectionStatus? ConnectionStatus = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( DisconnectReason != null ) {
            this.DisconnectReason = DisconnectReason;
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
        //      C# -> HypervVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HypervVmAgentConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason != null) {
            s += ind + "disconnectReason\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HypervVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HypervVmAgentConnectionStatus! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new HypervVmAgentConnectionStatus();
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason", true))
        {
            this.DisconnectReason = "FETCH";
        }
    }


    #endregion

    } // class HypervVmAgentStatus
    
    #endregion

    public static class ListHypervVmAgentStatusExtensions
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
            this List<HypervVmAgentStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervVmAgentStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVmAgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types