// EffectiveSlaAssignment.cs
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
    #region EffectiveSlaAssignment
    public class EffectiveSlaAssignment: BaseType
    {
        #region members

        //      C# -> System.String? EffectiveRetentionSlaId
        // GraphQL -> effectiveRetentionSlaId: String (scalar)
        [JsonProperty("effectiveRetentionSlaId")]
        public System.String? EffectiveRetentionSlaId { get; set; }

        //      C# -> System.String? EffectiveSlaId
        // GraphQL -> effectiveSlaId: String (scalar)
        [JsonProperty("effectiveSlaId")]
        public System.String? EffectiveSlaId { get; set; }

        //      C# -> System.Boolean? IsUnprotected
        // GraphQL -> isUnprotected: Boolean (scalar)
        [JsonProperty("isUnprotected")]
        public System.Boolean? IsUnprotected { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EffectiveSlaAssignment";
    }

    public EffectiveSlaAssignment Set(
        System.String? EffectiveRetentionSlaId = null,
        System.String? EffectiveSlaId = null,
        System.Boolean? IsUnprotected = null
    ) 
    {
        if ( EffectiveRetentionSlaId != null ) {
            this.EffectiveRetentionSlaId = EffectiveRetentionSlaId;
        }
        if ( EffectiveSlaId != null ) {
            this.EffectiveSlaId = EffectiveSlaId;
        }
        if ( IsUnprotected != null ) {
            this.IsUnprotected = IsUnprotected;
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
        //      C# -> System.String? EffectiveRetentionSlaId
        // GraphQL -> effectiveRetentionSlaId: String (scalar)
        if (this.EffectiveRetentionSlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveRetentionSlaId\n" ;
            } else {
                s += ind + "effectiveRetentionSlaId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaId
        // GraphQL -> effectiveSlaId: String (scalar)
        if (this.EffectiveSlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaId\n" ;
            } else {
                s += ind + "effectiveSlaId\n" ;
            }
        }
        //      C# -> System.Boolean? IsUnprotected
        // GraphQL -> isUnprotected: Boolean (scalar)
        if (this.IsUnprotected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUnprotected\n" ;
            } else {
                s += ind + "isUnprotected\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? EffectiveRetentionSlaId
        // GraphQL -> effectiveRetentionSlaId: String (scalar)
        if (ec.Includes("effectiveRetentionSlaId",true))
        {
            if(this.EffectiveRetentionSlaId == null) {

                this.EffectiveRetentionSlaId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveRetentionSlaId != null && ec.Excludes("effectiveRetentionSlaId",true))
        {
            this.EffectiveRetentionSlaId = null;
        }
        //      C# -> System.String? EffectiveSlaId
        // GraphQL -> effectiveSlaId: String (scalar)
        if (ec.Includes("effectiveSlaId",true))
        {
            if(this.EffectiveSlaId == null) {

                this.EffectiveSlaId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaId != null && ec.Excludes("effectiveSlaId",true))
        {
            this.EffectiveSlaId = null;
        }
        //      C# -> System.Boolean? IsUnprotected
        // GraphQL -> isUnprotected: Boolean (scalar)
        if (ec.Includes("isUnprotected",true))
        {
            if(this.IsUnprotected == null) {

                this.IsUnprotected = true;

            } else {


            }
        }
        else if (this.IsUnprotected != null && ec.Excludes("isUnprotected",true))
        {
            this.IsUnprotected = null;
        }
    }


    #endregion

    } // class EffectiveSlaAssignment
    
    #endregion

    public static class ListEffectiveSlaAssignmentExtensions
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
            this List<EffectiveSlaAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EffectiveSlaAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EffectiveSlaAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EffectiveSlaAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EffectiveSlaAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types