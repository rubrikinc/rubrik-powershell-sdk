// VsphereFolderLogicalChildTypeEdge.cs
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
    #region VsphereFolderLogicalChildTypeEdge
    public class VsphereFolderLogicalChildTypeEdge: BaseType
    {
        #region members

        //      C# -> VsphereFolderLogicalChildType? Node
        // GraphQL -> node: VsphereFolderLogicalChildType! (interface)
        [JsonProperty("node")]
        public VsphereFolderLogicalChildType? Node { get; set; }

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }


        #endregion

    #region methods

    public VsphereFolderLogicalChildTypeEdge Set(
        VsphereFolderLogicalChildType? Node = null,
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
        //      C# -> VsphereFolderLogicalChildType? Node
        // GraphQL -> node: VsphereFolderLogicalChildType! (interface)
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
        //      C# -> VsphereFolderLogicalChildType? Node
        // GraphQL -> node: VsphereFolderLogicalChildType! (interface)
        if (this.Node == null && Exploration.Includes(parent + ".node"))
        {
            var impls = new List<VsphereFolderLogicalChildType>();
            impls.ApplyExploratoryFieldSpec(parent + ".node");
            this.Node = (VsphereFolderLogicalChildType)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor == null && Exploration.Includes(parent + ".cursor", true))
        {
            this.Cursor = "FETCH";
        }
    }


    #endregion

    } // class VsphereFolderLogicalChildTypeEdge
    
    #endregion

    public static class ListVsphereFolderLogicalChildTypeEdgeExtensions
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
            this List<VsphereFolderLogicalChildTypeEdge> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereFolderLogicalChildTypeEdge> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereFolderLogicalChildTypeEdge());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types