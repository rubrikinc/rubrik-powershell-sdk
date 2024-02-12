// BackupStatsBucket.cs
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
    #region BackupStatsBucket
    public class BackupStatsBucket: BaseType
    {
        #region members

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        [JsonProperty("numFailed")]
        public System.Int32? NumFailed { get; set; }

        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        [JsonProperty("numSucceeded")]
        public System.Int32? NumSucceeded { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupStatsBucket";
    }

    public BackupStatsBucket Set(
        DateTime? EndTime = null,
        System.Int32? NumFailed = null,
        System.Int32? NumSucceeded = null,
        DateTime? StartTime = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( NumFailed != null ) {
            this.NumFailed = NumFailed;
        }
        if ( NumSucceeded != null ) {
            this.NumSucceeded = NumSucceeded;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (this.NumFailed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFailed\n" ;
            } else {
                s += ind + "numFailed\n" ;
            }
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (this.NumSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSucceeded\n" ;
            } else {
                s += ind + "numSucceeded\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (ec.Includes("numFailed",true))
        {
            if(this.NumFailed == null) {

                this.NumFailed = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFailed != null && ec.Excludes("numFailed",true))
        {
            this.NumFailed = null;
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (ec.Includes("numSucceeded",true))
        {
            if(this.NumSucceeded == null) {

                this.NumSucceeded = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSucceeded != null && ec.Excludes("numSucceeded",true))
        {
            this.NumSucceeded = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
    }


    #endregion

    } // class BackupStatsBucket
    
    #endregion

    public static class ListBackupStatsBucketExtensions
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
            this List<BackupStatsBucket> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<BackupStatsBucket> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupStatsBucket> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupStatsBucket());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupStatsBucket> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types