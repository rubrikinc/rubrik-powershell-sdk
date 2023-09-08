// K8sClusterPortsInfo.cs
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
    #region K8sClusterPortsInfo
    public class K8sClusterPortsInfo: BaseType
    {
        #region members

        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        [JsonProperty("portRangeType")]
        public KuprClusterPortsType? PortRangeType { get; set; }

        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        [JsonProperty("kuprClusterUuid")]
        public System.String? KuprClusterUuid { get; set; }

        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        [JsonProperty("maxPort")]
        public System.Int32? MaxPort { get; set; }

        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        [JsonProperty("minPort")]
        public System.Int32? MinPort { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sClusterPortsInfo";
    }

    public K8sClusterPortsInfo Set(
        KuprClusterPortsType? PortRangeType = null,
        System.String? KuprClusterUuid = null,
        System.Int32? MaxPort = null,
        System.Int32? MinPort = null
    ) 
    {
        if ( PortRangeType != null ) {
            this.PortRangeType = PortRangeType;
        }
        if ( KuprClusterUuid != null ) {
            this.KuprClusterUuid = KuprClusterUuid;
        }
        if ( MaxPort != null ) {
            this.MaxPort = MaxPort;
        }
        if ( MinPort != null ) {
            this.MinPort = MinPort;
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
        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        if (this.PortRangeType != null) {
            s += ind + "portRangeType\n" ;
        }
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid != null) {
            s += ind + "kuprClusterUuid\n" ;
        }
        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        if (this.MaxPort != null) {
            s += ind + "maxPort\n" ;
        }
        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        if (this.MinPort != null) {
            s += ind + "minPort\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        if (this.PortRangeType == null && ec.Includes("portRangeType",true))
        {
            this.PortRangeType = new KuprClusterPortsType();
        }
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid == null && ec.Includes("kuprClusterUuid",true))
        {
            this.KuprClusterUuid = "FETCH";
        }
        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        if (this.MaxPort == null && ec.Includes("maxPort",true))
        {
            this.MaxPort = Int32.MinValue;
        }
        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        if (this.MinPort == null && ec.Includes("minPort",true))
        {
            this.MinPort = Int32.MinValue;
        }
    }


    #endregion

    } // class K8sClusterPortsInfo
    
    #endregion

    public static class ListK8sClusterPortsInfoExtensions
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
            this List<K8sClusterPortsInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sClusterPortsInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sClusterPortsInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<K8sClusterPortsInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types