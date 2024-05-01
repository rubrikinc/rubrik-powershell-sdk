// ManagedObjectSlaInfo.cs
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
    #region ManagedObjectSlaInfo
    public class ManagedObjectSlaInfo: BaseType
    {
        #region members

        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignment? SlaAssignment { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        [JsonProperty("configuredSlaDomainName")]
        public System.String? ConfiguredSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainSourceId
        // GraphQL -> effectiveSlaDomainSourceId: String (scalar)
        [JsonProperty("effectiveSlaDomainSourceId")]
        public System.String? EffectiveSlaDomainSourceId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainSourceName
        // GraphQL -> effectiveSlaDomainSourceName: String (scalar)
        [JsonProperty("effectiveSlaDomainSourceName")]
        public System.String? EffectiveSlaDomainSourceName { get; set; }

        //      C# -> System.String? EffectiveSlaPolarisManagedId
        // GraphQL -> effectiveSlaPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaPolarisManagedId")]
        public System.String? EffectiveSlaPolarisManagedId { get; set; }

        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isEffectiveSlaDomainRetentionLocked")]
        public System.Boolean? IsEffectiveSlaDomainRetentionLocked { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedObjectSlaInfo";
    }

    public ManagedObjectSlaInfo Set(
        SlaAssignment? SlaAssignment = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaDomainName = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainSourceId = null,
        System.String? EffectiveSlaDomainSourceName = null,
        System.String? EffectiveSlaPolarisManagedId = null,
        System.Boolean? IsEffectiveSlaDomainRetentionLocked = null,
        System.String? ObjectId = null
    ) 
    {
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaDomainName != null ) {
            this.ConfiguredSlaDomainName = ConfiguredSlaDomainName;
        }
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainSourceId != null ) {
            this.EffectiveSlaDomainSourceId = EffectiveSlaDomainSourceId;
        }
        if ( EffectiveSlaDomainSourceName != null ) {
            this.EffectiveSlaDomainSourceName = EffectiveSlaDomainSourceName;
        }
        if ( EffectiveSlaPolarisManagedId != null ) {
            this.EffectiveSlaPolarisManagedId = EffectiveSlaPolarisManagedId;
        }
        if ( IsEffectiveSlaDomainRetentionLocked != null ) {
            this.IsEffectiveSlaDomainRetentionLocked = IsEffectiveSlaDomainRetentionLocked;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (this.ConfiguredSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainName\n" ;
            } else {
                s += ind + "configuredSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainId\n" ;
            } else {
                s += ind + "effectiveSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainName\n" ;
            } else {
                s += ind + "effectiveSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainSourceId
        // GraphQL -> effectiveSlaDomainSourceId: String (scalar)
        if (this.EffectiveSlaDomainSourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainSourceId\n" ;
            } else {
                s += ind + "effectiveSlaDomainSourceId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainSourceName
        // GraphQL -> effectiveSlaDomainSourceName: String (scalar)
        if (this.EffectiveSlaDomainSourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainSourceName\n" ;
            } else {
                s += ind + "effectiveSlaDomainSourceName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaPolarisManagedId
        // GraphQL -> effectiveSlaPolarisManagedId: String (scalar)
        if (this.EffectiveSlaPolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaPolarisManagedId\n" ;
            } else {
                s += ind + "effectiveSlaPolarisManagedId\n" ;
            }
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEffectiveSlaDomainRetentionLocked\n" ;
            } else {
                s += ind + "isEffectiveSlaDomainRetentionLocked\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment! (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignment();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (ec.Includes("configuredSlaDomainName",true))
        {
            if(this.ConfiguredSlaDomainName == null) {

                this.ConfiguredSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainName != null && ec.Excludes("configuredSlaDomainName",true))
        {
            this.ConfiguredSlaDomainName = null;
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (ec.Includes("effectiveSlaDomainId",true))
        {
            if(this.EffectiveSlaDomainId == null) {

                this.EffectiveSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainId != null && ec.Excludes("effectiveSlaDomainId",true))
        {
            this.EffectiveSlaDomainId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (ec.Includes("effectiveSlaDomainName",true))
        {
            if(this.EffectiveSlaDomainName == null) {

                this.EffectiveSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainName != null && ec.Excludes("effectiveSlaDomainName",true))
        {
            this.EffectiveSlaDomainName = null;
        }
        //      C# -> System.String? EffectiveSlaDomainSourceId
        // GraphQL -> effectiveSlaDomainSourceId: String (scalar)
        if (ec.Includes("effectiveSlaDomainSourceId",true))
        {
            if(this.EffectiveSlaDomainSourceId == null) {

                this.EffectiveSlaDomainSourceId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainSourceId != null && ec.Excludes("effectiveSlaDomainSourceId",true))
        {
            this.EffectiveSlaDomainSourceId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainSourceName
        // GraphQL -> effectiveSlaDomainSourceName: String (scalar)
        if (ec.Includes("effectiveSlaDomainSourceName",true))
        {
            if(this.EffectiveSlaDomainSourceName == null) {

                this.EffectiveSlaDomainSourceName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainSourceName != null && ec.Excludes("effectiveSlaDomainSourceName",true))
        {
            this.EffectiveSlaDomainSourceName = null;
        }
        //      C# -> System.String? EffectiveSlaPolarisManagedId
        // GraphQL -> effectiveSlaPolarisManagedId: String (scalar)
        if (ec.Includes("effectiveSlaPolarisManagedId",true))
        {
            if(this.EffectiveSlaPolarisManagedId == null) {

                this.EffectiveSlaPolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaPolarisManagedId != null && ec.Excludes("effectiveSlaPolarisManagedId",true))
        {
            this.EffectiveSlaPolarisManagedId = null;
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (ec.Includes("isEffectiveSlaDomainRetentionLocked",true))
        {
            if(this.IsEffectiveSlaDomainRetentionLocked == null) {

                this.IsEffectiveSlaDomainRetentionLocked = true;

            } else {


            }
        }
        else if (this.IsEffectiveSlaDomainRetentionLocked != null && ec.Excludes("isEffectiveSlaDomainRetentionLocked",true))
        {
            this.IsEffectiveSlaDomainRetentionLocked = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
    }


    #endregion

    } // class ManagedObjectSlaInfo
    
    #endregion

    public static class ListManagedObjectSlaInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ManagedObjectSlaInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedObjectSlaInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedObjectSlaInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedObjectSlaInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedObjectSlaInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types