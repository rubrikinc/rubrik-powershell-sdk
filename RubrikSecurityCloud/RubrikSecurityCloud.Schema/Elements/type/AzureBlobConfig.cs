// AzureBlobConfig.cs
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
    #region AzureBlobConfig
    public class AzureBlobConfig: BaseType
    {
        #region members

        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: String! (scalar)
        [JsonProperty("backupLocationId")]
        public System.String? BackupLocationId { get; set; }

        //      C# -> System.String? BackupLocationName
        // GraphQL -> backupLocationName: String (scalar)
        [JsonProperty("backupLocationName")]
        public System.String? BackupLocationName { get; set; }

        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        [JsonProperty("continuousBackupRetentionInDays")]
        public System.Int32? ContinuousBackupRetentionInDays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureBlobConfig";
    }

    public AzureBlobConfig Set(
        System.String? BackupLocationId = null,
        System.String? BackupLocationName = null,
        System.Int32? ContinuousBackupRetentionInDays = null
    ) 
    {
        if ( BackupLocationId != null ) {
            this.BackupLocationId = BackupLocationId;
        }
        if ( BackupLocationName != null ) {
            this.BackupLocationName = BackupLocationName;
        }
        if ( ContinuousBackupRetentionInDays != null ) {
            this.ContinuousBackupRetentionInDays = ContinuousBackupRetentionInDays;
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
        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: String! (scalar)
        if (this.BackupLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupLocationId\n" ;
            } else {
                s += ind + "backupLocationId\n" ;
            }
        }
        //      C# -> System.String? BackupLocationName
        // GraphQL -> backupLocationName: String (scalar)
        if (this.BackupLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupLocationName\n" ;
            } else {
                s += ind + "backupLocationName\n" ;
            }
        }
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        if (this.ContinuousBackupRetentionInDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "continuousBackupRetentionInDays\n" ;
            } else {
                s += ind + "continuousBackupRetentionInDays\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: String! (scalar)
        if (ec.Includes("backupLocationId",true))
        {
            if(this.BackupLocationId == null) {

                this.BackupLocationId = "FETCH";

            } else {


            }
        }
        else if (this.BackupLocationId != null && ec.Excludes("backupLocationId",true))
        {
            this.BackupLocationId = null;
        }
        //      C# -> System.String? BackupLocationName
        // GraphQL -> backupLocationName: String (scalar)
        if (ec.Includes("backupLocationName",true))
        {
            if(this.BackupLocationName == null) {

                this.BackupLocationName = "FETCH";

            } else {


            }
        }
        else if (this.BackupLocationName != null && ec.Excludes("backupLocationName",true))
        {
            this.BackupLocationName = null;
        }
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        if (ec.Includes("continuousBackupRetentionInDays",true))
        {
            if(this.ContinuousBackupRetentionInDays == null) {

                this.ContinuousBackupRetentionInDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.ContinuousBackupRetentionInDays != null && ec.Excludes("continuousBackupRetentionInDays",true))
        {
            this.ContinuousBackupRetentionInDays = null;
        }
    }


    #endregion

    } // class AzureBlobConfig
    
    #endregion

    public static class ListAzureBlobConfigExtensions
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
            this List<AzureBlobConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureBlobConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureBlobConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureBlobConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureBlobConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types