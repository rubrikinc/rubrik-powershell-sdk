// HierarchyObjectSlaAssignment.cs
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
    #region HierarchyObjectSlaAssignment
    public class HierarchyObjectSlaAssignment: BaseType
    {
        #region members

        //      C# -> SlaAssignmentType? AssignmentType
        // GraphQL -> assignmentType: SlaAssignmentType! (enum)
        [JsonProperty("assignmentType")]
        public SlaAssignmentType? AssignmentType { get; set; }

        //      C# -> EffectiveSlaAssignment? EffectiveSla
        // GraphQL -> effectiveSla: EffectiveSlaAssignment (type)
        [JsonProperty("effectiveSla")]
        public EffectiveSlaAssignment? EffectiveSla { get; set; }

        //      C# -> SlaAssignmentDetail? Sla
        // GraphQL -> sla: SlaAssignmentDetail (type)
        [JsonProperty("sla")]
        public SlaAssignmentDetail? Sla { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HierarchyObjectSlaAssignment";
    }

    public HierarchyObjectSlaAssignment Set(
        SlaAssignmentType? AssignmentType = null,
        EffectiveSlaAssignment? EffectiveSla = null,
        SlaAssignmentDetail? Sla = null
    ) 
    {
        if ( AssignmentType != null ) {
            this.AssignmentType = AssignmentType;
        }
        if ( EffectiveSla != null ) {
            this.EffectiveSla = EffectiveSla;
        }
        if ( Sla != null ) {
            this.Sla = Sla;
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
        //      C# -> SlaAssignmentType? AssignmentType
        // GraphQL -> assignmentType: SlaAssignmentType! (enum)
        if (this.AssignmentType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "assignmentType\n" ;
            } else {
                s += ind + "assignmentType\n" ;
            }
        }
        //      C# -> EffectiveSlaAssignment? EffectiveSla
        // GraphQL -> effectiveSla: EffectiveSlaAssignment (type)
        if (this.EffectiveSla != null) {
            var fspec = this.EffectiveSla.AsFieldSpec(conf.Child("effectiveSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignmentDetail? Sla
        // GraphQL -> sla: SlaAssignmentDetail (type)
        if (this.Sla != null) {
            var fspec = this.Sla.AsFieldSpec(conf.Child("sla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SlaAssignmentType? AssignmentType
        // GraphQL -> assignmentType: SlaAssignmentType! (enum)
        if (ec.Includes("assignmentType",true))
        {
            if(this.AssignmentType == null) {

                this.AssignmentType = new SlaAssignmentType();

            } else {


            }
        }
        else if (this.AssignmentType != null && ec.Excludes("assignmentType",true))
        {
            this.AssignmentType = null;
        }
        //      C# -> EffectiveSlaAssignment? EffectiveSla
        // GraphQL -> effectiveSla: EffectiveSlaAssignment (type)
        if (ec.Includes("effectiveSla",false))
        {
            if(this.EffectiveSla == null) {

                this.EffectiveSla = new EffectiveSlaAssignment();
                this.EffectiveSla.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSla"));

            } else {

                this.EffectiveSla.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSla"));

            }
        }
        else if (this.EffectiveSla != null && ec.Excludes("effectiveSla",false))
        {
            this.EffectiveSla = null;
        }
        //      C# -> SlaAssignmentDetail? Sla
        // GraphQL -> sla: SlaAssignmentDetail (type)
        if (ec.Includes("sla",false))
        {
            if(this.Sla == null) {

                this.Sla = new SlaAssignmentDetail();
                this.Sla.ApplyExploratoryFieldSpec(ec.NewChild("sla"));

            } else {

                this.Sla.ApplyExploratoryFieldSpec(ec.NewChild("sla"));

            }
        }
        else if (this.Sla != null && ec.Excludes("sla",false))
        {
            this.Sla = null;
        }
    }


    #endregion

    } // class HierarchyObjectSlaAssignment
    
    #endregion

    public static class ListHierarchyObjectSlaAssignmentExtensions
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
            this List<HierarchyObjectSlaAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HierarchyObjectSlaAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HierarchyObjectSlaAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HierarchyObjectSlaAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HierarchyObjectSlaAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types