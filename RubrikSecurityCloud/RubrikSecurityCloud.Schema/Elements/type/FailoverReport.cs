// FailoverReport.cs
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
    #region FailoverReport
    public class FailoverReport: BaseType
    {
        #region members

        //      C# -> AppflowsBlueprintFailoverReportStatusEnum? Status
        // GraphQL -> status: AppflowsBlueprintFailoverReportStatusEnum! (enum)
        [JsonProperty("status")]
        public AppflowsBlueprintFailoverReportStatusEnum? Status { get; set; }

        //      C# -> DateTime? ExpireTime
        // GraphQL -> expireTime: DateTime! (scalar)
        [JsonProperty("expireTime")]
        public DateTime? ExpireTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String (scalar)
        [JsonProperty("reportUrl")]
        public System.String? ReportUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverReport";
    }

    public FailoverReport Set(
        AppflowsBlueprintFailoverReportStatusEnum? Status = null,
        DateTime? ExpireTime = null,
        System.String? Id = null,
        System.String? ReportUrl = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ExpireTime != null ) {
            this.ExpireTime = ExpireTime;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> AppflowsBlueprintFailoverReportStatusEnum? Status
        // GraphQL -> status: AppflowsBlueprintFailoverReportStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? ExpireTime
        // GraphQL -> expireTime: DateTime! (scalar)
        if (this.ExpireTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expireTime\n" ;
            } else {
                s += ind + "expireTime\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String (scalar)
        if (this.ReportUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportUrl\n" ;
            } else {
                s += ind + "reportUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AppflowsBlueprintFailoverReportStatusEnum? Status
        // GraphQL -> status: AppflowsBlueprintFailoverReportStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AppflowsBlueprintFailoverReportStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? ExpireTime
        // GraphQL -> expireTime: DateTime! (scalar)
        if (ec.Includes("expireTime",true))
        {
            if(this.ExpireTime == null) {

                this.ExpireTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpireTime != null && ec.Excludes("expireTime",true))
        {
            this.ExpireTime = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String (scalar)
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

    } // class FailoverReport
    
    #endregion

    public static class ListFailoverReportExtensions
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
            this List<FailoverReport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverReport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverReport> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverReport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverReport> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types