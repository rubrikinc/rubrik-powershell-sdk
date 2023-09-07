// NfAnomalyResult.cs
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
    #region NfAnomalyResult
    public class NfAnomalyResult: BaseType
    {
        #region members

        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ObjectTypeEnum? ObjectType { get; set; }

        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        [JsonProperty("anomalyId")]
        public System.String? AnomalyId { get; set; }

        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        [JsonProperty("detectionTime")]
        public DateTime? DetectionTime { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NfAnomalyResult";
    }

    public NfAnomalyResult Set(
        ObjectTypeEnum? ObjectType = null,
        System.String? AnomalyId = null,
        DateTime? DetectionTime = null,
        System.Boolean? IsAnomaly = null,
        System.String? Location = null,
        System.String? WorkloadFid = null,
        System.String? WorkloadName = null,
        Cluster? Cluster = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( AnomalyId != null ) {
            this.AnomalyId = AnomalyId;
        }
        if ( DetectionTime != null ) {
            this.DetectionTime = DetectionTime;
        }
        if ( IsAnomaly != null ) {
            this.IsAnomaly = IsAnomaly;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( WorkloadFid != null ) {
            this.WorkloadFid = WorkloadFid;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
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
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        if (this.AnomalyId != null) {
            s += ind + "anomalyId\n" ;
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        if (this.DetectionTime != null) {
            s += ind + "detectionTime\n" ;
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            s += ind + "isAnomaly\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (this.WorkloadFid != null) {
            s += ind + "workloadFid\n" ;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            s += ind + "workloadName\n" ;
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
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new ObjectTypeEnum();
        }
        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        if (this.AnomalyId == null && ec.Includes("anomalyId",true))
        {
            this.AnomalyId = "FETCH";
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        if (this.DetectionTime == null && ec.Includes("detectionTime",true))
        {
            this.DetectionTime = new DateTime();
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly == null && ec.Includes("isAnomaly",true))
        {
            this.IsAnomaly = true;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && ec.Includes("location",true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (this.WorkloadFid == null && ec.Includes("workloadFid",true))
        {
            this.WorkloadFid = "FETCH";
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName == null && ec.Includes("workloadName",true))
        {
            this.WorkloadName = "FETCH";
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

    } // class NfAnomalyResult
    
    #endregion

    public static class ListNfAnomalyResultExtensions
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
            this List<NfAnomalyResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NfAnomalyResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NfAnomalyResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NfAnomalyResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types