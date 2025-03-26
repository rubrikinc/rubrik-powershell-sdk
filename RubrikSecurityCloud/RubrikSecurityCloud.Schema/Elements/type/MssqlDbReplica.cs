// MssqlDbReplica.cs
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
    #region MssqlDbReplica
    public class MssqlDbReplica: BaseType
    {
        #region members

        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        [JsonProperty("recoveryModel")]
        public MssqlDbReplicaRecoveryModel? RecoveryModel { get; set; }

        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean! (scalar)
        [JsonProperty("isStandby")]
        public System.Boolean? IsStandby { get; set; }

        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        [JsonProperty("recoveryForkGuid")]
        public System.String? RecoveryForkGuid { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
        [JsonProperty("availabilityInfo")]
        public MssqlDbReplicaAvailabilityInfo? AvailabilityInfo { get; set; }

        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        [JsonProperty("rootProperties")]
        public MssqlRootProperties? RootProperties { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDbReplica";
    }

    public MssqlDbReplica Set(
        MssqlDbReplicaRecoveryModel? RecoveryModel = null,
        System.Boolean? HasPermissions = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsStandby = null,
        System.String? RecoveryForkGuid = null,
        System.String? State = null,
        MssqlDbReplicaAvailabilityInfo? AvailabilityInfo = null,
        MssqlRootProperties? RootProperties = null
    ) 
    {
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( IsStandby != null ) {
            this.IsStandby = IsStandby;
        }
        if ( RecoveryForkGuid != null ) {
            this.RecoveryForkGuid = RecoveryForkGuid;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( AvailabilityInfo != null ) {
            this.AvailabilityInfo = AvailabilityInfo;
        }
        if ( RootProperties != null ) {
            this.RootProperties = RootProperties;
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
        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        if (this.RecoveryModel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryModel\n" ;
            } else {
                s += ind + "recoveryModel\n" ;
            }
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPermissions\n" ;
            } else {
                s += ind + "hasPermissions\n" ;
            }
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceId\n" ;
            } else {
                s += ind + "instanceId\n" ;
            }
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceName\n" ;
            } else {
                s += ind + "instanceName\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeleted\n" ;
            } else {
                s += ind + "isDeleted\n" ;
            }
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean! (scalar)
        if (this.IsStandby != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isStandby\n" ;
            } else {
                s += ind + "isStandby\n" ;
            }
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (this.RecoveryForkGuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryForkGuid\n" ;
            } else {
                s += ind + "recoveryForkGuid\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
        if (this.AvailabilityInfo != null) {
            var fspec = this.AvailabilityInfo.AsFieldSpec(conf.Child("availabilityInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availabilityInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (this.RootProperties != null) {
            var fspec = this.RootProperties.AsFieldSpec(conf.Child("rootProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rootProperties" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        if (ec.Includes("recoveryModel",true))
        {
            if(this.RecoveryModel == null) {

                this.RecoveryModel = new MssqlDbReplicaRecoveryModel();

            } else {


            }
        }
        else if (this.RecoveryModel != null && ec.Excludes("recoveryModel",true))
        {
            this.RecoveryModel = null;
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (ec.Includes("hasPermissions",true))
        {
            if(this.HasPermissions == null) {

                this.HasPermissions = true;

            } else {


            }
        }
        else if (this.HasPermissions != null && ec.Excludes("hasPermissions",true))
        {
            this.HasPermissions = null;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (ec.Includes("instanceId",true))
        {
            if(this.InstanceId == null) {

                this.InstanceId = "FETCH";

            } else {


            }
        }
        else if (this.InstanceId != null && ec.Excludes("instanceId",true))
        {
            this.InstanceId = null;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (ec.Includes("instanceName",true))
        {
            if(this.InstanceName == null) {

                this.InstanceName = "FETCH";

            } else {


            }
        }
        else if (this.InstanceName != null && ec.Excludes("instanceName",true))
        {
            this.InstanceName = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (ec.Includes("isDeleted",true))
        {
            if(this.IsDeleted == null) {

                this.IsDeleted = true;

            } else {


            }
        }
        else if (this.IsDeleted != null && ec.Excludes("isDeleted",true))
        {
            this.IsDeleted = null;
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean! (scalar)
        if (ec.Includes("isStandby",true))
        {
            if(this.IsStandby == null) {

                this.IsStandby = true;

            } else {


            }
        }
        else if (this.IsStandby != null && ec.Excludes("isStandby",true))
        {
            this.IsStandby = null;
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (ec.Includes("recoveryForkGuid",true))
        {
            if(this.RecoveryForkGuid == null) {

                this.RecoveryForkGuid = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryForkGuid != null && ec.Excludes("recoveryForkGuid",true))
        {
            this.RecoveryForkGuid = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
        if (ec.Includes("availabilityInfo",false))
        {
            if(this.AvailabilityInfo == null) {

                this.AvailabilityInfo = new MssqlDbReplicaAvailabilityInfo();
                this.AvailabilityInfo.ApplyExploratoryFieldSpec(ec.NewChild("availabilityInfo"));

            } else {

                this.AvailabilityInfo.ApplyExploratoryFieldSpec(ec.NewChild("availabilityInfo"));

            }
        }
        else if (this.AvailabilityInfo != null && ec.Excludes("availabilityInfo",false))
        {
            this.AvailabilityInfo = null;
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (ec.Includes("rootProperties",false))
        {
            if(this.RootProperties == null) {

                this.RootProperties = new MssqlRootProperties();
                this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));

            } else {

                this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));

            }
        }
        else if (this.RootProperties != null && ec.Excludes("rootProperties",false))
        {
            this.RootProperties = null;
        }
    }


    #endregion

    } // class MssqlDbReplica
    
    #endregion

    public static class ListMssqlDbReplicaExtensions
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
            this List<MssqlDbReplica> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlDbReplica> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbReplica> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbReplica());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDbReplica> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types