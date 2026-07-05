// RecoveryReport.cs
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
    #region RecoveryReport
    public class RecoveryReport: BaseType
    {
        #region members

        //      C# -> RecoveryReportStatus? Status
        // GraphQL -> status: RecoveryReportStatus! (enum)
        [JsonProperty("status")]
        public RecoveryReportStatus? Status { get; set; }

        //      C# -> DateTime? ExpiredAt
        // GraphQL -> expiredAt: DateTime (scalar)
        [JsonProperty("expiredAt")]
        public DateTime? ExpiredAt { get; set; }

        //      C# -> System.String? ReportId
        // GraphQL -> reportId: UUID! (scalar)
        [JsonProperty("reportId")]
        public System.String? ReportId { get; set; }

        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String! (scalar)
        [JsonProperty("reportUrl")]
        public System.String? ReportUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryReport";
    }

    public RecoveryReport Set(
        RecoveryReportStatus? Status = null,
        DateTime? ExpiredAt = null,
        System.String? ReportId = null,
        System.String? ReportUrl = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ExpiredAt != null ) {
            this.ExpiredAt = ExpiredAt;
        }
        if ( ReportId != null ) {
            this.ReportId = ReportId;
        }
        if ( ReportUrl != null ) {
            this.ReportUrl = ReportUrl;
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
        //      C# -> RecoveryReportStatus? Status
        // GraphQL -> status: RecoveryReportStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? ExpiredAt
        // GraphQL -> expiredAt: DateTime (scalar)
        if (this.ExpiredAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiredAt\n" ;
            } else {
                s += ind + "expiredAt\n" ;
            }
        }
        //      C# -> System.String? ReportId
        // GraphQL -> reportId: UUID! (scalar)
        if (this.ReportId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportId\n" ;
            } else {
                s += ind + "reportId\n" ;
            }
        }
        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String! (scalar)
        if (this.ReportUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportUrl\n" ;
            } else {
                s += ind + "reportUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryReportStatus? Status
        // GraphQL -> status: RecoveryReportStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new RecoveryReportStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? ExpiredAt
        // GraphQL -> expiredAt: DateTime (scalar)
        if (ec.Includes("expiredAt",true))
        {
            if(this.ExpiredAt == null) {

                this.ExpiredAt = new DateTime();

            } else {


            }
        }
        else if (this.ExpiredAt != null && ec.Excludes("expiredAt",true))
        {
            this.ExpiredAt = null;
        }
        //      C# -> System.String? ReportId
        // GraphQL -> reportId: UUID! (scalar)
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
        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String! (scalar)
        if (ec.Includes("reportUrl",true))
        {
            if(this.ReportUrl == null) {

                this.ReportUrl = "FETCH";

            } else {


            }
        }
        else if (this.ReportUrl != null && ec.Excludes("reportUrl",true))
        {
            this.ReportUrl = null;
        }
    }


    #endregion

    } // class RecoveryReport
    
    #endregion

    public static class ListRecoveryReportExtensions
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
            this List<RecoveryReport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryReport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryReport> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryReport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryReport> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types