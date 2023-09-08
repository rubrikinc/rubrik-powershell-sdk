// K8sSnapshotSummary.cs
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
    #region K8sSnapshotSummary
    public class K8sSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.String? K8SresourceSetName
        // GraphQL -> k8SResourceSetName: String! (scalar)
        [JsonProperty("k8SResourceSetName")]
        public System.String? K8SresourceSetName { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sSnapshotSummary";
    }

    public K8sSnapshotSummary Set(
        System.String? K8SresourceSetName = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( K8SresourceSetName != null ) {
            this.K8SresourceSetName = K8SresourceSetName;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
        //      C# -> System.String? K8SresourceSetName
        // GraphQL -> k8SResourceSetName: String! (scalar)
        if (this.K8SresourceSetName != null) {
            s += ind + "k8SResourceSetName\n" ;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? K8SresourceSetName
        // GraphQL -> k8SResourceSetName: String! (scalar)
        if (this.K8SresourceSetName == null && ec.Includes("k8SResourceSetName",true))
        {
            this.K8SresourceSetName = "FETCH";
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary == null && ec.Includes("baseSnapshotSummary",false))
        {
            this.BaseSnapshotSummary = new BaseSnapshotSummary();
            this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));
        }
    }


    #endregion

    } // class K8sSnapshotSummary
    
    #endregion

    public static class ListK8sSnapshotSummaryExtensions
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
            this List<K8sSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<K8sSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types