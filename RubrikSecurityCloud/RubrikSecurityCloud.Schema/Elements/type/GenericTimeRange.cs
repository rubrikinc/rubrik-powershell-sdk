// GenericTimeRange.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:37.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region GenericTimeRange
    public class GenericTimeRange: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> TimeRange? AbsoluteTimeRange
            // GraphQL -> absoluteTimeRange: TimeRange (type)
            if (this.AbsoluteTimeRange != null)
            {
                 s += ind + "absoluteTimeRange\n";

                 s += ind + "{\n" + 
                 this.AbsoluteTimeRange.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RelativeTimeRange? RelativeTimeRange
            // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
            if (this.RelativeTimeRange != null)
            {
                 s += ind + "relativeTimeRange\n";

                 s += ind + "{\n" + 
                 this.RelativeTimeRange.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> TimeRange? AbsoluteTimeRange
            // GraphQL -> absoluteTimeRange: TimeRange (type)
            if (this.AbsoluteTimeRange == null && Exploration.Includes(parent + ".absoluteTimeRange"))
            {
                this.AbsoluteTimeRange = new TimeRange();
                this.AbsoluteTimeRange.ApplyExploratoryFragment(parent + ".absoluteTimeRange");
            }
            //      C# -> RelativeTimeRange? RelativeTimeRange
            // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
            if (this.RelativeTimeRange == null && Exploration.Includes(parent + ".relativeTimeRange"))
            {
                this.RelativeTimeRange = new RelativeTimeRange();
                this.RelativeTimeRange.ApplyExploratoryFragment(parent + ".relativeTimeRange");
            }
        }


    #endregion

    } // class GenericTimeRange
    #endregion

    public static class ListGenericTimeRangeExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GenericTimeRange> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GenericTimeRange> list, 
            String parent = "")
        {
            var item = new GenericTimeRange();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types