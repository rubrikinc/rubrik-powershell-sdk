// NodeStatus.cs
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
    #region NodeStatus
    public class NodeStatus: IFragment
    {
        #region members
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        [JsonProperty("brikId")]
        public System.String? BrikId { get; set; }

        //      C# -> System.Boolean? HasUnavailableDisks
        // GraphQL -> hasUnavailableDisks: Boolean (scalar)
        [JsonProperty("hasUnavailableDisks")]
        public System.Boolean? HasUnavailableDisks { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> SupportTunnelInfo? SupportTunnel
        // GraphQL -> supportTunnel: SupportTunnelInfo (type)
        [JsonProperty("supportTunnel")]
        public SupportTunnelInfo? SupportTunnel { get; set; }

        #endregion

    #region methods

    public NodeStatus Set(
        System.String? BrikId = null,
        System.Boolean? HasUnavailableDisks = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? IpAddress = null,
        System.String? Status = null,
        SupportTunnelInfo? SupportTunnel = null
    ) 
    {
        if ( BrikId != null ) {
            this.BrikId = BrikId;
        }
        if ( HasUnavailableDisks != null ) {
            this.HasUnavailableDisks = HasUnavailableDisks;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SupportTunnel != null ) {
            this.SupportTunnel = SupportTunnel;
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
            //      C# -> System.String? BrikId
            // GraphQL -> brikId: String! (scalar)
            if (this.BrikId != null)
            {
                 s += ind + "brikId\n";

            }
            //      C# -> System.Boolean? HasUnavailableDisks
            // GraphQL -> hasUnavailableDisks: Boolean (scalar)
            if (this.HasUnavailableDisks != null)
            {
                 s += ind + "hasUnavailableDisks\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String (scalar)
            if (this.IpAddress != null)
            {
                 s += ind + "ipAddress\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> SupportTunnelInfo? SupportTunnel
            // GraphQL -> supportTunnel: SupportTunnelInfo (type)
            if (this.SupportTunnel != null)
            {
                 s += ind + "supportTunnel\n";

                 s += ind + "{\n" + 
                 this.SupportTunnel.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BrikId
            // GraphQL -> brikId: String! (scalar)
            if (this.BrikId == null && Exploration.Includes(parent + ".brikId$"))
            {
                this.BrikId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasUnavailableDisks
            // GraphQL -> hasUnavailableDisks: Boolean (scalar)
            if (this.HasUnavailableDisks == null && Exploration.Includes(parent + ".hasUnavailableDisks$"))
            {
                this.HasUnavailableDisks = new System.Boolean();
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String (scalar)
            if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress$"))
            {
                this.IpAddress = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> SupportTunnelInfo? SupportTunnel
            // GraphQL -> supportTunnel: SupportTunnelInfo (type)
            if (this.SupportTunnel == null && Exploration.Includes(parent + ".supportTunnel"))
            {
                this.SupportTunnel = new SupportTunnelInfo();
                this.SupportTunnel.ApplyExploratoryFragment(parent + ".supportTunnel");
            }
        }


    #endregion

    } // class NodeStatus
    #endregion

    public static class ListNodeStatusExtensions
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
            this List<NodeStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NodeStatus> list, 
            String parent = "")
        {
            var item = new NodeStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types