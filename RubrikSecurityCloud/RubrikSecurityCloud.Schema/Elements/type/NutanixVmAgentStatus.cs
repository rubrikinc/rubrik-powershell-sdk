// NutanixVmAgentStatus.cs
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
    #region NutanixVmAgentStatus
    public class NutanixVmAgentStatus: IFragment
    {
        #region members
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }

        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public NutanixVmAgentConnectionStatus? ConnectionStatus { get; set; }

        #endregion

    #region methods

    public NutanixVmAgentStatus Set(
        System.String? DisconnectReason = null,
        NutanixVmAgentConnectionStatus? ConnectionStatus = null
    ) 
    {
        if ( DisconnectReason != null ) {
            this.DisconnectReason = DisconnectReason;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
            //      C# -> System.String? DisconnectReason
            // GraphQL -> disconnectReason: String (scalar)
            if (this.DisconnectReason != null)
            {
                 s += ind + "disconnectReason\n";

            }
            //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DisconnectReason
            // GraphQL -> disconnectReason: String (scalar)
            if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason$"))
            {
                this.DisconnectReason = new System.String("FETCH");
            }
            //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus$"))
            {
                this.ConnectionStatus = new NutanixVmAgentConnectionStatus();
            }
        }


    #endregion

    } // class NutanixVmAgentStatus
    #endregion

    public static class ListNutanixVmAgentStatusExtensions
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
            this List<NutanixVmAgentStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixVmAgentStatus> list, 
            String parent = "")
        {
            var item = new NutanixVmAgentStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types