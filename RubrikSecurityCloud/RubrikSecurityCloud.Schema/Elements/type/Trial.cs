// Trial.cs
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
    #region Trial
    public class Trial: BaseType
    {
        #region members

        //      C# -> TrialState? State
        // GraphQL -> state: TrialState! (enum)
        [JsonProperty("state")]
        public TrialState? State { get; set; }

        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        [JsonProperty("type")]
        public TrialType? Type { get; set; }

        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        [JsonProperty("activatedAt")]
        public DateTime? ActivatedAt { get; set; }

        //      C# -> System.String? ActivatorUserId
        // GraphQL -> activatorUserId: String! (scalar)
        [JsonProperty("activatorUserId")]
        public System.String? ActivatorUserId { get; set; }

        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        [JsonProperty("duration")]
        public System.Int32? Duration { get; set; }

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> System.Boolean? HasValidReport
        // GraphQL -> hasValidReport: Boolean! (scalar)
        [JsonProperty("hasValidReport")]
        public System.Boolean? HasValidReport { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsIgnored
        // GraphQL -> isIgnored: Boolean! (scalar)
        [JsonProperty("isIgnored")]
        public System.Boolean? IsIgnored { get; set; }

        //      C# -> System.Boolean? IsOnboardingComplete
        // GraphQL -> isOnboardingComplete: Boolean! (scalar)
        [JsonProperty("isOnboardingComplete")]
        public System.Boolean? IsOnboardingComplete { get; set; }

        //      C# -> System.Int32? NumExtensions
        // GraphQL -> numExtensions: Int! (scalar)
        [JsonProperty("numExtensions")]
        public System.Int32? NumExtensions { get; set; }

        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        [JsonProperty("offeredAt")]
        public DateTime? OfferedAt { get; set; }

        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        [JsonProperty("roleId")]
        public System.String? RoleId { get; set; }

        //      C# -> System.Boolean? WasExplicitlyInvited
        // GraphQL -> wasExplicitlyInvited: Boolean! (scalar)
        [JsonProperty("wasExplicitlyInvited")]
        public System.Boolean? WasExplicitlyInvited { get; set; }

        //      C# -> TrialSpecificParams? Params
        // GraphQL -> params: TrialSpecificParams (type)
        [JsonProperty("params")]
        public TrialSpecificParams? Params { get; set; }

        //      C# -> List<TrialTask>? Tasks
        // GraphQL -> tasks: [TrialTask!]! (type)
        [JsonProperty("tasks")]
        public List<TrialTask>? Tasks { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Trial";
    }

    public Trial Set(
        TrialState? State = null,
        TrialType? Type = null,
        DateTime? ActivatedAt = null,
        System.String? ActivatorUserId = null,
        System.Int32? Duration = null,
        DateTime? EndDate = null,
        System.Boolean? HasValidReport = null,
        System.String? Id = null,
        System.Boolean? IsIgnored = null,
        System.Boolean? IsOnboardingComplete = null,
        System.Int32? NumExtensions = null,
        DateTime? OfferedAt = null,
        System.String? RoleId = null,
        System.Boolean? WasExplicitlyInvited = null,
        TrialSpecificParams? Params = null,
        List<TrialTask>? Tasks = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ActivatedAt != null ) {
            this.ActivatedAt = ActivatedAt;
        }
        if ( ActivatorUserId != null ) {
            this.ActivatorUserId = ActivatorUserId;
        }
        if ( Duration != null ) {
            this.Duration = Duration;
        }
        if ( EndDate != null ) {
            this.EndDate = EndDate;
        }
        if ( HasValidReport != null ) {
            this.HasValidReport = HasValidReport;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsIgnored != null ) {
            this.IsIgnored = IsIgnored;
        }
        if ( IsOnboardingComplete != null ) {
            this.IsOnboardingComplete = IsOnboardingComplete;
        }
        if ( NumExtensions != null ) {
            this.NumExtensions = NumExtensions;
        }
        if ( OfferedAt != null ) {
            this.OfferedAt = OfferedAt;
        }
        if ( RoleId != null ) {
            this.RoleId = RoleId;
        }
        if ( WasExplicitlyInvited != null ) {
            this.WasExplicitlyInvited = WasExplicitlyInvited;
        }
        if ( Params != null ) {
            this.Params = Params;
        }
        if ( Tasks != null ) {
            this.Tasks = Tasks;
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
        //      C# -> TrialState? State
        // GraphQL -> state: TrialState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        if (this.ActivatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activatedAt\n" ;
            } else {
                s += ind + "activatedAt\n" ;
            }
        }
        //      C# -> System.String? ActivatorUserId
        // GraphQL -> activatorUserId: String! (scalar)
        if (this.ActivatorUserId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activatorUserId\n" ;
            } else {
                s += ind + "activatorUserId\n" ;
            }
        }
        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        if (this.Duration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "duration\n" ;
            } else {
                s += ind + "duration\n" ;
            }
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endDate\n" ;
            } else {
                s += ind + "endDate\n" ;
            }
        }
        //      C# -> System.Boolean? HasValidReport
        // GraphQL -> hasValidReport: Boolean! (scalar)
        if (this.HasValidReport != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasValidReport\n" ;
            } else {
                s += ind + "hasValidReport\n" ;
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
        //      C# -> System.Boolean? IsIgnored
        // GraphQL -> isIgnored: Boolean! (scalar)
        if (this.IsIgnored != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIgnored\n" ;
            } else {
                s += ind + "isIgnored\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnboardingComplete
        // GraphQL -> isOnboardingComplete: Boolean! (scalar)
        if (this.IsOnboardingComplete != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnboardingComplete\n" ;
            } else {
                s += ind + "isOnboardingComplete\n" ;
            }
        }
        //      C# -> System.Int32? NumExtensions
        // GraphQL -> numExtensions: Int! (scalar)
        if (this.NumExtensions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numExtensions\n" ;
            } else {
                s += ind + "numExtensions\n" ;
            }
        }
        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        if (this.OfferedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "offeredAt\n" ;
            } else {
                s += ind + "offeredAt\n" ;
            }
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (this.RoleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleId\n" ;
            } else {
                s += ind + "roleId\n" ;
            }
        }
        //      C# -> System.Boolean? WasExplicitlyInvited
        // GraphQL -> wasExplicitlyInvited: Boolean! (scalar)
        if (this.WasExplicitlyInvited != null) {
            if (conf.Flat) {
                s += conf.Prefix + "wasExplicitlyInvited\n" ;
            } else {
                s += ind + "wasExplicitlyInvited\n" ;
            }
        }
        //      C# -> TrialSpecificParams? Params
        // GraphQL -> params: TrialSpecificParams (type)
        if (this.Params != null) {
            var fspec = this.Params.AsFieldSpec(conf.Child("params"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "params" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TrialTask>? Tasks
        // GraphQL -> tasks: [TrialTask!]! (type)
        if (this.Tasks != null) {
            var fspec = this.Tasks.AsFieldSpec(conf.Child("tasks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tasks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TrialState? State
        // GraphQL -> state: TrialState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new TrialState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new TrialType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        if (ec.Includes("activatedAt",true))
        {
            if(this.ActivatedAt == null) {

                this.ActivatedAt = new DateTime();

            } else {


            }
        }
        else if (this.ActivatedAt != null && ec.Excludes("activatedAt",true))
        {
            this.ActivatedAt = null;
        }
        //      C# -> System.String? ActivatorUserId
        // GraphQL -> activatorUserId: String! (scalar)
        if (ec.Includes("activatorUserId",true))
        {
            if(this.ActivatorUserId == null) {

                this.ActivatorUserId = "FETCH";

            } else {


            }
        }
        else if (this.ActivatorUserId != null && ec.Excludes("activatorUserId",true))
        {
            this.ActivatorUserId = null;
        }
        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        if (ec.Includes("duration",true))
        {
            if(this.Duration == null) {

                this.Duration = Int32.MinValue;

            } else {


            }
        }
        else if (this.Duration != null && ec.Excludes("duration",true))
        {
            this.Duration = null;
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (ec.Includes("endDate",true))
        {
            if(this.EndDate == null) {

                this.EndDate = new DateTime();

            } else {


            }
        }
        else if (this.EndDate != null && ec.Excludes("endDate",true))
        {
            this.EndDate = null;
        }
        //      C# -> System.Boolean? HasValidReport
        // GraphQL -> hasValidReport: Boolean! (scalar)
        if (ec.Includes("hasValidReport",true))
        {
            if(this.HasValidReport == null) {

                this.HasValidReport = true;

            } else {


            }
        }
        else if (this.HasValidReport != null && ec.Excludes("hasValidReport",true))
        {
            this.HasValidReport = null;
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
        //      C# -> System.Boolean? IsIgnored
        // GraphQL -> isIgnored: Boolean! (scalar)
        if (ec.Includes("isIgnored",true))
        {
            if(this.IsIgnored == null) {

                this.IsIgnored = true;

            } else {


            }
        }
        else if (this.IsIgnored != null && ec.Excludes("isIgnored",true))
        {
            this.IsIgnored = null;
        }
        //      C# -> System.Boolean? IsOnboardingComplete
        // GraphQL -> isOnboardingComplete: Boolean! (scalar)
        if (ec.Includes("isOnboardingComplete",true))
        {
            if(this.IsOnboardingComplete == null) {

                this.IsOnboardingComplete = true;

            } else {


            }
        }
        else if (this.IsOnboardingComplete != null && ec.Excludes("isOnboardingComplete",true))
        {
            this.IsOnboardingComplete = null;
        }
        //      C# -> System.Int32? NumExtensions
        // GraphQL -> numExtensions: Int! (scalar)
        if (ec.Includes("numExtensions",true))
        {
            if(this.NumExtensions == null) {

                this.NumExtensions = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumExtensions != null && ec.Excludes("numExtensions",true))
        {
            this.NumExtensions = null;
        }
        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        if (ec.Includes("offeredAt",true))
        {
            if(this.OfferedAt == null) {

                this.OfferedAt = new DateTime();

            } else {


            }
        }
        else if (this.OfferedAt != null && ec.Excludes("offeredAt",true))
        {
            this.OfferedAt = null;
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (ec.Includes("roleId",true))
        {
            if(this.RoleId == null) {

                this.RoleId = "FETCH";

            } else {


            }
        }
        else if (this.RoleId != null && ec.Excludes("roleId",true))
        {
            this.RoleId = null;
        }
        //      C# -> System.Boolean? WasExplicitlyInvited
        // GraphQL -> wasExplicitlyInvited: Boolean! (scalar)
        if (ec.Includes("wasExplicitlyInvited",true))
        {
            if(this.WasExplicitlyInvited == null) {

                this.WasExplicitlyInvited = true;

            } else {


            }
        }
        else if (this.WasExplicitlyInvited != null && ec.Excludes("wasExplicitlyInvited",true))
        {
            this.WasExplicitlyInvited = null;
        }
        //      C# -> TrialSpecificParams? Params
        // GraphQL -> params: TrialSpecificParams (type)
        if (ec.Includes("params",false))
        {
            if(this.Params == null) {

                this.Params = new TrialSpecificParams();
                this.Params.ApplyExploratoryFieldSpec(ec.NewChild("params"));

            } else {

                this.Params.ApplyExploratoryFieldSpec(ec.NewChild("params"));

            }
        }
        else if (this.Params != null && ec.Excludes("params",false))
        {
            this.Params = null;
        }
        //      C# -> List<TrialTask>? Tasks
        // GraphQL -> tasks: [TrialTask!]! (type)
        if (ec.Includes("tasks",false))
        {
            if(this.Tasks == null) {

                this.Tasks = new List<TrialTask>();
                this.Tasks.ApplyExploratoryFieldSpec(ec.NewChild("tasks"));

            } else {

                this.Tasks.ApplyExploratoryFieldSpec(ec.NewChild("tasks"));

            }
        }
        else if (this.Tasks != null && ec.Excludes("tasks",false))
        {
            this.Tasks = null;
        }
    }


    #endregion

    } // class Trial
    
    #endregion

    public static class ListTrialExtensions
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
            this List<Trial> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Trial> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Trial> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Trial());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Trial> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types