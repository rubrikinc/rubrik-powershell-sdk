// BasicSnapshotSchedule.cs
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
    #region BasicSnapshotSchedule
    public class BasicSnapshotSchedule: BaseType
    {
        #region members

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BasicSnapshotSchedule";
    }

    public BasicSnapshotSchedule Set(
        RetentionUnit? RetentionUnit = null,
        System.Int32? Frequency = null,
        System.Int32? Retention = null
    ) 
    {
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
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
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionUnit\n" ;
            } else {
                s += ind + "retentionUnit\n" ;
            }
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequency\n" ;
            } else {
                s += ind + "frequency\n" ;
            }
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retention\n" ;
            } else {
                s += ind + "retention\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (ec.Includes("retentionUnit",true))
        {
            if(this.RetentionUnit == null) {

                this.RetentionUnit = new RetentionUnit();

            } else {


            }
        }
        else if (this.RetentionUnit != null && ec.Excludes("retentionUnit",true))
        {
            this.RetentionUnit = null;
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (ec.Includes("frequency",true))
        {
            if(this.Frequency == null) {

                this.Frequency = Int32.MinValue;

            } else {


            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",true))
        {
            this.Frequency = null;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (ec.Includes("retention",true))
        {
            if(this.Retention == null) {

                this.Retention = Int32.MinValue;

            } else {


            }
        }
        else if (this.Retention != null && ec.Excludes("retention",true))
        {
            this.Retention = null;
        }
    }


    #endregion

    } // class BasicSnapshotSchedule
    
    #endregion

    public static class ListBasicSnapshotScheduleExtensions
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
            this List<BasicSnapshotSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BasicSnapshotSchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BasicSnapshotSchedule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BasicSnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BasicSnapshotSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types