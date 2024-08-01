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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CreateSnapMirrorCloudReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainId\n" ;
            } else {
                s += ind + "effectiveSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainName\n" ;
            } else {
                s += ind + "effectiveSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainPolarisManagedId\n" ;
            } else {
                s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
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
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.String? NasNamespaceId
        // GraphQL -> nasNamespaceId: String! (scalar)
        if (this.NasNamespaceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasNamespaceId\n" ;
            } else {
                s += ind + "nasNamespaceId\n" ;
            }
        }
        //      C# -> System.String? NasNamespaceName
        // GraphQL -> nasNamespaceName: String! (scalar)
        if (this.NasNamespaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasNamespaceName\n" ;
            } else {
                s += ind + "nasNamespaceName\n" ;
            }
        }
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        if (this.NasSystemId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasSystemId\n" ;
            } else {
                s += ind + "nasSystemId\n" ;
            }
        }
        //      C# -> System.String? NasSystemName
        // GraphQL -> nasSystemName: String! (scalar)
        if (this.NasSystemName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasSystemName\n" ;
            } else {
                s += ind + "nasSystemName\n" ;
            }
        }
        //      C# -> System.String? NasVolumeId
        // GraphQL -> nasVolumeId: String! (scalar)
        if (this.NasVolumeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasVolumeId\n" ;
            } else {
                s += ind + "nasVolumeId\n" ;
            }
        }
        //      C# -> System.String? NasVolumeName
        // GraphQL -> nasVolumeName: String! (scalar)
        if (this.NasVolumeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasVolumeName\n" ;
            } else {
                s += ind + "nasVolumeName\n" ;
            }
        }
        //      C# -> System.String? RelationshipUuid
        // GraphQL -> relationshipUuid: String (scalar)
        if (this.RelationshipUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relationshipUuid\n" ;
            } else {
                s += ind + "relationshipUuid\n" ;
            }
        }
        //      C# -> System.String? SnapMirrorLabel
        // GraphQL -> snapMirrorLabel: String (scalar)
        if (this.SnapMirrorLabel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapMirrorLabel\n" ;
            } else {
                s += ind + "snapMirrorLabel\n" ;
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
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
        // GraphQL -> effectiveSlaDomainName: String (scalar)
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
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (ec.Includes("effectiveSlaDomainPolarisManagedId",true))
        {
            if(this.EffectiveSlaDomainPolarisManagedId == null) {

                this.EffectiveSlaDomainPolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainPolarisManagedId != null && ec.Excludes("effectiveSlaDomainPolarisManagedId",true))
        {
            this.EffectiveSlaDomainPolarisManagedId = null;
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
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.String? NasNamespaceId
        // GraphQL -> nasNamespaceId: String! (scalar)
        if (ec.Includes("nasNamespaceId",true))
        {
            if(this.NasNamespaceId == null) {

                this.NasNamespaceId = "FETCH";

            } else {


            }
        }
        else if (this.NasNamespaceId != null && ec.Excludes("nasNamespaceId",true))
        {
            this.NasNamespaceId = null;
        }
        //      C# -> System.String? NasNamespaceName
        // GraphQL -> nasNamespaceName: String! (scalar)
        if (ec.Includes("nasNamespaceName",true))
        {
            if(this.NasNamespaceName == null) {

                this.NasNamespaceName = "FETCH";

            } else {


            }
        }
        else if (this.NasNamespaceName != null && ec.Excludes("nasNamespaceName",true))
        {
            this.NasNamespaceName = null;
        }
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        if (ec.Includes("nasSystemId",true))
        {
            if(this.NasSystemId == null) {

                this.NasSystemId = "FETCH";

            } else {


            }
        }
        else if (this.NasSystemId != null && ec.Excludes("nasSystemId",true))
        {
            this.NasSystemId = null;
        }
        //      C# -> System.String? NasSystemName
        // GraphQL -> nasSystemName: String! (scalar)
        if (ec.Includes("nasSystemName",true))
        {
            if(this.NasSystemName == null) {

                this.NasSystemName = "FETCH";

            } else {


            }
        }
        else if (this.NasSystemName != null && ec.Excludes("nasSystemName",true))
        {
            this.NasSystemName = null;
        }
        //      C# -> System.String? NasVolumeId
        // GraphQL -> nasVolumeId: String! (scalar)
        if (ec.Includes("nasVolumeId",true))
        {
            if(this.NasVolumeId == null) {

                this.NasVolumeId = "FETCH";

            } else {


            }
        }
        else if (this.NasVolumeId != null && ec.Excludes("nasVolumeId",true))
        {
            this.NasVolumeId = null;
        }
        //      C# -> System.String? NasVolumeName
        // GraphQL -> nasVolumeName: String! (scalar)
        if (ec.Includes("nasVolumeName",true))
        {
            if(this.NasVolumeName == null) {

                this.NasVolumeName = "FETCH";

            } else {


            }
        }
        else if (this.NasVolumeName != null && ec.Excludes("nasVolumeName",true))
        {
            this.NasVolumeName = null;
        }
        //      C# -> System.String? RelationshipUuid
        // GraphQL -> relationshipUuid: String (scalar)
        if (ec.Includes("relationshipUuid",true))
        {
            if(this.RelationshipUuid == null) {

                this.RelationshipUuid = "FETCH";

            } else {


            }
        }
        else if (this.RelationshipUuid != null && ec.Excludes("relationshipUuid",true))
        {
            this.RelationshipUuid = null;
        }
        //      C# -> System.String? SnapMirrorLabel
        // GraphQL -> snapMirrorLabel: String (scalar)
        if (ec.Includes("snapMirrorLabel",true))
        {
            if(this.SnapMirrorLabel == null) {

                this.SnapMirrorLabel = "FETCH";

            } else {


            }
        }
        else if (this.SnapMirrorLabel != null && ec.Excludes("snapMirrorLabel",true))
        {
            this.SnapMirrorLabel = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class CreateSnapMirrorCloudReply
    
    #endregion

    public static class ListCreateSnapMirrorCloudReplyExtensions
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
            this List<CreateSnapMirrorCloudReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateSnapMirrorCloudReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateSnapMirrorCloudReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateSnapMirrorCloudReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateSnapMirrorCloudReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types