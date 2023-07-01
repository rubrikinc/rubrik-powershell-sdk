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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region NodeStatus
    public class NodeStatus: BaseType
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

    public override string GetGqlTypeName() {
        return "NodeStatus";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (this.BrikId != null) {
            s += ind + "brikId\n" ;
        }
        //      C# -> System.Boolean? HasUnavailableDisks
        // GraphQL -> hasUnavailableDisks: Boolean (scalar)
        if (this.HasUnavailableDisks != null) {
            s += ind + "hasUnavailableDisks\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress != null) {
            s += ind + "ipAddress\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> SupportTunnelInfo? SupportTunnel
        // GraphQL -> supportTunnel: SupportTunnelInfo (type)
        if (this.SupportTunnel != null) {
            var fspec = this.SupportTunnel.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "supportTunnel {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (this.BrikId == null && Exploration.Includes(parent + ".brikId", true))
        {
            this.BrikId = "FETCH";
        }
        //      C# -> System.Boolean? HasUnavailableDisks
        // GraphQL -> hasUnavailableDisks: Boolean (scalar)
        if (this.HasUnavailableDisks == null && Exploration.Includes(parent + ".hasUnavailableDisks", true))
        {
            this.HasUnavailableDisks = true;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress", true))
        {
            this.IpAddress = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> SupportTunnelInfo? SupportTunnel
        // GraphQL -> supportTunnel: SupportTunnelInfo (type)
        if (this.SupportTunnel == null && Exploration.Includes(parent + ".supportTunnel"))
        {
            this.SupportTunnel = new SupportTunnelInfo();
            this.SupportTunnel.ApplyExploratoryFieldSpec(parent + ".supportTunnel");
        }
    }


    #endregion

    } // class NodeStatus
    
    #endregion

    public static class ListNodeStatusExtensions
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
            this List<NodeStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NodeStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types