// TaskSummary.cs
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
    #region TaskSummary
    public class TaskSummary: BaseType
    {
        #region members

        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ObjectTypeEnum? ObjectType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int32? NumCanceled
        // GraphQL -> numCanceled: Int! (scalar)
        [JsonProperty("numCanceled")]
        public System.Int32? NumCanceled { get; set; }

        //      C# -> System.Int32? NumExpected
        // GraphQL -> numExpected: Int! (scalar)
        [JsonProperty("numExpected")]
        public System.Int32? NumExpected { get; set; }

        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        [JsonProperty("numFailed")]
        public System.Int32? NumFailed { get; set; }

        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        [JsonProperty("numSucceeded")]
        public System.Int32? NumSucceeded { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        [JsonProperty("slaDomainName")]
        public System.String? SlaDomainName { get; set; }

        //      C# -> System.String? SnappbleId
        // GraphQL -> snappbleId: UUID! (scalar)
        [JsonProperty("snappbleId")]
        public System.String? SnappbleId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskSummary";
    }

    public TaskSummary Set(
        ObjectTypeEnum? ObjectType = null,
        System.String? ClusterUuid = null,
        DateTime? Date = null,
        System.String? Location = null,
        System.Int32? NumCanceled = null,
        System.Int32? NumExpected = null,
        System.Int32? NumFailed = null,
        System.Int32? NumSucceeded = null,
        System.String? ObjectName = null,
        System.String? SlaDomainId = null,
        System.String? SlaDomainName = null,
        System.String? SnappbleId = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( NumCanceled != null ) {
            this.NumCanceled = NumCanceled;
        }
        if ( NumExpected != null ) {
            this.NumExpected = NumExpected;
        }
        if ( NumFailed != null ) {
            this.NumFailed = NumFailed;
        }
        if ( NumSucceeded != null ) {
            this.NumSucceeded = NumSucceeded;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( SlaDomainId != null ) {
            this.SlaDomainId = SlaDomainId;
        }
        if ( SlaDomainName != null ) {
            this.SlaDomainName = SlaDomainName;
        }
        if ( SnappbleId != null ) {
            this.SnappbleId = SnappbleId;
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
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.Int32? NumCanceled
        // GraphQL -> numCanceled: Int! (scalar)
        if (this.NumCanceled != null) {
            s += ind + "numCanceled\n" ;
        }
        //      C# -> System.Int32? NumExpected
        // GraphQL -> numExpected: Int! (scalar)
        if (this.NumExpected != null) {
            s += ind + "numExpected\n" ;
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (this.NumFailed != null) {
            s += ind + "numFailed\n" ;
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (this.NumSucceeded != null) {
            s += ind + "numSucceeded\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            s += ind + "slaDomainId\n" ;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            s += ind + "slaDomainName\n" ;
        }
        //      C# -> System.String? SnappbleId
        // GraphQL -> snappbleId: UUID! (scalar)
        if (this.SnappbleId != null) {
            s += ind + "snappbleId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new ObjectTypeEnum();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.Int32? NumCanceled
        // GraphQL -> numCanceled: Int! (scalar)
        if (this.NumCanceled == null && Exploration.Includes(parent + ".numCanceled", true))
        {
            this.NumCanceled = Int32.MinValue;
        }
        //      C# -> System.Int32? NumExpected
        // GraphQL -> numExpected: Int! (scalar)
        if (this.NumExpected == null && Exploration.Includes(parent + ".numExpected", true))
        {
            this.NumExpected = Int32.MinValue;
        }
        //      C# -> System.Int32? NumFailed
        // GraphQL -> numFailed: Int! (scalar)
        if (this.NumFailed == null && Exploration.Includes(parent + ".numFailed", true))
        {
            this.NumFailed = Int32.MinValue;
        }
        //      C# -> System.Int32? NumSucceeded
        // GraphQL -> numSucceeded: Int! (scalar)
        if (this.NumSucceeded == null && Exploration.Includes(parent + ".numSucceeded", true))
        {
            this.NumSucceeded = Int32.MinValue;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName == null && Exploration.Includes(parent + ".objectName", true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId == null && Exploration.Includes(parent + ".slaDomainId", true))
        {
            this.SlaDomainId = "FETCH";
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName == null && Exploration.Includes(parent + ".slaDomainName", true))
        {
            this.SlaDomainName = "FETCH";
        }
        //      C# -> System.String? SnappbleId
        // GraphQL -> snappbleId: UUID! (scalar)
        if (this.SnappbleId == null && Exploration.Includes(parent + ".snappbleId", true))
        {
            this.SnappbleId = "FETCH";
        }
    }


    #endregion

    } // class TaskSummary
    
    #endregion

    public static class ListTaskSummaryExtensions
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
            this List<TaskSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types