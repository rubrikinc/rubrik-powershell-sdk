// MssqlLogShippingTarget.cs
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
    #region MssqlLogShippingTarget
    public class MssqlLogShippingTarget: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? LagTimeFromPrimary
        // GraphQL -> lagTimeFromPrimary: Long! (scalar)
        [JsonProperty("lagTimeFromPrimary")]
        public System.Int64? LagTimeFromPrimary { get; set; }

        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        [JsonProperty("lastAppliedPoint")]
        public DateTime? LastAppliedPoint { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? LogFrequency
        // GraphQL -> logFrequency: Long! (scalar)
        [JsonProperty("logFrequency")]
        public System.Int64? LogFrequency { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> Cluster? PrimaryCluster
        // GraphQL -> primaryCluster: Cluster (type)
        [JsonProperty("primaryCluster")]
        public Cluster? PrimaryCluster { get; set; }

        //      C# -> MssqlDatabase? PrimaryDatabase
        // GraphQL -> primaryDatabase: MssqlDatabase (type)
        [JsonProperty("primaryDatabase")]
        public MssqlDatabase? PrimaryDatabase { get; set; }

        //      C# -> MssqlDatabase? SecondaryDatabase
        // GraphQL -> secondaryDatabase: MssqlDatabase (type)
        [JsonProperty("secondaryDatabase")]
        public MssqlDatabase? SecondaryDatabase { get; set; }

        //      C# -> MssqlInstance? SecondaryInstance
        // GraphQL -> secondaryInstance: MssqlInstance (type)
        [JsonProperty("secondaryInstance")]
        public MssqlInstance? SecondaryInstance { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlLogShippingTarget";
    }

    public MssqlLogShippingTarget Set(
        System.String? CdmId = null,
        System.String? Fid = null,
        System.Int64? LagTimeFromPrimary = null,
        DateTime? LastAppliedPoint = null,
        System.String? Location = null,
        System.Int64? LogFrequency = null,
        System.String? State = null,
        System.String? Status = null,
        Cluster? Cluster = null,
        Cluster? PrimaryCluster = null,
        MssqlDatabase? PrimaryDatabase = null,
        MssqlDatabase? SecondaryDatabase = null,
        MssqlInstance? SecondaryInstance = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( LagTimeFromPrimary != null ) {
            this.LagTimeFromPrimary = LagTimeFromPrimary;
        }
        if ( LastAppliedPoint != null ) {
            this.LastAppliedPoint = LastAppliedPoint;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( LogFrequency != null ) {
            this.LogFrequency = LogFrequency;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( PrimaryCluster != null ) {
            this.PrimaryCluster = PrimaryCluster;
        }
        if ( PrimaryDatabase != null ) {
            this.PrimaryDatabase = PrimaryDatabase;
        }
        if ( SecondaryDatabase != null ) {
            this.SecondaryDatabase = SecondaryDatabase;
        }
        if ( SecondaryInstance != null ) {
            this.SecondaryInstance = SecondaryInstance;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Int64? LagTimeFromPrimary
        // GraphQL -> lagTimeFromPrimary: Long! (scalar)
        if (this.LagTimeFromPrimary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lagTimeFromPrimary\n" ;
            } else {
                s += ind + "lagTimeFromPrimary\n" ;
            }
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (this.LastAppliedPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAppliedPoint\n" ;
            } else {
                s += ind + "lastAppliedPoint\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.Int64? LogFrequency
        // GraphQL -> logFrequency: Long! (scalar)
        if (this.LogFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logFrequency\n" ;
            } else {
                s += ind + "logFrequency\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? PrimaryCluster
        // GraphQL -> primaryCluster: Cluster (type)
        if (this.PrimaryCluster != null) {
            var fspec = this.PrimaryCluster.AsFieldSpec(conf.Child("primaryCluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlDatabase? PrimaryDatabase
        // GraphQL -> primaryDatabase: MssqlDatabase (type)
        if (this.PrimaryDatabase != null) {
            var fspec = this.PrimaryDatabase.AsFieldSpec(conf.Child("primaryDatabase"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryDatabase" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlDatabase? SecondaryDatabase
        // GraphQL -> secondaryDatabase: MssqlDatabase (type)
        if (this.SecondaryDatabase != null) {
            var fspec = this.SecondaryDatabase.AsFieldSpec(conf.Child("secondaryDatabase"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryDatabase" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlInstance? SecondaryInstance
        // GraphQL -> secondaryInstance: MssqlInstance (type)
        if (this.SecondaryInstance != null) {
            var fspec = this.SecondaryInstance.AsFieldSpec(conf.Child("secondaryInstance"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryInstance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Int64? LagTimeFromPrimary
        // GraphQL -> lagTimeFromPrimary: Long! (scalar)
        if (ec.Includes("lagTimeFromPrimary",true))
        {
            if(this.LagTimeFromPrimary == null) {

                this.LagTimeFromPrimary = new System.Int64();

            } else {


            }
        }
        else if (this.LagTimeFromPrimary != null && ec.Excludes("lagTimeFromPrimary",true))
        {
            this.LagTimeFromPrimary = null;
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (ec.Includes("lastAppliedPoint",true))
        {
            if(this.LastAppliedPoint == null) {

                this.LastAppliedPoint = new DateTime();

            } else {


            }
        }
        else if (this.LastAppliedPoint != null && ec.Excludes("lastAppliedPoint",true))
        {
            this.LastAppliedPoint = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.Int64? LogFrequency
        // GraphQL -> logFrequency: Long! (scalar)
        if (ec.Includes("logFrequency",true))
        {
            if(this.LogFrequency == null) {

                this.LogFrequency = new System.Int64();

            } else {


            }
        }
        else if (this.LogFrequency != null && ec.Excludes("logFrequency",true))
        {
            this.LogFrequency = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
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
        //      C# -> Cluster? PrimaryCluster
        // GraphQL -> primaryCluster: Cluster (type)
        if (ec.Includes("primaryCluster",false))
        {
            if(this.PrimaryCluster == null) {

                this.PrimaryCluster = new Cluster();
                this.PrimaryCluster.ApplyExploratoryFieldSpec(ec.NewChild("primaryCluster"));

            } else {

                this.PrimaryCluster.ApplyExploratoryFieldSpec(ec.NewChild("primaryCluster"));

            }
        }
        else if (this.PrimaryCluster != null && ec.Excludes("primaryCluster",false))
        {
            this.PrimaryCluster = null;
        }
        //      C# -> MssqlDatabase? PrimaryDatabase
        // GraphQL -> primaryDatabase: MssqlDatabase (type)
        if (ec.Includes("primaryDatabase",false))
        {
            if(this.PrimaryDatabase == null) {

                this.PrimaryDatabase = new MssqlDatabase();
                this.PrimaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("primaryDatabase"));

            } else {

                this.PrimaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("primaryDatabase"));

            }
        }
        else if (this.PrimaryDatabase != null && ec.Excludes("primaryDatabase",false))
        {
            this.PrimaryDatabase = null;
        }
        //      C# -> MssqlDatabase? SecondaryDatabase
        // GraphQL -> secondaryDatabase: MssqlDatabase (type)
        if (ec.Includes("secondaryDatabase",false))
        {
            if(this.SecondaryDatabase == null) {

                this.SecondaryDatabase = new MssqlDatabase();
                this.SecondaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("secondaryDatabase"));

            } else {

                this.SecondaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("secondaryDatabase"));

            }
        }
        else if (this.SecondaryDatabase != null && ec.Excludes("secondaryDatabase",false))
        {
            this.SecondaryDatabase = null;
        }
        //      C# -> MssqlInstance? SecondaryInstance
        // GraphQL -> secondaryInstance: MssqlInstance (type)
        if (ec.Includes("secondaryInstance",false))
        {
            if(this.SecondaryInstance == null) {

                this.SecondaryInstance = new MssqlInstance();
                this.SecondaryInstance.ApplyExploratoryFieldSpec(ec.NewChild("secondaryInstance"));

            } else {

                this.SecondaryInstance.ApplyExploratoryFieldSpec(ec.NewChild("secondaryInstance"));

            }
        }
        else if (this.SecondaryInstance != null && ec.Excludes("secondaryInstance",false))
        {
            this.SecondaryInstance = null;
        }
    }


    #endregion

    } // class MssqlLogShippingTarget
    
    #endregion

    public static class ListMssqlLogShippingTargetExtensions
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
            this List<MssqlLogShippingTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlLogShippingTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingTarget> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlLogShippingTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types