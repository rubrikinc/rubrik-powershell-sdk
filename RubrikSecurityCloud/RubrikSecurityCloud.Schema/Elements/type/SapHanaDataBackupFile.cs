// SapHanaDataBackupFile.cs
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
    #region SapHanaDataBackupFile
    public class SapHanaDataBackupFile: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        [JsonProperty("backupFileSizeInBytes")]
        public System.Int64? BackupFileSizeInBytes { get; set; }

        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        [JsonProperty("destinationPath")]
        public System.String? DestinationPath { get; set; }

        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String! (scalar)
        [JsonProperty("externalBackupId")]
        public System.String? ExternalBackupId { get; set; }

        //      C# -> System.Int64? RedoLogPositionOpt
        // GraphQL -> redoLogPositionOpt: Long (scalar)
        [JsonProperty("redoLogPositionOpt")]
        public System.Int64? RedoLogPositionOpt { get; set; }

        //      C# -> System.String? ServiceType
        // GraphQL -> serviceType: String! (scalar)
        [JsonProperty("serviceType")]
        public System.String? ServiceType { get; set; }

        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long! (scalar)
        [JsonProperty("sourceId")]
        public System.Int64? SourceId { get; set; }

        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String! (scalar)
        [JsonProperty("sourceType")]
        public System.String? SourceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaDataBackupFile";
    }

    public SapHanaDataBackupFile Set(
        System.Int64? BackupFileSizeInBytes = null,
        System.String? DestinationPath = null,
        System.String? ExternalBackupId = null,
        System.Int64? RedoLogPositionOpt = null,
        System.String? ServiceType = null,
        System.Int64? SourceId = null,
        System.String? SourceType = null
    ) 
    {
        if ( BackupFileSizeInBytes != null ) {
            this.BackupFileSizeInBytes = BackupFileSizeInBytes;
        }
        if ( DestinationPath != null ) {
            this.DestinationPath = DestinationPath;
        }
        if ( ExternalBackupId != null ) {
            this.ExternalBackupId = ExternalBackupId;
        }
        if ( RedoLogPositionOpt != null ) {
            this.RedoLogPositionOpt = RedoLogPositionOpt;
        }
        if ( ServiceType != null ) {
            this.ServiceType = ServiceType;
        }
        if ( SourceId != null ) {
            this.SourceId = SourceId;
        }
        if ( SourceType != null ) {
            this.SourceType = SourceType;
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
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
        if (this.BackupFileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupFileSizeInBytes\n" ;
            } else {
                s += ind + "backupFileSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        if (this.DestinationPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationPath\n" ;
            } else {
                s += ind + "destinationPath\n" ;
            }
        }
        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String! (scalar)
        if (this.ExternalBackupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalBackupId\n" ;
            } else {
                s += ind + "externalBackupId\n" ;
            }
        }
        //      C# -> System.Int64? RedoLogPositionOpt
        // GraphQL -> redoLogPositionOpt: Long (scalar)
        if (this.RedoLogPositionOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redoLogPositionOpt\n" ;
            } else {
                s += ind + "redoLogPositionOpt\n" ;
            }
        }
        //      C# -> System.String? ServiceType
        // GraphQL -> serviceType: String! (scalar)
        if (this.ServiceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceType\n" ;
            } else {
                s += ind + "serviceType\n" ;
            }
        }
        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long! (scalar)
        if (this.SourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceId\n" ;
            } else {
                s += ind + "sourceId\n" ;
            }
        }
        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String! (scalar)
        if (this.SourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceType\n" ;
            } else {
                s += ind + "sourceType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BackupFileSizeInBytes
        // GraphQL -> backupFileSizeInBytes: Long! (scalar)
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
        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
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
        //      C# -> System.String? ExternalBackupId
        // GraphQL -> externalBackupId: String! (scalar)
        if (ec.Includes("externalBackupId",true))
        {
            if(this.ExternalBackupId == null) {

                this.ExternalBackupId = "FETCH";

            } else {


            }
        }
        else if (this.ExternalBackupId != null && ec.Excludes("externalBackupId",true))
        {
            this.ExternalBackupId = null;
        }
        //      C# -> System.Int64? RedoLogPositionOpt
        // GraphQL -> redoLogPositionOpt: Long (scalar)
        if (ec.Includes("redoLogPositionOpt",true))
        {
            if(this.RedoLogPositionOpt == null) {

                this.RedoLogPositionOpt = new System.Int64();

            } else {


            }
        }
        else if (this.RedoLogPositionOpt != null && ec.Excludes("redoLogPositionOpt",true))
        {
            this.RedoLogPositionOpt = null;
        }
        //      C# -> System.String? ServiceType
        // GraphQL -> serviceType: String! (scalar)
        if (ec.Includes("serviceType",true))
        {
            if(this.ServiceType == null) {

                this.ServiceType = "FETCH";

            } else {


            }
        }
        else if (this.ServiceType != null && ec.Excludes("serviceType",true))
        {
            this.ServiceType = null;
        }
        //      C# -> System.Int64? SourceId
        // GraphQL -> sourceId: Long! (scalar)
        if (ec.Includes("sourceId",true))
        {
            if(this.SourceId == null) {

                this.SourceId = new System.Int64();

            } else {


            }
        }
        else if (this.SourceId != null && ec.Excludes("sourceId",true))
        {
            this.SourceId = null;
        }
        //      C# -> System.String? SourceType
        // GraphQL -> sourceType: String! (scalar)
        if (ec.Includes("sourceType",true))
        {
            if(this.SourceType == null) {

                this.SourceType = "FETCH";

            } else {


            }
        }
        else if (this.SourceType != null && ec.Excludes("sourceType",true))
        {
            this.SourceType = null;
        }
    }


    #endregion

    } // class SapHanaDataBackupFile
    
    #endregion

    public static class ListSapHanaDataBackupFileExtensions
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
            this List<SapHanaDataBackupFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaDataBackupFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaDataBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaDataBackupFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types