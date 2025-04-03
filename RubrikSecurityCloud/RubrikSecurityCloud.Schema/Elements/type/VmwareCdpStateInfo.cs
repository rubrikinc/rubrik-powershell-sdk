// VmwareCdpStateInfo.cs
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
    #region VmwareCdpStateInfo
    public class VmwareCdpStateInfo: BaseType
    {
        #region members

        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        [JsonProperty("localStatus")]
        public CdpLocalStatus? LocalStatus { get; set; }

        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        [JsonProperty("replicationStatus")]
        public CdpReplicationStatus? ReplicationStatus { get; set; }

        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        [JsonProperty("healthPercentage")]
        public System.Single? HealthPercentage { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareCdpStateInfo";
    }

    public VmwareCdpStateInfo Set(
        CdpLocalStatus? LocalStatus = null,
        CdpReplicationStatus? ReplicationStatus = null,
        System.Single? HealthPercentage = null,
        System.String? VmId = null
    ) 
    {
        if ( LocalStatus != null ) {
            this.LocalStatus = LocalStatus;
        }
        if ( ReplicationStatus != null ) {
            this.ReplicationStatus = ReplicationStatus;
        }
        if ( HealthPercentage != null ) {
            this.HealthPercentage = HealthPercentage;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        if (this.LocalStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localStatus\n" ;
            } else {
                s += ind + "localStatus\n" ;
            }
        }
        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        if (this.ReplicationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationStatus\n" ;
            } else {
                s += ind + "replicationStatus\n" ;
            }
        }
        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        if (this.HealthPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "healthPercentage\n" ;
            } else {
                s += ind + "healthPercentage\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CdpLocalStatus? LocalStatus
        // GraphQL -> localStatus: CdpLocalStatus (enum)
        if (ec.Includes("localStatus",true))
        {
            if(this.LocalStatus == null) {

                this.LocalStatus = new CdpLocalStatus();

            } else {


            }
        }
        else if (this.LocalStatus != null && ec.Excludes("localStatus",true))
        {
            this.LocalStatus = null;
        }
        //      C# -> CdpReplicationStatus? ReplicationStatus
        // GraphQL -> replicationStatus: CdpReplicationStatus (enum)
        if (ec.Includes("replicationStatus",true))
        {
            if(this.ReplicationStatus == null) {

                this.ReplicationStatus = new CdpReplicationStatus();

            } else {


            }
        }
        else if (this.ReplicationStatus != null && ec.Excludes("replicationStatus",true))
        {
            this.ReplicationStatus = null;
        }
        //      C# -> System.Single? HealthPercentage
        // GraphQL -> healthPercentage: Float (scalar)
        if (ec.Includes("healthPercentage",true))
        {
            if(this.HealthPercentage == null) {

                this.HealthPercentage = new System.Single();

            } else {


            }
        }
        else if (this.HealthPercentage != null && ec.Excludes("healthPercentage",true))
        {
            this.HealthPercentage = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
    }


    #endregion

    } // class VmwareCdpStateInfo
    
    #endregion

    public static class ListVmwareCdpStateInfoExtensions
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
            this List<VmwareCdpStateInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareCdpStateInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareCdpStateInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareCdpStateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareCdpStateInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types