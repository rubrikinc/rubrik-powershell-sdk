// Failover.cs
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
    #region Failover
    public class Failover: BaseType
    {
        #region members

        //      C# -> FailoverStatusEnum? FailoverStatus
        // GraphQL -> failoverStatus: FailoverStatusEnum! (enum)
        [JsonProperty("failoverStatus")]
        public FailoverStatusEnum? FailoverStatus { get; set; }

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> LastTestStatusEnum? LastTestStatus
        // GraphQL -> lastTestStatus: LastTestStatusEnum (enum)
        [JsonProperty("lastTestStatus")]
        public LastTestStatusEnum? LastTestStatus { get; set; }

        //      C# -> System.String? AppBlueprintId
        // GraphQL -> appBlueprintId: UUID! (scalar)
        [JsonProperty("appBlueprintId")]
        public System.String? AppBlueprintId { get; set; }

        //      C# -> System.String? AppBlueprintName
        // GraphQL -> appBlueprintName: String! (scalar)
        [JsonProperty("appBlueprintName")]
        public System.String? AppBlueprintName { get; set; }

        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long (scalar)
        [JsonProperty("duration")]
        public System.Int64? Duration { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastTestTime
        // GraphQL -> lastTestTime: DateTime (scalar)
        [JsonProperty("lastTestTime")]
        public DateTime? LastTestTime { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? TargetSite
        // GraphQL -> targetSite: String! (scalar)
        [JsonProperty("targetSite")]
        public System.String? TargetSite { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }

        //      C# -> FailoverReport? Report
        // GraphQL -> report: FailoverReport (type)
        [JsonProperty("report")]
        public FailoverReport? Report { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars Report { get; set; }


        public InlineVars() {
            Tuple<string, string>[] reportArgs = {
                    Tuple.Create("failoverReportId", "String!"),
                };
            this.Report =
                new RscGqlVars(null, reportArgs, null, true);
        }
    }

    public Failover()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "Failover";
    }

    public Failover Set(
        FailoverStatusEnum? FailoverStatus = null,
        FailoverTypeEnum? FailoverType = null,
        LastTestStatusEnum? LastTestStatus = null,
        System.String? AppBlueprintId = null,
        System.String? AppBlueprintName = null,
        System.Int64? Duration = null,
        DateTime? EndTime = null,
        System.String? Id = null,
        DateTime? LastTestTime = null,
        System.String? Source = null,
        DateTime? StartTime = null,
        System.String? TargetSite = null,
        System.String? TaskchainId = null,
        FailoverReport? Report = null
    ) 
    {
        if ( FailoverStatus != null ) {
            this.FailoverStatus = FailoverStatus;
        }
        if ( FailoverType != null ) {
            this.FailoverType = FailoverType;
        }
        if ( LastTestStatus != null ) {
            this.LastTestStatus = LastTestStatus;
        }
        if ( AppBlueprintId != null ) {
            this.AppBlueprintId = AppBlueprintId;
        }
        if ( AppBlueprintName != null ) {
            this.AppBlueprintName = AppBlueprintName;
        }
        if ( Duration != null ) {
            this.Duration = Duration;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastTestTime != null ) {
            this.LastTestTime = LastTestTime;
        }
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TargetSite != null ) {
            this.TargetSite = TargetSite;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
        }
        if ( Report != null ) {
            this.Report = Report;
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
        //      C# -> FailoverStatusEnum? FailoverStatus
        // GraphQL -> failoverStatus: FailoverStatusEnum! (enum)
        if (this.FailoverStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverStatus\n" ;
            } else {
                s += ind + "failoverStatus\n" ;
            }
        }
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (this.FailoverType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverType\n" ;
            } else {
                s += ind + "failoverType\n" ;
            }
        }
        //      C# -> LastTestStatusEnum? LastTestStatus
        // GraphQL -> lastTestStatus: LastTestStatusEnum (enum)
        if (this.LastTestStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastTestStatus\n" ;
            } else {
                s += ind + "lastTestStatus\n" ;
            }
        }
        //      C# -> System.String? AppBlueprintId
        // GraphQL -> appBlueprintId: UUID! (scalar)
        if (this.AppBlueprintId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appBlueprintId\n" ;
            } else {
                s += ind + "appBlueprintId\n" ;
            }
        }
        //      C# -> System.String? AppBlueprintName
        // GraphQL -> appBlueprintName: String! (scalar)
        if (this.AppBlueprintName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appBlueprintName\n" ;
            } else {
                s += ind + "appBlueprintName\n" ;
            }
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long (scalar)
        if (this.Duration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "duration\n" ;
            } else {
                s += ind + "duration\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
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
        //      C# -> DateTime? LastTestTime
        // GraphQL -> lastTestTime: DateTime (scalar)
        if (this.LastTestTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastTestTime\n" ;
            } else {
                s += ind + "lastTestTime\n" ;
            }
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? TargetSite
        // GraphQL -> targetSite: String! (scalar)
        if (this.TargetSite != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetSite\n" ;
            } else {
                s += ind + "targetSite\n" ;
            }
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainId\n" ;
            } else {
                s += ind + "taskchainId\n" ;
            }
        }
        //      C# -> FailoverReport? Report
        // GraphQL -> report: FailoverReport (type)
        if (this.Report != null) {
            var fspec = this.Report.AsFieldSpec(conf.Child("report"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "report" + "\n(" + this.Vars.Report.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FailoverStatusEnum? FailoverStatus
        // GraphQL -> failoverStatus: FailoverStatusEnum! (enum)
        if (ec.Includes("failoverStatus",true))
        {
            if(this.FailoverStatus == null) {

                this.FailoverStatus = new FailoverStatusEnum();

            } else {


            }
        }
        else if (this.FailoverStatus != null && ec.Excludes("failoverStatus",true))
        {
            this.FailoverStatus = null;
        }
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (ec.Includes("failoverType",true))
        {
            if(this.FailoverType == null) {

                this.FailoverType = new FailoverTypeEnum();

            } else {


            }
        }
        else if (this.FailoverType != null && ec.Excludes("failoverType",true))
        {
            this.FailoverType = null;
        }
        //      C# -> LastTestStatusEnum? LastTestStatus
        // GraphQL -> lastTestStatus: LastTestStatusEnum (enum)
        if (ec.Includes("lastTestStatus",true))
        {
            if(this.LastTestStatus == null) {

                this.LastTestStatus = new LastTestStatusEnum();

            } else {


            }
        }
        else if (this.LastTestStatus != null && ec.Excludes("lastTestStatus",true))
        {
            this.LastTestStatus = null;
        }
        //      C# -> System.String? AppBlueprintId
        // GraphQL -> appBlueprintId: UUID! (scalar)
        if (ec.Includes("appBlueprintId",true))
        {
            if(this.AppBlueprintId == null) {

                this.AppBlueprintId = "FETCH";

            } else {


            }
        }
        else if (this.AppBlueprintId != null && ec.Excludes("appBlueprintId",true))
        {
            this.AppBlueprintId = null;
        }
        //      C# -> System.String? AppBlueprintName
        // GraphQL -> appBlueprintName: String! (scalar)
        if (ec.Includes("appBlueprintName",true))
        {
            if(this.AppBlueprintName == null) {

                this.AppBlueprintName = "FETCH";

            } else {


            }
        }
        else if (this.AppBlueprintName != null && ec.Excludes("appBlueprintName",true))
        {
            this.AppBlueprintName = null;
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long (scalar)
        if (ec.Includes("duration",true))
        {
            if(this.Duration == null) {

                this.Duration = new System.Int64();

            } else {


            }
        }
        else if (this.Duration != null && ec.Excludes("duration",true))
        {
            this.Duration = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
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
        //      C# -> DateTime? LastTestTime
        // GraphQL -> lastTestTime: DateTime (scalar)
        if (ec.Includes("lastTestTime",true))
        {
            if(this.LastTestTime == null) {

                this.LastTestTime = new DateTime();

            } else {


            }
        }
        else if (this.LastTestTime != null && ec.Excludes("lastTestTime",true))
        {
            this.LastTestTime = null;
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = "FETCH";

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? TargetSite
        // GraphQL -> targetSite: String! (scalar)
        if (ec.Includes("targetSite",true))
        {
            if(this.TargetSite == null) {

                this.TargetSite = "FETCH";

            } else {


            }
        }
        else if (this.TargetSite != null && ec.Excludes("targetSite",true))
        {
            this.TargetSite = null;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (ec.Includes("taskchainId",true))
        {
            if(this.TaskchainId == null) {

                this.TaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainId != null && ec.Excludes("taskchainId",true))
        {
            this.TaskchainId = null;
        }
        //      C# -> FailoverReport? Report
        // GraphQL -> report: FailoverReport (type)
        if (ec.Includes("report",false))
        {
            if(this.Report == null) {

                this.Report = new FailoverReport();
                this.Report.ApplyExploratoryFieldSpec(ec.NewChild("report"));

            } else {

                this.Report.ApplyExploratoryFieldSpec(ec.NewChild("report"));

            }
        }
        else if (this.Report != null && ec.Excludes("report",false))
        {
            this.Report = null;
        }
    }


    #endregion

    } // class Failover
    
    #endregion

    public static class ListFailoverExtensions
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
            this List<Failover> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Failover> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Failover> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Failover());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Failover> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types