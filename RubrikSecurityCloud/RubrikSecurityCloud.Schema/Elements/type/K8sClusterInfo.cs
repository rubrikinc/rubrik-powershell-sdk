// K8sClusterInfo.cs
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
    #region K8sClusterInfo
    public class K8sClusterInfo: BaseType
    {
        #region members

        //      C# -> K8sClusterType? Type
        // GraphQL -> type: K8sClusterType! (enum)
        [JsonProperty("type")]
        public K8sClusterType? Type { get; set; }

        //      C# -> System.String? K8sVersion
        // GraphQL -> k8sVersion: String (scalar)
        [JsonProperty("k8sVersion")]
        public System.String? K8sVersion { get; set; }

        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        [JsonProperty("kuprClusterUuid")]
        public System.String? KuprClusterUuid { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> Cluster? AssociatedCdm
        // GraphQL -> associatedCdm: Cluster (type)
        [JsonProperty("associatedCdm")]
        public Cluster? AssociatedCdm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sClusterInfo";
    }

    public K8sClusterInfo Set(
        K8sClusterType? Type = null,
        System.String? K8sVersion = null,
        System.String? KuprClusterUuid = null,
        System.Int32? Port = null,
        Cluster? AssociatedCdm = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( K8sVersion != null ) {
            this.K8sVersion = K8sVersion;
        }
        if ( KuprClusterUuid != null ) {
            this.KuprClusterUuid = KuprClusterUuid;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( AssociatedCdm != null ) {
            this.AssociatedCdm = AssociatedCdm;
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
        //      C# -> K8sClusterType? Type
        // GraphQL -> type: K8sClusterType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? K8sVersion
        // GraphQL -> k8sVersion: String (scalar)
        if (this.K8sVersion != null) {
            s += ind + "k8sVersion\n" ;
        }
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid != null) {
            s += ind + "kuprClusterUuid\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> Cluster? AssociatedCdm
        // GraphQL -> associatedCdm: Cluster (type)
        if (this.AssociatedCdm != null) {
            var fspec = this.AssociatedCdm.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "associatedCdm {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> K8sClusterType? Type
        // GraphQL -> type: K8sClusterType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new K8sClusterType();
        }
        //      C# -> System.String? K8sVersion
        // GraphQL -> k8sVersion: String (scalar)
        if (this.K8sVersion == null && ec.Includes("k8sVersion",true))
        {
            this.K8sVersion = "FETCH";
        }
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid == null && ec.Includes("kuprClusterUuid",true))
        {
            this.KuprClusterUuid = "FETCH";
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && ec.Includes("port",true))
        {
            this.Port = Int32.MinValue;
        }
        //      C# -> Cluster? AssociatedCdm
        // GraphQL -> associatedCdm: Cluster (type)
        if (this.AssociatedCdm == null && ec.Includes("associatedCdm",false))
        {
            this.AssociatedCdm = new Cluster();
            this.AssociatedCdm.ApplyExploratoryFieldSpec(ec.NewChild("associatedCdm"));
        }
    }


    #endregion

    } // class K8sClusterInfo
    
    #endregion

    public static class ListK8sClusterInfoExtensions
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
            this List<K8sClusterInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sClusterInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sClusterInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<K8sClusterInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types