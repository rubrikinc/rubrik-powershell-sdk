// SlaAutoMigrationStateInfo.cs
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
    #region SlaAutoMigrationStateInfo
    public class SlaAutoMigrationStateInfo: BaseType
    {
        #region members

        //      C# -> SlaAutoMigrationFsmState? State
        // GraphQL -> state: SlaAutoMigrationFsmState! (enum)
        [JsonProperty("state")]
        public SlaAutoMigrationFsmState? State { get; set; }

        //      C# -> DateTime? EndDate
        // GraphQL -> endDate: DateTime (scalar)
        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        //      C# -> System.Boolean? ExtensionGranted
        // GraphQL -> extensionGranted: Boolean! (scalar)
        [JsonProperty("extensionGranted")]
        public System.Boolean? ExtensionGranted { get; set; }

        //      C# -> System.Boolean? ExtensionGrantedInCurrentState
        // GraphQL -> extensionGrantedInCurrentState: Boolean! (scalar)
        [JsonProperty("extensionGrantedInCurrentState")]
        public System.Boolean? ExtensionGrantedInCurrentState { get; set; }

        //      C# -> DateTime? PauseDate
        // GraphQL -> pauseDate: DateTime (scalar)
        [JsonProperty("pauseDate")]
        public DateTime? PauseDate { get; set; }

        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        //      C# -> System.Boolean? SuccessfullyMigrated
        // GraphQL -> successfullyMigrated: Boolean! (scalar)
        [JsonProperty("successfullyMigrated")]
        public System.Boolean? SuccessfullyMigrated { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaAutoMigrationStateInfo";
    }

    public SlaAutoMigrationStateInfo Set(
        SlaAutoMigrationFsmState? State = null,
        DateTime? EndDate = null,
        System.Boolean? ExtensionGranted = null,
        System.Boolean? ExtensionGrantedInCurrentState = null,
        DateTime? PauseDate = null,
        DateTime? StartDate = null,
        System.Boolean? SuccessfullyMigrated = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( EndDate != null ) {
            this.EndDate = EndDate;
        }
        if ( ExtensionGranted != null ) {
            this.ExtensionGranted = ExtensionGranted;
        }
        if ( ExtensionGrantedInCurrentState != null ) {
            this.ExtensionGrantedInCurrentState = ExtensionGrantedInCurrentState;
        }
        if ( PauseDate != null ) {
            this.PauseDate = PauseDate;
        }
        if ( StartDate != null ) {
            this.StartDate = StartDate;
        }
        if ( SuccessfullyMigrated != null ) {
            this.SuccessfullyMigrated = SuccessfullyMigrated;
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
        //      C# -> SlaAutoMigrationFsmState? State
        // GraphQL -> state: SlaAutoMigrationFsmState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
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
        //      C# -> System.Boolean? ExtensionGranted
        // GraphQL -> extensionGranted: Boolean! (scalar)
        if (this.ExtensionGranted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "extensionGranted\n" ;
            } else {
                s += ind + "extensionGranted\n" ;
            }
        }
        //      C# -> System.Boolean? ExtensionGrantedInCurrentState
        // GraphQL -> extensionGrantedInCurrentState: Boolean! (scalar)
        if (this.ExtensionGrantedInCurrentState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "extensionGrantedInCurrentState\n" ;
            } else {
                s += ind + "extensionGrantedInCurrentState\n" ;
            }
        }
        //      C# -> DateTime? PauseDate
        // GraphQL -> pauseDate: DateTime (scalar)
        if (this.PauseDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pauseDate\n" ;
            } else {
                s += ind + "pauseDate\n" ;
            }
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        if (this.StartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startDate\n" ;
            } else {
                s += ind + "startDate\n" ;
            }
        }
        //      C# -> System.Boolean? SuccessfullyMigrated
        // GraphQL -> successfullyMigrated: Boolean! (scalar)
        if (this.SuccessfullyMigrated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "successfullyMigrated\n" ;
            } else {
                s += ind + "successfullyMigrated\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaAutoMigrationFsmState? State
        // GraphQL -> state: SlaAutoMigrationFsmState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new SlaAutoMigrationFsmState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
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
        //      C# -> System.Boolean? ExtensionGranted
        // GraphQL -> extensionGranted: Boolean! (scalar)
        if (ec.Includes("extensionGranted",true))
        {
            if(this.ExtensionGranted == null) {

                this.ExtensionGranted = true;

            } else {


            }
        }
        else if (this.ExtensionGranted != null && ec.Excludes("extensionGranted",true))
        {
            this.ExtensionGranted = null;
        }
        //      C# -> System.Boolean? ExtensionGrantedInCurrentState
        // GraphQL -> extensionGrantedInCurrentState: Boolean! (scalar)
        if (ec.Includes("extensionGrantedInCurrentState",true))
        {
            if(this.ExtensionGrantedInCurrentState == null) {

                this.ExtensionGrantedInCurrentState = true;

            } else {


            }
        }
        else if (this.ExtensionGrantedInCurrentState != null && ec.Excludes("extensionGrantedInCurrentState",true))
        {
            this.ExtensionGrantedInCurrentState = null;
        }
        //      C# -> DateTime? PauseDate
        // GraphQL -> pauseDate: DateTime (scalar)
        if (ec.Includes("pauseDate",true))
        {
            if(this.PauseDate == null) {

                this.PauseDate = new DateTime();

            } else {


            }
        }
        else if (this.PauseDate != null && ec.Excludes("pauseDate",true))
        {
            this.PauseDate = null;
        }
        //      C# -> DateTime? StartDate
        // GraphQL -> startDate: DateTime (scalar)
        if (ec.Includes("startDate",true))
        {
            if(this.StartDate == null) {

                this.StartDate = new DateTime();

            } else {


            }
        }
        else if (this.StartDate != null && ec.Excludes("startDate",true))
        {
            this.StartDate = null;
        }
        //      C# -> System.Boolean? SuccessfullyMigrated
        // GraphQL -> successfullyMigrated: Boolean! (scalar)
        if (ec.Includes("successfullyMigrated",true))
        {
            if(this.SuccessfullyMigrated == null) {

                this.SuccessfullyMigrated = true;

            } else {


            }
        }
        else if (this.SuccessfullyMigrated != null && ec.Excludes("successfullyMigrated",true))
        {
            this.SuccessfullyMigrated = null;
        }
    }


    #endregion

    } // class SlaAutoMigrationStateInfo
    
    #endregion

    public static class ListSlaAutoMigrationStateInfoExtensions
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
            this List<SlaAutoMigrationStateInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaAutoMigrationStateInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaAutoMigrationStateInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaAutoMigrationStateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaAutoMigrationStateInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types