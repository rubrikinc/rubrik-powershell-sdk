// ArchivalTieringStatus.cs
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
    #region ArchivalTieringStatus
    public class ArchivalTieringStatus: BaseType
    {
        #region members

        //      C# -> SnapshotCloudStorageTier? CurrentTier
        // GraphQL -> currentTier: SnapshotCloudStorageTier! (enum)
        [JsonProperty("currentTier")]
        public SnapshotCloudStorageTier? CurrentTier { get; set; }

        //      C# -> System.Boolean? IsFullyTiered
        // GraphQL -> isFullyTiered: Boolean! (scalar)
        [JsonProperty("isFullyTiered")]
        public System.Boolean? IsFullyTiered { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> DateTime? RehydrationInitiatedAt
        // GraphQL -> rehydrationInitiatedAt: DateTime (scalar)
        [JsonProperty("rehydrationInitiatedAt")]
        public DateTime? RehydrationInitiatedAt { get; set; }

        //      C# -> System.Boolean? RehydrationNeeded
        // GraphQL -> rehydrationNeeded: Boolean! (scalar)
        [JsonProperty("rehydrationNeeded")]
        public System.Boolean? RehydrationNeeded { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalTieringStatus";
    }

    public ArchivalTieringStatus Set(
        SnapshotCloudStorageTier? CurrentTier = null,
        System.Boolean? IsFullyTiered = null,
        System.String? LocationId = null,
        DateTime? RehydrationInitiatedAt = null,
        System.Boolean? RehydrationNeeded = null
    ) 
    {
        if ( CurrentTier != null ) {
            this.CurrentTier = CurrentTier;
        }
        if ( IsFullyTiered != null ) {
            this.IsFullyTiered = IsFullyTiered;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( RehydrationInitiatedAt != null ) {
            this.RehydrationInitiatedAt = RehydrationInitiatedAt;
        }
        if ( RehydrationNeeded != null ) {
            this.RehydrationNeeded = RehydrationNeeded;
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
        //      C# -> SnapshotCloudStorageTier? CurrentTier
        // GraphQL -> currentTier: SnapshotCloudStorageTier! (enum)
        if (this.CurrentTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentTier\n" ;
            } else {
                s += ind + "currentTier\n" ;
            }
        }
        //      C# -> System.Boolean? IsFullyTiered
        // GraphQL -> isFullyTiered: Boolean! (scalar)
        if (this.IsFullyTiered != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFullyTiered\n" ;
            } else {
                s += ind + "isFullyTiered\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> DateTime? RehydrationInitiatedAt
        // GraphQL -> rehydrationInitiatedAt: DateTime (scalar)
        if (this.RehydrationInitiatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rehydrationInitiatedAt\n" ;
            } else {
                s += ind + "rehydrationInitiatedAt\n" ;
            }
        }
        //      C# -> System.Boolean? RehydrationNeeded
        // GraphQL -> rehydrationNeeded: Boolean! (scalar)
        if (this.RehydrationNeeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rehydrationNeeded\n" ;
            } else {
                s += ind + "rehydrationNeeded\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SnapshotCloudStorageTier? CurrentTier
        // GraphQL -> currentTier: SnapshotCloudStorageTier! (enum)
        if (ec.Includes("currentTier",true))
        {
            if(this.CurrentTier == null) {

                this.CurrentTier = new SnapshotCloudStorageTier();

            } else {


            }
        }
        else if (this.CurrentTier != null && ec.Excludes("currentTier",true))
        {
            this.CurrentTier = null;
        }
        //      C# -> System.Boolean? IsFullyTiered
        // GraphQL -> isFullyTiered: Boolean! (scalar)
        if (ec.Includes("isFullyTiered",true))
        {
            if(this.IsFullyTiered == null) {

                this.IsFullyTiered = true;

            } else {


            }
        }
        else if (this.IsFullyTiered != null && ec.Excludes("isFullyTiered",true))
        {
            this.IsFullyTiered = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> DateTime? RehydrationInitiatedAt
        // GraphQL -> rehydrationInitiatedAt: DateTime (scalar)
        if (ec.Includes("rehydrationInitiatedAt",true))
        {
            if(this.RehydrationInitiatedAt == null) {

                this.RehydrationInitiatedAt = new DateTime();

            } else {


            }
        }
        else if (this.RehydrationInitiatedAt != null && ec.Excludes("rehydrationInitiatedAt",true))
        {
            this.RehydrationInitiatedAt = null;
        }
        //      C# -> System.Boolean? RehydrationNeeded
        // GraphQL -> rehydrationNeeded: Boolean! (scalar)
        if (ec.Includes("rehydrationNeeded",true))
        {
            if(this.RehydrationNeeded == null) {

                this.RehydrationNeeded = true;

            } else {


            }
        }
        else if (this.RehydrationNeeded != null && ec.Excludes("rehydrationNeeded",true))
        {
            this.RehydrationNeeded = null;
        }
    }


    #endregion

    } // class ArchivalTieringStatus
    
    #endregion

    public static class ListArchivalTieringStatusExtensions
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
            this List<ArchivalTieringStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalTieringStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalTieringStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalTieringStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalTieringStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types