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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (this.ConfiguredSlaDomainName != null) {
            s += ind + "configuredSlaDomainName\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId != null) {
            s += ind + "effectiveSlaDomainId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName != null) {
            s += ind + "effectiveSlaDomainName\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainSourceId
        // GraphQL -> effectiveSlaDomainSourceId: String (scalar)
        if (this.EffectiveSlaDomainSourceId != null) {
            s += ind + "effectiveSlaDomainSourceId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainSourceName
        // GraphQL -> effectiveSlaDomainSourceName: String (scalar)
        if (this.EffectiveSlaDomainSourceName != null) {
            s += ind + "effectiveSlaDomainSourceName\n" ;
        }
        //      C# -> System.String? EffectiveSlaPolarisManagedId
        // GraphQL -> effectiveSlaPolarisManagedId: String (scalar)
        if (this.EffectiveSlaPolarisManagedId != null) {
            s += ind + "effectiveSlaPolarisManagedId\n" ;
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked != null) {
            s += ind + "isEffectiveSlaDomainRetentionLocked\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment! (enum)
        if (this.SlaAssignment == null && ec.Includes("slaAssignment",true))
        {
            this.SlaAssignment = new SlaAssignment();
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId == null && ec.Includes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> System.String? ConfiguredSlaDomainName
        // GraphQL -> configuredSlaDomainName: String! (scalar)
        if (this.ConfiguredSlaDomainName == null && ec.Includes("configuredSlaDomainName",true))
        {
            this.ConfiguredSlaDomainName = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId == null && ec.Includes("effectiveSlaDomainId",true))
        {
            this.EffectiveSlaDomainId = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName == null && ec.Includes("effectiveSlaDomainName",true))
        {
            this.EffectiveSlaDomainName = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainSourceId
        // GraphQL -> effectiveSlaDomainSourceId: String (scalar)
        if (this.EffectiveSlaDomainSourceId == null && ec.Includes("effectiveSlaDomainSourceId",true))
        {
            this.EffectiveSlaDomainSourceId = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainSourceName
        // GraphQL -> effectiveSlaDomainSourceName: String (scalar)
        if (this.EffectiveSlaDomainSourceName == null && ec.Includes("effectiveSlaDomainSourceName",true))
        {
            this.EffectiveSlaDomainSourceName = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaPolarisManagedId
        // GraphQL -> effectiveSlaPolarisManagedId: String (scalar)
        if (this.EffectiveSlaPolarisManagedId == null && ec.Includes("effectiveSlaPolarisManagedId",true))
        {
            this.EffectiveSlaPolarisManagedId = "FETCH";
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked == null && ec.Includes("isEffectiveSlaDomainRetentionLocked",true))
        {
            this.IsEffectiveSlaDomainRetentionLocked = true;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && ec.Includes("objectId",true))
        {
            this.ObjectId = "FETCH";
        }
    }


    #endregion

    } // class ManagedObjectSlaInfo
    
    #endregion

    public static class ListManagedObjectSlaInfoExtensions
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
            this List<ManagedObjectSlaInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<ManagedObjectSlaInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types