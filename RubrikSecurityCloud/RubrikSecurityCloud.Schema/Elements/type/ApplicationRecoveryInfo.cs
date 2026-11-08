// ApplicationRecoveryInfo.cs
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
    #region ApplicationRecoveryInfo
    public class ApplicationRecoveryInfo: BaseType
    {
        #region members

        //      C# -> ApplicationRecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: ApplicationRecoveryOutcome! (enum)
        [JsonProperty("recoveryOutcome")]
        public ApplicationRecoveryOutcome? RecoveryOutcome { get; set; }

        //      C# -> ApplicationRecoveryStatus? Status
        // GraphQL -> status: ApplicationRecoveryStatus! (enum)
        [JsonProperty("status")]
        public ApplicationRecoveryStatus? Status { get; set; }

        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        [JsonProperty("applicationId")]
        public System.String? ApplicationId { get; set; }

        //      C# -> System.String? CompositeBlueprintId
        // GraphQL -> compositeBlueprintId: UUID! (scalar)
        [JsonProperty("compositeBlueprintId")]
        public System.String? CompositeBlueprintId { get; set; }

        //      C# -> System.String? CompositeFailoverId
        // GraphQL -> compositeFailoverId: UUID! (scalar)
        [JsonProperty("compositeFailoverId")]
        public System.String? CompositeFailoverId { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int64? NumWorkloads
        // GraphQL -> numWorkloads: Long! (scalar)
        [JsonProperty("numWorkloads")]
        public System.Int64? NumWorkloads { get; set; }

        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: UUID! (scalar)
        [JsonProperty("recoveryId")]
        public System.String? RecoveryId { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        [JsonProperty("targetCloudNativeAccountId")]
        public System.String? TargetCloudNativeAccountId { get; set; }

        //      C# -> System.String? TargetCloudNativeAccountName
        // GraphQL -> targetCloudNativeAccountName: String! (scalar)
        [JsonProperty("targetCloudNativeAccountName")]
        public System.String? TargetCloudNativeAccountName { get; set; }

        //      C# -> System.String? TargetRegion
        // GraphQL -> targetRegion: String! (scalar)
        [JsonProperty("targetRegion")]
        public System.String? TargetRegion { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationRecoveryInfo";
    }

    public ApplicationRecoveryInfo Set(
        ApplicationRecoveryOutcome? RecoveryOutcome = null,
        ApplicationRecoveryStatus? Status = null,
        System.String? ApplicationId = null,
        System.String? CompositeBlueprintId = null,
        System.String? CompositeFailoverId = null,
        DateTime? CreatedAt = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Int64? NumWorkloads = null,
        System.String? RecoveryId = null,
        System.String? RecoveryName = null,
        System.Int64? StartTime = null,
        System.String? TargetCloudNativeAccountId = null,
        System.String? TargetCloudNativeAccountName = null,
        System.String? TargetRegion = null,
        DateTime? UpdatedAt = null
    ) 
    {
        if ( RecoveryOutcome != null ) {
            this.RecoveryOutcome = RecoveryOutcome;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ApplicationId != null ) {
            this.ApplicationId = ApplicationId;
        }
        if ( CompositeBlueprintId != null ) {
            this.CompositeBlueprintId = CompositeBlueprintId;
        }
        if ( CompositeFailoverId != null ) {
            this.CompositeFailoverId = CompositeFailoverId;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( NumWorkloads != null ) {
            this.NumWorkloads = NumWorkloads;
        }
        if ( RecoveryId != null ) {
            this.RecoveryId = RecoveryId;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TargetCloudNativeAccountId != null ) {
            this.TargetCloudNativeAccountId = TargetCloudNativeAccountId;
        }
        if ( TargetCloudNativeAccountName != null ) {
            this.TargetCloudNativeAccountName = TargetCloudNativeAccountName;
        }
        if ( TargetRegion != null ) {
            this.TargetRegion = TargetRegion;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
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
        //      C# -> ApplicationRecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: ApplicationRecoveryOutcome! (enum)
        if (this.RecoveryOutcome != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryOutcome\n" ;
            } else {
                s += ind + "recoveryOutcome\n" ;
            }
        }
        //      C# -> ApplicationRecoveryStatus? Status
        // GraphQL -> status: ApplicationRecoveryStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        if (this.ApplicationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationId\n" ;
            } else {
                s += ind + "applicationId\n" ;
            }
        }
        //      C# -> System.String? CompositeBlueprintId
        // GraphQL -> compositeBlueprintId: UUID! (scalar)
        if (this.CompositeBlueprintId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "compositeBlueprintId\n" ;
            } else {
                s += ind + "compositeBlueprintId\n" ;
            }
        }
        //      C# -> System.String? CompositeFailoverId
        // GraphQL -> compositeFailoverId: UUID! (scalar)
        if (this.CompositeFailoverId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "compositeFailoverId\n" ;
            } else {
                s += ind + "compositeFailoverId\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "elapsedTime\n" ;
            } else {
                s += ind + "elapsedTime\n" ;
            }
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int64? NumWorkloads
        // GraphQL -> numWorkloads: Long! (scalar)
        if (this.NumWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloads\n" ;
            } else {
                s += ind + "numWorkloads\n" ;
            }
        }
        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: UUID! (scalar)
        if (this.RecoveryId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryId\n" ;
            } else {
                s += ind + "recoveryId\n" ;
            }
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryName\n" ;
            } else {
                s += ind + "recoveryName\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        if (this.TargetCloudNativeAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetCloudNativeAccountId\n" ;
            } else {
                s += ind + "targetCloudNativeAccountId\n" ;
            }
        }
        //      C# -> System.String? TargetCloudNativeAccountName
        // GraphQL -> targetCloudNativeAccountName: String! (scalar)
        if (this.TargetCloudNativeAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetCloudNativeAccountName\n" ;
            } else {
                s += ind + "targetCloudNativeAccountName\n" ;
            }
        }
        //      C# -> System.String? TargetRegion
        // GraphQL -> targetRegion: String! (scalar)
        if (this.TargetRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetRegion\n" ;
            } else {
                s += ind + "targetRegion\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ApplicationRecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: ApplicationRecoveryOutcome! (enum)
        if (ec.Includes("recoveryOutcome",true))
        {
            if(this.RecoveryOutcome == null) {

                this.RecoveryOutcome = new ApplicationRecoveryOutcome();

            } else {


            }
        }
        else if (this.RecoveryOutcome != null && ec.Excludes("recoveryOutcome",true))
        {
            this.RecoveryOutcome = null;
        }
        //      C# -> ApplicationRecoveryStatus? Status
        // GraphQL -> status: ApplicationRecoveryStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ApplicationRecoveryStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? ApplicationId
        // GraphQL -> applicationId: UUID! (scalar)
        if (ec.Includes("applicationId",true))
        {
            if(this.ApplicationId == null) {

                this.ApplicationId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationId != null && ec.Excludes("applicationId",true))
        {
            this.ApplicationId = null;
        }
        //      C# -> System.String? CompositeBlueprintId
        // GraphQL -> compositeBlueprintId: UUID! (scalar)
        if (ec.Includes("compositeBlueprintId",true))
        {
            if(this.CompositeBlueprintId == null) {

                this.CompositeBlueprintId = "FETCH";

            } else {


            }
        }
        else if (this.CompositeBlueprintId != null && ec.Excludes("compositeBlueprintId",true))
        {
            this.CompositeBlueprintId = null;
        }
        //      C# -> System.String? CompositeFailoverId
        // GraphQL -> compositeFailoverId: UUID! (scalar)
        if (ec.Includes("compositeFailoverId",true))
        {
            if(this.CompositeFailoverId == null) {

                this.CompositeFailoverId = "FETCH";

            } else {


            }
        }
        else if (this.CompositeFailoverId != null && ec.Excludes("compositeFailoverId",true))
        {
            this.CompositeFailoverId = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (ec.Includes("elapsedTime",true))
        {
            if(this.ElapsedTime == null) {

                this.ElapsedTime = new System.Int64();

            } else {


            }
        }
        else if (this.ElapsedTime != null && ec.Excludes("elapsedTime",true))
        {
            this.ElapsedTime = null;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int64? NumWorkloads
        // GraphQL -> numWorkloads: Long! (scalar)
        if (ec.Includes("numWorkloads",true))
        {
            if(this.NumWorkloads == null) {

                this.NumWorkloads = new System.Int64();

            } else {


            }
        }
        else if (this.NumWorkloads != null && ec.Excludes("numWorkloads",true))
        {
            this.NumWorkloads = null;
        }
        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: UUID! (scalar)
        if (ec.Includes("recoveryId",true))
        {
            if(this.RecoveryId == null) {

                this.RecoveryId = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryId != null && ec.Excludes("recoveryId",true))
        {
            this.RecoveryId = null;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (ec.Includes("recoveryName",true))
        {
            if(this.RecoveryName == null) {

                this.RecoveryName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryName != null && ec.Excludes("recoveryName",true))
        {
            this.RecoveryName = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new System.Int64();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        if (ec.Includes("targetCloudNativeAccountId",true))
        {
            if(this.TargetCloudNativeAccountId == null) {

                this.TargetCloudNativeAccountId = "FETCH";

            } else {


            }
        }
        else if (this.TargetCloudNativeAccountId != null && ec.Excludes("targetCloudNativeAccountId",true))
        {
            this.TargetCloudNativeAccountId = null;
        }
        //      C# -> System.String? TargetCloudNativeAccountName
        // GraphQL -> targetCloudNativeAccountName: String! (scalar)
        if (ec.Includes("targetCloudNativeAccountName",true))
        {
            if(this.TargetCloudNativeAccountName == null) {

                this.TargetCloudNativeAccountName = "FETCH";

            } else {


            }
        }
        else if (this.TargetCloudNativeAccountName != null && ec.Excludes("targetCloudNativeAccountName",true))
        {
            this.TargetCloudNativeAccountName = null;
        }
        //      C# -> System.String? TargetRegion
        // GraphQL -> targetRegion: String! (scalar)
        if (ec.Includes("targetRegion",true))
        {
            if(this.TargetRegion == null) {

                this.TargetRegion = "FETCH";

            } else {


            }
        }
        else if (this.TargetRegion != null && ec.Excludes("targetRegion",true))
        {
            this.TargetRegion = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
    }


    #endregion

    } // class ApplicationRecoveryInfo
    
    #endregion

    public static class ListApplicationRecoveryInfoExtensions
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
            this List<ApplicationRecoveryInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApplicationRecoveryInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationRecoveryInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationRecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationRecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types