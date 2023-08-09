// CdmMongoNode.cs
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
    #region CdmMongoNode
    public class CdmMongoNode: BaseType
    {
        #region members

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: UUID! (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMongoNode";
    }

    public CdmMongoNode Set(
        System.String? Host = null,
        System.String? HostFid = null,
        System.Int32? Port = null
    ) 
    {
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host != null) {
            s += ind + "host\n" ;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: UUID! (scalar)
        if (this.HostFid != null) {
            s += ind + "hostFid\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host == null && Exploration.Includes(parent + ".host", true))
        {
            this.Host = "FETCH";
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: UUID! (scalar)
        if (this.HostFid == null && Exploration.Includes(parent + ".hostFid", true))
        {
            this.HostFid = "FETCH";
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = Int32.MinValue;
        }
    }


    #endregion

    } // class CdmMongoNode
    
    #endregion

    public static class ListCdmMongoNodeExtensions
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
            this List<CdmMongoNode> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmMongoNode> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMongoNode());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types