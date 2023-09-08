// SapHanaLogSnapshotAppMetadata.cs
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
    #region SapHanaLogSnapshotAppMetadata
    public class SapHanaLogSnapshotAppMetadata: BaseType
    {
        #region members

        //      C# -> List<SapHanaLogBackup>? Backups
        // GraphQL -> backups: [SapHanaLogBackup!] (type)
        [JsonProperty("backups")]
        public List<SapHanaLogBackup>? Backups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaLogSnapshotAppMetadata";
    }

    public SapHanaLogSnapshotAppMetadata Set(
        List<SapHanaLogBackup>? Backups = null
    ) 
    {
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
        //      C# -> List<SapHanaLogBackup>? Backups
        // GraphQL -> backups: [SapHanaLogBackup!] (type)
        if (this.Backups != null) {
            var fspec = this.Backups.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "backups {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SapHanaLogBackup>? Backups
        // GraphQL -> backups: [SapHanaLogBackup!] (type)
        if (this.Backups == null && ec.Includes("backups",false))
        {
            this.Backups = new List<SapHanaLogBackup>();
            this.Backups.ApplyExploratoryFieldSpec(ec.NewChild("backups"));
        }
    }


    #endregion

    } // class SapHanaLogSnapshotAppMetadata
    
    #endregion

    public static class ListSapHanaLogSnapshotAppMetadataExtensions
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
            this List<SapHanaLogSnapshotAppMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaLogSnapshotAppMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaLogSnapshotAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SapHanaLogSnapshotAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types