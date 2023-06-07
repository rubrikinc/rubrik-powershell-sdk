// Db2LogSnapshotAppMetadata.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region Db2LogSnapshotAppMetadata
    public class Db2LogSnapshotAppMetadata: BaseType
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<Db2LogBackupFile>? Backups
        // GraphQL -> backups: [Db2LogBackupFile!] (type)
        [JsonProperty("backups")]
        public List<Db2LogBackupFile>? Backups { get; set; }


        #endregion

    #region methods

    public Db2LogSnapshotAppMetadata Set(
        System.String? SnapshotId = null,
        List<Db2LogBackupFile>? Backups = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Backups != null ) {
            this.Backups = Backups;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> List<Db2LogBackupFile>? Backups
        // GraphQL -> backups: [Db2LogBackupFile!] (type)
        if (this.Backups != null) {
            s += ind + "backups {\n" + this.Backups.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> List<Db2LogBackupFile>? Backups
        // GraphQL -> backups: [Db2LogBackupFile!] (type)
        if (this.Backups == null && Exploration.Includes(parent + ".backups"))
        {
            this.Backups = new List<Db2LogBackupFile>();
            this.Backups.ApplyExploratoryFieldSpec(parent + ".backups");
        }
    }


    #endregion

    } // class Db2LogSnapshotAppMetadata
    
    #endregion

    public static class ListDb2LogSnapshotAppMetadataExtensions
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
            this List<Db2LogSnapshotAppMetadata> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2LogSnapshotAppMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2LogSnapshotAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types