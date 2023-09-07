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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> TrialMetric? Type
        // GraphQL -> type: TrialMetric! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> DateTime? RecordedAt
        // GraphQL -> recordedAt: DateTime (scalar)
        if (this.RecordedAt != null) {
            s += ind + "recordedAt\n" ;
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String (scalar)
        if (this.SerializedValue != null) {
            s += ind + "serializedValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TrialMetric? Type
        // GraphQL -> type: TrialMetric! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new TrialMetric();
        }
        //      C# -> DateTime? RecordedAt
        // GraphQL -> recordedAt: DateTime (scalar)
        if (this.RecordedAt == null && ec.Includes("recordedAt",true))
        {
            this.RecordedAt = new DateTime();
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String (scalar)
        if (this.SerializedValue == null && ec.Includes("serializedValue",true))
        {
            this.SerializedValue = "FETCH";
        }
    }


    #endregion

    } // class TrialReportValue
    
    #endregion

    public static class ListTrialReportValueExtensions
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
            this List<TrialReportValue> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<TrialReportValue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types