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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.Int64? LagTimeFromPrimary
        // GraphQL -> lagTimeFromPrimary: Long! (scalar)
        if (this.LagTimeFromPrimary != null) {
            s += ind + "lagTimeFromPrimary\n" ;
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (this.LastAppliedPoint != null) {
            s += ind + "lastAppliedPoint\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.Int64? LogFrequency
        // GraphQL -> logFrequency: Long! (scalar)
        if (this.LogFrequency != null) {
            s += ind + "logFrequency\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Cluster? PrimaryCluster
        // GraphQL -> primaryCluster: Cluster (type)
        if (this.PrimaryCluster != null) {
            var fspec = this.PrimaryCluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "primaryCluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlDatabase? PrimaryDatabase
        // GraphQL -> primaryDatabase: MssqlDatabase (type)
        if (this.PrimaryDatabase != null) {
            var fspec = this.PrimaryDatabase.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "primaryDatabase {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlDatabase? SecondaryDatabase
        // GraphQL -> secondaryDatabase: MssqlDatabase (type)
        if (this.SecondaryDatabase != null) {
            var fspec = this.SecondaryDatabase.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "secondaryDatabase {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlInstance? SecondaryInstance
        // GraphQL -> secondaryInstance: MssqlInstance (type)
        if (this.SecondaryInstance != null) {
            var fspec = this.SecondaryInstance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "secondaryInstance {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && ec.Includes("cdmId",true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.Int64? LagTimeFromPrimary
        // GraphQL -> lagTimeFromPrimary: Long! (scalar)
        if (this.LagTimeFromPrimary == null && ec.Includes("lagTimeFromPrimary",true))
        {
            this.LagTimeFromPrimary = new System.Int64();
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (this.LastAppliedPoint == null && ec.Includes("lastAppliedPoint",true))
        {
            this.LastAppliedPoint = new DateTime();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && ec.Includes("location",true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.Int64? LogFrequency
        // GraphQL -> logFrequency: Long! (scalar)
        if (this.LogFrequency == null && ec.Includes("logFrequency",true))
        {
            this.LogFrequency = new System.Int64();
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State == null && ec.Includes("state",true))
        {
            this.State = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> Cluster? PrimaryCluster
        // GraphQL -> primaryCluster: Cluster (type)
        if (this.PrimaryCluster == null && ec.Includes("primaryCluster",false))
        {
            this.PrimaryCluster = new Cluster();
            this.PrimaryCluster.ApplyExploratoryFieldSpec(ec.NewChild("primaryCluster"));
        }
        //      C# -> MssqlDatabase? PrimaryDatabase
        // GraphQL -> primaryDatabase: MssqlDatabase (type)
        if (this.PrimaryDatabase == null && ec.Includes("primaryDatabase",false))
        {
            this.PrimaryDatabase = new MssqlDatabase();
            this.PrimaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("primaryDatabase"));
        }
        //      C# -> MssqlDatabase? SecondaryDatabase
        // GraphQL -> secondaryDatabase: MssqlDatabase (type)
        if (this.SecondaryDatabase == null && ec.Includes("secondaryDatabase",false))
        {
            this.SecondaryDatabase = new MssqlDatabase();
            this.SecondaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("secondaryDatabase"));
        }
        //      C# -> MssqlInstance? SecondaryInstance
        // GraphQL -> secondaryInstance: MssqlInstance (type)
        if (this.SecondaryInstance == null && ec.Includes("secondaryInstance",false))
        {
            this.SecondaryInstance = new MssqlInstance();
            this.SecondaryInstance.ApplyExploratoryFieldSpec(ec.NewChild("secondaryInstance"));
        }
    }


    #endregion

    } // class MssqlLogShippingTarget
    
    #endregion

    public static class ListMssqlLogShippingTargetExtensions
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
            this List<MssqlLogShippingTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<MssqlLogShippingTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types