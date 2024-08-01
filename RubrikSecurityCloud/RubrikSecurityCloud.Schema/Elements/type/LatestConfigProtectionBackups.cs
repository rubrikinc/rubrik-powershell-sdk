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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion
        // GraphQL -> latestConfigProtectionBackupsByVersion: [ConfigProtectionBackups!]! (type)
        if (this.LatestConfigProtectionBackupsByVersion != null) {
            var fspec = this.LatestConfigProtectionBackupsByVersion.AsFieldSpec(conf.Child("latestConfigProtectionBackupsByVersion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestConfigProtectionBackupsByVersion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<ConfigProtectionBackups>? LatestConfigProtectionBackupsByVersion
        // GraphQL -> latestConfigProtectionBackupsByVersion: [ConfigProtectionBackups!]! (type)
        if (ec.Includes("latestConfigProtectionBackupsByVersion",false))
        {
            if(this.LatestConfigProtectionBackupsByVersion == null) {

                this.LatestConfigProtectionBackupsByVersion = new List<ConfigProtectionBackups>();
                this.LatestConfigProtectionBackupsByVersion.ApplyExploratoryFieldSpec(ec.NewChild("latestConfigProtectionBackupsByVersion"));

            } else {

                this.LatestConfigProtectionBackupsByVersion.ApplyExploratoryFieldSpec(ec.NewChild("latestConfigProtectionBackupsByVersion"));

            }
        }
        else if (this.LatestConfigProtectionBackupsByVersion != null && ec.Excludes("latestConfigProtectionBackupsByVersion",false))
        {
            this.LatestConfigProtectionBackupsByVersion = null;
        }
    }


    #endregion

    } // class LatestConfigProtectionBackups
    
    #endregion

    public static class ListLatestConfigProtectionBackupsExtensions
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
            this List<LatestConfigProtectionBackups> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LatestConfigProtectionBackups> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<LatestConfigProtectionBackups> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types