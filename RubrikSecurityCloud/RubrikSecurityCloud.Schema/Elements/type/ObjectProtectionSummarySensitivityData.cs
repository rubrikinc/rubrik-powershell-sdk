// ObjectProtectionSummarySensitivityData.cs
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
    #region ObjectProtectionSummarySensitivityData
    public class ObjectProtectionSummarySensitivityData: BaseType
    {
        #region members

        //      C# -> SnappableProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: SnappableProtectionStatus! (enum)
        [JsonProperty("protectionStatus")]
        public SnappableProtectionStatus? ProtectionStatus { get; set; }

        //      C# -> System.Int64? NonSensitiveObjectCount
        // GraphQL -> nonSensitiveObjectCount: Long! (scalar)
        [JsonProperty("nonSensitiveObjectCount")]
        public System.Int64? NonSensitiveObjectCount { get; set; }

        //      C# -> System.Int64? PendingScanObjectCount
        // GraphQL -> pendingScanObjectCount: Long! (scalar)
        [JsonProperty("pendingScanObjectCount")]
        public System.Int64? PendingScanObjectCount { get; set; }

        //      C# -> System.Int64? ScanNotEnabledObjectCount
        // GraphQL -> scanNotEnabledObjectCount: Long! (scalar)
        [JsonProperty("scanNotEnabledObjectCount")]
        public System.Int64? ScanNotEnabledObjectCount { get; set; }

        //      C# -> System.Int64? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: Long! (scalar)
        [JsonProperty("sensitiveObjectCount")]
        public System.Int64? SensitiveObjectCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectProtectionSummarySensitivityData";
    }

    public ObjectProtectionSummarySensitivityData Set(
        SnappableProtectionStatus? ProtectionStatus = null,
        System.Int64? NonSensitiveObjectCount = null,
        System.Int64? PendingScanObjectCount = null,
        System.Int64? ScanNotEnabledObjectCount = null,
        System.Int64? SensitiveObjectCount = null
    ) 
    {
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( NonSensitiveObjectCount != null ) {
            this.NonSensitiveObjectCount = NonSensitiveObjectCount;
        }
        if ( PendingScanObjectCount != null ) {
            this.PendingScanObjectCount = PendingScanObjectCount;
        }
        if ( ScanNotEnabledObjectCount != null ) {
            this.ScanNotEnabledObjectCount = ScanNotEnabledObjectCount;
        }
        if ( SensitiveObjectCount != null ) {
            this.SensitiveObjectCount = SensitiveObjectCount;
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
        //      C# -> SnappableProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: SnappableProtectionStatus! (enum)
        if (this.ProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionStatus\n" ;
            } else {
                s += ind + "protectionStatus\n" ;
            }
        }
        //      C# -> System.Int64? NonSensitiveObjectCount
        // GraphQL -> nonSensitiveObjectCount: Long! (scalar)
        if (this.NonSensitiveObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nonSensitiveObjectCount\n" ;
            } else {
                s += ind + "nonSensitiveObjectCount\n" ;
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
        //      C# -> System.Int64? ScanNotEnabledObjectCount
        // GraphQL -> scanNotEnabledObjectCount: Long! (scalar)
        if (this.ScanNotEnabledObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scanNotEnabledObjectCount\n" ;
            } else {
                s += ind + "scanNotEnabledObjectCount\n" ;
            }
        }
        //      C# -> System.Int64? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: Long! (scalar)
        if (this.SensitiveObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sensitiveObjectCount\n" ;
            } else {
                s += ind + "sensitiveObjectCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnappableProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: SnappableProtectionStatus! (enum)
        if (ec.Includes("protectionStatus",true))
        {
            if(this.ProtectionStatus == null) {

                this.ProtectionStatus = new SnappableProtectionStatus();

            } else {


            }
        }
        else if (this.ProtectionStatus != null && ec.Excludes("protectionStatus",true))
        {
            this.ProtectionStatus = null;
        }
        //      C# -> System.Int64? NonSensitiveObjectCount
        // GraphQL -> nonSensitiveObjectCount: Long! (scalar)
        if (ec.Includes("nonSensitiveObjectCount",true))
        {
            if(this.NonSensitiveObjectCount == null) {

                this.NonSensitiveObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.NonSensitiveObjectCount != null && ec.Excludes("nonSensitiveObjectCount",true))
        {
            this.NonSensitiveObjectCount = null;
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
        //      C# -> System.Int64? ScanNotEnabledObjectCount
        // GraphQL -> scanNotEnabledObjectCount: Long! (scalar)
        if (ec.Includes("scanNotEnabledObjectCount",true))
        {
            if(this.ScanNotEnabledObjectCount == null) {

                this.ScanNotEnabledObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.ScanNotEnabledObjectCount != null && ec.Excludes("scanNotEnabledObjectCount",true))
        {
            this.ScanNotEnabledObjectCount = null;
        }
        //      C# -> System.Int64? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: Long! (scalar)
        if (ec.Includes("sensitiveObjectCount",true))
        {
            if(this.SensitiveObjectCount == null) {

                this.SensitiveObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.SensitiveObjectCount != null && ec.Excludes("sensitiveObjectCount",true))
        {
            this.SensitiveObjectCount = null;
        }
    }


    #endregion

    } // class ObjectProtectionSummarySensitivityData
    
    #endregion

    public static class ListObjectProtectionSummarySensitivityDataExtensions
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
            this List<ObjectProtectionSummarySensitivityData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectProtectionSummarySensitivityData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectProtectionSummarySensitivityData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectProtectionSummarySensitivityData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectProtectionSummarySensitivityData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types