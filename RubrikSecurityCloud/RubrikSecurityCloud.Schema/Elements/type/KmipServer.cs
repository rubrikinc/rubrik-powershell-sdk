// KmipServer.cs
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
    #region KmipServer
    public class KmipServer: BaseType
    {
        #region members

        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> List<CdmKmipServerInfo>? Clusters
        // GraphQL -> clusters: [CdmKmipServerInfo!]! (type)
        [JsonProperty("clusters")]
        public List<CdmKmipServerInfo>? Clusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KmipServer";
    }

    public KmipServer Set(
        System.String? Address = null,
        System.Int32? Port = null,
        List<CdmKmipServerInfo>? Clusters = null
    ) 
    {
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
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
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            s += ind + "address\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> List<CdmKmipServerInfo>? Clusters
        // GraphQL -> clusters: [CdmKmipServerInfo!]! (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusters {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address == null && Exploration.Includes(parent + ".address", true))
        {
            this.Address = "FETCH";
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = Int32.MinValue;
        }
        //      C# -> List<CdmKmipServerInfo>? Clusters
        // GraphQL -> clusters: [CdmKmipServerInfo!]! (type)
        if (this.Clusters == null && Exploration.Includes(parent + ".clusters"))
        {
            this.Clusters = new List<CdmKmipServerInfo>();
            this.Clusters.ApplyExploratoryFieldSpec(parent + ".clusters");
        }
    }


    #endregion

    } // class KmipServer
    
    #endregion

    public static class ListKmipServerExtensions
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
            this List<KmipServer> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KmipServer> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new KmipServer());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types