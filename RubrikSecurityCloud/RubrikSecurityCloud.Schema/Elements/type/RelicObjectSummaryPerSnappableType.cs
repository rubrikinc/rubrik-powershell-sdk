// RelicObjectSummaryPerSnappableType.cs
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
    #region RelicObjectSummaryPerSnappableType
    public class RelicObjectSummaryPerSnappableType: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        [JsonProperty("snappableType")]
        public ManagedObjectType? SnappableType { get; set; }

        //      C# -> System.Int64? PendingScanObjectCount
        // GraphQL -> pendingScanObjectCount: Long! (scalar)
        [JsonProperty("pendingScanObjectCount")]
        public System.Int64? PendingScanObjectCount { get; set; }

        //      C# -> System.Int64? RelicNonSensitiveObjectCount
        // GraphQL -> relicNonSensitiveObjectCount: Long! (scalar)
        [JsonProperty("relicNonSensitiveObjectCount")]
        public System.Int64? RelicNonSensitiveObjectCount { get; set; }

        //      C# -> System.Int64? RelicSensitiveObjectCount
        // GraphQL -> relicSensitiveObjectCount: Long! (scalar)
        [JsonProperty("relicSensitiveObjectCount")]
        public System.Int64? RelicSensitiveObjectCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RelicObjectSummaryPerSnappableType";
    }

    public RelicObjectSummaryPerSnappableType Set(
        ManagedObjectType? SnappableType = null,
        System.Int64? PendingScanObjectCount = null,
        System.Int64? RelicNonSensitiveObjectCount = null,
        System.Int64? RelicSensitiveObjectCount = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( PendingScanObjectCount != null ) {
            this.PendingScanObjectCount = PendingScanObjectCount;
        }
        if ( RelicNonSensitiveObjectCount != null ) {
            this.RelicNonSensitiveObjectCount = RelicNonSensitiveObjectCount;
        }
        if ( RelicSensitiveObjectCount != null ) {
            this.RelicSensitiveObjectCount = RelicSensitiveObjectCount;
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
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> System.Int64? PendingScanObjectCount
        // GraphQL -> pendingScanObjectCount: Long! (scalar)
        if (this.PendingScanObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingScanObjectCount\n" ;
            } else {
                s += ind + "pendingScanObjectCount\n" ;
            }
        }
        //      C# -> System.Int64? RelicNonSensitiveObjectCount
        // GraphQL -> relicNonSensitiveObjectCount: Long! (scalar)
        if (this.RelicNonSensitiveObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relicNonSensitiveObjectCount\n" ;
            } else {
                s += ind + "relicNonSensitiveObjectCount\n" ;
            }
        }
        //      C# -> System.Int64? RelicSensitiveObjectCount
        // GraphQL -> relicSensitiveObjectCount: Long! (scalar)
        if (this.RelicSensitiveObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relicSensitiveObjectCount\n" ;
            } else {
                s += ind + "relicSensitiveObjectCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> System.Int64? PendingScanObjectCount
        // GraphQL -> pendingScanObjectCount: Long! (scalar)
        if (ec.Includes("pendingScanObjectCount",true))
        {
            if(this.PendingScanObjectCount == null) {

                this.PendingScanObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.PendingScanObjectCount != null && ec.Excludes("pendingScanObjectCount",true))
        {
            this.PendingScanObjectCount = null;
        }
        //      C# -> System.Int64? RelicNonSensitiveObjectCount
        // GraphQL -> relicNonSensitiveObjectCount: Long! (scalar)
        if (ec.Includes("relicNonSensitiveObjectCount",true))
        {
            if(this.RelicNonSensitiveObjectCount == null) {

                this.RelicNonSensitiveObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.RelicNonSensitiveObjectCount != null && ec.Excludes("relicNonSensitiveObjectCount",true))
        {
            this.RelicNonSensitiveObjectCount = null;
        }
        //      C# -> System.Int64? RelicSensitiveObjectCount
        // GraphQL -> relicSensitiveObjectCount: Long! (scalar)
        if (ec.Includes("relicSensitiveObjectCount",true))
        {
            if(this.RelicSensitiveObjectCount == null) {

                this.RelicSensitiveObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.RelicSensitiveObjectCount != null && ec.Excludes("relicSensitiveObjectCount",true))
        {
            this.RelicSensitiveObjectCount = null;
        }
    }


    #endregion

    } // class RelicObjectSummaryPerSnappableType
    
    #endregion

    public static class ListRelicObjectSummaryPerSnappableTypeExtensions
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
            this List<RelicObjectSummaryPerSnappableType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RelicObjectSummaryPerSnappableType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RelicObjectSummaryPerSnappableType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RelicObjectSummaryPerSnappableType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RelicObjectSummaryPerSnappableType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types