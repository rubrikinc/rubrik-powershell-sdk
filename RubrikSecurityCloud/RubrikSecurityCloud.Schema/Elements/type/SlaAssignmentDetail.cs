// SlaAssignmentDetail.cs
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
    #region SlaAssignmentDetail
    public class SlaAssignmentDetail: BaseType
    {
        #region members

        //      C# -> System.Boolean? DoNotProtect
        // GraphQL -> doNotProtect: Boolean (scalar)
        [JsonProperty("doNotProtect")]
        public System.Boolean? DoNotProtect { get; set; }

        //      C# -> System.Boolean? NoAssignment
        // GraphQL -> noAssignment: Boolean (scalar)
        [JsonProperty("noAssignment")]
        public System.Boolean? NoAssignment { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaAssignmentDetail";
    }

    public SlaAssignmentDetail Set(
        System.Boolean? DoNotProtect = null,
        System.Boolean? NoAssignment = null,
        System.String? SlaId = null
    ) 
    {
        if ( DoNotProtect != null ) {
            this.DoNotProtect = DoNotProtect;
        }
        if ( NoAssignment != null ) {
            this.NoAssignment = NoAssignment;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
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
        //      C# -> System.Boolean? DoNotProtect
        // GraphQL -> doNotProtect: Boolean (scalar)
        if (this.DoNotProtect != null) {
            if (conf.Flat) {
                s += conf.Prefix + "doNotProtect\n" ;
            } else {
                s += ind + "doNotProtect\n" ;
            }
        }
        //      C# -> System.Boolean? NoAssignment
        // GraphQL -> noAssignment: Boolean (scalar)
        if (this.NoAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "noAssignment\n" ;
            } else {
                s += ind + "noAssignment\n" ;
            }
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        if (this.SlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaId\n" ;
            } else {
                s += ind + "slaId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? DoNotProtect
        // GraphQL -> doNotProtect: Boolean (scalar)
        if (ec.Includes("doNotProtect",true))
        {
            if(this.DoNotProtect == null) {

                this.DoNotProtect = true;

            } else {


            }
        }
        else if (this.DoNotProtect != null && ec.Excludes("doNotProtect",true))
        {
            this.DoNotProtect = null;
        }
        //      C# -> System.Boolean? NoAssignment
        // GraphQL -> noAssignment: Boolean (scalar)
        if (ec.Includes("noAssignment",true))
        {
            if(this.NoAssignment == null) {

                this.NoAssignment = true;

            } else {


            }
        }
        else if (this.NoAssignment != null && ec.Excludes("noAssignment",true))
        {
            this.NoAssignment = null;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        if (ec.Includes("slaId",true))
        {
            if(this.SlaId == null) {

                this.SlaId = "FETCH";

            } else {


            }
        }
        else if (this.SlaId != null && ec.Excludes("slaId",true))
        {
            this.SlaId = null;
        }
    }


    #endregion

    } // class SlaAssignmentDetail
    
    #endregion

    public static class ListSlaAssignmentDetailExtensions
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
            this List<SlaAssignmentDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaAssignmentDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaAssignmentDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaAssignmentDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaAssignmentDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types