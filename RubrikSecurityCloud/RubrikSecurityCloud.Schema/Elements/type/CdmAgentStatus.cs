// CdmAgentStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    #region CdmAgentStatus
    public class CdmAgentStatus: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AgentStatus
            // GraphQL -> agentStatus: String! (scalar)
            if (this.AgentStatus != null)
            {
                 s += ind + "agentStatus\n";

            }
            //      C# -> System.String? DisconnectReason
            // GraphQL -> disconnectReason: String (scalar)
            if (this.DisconnectReason != null)
            {
                 s += ind + "disconnectReason\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AgentStatus
            // GraphQL -> agentStatus: String! (scalar)
            if (this.AgentStatus == null && Exploration.Includes(parent + ".agentStatus$"))
            {
                this.AgentStatus = new System.String("FETCH");
            }
            //      C# -> System.String? DisconnectReason
            // GraphQL -> disconnectReason: String (scalar)
            if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason$"))
            {
                this.DisconnectReason = new System.String("FETCH");
            }
        }


    #endregion

    } // class CdmAgentStatus
    #endregion

    public static class ListCdmAgentStatusExtensions
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
            this List<CdmAgentStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmAgentStatus> list, 
            String parent = "")
        {
            var item = new CdmAgentStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types