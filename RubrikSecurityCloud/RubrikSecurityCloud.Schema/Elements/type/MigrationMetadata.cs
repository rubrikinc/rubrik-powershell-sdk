// MigrationMetadata.cs
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
    #region MigrationMetadata
    public class MigrationMetadata: BaseType
    {
        #region members

        //      C# -> ClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ClusterStatus! (enum)
        [JsonProperty("clusterStatus")]
        public ClusterStatus? ClusterStatus { get; set; }

        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode! (enum)
        [JsonProperty("registeredMode")]
        public ClusterRegistrationMode? RegisteredMode { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? MandatoryPrechecksMigrated
        // GraphQL -> mandatoryPrechecksMigrated: Boolean! (scalar)
        [JsonProperty("mandatoryPrechecksMigrated")]
        public System.Boolean? MandatoryPrechecksMigrated { get; set; }

        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        [JsonProperty("softwareVersion")]
        public System.String? SoftwareVersion { get; set; }

        //      C# -> System.Int32? TotalApplicablePrechecks
        // GraphQL -> totalApplicablePrechecks: Int! (scalar)
        [JsonProperty("totalApplicablePrechecks")]
        public System.Int32? TotalApplicablePrechecks { get; set; }

        //      C# -> System.Int32? TotalMigratedPrechecks
        // GraphQL -> totalMigratedPrechecks: Int! (scalar)
        [JsonProperty("totalMigratedPrechecks")]
        public System.Int32? TotalMigratedPrechecks { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MigrationMetadata";
    }

    public MigrationMetadata Set(
        ClusterStatus? ClusterStatus = null,
        ClusterRegistrationMode? RegisteredMode = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.Boolean? MandatoryPrechecksMigrated = null,
        System.String? SoftwareVersion = null,
        System.Int32? TotalApplicablePrechecks = null,
        System.Int32? TotalMigratedPrechecks = null
    ) 
    {
        if ( ClusterStatus != null ) {
            this.ClusterStatus = ClusterStatus;
        }
        if ( RegisteredMode != null ) {
            this.RegisteredMode = RegisteredMode;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( MandatoryPrechecksMigrated != null ) {
            this.MandatoryPrechecksMigrated = MandatoryPrechecksMigrated;
        }
        if ( SoftwareVersion != null ) {
            this.SoftwareVersion = SoftwareVersion;
        }
        if ( TotalApplicablePrechecks != null ) {
            this.TotalApplicablePrechecks = TotalApplicablePrechecks;
        }
        if ( TotalMigratedPrechecks != null ) {
            this.TotalMigratedPrechecks = TotalMigratedPrechecks;
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
        //      C# -> ClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ClusterStatus! (enum)
        if (this.ClusterStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterStatus\n" ;
            } else {
                s += ind + "clusterStatus\n" ;
            }
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode! (enum)
        if (this.RegisteredMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registeredMode\n" ;
            } else {
                s += ind + "registeredMode\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
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
        //      C# -> System.Boolean? MandatoryPrechecksMigrated
        // GraphQL -> mandatoryPrechecksMigrated: Boolean! (scalar)
        if (this.MandatoryPrechecksMigrated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mandatoryPrechecksMigrated\n" ;
            } else {
                s += ind + "mandatoryPrechecksMigrated\n" ;
            }
        }
        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        if (this.SoftwareVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "softwareVersion\n" ;
            } else {
                s += ind + "softwareVersion\n" ;
            }
        }
        //      C# -> System.Int32? TotalApplicablePrechecks
        // GraphQL -> totalApplicablePrechecks: Int! (scalar)
        if (this.TotalApplicablePrechecks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalApplicablePrechecks\n" ;
            } else {
                s += ind + "totalApplicablePrechecks\n" ;
            }
        }
        //      C# -> System.Int32? TotalMigratedPrechecks
        // GraphQL -> totalMigratedPrechecks: Int! (scalar)
        if (this.TotalMigratedPrechecks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalMigratedPrechecks\n" ;
            } else {
                s += ind + "totalMigratedPrechecks\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ClusterStatus! (enum)
        if (ec.Includes("clusterStatus",true))
        {
            if(this.ClusterStatus == null) {

                this.ClusterStatus = new ClusterStatus();

            } else {


            }
        }
        else if (this.ClusterStatus != null && ec.Excludes("clusterStatus",true))
        {
            this.ClusterStatus = null;
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode! (enum)
        if (ec.Includes("registeredMode",true))
        {
            if(this.RegisteredMode == null) {

                this.RegisteredMode = new ClusterRegistrationMode();

            } else {


            }
        }
        else if (this.RegisteredMode != null && ec.Excludes("registeredMode",true))
        {
            this.RegisteredMode = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
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
        //      C# -> System.Boolean? MandatoryPrechecksMigrated
        // GraphQL -> mandatoryPrechecksMigrated: Boolean! (scalar)
        if (ec.Includes("mandatoryPrechecksMigrated",true))
        {
            if(this.MandatoryPrechecksMigrated == null) {

                this.MandatoryPrechecksMigrated = true;

            } else {


            }
        }
        else if (this.MandatoryPrechecksMigrated != null && ec.Excludes("mandatoryPrechecksMigrated",true))
        {
            this.MandatoryPrechecksMigrated = null;
        }
        //      C# -> System.String? SoftwareVersion
        // GraphQL -> softwareVersion: String! (scalar)
        if (ec.Includes("softwareVersion",true))
        {
            if(this.SoftwareVersion == null) {

                this.SoftwareVersion = "FETCH";

            } else {


            }
        }
        else if (this.SoftwareVersion != null && ec.Excludes("softwareVersion",true))
        {
            this.SoftwareVersion = null;
        }
        //      C# -> System.Int32? TotalApplicablePrechecks
        // GraphQL -> totalApplicablePrechecks: Int! (scalar)
        if (ec.Includes("totalApplicablePrechecks",true))
        {
            if(this.TotalApplicablePrechecks == null) {

                this.TotalApplicablePrechecks = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalApplicablePrechecks != null && ec.Excludes("totalApplicablePrechecks",true))
        {
            this.TotalApplicablePrechecks = null;
        }
        //      C# -> System.Int32? TotalMigratedPrechecks
        // GraphQL -> totalMigratedPrechecks: Int! (scalar)
        if (ec.Includes("totalMigratedPrechecks",true))
        {
            if(this.TotalMigratedPrechecks == null) {

                this.TotalMigratedPrechecks = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalMigratedPrechecks != null && ec.Excludes("totalMigratedPrechecks",true))
        {
            this.TotalMigratedPrechecks = null;
        }
    }


    #endregion

    } // class MigrationMetadata
    
    #endregion

    public static class ListMigrationMetadataExtensions
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
            this List<MigrationMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MigrationMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MigrationMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MigrationMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MigrationMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types