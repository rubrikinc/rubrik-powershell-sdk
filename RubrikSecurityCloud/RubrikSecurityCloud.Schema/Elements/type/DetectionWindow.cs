// DetectionWindow.cs
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
    #region DetectionWindow
    public class DetectionWindow: BaseType
    {
        #region members

        //      C# -> DateTime? FirstObservedWindowStart
        // GraphQL -> firstObservedWindowStart: DateTime (scalar)
        [JsonProperty("firstObservedWindowStart")]
        public DateTime? FirstObservedWindowStart { get; set; }

        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long! (scalar)
        [JsonProperty("threshold")]
        public System.Int64? Threshold { get; set; }

        //      C# -> DateTime? WindowEnd
        // GraphQL -> windowEnd: DateTime (scalar)
        [JsonProperty("windowEnd")]
        public DateTime? WindowEnd { get; set; }

        //      C# -> DateTime? WindowStart
        // GraphQL -> windowStart: DateTime (scalar)
        [JsonProperty("windowStart")]
        public DateTime? WindowStart { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DetectionWindow";
    }

    public DetectionWindow Set(
        DateTime? FirstObservedWindowStart = null,
        System.Int64? Threshold = null,
        DateTime? WindowEnd = null,
        DateTime? WindowStart = null
    ) 
    {
        if ( FirstObservedWindowStart != null ) {
            this.FirstObservedWindowStart = FirstObservedWindowStart;
        }
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( WindowEnd != null ) {
            this.WindowEnd = WindowEnd;
        }
        if ( WindowStart != null ) {
            this.WindowStart = WindowStart;
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
        //      C# -> DateTime? FirstObservedWindowStart
        // GraphQL -> firstObservedWindowStart: DateTime (scalar)
        if (this.FirstObservedWindowStart != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstObservedWindowStart\n" ;
            } else {
                s += ind + "firstObservedWindowStart\n" ;
            }
        }
        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long! (scalar)
        if (this.Threshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threshold\n" ;
            } else {
                s += ind + "threshold\n" ;
            }
        }
        //      C# -> DateTime? WindowEnd
        // GraphQL -> windowEnd: DateTime (scalar)
        if (this.WindowEnd != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowEnd\n" ;
            } else {
                s += ind + "windowEnd\n" ;
            }
        }
        //      C# -> DateTime? WindowStart
        // GraphQL -> windowStart: DateTime (scalar)
        if (this.WindowStart != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowStart\n" ;
            } else {
                s += ind + "windowStart\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? FirstObservedWindowStart
        // GraphQL -> firstObservedWindowStart: DateTime (scalar)
        if (ec.Includes("firstObservedWindowStart",true))
        {
            if(this.FirstObservedWindowStart == null) {

                this.FirstObservedWindowStart = new DateTime();

            } else {


            }
        }
        else if (this.FirstObservedWindowStart != null && ec.Excludes("firstObservedWindowStart",true))
        {
            this.FirstObservedWindowStart = null;
        }
        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long! (scalar)
        if (ec.Includes("threshold",true))
        {
            if(this.Threshold == null) {

                this.Threshold = new System.Int64();

            } else {


            }
        }
        else if (this.Threshold != null && ec.Excludes("threshold",true))
        {
            this.Threshold = null;
        }
        //      C# -> DateTime? WindowEnd
        // GraphQL -> windowEnd: DateTime (scalar)
        if (ec.Includes("windowEnd",true))
        {
            if(this.WindowEnd == null) {

                this.WindowEnd = new DateTime();

            } else {


            }
        }
        else if (this.WindowEnd != null && ec.Excludes("windowEnd",true))
        {
            this.WindowEnd = null;
        }
        //      C# -> DateTime? WindowStart
        // GraphQL -> windowStart: DateTime (scalar)
        if (ec.Includes("windowStart",true))
        {
            if(this.WindowStart == null) {

                this.WindowStart = new DateTime();

            } else {


            }
        }
        else if (this.WindowStart != null && ec.Excludes("windowStart",true))
        {
            this.WindowStart = null;
        }
    }


    #endregion

    } // class DetectionWindow
    
    #endregion

    public static class ListDetectionWindowExtensions
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
            this List<DetectionWindow> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DetectionWindow> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DetectionWindow> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DetectionWindow());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DetectionWindow> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types