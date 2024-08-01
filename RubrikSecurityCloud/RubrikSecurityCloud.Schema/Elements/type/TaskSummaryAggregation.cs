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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? NumOfCanceled
        // GraphQL -> NumOfCanceled: Int! (scalar)
        if (this.NumOfCanceled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "NumOfCanceled\n" ;
            } else {
                s += ind + "NumOfCanceled\n" ;
            }
        }
        //      C# -> System.Int32? NumOfExpected
        // GraphQL -> NumOfExpected: Int! (scalar)
        if (this.NumOfExpected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "NumOfExpected\n" ;
            } else {
                s += ind + "NumOfExpected\n" ;
            }
        }
        //      C# -> System.Int32? NumOfFailed
        // GraphQL -> NumOfFailed: Int! (scalar)
        if (this.NumOfFailed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "NumOfFailed\n" ;
            } else {
                s += ind + "NumOfFailed\n" ;
            }
        }
        //      C# -> System.Int32? NumOfSucceeded
        // GraphQL -> NumOfSucceeded: Int! (scalar)
        if (this.NumOfSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "NumOfSucceeded\n" ;
            } else {
                s += ind + "NumOfSucceeded\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumOfCanceled
        // GraphQL -> NumOfCanceled: Int! (scalar)
        if (ec.Includes("NumOfCanceled",true))
        {
            if(this.NumOfCanceled == null) {

                this.NumOfCanceled = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumOfCanceled != null && ec.Excludes("NumOfCanceled",true))
        {
            this.NumOfCanceled = null;
        }
        //      C# -> System.Int32? NumOfExpected
        // GraphQL -> NumOfExpected: Int! (scalar)
        if (ec.Includes("NumOfExpected",true))
        {
            if(this.NumOfExpected == null) {

                this.NumOfExpected = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumOfExpected != null && ec.Excludes("NumOfExpected",true))
        {
            this.NumOfExpected = null;
        }
        //      C# -> System.Int32? NumOfFailed
        // GraphQL -> NumOfFailed: Int! (scalar)
        if (ec.Includes("NumOfFailed",true))
        {
            if(this.NumOfFailed == null) {

                this.NumOfFailed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumOfFailed != null && ec.Excludes("NumOfFailed",true))
        {
            this.NumOfFailed = null;
        }
        //      C# -> System.Int32? NumOfSucceeded
        // GraphQL -> NumOfSucceeded: Int! (scalar)
        if (ec.Includes("NumOfSucceeded",true))
        {
            if(this.NumOfSucceeded == null) {

                this.NumOfSucceeded = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumOfSucceeded != null && ec.Excludes("NumOfSucceeded",true))
        {
            this.NumOfSucceeded = null;
        }
    }


    #endregion

    } // class TaskSummaryAggregation
    
    #endregion

    public static class ListTaskSummaryAggregationExtensions
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
            this List<TaskSummaryAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TaskSummaryAggregation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<TaskSummaryAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types