// Db2LogBackupFile.cs
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
    #region Db2LogBackupFile
    public class Db2LogBackupFile: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long (scalar)
        [JsonProperty("backupFileSizeInBytes")]
        public System.Int64? BackupFileSizeInBytes { get; set; }

        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        [JsonProperty("backupId")]
        public System.String? BackupId { get; set; }

        //      C# -> System.String? ChainNumber
        // GraphQL -> chainNumber: String (scalar)
        [JsonProperty("chainNumber")]
        public System.String? ChainNumber { get; set; }

        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        [JsonProperty("destinationPath")]
        public System.String? DestinationPath { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? LogFileName
        // GraphQL -> logFileName: String (scalar)
        [JsonProperty("logFileName")]
        public System.String? LogFileName { get; set; }

        //      C# -> System.Int32? PartitionNumber
        // GraphQL -> partitionNumber: Int (scalar)
        [JsonProperty("partitionNumber")]
        public System.Int32? PartitionNumber { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2LogBackupFile";
    }

    public Db2LogBackupFile Set(
        System.Int64? BackupFileSizeInBytes = null,
        System.String? BackupId = null,
        System.String? ChainNumber = null,
        System.String? DestinationPath = null,
        DateTime? EndTime = null,
        System.String? LogFileName = null,
        System.Int32? PartitionNumber = null,
        DateTime? StartTime = null
    ) 
    {
        if ( BackupFileSizeInBytes != null ) {
            this.BackupFileSizeInBytes = BackupFileSizeInBytes;
        }
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( ChainNumber != null ) {
            this.ChainNumber = ChainNumber;
        }
        if ( DestinationPath != null ) {
            this.DestinationPath = DestinationPath;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( LogFileName != null ) {
            this.LogFileName = LogFileName;
        }
        if ( PartitionNumber != null ) {
            this.PartitionNumber = PartitionNumber;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long (scalar)
        if (this.BackupFileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupFileSizeInBytes\n" ;
            } else {
                s += ind + "backupFileSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (this.BackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupId\n" ;
            } else {
                s += ind + "backupId\n" ;
            }
        }
        //      C# -> System.String? ChainNumber
        // GraphQL -> chainNumber: String (scalar)
        if (this.ChainNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chainNumber\n" ;
            } else {
                s += ind + "chainNumber\n" ;
            }
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (this.DestinationPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationPath\n" ;
            } else {
                s += ind + "destinationPath\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? LogFileName
        // GraphQL -> logFileName: String (scalar)
        if (this.LogFileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logFileName\n" ;
            } else {
                s += ind + "logFileName\n" ;
            }
        }
        //      C# -> System.Int32? PartitionNumber
        // GraphQL -> partitionNumber: Int (scalar)
        if (this.PartitionNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partitionNumber\n" ;
            } else {
                s += ind + "partitionNumber\n" ;
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
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long (scalar)
        if (ec.Includes("backupFileSizeInBytes",true))
        {
            if(this.BackupFileSizeInBytes == null) {

                this.BackupFileSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.BackupFileSizeInBytes != null && ec.Excludes("backupFileSizeInBytes",true))
        {
            this.BackupFileSizeInBytes = null;
        }
        //      C# -> System.String? BackupId
        // GraphQL -> backupId: String (scalar)
        if (ec.Includes("backupId",true))
        {
            if(this.BackupId == null) {

                this.BackupId = "FETCH";

            } else {


            }
        }
        else if (this.BackupId != null && ec.Excludes("backupId",true))
        {
            this.BackupId = null;
        }
        //      C# -> System.String? ChainNumber
        // GraphQL -> chainNumber: String (scalar)
        if (ec.Includes("chainNumber",true))
        {
            if(this.ChainNumber == null) {

                this.ChainNumber = "FETCH";

            } else {


            }
        }
        else if (this.ChainNumber != null && ec.Excludes("chainNumber",true))
        {
            this.ChainNumber = null;
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String (scalar)
        if (ec.Includes("destinationPath",true))
        {
            if(this.DestinationPath == null) {

                this.DestinationPath = "FETCH";

            } else {


            }
        }
        else if (this.DestinationPath != null && ec.Excludes("destinationPath",true))
        {
            this.DestinationPath = null;
        }
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
        //      C# -> System.String? LogFileName
        // GraphQL -> logFileName: String (scalar)
        if (ec.Includes("logFileName",true))
        {
            if(this.LogFileName == null) {

                this.LogFileName = "FETCH";

            } else {


            }
        }
        else if (this.LogFileName != null && ec.Excludes("logFileName",true))
        {
            this.LogFileName = null;
        }
        //      C# -> System.Int32? PartitionNumber
        // GraphQL -> partitionNumber: Int (scalar)
        if (ec.Includes("partitionNumber",true))
        {
            if(this.PartitionNumber == null) {

                this.PartitionNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.PartitionNumber != null && ec.Excludes("partitionNumber",true))
        {
            this.PartitionNumber = null;
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

    } // class Db2LogBackupFile
    
    #endregion

    public static class ListDb2LogBackupFileExtensions
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
            this List<Db2LogBackupFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Db2LogBackupFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2LogBackupFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2LogBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2LogBackupFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types