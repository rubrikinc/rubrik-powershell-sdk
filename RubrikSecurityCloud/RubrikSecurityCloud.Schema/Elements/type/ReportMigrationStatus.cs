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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ReportTemplate? ReportTemplate
        // GraphQL -> reportTemplate: ReportTemplate! (enum)
        if (this.ReportTemplate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportTemplate\n" ;
            } else {
                s += ind + "reportTemplate\n" ;
            }
        }
        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Details
        // GraphQL -> details: String! (scalar)
        if (this.Details != null) {
            if (conf.Flat) {
                s += conf.Prefix + "details\n" ;
            } else {
                s += ind + "details\n" ;
            }
        }
        //      C# -> System.String? ReportId
        // GraphQL -> reportId: String! (scalar)
        if (this.ReportId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportId\n" ;
            } else {
                s += ind + "reportId\n" ;
            }
        }
        //      C# -> System.String? ReportName
        // GraphQL -> reportName: String! (scalar)
        if (this.ReportName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportName\n" ;
            } else {
                s += ind + "reportName\n" ;
            }
        }
        //      C# -> System.Int64? RscReportId
        // GraphQL -> rscReportId: Long! (scalar)
        if (this.RscReportId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscReportId\n" ;
            } else {
                s += ind + "rscReportId\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReportTemplate? ReportTemplate
        // GraphQL -> reportTemplate: ReportTemplate! (enum)
        if (ec.Includes("reportTemplate",true))
        {
            if(this.ReportTemplate == null) {

                this.ReportTemplate = new ReportTemplate();

            } else {


            }
        }
        else if (this.ReportTemplate != null && ec.Excludes("reportTemplate",true))
        {
            this.ReportTemplate = null;
        }
        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new CdmReportMigrationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Details
        // GraphQL -> details: String! (scalar)
        if (ec.Includes("details",true))
        {
            if(this.Details == null) {

                this.Details = "FETCH";

            } else {


            }
        }
        else if (this.Details != null && ec.Excludes("details",true))
        {
            this.Details = null;
        }
        //      C# -> System.String? ReportId
        // GraphQL -> reportId: String! (scalar)
        if (ec.Includes("reportId",true))
        {
            if(this.ReportId == null) {

                this.ReportId = "FETCH";

            } else {


            }
        }
        else if (this.ReportId != null && ec.Excludes("reportId",true))
        {
            this.ReportId = null;
        }
        //      C# -> System.String? ReportName
        // GraphQL -> reportName: String! (scalar)
        if (ec.Includes("reportName",true))
        {
            if(this.ReportName == null) {

                this.ReportName = "FETCH";

            } else {


            }
        }
        else if (this.ReportName != null && ec.Excludes("reportName",true))
        {
            this.ReportName = null;
        }
        //      C# -> System.Int64? RscReportId
        // GraphQL -> rscReportId: Long! (scalar)
        if (ec.Includes("rscReportId",true))
        {
            if(this.RscReportId == null) {

                this.RscReportId = new System.Int64();

            } else {


            }
        }
        else if (this.RscReportId != null && ec.Excludes("rscReportId",true))
        {
            this.RscReportId = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
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

    } // class ReportMigrationStatus
    
    #endregion

    public static class ListReportMigrationStatusExtensions
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
            this List<ReportMigrationStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReportMigrationStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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