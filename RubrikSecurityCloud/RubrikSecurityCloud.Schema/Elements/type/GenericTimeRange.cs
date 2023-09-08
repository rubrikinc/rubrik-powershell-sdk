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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        if (this.AbsoluteTimeRange != null) {
            var fspec = this.AbsoluteTimeRange.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "absoluteTimeRange {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        if (this.RelativeTimeRange != null) {
            var fspec = this.RelativeTimeRange.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "relativeTimeRange {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        if (this.AbsoluteTimeRange == null && ec.Includes("absoluteTimeRange",false))
        {
            this.AbsoluteTimeRange = new TimeRange();
            this.AbsoluteTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("absoluteTimeRange"));
        }
        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        if (this.RelativeTimeRange == null && ec.Includes("relativeTimeRange",false))
        {
            this.RelativeTimeRange = new RelativeTimeRange();
            this.RelativeTimeRange.ApplyExploratoryFieldSpec(ec.NewChild("relativeTimeRange"));
        }
    }


    #endregion

    } // class GenericTimeRange
    
    #endregion

    public static class ListGenericTimeRangeExtensions
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
            this List<GenericTimeRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<GenericTimeRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types