// SapHanaHostObject.cs
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
    #region SapHanaHostObject
    public class SapHanaHostObject: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        [JsonProperty("hostType")]
        public System.String? HostType { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }

        //      C# -> PhysicalHost? SystemHost
        // GraphQL -> systemHost: PhysicalHost (type)
        [JsonProperty("systemHost")]
        public PhysicalHost? SystemHost { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaHostObject";
    }

    public SapHanaHostObject Set(
        System.String? ClusterUuid = null,
        System.String? HostName = null,
        System.String? HostType = null,
        System.String? HostUuid = null,
        System.String? Status = null,
        PhysicalHost? Host = null,
        PhysicalHost? SystemHost = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( SystemHost != null ) {
            this.SystemHost = SystemHost;
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
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        if (this.HostType != null) {
            s += ind + "hostType\n" ;
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid != null) {
            s += ind + "hostUuid\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "host {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PhysicalHost? SystemHost
        // GraphQL -> systemHost: PhysicalHost (type)
        if (this.SystemHost != null) {
            var fspec = this.SystemHost.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "systemHost {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && ec.Includes("hostName",true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        if (this.HostType == null && ec.Includes("hostType",true))
        {
            this.HostType = "FETCH";
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid == null && ec.Includes("hostUuid",true))
        {
            this.HostUuid = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = "FETCH";
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        if (this.Host == null && ec.Includes("host",false))
        {
            this.Host = new PhysicalHost();
            this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));
        }
        //      C# -> PhysicalHost? SystemHost
        // GraphQL -> systemHost: PhysicalHost (type)
        if (this.SystemHost == null && ec.Includes("systemHost",false))
        {
            this.SystemHost = new PhysicalHost();
            this.SystemHost.ApplyExploratoryFieldSpec(ec.NewChild("systemHost"));
        }
    }


    #endregion

    } // class SapHanaHostObject
    
    #endregion

    public static class ListSapHanaHostObjectExtensions
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
            this List<SapHanaHostObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaHostObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaHostObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaHostObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types