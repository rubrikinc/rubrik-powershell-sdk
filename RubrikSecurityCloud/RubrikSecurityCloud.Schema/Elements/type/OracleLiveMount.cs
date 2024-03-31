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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region OracleLiveMount
    public class OracleLiveMount: BaseType
    {
        #region members

        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        [JsonProperty("status")]
        public OracleLiveMountStatus? Status { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleLiveMount";
    }

    public OracleLiveMount Set(
        OracleLiveMountStatus? Status = null,
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
        OracleRac? TargetOracleRac = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
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
        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (this.CreationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationDate\n" ;
            } else {
                s += ind + "creationDate\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsFilesOnlyMount
        // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
        if (this.IsFilesOnlyMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFilesOnlyMount\n" ;
            } else {
                s += ind + "isFilesOnlyMount\n" ;
            }
        }
        //      C# -> System.Boolean? IsInstantRecovered
        // GraphQL -> isInstantRecovered: Boolean! (scalar)
        if (this.IsInstantRecovered != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInstantRecovered\n" ;
            } else {
                s += ind + "isInstantRecovered\n" ;
            }
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReady\n" ;
            } else {
                s += ind + "isReady\n" ;
            }
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (this.MountedDatabaseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedDatabaseName\n" ;
            } else {
                s += ind + "mountedDatabaseName\n" ;
            }
        }
        //      C# -> System.String? TargetHostMount
        // GraphQL -> targetHostMount: String! (scalar)
        if (this.TargetHostMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetHostMount\n" ;
            } else {
                s += ind + "targetHostMount\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleDatabase? MountedDatabase
        // GraphQL -> mountedDatabase: OracleDatabase (type)
        if (this.MountedDatabase != null) {
            var fspec = this.MountedDatabase.AsFieldSpec(conf.Child("mountedDatabase"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mountedDatabase {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (this.Owner != null) {
            var fspec = this.Owner.AsFieldSpec(conf.Child("owner"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "owner {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: OracleDatabase (type)
        if (this.SourceDatabase != null) {
            var fspec = this.SourceDatabase.AsFieldSpec(conf.Child("sourceDatabase"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceDatabase {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleHost? TargetOracleHost
        // GraphQL -> targetOracleHost: OracleHost (type)
        if (this.TargetOracleHost != null) {
            var fspec = this.TargetOracleHost.AsFieldSpec(conf.Child("targetOracleHost"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetOracleHost {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleRac? TargetOracleRac
        // GraphQL -> targetOracleRac: OracleRac (type)
        if (this.TargetOracleRac != null) {
            var fspec = this.TargetOracleRac.AsFieldSpec(conf.Child("targetOracleRac"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetOracleRac {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new OracleLiveMountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (ec.Includes("creationDate",true))
        {
            if(this.CreationDate == null) {

                this.CreationDate = new DateTime();

            } else {


            }
        }
        else if (this.CreationDate != null && ec.Excludes("creationDate",true))
        {
            this.CreationDate = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsFilesOnlyMount
        // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
        if (ec.Includes("isFilesOnlyMount",true))
        {
            if(this.IsFilesOnlyMount == null) {

                this.IsFilesOnlyMount = true;

            } else {


            }
        }
        else if (this.IsFilesOnlyMount != null && ec.Excludes("isFilesOnlyMount",true))
        {
            this.IsFilesOnlyMount = null;
        }
        //      C# -> System.Boolean? IsInstantRecovered
        // GraphQL -> isInstantRecovered: Boolean! (scalar)
        if (ec.Includes("isInstantRecovered",true))
        {
            if(this.IsInstantRecovered == null) {

                this.IsInstantRecovered = true;

            } else {


            }
        }
        else if (this.IsInstantRecovered != null && ec.Excludes("isInstantRecovered",true))
        {
            this.IsInstantRecovered = null;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (ec.Includes("isReady",true))
        {
            if(this.IsReady == null) {

                this.IsReady = true;

            } else {


            }
        }
        else if (this.IsReady != null && ec.Excludes("isReady",true))
        {
            this.IsReady = null;
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (ec.Includes("mountedDatabaseName",true))
        {
            if(this.MountedDatabaseName == null) {

                this.MountedDatabaseName = "FETCH";

            } else {


            }
        }
        else if (this.MountedDatabaseName != null && ec.Excludes("mountedDatabaseName",true))
        {
            this.MountedDatabaseName = null;
        }
        //      C# -> System.String? TargetHostMount
        // GraphQL -> targetHostMount: String! (scalar)
        if (ec.Includes("targetHostMount",true))
        {
            if(this.TargetHostMount == null) {

                this.TargetHostMount = "FETCH";

            } else {


            }
        }
        else if (this.TargetHostMount != null && ec.Excludes("targetHostMount",true))
        {
            this.TargetHostMount = null;
        }
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
        //      C# -> OracleDatabase? MountedDatabase
        // GraphQL -> mountedDatabase: OracleDatabase (type)
        if (ec.Includes("mountedDatabase",false))
        {
            if(this.MountedDatabase == null) {

                this.MountedDatabase = new OracleDatabase();
                this.MountedDatabase.ApplyExploratoryFieldSpec(ec.NewChild("mountedDatabase"));

            } else {

                this.MountedDatabase.ApplyExploratoryFieldSpec(ec.NewChild("mountedDatabase"));

            }
        }
        else if (this.MountedDatabase != null && ec.Excludes("mountedDatabase",false))
        {
            this.MountedDatabase = null;
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (ec.Includes("owner",false))
        {
            if(this.Owner == null) {

                this.Owner = new User();
                this.Owner.ApplyExploratoryFieldSpec(ec.NewChild("owner"));

            } else {

                this.Owner.ApplyExploratoryFieldSpec(ec.NewChild("owner"));

            }
        }
        else if (this.Owner != null && ec.Excludes("owner",false))
        {
            this.Owner = null;
        }
        //      C# -> OracleDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: OracleDatabase (type)
        if (ec.Includes("sourceDatabase",false))
        {
            if(this.SourceDatabase == null) {

                this.SourceDatabase = new OracleDatabase();
                this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));

            } else {

                this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));

            }
        }
        else if (this.SourceDatabase != null && ec.Excludes("sourceDatabase",false))
        {
            this.SourceDatabase = null;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (ec.Includes("sourceSnapshot",false))
        {
            if(this.SourceSnapshot == null) {

                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            } else {

                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            }
        }
        else if (this.SourceSnapshot != null && ec.Excludes("sourceSnapshot",false))
        {
            this.SourceSnapshot = null;
        }
        //      C# -> OracleHost? TargetOracleHost
        // GraphQL -> targetOracleHost: OracleHost (type)
        if (ec.Includes("targetOracleHost",false))
        {
            if(this.TargetOracleHost == null) {

                this.TargetOracleHost = new OracleHost();
                this.TargetOracleHost.ApplyExploratoryFieldSpec(ec.NewChild("targetOracleHost"));

            } else {

                this.TargetOracleHost.ApplyExploratoryFieldSpec(ec.NewChild("targetOracleHost"));

            }
        }
        else if (this.TargetOracleHost != null && ec.Excludes("targetOracleHost",false))
        {
            this.TargetOracleHost = null;
        }
        //      C# -> OracleRac? TargetOracleRac
        // GraphQL -> targetOracleRac: OracleRac (type)
        if (ec.Includes("targetOracleRac",false))
        {
            if(this.TargetOracleRac == null) {

                this.TargetOracleRac = new OracleRac();
                this.TargetOracleRac.ApplyExploratoryFieldSpec(ec.NewChild("targetOracleRac"));

            } else {

                this.TargetOracleRac.ApplyExploratoryFieldSpec(ec.NewChild("targetOracleRac"));

            }
        }
        else if (this.TargetOracleRac != null && ec.Excludes("targetOracleRac",false))
        {
            this.TargetOracleRac = null;
        }
    }


    #endregion

    } // class OracleLiveMount
    
    #endregion

    public static class ListOracleLiveMountExtensions
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
            this List<OracleLiveMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleLiveMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleLiveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types