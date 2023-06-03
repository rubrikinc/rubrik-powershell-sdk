// Failover.cs
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
    #region Failover
    public class Failover: BaseType
    {
        #region members

        //      C# -> FailoverStatusEnum? FailoverStatus
        // GraphQL -> failoverStatus: FailoverStatusEnum! (enum)
        [JsonProperty("failoverStatus")]
        public FailoverStatusEnum? FailoverStatus { get; set; }

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> LastTestStatusEnum? LastTestStatus
        // GraphQL -> lastTestStatus: LastTestStatusEnum (enum)
        [JsonProperty("lastTestStatus")]
        public LastTestStatusEnum? LastTestStatus { get; set; }

        //      C# -> System.String? AppBlueprintId
        // GraphQL -> appBlueprintId: UUID! (scalar)
        [JsonProperty("appBlueprintId")]
        public System.String? AppBlueprintId { get; set; }

        //      C# -> System.String? AppBlueprintName
        // GraphQL -> appBlueprintName: String! (scalar)
        [JsonProperty("appBlueprintName")]
        public System.String? AppBlueprintName { get; set; }

        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long (scalar)
        [JsonProperty("duration")]
        public System.Int64? Duration { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastTestTime
        // GraphQL -> lastTestTime: DateTime (scalar)
        [JsonProperty("lastTestTime")]
        public DateTime? LastTestTime { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? TargetSite
        // GraphQL -> targetSite: String! (scalar)
        [JsonProperty("targetSite")]
        public System.String? TargetSite { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }

        //      C# -> FailoverReport? Report
        // GraphQL -> report: FailoverReport (type)
        [JsonProperty("report")]
        public FailoverReport? Report { get; set; }


        #endregion

    #region methods

    public Failover Set(
        FailoverStatusEnum? FailoverStatus = null,
        FailoverTypeEnum? FailoverType = null,
        LastTestStatusEnum? LastTestStatus = null,
        System.String? AppBlueprintId = null,
        System.String? AppBlueprintName = null,
        System.Int64? Duration = null,
        DateTime? EndTime = null,
        System.String? Id = null,
        DateTime? LastTestTime = null,
        System.String? Source = null,
        DateTime? StartTime = null,
        System.String? TargetSite = null,
        System.String? TaskchainId = null,
        FailoverReport? Report = null
    ) 
    {
        if ( FailoverStatus != null ) {
            this.FailoverStatus = FailoverStatus;
        }
        if ( FailoverType != null ) {
            this.FailoverType = FailoverType;
        }
        if ( LastTestStatus != null ) {
            this.LastTestStatus = LastTestStatus;
        }
        if ( AppBlueprintId != null ) {
            this.AppBlueprintId = AppBlueprintId;
        }
        if ( AppBlueprintName != null ) {
            this.AppBlueprintName = AppBlueprintName;
        }
        if ( Duration != null ) {
            this.Duration = Duration;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastTestTime != null ) {
            this.LastTestTime = LastTestTime;
        }
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TargetSite != null ) {
            this.TargetSite = TargetSite;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
        }
        if ( Report != null ) {
            this.Report = Report;
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
        //      C# -> FailoverStatusEnum? FailoverStatus
        // GraphQL -> failoverStatus: FailoverStatusEnum! (enum)
        if (this.FailoverStatus != null) {
            s += ind + "failoverStatus\n" ;
        }
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (this.FailoverType != null) {
            s += ind + "failoverType\n" ;
        }
        //      C# -> LastTestStatusEnum? LastTestStatus
        // GraphQL -> lastTestStatus: LastTestStatusEnum (enum)
        if (this.LastTestStatus != null) {
            s += ind + "lastTestStatus\n" ;
        }
        //      C# -> System.String? AppBlueprintId
        // GraphQL -> appBlueprintId: UUID! (scalar)
        if (this.AppBlueprintId != null) {
            s += ind + "appBlueprintId\n" ;
        }
        //      C# -> System.String? AppBlueprintName
        // GraphQL -> appBlueprintName: String! (scalar)
        if (this.AppBlueprintName != null) {
            s += ind + "appBlueprintName\n" ;
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long (scalar)
        if (this.Duration != null) {
            s += ind + "duration\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastTestTime
        // GraphQL -> lastTestTime: DateTime (scalar)
        if (this.LastTestTime != null) {
            s += ind + "lastTestTime\n" ;
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (this.Source != null) {
            s += ind + "source\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? TargetSite
        // GraphQL -> targetSite: String! (scalar)
        if (this.TargetSite != null) {
            s += ind + "targetSite\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        //      C# -> FailoverReport? Report
        // GraphQL -> report: FailoverReport (type)
        if (this.Report != null) {
            s += ind + "report {\n" + this.Report.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FailoverStatusEnum? FailoverStatus
        // GraphQL -> failoverStatus: FailoverStatusEnum! (enum)
        if (this.FailoverStatus == null && Exploration.Includes(parent + ".failoverStatus", true))
        {
            this.FailoverStatus = new FailoverStatusEnum();
        }
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (this.FailoverType == null && Exploration.Includes(parent + ".failoverType", true))
        {
            this.FailoverType = new FailoverTypeEnum();
        }
        //      C# -> LastTestStatusEnum? LastTestStatus
        // GraphQL -> lastTestStatus: LastTestStatusEnum (enum)
        if (this.LastTestStatus == null && Exploration.Includes(parent + ".lastTestStatus", true))
        {
            this.LastTestStatus = new LastTestStatusEnum();
        }
        //      C# -> System.String? AppBlueprintId
        // GraphQL -> appBlueprintId: UUID! (scalar)
        if (this.AppBlueprintId == null && Exploration.Includes(parent + ".appBlueprintId", true))
        {
            this.AppBlueprintId = new System.String("FETCH");
        }
        //      C# -> System.String? AppBlueprintName
        // GraphQL -> appBlueprintName: String! (scalar)
        if (this.AppBlueprintName == null && Exploration.Includes(parent + ".appBlueprintName", true))
        {
            this.AppBlueprintName = new System.String("FETCH");
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long (scalar)
        if (this.Duration == null && Exploration.Includes(parent + ".duration", true))
        {
            this.Duration = new System.Int64();
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> DateTime? LastTestTime
        // GraphQL -> lastTestTime: DateTime (scalar)
        if (this.LastTestTime == null && Exploration.Includes(parent + ".lastTestTime", true))
        {
            this.LastTestTime = new DateTime();
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (this.Source == null && Exploration.Includes(parent + ".source", true))
        {
            this.Source = new System.String("FETCH");
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> System.String? TargetSite
        // GraphQL -> targetSite: String! (scalar)
        if (this.TargetSite == null && Exploration.Includes(parent + ".targetSite", true))
        {
            this.TargetSite = new System.String("FETCH");
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId", true))
        {
            this.TaskchainId = new System.String("FETCH");
        }
        //      C# -> FailoverReport? Report
        // GraphQL -> report: FailoverReport (type)
        if (this.Report == null && Exploration.Includes(parent + ".report"))
        {
            this.Report = new FailoverReport();
            this.Report.ApplyExploratoryFieldSpec(parent + ".report");
        }
    }


    #endregion

    } // class Failover
    
    #endregion

    public static class ListFailoverExtensions
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
            this List<Failover> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Failover> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Failover());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types