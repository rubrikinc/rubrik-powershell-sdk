// WorkloadGroupByInfo.cs
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
    #region WorkloadGroupByInfo
    public class WorkloadGroupByInfo: BaseType
    {
        #region members

        //      C# -> WorkloadGroupByEnum? GroupByField
        // GraphQL -> groupByField: WorkloadGroupByEnum! (enum)
        [JsonProperty("groupByField")]
        public WorkloadGroupByEnum? GroupByField { get; set; }

        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        [JsonProperty("groupByValue")]
        public System.String? GroupByValue { get; set; }


        #endregion

    #region methods

    public WorkloadGroupByInfo Set(
        WorkloadGroupByEnum? GroupByField = null,
        System.String? GroupByValue = null
    ) 
    {
        if ( GroupByField != null ) {
            this.GroupByField = GroupByField;
        }
        if ( GroupByValue != null ) {
            this.GroupByValue = GroupByValue;
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
        //      C# -> WorkloadGroupByEnum? GroupByField
        // GraphQL -> groupByField: WorkloadGroupByEnum! (enum)
        if (this.GroupByField != null) {
            s += ind + "groupByField\n" ;
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue != null) {
            s += ind + "groupByValue\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> WorkloadGroupByEnum? GroupByField
        // GraphQL -> groupByField: WorkloadGroupByEnum! (enum)
        if (this.GroupByField == null && Exploration.Includes(parent + ".groupByField", true))
        {
            this.GroupByField = new WorkloadGroupByEnum();
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue == null && Exploration.Includes(parent + ".groupByValue", true))
        {
            this.GroupByValue = "FETCH";
        }
    }


    #endregion

    } // class WorkloadGroupByInfo
    
    #endregion

    public static class ListWorkloadGroupByInfoExtensions
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
            this List<WorkloadGroupByInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadGroupByInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadGroupByInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types