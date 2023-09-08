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

        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        [JsonProperty("state")]
        public ProductState? State { get; set; }

        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        [JsonProperty("type")]
        public TrialType? Type { get; set; }

        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        [JsonProperty("activatedAt")]
        public DateTime? ActivatedAt { get; set; }

        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        [JsonProperty("duration")]
        public System.Int32? Duration { get; set; }

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

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

        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        [JsonProperty("offeredAt")]
        public DateTime? OfferedAt { get; set; }

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
        ProductState? State = null,
        TrialType? Type = null,
        DateTime? ActivatedAt = null,
        System.Int32? Duration = null,
        DateTime? EndDate = null,
        System.String? Id = null,
        System.Boolean? IsIgnored = null,
        System.Boolean? IsOnboardingComplete = null,
        DateTime? OfferedAt = null,
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
        if ( Duration != null ) {
            this.Duration = Duration;
        }
        if ( EndDate != null ) {
            this.EndDate = EndDate;
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
        if ( OfferedAt != null ) {
            this.OfferedAt = OfferedAt;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        if (this.ActivatedAt != null) {
            s += ind + "activatedAt\n" ;
        }
        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        if (this.Duration != null) {
            s += ind + "duration\n" ;
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate != null) {
            s += ind + "endDate\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsIgnored
        // GraphQL -> isIgnored: Boolean! (scalar)
        if (this.IsIgnored != null) {
            s += ind + "isIgnored\n" ;
        }
        //      C# -> System.Boolean? IsOnboardingComplete
        // GraphQL -> isOnboardingComplete: Boolean! (scalar)
        if (this.IsOnboardingComplete != null) {
            s += ind + "isOnboardingComplete\n" ;
        }
        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        if (this.OfferedAt != null) {
            s += ind + "offeredAt\n" ;
        }
        //      C# -> System.Boolean? WasExplicitlyInvited
        // GraphQL -> wasExplicitlyInvited: Boolean! (scalar)
        if (this.WasExplicitlyInvited != null) {
            s += ind + "wasExplicitlyInvited\n" ;
        }
        //      C# -> TrialSpecificParams? Params
        // GraphQL -> params: TrialSpecificParams (type)
        if (this.Params != null) {
            var fspec = this.Params.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "params {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TrialTask>? Tasks
        // GraphQL -> tasks: [TrialTask!]! (type)
        if (this.Tasks != null) {
            var fspec = this.Tasks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tasks {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (this.State == null && ec.Includes("state",true))
        {
            this.State = new ProductState();
        }
        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new TrialType();
        }
        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        if (this.ActivatedAt == null && ec.Includes("activatedAt",true))
        {
            this.ActivatedAt = new DateTime();
        }
        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        if (this.Duration == null && ec.Includes("duration",true))
        {
            this.Duration = Int32.MinValue;
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate == null && ec.Includes("endDate",true))
        {
            this.EndDate = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsIgnored
        // GraphQL -> isIgnored: Boolean! (scalar)
        if (this.IsIgnored == null && ec.Includes("isIgnored",true))
        {
            this.IsIgnored = true;
        }
        //      C# -> System.Boolean? IsOnboardingComplete
        // GraphQL -> isOnboardingComplete: Boolean! (scalar)
        if (this.IsOnboardingComplete == null && ec.Includes("isOnboardingComplete",true))
        {
            this.IsOnboardingComplete = true;
        }
        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        if (this.OfferedAt == null && ec.Includes("offeredAt",true))
        {
            this.OfferedAt = new DateTime();
        }
        //      C# -> System.Boolean? WasExplicitlyInvited
        // GraphQL -> wasExplicitlyInvited: Boolean! (scalar)
        if (this.WasExplicitlyInvited == null && ec.Includes("wasExplicitlyInvited",true))
        {
            this.WasExplicitlyInvited = true;
        }
        //      C# -> TrialSpecificParams? Params
        // GraphQL -> params: TrialSpecificParams (type)
        if (this.Params == null && ec.Includes("params",false))
        {
            this.Params = new TrialSpecificParams();
            this.Params.ApplyExploratoryFieldSpec(ec.NewChild("params"));
        }
        //      C# -> List<TrialTask>? Tasks
        // GraphQL -> tasks: [TrialTask!]! (type)
        if (this.Tasks == null && ec.Includes("tasks",false))
        {
            this.Tasks = new List<TrialTask>();
            this.Tasks.ApplyExploratoryFieldSpec(ec.NewChild("tasks"));
        }
    }


    #endregion

    } // class Trial
    
    #endregion

    public static class ListTrialExtensions
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
            this List<Trial> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<Trial> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types