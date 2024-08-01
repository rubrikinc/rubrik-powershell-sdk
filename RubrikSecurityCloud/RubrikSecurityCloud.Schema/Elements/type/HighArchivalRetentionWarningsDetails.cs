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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        if (this.FrequencyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequencyType\n" ;
            } else {
                s += ind + "frequencyType\n" ;
            }
        }
        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        if (this.ArchivalRetentionInDaysProvided != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalRetentionInDaysProvided\n" ;
            } else {
                s += ind + "archivalRetentionInDaysProvided\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockDurationDays\n" ;
            } else {
                s += ind + "lockDurationDays\n" ;
            }
        }
        //      C# -> System.Int32? MaxLockDurationDaysRequired
        // GraphQL -> maxLockDurationDaysRequired: Int! (scalar)
        if (this.MaxLockDurationDaysRequired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxLockDurationDaysRequired\n" ;
            } else {
                s += ind + "maxLockDurationDaysRequired\n" ;
            }
        }
        //      C# -> System.Int32? MinLockDurationDaysRequired
        // GraphQL -> minLockDurationDaysRequired: Int! (scalar)
        if (this.MinLockDurationDaysRequired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minLockDurationDaysRequired\n" ;
            } else {
                s += ind + "minLockDurationDaysRequired\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RetentionUnit? FrequencyType
        // GraphQL -> frequencyType: RetentionUnit! (enum)
        if (ec.Includes("frequencyType",true))
        {
            if(this.FrequencyType == null) {

                this.FrequencyType = new RetentionUnit();

            } else {


            }
        }
        else if (this.FrequencyType != null && ec.Excludes("frequencyType",true))
        {
            this.FrequencyType = null;
        }
        //      C# -> System.Int32? ArchivalRetentionInDaysProvided
        // GraphQL -> archivalRetentionInDaysProvided: Int! (scalar)
        if (ec.Includes("archivalRetentionInDaysProvided",true))
        {
            if(this.ArchivalRetentionInDaysProvided == null) {

                this.ArchivalRetentionInDaysProvided = Int32.MinValue;

            } else {


            }
        }
        else if (this.ArchivalRetentionInDaysProvided != null && ec.Excludes("archivalRetentionInDaysProvided",true))
        {
            this.ArchivalRetentionInDaysProvided = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (ec.Includes("lockDurationDays",true))
        {
            if(this.LockDurationDays == null) {

                this.LockDurationDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.LockDurationDays != null && ec.Excludes("lockDurationDays",true))
        {
            this.LockDurationDays = null;
        }
        //      C# -> System.Int32? MaxLockDurationDaysRequired
        // GraphQL -> maxLockDurationDaysRequired: Int! (scalar)
        if (ec.Includes("maxLockDurationDaysRequired",true))
        {
            if(this.MaxLockDurationDaysRequired == null) {

                this.MaxLockDurationDaysRequired = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxLockDurationDaysRequired != null && ec.Excludes("maxLockDurationDaysRequired",true))
        {
            this.MaxLockDurationDaysRequired = null;
        }
        //      C# -> System.Int32? MinLockDurationDaysRequired
        // GraphQL -> minLockDurationDaysRequired: Int! (scalar)
        if (ec.Includes("minLockDurationDaysRequired",true))
        {
            if(this.MinLockDurationDaysRequired == null) {

                this.MinLockDurationDaysRequired = Int32.MinValue;

            } else {


            }
        }
        else if (this.MinLockDurationDaysRequired != null && ec.Excludes("minLockDurationDaysRequired",true))
        {
            this.MinLockDurationDaysRequired = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class HighArchivalRetentionWarningsDetails
    
    #endregion

    public static class ListHighArchivalRetentionWarningsDetailsExtensions
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
            this List<HighArchivalRetentionWarningsDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HighArchivalRetentionWarningsDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<HighArchivalRetentionWarningsDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types