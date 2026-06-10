// IdentityEventMetadata.cs
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
    #region IdentityEventMetadata
 
    public class IdentityEventMetadata: BaseType, ResourceMetadataUnion
    {
        #region members

        //      C# -> ViolationPrincipalType? ActorIdentityType
        // GraphQL -> actorIdentityType: ViolationPrincipalType! (enum)
        [JsonProperty("actorIdentityType")]
        public ViolationPrincipalType? ActorIdentityType { get; set; }

        //      C# -> PrivilegeType? ActorPrivilegeType
        // GraphQL -> actorPrivilegeType: PrivilegeType! (enum)
        [JsonProperty("actorPrivilegeType")]
        public PrivilegeType? ActorPrivilegeType { get; set; }

        //      C# -> IdentityEventActorIdentificationState? ActorState
        // GraphQL -> actorState: IdentityEventActorIdentificationState! (enum)
        [JsonProperty("actorState")]
        public IdentityEventActorIdentificationState? ActorState { get; set; }

        //      C# -> IdentityAlertEventType? EventType
        // GraphQL -> eventType: IdentityAlertEventType! (enum)
        [JsonProperty("eventType")]
        public IdentityAlertEventType? EventType { get; set; }

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> IdentityStatus? SourceIdentityStatus
        // GraphQL -> sourceIdentityStatus: IdentityStatus! (enum)
        [JsonProperty("sourceIdentityStatus")]
        public IdentityStatus? SourceIdentityStatus { get; set; }

        //      C# -> ViolationPrincipalType? SourceIdentityType
        // GraphQL -> sourceIdentityType: ViolationPrincipalType! (enum)
        [JsonProperty("sourceIdentityType")]
        public ViolationPrincipalType? SourceIdentityType { get; set; }

        //      C# -> PrivilegeType? SourcePrivilegeType
        // GraphQL -> sourcePrivilegeType: PrivilegeType! (enum)
        [JsonProperty("sourcePrivilegeType")]
        public PrivilegeType? SourcePrivilegeType { get; set; }

        //      C# -> IdentityStatus? TargetIdentityStatus
        // GraphQL -> targetIdentityStatus: IdentityStatus! (enum)
        [JsonProperty("targetIdentityStatus")]
        public IdentityStatus? TargetIdentityStatus { get; set; }

        //      C# -> ViolationPrincipalType? TargetIdentityType
        // GraphQL -> targetIdentityType: ViolationPrincipalType! (enum)
        [JsonProperty("targetIdentityType")]
        public ViolationPrincipalType? TargetIdentityType { get; set; }

        //      C# -> PrivilegeType? TargetPrivilegeType
        // GraphQL -> targetPrivilegeType: PrivilegeType! (enum)
        [JsonProperty("targetPrivilegeType")]
        public PrivilegeType? TargetPrivilegeType { get; set; }

        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        [JsonProperty("actorIdentityId")]
        public System.String? ActorIdentityId { get; set; }

        //      C# -> System.String? ActorIdentityName
        // GraphQL -> actorIdentityName: String! (scalar)
        [JsonProperty("actorIdentityName")]
        public System.String? ActorIdentityName { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        [JsonProperty("entityName")]
        public System.String? EntityName { get; set; }

        //      C# -> DateTime? EventTime
        // GraphQL -> eventTime: DateTime (scalar)
        [JsonProperty("eventTime")]
        public DateTime? EventTime { get; set; }

        //      C# -> System.String? SourceIdentityEntityId
        // GraphQL -> sourceIdentityEntityId: String! (scalar)
        [JsonProperty("sourceIdentityEntityId")]
        public System.String? SourceIdentityEntityId { get; set; }

        //      C# -> System.String? SourceIdentityEntityName
        // GraphQL -> sourceIdentityEntityName: String! (scalar)
        [JsonProperty("sourceIdentityEntityName")]
        public System.String? SourceIdentityEntityName { get; set; }

        //      C# -> System.String? SourceIdentityId
        // GraphQL -> sourceIdentityId: String! (scalar)
        [JsonProperty("sourceIdentityId")]
        public System.String? SourceIdentityId { get; set; }

        //      C# -> System.String? SourceIdentityName
        // GraphQL -> sourceIdentityName: String! (scalar)
        [JsonProperty("sourceIdentityName")]
        public System.String? SourceIdentityName { get; set; }

        //      C# -> System.String? SourceIdentityUniqueIdentifier
        // GraphQL -> sourceIdentityUniqueIdentifier: String! (scalar)
        [JsonProperty("sourceIdentityUniqueIdentifier")]
        public System.String? SourceIdentityUniqueIdentifier { get; set; }

        //      C# -> System.String? TargetIdentityName
        // GraphQL -> targetIdentityName: String! (scalar)
        [JsonProperty("targetIdentityName")]
        public System.String? TargetIdentityName { get; set; }

        //      C# -> System.String? TargetIdentitySource
        // GraphQL -> targetIdentitySource: String! (scalar)
        [JsonProperty("targetIdentitySource")]
        public System.String? TargetIdentitySource { get; set; }

        //      C# -> System.String? TargetIdentityUniqueIdentifier
        // GraphQL -> targetIdentityUniqueIdentifier: String! (scalar)
        [JsonProperty("targetIdentityUniqueIdentifier")]
        public System.String? TargetIdentityUniqueIdentifier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityEventMetadata";
    }

    public IdentityEventMetadata Set(
        ViolationPrincipalType? ActorIdentityType = null,
        PrivilegeType? ActorPrivilegeType = null,
        IdentityEventActorIdentificationState? ActorState = null,
        IdentityAlertEventType? EventType = null,
        IdpType? IdpType = null,
        IdentityStatus? SourceIdentityStatus = null,
        ViolationPrincipalType? SourceIdentityType = null,
        PrivilegeType? SourcePrivilegeType = null,
        IdentityStatus? TargetIdentityStatus = null,
        ViolationPrincipalType? TargetIdentityType = null,
        PrivilegeType? TargetPrivilegeType = null,
        System.String? ActorIdentityId = null,
        System.String? ActorIdentityName = null,
        System.String? EntityId = null,
        System.String? EntityName = null,
        DateTime? EventTime = null,
        System.String? SourceIdentityEntityId = null,
        System.String? SourceIdentityEntityName = null,
        System.String? SourceIdentityId = null,
        System.String? SourceIdentityName = null,
        System.String? SourceIdentityUniqueIdentifier = null,
        System.String? TargetIdentityName = null,
        System.String? TargetIdentitySource = null,
        System.String? TargetIdentityUniqueIdentifier = null
    ) 
    {
        if ( ActorIdentityType != null ) {
            this.ActorIdentityType = ActorIdentityType;
        }
        if ( ActorPrivilegeType != null ) {
            this.ActorPrivilegeType = ActorPrivilegeType;
        }
        if ( ActorState != null ) {
            this.ActorState = ActorState;
        }
        if ( EventType != null ) {
            this.EventType = EventType;
        }
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( SourceIdentityStatus != null ) {
            this.SourceIdentityStatus = SourceIdentityStatus;
        }
        if ( SourceIdentityType != null ) {
            this.SourceIdentityType = SourceIdentityType;
        }
        if ( SourcePrivilegeType != null ) {
            this.SourcePrivilegeType = SourcePrivilegeType;
        }
        if ( TargetIdentityStatus != null ) {
            this.TargetIdentityStatus = TargetIdentityStatus;
        }
        if ( TargetIdentityType != null ) {
            this.TargetIdentityType = TargetIdentityType;
        }
        if ( TargetPrivilegeType != null ) {
            this.TargetPrivilegeType = TargetPrivilegeType;
        }
        if ( ActorIdentityId != null ) {
            this.ActorIdentityId = ActorIdentityId;
        }
        if ( ActorIdentityName != null ) {
            this.ActorIdentityName = ActorIdentityName;
        }
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( EntityName != null ) {
            this.EntityName = EntityName;
        }
        if ( EventTime != null ) {
            this.EventTime = EventTime;
        }
        if ( SourceIdentityEntityId != null ) {
            this.SourceIdentityEntityId = SourceIdentityEntityId;
        }
        if ( SourceIdentityEntityName != null ) {
            this.SourceIdentityEntityName = SourceIdentityEntityName;
        }
        if ( SourceIdentityId != null ) {
            this.SourceIdentityId = SourceIdentityId;
        }
        if ( SourceIdentityName != null ) {
            this.SourceIdentityName = SourceIdentityName;
        }
        if ( SourceIdentityUniqueIdentifier != null ) {
            this.SourceIdentityUniqueIdentifier = SourceIdentityUniqueIdentifier;
        }
        if ( TargetIdentityName != null ) {
            this.TargetIdentityName = TargetIdentityName;
        }
        if ( TargetIdentitySource != null ) {
            this.TargetIdentitySource = TargetIdentitySource;
        }
        if ( TargetIdentityUniqueIdentifier != null ) {
            this.TargetIdentityUniqueIdentifier = TargetIdentityUniqueIdentifier;
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
        //      C# -> ViolationPrincipalType? ActorIdentityType
        // GraphQL -> actorIdentityType: ViolationPrincipalType! (enum)
        if (this.ActorIdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityType\n" ;
            } else {
                s += ind + "actorIdentityType\n" ;
            }
        }
        //      C# -> PrivilegeType? ActorPrivilegeType
        // GraphQL -> actorPrivilegeType: PrivilegeType! (enum)
        if (this.ActorPrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorPrivilegeType\n" ;
            } else {
                s += ind + "actorPrivilegeType\n" ;
            }
        }
        //      C# -> IdentityEventActorIdentificationState? ActorState
        // GraphQL -> actorState: IdentityEventActorIdentificationState! (enum)
        if (this.ActorState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorState\n" ;
            } else {
                s += ind + "actorState\n" ;
            }
        }
        //      C# -> IdentityAlertEventType? EventType
        // GraphQL -> eventType: IdentityAlertEventType! (enum)
        if (this.EventType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventType\n" ;
            } else {
                s += ind + "eventType\n" ;
            }
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> IdentityStatus? SourceIdentityStatus
        // GraphQL -> sourceIdentityStatus: IdentityStatus! (enum)
        if (this.SourceIdentityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityStatus\n" ;
            } else {
                s += ind + "sourceIdentityStatus\n" ;
            }
        }
        //      C# -> ViolationPrincipalType? SourceIdentityType
        // GraphQL -> sourceIdentityType: ViolationPrincipalType! (enum)
        if (this.SourceIdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityType\n" ;
            } else {
                s += ind + "sourceIdentityType\n" ;
            }
        }
        //      C# -> PrivilegeType? SourcePrivilegeType
        // GraphQL -> sourcePrivilegeType: PrivilegeType! (enum)
        if (this.SourcePrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourcePrivilegeType\n" ;
            } else {
                s += ind + "sourcePrivilegeType\n" ;
            }
        }
        //      C# -> IdentityStatus? TargetIdentityStatus
        // GraphQL -> targetIdentityStatus: IdentityStatus! (enum)
        if (this.TargetIdentityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityStatus\n" ;
            } else {
                s += ind + "targetIdentityStatus\n" ;
            }
        }
        //      C# -> ViolationPrincipalType? TargetIdentityType
        // GraphQL -> targetIdentityType: ViolationPrincipalType! (enum)
        if (this.TargetIdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityType\n" ;
            } else {
                s += ind + "targetIdentityType\n" ;
            }
        }
        //      C# -> PrivilegeType? TargetPrivilegeType
        // GraphQL -> targetPrivilegeType: PrivilegeType! (enum)
        if (this.TargetPrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetPrivilegeType\n" ;
            } else {
                s += ind + "targetPrivilegeType\n" ;
            }
        }
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (this.ActorIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityId\n" ;
            } else {
                s += ind + "actorIdentityId\n" ;
            }
        }
        //      C# -> System.String? ActorIdentityName
        // GraphQL -> actorIdentityName: String! (scalar)
        if (this.ActorIdentityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityName\n" ;
            } else {
                s += ind + "actorIdentityName\n" ;
            }
        }
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (this.EntityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityId\n" ;
            } else {
                s += ind + "entityId\n" ;
            }
        }
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (this.EntityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityName\n" ;
            } else {
                s += ind + "entityName\n" ;
            }
        }
        //      C# -> DateTime? EventTime
        // GraphQL -> eventTime: DateTime (scalar)
        if (this.EventTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTime\n" ;
            } else {
                s += ind + "eventTime\n" ;
            }
        }
        //      C# -> System.String? SourceIdentityEntityId
        // GraphQL -> sourceIdentityEntityId: String! (scalar)
        if (this.SourceIdentityEntityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityEntityId\n" ;
            } else {
                s += ind + "sourceIdentityEntityId\n" ;
            }
        }
        //      C# -> System.String? SourceIdentityEntityName
        // GraphQL -> sourceIdentityEntityName: String! (scalar)
        if (this.SourceIdentityEntityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityEntityName\n" ;
            } else {
                s += ind + "sourceIdentityEntityName\n" ;
            }
        }
        //      C# -> System.String? SourceIdentityId
        // GraphQL -> sourceIdentityId: String! (scalar)
        if (this.SourceIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityId\n" ;
            } else {
                s += ind + "sourceIdentityId\n" ;
            }
        }
        //      C# -> System.String? SourceIdentityName
        // GraphQL -> sourceIdentityName: String! (scalar)
        if (this.SourceIdentityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityName\n" ;
            } else {
                s += ind + "sourceIdentityName\n" ;
            }
        }
        //      C# -> System.String? SourceIdentityUniqueIdentifier
        // GraphQL -> sourceIdentityUniqueIdentifier: String! (scalar)
        if (this.SourceIdentityUniqueIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityUniqueIdentifier\n" ;
            } else {
                s += ind + "sourceIdentityUniqueIdentifier\n" ;
            }
        }
        //      C# -> System.String? TargetIdentityName
        // GraphQL -> targetIdentityName: String! (scalar)
        if (this.TargetIdentityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityName\n" ;
            } else {
                s += ind + "targetIdentityName\n" ;
            }
        }
        //      C# -> System.String? TargetIdentitySource
        // GraphQL -> targetIdentitySource: String! (scalar)
        if (this.TargetIdentitySource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentitySource\n" ;
            } else {
                s += ind + "targetIdentitySource\n" ;
            }
        }
        //      C# -> System.String? TargetIdentityUniqueIdentifier
        // GraphQL -> targetIdentityUniqueIdentifier: String! (scalar)
        if (this.TargetIdentityUniqueIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityUniqueIdentifier\n" ;
            } else {
                s += ind + "targetIdentityUniqueIdentifier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ViolationPrincipalType? ActorIdentityType
        // GraphQL -> actorIdentityType: ViolationPrincipalType! (enum)
        if (ec.Includes("actorIdentityType",true))
        {
            if(this.ActorIdentityType == null) {

                this.ActorIdentityType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.ActorIdentityType != null && ec.Excludes("actorIdentityType",true))
        {
            this.ActorIdentityType = null;
        }
        //      C# -> PrivilegeType? ActorPrivilegeType
        // GraphQL -> actorPrivilegeType: PrivilegeType! (enum)
        if (ec.Includes("actorPrivilegeType",true))
        {
            if(this.ActorPrivilegeType == null) {

                this.ActorPrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.ActorPrivilegeType != null && ec.Excludes("actorPrivilegeType",true))
        {
            this.ActorPrivilegeType = null;
        }
        //      C# -> IdentityEventActorIdentificationState? ActorState
        // GraphQL -> actorState: IdentityEventActorIdentificationState! (enum)
        if (ec.Includes("actorState",true))
        {
            if(this.ActorState == null) {

                this.ActorState = new IdentityEventActorIdentificationState();

            } else {


            }
        }
        else if (this.ActorState != null && ec.Excludes("actorState",true))
        {
            this.ActorState = null;
        }
        //      C# -> IdentityAlertEventType? EventType
        // GraphQL -> eventType: IdentityAlertEventType! (enum)
        if (ec.Includes("eventType",true))
        {
            if(this.EventType == null) {

                this.EventType = new IdentityAlertEventType();

            } else {


            }
        }
        else if (this.EventType != null && ec.Excludes("eventType",true))
        {
            this.EventType = null;
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> IdentityStatus? SourceIdentityStatus
        // GraphQL -> sourceIdentityStatus: IdentityStatus! (enum)
        if (ec.Includes("sourceIdentityStatus",true))
        {
            if(this.SourceIdentityStatus == null) {

                this.SourceIdentityStatus = new IdentityStatus();

            } else {


            }
        }
        else if (this.SourceIdentityStatus != null && ec.Excludes("sourceIdentityStatus",true))
        {
            this.SourceIdentityStatus = null;
        }
        //      C# -> ViolationPrincipalType? SourceIdentityType
        // GraphQL -> sourceIdentityType: ViolationPrincipalType! (enum)
        if (ec.Includes("sourceIdentityType",true))
        {
            if(this.SourceIdentityType == null) {

                this.SourceIdentityType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.SourceIdentityType != null && ec.Excludes("sourceIdentityType",true))
        {
            this.SourceIdentityType = null;
        }
        //      C# -> PrivilegeType? SourcePrivilegeType
        // GraphQL -> sourcePrivilegeType: PrivilegeType! (enum)
        if (ec.Includes("sourcePrivilegeType",true))
        {
            if(this.SourcePrivilegeType == null) {

                this.SourcePrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.SourcePrivilegeType != null && ec.Excludes("sourcePrivilegeType",true))
        {
            this.SourcePrivilegeType = null;
        }
        //      C# -> IdentityStatus? TargetIdentityStatus
        // GraphQL -> targetIdentityStatus: IdentityStatus! (enum)
        if (ec.Includes("targetIdentityStatus",true))
        {
            if(this.TargetIdentityStatus == null) {

                this.TargetIdentityStatus = new IdentityStatus();

            } else {


            }
        }
        else if (this.TargetIdentityStatus != null && ec.Excludes("targetIdentityStatus",true))
        {
            this.TargetIdentityStatus = null;
        }
        //      C# -> ViolationPrincipalType? TargetIdentityType
        // GraphQL -> targetIdentityType: ViolationPrincipalType! (enum)
        if (ec.Includes("targetIdentityType",true))
        {
            if(this.TargetIdentityType == null) {

                this.TargetIdentityType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.TargetIdentityType != null && ec.Excludes("targetIdentityType",true))
        {
            this.TargetIdentityType = null;
        }
        //      C# -> PrivilegeType? TargetPrivilegeType
        // GraphQL -> targetPrivilegeType: PrivilegeType! (enum)
        if (ec.Includes("targetPrivilegeType",true))
        {
            if(this.TargetPrivilegeType == null) {

                this.TargetPrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.TargetPrivilegeType != null && ec.Excludes("targetPrivilegeType",true))
        {
            this.TargetPrivilegeType = null;
        }
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (ec.Includes("actorIdentityId",true))
        {
            if(this.ActorIdentityId == null) {

                this.ActorIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.ActorIdentityId != null && ec.Excludes("actorIdentityId",true))
        {
            this.ActorIdentityId = null;
        }
        //      C# -> System.String? ActorIdentityName
        // GraphQL -> actorIdentityName: String! (scalar)
        if (ec.Includes("actorIdentityName",true))
        {
            if(this.ActorIdentityName == null) {

                this.ActorIdentityName = "FETCH";

            } else {


            }
        }
        else if (this.ActorIdentityName != null && ec.Excludes("actorIdentityName",true))
        {
            this.ActorIdentityName = null;
        }
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (ec.Includes("entityId",true))
        {
            if(this.EntityId == null) {

                this.EntityId = "FETCH";

            } else {


            }
        }
        else if (this.EntityId != null && ec.Excludes("entityId",true))
        {
            this.EntityId = null;
        }
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (ec.Includes("entityName",true))
        {
            if(this.EntityName == null) {

                this.EntityName = "FETCH";

            } else {


            }
        }
        else if (this.EntityName != null && ec.Excludes("entityName",true))
        {
            this.EntityName = null;
        }
        //      C# -> DateTime? EventTime
        // GraphQL -> eventTime: DateTime (scalar)
        if (ec.Includes("eventTime",true))
        {
            if(this.EventTime == null) {

                this.EventTime = new DateTime();

            } else {


            }
        }
        else if (this.EventTime != null && ec.Excludes("eventTime",true))
        {
            this.EventTime = null;
        }
        //      C# -> System.String? SourceIdentityEntityId
        // GraphQL -> sourceIdentityEntityId: String! (scalar)
        if (ec.Includes("sourceIdentityEntityId",true))
        {
            if(this.SourceIdentityEntityId == null) {

                this.SourceIdentityEntityId = "FETCH";

            } else {


            }
        }
        else if (this.SourceIdentityEntityId != null && ec.Excludes("sourceIdentityEntityId",true))
        {
            this.SourceIdentityEntityId = null;
        }
        //      C# -> System.String? SourceIdentityEntityName
        // GraphQL -> sourceIdentityEntityName: String! (scalar)
        if (ec.Includes("sourceIdentityEntityName",true))
        {
            if(this.SourceIdentityEntityName == null) {

                this.SourceIdentityEntityName = "FETCH";

            } else {


            }
        }
        else if (this.SourceIdentityEntityName != null && ec.Excludes("sourceIdentityEntityName",true))
        {
            this.SourceIdentityEntityName = null;
        }
        //      C# -> System.String? SourceIdentityId
        // GraphQL -> sourceIdentityId: String! (scalar)
        if (ec.Includes("sourceIdentityId",true))
        {
            if(this.SourceIdentityId == null) {

                this.SourceIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.SourceIdentityId != null && ec.Excludes("sourceIdentityId",true))
        {
            this.SourceIdentityId = null;
        }
        //      C# -> System.String? SourceIdentityName
        // GraphQL -> sourceIdentityName: String! (scalar)
        if (ec.Includes("sourceIdentityName",true))
        {
            if(this.SourceIdentityName == null) {

                this.SourceIdentityName = "FETCH";

            } else {


            }
        }
        else if (this.SourceIdentityName != null && ec.Excludes("sourceIdentityName",true))
        {
            this.SourceIdentityName = null;
        }
        //      C# -> System.String? SourceIdentityUniqueIdentifier
        // GraphQL -> sourceIdentityUniqueIdentifier: String! (scalar)
        if (ec.Includes("sourceIdentityUniqueIdentifier",true))
        {
            if(this.SourceIdentityUniqueIdentifier == null) {

                this.SourceIdentityUniqueIdentifier = "FETCH";

            } else {


            }
        }
        else if (this.SourceIdentityUniqueIdentifier != null && ec.Excludes("sourceIdentityUniqueIdentifier",true))
        {
            this.SourceIdentityUniqueIdentifier = null;
        }
        //      C# -> System.String? TargetIdentityName
        // GraphQL -> targetIdentityName: String! (scalar)
        if (ec.Includes("targetIdentityName",true))
        {
            if(this.TargetIdentityName == null) {

                this.TargetIdentityName = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentityName != null && ec.Excludes("targetIdentityName",true))
        {
            this.TargetIdentityName = null;
        }
        //      C# -> System.String? TargetIdentitySource
        // GraphQL -> targetIdentitySource: String! (scalar)
        if (ec.Includes("targetIdentitySource",true))
        {
            if(this.TargetIdentitySource == null) {

                this.TargetIdentitySource = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentitySource != null && ec.Excludes("targetIdentitySource",true))
        {
            this.TargetIdentitySource = null;
        }
        //      C# -> System.String? TargetIdentityUniqueIdentifier
        // GraphQL -> targetIdentityUniqueIdentifier: String! (scalar)
        if (ec.Includes("targetIdentityUniqueIdentifier",true))
        {
            if(this.TargetIdentityUniqueIdentifier == null) {

                this.TargetIdentityUniqueIdentifier = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentityUniqueIdentifier != null && ec.Excludes("targetIdentityUniqueIdentifier",true))
        {
            this.TargetIdentityUniqueIdentifier = null;
        }
    }


    #endregion

    } // class IdentityEventMetadata
    
    #endregion

    public static class ListIdentityEventMetadataExtensions
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
            this List<IdentityEventMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityEventMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityEventMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityEventMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityEventMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types