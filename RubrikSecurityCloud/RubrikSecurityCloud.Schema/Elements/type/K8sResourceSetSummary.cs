// K8sResourceSetSummary.cs
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
    #region K8sResourceSetSummary
    public class K8sResourceSetSummary: BaseType
    {
        #region members

        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        [JsonProperty("definition")]
        public System.String? Definition { get; set; }

        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!]! (scalar)
        [JsonProperty("hookConfigs")]
        public List<System.String>? HookConfigs { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? K8SclusterUuid
        // GraphQL -> k8SClusterUuid: String (scalar)
        [JsonProperty("k8SClusterUuid")]
        public System.String? K8SclusterUuid { get; set; }

        //      C# -> System.String? K8Snamespace
        // GraphQL -> k8SNamespace: String (scalar)
        [JsonProperty("k8SNamespace")]
        public System.String? K8Snamespace { get; set; }

        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String (scalar)
        [JsonProperty("kubernetesClusterUuid")]
        public System.String? KubernetesClusterUuid { get; set; }

        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        [JsonProperty("kubernetesNamespace")]
        public System.String? KubernetesNamespace { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        [JsonProperty("rsType")]
        public System.String? RsType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sResourceSetSummary";
    }

    public K8sResourceSetSummary Set(
        System.String? Definition = null,
        List<System.String>? HookConfigs = null,
        System.String? Id = null,
        System.String? K8SclusterUuid = null,
        System.String? K8Snamespace = null,
        System.String? KubernetesClusterUuid = null,
        System.String? KubernetesNamespace = null,
        System.String? Name = null,
        System.String? RsType = null
    ) 
    {
        if ( Definition != null ) {
            this.Definition = Definition;
        }
        if ( HookConfigs != null ) {
            this.HookConfigs = HookConfigs;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( K8SclusterUuid != null ) {
            this.K8SclusterUuid = K8SclusterUuid;
        }
        if ( K8Snamespace != null ) {
            this.K8Snamespace = K8Snamespace;
        }
        if ( KubernetesClusterUuid != null ) {
            this.KubernetesClusterUuid = KubernetesClusterUuid;
        }
        if ( KubernetesNamespace != null ) {
            this.KubernetesNamespace = KubernetesNamespace;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RsType != null ) {
            this.RsType = RsType;
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
        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        if (this.Definition != null) {
            s += ind + "definition\n" ;
        }
        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!]! (scalar)
        if (this.HookConfigs != null) {
            s += ind + "hookConfigs\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? K8SclusterUuid
        // GraphQL -> k8SClusterUuid: String (scalar)
        if (this.K8SclusterUuid != null) {
            s += ind + "k8SClusterUuid\n" ;
        }
        //      C# -> System.String? K8Snamespace
        // GraphQL -> k8SNamespace: String (scalar)
        if (this.K8Snamespace != null) {
            s += ind + "k8SNamespace\n" ;
        }
        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String (scalar)
        if (this.KubernetesClusterUuid != null) {
            s += ind + "kubernetesClusterUuid\n" ;
        }
        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        if (this.KubernetesNamespace != null) {
            s += ind + "kubernetesNamespace\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        if (this.RsType != null) {
            s += ind + "rsType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Definition
        // GraphQL -> definition: String! (scalar)
        if (this.Definition == null && Exploration.Includes(parent + ".definition", true))
        {
            this.Definition = "FETCH";
        }
        //      C# -> List<System.String>? HookConfigs
        // GraphQL -> hookConfigs: [String!]! (scalar)
        if (this.HookConfigs == null && Exploration.Includes(parent + ".hookConfigs", true))
        {
            this.HookConfigs = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? K8SclusterUuid
        // GraphQL -> k8SClusterUuid: String (scalar)
        if (this.K8SclusterUuid == null && Exploration.Includes(parent + ".k8SClusterUuid", true))
        {
            this.K8SclusterUuid = "FETCH";
        }
        //      C# -> System.String? K8Snamespace
        // GraphQL -> k8SNamespace: String (scalar)
        if (this.K8Snamespace == null && Exploration.Includes(parent + ".k8SNamespace", true))
        {
            this.K8Snamespace = "FETCH";
        }
        //      C# -> System.String? KubernetesClusterUuid
        // GraphQL -> kubernetesClusterUuid: String (scalar)
        if (this.KubernetesClusterUuid == null && Exploration.Includes(parent + ".kubernetesClusterUuid", true))
        {
            this.KubernetesClusterUuid = "FETCH";
        }
        //      C# -> System.String? KubernetesNamespace
        // GraphQL -> kubernetesNamespace: String (scalar)
        if (this.KubernetesNamespace == null && Exploration.Includes(parent + ".kubernetesNamespace", true))
        {
            this.KubernetesNamespace = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? RsType
        // GraphQL -> rsType: String! (scalar)
        if (this.RsType == null && Exploration.Includes(parent + ".rsType", true))
        {
            this.RsType = "FETCH";
        }
    }


    #endregion

    } // class K8sResourceSetSummary
    
    #endregion

    public static class ListK8sResourceSetSummaryExtensions
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
            this List<K8sResourceSetSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sResourceSetSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sResourceSetSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types