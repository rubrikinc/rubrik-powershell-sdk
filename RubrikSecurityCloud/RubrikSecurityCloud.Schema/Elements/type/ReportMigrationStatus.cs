// ReportMigrationStatus.cs
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
    #region ReportMigrationStatus
    public class ReportMigrationStatus: BaseType
    {
        #region members

        //      C# -> ReportTemplate? ReportTemplate
        // GraphQL -> reportTemplate: ReportTemplate! (enum)
        [JsonProperty("reportTemplate")]
        public ReportTemplate? ReportTemplate { get; set; }

        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        [JsonProperty("status")]
        public CdmReportMigrationStatus? Status { get; set; }

        //      C# -> System.String? Details
        // GraphQL -> details: String! (scalar)
        [JsonProperty("details")]
        public System.String? Details { get; set; }

        //      C# -> System.String? ReportId
        // GraphQL -> reportId: String! (scalar)
        [JsonProperty("reportId")]
        public System.String? ReportId { get; set; }

        //      C# -> System.String? ReportName
        // GraphQL -> reportName: String! (scalar)
        [JsonProperty("reportName")]
        public System.String? ReportName { get; set; }

        //      C# -> System.Int64? RscReportId
        // GraphQL -> rscReportId: Long! (scalar)
        [JsonProperty("rscReportId")]
        public System.Int64? RscReportId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReportMigrationStatus";
    }

    public ReportMigrationStatus Set(
        ReportTemplate? ReportTemplate = null,
        CdmReportMigrationStatus? Status = null,
        System.String? Details = null,
        System.String? ReportId = null,
        System.String? ReportName = null,
        System.Int64? RscReportId = null,
        Cluster? Cluster = null
    ) 
    {
        if ( ReportTemplate != null ) {
            this.ReportTemplate = ReportTemplate;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Details != null ) {
            this.Details = Details;
        }
        if ( ReportId != null ) {
            this.ReportId = ReportId;
        }
        if ( ReportName != null ) {
            this.ReportName = ReportName;
        }
        if ( RscReportId != null ) {
            this.RscReportId = RscReportId;
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
        //      C# -> ReportTemplate? ReportTemplate
        // GraphQL -> reportTemplate: ReportTemplate! (enum)
        if (this.ReportTemplate != null) {
            s += ind + "reportTemplate\n" ;
        }
        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Details
        // GraphQL -> details: String! (scalar)
        if (this.Details != null) {
            s += ind + "details\n" ;
        }
        //      C# -> System.String? ReportId
        // GraphQL -> reportId: String! (scalar)
        if (this.ReportId != null) {
            s += ind + "reportId\n" ;
        }
        //      C# -> System.String? ReportName
        // GraphQL -> reportName: String! (scalar)
        if (this.ReportName != null) {
            s += ind + "reportName\n" ;
        }
        //      C# -> System.Int64? RscReportId
        // GraphQL -> rscReportId: Long! (scalar)
        if (this.RscReportId != null) {
            s += ind + "rscReportId\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
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
        //      C# -> ReportTemplate? ReportTemplate
        // GraphQL -> reportTemplate: ReportTemplate! (enum)
        if (this.ReportTemplate == null && ec.Includes("reportTemplate",true))
        {
            this.ReportTemplate = new ReportTemplate();
        }
        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new CdmReportMigrationStatus();
        }
        //      C# -> System.String? Details
        // GraphQL -> details: String! (scalar)
        if (this.Details == null && ec.Includes("details",true))
        {
            this.Details = "FETCH";
        }
        //      C# -> System.String? ReportId
        // GraphQL -> reportId: String! (scalar)
        if (this.ReportId == null && ec.Includes("reportId",true))
        {
            this.ReportId = "FETCH";
        }
        //      C# -> System.String? ReportName
        // GraphQL -> reportName: String! (scalar)
        if (this.ReportName == null && ec.Includes("reportName",true))
        {
            this.ReportName = "FETCH";
        }
        //      C# -> System.Int64? RscReportId
        // GraphQL -> rscReportId: Long! (scalar)
        if (this.RscReportId == null && ec.Includes("rscReportId",true))
        {
            this.RscReportId = new System.Int64();
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
    }


    #endregion

    } // class ReportMigrationStatus
    
    #endregion

    public static class ListReportMigrationStatusExtensions
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
            this List<ReportMigrationStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportMigrationStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportMigrationStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReportMigrationStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types