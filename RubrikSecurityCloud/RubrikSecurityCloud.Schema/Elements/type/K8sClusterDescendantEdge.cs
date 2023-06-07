// K8sClusterDescendantEdge.cs
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
    #region K8sClusterDescendantEdge
    public class K8sClusterDescendantEdge: BaseType
    {
        #region members

        //      C# -> K8sClusterDescendant? Node
        // GraphQL -> node: K8sClusterDescendant! (interface)
        [JsonProperty("node")]
        public K8sClusterDescendant? Node { get; set; }

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }


        #endregion

    #region methods

    public K8sClusterDescendantEdge Set(
        K8sClusterDescendant? Node = null,
        System.String? Cursor = null
    ) 
    {
        if ( Node != null ) {
            this.Node = Node;
        }
        if ( Cursor != null ) {
            this.Cursor = Cursor;
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
        //      C# -> K8sClusterDescendant? Node
        // GraphQL -> node: K8sClusterDescendant! (interface)
        if (this.Node != null) {
            s += ind + "node {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.Node).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            s += ind + "cursor\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> K8sClusterDescendant? Node
        // GraphQL -> node: K8sClusterDescendant! (interface)
        if (this.Node == null && Exploration.Includes(parent + ".node"))
        {
            var impls = new List<K8sClusterDescendant>();
            impls.ApplyExploratoryFieldSpec(parent + ".node");
            this.Node = (K8sClusterDescendant)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor == null && Exploration.Includes(parent + ".cursor", true))
        {
            this.Cursor = "FETCH";
        }
    }


    #endregion

    } // class K8sClusterDescendantEdge
    
    #endregion

    public static class ListK8sClusterDescendantEdgeExtensions
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
            this List<K8sClusterDescendantEdge> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sClusterDescendantEdge> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sClusterDescendantEdge());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types