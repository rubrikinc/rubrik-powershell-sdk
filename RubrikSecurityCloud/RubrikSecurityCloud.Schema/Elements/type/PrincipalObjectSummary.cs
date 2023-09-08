// PrincipalObjectSummary.cs
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
    #region PrincipalObjectSummary
    public class PrincipalObjectSummary: BaseType
    {
        #region members

        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        [JsonProperty("objectType")]
        public DataGovObjectType? ObjectType { get; set; }

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        [JsonProperty("fullName")]
        public System.String? FullName { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }

        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        [JsonProperty("totalSensitiveHits")]
        public SummaryHits? TotalSensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalObjectSummary";
    }

    public PrincipalObjectSummary Set(
        DataGovObjectType? ObjectType = null,
        RiskLevelType? RiskLevel = null,
        System.String? FullName = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        System.String? PrincipalId = null,
        Cluster? Cluster = null,
        SensitiveFiles? SensitiveFiles = null,
        SummaryHits? TotalSensitiveHits = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( FullName != null ) {
            this.FullName = FullName;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
        }
        if ( TotalSensitiveHits != null ) {
            this.TotalSensitiveHits = TotalSensitiveHits;
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
        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            s += ind + "riskLevel\n" ;
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            s += ind + "fullName\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            s += ind + "principalId\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sensitiveFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            var fspec = this.TotalSensitiveHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalSensitiveHits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new DataGovObjectType();
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel == null && ec.Includes("riskLevel",true))
        {
            this.RiskLevel = new RiskLevelType();
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName == null && ec.Includes("fullName",true))
        {
            this.FullName = "FETCH";
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && ec.Includes("objectId",true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName == null && ec.Includes("objectName",true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId == null && ec.Includes("principalId",true))
        {
            this.PrincipalId = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles == null && ec.Includes("sensitiveFiles",false))
        {
            this.SensitiveFiles = new SensitiveFiles();
            this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits == null && ec.Includes("totalSensitiveHits",false))
        {
            this.TotalSensitiveHits = new SummaryHits();
            this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));
        }
    }


    #endregion

    } // class PrincipalObjectSummary
    
    #endregion

    public static class ListPrincipalObjectSummaryExtensions
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
            this List<PrincipalObjectSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalObjectSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalObjectSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PrincipalObjectSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types