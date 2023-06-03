// CreateSnapMirrorCloudReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateSnapMirrorCloudReply
    public class CreateSnapMirrorCloudReply: BaseType
    {
        #region members

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaDomainPolarisManagedId")]
        public System.String? EffectiveSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isEffectiveSlaDomainRetentionLocked")]
        public System.Boolean? IsEffectiveSlaDomainRetentionLocked { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? NasNamespaceId
        // GraphQL -> nasNamespaceId: String! (scalar)
        [JsonProperty("nasNamespaceId")]
        public System.String? NasNamespaceId { get; set; }

        //      C# -> System.String? NasNamespaceName
        // GraphQL -> nasNamespaceName: String! (scalar)
        [JsonProperty("nasNamespaceName")]
        public System.String? NasNamespaceName { get; set; }

        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        [JsonProperty("nasSystemId")]
        public System.String? NasSystemId { get; set; }

        //      C# -> System.String? NasSystemName
        // GraphQL -> nasSystemName: String! (scalar)
        [JsonProperty("nasSystemName")]
        public System.String? NasSystemName { get; set; }

        //      C# -> System.String? NasVolumeId
        // GraphQL -> nasVolumeId: String! (scalar)
        [JsonProperty("nasVolumeId")]
        public System.String? NasVolumeId { get; set; }

        //      C# -> System.String? NasVolumeName
        // GraphQL -> nasVolumeName: String! (scalar)
        [JsonProperty("nasVolumeName")]
        public System.String? NasVolumeName { get; set; }

        //      C# -> System.String? RelationshipUuid
        // GraphQL -> relationshipUuid: String (scalar)
        [JsonProperty("relationshipUuid")]
        public System.String? RelationshipUuid { get; set; }

        //      C# -> System.String? SnapMirrorLabel
        // GraphQL -> snapMirrorLabel: String (scalar)
        [JsonProperty("snapMirrorLabel")]
        public System.String? SnapMirrorLabel { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public CreateSnapMirrorCloudReply Set(
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.Boolean? IsEffectiveSlaDomainRetentionLocked = null,
        System.Boolean? IsRelic = null,
        System.String? NasNamespaceId = null,
        System.String? NasNamespaceName = null,
        System.String? NasSystemId = null,
        System.String? NasSystemName = null,
        System.String? NasVolumeId = null,
        System.String? NasVolumeName = null,
        System.String? RelationshipUuid = null,
        System.String? SnapMirrorLabel = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( IsEffectiveSlaDomainRetentionLocked != null ) {
            this.IsEffectiveSlaDomainRetentionLocked = IsEffectiveSlaDomainRetentionLocked;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( NasNamespaceId != null ) {
            this.NasNamespaceId = NasNamespaceId;
        }
        if ( NasNamespaceName != null ) {
            this.NasNamespaceName = NasNamespaceName;
        }
        if ( NasSystemId != null ) {
            this.NasSystemId = NasSystemId;
        }
        if ( NasSystemName != null ) {
            this.NasSystemName = NasSystemName;
        }
        if ( NasVolumeId != null ) {
            this.NasVolumeId = NasVolumeId;
        }
        if ( NasVolumeName != null ) {
            this.NasVolumeName = NasVolumeName;
        }
        if ( RelationshipUuid != null ) {
            this.RelationshipUuid = RelationshipUuid;
        }
        if ( SnapMirrorLabel != null ) {
            this.SnapMirrorLabel = SnapMirrorLabel;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            s += ind + "effectiveSlaDomainId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName != null) {
            s += ind + "effectiveSlaDomainName\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked != null) {
            s += ind + "isEffectiveSlaDomainRetentionLocked\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? NasNamespaceId
        // GraphQL -> nasNamespaceId: String! (scalar)
        if (this.NasNamespaceId != null) {
            s += ind + "nasNamespaceId\n" ;
        }
        //      C# -> System.String? NasNamespaceName
        // GraphQL -> nasNamespaceName: String! (scalar)
        if (this.NasNamespaceName != null) {
            s += ind + "nasNamespaceName\n" ;
        }
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        if (this.NasSystemId != null) {
            s += ind + "nasSystemId\n" ;
        }
        //      C# -> System.String? NasSystemName
        // GraphQL -> nasSystemName: String! (scalar)
        if (this.NasSystemName != null) {
            s += ind + "nasSystemName\n" ;
        }
        //      C# -> System.String? NasVolumeId
        // GraphQL -> nasVolumeId: String! (scalar)
        if (this.NasVolumeId != null) {
            s += ind + "nasVolumeId\n" ;
        }
        //      C# -> System.String? NasVolumeName
        // GraphQL -> nasVolumeName: String! (scalar)
        if (this.NasVolumeName != null) {
            s += ind + "nasVolumeName\n" ;
        }
        //      C# -> System.String? RelationshipUuid
        // GraphQL -> relationshipUuid: String (scalar)
        if (this.RelationshipUuid != null) {
            s += ind + "relationshipUuid\n" ;
        }
        //      C# -> System.String? SnapMirrorLabel
        // GraphQL -> snapMirrorLabel: String (scalar)
        if (this.SnapMirrorLabel != null) {
            s += ind + "snapMirrorLabel\n" ;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            s += ind + "slaAssignable {\n" + this.SlaAssignable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId", true))
        {
            this.EffectiveSlaDomainId = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName == null && Exploration.Includes(parent + ".effectiveSlaDomainName", true))
        {
            this.EffectiveSlaDomainName = new System.String("FETCH");
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".effectiveSlaDomainPolarisManagedId", true))
        {
            this.EffectiveSlaDomainPolarisManagedId = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isEffectiveSlaDomainRetentionLocked", true))
        {
            this.IsEffectiveSlaDomainRetentionLocked = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? NasNamespaceId
        // GraphQL -> nasNamespaceId: String! (scalar)
        if (this.NasNamespaceId == null && Exploration.Includes(parent + ".nasNamespaceId", true))
        {
            this.NasNamespaceId = new System.String("FETCH");
        }
        //      C# -> System.String? NasNamespaceName
        // GraphQL -> nasNamespaceName: String! (scalar)
        if (this.NasNamespaceName == null && Exploration.Includes(parent + ".nasNamespaceName", true))
        {
            this.NasNamespaceName = new System.String("FETCH");
        }
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        if (this.NasSystemId == null && Exploration.Includes(parent + ".nasSystemId", true))
        {
            this.NasSystemId = new System.String("FETCH");
        }
        //      C# -> System.String? NasSystemName
        // GraphQL -> nasSystemName: String! (scalar)
        if (this.NasSystemName == null && Exploration.Includes(parent + ".nasSystemName", true))
        {
            this.NasSystemName = new System.String("FETCH");
        }
        //      C# -> System.String? NasVolumeId
        // GraphQL -> nasVolumeId: String! (scalar)
        if (this.NasVolumeId == null && Exploration.Includes(parent + ".nasVolumeId", true))
        {
            this.NasVolumeId = new System.String("FETCH");
        }
        //      C# -> System.String? NasVolumeName
        // GraphQL -> nasVolumeName: String! (scalar)
        if (this.NasVolumeName == null && Exploration.Includes(parent + ".nasVolumeName", true))
        {
            this.NasVolumeName = new System.String("FETCH");
        }
        //      C# -> System.String? RelationshipUuid
        // GraphQL -> relationshipUuid: String (scalar)
        if (this.RelationshipUuid == null && Exploration.Includes(parent + ".relationshipUuid", true))
        {
            this.RelationshipUuid = new System.String("FETCH");
        }
        //      C# -> System.String? SnapMirrorLabel
        // GraphQL -> snapMirrorLabel: String (scalar)
        if (this.SnapMirrorLabel == null && Exploration.Includes(parent + ".snapMirrorLabel", true))
        {
            this.SnapMirrorLabel = new System.String("FETCH");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class CreateSnapMirrorCloudReply
    
    #endregion

    public static class ListCreateSnapMirrorCloudReplyExtensions
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
            this List<CreateSnapMirrorCloudReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateSnapMirrorCloudReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateSnapMirrorCloudReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types