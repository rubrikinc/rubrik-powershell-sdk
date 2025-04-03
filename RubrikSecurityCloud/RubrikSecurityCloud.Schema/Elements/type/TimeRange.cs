// TimeRange.cs
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
    #region TimeRange
    public class TimeRange: BaseType
    {
        #region members

        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        [JsonProperty("end")]
        public DateTime? End { get; set; }

        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        [JsonProperty("start")]
        public DateTime? Start { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TimeRange";
    }

    public TimeRange Set(
        DateTime? End = null,
        DateTime? Start = null
    ) 
    {
        if ( End != null ) {
            this.End = End;
        }
        if ( Start != null ) {
            this.Start = Start;
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
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        if (this.End != null) {
            if (conf.Flat) {
                s += conf.Prefix + "end\n" ;
            } else {
                s += ind + "end\n" ;
            }
        }
        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        if (this.Start != null) {
            if (conf.Flat) {
                s += conf.Prefix + "start\n" ;
            } else {
                s += ind + "start\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        if (ec.Includes("end",true))
        {
            if(this.End == null) {

                this.End = new DateTime();

            } else {


            }
        }
        else if (this.End != null && ec.Excludes("end",true))
        {
            this.End = null;
        }
        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        if (ec.Includes("start",true))
        {
            if(this.Start == null) {

                this.Start = new DateTime();

            } else {


            }
        }
        else if (this.Start != null && ec.Excludes("start",true))
        {
            this.Start = null;
        }
    }


    #endregion

    } // class TimeRange
    
    #endregion

    public static class ListTimeRangeExtensions
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
            this List<TimeRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TimeRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TimeRange> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TimeRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TimeRange> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types