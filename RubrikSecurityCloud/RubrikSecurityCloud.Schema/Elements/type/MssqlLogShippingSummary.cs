// MssqlLogShippingSummary.cs
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
    #region MssqlLogShippingSummary
    public class MssqlLogShippingSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        [JsonProperty("lagTime")]
        public System.Int64? LagTime { get; set; }

        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        [JsonProperty("lastAppliedPoint")]
        public DateTime? LastAppliedPoint { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        [JsonProperty("primaryDatabaseId")]
        public System.String? PrimaryDatabaseId { get; set; }

        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        [JsonProperty("primaryDatabaseLogBackupFrequency")]
        public System.Int64? PrimaryDatabaseLogBackupFrequency { get; set; }

        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        [JsonProperty("primaryDatabaseName")]
        public System.String? PrimaryDatabaseName { get; set; }

        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        [JsonProperty("secondaryDatabaseId")]
        public System.String? SecondaryDatabaseId { get; set; }

        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        [JsonProperty("secondaryDatabaseName")]
        public System.String? SecondaryDatabaseName { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        [JsonProperty("status")]
        public MssqlLogShippingStatusInfo? Status { get; set; }


        #endregion

    #region methods

    public MssqlLogShippingSummary Set(
        System.String? Id = null,
        System.Int64? LagTime = null,
        DateTime? LastAppliedPoint = null,
        System.String? Location = null,
        System.String? PrimaryDatabaseId = null,
        System.Int64? PrimaryDatabaseLogBackupFrequency = null,
        System.String? PrimaryDatabaseName = null,
        System.String? SecondaryDatabaseId = null,
        System.String? SecondaryDatabaseName = null,
        System.String? State = null,
        MssqlLogShippingStatusInfo? Status = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LagTime != null ) {
            this.LagTime = LagTime;
        }
        if ( LastAppliedPoint != null ) {
            this.LastAppliedPoint = LastAppliedPoint;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( PrimaryDatabaseId != null ) {
            this.PrimaryDatabaseId = PrimaryDatabaseId;
        }
        if ( PrimaryDatabaseLogBackupFrequency != null ) {
            this.PrimaryDatabaseLogBackupFrequency = PrimaryDatabaseLogBackupFrequency;
        }
        if ( PrimaryDatabaseName != null ) {
            this.PrimaryDatabaseName = PrimaryDatabaseName;
        }
        if ( SecondaryDatabaseId != null ) {
            this.SecondaryDatabaseId = SecondaryDatabaseId;
        }
        if ( SecondaryDatabaseName != null ) {
            this.SecondaryDatabaseName = SecondaryDatabaseName;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        if (this.LagTime != null) {
            s += ind + "lagTime\n" ;
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
        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        if (this.PrimaryDatabaseId != null) {
            s += ind + "primaryDatabaseId\n" ;
        }
        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        if (this.PrimaryDatabaseLogBackupFrequency != null) {
            s += ind + "primaryDatabaseLogBackupFrequency\n" ;
        }
        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        if (this.PrimaryDatabaseName != null) {
            s += ind + "primaryDatabaseName\n" ;
        }
        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        if (this.SecondaryDatabaseId != null) {
            s += ind + "secondaryDatabaseId\n" ;
        }
        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        if (this.SecondaryDatabaseName != null) {
            s += ind + "secondaryDatabaseName\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        if (this.Status != null) {
            s += ind + "status {\n" + this.Status.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        if (this.LagTime == null && Exploration.Includes(parent + ".lagTime", true))
        {
            this.LagTime = new System.Int64();
        }
        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        if (this.LastAppliedPoint == null && Exploration.Includes(parent + ".lastAppliedPoint", true))
        {
            this.LastAppliedPoint = new DateTime();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = new System.String("FETCH");
        }
        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        if (this.PrimaryDatabaseId == null && Exploration.Includes(parent + ".primaryDatabaseId", true))
        {
            this.PrimaryDatabaseId = new System.String("FETCH");
        }
        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        if (this.PrimaryDatabaseLogBackupFrequency == null && Exploration.Includes(parent + ".primaryDatabaseLogBackupFrequency", true))
        {
            this.PrimaryDatabaseLogBackupFrequency = new System.Int64();
        }
        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        if (this.PrimaryDatabaseName == null && Exploration.Includes(parent + ".primaryDatabaseName", true))
        {
            this.PrimaryDatabaseName = new System.String("FETCH");
        }
        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        if (this.SecondaryDatabaseId == null && Exploration.Includes(parent + ".secondaryDatabaseId", true))
        {
            this.SecondaryDatabaseId = new System.String("FETCH");
        }
        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        if (this.SecondaryDatabaseName == null && Exploration.Includes(parent + ".secondaryDatabaseName", true))
        {
            this.SecondaryDatabaseName = new System.String("FETCH");
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new System.String("FETCH");
        }
        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        if (this.Status == null && Exploration.Includes(parent + ".status"))
        {
            this.Status = new MssqlLogShippingStatusInfo();
            this.Status.ApplyExploratoryFieldSpec(parent + ".status");
        }
    }


    #endregion

    } // class MssqlLogShippingSummary
    
    #endregion

    public static class ListMssqlLogShippingSummaryExtensions
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
            this List<MssqlLogShippingSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types