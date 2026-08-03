// M365RecoveryPlanFilterComposite.cs
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
    #region M365RecoveryPlanFilterComposite
    public class M365RecoveryPlanFilterComposite: BaseType
    {
        #region members

        //      C# -> RecoveryPlanFilterOp? Op
        // GraphQL -> op: RecoveryPlanFilterOp! (enum)
        [JsonProperty("op")]
        public RecoveryPlanFilterOp? Op { get; set; }

        //      C# -> List<M365RecoveryPlanFilterNode>? Children
        // GraphQL -> children: [M365RecoveryPlanFilterNode!]! (type)
        [JsonProperty("children")]
        public List<M365RecoveryPlanFilterNode>? Children { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365RecoveryPlanFilterComposite";
    }

    public M365RecoveryPlanFilterComposite Set(
        RecoveryPlanFilterOp? Op = null,
        List<M365RecoveryPlanFilterNode>? Children = null
    ) 
    {
        if ( Op != null ) {
            this.Op = Op;
        }
        if ( Children != null ) {
            this.Children = Children;
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
        //      C# -> RecoveryPlanFilterOp? Op
        // GraphQL -> op: RecoveryPlanFilterOp! (enum)
        if (this.Op != null) {
            if (conf.Flat) {
                s += conf.Prefix + "op\n" ;
            } else {
                s += ind + "op\n" ;
            }
        }
        //      C# -> List<M365RecoveryPlanFilterNode>? Children
        // GraphQL -> children: [M365RecoveryPlanFilterNode!]! (type)
        if (this.Children != null) {
            var fspec = this.Children.AsFieldSpec(conf.Child("children"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "children" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryPlanFilterOp? Op
        // GraphQL -> op: RecoveryPlanFilterOp! (enum)
        if (ec.Includes("op",true))
        {
            if(this.Op == null) {

                this.Op = new RecoveryPlanFilterOp();

            } else {


            }
        }
        else if (this.Op != null && ec.Excludes("op",true))
        {
            this.Op = null;
        }
        //      C# -> List<M365RecoveryPlanFilterNode>? Children
        // GraphQL -> children: [M365RecoveryPlanFilterNode!]! (type)
        if (ec.Includes("children",false))
        {
            if(this.Children == null) {

                this.Children = new List<M365RecoveryPlanFilterNode>();
                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            } else {

                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            }
        }
        else if (this.Children != null && ec.Excludes("children",false))
        {
            this.Children = null;
        }
    }


    #endregion

    } // class M365RecoveryPlanFilterComposite
    
    #endregion

    public static class ListM365RecoveryPlanFilterCompositeExtensions
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
            this List<M365RecoveryPlanFilterComposite> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365RecoveryPlanFilterComposite> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365RecoveryPlanFilterComposite> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365RecoveryPlanFilterComposite());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365RecoveryPlanFilterComposite> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types