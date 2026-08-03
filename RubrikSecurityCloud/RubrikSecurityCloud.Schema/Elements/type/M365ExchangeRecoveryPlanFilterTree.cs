// M365ExchangeRecoveryPlanFilterTree.cs
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
    #region M365ExchangeRecoveryPlanFilterTree
    public class M365ExchangeRecoveryPlanFilterTree: BaseType
    {
        #region members

        //      C# -> M365RecoveryPlanFilterNode? Root
        // GraphQL -> root: M365RecoveryPlanFilterNode! (type)
        [JsonProperty("root")]
        public M365RecoveryPlanFilterNode? Root { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365ExchangeRecoveryPlanFilterTree";
    }

    public M365ExchangeRecoveryPlanFilterTree Set(
        M365RecoveryPlanFilterNode? Root = null
    ) 
    {
        if ( Root != null ) {
            this.Root = Root;
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
        //      C# -> M365RecoveryPlanFilterNode? Root
        // GraphQL -> root: M365RecoveryPlanFilterNode! (type)
        if (this.Root != null) {
            var fspec = this.Root.AsFieldSpec(conf.Child("root"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "root" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> M365RecoveryPlanFilterNode? Root
        // GraphQL -> root: M365RecoveryPlanFilterNode! (type)
        if (ec.Includes("root",false))
        {
            if(this.Root == null) {

                this.Root = new M365RecoveryPlanFilterNode();
                this.Root.ApplyExploratoryFieldSpec(ec.NewChild("root"));

            } else {

                this.Root.ApplyExploratoryFieldSpec(ec.NewChild("root"));

            }
        }
        else if (this.Root != null && ec.Excludes("root",false))
        {
            this.Root = null;
        }
    }


    #endregion

    } // class M365ExchangeRecoveryPlanFilterTree
    
    #endregion

    public static class ListM365ExchangeRecoveryPlanFilterTreeExtensions
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
            this List<M365ExchangeRecoveryPlanFilterTree> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365ExchangeRecoveryPlanFilterTree> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365ExchangeRecoveryPlanFilterTree> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365ExchangeRecoveryPlanFilterTree());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365ExchangeRecoveryPlanFilterTree> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types