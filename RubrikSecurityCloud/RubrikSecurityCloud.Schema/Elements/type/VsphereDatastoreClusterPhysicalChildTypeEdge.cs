// VsphereDatastoreClusterPhysicalChildTypeEdge.cs
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
    #region VsphereDatastoreClusterPhysicalChildTypeEdge
    public class VsphereDatastoreClusterPhysicalChildTypeEdge: BaseType
    {
        #region members

        //      C# -> VsphereDatastoreClusterPhysicalChildType? Node
        // GraphQL -> node: VsphereDatastoreClusterPhysicalChildType! (interface)
        [JsonProperty("node")]
        public VsphereDatastoreClusterPhysicalChildType? Node { get; set; }

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereDatastoreClusterPhysicalChildTypeEdge";
    }

    public VsphereDatastoreClusterPhysicalChildTypeEdge Set(
        VsphereDatastoreClusterPhysicalChildType? Node = null,
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> VsphereDatastoreClusterPhysicalChildType? Node
        // GraphQL -> node: VsphereDatastoreClusterPhysicalChildType! (interface)
        if (this.Node != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Node).AsFieldSpec(conf.Child("node"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "VsphereDatastoreClusterPhysicalChildTypeEdge_INTERFACE_FIELD_node: node{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cursor\n" ;
            } else {
                s += ind + "cursor\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VsphereDatastoreClusterPhysicalChildType? Node
        // GraphQL -> node: VsphereDatastoreClusterPhysicalChildType! (interface)
        if (ec.Includes("node",false))
        {
            if(this.Node == null) {

                var impls = new List<VsphereDatastoreClusterPhysicalChildType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("node"));
                this.Node = (VsphereDatastoreClusterPhysicalChildType)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<VsphereDatastoreClusterPhysicalChildType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("node"));
                this.Node = (VsphereDatastoreClusterPhysicalChildType)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Node != null && ec.Excludes("node",false))
        {
            this.Node = null;
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (ec.Includes("cursor",true))
        {
            if(this.Cursor == null) {

                this.Cursor = "FETCH";

            } else {


            }
        }
        else if (this.Cursor != null && ec.Excludes("cursor",true))
        {
            this.Cursor = null;
        }
    }


    #endregion

    } // class VsphereDatastoreClusterPhysicalChildTypeEdge
    
    #endregion

    public static class ListVsphereDatastoreClusterPhysicalChildTypeEdgeExtensions
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
            this List<VsphereDatastoreClusterPhysicalChildTypeEdge> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VsphereDatastoreClusterPhysicalChildTypeEdge> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereDatastoreClusterPhysicalChildTypeEdge> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereDatastoreClusterPhysicalChildTypeEdge());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereDatastoreClusterPhysicalChildTypeEdge> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types