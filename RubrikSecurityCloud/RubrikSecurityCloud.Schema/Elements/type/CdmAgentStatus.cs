// CdmAgentStatus.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CdmAgentStatus
    public class CdmAgentStatus: BaseType
    {
        #region members

        //      C# -> System.String? AgentStatus
        // GraphQL -> agentStatus: String! (scalar)
        [JsonProperty("agentStatus")]
        public System.String? AgentStatus { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public CdmAgentStatus Set(
        System.String? AgentStatus = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
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
        //      C# -> System.String? AgentStatus
        // GraphQL -> agentStatus: String! (scalar)
        if (this.AgentStatus != null) {
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
        //      C# -> System.String? AgentStatus
        // GraphQL -> agentStatus: String! (scalar)
        if (this.AgentStatus == null && Exploration.Includes(parent + ".agentStatus", true))
        {
            this.AgentStatus = new System.String("FETCH");
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason", true))
        {
            this.DisconnectReason = new System.String("FETCH");
        }
    }


    #endregion

    } // class CdmAgentStatus
    
    #endregion

    public static class ListCdmAgentStatusExtensions
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
            this List<CdmAgentStatus> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmAgentStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmAgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types