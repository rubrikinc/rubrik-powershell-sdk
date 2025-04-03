// ManagedVolumeSnapshotStats.cs
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
    #region ManagedVolumeSnapshotStats
    public class ManagedVolumeSnapshotStats: BaseType
    {
        #region members

        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        [JsonProperty("logicalBytes")]
        public System.Int64? LogicalBytes { get; set; }

        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        [JsonProperty("physicalBytes")]
        public System.Int64? PhysicalBytes { get; set; }

        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        [JsonProperty("totalInodes")]
        public System.Int64? TotalInodes { get; set; }

        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        [JsonProperty("usedInodes")]
        public System.Int64? UsedInodes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSnapshotStats";
    }

    public ManagedVolumeSnapshotStats Set(
        System.Int64? LogicalBytes = null,
        System.Int64? PhysicalBytes = null,
        System.Int64? TotalInodes = null,
        System.Int64? UsedInodes = null
    ) 
    {
        if ( LogicalBytes != null ) {
            this.LogicalBytes = LogicalBytes;
        }
        if ( PhysicalBytes != null ) {
            this.PhysicalBytes = PhysicalBytes;
        }
        if ( TotalInodes != null ) {
            this.TotalInodes = TotalInodes;
        }
        if ( UsedInodes != null ) {
            this.UsedInodes = UsedInodes;
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
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (this.LogicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalBytes\n" ;
            } else {
                s += ind + "logicalBytes\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (this.PhysicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalBytes\n" ;
            } else {
                s += ind + "physicalBytes\n" ;
            }
        }
        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        if (this.TotalInodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalInodes\n" ;
            } else {
                s += ind + "totalInodes\n" ;
            }
        }
        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        if (this.UsedInodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedInodes\n" ;
            } else {
                s += ind + "usedInodes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (ec.Includes("logicalBytes",true))
        {
            if(this.LogicalBytes == null) {

                this.LogicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LogicalBytes != null && ec.Excludes("logicalBytes",true))
        {
            this.LogicalBytes = null;
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (ec.Includes("physicalBytes",true))
        {
            if(this.PhysicalBytes == null) {

                this.PhysicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalBytes != null && ec.Excludes("physicalBytes",true))
        {
            this.PhysicalBytes = null;
        }
        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        if (ec.Includes("totalInodes",true))
        {
            if(this.TotalInodes == null) {

                this.TotalInodes = new System.Int64();

            } else {


            }
        }
        else if (this.TotalInodes != null && ec.Excludes("totalInodes",true))
        {
            this.TotalInodes = null;
        }
        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        if (ec.Includes("usedInodes",true))
        {
            if(this.UsedInodes == null) {

                this.UsedInodes = new System.Int64();

            } else {


            }
        }
        else if (this.UsedInodes != null && ec.Excludes("usedInodes",true))
        {
            this.UsedInodes = null;
        }
    }


    #endregion

    } // class ManagedVolumeSnapshotStats
    
    #endregion

    public static class ListManagedVolumeSnapshotStatsExtensions
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
            this List<ManagedVolumeSnapshotStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeSnapshotStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSnapshotStats> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSnapshotStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSnapshotStats> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types