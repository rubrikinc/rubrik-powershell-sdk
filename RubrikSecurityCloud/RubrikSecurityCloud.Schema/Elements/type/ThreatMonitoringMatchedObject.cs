// ThreatMonitoringMatchedObject.cs
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
    #region ThreatMonitoringMatchedObject
    public class ThreatMonitoringMatchedObject: BaseType
    {
        #region members

        //      C# -> List<IndicatorOfCompromiseKind>? MatchType
        // GraphQL -> matchType: [IndicatorOfCompromiseKind!]! (enum)
        [JsonProperty("matchType")]
        public List<IndicatorOfCompromiseKind>? MatchType { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> MatchSeverity? Severity
        // GraphQL -> severity: MatchSeverity! (enum)
        [JsonProperty("severity")]
        public MatchSeverity? Severity { get; set; }

        //      C# -> System.Int64? FilesMatched
        // GraphQL -> filesMatched: Long! (scalar)
        [JsonProperty("filesMatched")]
        public System.Int64? FilesMatched { get; set; }

        //      C# -> DateTime? LastDetection
        // GraphQL -> lastDetection: DateTime (scalar)
        [JsonProperty("lastDetection")]
        public DateTime? LastDetection { get; set; }

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringMatchedObject";
    }

    public ThreatMonitoringMatchedObject Set(
        List<IndicatorOfCompromiseKind>? MatchType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        MatchSeverity? Severity = null,
        System.Int64? FilesMatched = null,
        DateTime? LastDetection = null,
        System.String? ObjectFid = null,
        System.String? ObjectName = null,
        Cluster? Cluster = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( FilesMatched != null ) {
            this.FilesMatched = FilesMatched;
        }
        if ( LastDetection != null ) {
            this.LastDetection = LastDetection;
        }
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> List<IndicatorOfCompromiseKind>? MatchType
        // GraphQL -> matchType: [IndicatorOfCompromiseKind!]! (enum)
        if (this.MatchType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchType\n" ;
            } else {
                s += ind + "matchType\n" ;
            }
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> MatchSeverity? Severity
        // GraphQL -> severity: MatchSeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Int64? FilesMatched
        // GraphQL -> filesMatched: Long! (scalar)
        if (this.FilesMatched != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesMatched\n" ;
            } else {
                s += ind + "filesMatched\n" ;
            }
        }
        //      C# -> DateTime? LastDetection
        // GraphQL -> lastDetection: DateTime (scalar)
        if (this.LastDetection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastDetection\n" ;
            } else {
                s += ind + "lastDetection\n" ;
            }
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
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
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<IndicatorOfCompromiseKind>? MatchType
        // GraphQL -> matchType: [IndicatorOfCompromiseKind!]! (enum)
        if (ec.Includes("matchType",true))
        {
            if(this.MatchType == null) {

                this.MatchType = new List<IndicatorOfCompromiseKind>();

            } else {


            }
        }
        else if (this.MatchType != null && ec.Excludes("matchType",true))
        {
            this.MatchType = null;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> MatchSeverity? Severity
        // GraphQL -> severity: MatchSeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new MatchSeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Int64? FilesMatched
        // GraphQL -> filesMatched: Long! (scalar)
        if (ec.Includes("filesMatched",true))
        {
            if(this.FilesMatched == null) {

                this.FilesMatched = new System.Int64();

            } else {


            }
        }
        else if (this.FilesMatched != null && ec.Excludes("filesMatched",true))
        {
            this.FilesMatched = null;
        }
        //      C# -> DateTime? LastDetection
        // GraphQL -> lastDetection: DateTime (scalar)
        if (ec.Includes("lastDetection",true))
        {
            if(this.LastDetection == null) {

                this.LastDetection = new DateTime();

            } else {


            }
        }
        else if (this.LastDetection != null && ec.Excludes("lastDetection",true))
        {
            this.LastDetection = null;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
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
    }


    #endregion

    } // class ThreatMonitoringMatchedObject
    
    #endregion

    public static class ListThreatMonitoringMatchedObjectExtensions
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
            this List<ThreatMonitoringMatchedObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringMatchedObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringMatchedObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringMatchedObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringMatchedObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types