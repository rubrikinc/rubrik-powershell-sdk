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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ClusterStatus! (enum)
        if (this.ClusterStatus != null) {
            s += ind + "clusterStatus\n" ;
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode! (enum)
        if (this.RegisteredMode != null) {
            s += ind + "registeredMode\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Int32? TotalApplicablePrechecks
        // GraphQL -> totalApplicablePrechecks: Int! (scalar)
        if (this.TotalApplicablePrechecks != null) {
            s += ind + "totalApplicablePrechecks\n" ;
        }
        //      C# -> System.Int32? TotalMigratedPrechecks
        // GraphQL -> totalMigratedPrechecks: Int! (scalar)
        if (this.TotalMigratedPrechecks != null) {
            s += ind + "totalMigratedPrechecks\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterStatus? ClusterStatus
        // GraphQL -> clusterStatus: ClusterStatus! (enum)
        if (this.ClusterStatus == null && ec.Includes("clusterStatus",true))
        {
            this.ClusterStatus = new ClusterStatus();
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode! (enum)
        if (this.RegisteredMode == null && ec.Includes("registeredMode",true))
        {
            this.RegisteredMode = new ClusterRegistrationMode();
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && ec.Includes("clusterName",true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Int32? TotalApplicablePrechecks
        // GraphQL -> totalApplicablePrechecks: Int! (scalar)
        if (this.TotalApplicablePrechecks == null && ec.Includes("totalApplicablePrechecks",true))
        {
            this.TotalApplicablePrechecks = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalMigratedPrechecks
        // GraphQL -> totalMigratedPrechecks: Int! (scalar)
        if (this.TotalMigratedPrechecks == null && ec.Includes("totalMigratedPrechecks",true))
        {
            this.TotalMigratedPrechecks = Int32.MinValue;
        }
    }


    #endregion

    } // class MigrationMetadata
    
    #endregion

    public static class ListMigrationMetadataExtensions
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
            this List<MigrationMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<MigrationMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types