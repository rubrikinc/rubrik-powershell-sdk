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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AssignSlaWarningsEnum? Code
        // GraphQL -> code: AssignSLAWarningsEnum! (enum)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (this.ObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectIds\n" ;
            } else {
                s += ind + "objectIds\n" ;
            }
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotIds\n" ;
            } else {
                s += ind + "snapshotIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AssignSlaWarningsEnum? Code
        // GraphQL -> code: AssignSLAWarningsEnum! (enum)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = new AssignSlaWarningsEnum();

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new WarningSeverityEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!]! (scalar)
        if (ec.Includes("objectIds",true))
        {
            if(this.ObjectIds == null) {

                this.ObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ObjectIds != null && ec.Excludes("objectIds",true))
        {
            this.ObjectIds = null;
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (ec.Includes("snapshotIds",true))
        {
            if(this.SnapshotIds == null) {

                this.SnapshotIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SnapshotIds != null && ec.Excludes("snapshotIds",true))
        {
            this.SnapshotIds = null;
        }
    }


    #endregion

    } // class SlaWarning
    
    #endregion

    public static class ListSlaWarningExtensions
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
            this List<SlaWarning> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaWarning> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SlaWarning> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types