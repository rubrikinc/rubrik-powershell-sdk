// AgentStatus.cs
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
    #region AgentStatus
    public class AgentStatus: BaseType
    {
        #region members

        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        [JsonProperty("agentStatus")]
        public AgentConnectionStatus? AgentStatusField { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AgentStatus";
    }

    public AgentStatus Set(
        AgentConnectionStatus? AgentStatusField = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( AgentStatusField != null ) {
            this.AgentStatusField = AgentStatusField;
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
        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        if (this.AgentStatusField != null) {
            s += ind + "agentStatus\n" ;
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
        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        if (this.AgentStatusField == null && Exploration.Includes(parent + ".agentStatus", true))
        {
            this.AgentStatusField = new AgentConnectionStatus();
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason", true))
        {
            this.DisconnectReason = "FETCH";
        }
    }


    #endregion

    } // class AgentStatus
    
    #endregion

    public static class ListAgentStatusExtensions
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
            this List<AgentStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AgentStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types