// OracleLiveMount.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region OracleLiveMount
    public class OracleLiveMount: IFragment
    {
        #region members
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        [JsonProperty("creationDate")]
        public DateTime? CreationDate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsFilesOnlyMount
        // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
        [JsonProperty("isFilesOnlyMount")]
        public System.Boolean? IsFilesOnlyMount { get; set; }

        //      C# -> System.Boolean? IsInstantRecovered
        // GraphQL -> isInstantRecovered: Boolean! (scalar)
        [JsonProperty("isInstantRecovered")]
        public System.Boolean? IsInstantRecovered { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        [JsonProperty("mountedDatabaseName")]
        public System.String? MountedDatabaseName { get; set; }

        //      C# -> System.String? TargetHostMount
        // GraphQL -> targetHostMount: String! (scalar)
        [JsonProperty("targetHostMount")]
        public System.String? TargetHostMount { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> OracleDatabase? MountedDatabase
        // GraphQL -> mountedDatabase: OracleDatabase (type)
        [JsonProperty("mountedDatabase")]
        public OracleDatabase? MountedDatabase { get; set; }

        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        [JsonProperty("owner")]
        public User? Owner { get; set; }

        //      C# -> OracleDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: OracleDatabase (type)
        [JsonProperty("sourceDatabase")]
        public OracleDatabase? SourceDatabase { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        //      C# -> OracleHost? TargetOracleHost
        // GraphQL -> targetOracleHost: OracleHost (type)
        [JsonProperty("targetOracleHost")]
        public OracleHost? TargetOracleHost { get; set; }

        //      C# -> OracleRac? TargetOracleRac
        // GraphQL -> targetOracleRac: OracleRac (type)
        [JsonProperty("targetOracleRac")]
        public OracleRac? TargetOracleRac { get; set; }

        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        [JsonProperty("status")]
        public OracleLiveMountStatus? Status { get; set; }

        #endregion

    #region methods

    public OracleLiveMount Set(
        System.String? CdmId = null,
        DateTime? CreationDate = null,
        System.String? Id = null,
        System.Boolean? IsFilesOnlyMount = null,
        System.Boolean? IsInstantRecovered = null,
        System.Boolean? IsReady = null,
        System.String? MountedDatabaseName = null,
        System.String? TargetHostMount = null,
        Cluster? Cluster = null,
        OracleDatabase? MountedDatabase = null,
        User? Owner = null,
        OracleDatabase? SourceDatabase = null,
        CdmSnapshot? SourceSnapshot = null,
        OracleHost? TargetOracleHost = null,
        OracleRac? TargetOracleRac = null,
        OracleLiveMountStatus? Status = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CreationDate != null ) {
            this.CreationDate = CreationDate;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsFilesOnlyMount != null ) {
            this.IsFilesOnlyMount = IsFilesOnlyMount;
        }
        if ( IsInstantRecovered != null ) {
            this.IsInstantRecovered = IsInstantRecovered;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountedDatabaseName != null ) {
            this.MountedDatabaseName = MountedDatabaseName;
        }
        if ( TargetHostMount != null ) {
            this.TargetHostMount = TargetHostMount;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( MountedDatabase != null ) {
            this.MountedDatabase = MountedDatabase;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( SourceDatabase != null ) {
            this.SourceDatabase = SourceDatabase;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
        }
        if ( TargetOracleHost != null ) {
            this.TargetOracleHost = TargetOracleHost;
        }
        if ( TargetOracleRac != null ) {
            this.TargetOracleRac = TargetOracleRac;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> DateTime? CreationDate
            // GraphQL -> creationDate: DateTime (scalar)
            if (this.CreationDate != null)
            {
                 s += ind + "creationDate\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsFilesOnlyMount
            // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
            if (this.IsFilesOnlyMount != null)
            {
                 s += ind + "isFilesOnlyMount\n";

            }
            //      C# -> System.Boolean? IsInstantRecovered
            // GraphQL -> isInstantRecovered: Boolean! (scalar)
            if (this.IsInstantRecovered != null)
            {
                 s += ind + "isInstantRecovered\n";

            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady != null)
            {
                 s += ind + "isReady\n";

            }
            //      C# -> System.String? MountedDatabaseName
            // GraphQL -> mountedDatabaseName: String! (scalar)
            if (this.MountedDatabaseName != null)
            {
                 s += ind + "mountedDatabaseName\n";

            }
            //      C# -> System.String? TargetHostMount
            // GraphQL -> targetHostMount: String! (scalar)
            if (this.TargetHostMount != null)
            {
                 s += ind + "targetHostMount\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleDatabase? MountedDatabase
            // GraphQL -> mountedDatabase: OracleDatabase (type)
            if (this.MountedDatabase != null)
            {
                 s += ind + "mountedDatabase\n";

                 s += ind + "{\n" + 
                 this.MountedDatabase.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> User? Owner
            // GraphQL -> owner: User! (type)
            if (this.Owner != null)
            {
                 s += ind + "owner\n";

                 s += ind + "{\n" + 
                 this.Owner.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleDatabase? SourceDatabase
            // GraphQL -> sourceDatabase: OracleDatabase (type)
            if (this.SourceDatabase != null)
            {
                 s += ind + "sourceDatabase\n";

                 s += ind + "{\n" + 
                 this.SourceDatabase.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot != null)
            {
                 s += ind + "sourceSnapshot\n";

                 s += ind + "{\n" + 
                 this.SourceSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleHost? TargetOracleHost
            // GraphQL -> targetOracleHost: OracleHost (type)
            if (this.TargetOracleHost != null)
            {
                 s += ind + "targetOracleHost\n";

                 s += ind + "{\n" + 
                 this.TargetOracleHost.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleRac? TargetOracleRac
            // GraphQL -> targetOracleRac: OracleRac (type)
            if (this.TargetOracleRac != null)
            {
                 s += ind + "targetOracleRac\n";

                 s += ind + "{\n" + 
                 this.TargetOracleRac.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleLiveMountStatus? Status
            // GraphQL -> status: OracleLiveMountStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> DateTime? CreationDate
            // GraphQL -> creationDate: DateTime (scalar)
            if (this.CreationDate == null && Exploration.Includes(parent + ".creationDate$"))
            {
                this.CreationDate = new DateTime();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsFilesOnlyMount
            // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
            if (this.IsFilesOnlyMount == null && Exploration.Includes(parent + ".isFilesOnlyMount$"))
            {
                this.IsFilesOnlyMount = new System.Boolean();
            }
            //      C# -> System.Boolean? IsInstantRecovered
            // GraphQL -> isInstantRecovered: Boolean! (scalar)
            if (this.IsInstantRecovered == null && Exploration.Includes(parent + ".isInstantRecovered$"))
            {
                this.IsInstantRecovered = new System.Boolean();
            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady == null && Exploration.Includes(parent + ".isReady$"))
            {
                this.IsReady = new System.Boolean();
            }
            //      C# -> System.String? MountedDatabaseName
            // GraphQL -> mountedDatabaseName: String! (scalar)
            if (this.MountedDatabaseName == null && Exploration.Includes(parent + ".mountedDatabaseName$"))
            {
                this.MountedDatabaseName = new System.String("FETCH");
            }
            //      C# -> System.String? TargetHostMount
            // GraphQL -> targetHostMount: String! (scalar)
            if (this.TargetHostMount == null && Exploration.Includes(parent + ".targetHostMount$"))
            {
                this.TargetHostMount = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> OracleDatabase? MountedDatabase
            // GraphQL -> mountedDatabase: OracleDatabase (type)
            if (this.MountedDatabase == null && Exploration.Includes(parent + ".mountedDatabase"))
            {
                this.MountedDatabase = new OracleDatabase();
                this.MountedDatabase.ApplyExploratoryFragment(parent + ".mountedDatabase");
            }
            //      C# -> User? Owner
            // GraphQL -> owner: User! (type)
            if (this.Owner == null && Exploration.Includes(parent + ".owner"))
            {
                this.Owner = new User();
                this.Owner.ApplyExploratoryFragment(parent + ".owner");
            }
            //      C# -> OracleDatabase? SourceDatabase
            // GraphQL -> sourceDatabase: OracleDatabase (type)
            if (this.SourceDatabase == null && Exploration.Includes(parent + ".sourceDatabase"))
            {
                this.SourceDatabase = new OracleDatabase();
                this.SourceDatabase.ApplyExploratoryFragment(parent + ".sourceDatabase");
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
            {
                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFragment(parent + ".sourceSnapshot");
            }
            //      C# -> OracleHost? TargetOracleHost
            // GraphQL -> targetOracleHost: OracleHost (type)
            if (this.TargetOracleHost == null && Exploration.Includes(parent + ".targetOracleHost"))
            {
                this.TargetOracleHost = new OracleHost();
                this.TargetOracleHost.ApplyExploratoryFragment(parent + ".targetOracleHost");
            }
            //      C# -> OracleRac? TargetOracleRac
            // GraphQL -> targetOracleRac: OracleRac (type)
            if (this.TargetOracleRac == null && Exploration.Includes(parent + ".targetOracleRac"))
            {
                this.TargetOracleRac = new OracleRac();
                this.TargetOracleRac.ApplyExploratoryFragment(parent + ".targetOracleRac");
            }
            //      C# -> OracleLiveMountStatus? Status
            // GraphQL -> status: OracleLiveMountStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new OracleLiveMountStatus();
            }
        }


    #endregion

    } // class OracleLiveMount
    #endregion

    public static class ListOracleLiveMountExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<OracleLiveMount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleLiveMount> list, 
            String parent = "")
        {
            var item = new OracleLiveMount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types