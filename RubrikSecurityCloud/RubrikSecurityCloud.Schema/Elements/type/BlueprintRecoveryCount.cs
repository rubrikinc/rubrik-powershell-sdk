// BlueprintRecoveryCount.cs
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
    #region BlueprintRecoveryCount
    public class BlueprintRecoveryCount: BaseType
    {
        #region members

        //      C# -> System.Int64? FailoverRecoveryCount
        // GraphQL -> failoverRecoveryCount: Long! (scalar)
        [JsonProperty("failoverRecoveryCount")]
        public System.Int64? FailoverRecoveryCount { get; set; }

        //      C# -> System.Int64? IsolatedRecoveryCount
        // GraphQL -> isolatedRecoveryCount: Long! (scalar)
        [JsonProperty("isolatedRecoveryCount")]
        public System.Int64? IsolatedRecoveryCount { get; set; }

        //      C# -> System.Int64? LocalRecoveryCount
        // GraphQL -> localRecoveryCount: Long! (scalar)
        [JsonProperty("localRecoveryCount")]
        public System.Int64? LocalRecoveryCount { get; set; }

        //      C# -> System.Int64? TestFailoverRecoveryCount
        // GraphQL -> testFailoverRecoveryCount: Long! (scalar)
        [JsonProperty("testFailoverRecoveryCount")]
        public System.Int64? TestFailoverRecoveryCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlueprintRecoveryCount";
    }

    public BlueprintRecoveryCount Set(
        System.Int64? FailoverRecoveryCount = null,
        System.Int64? IsolatedRecoveryCount = null,
        System.Int64? LocalRecoveryCount = null,
        System.Int64? TestFailoverRecoveryCount = null
    ) 
    {
        if ( FailoverRecoveryCount != null ) {
            this.FailoverRecoveryCount = FailoverRecoveryCount;
        }
        if ( IsolatedRecoveryCount != null ) {
            this.IsolatedRecoveryCount = IsolatedRecoveryCount;
        }
        if ( LocalRecoveryCount != null ) {
            this.LocalRecoveryCount = LocalRecoveryCount;
        }
        if ( TestFailoverRecoveryCount != null ) {
            this.TestFailoverRecoveryCount = TestFailoverRecoveryCount;
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
        //      C# -> System.Int64? FailoverRecoveryCount
        // GraphQL -> failoverRecoveryCount: Long! (scalar)
        if (this.FailoverRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverRecoveryCount\n" ;
            } else {
                s += ind + "failoverRecoveryCount\n" ;
            }
        }
        //      C# -> System.Int64? IsolatedRecoveryCount
        // GraphQL -> isolatedRecoveryCount: Long! (scalar)
        if (this.IsolatedRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isolatedRecoveryCount\n" ;
            } else {
                s += ind + "isolatedRecoveryCount\n" ;
            }
        }
        //      C# -> System.Int64? LocalRecoveryCount
        // GraphQL -> localRecoveryCount: Long! (scalar)
        if (this.LocalRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localRecoveryCount\n" ;
            } else {
                s += ind + "localRecoveryCount\n" ;
            }
        }
        //      C# -> System.Int64? TestFailoverRecoveryCount
        // GraphQL -> testFailoverRecoveryCount: Long! (scalar)
        if (this.TestFailoverRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "testFailoverRecoveryCount\n" ;
            } else {
                s += ind + "testFailoverRecoveryCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? FailoverRecoveryCount
        // GraphQL -> failoverRecoveryCount: Long! (scalar)
        if (ec.Includes("failoverRecoveryCount",true))
        {
            if(this.FailoverRecoveryCount == null) {

                this.FailoverRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.FailoverRecoveryCount != null && ec.Excludes("failoverRecoveryCount",true))
        {
            this.FailoverRecoveryCount = null;
        }
        //      C# -> System.Int64? IsolatedRecoveryCount
        // GraphQL -> isolatedRecoveryCount: Long! (scalar)
        if (ec.Includes("isolatedRecoveryCount",true))
        {
            if(this.IsolatedRecoveryCount == null) {

                this.IsolatedRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.IsolatedRecoveryCount != null && ec.Excludes("isolatedRecoveryCount",true))
        {
            this.IsolatedRecoveryCount = null;
        }
        //      C# -> System.Int64? LocalRecoveryCount
        // GraphQL -> localRecoveryCount: Long! (scalar)
        if (ec.Includes("localRecoveryCount",true))
        {
            if(this.LocalRecoveryCount == null) {

                this.LocalRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.LocalRecoveryCount != null && ec.Excludes("localRecoveryCount",true))
        {
            this.LocalRecoveryCount = null;
        }
        //      C# -> System.Int64? TestFailoverRecoveryCount
        // GraphQL -> testFailoverRecoveryCount: Long! (scalar)
        if (ec.Includes("testFailoverRecoveryCount",true))
        {
            if(this.TestFailoverRecoveryCount == null) {

                this.TestFailoverRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.TestFailoverRecoveryCount != null && ec.Excludes("testFailoverRecoveryCount",true))
        {
            this.TestFailoverRecoveryCount = null;
        }
    }


    #endregion

    } // class BlueprintRecoveryCount
    
    #endregion

    public static class ListBlueprintRecoveryCountExtensions
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
            this List<BlueprintRecoveryCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BlueprintRecoveryCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintRecoveryCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoveryCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlueprintRecoveryCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types