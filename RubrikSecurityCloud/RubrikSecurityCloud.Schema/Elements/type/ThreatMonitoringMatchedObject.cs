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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<IndicatorOfCompromiseKind>? MatchType
        // GraphQL -> matchType: [IndicatorOfCompromiseKind!]! (enum)
        if (this.MatchType != null) {
            s += ind + "matchType\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.Int64? FilesMatched
        // GraphQL -> filesMatched: Long! (scalar)
        if (this.FilesMatched != null) {
            s += ind + "filesMatched\n" ;
        }
        //      C# -> DateTime? LastDetection
        // GraphQL -> lastDetection: DateTime (scalar)
        if (this.LastDetection != null) {
            s += ind + "lastDetection\n" ;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            s += ind + "objectFid\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<IndicatorOfCompromiseKind>? MatchType
        // GraphQL -> matchType: [IndicatorOfCompromiseKind!]! (enum)
        if (this.MatchType == null && ec.Includes("matchType",true))
        {
            this.MatchType = new List<IndicatorOfCompromiseKind>();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> System.Int64? FilesMatched
        // GraphQL -> filesMatched: Long! (scalar)
        if (this.FilesMatched == null && ec.Includes("filesMatched",true))
        {
            this.FilesMatched = new System.Int64();
        }
        //      C# -> DateTime? LastDetection
        // GraphQL -> lastDetection: DateTime (scalar)
        if (this.LastDetection == null && ec.Includes("lastDetection",true))
        {
            this.LastDetection = new DateTime();
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid == null && ec.Includes("objectFid",true))
        {
            this.ObjectFid = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName == null && ec.Includes("objectName",true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
    }


    #endregion

    } // class ThreatMonitoringMatchedObject
    
    #endregion

    public static class ListThreatMonitoringMatchedObjectExtensions
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
            this List<ThreatMonitoringMatchedObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringMatchedObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringMatchedObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ThreatMonitoringMatchedObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types