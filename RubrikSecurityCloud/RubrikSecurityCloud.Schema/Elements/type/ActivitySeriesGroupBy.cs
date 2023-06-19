// ActivitySeriesGroupBy.cs
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
    #region ActivitySeriesGroupBy
    public class ActivitySeriesGroupBy: BaseType
    {
        #region members

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        [JsonProperty("activitySeriesConnection")]
        public ActivitySeriesConnection? ActivitySeriesConnection { get; set; }

        //      C# -> List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField
        // GraphQL -> activitySeriesGroupBy: [ActivitySeriesGroupBy!]! (type)
        [JsonProperty("activitySeriesGroupBy")]
        public List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField { get; set; }

        //      C# -> ActivitySeriesGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ActivitySeriesGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ActivitySeriesGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public ActivitySeriesGroupBy Set(
        ActivitySeriesConnection? ActivitySeriesConnection = null,
        List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField = null,
        ActivitySeriesGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ActivitySeriesConnection != null ) {
            this.ActivitySeriesConnection = ActivitySeriesConnection;
        }
        if ( ActivitySeriesGroupByField != null ) {
            this.ActivitySeriesGroupByField = ActivitySeriesGroupByField;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection != null) {
            var fspec = this.ActivitySeriesConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "activitySeriesConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField
        // GraphQL -> activitySeriesGroupBy: [ActivitySeriesGroupBy!]! (type)
        if (this.ActivitySeriesGroupByField != null) {
            var fspec = this.ActivitySeriesGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "activitySeriesGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ActivitySeriesGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ActivitySeriesGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection == null && Exploration.Includes(parent + ".activitySeriesConnection"))
        {
            this.ActivitySeriesConnection = new ActivitySeriesConnection();
            this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(parent + ".activitySeriesConnection");
        }
        //      C# -> List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField
        // GraphQL -> activitySeriesGroupBy: [ActivitySeriesGroupBy!]! (type)
        if (this.ActivitySeriesGroupByField == null && Exploration.Includes(parent + ".activitySeriesGroupBy"))
        {
            this.ActivitySeriesGroupByField = new List<ActivitySeriesGroupBy>();
            this.ActivitySeriesGroupByField.ApplyExploratoryFieldSpec(parent + ".activitySeriesGroupBy");
        }
        //      C# -> ActivitySeriesGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ActivitySeriesGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<ActivitySeriesGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (ActivitySeriesGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class ActivitySeriesGroupBy
    
    #endregion

    public static class ListActivitySeriesGroupByExtensions
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
            this List<ActivitySeriesGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActivitySeriesGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivitySeriesGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types