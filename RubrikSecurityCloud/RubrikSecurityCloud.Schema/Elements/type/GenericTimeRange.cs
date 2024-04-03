// GenericTimeRange.cs
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
    #region GenericTimeRange
    public class GenericTimeRange: BaseType
    {
        #region members

        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        [JsonProperty("absoluteTimeRange")]
        public TimeRange? AbsoluteTimeRange { get; set; }

        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        [JsonProperty("relativeTimeRange")]
        public RelativeTimeRange? RelativeTimeRange { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GenericTimeRange";
    }

    public GenericTimeRange Set(
        TimeRange? AbsoluteTimeRange = null,
        RelativeTimeRange? RelativeTimeRange = null
    ) 
    {
        if ( AbsoluteTimeRange != null ) {
            this.AbsoluteTimeRange = AbsoluteTimeRange;
        }
        if ( RelativeTimeRange != null ) {
            this.RelativeTimeRange = RelativeTimeRange;
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
        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        if (this.AbsoluteTimeRange != null) {
            var fspec = this.AbsoluteTimeRange.AsFieldSpec(conf.Child("absoluteTimeRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "absoluteTimeRange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        if (this.RelativeTimeRange != null) {
            var fspec = this.RelativeTimeRange.AsFieldSpec(conf.Child("relativeTimeRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "relativeTimeRange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        if (ec.Includes("absoluteTimeRange",false))
        {
            if(this.AbsoluteTimeRange == null) {

                this.AbsoluteTimeRange = new TimeRange();
                this.AbsoluteTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("absoluteTimeRange"));

            } else {

                this.AbsoluteTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("absoluteTimeRange"));

            }
        }
        else if (this.AbsoluteTimeRange != null && ec.Excludes("absoluteTimeRange",false))
        {
            this.AbsoluteTimeRange = null;
        }
        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        if (ec.Includes("relativeTimeRange",false))
        {
            if(this.RelativeTimeRange == null) {

                this.RelativeTimeRange = new RelativeTimeRange();
                this.RelativeTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("relativeTimeRange"));

            } else {

                this.RelativeTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("relativeTimeRange"));

            }
        }
        else if (this.RelativeTimeRange != null && ec.Excludes("relativeTimeRange",false))
        {
            this.RelativeTimeRange = null;
        }
    }


    #endregion

    } // class GenericTimeRange
    
    #endregion

    public static class ListGenericTimeRangeExtensions
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
            this List<GenericTimeRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GenericTimeRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GenericTimeRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GenericTimeRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GenericTimeRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types