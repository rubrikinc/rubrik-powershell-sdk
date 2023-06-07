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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            s += ind + "sensitiveFiles {\n" + this.SensitiveFiles.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            s += ind + "totalSensitiveHits {\n" + this.TotalSensitiveHits.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new DataGovObjectType();
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel == null && Exploration.Includes(parent + ".riskLevel", true))
        {
            this.RiskLevel = new RiskLevelType();
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName == null && Exploration.Includes(parent + ".fullName", true))
        {
            this.FullName = "FETCH";
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName == null && Exploration.Includes(parent + ".objectName", true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId == null && Exploration.Includes(parent + ".principalId", true))
        {
            this.PrincipalId = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles == null && Exploration.Includes(parent + ".sensitiveFiles"))
        {
            this.SensitiveFiles = new SensitiveFiles();
            this.SensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sensitiveFiles");
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits == null && Exploration.Includes(parent + ".totalSensitiveHits"))
        {
            this.TotalSensitiveHits = new SummaryHits();
            this.TotalSensitiveHits.ApplyExploratoryFieldSpec(parent + ".totalSensitiveHits");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalObjectSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalObjectSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types