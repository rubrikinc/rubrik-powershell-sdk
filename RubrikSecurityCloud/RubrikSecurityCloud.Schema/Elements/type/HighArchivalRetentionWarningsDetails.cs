// HighArchivalRetentionWarningsDetails.cs
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
    #region HighArchivalRetentionWarningsDetails
 
    public class HighArchivalRetentionWarningsDetails: BaseType, SpecificArchivalLocationWarningDetails
    {
        #region members

        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        [JsonProperty("frequencyType")]
        public RetentionUnit? FrequencyType { get; set; }

        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        [JsonProperty("archivalRetentionInDaysProvided")]
        public System.Int32? ArchivalRetentionInDaysProvided { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        [JsonProperty("lockDurationDays")]
        public System.Int32? LockDurationDays { get; set; }

        //      C# -> System.Int32? MaxLockDurationDaysRequired
        // GraphQL -> maxLockDurationDaysRequired: Int! (scalar)
        [JsonProperty("maxLockDurationDaysRequired")]
        public System.Int32? MaxLockDurationDaysRequired { get; set; }

        //      C# -> System.Int32? MinLockDurationDaysRequired
        // GraphQL -> minLockDurationDaysRequired: Int! (scalar)
        [JsonProperty("minLockDurationDaysRequired")]
        public System.Int32? MinLockDurationDaysRequired { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HighArchivalRetentionWarningsDetails";
    }

    public HighArchivalRetentionWarningsDetails Set(
        RetentionUnit? FrequencyType = null,
        System.Int32? ArchivalRetentionInDaysProvided = null,
        System.String? Id = null,
        System.Int32? LockDurationDays = null,
        System.Int32? MaxLockDurationDaysRequired = null,
        System.Int32? MinLockDurationDaysRequired = null,
        System.String? Name = null
    ) 
    {
        if ( FrequencyType != null ) {
            this.FrequencyType = FrequencyType;
        }
        if ( ArchivalRetentionInDaysProvided != null ) {
            this.ArchivalRetentionInDaysProvided = ArchivalRetentionInDaysProvided;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LockDurationDays != null ) {
            this.LockDurationDays = LockDurationDays;
        }
        if ( MaxLockDurationDaysRequired != null ) {
            this.MaxLockDurationDaysRequired = MaxLockDurationDaysRequired;
        }
        if ( MinLockDurationDaysRequired != null ) {
            this.MinLockDurationDaysRequired = MinLockDurationDaysRequired;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        if (this.FrequencyType != null) {
            s += ind + "frequencyType\n" ;
        }
        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        if (this.ArchivalRetentionInDaysProvided != null) {
            s += ind + "archivalRetentionInDaysProvided\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays != null) {
            s += ind + "lockDurationDays\n" ;
        }
        //      C# -> System.Int32? MaxLockDurationDaysRequired
        // GraphQL -> maxLockDurationDaysRequired: Int! (scalar)
        if (this.MaxLockDurationDaysRequired != null) {
            s += ind + "maxLockDurationDaysRequired\n" ;
        }
        //      C# -> System.Int32? MinLockDurationDaysRequired
        // GraphQL -> minLockDurationDaysRequired: Int! (scalar)
        if (this.MinLockDurationDaysRequired != null) {
            s += ind + "minLockDurationDaysRequired\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        if (this.FrequencyType == null && ec.Includes("frequencyType",true))
        {
            this.FrequencyType = new RetentionUnit();
        }
        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        if (this.ArchivalRetentionInDaysProvided == null && ec.Includes("archivalRetentionInDaysProvided",true))
        {
            this.ArchivalRetentionInDaysProvided = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays == null && ec.Includes("lockDurationDays",true))
        {
            this.LockDurationDays = Int32.MinValue;
        }
        //      C# -> System.Int32? MaxLockDurationDaysRequired
        // GraphQL -> maxLockDurationDaysRequired: Int! (scalar)
        if (this.MaxLockDurationDaysRequired == null && ec.Includes("maxLockDurationDaysRequired",true))
        {
            this.MaxLockDurationDaysRequired = Int32.MinValue;
        }
        //      C# -> System.Int32? MinLockDurationDaysRequired
        // GraphQL -> minLockDurationDaysRequired: Int! (scalar)
        if (this.MinLockDurationDaysRequired == null && ec.Includes("minLockDurationDaysRequired",true))
        {
            this.MinLockDurationDaysRequired = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class HighArchivalRetentionWarningsDetails
    
    #endregion

    public static class ListHighArchivalRetentionWarningsDetailsExtensions
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
            this List<HighArchivalRetentionWarningsDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HighArchivalRetentionWarningsDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HighArchivalRetentionWarningsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<HighArchivalRetentionWarningsDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types