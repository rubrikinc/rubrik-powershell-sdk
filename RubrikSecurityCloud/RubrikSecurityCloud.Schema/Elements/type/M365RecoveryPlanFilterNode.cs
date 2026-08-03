// M365RecoveryPlanFilterNode.cs
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
    #region M365RecoveryPlanFilterNode
    public class M365RecoveryPlanFilterNode: BaseType
    {
        #region members

        //      C# -> M365RecoveryPlanFilterComposite? Composite
        // GraphQL -> composite: M365RecoveryPlanFilterComposite (type)
        [JsonProperty("composite")]
        public M365RecoveryPlanFilterComposite? Composite { get; set; }

        //      C# -> M365RecoveryPlanFilterLeaf? Leaf
        // GraphQL -> leaf: M365RecoveryPlanFilterLeaf (type)
        [JsonProperty("leaf")]
        public M365RecoveryPlanFilterLeaf? Leaf { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365RecoveryPlanFilterNode";
    }

    public M365RecoveryPlanFilterNode Set(
        M365RecoveryPlanFilterComposite? Composite = null,
        M365RecoveryPlanFilterLeaf? Leaf = null
    ) 
    {
        if ( Composite != null ) {
            this.Composite = Composite;
        }
        if ( Leaf != null ) {
            this.Leaf = Leaf;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> M365RecoveryPlanFilterComposite? Composite
        // GraphQL -> composite: M365RecoveryPlanFilterComposite (type)
        if (this.Composite != null) {
            var fspec = this.Composite.AsFieldSpec(conf.Child("composite"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "composite" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365RecoveryPlanFilterLeaf? Leaf
        // GraphQL -> leaf: M365RecoveryPlanFilterLeaf (type)
        if (this.Leaf != null) {
            var fspec = this.Leaf.AsFieldSpec(conf.Child("leaf"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "leaf" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> M365RecoveryPlanFilterComposite? Composite
        // GraphQL -> composite: M365RecoveryPlanFilterComposite (type)
        if (ec.Includes("composite",false))
        {
            if(this.Composite == null) {

                this.Composite = new M365RecoveryPlanFilterComposite();
                this.Composite.ApplyExploratoryFieldSpec(ec.NewChild("composite"));

            } else {

                this.Composite.ApplyExploratoryFieldSpec(ec.NewChild("composite"));

            }
        }
        else if (this.Composite != null && ec.Excludes("composite",false))
        {
            this.Composite = null;
        }
        //      C# -> M365RecoveryPlanFilterLeaf? Leaf
        // GraphQL -> leaf: M365RecoveryPlanFilterLeaf (type)
        if (ec.Includes("leaf",false))
        {
            if(this.Leaf == null) {

                this.Leaf = new M365RecoveryPlanFilterLeaf();
                this.Leaf.ApplyExploratoryFieldSpec(ec.NewChild("leaf"));

            } else {

                this.Leaf.ApplyExploratoryFieldSpec(ec.NewChild("leaf"));

            }
        }
        else if (this.Leaf != null && ec.Excludes("leaf",false))
        {
            this.Leaf = null;
        }
    }


    #endregion

    } // class M365RecoveryPlanFilterNode
    
    #endregion

    public static class ListM365RecoveryPlanFilterNodeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<M365RecoveryPlanFilterNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365RecoveryPlanFilterNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365RecoveryPlanFilterNode> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365RecoveryPlanFilterNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365RecoveryPlanFilterNode> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types