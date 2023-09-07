// SlaWarning.cs
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
    #region SlaWarning
    public class SlaWarning: BaseType
    {
        #region members

        //      C# -> AssignSlaWarningsEnum? Code
        // GraphQL -> code: AssignSLAWarningsEnum! (enum)
        [JsonProperty("code")]
        public AssignSlaWarningsEnum? Code { get; set; }

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        [JsonProperty("snapshotIds")]
        public List<System.String>? SnapshotIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaWarning";
    }

    public SlaWarning Set(
        AssignSlaWarningsEnum? Code = null,
        WarningSeverityEnum? Severity = null,
        List<System.String>? ObjectIds = null,
        List<System.String>? SnapshotIds = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ObjectIds != null ) {
            this.ObjectIds = ObjectIds;
        }
        if ( SnapshotIds != null ) {
            this.SnapshotIds = SnapshotIds;
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
        //      C# -> AssignSlaWarningsEnum? Code
        // GraphQL -> code: AssignSLAWarningsEnum! (enum)
        if (this.Code != null) {
            s += ind + "code\n" ;
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds != null) {
            s += ind + "objectIds\n" ;
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds != null) {
            s += ind + "snapshotIds\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AssignSlaWarningsEnum? Code
        // GraphQL -> code: AssignSLAWarningsEnum! (enum)
        if (this.Code == null && ec.Includes("code",true))
        {
            this.Code = new AssignSlaWarningsEnum();
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new WarningSeverityEnum();
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds == null && ec.Includes("objectIds",true))
        {
            this.ObjectIds = new List<System.String>();
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds == null && ec.Includes("snapshotIds",true))
        {
            this.SnapshotIds = new List<System.String>();
        }
    }


    #endregion

    } // class SlaWarning
    
    #endregion

    public static class ListSlaWarningExtensions
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
            this List<SlaWarning> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaWarning> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaWarning());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SlaWarning> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types