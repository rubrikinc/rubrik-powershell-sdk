// SddSchedule.cs
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
    #region SddSchedule
    public class SddSchedule: BaseType
    {
        #region members

        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> System.Int32? StartMonth
        // GraphQL -> startMonth: Int! (scalar)
        [JsonProperty("startMonth")]
        public System.Int32? StartMonth { get; set; }

        //      C# -> System.Int32? When
        // GraphQL -> when: Int! (scalar)
        [JsonProperty("when")]
        public System.Int32? When { get; set; }

        //      C# -> SddScheduleFrequency? Frequency
        // GraphQL -> frequency: SddScheduleFrequency (type)
        [JsonProperty("frequency")]
        public SddScheduleFrequency? Frequency { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SddSchedule";
    }

    public SddSchedule Set(
        DateTime? BeginTime = null,
        System.Int32? StartMonth = null,
        System.Int32? When = null,
        SddScheduleFrequency? Frequency = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( StartMonth != null ) {
            this.StartMonth = StartMonth;
        }
        if ( When != null ) {
            this.When = When;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
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
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (this.BeginTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "beginTime\n" ;
            } else {
                s += ind + "beginTime\n" ;
            }
        }
        //      C# -> System.Int32? StartMonth
        // GraphQL -> startMonth: Int! (scalar)
        if (this.StartMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startMonth\n" ;
            } else {
                s += ind + "startMonth\n" ;
            }
        }
        //      C# -> System.Int32? When
        // GraphQL -> when: Int! (scalar)
        if (this.When != null) {
            if (conf.Flat) {
                s += conf.Prefix + "when\n" ;
            } else {
                s += ind + "when\n" ;
            }
        }
        //      C# -> SddScheduleFrequency? Frequency
        // GraphQL -> frequency: SddScheduleFrequency (type)
        if (this.Frequency != null) {
            var fspec = this.Frequency.AsFieldSpec(conf.Child("frequency"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "frequency" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (ec.Includes("beginTime",true))
        {
            if(this.BeginTime == null) {

                this.BeginTime = new DateTime();

            } else {


            }
        }
        else if (this.BeginTime != null && ec.Excludes("beginTime",true))
        {
            this.BeginTime = null;
        }
        //      C# -> System.Int32? StartMonth
        // GraphQL -> startMonth: Int! (scalar)
        if (ec.Includes("startMonth",true))
        {
            if(this.StartMonth == null) {

                this.StartMonth = Int32.MinValue;

            } else {


            }
        }
        else if (this.StartMonth != null && ec.Excludes("startMonth",true))
        {
            this.StartMonth = null;
        }
        //      C# -> System.Int32? When
        // GraphQL -> when: Int! (scalar)
        if (ec.Includes("when",true))
        {
            if(this.When == null) {

                this.When = Int32.MinValue;

            } else {


            }
        }
        else if (this.When != null && ec.Excludes("when",true))
        {
            this.When = null;
        }
        //      C# -> SddScheduleFrequency? Frequency
        // GraphQL -> frequency: SddScheduleFrequency (type)
        if (ec.Includes("frequency",false))
        {
            if(this.Frequency == null) {

                this.Frequency = new SddScheduleFrequency();
                this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));

            } else {

                this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));

            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",false))
        {
            this.Frequency = null;
        }
    }


    #endregion

    } // class SddSchedule
    
    #endregion

    public static class ListSddScheduleExtensions
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
            this List<SddSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SddSchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SddSchedule> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SddSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SddSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types