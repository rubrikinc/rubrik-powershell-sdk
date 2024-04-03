// DayToDayModeBackupStats.cs
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
    #region DayToDayModeBackupStats
    public class DayToDayModeBackupStats: BaseType
    {
        #region members

        //      C# -> System.Int32? NumFullsFailed
        // GraphQL -> numFullsFailed: Int! (scalar)
        [JsonProperty("numFullsFailed")]
        public System.Int32? NumFullsFailed { get; set; }

        //      C# -> System.Int32? NumFullsSucceeded
        // GraphQL -> numFullsSucceeded: Int! (scalar)
        [JsonProperty("numFullsSucceeded")]
        public System.Int32? NumFullsSucceeded { get; set; }

        //      C# -> System.Int32? NumIncrementalsFailed
        // GraphQL -> numIncrementalsFailed: Int! (scalar)
        [JsonProperty("numIncrementalsFailed")]
        public System.Int32? NumIncrementalsFailed { get; set; }

        //      C# -> System.Int32? NumIncrementalsSucceeded
        // GraphQL -> numIncrementalsSucceeded: Int! (scalar)
        [JsonProperty("numIncrementalsSucceeded")]
        public System.Int32? NumIncrementalsSucceeded { get; set; }

        //      C# -> System.Int32? TotalNewObjectsAdded
        // GraphQL -> totalNewObjectsAdded: Int! (scalar)
        [JsonProperty("totalNewObjectsAdded")]
        public System.Int32? TotalNewObjectsAdded { get; set; }

        //      C# -> List<BackupStatsBucket>? BackupStatsBuckets
        // GraphQL -> backupStatsBuckets: [BackupStatsBucket!]! (type)
        [JsonProperty("backupStatsBuckets")]
        public List<BackupStatsBucket>? BackupStatsBuckets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DayToDayModeBackupStats";
    }

    public DayToDayModeBackupStats Set(
        System.Int32? NumFullsFailed = null,
        System.Int32? NumFullsSucceeded = null,
        System.Int32? NumIncrementalsFailed = null,
        System.Int32? NumIncrementalsSucceeded = null,
        System.Int32? TotalNewObjectsAdded = null,
        List<BackupStatsBucket>? BackupStatsBuckets = null
    ) 
    {
        if ( NumFullsFailed != null ) {
            this.NumFullsFailed = NumFullsFailed;
        }
        if ( NumFullsSucceeded != null ) {
            this.NumFullsSucceeded = NumFullsSucceeded;
        }
        if ( NumIncrementalsFailed != null ) {
            this.NumIncrementalsFailed = NumIncrementalsFailed;
        }
        if ( NumIncrementalsSucceeded != null ) {
            this.NumIncrementalsSucceeded = NumIncrementalsSucceeded;
        }
        if ( TotalNewObjectsAdded != null ) {
            this.TotalNewObjectsAdded = TotalNewObjectsAdded;
        }
        if ( BackupStatsBuckets != null ) {
            this.BackupStatsBuckets = BackupStatsBuckets;
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
        //      C# -> System.Int32? NumFullsFailed
        // GraphQL -> numFullsFailed: Int! (scalar)
        if (this.NumFullsFailed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFullsFailed\n" ;
            } else {
                s += ind + "numFullsFailed\n" ;
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
        //      C# -> System.Int32? NumIncrementalsFailed
        // GraphQL -> numIncrementalsFailed: Int! (scalar)
        if (this.NumIncrementalsFailed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numIncrementalsFailed\n" ;
            } else {
                s += ind + "numIncrementalsFailed\n" ;
            }
        }
        //      C# -> System.Int32? NumIncrementalsSucceeded
        // GraphQL -> numIncrementalsSucceeded: Int! (scalar)
        if (this.NumIncrementalsSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numIncrementalsSucceeded\n" ;
            } else {
                s += ind + "numIncrementalsSucceeded\n" ;
            }
        }
        //      C# -> System.Int32? TotalNewObjectsAdded
        // GraphQL -> totalNewObjectsAdded: Int! (scalar)
        if (this.TotalNewObjectsAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalNewObjectsAdded\n" ;
            } else {
                s += ind + "totalNewObjectsAdded\n" ;
            }
        }
        //      C# -> List<BackupStatsBucket>? BackupStatsBuckets
        // GraphQL -> backupStatsBuckets: [BackupStatsBucket!]! (type)
        if (this.BackupStatsBuckets != null) {
            var fspec = this.BackupStatsBuckets.AsFieldSpec(conf.Child("backupStatsBuckets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupStatsBuckets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumFullsFailed
        // GraphQL -> numFullsFailed: Int! (scalar)
        if (ec.Includes("numFullsFailed",true))
        {
            if(this.NumFullsFailed == null) {

                this.NumFullsFailed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFullsFailed != null && ec.Excludes("numFullsFailed",true))
        {
            this.NumFullsFailed = null;
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
        //      C# -> System.Int32? NumIncrementalsFailed
        // GraphQL -> numIncrementalsFailed: Int! (scalar)
        if (ec.Includes("numIncrementalsFailed",true))
        {
            if(this.NumIncrementalsFailed == null) {

                this.NumIncrementalsFailed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumIncrementalsFailed != null && ec.Excludes("numIncrementalsFailed",true))
        {
            this.NumIncrementalsFailed = null;
        }
        //      C# -> System.Int32? NumIncrementalsSucceeded
        // GraphQL -> numIncrementalsSucceeded: Int! (scalar)
        if (ec.Includes("numIncrementalsSucceeded",true))
        {
            if(this.NumIncrementalsSucceeded == null) {

                this.NumIncrementalsSucceeded = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumIncrementalsSucceeded != null && ec.Excludes("numIncrementalsSucceeded",true))
        {
            this.NumIncrementalsSucceeded = null;
        }
        //      C# -> System.Int32? TotalNewObjectsAdded
        // GraphQL -> totalNewObjectsAdded: Int! (scalar)
        if (ec.Includes("totalNewObjectsAdded",true))
        {
            if(this.TotalNewObjectsAdded == null) {

                this.TotalNewObjectsAdded = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalNewObjectsAdded != null && ec.Excludes("totalNewObjectsAdded",true))
        {
            this.TotalNewObjectsAdded = null;
        }
        //      C# -> List<BackupStatsBucket>? BackupStatsBuckets
        // GraphQL -> backupStatsBuckets: [BackupStatsBucket!]! (type)
        if (ec.Includes("backupStatsBuckets",false))
        {
            if(this.BackupStatsBuckets == null) {

                this.BackupStatsBuckets = new List<BackupStatsBucket>();
                this.BackupStatsBuckets.ApplyExploratoryFieldSpec(ec.NewChild("backupStatsBuckets"));

            } else {

                this.BackupStatsBuckets.ApplyExploratoryFieldSpec(ec.NewChild("backupStatsBuckets"));

            }
        }
        else if (this.BackupStatsBuckets != null && ec.Excludes("backupStatsBuckets",false))
        {
            this.BackupStatsBuckets = null;
        }
    }


    #endregion

    } // class DayToDayModeBackupStats
    
    #endregion

    public static class ListDayToDayModeBackupStatsExtensions
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
            this List<DayToDayModeBackupStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DayToDayModeBackupStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DayToDayModeBackupStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DayToDayModeBackupStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DayToDayModeBackupStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types