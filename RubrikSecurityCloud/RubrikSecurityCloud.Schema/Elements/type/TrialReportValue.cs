// TrialReportValue.cs
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
    #region TrialReportValue
    public class TrialReportValue: BaseType
    {
        #region members

        //      C# -> TrialMetric? Type
        // GraphQL -> type: TrialMetric! (enum)
        [JsonProperty("type")]
        public TrialMetric? Type { get; set; }

        //      C# -> DateTime? RecordedAt
        // GraphQL -> recordedAt: DateTime (scalar)
        [JsonProperty("recordedAt")]
        public DateTime? RecordedAt { get; set; }

        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String (scalar)
        [JsonProperty("serializedValue")]
        public System.String? SerializedValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TrialReportValue";
    }

    public TrialReportValue Set(
        TrialMetric? Type = null,
        DateTime? RecordedAt = null,
        System.String? SerializedValue = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( RecordedAt != null ) {
            this.RecordedAt = RecordedAt;
        }
        if ( SerializedValue != null ) {
            this.SerializedValue = SerializedValue;
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
        //      C# -> TrialMetric? Type
        // GraphQL -> type: TrialMetric! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? RecordedAt
        // GraphQL -> recordedAt: DateTime (scalar)
        if (this.RecordedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recordedAt\n" ;
            } else {
                s += ind + "recordedAt\n" ;
            }
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String (scalar)
        if (this.SerializedValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serializedValue\n" ;
            } else {
                s += ind + "serializedValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TrialMetric? Type
        // GraphQL -> type: TrialMetric! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new TrialMetric();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? RecordedAt
        // GraphQL -> recordedAt: DateTime (scalar)
        if (ec.Includes("recordedAt",true))
        {
            if(this.RecordedAt == null) {

                this.RecordedAt = new DateTime();

            } else {


            }
        }
        else if (this.RecordedAt != null && ec.Excludes("recordedAt",true))
        {
            this.RecordedAt = null;
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String (scalar)
        if (ec.Includes("serializedValue",true))
        {
            if(this.SerializedValue == null) {

                this.SerializedValue = "FETCH";

            } else {


            }
        }
        else if (this.SerializedValue != null && ec.Excludes("serializedValue",true))
        {
            this.SerializedValue = null;
        }
    }


    #endregion

    } // class TrialReportValue
    
    #endregion

    public static class ListTrialReportValueExtensions
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
            this List<TrialReportValue> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TrialReportValue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TrialReportValue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TrialReportValue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TrialReportValue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types