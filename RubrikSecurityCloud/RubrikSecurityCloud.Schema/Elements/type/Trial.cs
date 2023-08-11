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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ProductState? State
        // GraphQL -> state: ProductState! (enum)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new ProductState();
        }
        //      C# -> TrialType? Type
        // GraphQL -> type: TrialType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new TrialType();
        }
        //      C# -> DateTime? ActivatedAt
        // GraphQL -> activatedAt: DateTime (scalar)
        if (this.ActivatedAt == null && Exploration.Includes(parent + ".activatedAt", true))
        {
            this.ActivatedAt = new DateTime();
        }
        //      C# -> System.Int32? Duration
        // GraphQL -> duration: Int! (scalar)
        if (this.Duration == null && Exploration.Includes(parent + ".duration", true))
        {
            this.Duration = Int32.MinValue;
        }
        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        if (this.EndDate == null && Exploration.Includes(parent + ".endDate", true))
        {
            this.EndDate = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsIgnored
        // GraphQL -> isIgnored: Boolean! (scalar)
        if (this.IsIgnored == null && Exploration.Includes(parent + ".isIgnored", true))
        {
            this.IsIgnored = true;
        }
        //      C# -> System.Boolean? IsOnboardingComplete
        // GraphQL -> isOnboardingComplete: Boolean! (scalar)
        if (this.IsOnboardingComplete == null && Exploration.Includes(parent + ".isOnboardingComplete", true))
        {
            this.IsOnboardingComplete = true;
        }
        //      C# -> DateTime? OfferedAt
        // GraphQL -> offeredAt: DateTime! (scalar)
        if (this.OfferedAt == null && Exploration.Includes(parent + ".offeredAt", true))
        {
            this.OfferedAt = new DateTime();
        }
        //      C# -> TrialSpecificParams? Params
        // GraphQL -> params: TrialSpecificParams (type)
        if (this.Params == null && Exploration.Includes(parent + ".params"))
        {
            this.Params = new TrialSpecificParams();
            this.Params.ApplyExploratoryFieldSpec(parent + ".params");
        }
        //      C# -> List<TrialTask>? Tasks
        // GraphQL -> tasks: [TrialTask!]! (type)
        if (this.Tasks == null && Exploration.Includes(parent + ".tasks"))
        {
            this.Tasks = new List<TrialTask>();
            this.Tasks.ApplyExploratoryFieldSpec(parent + ".tasks");
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
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Trial());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types