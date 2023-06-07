// OrgNetwork.cs
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
    #region OrgNetwork
    public class OrgNetwork: BaseType
    {
        #region members

        //      C# -> List<System.String>? LiveMountIps
        // GraphQL -> liveMountIps: [String!]! (scalar)
        [JsonProperty("liveMountIps")]
        public List<System.String>? LiveMountIps { get; set; }

        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: UUID! (scalar)
        [JsonProperty("orgNetworkId")]
        public System.String? OrgNetworkId { get; set; }

        //      C# -> System.String? OrgNetworkName
        // GraphQL -> orgNetworkName: String! (scalar)
        [JsonProperty("orgNetworkName")]
        public System.String? OrgNetworkName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<EnvoyInfo>? EnvoyInfoList
        // GraphQL -> envoyInfoList: [EnvoyInfo!]! (type)
        [JsonProperty("envoyInfoList")]
        public List<EnvoyInfo>? EnvoyInfoList { get; set; }

        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        [JsonProperty("org")]
        public Org? Org { get; set; }


        #endregion

    #region methods

    public OrgNetwork Set(
        List<System.String>? LiveMountIps = null,
        System.String? OrgNetworkId = null,
        System.String? OrgNetworkName = null,
        Cluster? Cluster = null,
        List<EnvoyInfo>? EnvoyInfoList = null,
        Org? Org = null
    ) 
    {
        if ( LiveMountIps != null ) {
            this.LiveMountIps = LiveMountIps;
        }
        if ( OrgNetworkId != null ) {
            this.OrgNetworkId = OrgNetworkId;
        }
        if ( OrgNetworkName != null ) {
            this.OrgNetworkName = OrgNetworkName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( EnvoyInfoList != null ) {
            this.EnvoyInfoList = EnvoyInfoList;
        }
        if ( Org != null ) {
            this.Org = Org;
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
        //      C# -> List<System.String>? LiveMountIps
        // GraphQL -> liveMountIps: [String!]! (scalar)
        if (this.LiveMountIps != null) {
            s += ind + "liveMountIps\n" ;
        }
        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: UUID! (scalar)
        if (this.OrgNetworkId != null) {
            s += ind + "orgNetworkId\n" ;
        }
        //      C# -> System.String? OrgNetworkName
        // GraphQL -> orgNetworkName: String! (scalar)
        if (this.OrgNetworkName != null) {
            s += ind + "orgNetworkName\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<EnvoyInfo>? EnvoyInfoList
        // GraphQL -> envoyInfoList: [EnvoyInfo!]! (type)
        if (this.EnvoyInfoList != null) {
            s += ind + "envoyInfoList {\n" + this.EnvoyInfoList.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        if (this.Org != null) {
            s += ind + "org {\n" + this.Org.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? LiveMountIps
        // GraphQL -> liveMountIps: [String!]! (scalar)
        if (this.LiveMountIps == null && Exploration.Includes(parent + ".liveMountIps", true))
        {
            this.LiveMountIps = new List<System.String>();
        }
        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: UUID! (scalar)
        if (this.OrgNetworkId == null && Exploration.Includes(parent + ".orgNetworkId", true))
        {
            this.OrgNetworkId = "FETCH";
        }
        //      C# -> System.String? OrgNetworkName
        // GraphQL -> orgNetworkName: String! (scalar)
        if (this.OrgNetworkName == null && Exploration.Includes(parent + ".orgNetworkName", true))
        {
            this.OrgNetworkName = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> List<EnvoyInfo>? EnvoyInfoList
        // GraphQL -> envoyInfoList: [EnvoyInfo!]! (type)
        if (this.EnvoyInfoList == null && Exploration.Includes(parent + ".envoyInfoList"))
        {
            this.EnvoyInfoList = new List<EnvoyInfo>();
            this.EnvoyInfoList.ApplyExploratoryFieldSpec(parent + ".envoyInfoList");
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        if (this.Org == null && Exploration.Includes(parent + ".org"))
        {
            this.Org = new Org();
            this.Org.ApplyExploratoryFieldSpec(parent + ".org");
        }
    }


    #endregion

    } // class OrgNetwork
    
    #endregion

    public static class ListOrgNetworkExtensions
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
            this List<OrgNetwork> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OrgNetwork> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OrgNetwork());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types