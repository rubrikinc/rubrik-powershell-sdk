// LatestConfigProtectionBackups.cs
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
    #region LatestConfigProtectionBackups
    public class LatestConfigProtectionBackups: BaseType
    {
        #region members

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion
        // GraphQL -> latestConfigProtectionBackupsByVersion: [ConfigProtectionBackups!]! (type)
        [JsonProperty("latestConfigProtectionBackupsByVersion")]
        public List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LatestConfigProtectionBackups";
    }

    public LatestConfigProtectionBackups Set(
        Cluster? Cluster = null,
        List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( LatestConfigProtectionBackupsByVersion != null ) {
            this.LatestConfigProtectionBackupsByVersion = LatestConfigProtectionBackupsByVersion;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion
        // GraphQL -> latestConfigProtectionBackupsByVersion: [ConfigProtectionBackups!]! (type)
        if (this.LatestConfigProtectionBackupsByVersion != null) {
            var fspec = this.LatestConfigProtectionBackupsByVersion.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestConfigProtectionBackupsByVersion {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion
        // GraphQL -> latestConfigProtectionBackupsByVersion: [ConfigProtectionBackups!]! (type)
        if (this.LatestConfigProtectionBackupsByVersion == null && ec.Includes("latestConfigProtectionBackupsByVersion",false))
        {
            this.LatestConfigProtectionBackupsByVersion = new List<ConfigProtectionBackups>();
            this.LatestConfigProtectionBackupsByVersion.ApplyExploratoryFieldSpec(ec.NewChild("latestConfigProtectionBackupsByVersion"));
        }
    }


    #endregion

    } // class LatestConfigProtectionBackups
    
    #endregion

    public static class ListLatestConfigProtectionBackupsExtensions
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
            this List<LatestConfigProtectionBackups> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LatestConfigProtectionBackups> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LatestConfigProtectionBackups());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<LatestConfigProtectionBackups> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types