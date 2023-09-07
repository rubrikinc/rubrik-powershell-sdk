// CdmNodeDetail.cs
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
    #region CdmNodeDetail
    public class CdmNodeDetail: BaseType
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DataIpAddress
        // GraphQL -> dataIpAddress: String! (scalar)
        [JsonProperty("dataIpAddress")]
        public System.String? DataIpAddress { get; set; }

        //      C# -> System.String? IpmiIpAddress
        // GraphQL -> ipmiIpAddress: String (scalar)
        [JsonProperty("ipmiIpAddress")]
        public System.String? IpmiIpAddress { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmNodeDetail";
    }

    public CdmNodeDetail Set(
        System.String? ClusterId = null,
        System.String? DataIpAddress = null,
        System.String? IpmiIpAddress = null,
        System.String? NodeId = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DataIpAddress != null ) {
            this.DataIpAddress = DataIpAddress;
        }
        if ( IpmiIpAddress != null ) {
            this.IpmiIpAddress = IpmiIpAddress;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
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
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? DataIpAddress
        // GraphQL -> dataIpAddress: String! (scalar)
        if (this.DataIpAddress != null) {
            s += ind + "dataIpAddress\n" ;
        }
        //      C# -> System.String? IpmiIpAddress
        // GraphQL -> ipmiIpAddress: String (scalar)
        if (this.IpmiIpAddress != null) {
            s += ind + "ipmiIpAddress\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && ec.Includes("clusterId",true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? DataIpAddress
        // GraphQL -> dataIpAddress: String! (scalar)
        if (this.DataIpAddress == null && ec.Includes("dataIpAddress",true))
        {
            this.DataIpAddress = "FETCH";
        }
        //      C# -> System.String? IpmiIpAddress
        // GraphQL -> ipmiIpAddress: String (scalar)
        if (this.IpmiIpAddress == null && ec.Includes("ipmiIpAddress",true))
        {
            this.IpmiIpAddress = "FETCH";
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && ec.Includes("nodeId",true))
        {
            this.NodeId = "FETCH";
        }
    }


    #endregion

    } // class CdmNodeDetail
    
    #endregion

    public static class ListCdmNodeDetailExtensions
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
            this List<CdmNodeDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmNodeDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmNodeDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CdmNodeDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types