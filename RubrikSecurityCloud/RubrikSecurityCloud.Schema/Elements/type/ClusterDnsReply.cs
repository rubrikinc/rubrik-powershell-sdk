// ClusterDnsReply.cs
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
    #region ClusterDnsReply
    public class ClusterDnsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        [JsonProperty("domains")]
        public List<System.String>? Domains { get; set; }

        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        [JsonProperty("servers")]
        public List<System.String>? Servers { get; set; }


        #endregion

    #region methods

    public ClusterDnsReply Set(
        List<System.String>? Domains = null,
        List<System.String>? Servers = null
    ) 
    {
        if ( Domains != null ) {
            this.Domains = Domains;
        }
        if ( Servers != null ) {
            this.Servers = Servers;
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
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        if (this.Domains != null) {
            s += ind + "domains\n" ;
        }
        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        if (this.Servers != null) {
            s += ind + "servers\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        if (this.Domains == null && Exploration.Includes(parent + ".domains", true))
        {
            this.Domains = new List<System.String>();
        }
        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        if (this.Servers == null && Exploration.Includes(parent + ".servers", true))
        {
            this.Servers = new List<System.String>();
        }
    }


    #endregion

    } // class ClusterDnsReply
    
    #endregion

    public static class ListClusterDnsReplyExtensions
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
            this List<ClusterDnsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterDnsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterDnsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types