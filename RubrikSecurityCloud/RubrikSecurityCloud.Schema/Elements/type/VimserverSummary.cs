// VimserverSummary.cs
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
    #region VimserverSummary
    public class VimserverSummary: BaseType
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VcdClusterId
        // GraphQL -> vcdClusterId: String! (scalar)
        [JsonProperty("vcdClusterId")]
        public System.String? VcdClusterId { get; set; }

        //      C# -> System.String? VcdClusterName
        // GraphQL -> vcdClusterName: String! (scalar)
        [JsonProperty("vcdClusterName")]
        public System.String? VcdClusterName { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public VcdConnectionStatus? ConnectionStatus { get; set; }


        #endregion

    #region methods

    public VimserverSummary Set(
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? VcdClusterId = null,
        System.String? VcdClusterName = null,
        System.String? VcenterId = null,
        VcdConnectionStatus? ConnectionStatus = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VcdClusterId != null ) {
            this.VcdClusterId = VcdClusterId;
        }
        if ( VcdClusterName != null ) {
            this.VcdClusterName = VcdClusterName;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? VcdClusterId
        // GraphQL -> vcdClusterId: String! (scalar)
        if (this.VcdClusterId != null) {
            s += ind + "vcdClusterId\n" ;
        }
        //      C# -> System.String? VcdClusterName
        // GraphQL -> vcdClusterName: String! (scalar)
        if (this.VcdClusterName != null) {
            s += ind + "vcdClusterName\n" ;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId != null) {
            s += ind + "vcenterId\n" ;
        }
        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus {\n" + this.ConnectionStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? VcdClusterId
        // GraphQL -> vcdClusterId: String! (scalar)
        if (this.VcdClusterId == null && Exploration.Includes(parent + ".vcdClusterId", true))
        {
            this.VcdClusterId = "FETCH";
        }
        //      C# -> System.String? VcdClusterName
        // GraphQL -> vcdClusterName: String! (scalar)
        if (this.VcdClusterName == null && Exploration.Includes(parent + ".vcdClusterName", true))
        {
            this.VcdClusterName = "FETCH";
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId == null && Exploration.Includes(parent + ".vcenterId", true))
        {
            this.VcenterId = "FETCH";
        }
        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
        {
            this.ConnectionStatus = new VcdConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(parent + ".connectionStatus");
        }
    }


    #endregion

    } // class VimserverSummary
    
    #endregion

    public static class ListVimserverSummaryExtensions
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
            this List<VimserverSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VimserverSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VimserverSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types