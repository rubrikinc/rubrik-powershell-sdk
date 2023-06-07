// IssueEvent.cs
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
    #region IssueEvent
    public class IssueEvent: BaseType
    {
        #region members

        //      C# -> IssueEventType? Type
        // GraphQL -> type: IssueEventType! (enum)
        [JsonProperty("type")]
        public IssueEventType? Type { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? Timestamp
        // GraphQL -> timestamp: Long! (scalar)
        [JsonProperty("timestamp")]
        public System.Int64? Timestamp { get; set; }

        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        [JsonProperty("violations")]
        public System.Int32? Violations { get; set; }

        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        [JsonProperty("violationsDelta")]
        public System.Int32? ViolationsDelta { get; set; }


        #endregion

    #region methods

    public IssueEvent Set(
        IssueEventType? Type = null,
        System.String? SnapshotFid = null,
        System.Int64? Timestamp = null,
        System.Int32? Violations = null,
        System.Int32? ViolationsDelta = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        if ( Violations != null ) {
            this.Violations = Violations;
        }
        if ( ViolationsDelta != null ) {
            this.ViolationsDelta = ViolationsDelta;
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
        //      C# -> IssueEventType? Type
        // GraphQL -> type: IssueEventType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.Int64? Timestamp
        // GraphQL -> timestamp: Long! (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            s += ind + "violations\n" ;
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (this.ViolationsDelta != null) {
            s += ind + "violationsDelta\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> IssueEventType? Type
        // GraphQL -> type: IssueEventType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new IssueEventType();
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid", true))
        {
            this.SnapshotFid = "FETCH";
        }
        //      C# -> System.Int64? Timestamp
        // GraphQL -> timestamp: Long! (scalar)
        if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp", true))
        {
            this.Timestamp = new System.Int64();
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations == null && Exploration.Includes(parent + ".violations", true))
        {
            this.Violations = Int32.MinValue;
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (this.ViolationsDelta == null && Exploration.Includes(parent + ".violationsDelta", true))
        {
            this.ViolationsDelta = Int32.MinValue;
        }
    }


    #endregion

    } // class IssueEvent
    
    #endregion

    public static class ListIssueEventExtensions
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
            this List<IssueEvent> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<IssueEvent> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new IssueEvent());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types