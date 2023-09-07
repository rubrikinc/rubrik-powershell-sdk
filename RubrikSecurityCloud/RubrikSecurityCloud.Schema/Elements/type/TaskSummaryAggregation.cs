// TaskSummaryAggregation.cs
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
    #region TaskSummaryAggregation
    public class TaskSummaryAggregation: BaseType
    {
        #region members

        //      C# -> System.Int32? NumOfCanceled
        // GraphQL -> NumOfCanceled: Int! (scalar)
        [JsonProperty("NumOfCanceled")]
        public System.Int32? NumOfCanceled { get; set; }

        //      C# -> System.Int32? NumOfExpected
        // GraphQL -> NumOfExpected: Int! (scalar)
        [JsonProperty("NumOfExpected")]
        public System.Int32? NumOfExpected { get; set; }

        //      C# -> System.Int32? NumOfFailed
        // GraphQL -> NumOfFailed: Int! (scalar)
        [JsonProperty("NumOfFailed")]
        public System.Int32? NumOfFailed { get; set; }

        //      C# -> System.Int32? NumOfSucceeded
        // GraphQL -> NumOfSucceeded: Int! (scalar)
        [JsonProperty("NumOfSucceeded")]
        public System.Int32? NumOfSucceeded { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskSummaryAggregation";
    }

    public TaskSummaryAggregation Set(
        System.Int32? NumOfCanceled = null,
        System.Int32? NumOfExpected = null,
        System.Int32? NumOfFailed = null,
        System.Int32? NumOfSucceeded = null
    ) 
    {
        if ( NumOfCanceled != null ) {
            this.NumOfCanceled = NumOfCanceled;
        }
        if ( NumOfExpected != null ) {
            this.NumOfExpected = NumOfExpected;
        }
        if ( NumOfFailed != null ) {
            this.NumOfFailed = NumOfFailed;
        }
        if ( NumOfSucceeded != null ) {
            this.NumOfSucceeded = NumOfSucceeded;
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
        //      C# -> System.Int32? NumOfCanceled
        // GraphQL -> NumOfCanceled: Int! (scalar)
        if (this.NumOfCanceled != null) {
            s += ind + "NumOfCanceled\n" ;
        }
        //      C# -> System.Int32? NumOfExpected
        // GraphQL -> NumOfExpected: Int! (scalar)
        if (this.NumOfExpected != null) {
            s += ind + "NumOfExpected\n" ;
        }
        //      C# -> System.Int32? NumOfFailed
        // GraphQL -> NumOfFailed: Int! (scalar)
        if (this.NumOfFailed != null) {
            s += ind + "NumOfFailed\n" ;
        }
        //      C# -> System.Int32? NumOfSucceeded
        // GraphQL -> NumOfSucceeded: Int! (scalar)
        if (this.NumOfSucceeded != null) {
            s += ind + "NumOfSucceeded\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumOfCanceled
        // GraphQL -> NumOfCanceled: Int! (scalar)
        if (this.NumOfCanceled == null && ec.Includes("NumOfCanceled",true))
        {
            this.NumOfCanceled = Int32.MinValue;
        }
        //      C# -> System.Int32? NumOfExpected
        // GraphQL -> NumOfExpected: Int! (scalar)
        if (this.NumOfExpected == null && ec.Includes("NumOfExpected",true))
        {
            this.NumOfExpected = Int32.MinValue;
        }
        //      C# -> System.Int32? NumOfFailed
        // GraphQL -> NumOfFailed: Int! (scalar)
        if (this.NumOfFailed == null && ec.Includes("NumOfFailed",true))
        {
            this.NumOfFailed = Int32.MinValue;
        }
        //      C# -> System.Int32? NumOfSucceeded
        // GraphQL -> NumOfSucceeded: Int! (scalar)
        if (this.NumOfSucceeded == null && ec.Includes("NumOfSucceeded",true))
        {
            this.NumOfSucceeded = Int32.MinValue;
        }
    }


    #endregion

    } // class TaskSummaryAggregation
    
    #endregion

    public static class ListTaskSummaryAggregationExtensions
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
            this List<TaskSummaryAggregation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskSummaryAggregation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskSummaryAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TaskSummaryAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types