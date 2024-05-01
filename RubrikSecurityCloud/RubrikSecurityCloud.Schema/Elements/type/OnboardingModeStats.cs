// OnboardingModeStats.cs
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
    #region OnboardingModeStats
    public class OnboardingModeStats: BaseType
    {
        #region members

        //      C# -> System.Int32? CompletionPercentage
        // GraphQL -> completionPercentage: Int! (scalar)
        [JsonProperty("completionPercentage")]
        public System.Int32? CompletionPercentage { get; set; }

        //      C# -> System.Int32? NumFullsInProgress
        // GraphQL -> numFullsInProgress: Int! (scalar)
        [JsonProperty("numFullsInProgress")]
        public System.Int32? NumFullsInProgress { get; set; }

        //      C# -> System.Int32? NumFullsSucceeded
        // GraphQL -> numFullsSucceeded: Int! (scalar)
        [JsonProperty("numFullsSucceeded")]
        public System.Int32? NumFullsSucceeded { get; set; }

        //      C# -> System.Int32? TotalProtectedCount
        // GraphQL -> totalProtectedCount: Int! (scalar)
        [JsonProperty("totalProtectedCount")]
        public System.Int32? TotalProtectedCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OnboardingModeStats";
    }

    public OnboardingModeStats Set(
        System.Int32? CompletionPercentage = null,
        System.Int32? NumFullsInProgress = null,
        System.Int32? NumFullsSucceeded = null,
        System.Int32? TotalProtectedCount = null
    ) 
    {
        if ( CompletionPercentage != null ) {
            this.CompletionPercentage = CompletionPercentage;
        }
        if ( NumFullsInProgress != null ) {
            this.NumFullsInProgress = NumFullsInProgress;
        }
        if ( NumFullsSucceeded != null ) {
            this.NumFullsSucceeded = NumFullsSucceeded;
        }
        if ( TotalProtectedCount != null ) {
            this.TotalProtectedCount = TotalProtectedCount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? CompletionPercentage
        // GraphQL -> completionPercentage: Int! (scalar)
        if (this.CompletionPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completionPercentage\n" ;
            } else {
                s += ind + "completionPercentage\n" ;
            }
        }
        //      C# -> System.Int32? NumFullsInProgress
        // GraphQL -> numFullsInProgress: Int! (scalar)
        if (this.NumFullsInProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFullsInProgress\n" ;
            } else {
                s += ind + "numFullsInProgress\n" ;
            }
        }
        //      C# -> System.Int32? NumFullsSucceeded
        // GraphQL -> numFullsSucceeded: Int! (scalar)
        if (this.NumFullsSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFullsSucceeded\n" ;
            } else {
                s += ind + "numFullsSucceeded\n" ;
            }
        }
        //      C# -> System.Int32? TotalProtectedCount
        // GraphQL -> totalProtectedCount: Int! (scalar)
        if (this.TotalProtectedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalProtectedCount\n" ;
            } else {
                s += ind + "totalProtectedCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? CompletionPercentage
        // GraphQL -> completionPercentage: Int! (scalar)
        if (ec.Includes("completionPercentage",true))
        {
            if(this.CompletionPercentage == null) {

                this.CompletionPercentage = Int32.MinValue;

            } else {


            }
        }
        else if (this.CompletionPercentage != null && ec.Excludes("completionPercentage",true))
        {
            this.CompletionPercentage = null;
        }
        //      C# -> System.Int32? NumFullsInProgress
        // GraphQL -> numFullsInProgress: Int! (scalar)
        if (ec.Includes("numFullsInProgress",true))
        {
            if(this.NumFullsInProgress == null) {

                this.NumFullsInProgress = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFullsInProgress != null && ec.Excludes("numFullsInProgress",true))
        {
            this.NumFullsInProgress = null;
        }
        //      C# -> System.Int32? NumFullsSucceeded
        // GraphQL -> numFullsSucceeded: Int! (scalar)
        if (ec.Includes("numFullsSucceeded",true))
        {
            if(this.NumFullsSucceeded == null) {

                this.NumFullsSucceeded = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFullsSucceeded != null && ec.Excludes("numFullsSucceeded",true))
        {
            this.NumFullsSucceeded = null;
        }
        //      C# -> System.Int32? TotalProtectedCount
        // GraphQL -> totalProtectedCount: Int! (scalar)
        if (ec.Includes("totalProtectedCount",true))
        {
            if(this.TotalProtectedCount == null) {

                this.TotalProtectedCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalProtectedCount != null && ec.Excludes("totalProtectedCount",true))
        {
            this.TotalProtectedCount = null;
        }
    }


    #endregion

    } // class OnboardingModeStats
    
    #endregion

    public static class ListOnboardingModeStatsExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OnboardingModeStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OnboardingModeStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OnboardingModeStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OnboardingModeStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OnboardingModeStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types