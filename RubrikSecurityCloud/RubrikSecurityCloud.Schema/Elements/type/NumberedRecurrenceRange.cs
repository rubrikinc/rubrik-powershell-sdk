// NumberedRecurrenceRange.cs
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
    #region NumberedRecurrenceRange
    public class NumberedRecurrenceRange: BaseType
    {
        #region members

        //      C# -> System.Int32? NumberOfOccurrences
        // GraphQL -> numberOfOccurrences: Int! (scalar)
        [JsonProperty("numberOfOccurrences")]
        public System.Int32? NumberOfOccurrences { get; set; }

        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NumberedRecurrenceRange";
    }

    public NumberedRecurrenceRange Set(
        System.Int32? NumberOfOccurrences = null,
        DateTime? StartDate = null
    ) 
    {
        if ( NumberOfOccurrences != null ) {
            this.NumberOfOccurrences = NumberOfOccurrences;
        }
        if ( StartDate != null ) {
            this.StartDate = StartDate;
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
        //      C# -> System.Int32? NumberOfOccurrences
        // GraphQL -> numberOfOccurrences: Int! (scalar)
        if (this.NumberOfOccurrences != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numberOfOccurrences\n" ;
            } else {
                s += ind + "numberOfOccurrences\n" ;
            }
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        if (this.StartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDate\n" ;
            } else {
                s += ind + "startDate\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumberOfOccurrences
        // GraphQL -> numberOfOccurrences: Int! (scalar)
        if (ec.Includes("numberOfOccurrences",true))
        {
            if(this.NumberOfOccurrences == null) {

                this.NumberOfOccurrences = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumberOfOccurrences != null && ec.Excludes("numberOfOccurrences",true))
        {
            this.NumberOfOccurrences = null;
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime! (scalar)
        if (ec.Includes("startDate",true))
        {
            if(this.StartDate == null) {

                this.StartDate = new DateTime();

            } else {


            }
        }
        else if (this.StartDate != null && ec.Excludes("startDate",true))
        {
            this.StartDate = null;
        }
    }


    #endregion

    } // class NumberedRecurrenceRange
    
    #endregion

    public static class ListNumberedRecurrenceRangeExtensions
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
            this List<NumberedRecurrenceRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NumberedRecurrenceRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NumberedRecurrenceRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NumberedRecurrenceRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NumberedRecurrenceRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types