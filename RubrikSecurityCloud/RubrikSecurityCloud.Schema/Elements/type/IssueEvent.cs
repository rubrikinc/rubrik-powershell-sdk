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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "IssueEvent";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> IssueEventType? Type
        // GraphQL -> type: IssueEventType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
            }
        }
        //      C# -> System.Int64? Timestamp
        // GraphQL -> timestamp: Long! (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violations\n" ;
            } else {
                s += ind + "violations\n" ;
            }
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (this.ViolationsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationsDelta\n" ;
            } else {
                s += ind + "violationsDelta\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IssueEventType? Type
        // GraphQL -> type: IssueEventType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new IssueEventType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
        }
        //      C# -> System.Int64? Timestamp
        // GraphQL -> timestamp: Long! (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new System.Int64();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (ec.Includes("violations",true))
        {
            if(this.Violations == null) {

                this.Violations = Int32.MinValue;

            } else {


            }
        }
        else if (this.Violations != null && ec.Excludes("violations",true))
        {
            this.Violations = null;
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (ec.Includes("violationsDelta",true))
        {
            if(this.ViolationsDelta == null) {

                this.ViolationsDelta = Int32.MinValue;

            } else {


            }
        }
        else if (this.ViolationsDelta != null && ec.Excludes("violationsDelta",true))
        {
            this.ViolationsDelta = null;
        }
    }


    #endregion

    } // class IssueEvent
    
    #endregion

    public static class ListIssueEventExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<IssueEvent> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IssueEvent> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IssueEvent> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IssueEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IssueEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types