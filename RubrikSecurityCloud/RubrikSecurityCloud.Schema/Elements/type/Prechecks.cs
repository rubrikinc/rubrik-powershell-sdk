// Prechecks.cs
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
    #region Prechecks
    public class Prechecks: BaseType
    {
        #region members

        //      C# -> MigrationPrecheckType? MigrationPrecheckType
        // GraphQL -> migrationPrecheckType: MigrationPrecheckType! (enum)
        [JsonProperty("migrationPrecheckType")]
        public MigrationPrecheckType? MigrationPrecheckType { get; set; }

        //      C# -> MigrationStatus? MigrationStatus
        // GraphQL -> migrationStatus: MigrationStatus! (enum)
        [JsonProperty("migrationStatus")]
        public MigrationStatus? MigrationStatus { get; set; }

        //      C# -> PrecheckName? PrecheckName
        // GraphQL -> precheckName: PrecheckName! (enum)
        [JsonProperty("precheckName")]
        public PrecheckName? PrecheckName { get; set; }

        //      C# -> PrecheckStatus? PrecheckStatus
        // GraphQL -> precheckStatus: PrecheckStatus! (enum)
        [JsonProperty("precheckStatus")]
        public PrecheckStatus? PrecheckStatus { get; set; }

        //      C# -> PrecheckType? PrecheckType
        // GraphQL -> precheckType: PrecheckType! (enum)
        [JsonProperty("precheckType")]
        public PrecheckType? PrecheckType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? LastRunTimestamp
        // GraphQL -> lastRunTimestamp: DateTime (scalar)
        [JsonProperty("lastRunTimestamp")]
        public DateTime? LastRunTimestamp { get; set; }

        //      C# -> System.Boolean? RequiredForRscMode
        // GraphQL -> requiredForRSCMode: Boolean (scalar)
        [JsonProperty("requiredForRSCMode")]
        public System.Boolean? RequiredForRscMode { get; set; }

        //      C# -> System.Boolean? RequiredForSlaBlockMode
        // GraphQL -> requiredForSlaBlockMode: Boolean (scalar)
        [JsonProperty("requiredForSlaBlockMode")]
        public System.Boolean? RequiredForSlaBlockMode { get; set; }

        //      C# -> PrecheckMessage? Cause
        // GraphQL -> cause: PrecheckMessage (type)
        [JsonProperty("cause")]
        public PrecheckMessage? Cause { get; set; }

        //      C# -> PrecheckMessage? Consequence
        // GraphQL -> consequence: PrecheckMessage (type)
        [JsonProperty("consequence")]
        public PrecheckMessage? Consequence { get; set; }

        //      C# -> PrecheckMessage? Remedy
        // GraphQL -> remedy: PrecheckMessage (type)
        [JsonProperty("remedy")]
        public PrecheckMessage? Remedy { get; set; }

        //      C# -> PrecheckMessage? Summary
        // GraphQL -> summary: PrecheckMessage (type)
        [JsonProperty("summary")]
        public PrecheckMessage? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Prechecks";
    }

    public Prechecks Set(
        MigrationPrecheckType? MigrationPrecheckType = null,
        MigrationStatus? MigrationStatus = null,
        PrecheckName? PrecheckName = null,
        PrecheckStatus? PrecheckStatus = null,
        PrecheckType? PrecheckType = null,
        System.String? ClusterUuid = null,
        DateTime? LastRunTimestamp = null,
        System.Boolean? RequiredForRscMode = null,
        System.Boolean? RequiredForSlaBlockMode = null,
        PrecheckMessage? Cause = null,
        PrecheckMessage? Consequence = null,
        PrecheckMessage? Remedy = null,
        PrecheckMessage? Summary = null
    ) 
    {
        if ( MigrationPrecheckType != null ) {
            this.MigrationPrecheckType = MigrationPrecheckType;
        }
        if ( MigrationStatus != null ) {
            this.MigrationStatus = MigrationStatus;
        }
        if ( PrecheckName != null ) {
            this.PrecheckName = PrecheckName;
        }
        if ( PrecheckStatus != null ) {
            this.PrecheckStatus = PrecheckStatus;
        }
        if ( PrecheckType != null ) {
            this.PrecheckType = PrecheckType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( LastRunTimestamp != null ) {
            this.LastRunTimestamp = LastRunTimestamp;
        }
        if ( RequiredForRscMode != null ) {
            this.RequiredForRscMode = RequiredForRscMode;
        }
        if ( RequiredForSlaBlockMode != null ) {
            this.RequiredForSlaBlockMode = RequiredForSlaBlockMode;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( Consequence != null ) {
            this.Consequence = Consequence;
        }
        if ( Remedy != null ) {
            this.Remedy = Remedy;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> MigrationPrecheckType? MigrationPrecheckType
        // GraphQL -> migrationPrecheckType: MigrationPrecheckType! (enum)
        if (this.MigrationPrecheckType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationPrecheckType\n" ;
            } else {
                s += ind + "migrationPrecheckType\n" ;
            }
        }
        //      C# -> MigrationStatus? MigrationStatus
        // GraphQL -> migrationStatus: MigrationStatus! (enum)
        if (this.MigrationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationStatus\n" ;
            } else {
                s += ind + "migrationStatus\n" ;
            }
        }
        //      C# -> PrecheckName? PrecheckName
        // GraphQL -> precheckName: PrecheckName! (enum)
        if (this.PrecheckName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "precheckName\n" ;
            } else {
                s += ind + "precheckName\n" ;
            }
        }
        //      C# -> PrecheckStatus? PrecheckStatus
        // GraphQL -> precheckStatus: PrecheckStatus! (enum)
        if (this.PrecheckStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "precheckStatus\n" ;
            } else {
                s += ind + "precheckStatus\n" ;
            }
        }
        //      C# -> PrecheckType? PrecheckType
        // GraphQL -> precheckType: PrecheckType! (enum)
        if (this.PrecheckType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "precheckType\n" ;
            } else {
                s += ind + "precheckType\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> DateTime? LastRunTimestamp
        // GraphQL -> lastRunTimestamp: DateTime (scalar)
        if (this.LastRunTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRunTimestamp\n" ;
            } else {
                s += ind + "lastRunTimestamp\n" ;
            }
        }
        //      C# -> System.Boolean? RequiredForRscMode
        // GraphQL -> requiredForRSCMode: Boolean (scalar)
        if (this.RequiredForRscMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requiredForRSCMode\n" ;
            } else {
                s += ind + "requiredForRSCMode\n" ;
            }
        }
        //      C# -> System.Boolean? RequiredForSlaBlockMode
        // GraphQL -> requiredForSlaBlockMode: Boolean (scalar)
        if (this.RequiredForSlaBlockMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requiredForSlaBlockMode\n" ;
            } else {
                s += ind + "requiredForSlaBlockMode\n" ;
            }
        }
        //      C# -> PrecheckMessage? Cause
        // GraphQL -> cause: PrecheckMessage (type)
        if (this.Cause != null) {
            var fspec = this.Cause.AsFieldSpec(conf.Child("cause"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cause" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrecheckMessage? Consequence
        // GraphQL -> consequence: PrecheckMessage (type)
        if (this.Consequence != null) {
            var fspec = this.Consequence.AsFieldSpec(conf.Child("consequence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "consequence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrecheckMessage? Remedy
        // GraphQL -> remedy: PrecheckMessage (type)
        if (this.Remedy != null) {
            var fspec = this.Remedy.AsFieldSpec(conf.Child("remedy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remedy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrecheckMessage? Summary
        // GraphQL -> summary: PrecheckMessage (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(conf.Child("summary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "summary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MigrationPrecheckType? MigrationPrecheckType
        // GraphQL -> migrationPrecheckType: MigrationPrecheckType! (enum)
        if (ec.Includes("migrationPrecheckType",true))
        {
            if(this.MigrationPrecheckType == null) {

                this.MigrationPrecheckType = new MigrationPrecheckType();

            } else {


            }
        }
        else if (this.MigrationPrecheckType != null && ec.Excludes("migrationPrecheckType",true))
        {
            this.MigrationPrecheckType = null;
        }
        //      C# -> MigrationStatus? MigrationStatus
        // GraphQL -> migrationStatus: MigrationStatus! (enum)
        if (ec.Includes("migrationStatus",true))
        {
            if(this.MigrationStatus == null) {

                this.MigrationStatus = new MigrationStatus();

            } else {


            }
        }
        else if (this.MigrationStatus != null && ec.Excludes("migrationStatus",true))
        {
            this.MigrationStatus = null;
        }
        //      C# -> PrecheckName? PrecheckName
        // GraphQL -> precheckName: PrecheckName! (enum)
        if (ec.Includes("precheckName",true))
        {
            if(this.PrecheckName == null) {

                this.PrecheckName = new PrecheckName();

            } else {


            }
        }
        else if (this.PrecheckName != null && ec.Excludes("precheckName",true))
        {
            this.PrecheckName = null;
        }
        //      C# -> PrecheckStatus? PrecheckStatus
        // GraphQL -> precheckStatus: PrecheckStatus! (enum)
        if (ec.Includes("precheckStatus",true))
        {
            if(this.PrecheckStatus == null) {

                this.PrecheckStatus = new PrecheckStatus();

            } else {


            }
        }
        else if (this.PrecheckStatus != null && ec.Excludes("precheckStatus",true))
        {
            this.PrecheckStatus = null;
        }
        //      C# -> PrecheckType? PrecheckType
        // GraphQL -> precheckType: PrecheckType! (enum)
        if (ec.Includes("precheckType",true))
        {
            if(this.PrecheckType == null) {

                this.PrecheckType = new PrecheckType();

            } else {


            }
        }
        else if (this.PrecheckType != null && ec.Excludes("precheckType",true))
        {
            this.PrecheckType = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> DateTime? LastRunTimestamp
        // GraphQL -> lastRunTimestamp: DateTime (scalar)
        if (ec.Includes("lastRunTimestamp",true))
        {
            if(this.LastRunTimestamp == null) {

                this.LastRunTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.LastRunTimestamp != null && ec.Excludes("lastRunTimestamp",true))
        {
            this.LastRunTimestamp = null;
        }
        //      C# -> System.Boolean? RequiredForRscMode
        // GraphQL -> requiredForRSCMode: Boolean (scalar)
        if (ec.Includes("requiredForRSCMode",true))
        {
            if(this.RequiredForRscMode == null) {

                this.RequiredForRscMode = true;

            } else {


            }
        }
        else if (this.RequiredForRscMode != null && ec.Excludes("requiredForRSCMode",true))
        {
            this.RequiredForRscMode = null;
        }
        //      C# -> System.Boolean? RequiredForSlaBlockMode
        // GraphQL -> requiredForSlaBlockMode: Boolean (scalar)
        if (ec.Includes("requiredForSlaBlockMode",true))
        {
            if(this.RequiredForSlaBlockMode == null) {

                this.RequiredForSlaBlockMode = true;

            } else {


            }
        }
        else if (this.RequiredForSlaBlockMode != null && ec.Excludes("requiredForSlaBlockMode",true))
        {
            this.RequiredForSlaBlockMode = null;
        }
        //      C# -> PrecheckMessage? Cause
        // GraphQL -> cause: PrecheckMessage (type)
        if (ec.Includes("cause",false))
        {
            if(this.Cause == null) {

                this.Cause = new PrecheckMessage();
                this.Cause.ApplyExploratoryFieldSpec(ec.NewChild("cause"));

            } else {

                this.Cause.ApplyExploratoryFieldSpec(ec.NewChild("cause"));

            }
        }
        else if (this.Cause != null && ec.Excludes("cause",false))
        {
            this.Cause = null;
        }
        //      C# -> PrecheckMessage? Consequence
        // GraphQL -> consequence: PrecheckMessage (type)
        if (ec.Includes("consequence",false))
        {
            if(this.Consequence == null) {

                this.Consequence = new PrecheckMessage();
                this.Consequence.ApplyExploratoryFieldSpec(ec.NewChild("consequence"));

            } else {

                this.Consequence.ApplyExploratoryFieldSpec(ec.NewChild("consequence"));

            }
        }
        else if (this.Consequence != null && ec.Excludes("consequence",false))
        {
            this.Consequence = null;
        }
        //      C# -> PrecheckMessage? Remedy
        // GraphQL -> remedy: PrecheckMessage (type)
        if (ec.Includes("remedy",false))
        {
            if(this.Remedy == null) {

                this.Remedy = new PrecheckMessage();
                this.Remedy.ApplyExploratoryFieldSpec(ec.NewChild("remedy"));

            } else {

                this.Remedy.ApplyExploratoryFieldSpec(ec.NewChild("remedy"));

            }
        }
        else if (this.Remedy != null && ec.Excludes("remedy",false))
        {
            this.Remedy = null;
        }
        //      C# -> PrecheckMessage? Summary
        // GraphQL -> summary: PrecheckMessage (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new PrecheckMessage();
                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            } else {

                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            }
        }
        else if (this.Summary != null && ec.Excludes("summary",false))
        {
            this.Summary = null;
        }
    }


    #endregion

    } // class Prechecks
    
    #endregion

    public static class ListPrechecksExtensions
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
            this List<Prechecks> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Prechecks> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Prechecks> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Prechecks());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Prechecks> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types