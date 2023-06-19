// CdmOracleRacNode.cs
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
    #region CdmOracleRacNode
    public class CdmOracleRacNode: BaseType
    {
        #region members

        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        [JsonProperty("status")]
        public HostConnectivityStatusEnum? Status { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }


        #endregion

    #region methods

    public CdmOracleRacNode Set(
        HostConnectivityStatusEnum? Status = null,
        System.String? HostFid = null,
        System.String? NodeName = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
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
        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        if (this.HostFid != null) {
            s += ind + "hostFid\n" ;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            s += ind + "nodeName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new HostConnectivityStatusEnum();
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        if (this.HostFid == null && Exploration.Includes(parent + ".hostFid", true))
        {
            this.HostFid = "FETCH";
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName == null && Exploration.Includes(parent + ".nodeName", true))
        {
            this.NodeName = "FETCH";
        }
    }


    #endregion

    } // class CdmOracleRacNode
    
    #endregion

    public static class ListCdmOracleRacNodeExtensions
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
            this List<CdmOracleRacNode> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmOracleRacNode> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmOracleRacNode());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types