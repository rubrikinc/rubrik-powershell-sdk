// UnaccessedSummaryPerSnappableType.cs
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
    #region UnaccessedSummaryPerSnappableType
    public class UnaccessedSummaryPerSnappableType: BaseType
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

        //      C# -> System.Int64? UnaccessedNonSensitiveObjectCount
        // GraphQL -> unaccessedNonSensitiveObjectCount: Long! (scalar)
        [JsonProperty("unaccessedNonSensitiveObjectCount")]
        public System.Int64? UnaccessedNonSensitiveObjectCount { get; set; }

        //      C# -> System.Int64? UnaccessedSensitiveObjectCount
        // GraphQL -> unaccessedSensitiveObjectCount: Long! (scalar)
        [JsonProperty("unaccessedSensitiveObjectCount")]
        public System.Int64? UnaccessedSensitiveObjectCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnaccessedSummaryPerSnappableType";
    }

    public UnaccessedSummaryPerSnappableType Set(
        ManagedObjectType? SnappableType = null,
        System.Int64? PendingScanObjectCount = null,
        System.Int64? UnaccessedNonSensitiveObjectCount = null,
        System.Int64? UnaccessedSensitiveObjectCount = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( PendingScanObjectCount != null ) {
            this.PendingScanObjectCount = PendingScanObjectCount;
        }
        if ( UnaccessedNonSensitiveObjectCount != null ) {
            this.UnaccessedNonSensitiveObjectCount = UnaccessedNonSensitiveObjectCount;
        }
        if ( UnaccessedSensitiveObjectCount != null ) {
            this.UnaccessedSensitiveObjectCount = UnaccessedSensitiveObjectCount;
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
        //      C# -> System.Int64? UnaccessedNonSensitiveObjectCount
        // GraphQL -> unaccessedNonSensitiveObjectCount: Long! (scalar)
        if (this.UnaccessedNonSensitiveObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unaccessedNonSensitiveObjectCount\n" ;
            } else {
                s += ind + "unaccessedNonSensitiveObjectCount\n" ;
            }
        }
        //      C# -> System.Int64? UnaccessedSensitiveObjectCount
        // GraphQL -> unaccessedSensitiveObjectCount: Long! (scalar)
        if (this.UnaccessedSensitiveObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unaccessedSensitiveObjectCount\n" ;
            } else {
                s += ind + "unaccessedSensitiveObjectCount\n" ;
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
        //      C# -> System.Int64? UnaccessedNonSensitiveObjectCount
        // GraphQL -> unaccessedNonSensitiveObjectCount: Long! (scalar)
        if (ec.Includes("unaccessedNonSensitiveObjectCount",true))
        {
            if(this.UnaccessedNonSensitiveObjectCount == null) {

                this.UnaccessedNonSensitiveObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.UnaccessedNonSensitiveObjectCount != null && ec.Excludes("unaccessedNonSensitiveObjectCount",true))
        {
            this.UnaccessedNonSensitiveObjectCount = null;
        }
        //      C# -> System.Int64? UnaccessedSensitiveObjectCount
        // GraphQL -> unaccessedSensitiveObjectCount: Long! (scalar)
        if (ec.Includes("unaccessedSensitiveObjectCount",true))
        {
            if(this.UnaccessedSensitiveObjectCount == null) {

                this.UnaccessedSensitiveObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.UnaccessedSensitiveObjectCount != null && ec.Excludes("unaccessedSensitiveObjectCount",true))
        {
            this.UnaccessedSensitiveObjectCount = null;
        }
    }


    #endregion

    } // class UnaccessedSummaryPerSnappableType
    
    #endregion

    public static class ListUnaccessedSummaryPerSnappableTypeExtensions
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
            this List<UnaccessedSummaryPerSnappableType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UnaccessedSummaryPerSnappableType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UnaccessedSummaryPerSnappableType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnaccessedSummaryPerSnappableType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnaccessedSummaryPerSnappableType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types