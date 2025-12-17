// FailoverGroupWorkload.cs
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
    #region FailoverGroupWorkload
    public class FailoverGroupWorkload: BaseType
    {
        #region members

        //      C# -> FailoverGroupObjectStatus? Status
        // GraphQL -> status: FailoverGroupObjectStatus! (enum)
        [JsonProperty("status")]
        public FailoverGroupObjectStatus? Status { get; set; }

        //      C# -> FlexmotionWorkloadType? WorkloadType
        // GraphQL -> workloadType: FlexmotionWorkloadType! (enum)
        [JsonProperty("workloadType")]
        public FlexmotionWorkloadType? WorkloadType { get; set; }

        //      C# -> List<System.String>? CounterpartIds
        // GraphQL -> counterpartIds: [UUID!]! (scalar)
        [JsonProperty("counterpartIds")]
        public List<System.String>? CounterpartIds { get; set; }

        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [UUID!]! (scalar)
        [JsonProperty("hostIds")]
        public List<System.String>? HostIds { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverGroupWorkload";
    }

    public FailoverGroupWorkload Set(
        FailoverGroupObjectStatus? Status = null,
        FlexmotionWorkloadType? WorkloadType = null,
        List<System.String>? CounterpartIds = null,
        List<System.String>? HostIds = null,
        System.String? Name = null,
        System.String? PrimaryClusterUuid = null,
        System.String? StatusMessage = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( CounterpartIds != null ) {
            this.CounterpartIds = CounterpartIds;
        }
        if ( HostIds != null ) {
            this.HostIds = HostIds;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> FailoverGroupObjectStatus? Status
        // GraphQL -> status: FailoverGroupObjectStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> FlexmotionWorkloadType? WorkloadType
        // GraphQL -> workloadType: FlexmotionWorkloadType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        //      C# -> List<System.String>? CounterpartIds
        // GraphQL -> counterpartIds: [UUID!]! (scalar)
        if (this.CounterpartIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "counterpartIds\n" ;
            } else {
                s += ind + "counterpartIds\n" ;
            }
        }
        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [UUID!]! (scalar)
        if (this.HostIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostIds\n" ;
            } else {
                s += ind + "hostIds\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (this.PrimaryClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterUuid\n" ;
            } else {
                s += ind + "primaryClusterUuid\n" ;
            }
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FailoverGroupObjectStatus? Status
        // GraphQL -> status: FailoverGroupObjectStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new FailoverGroupObjectStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> FlexmotionWorkloadType? WorkloadType
        // GraphQL -> workloadType: FlexmotionWorkloadType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new FlexmotionWorkloadType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
        //      C# -> List<System.String>? CounterpartIds
        // GraphQL -> counterpartIds: [UUID!]! (scalar)
        if (ec.Includes("counterpartIds",true))
        {
            if(this.CounterpartIds == null) {

                this.CounterpartIds = new List<System.String>();

            } else {


            }
        }
        else if (this.CounterpartIds != null && ec.Excludes("counterpartIds",true))
        {
            this.CounterpartIds = null;
        }
        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [UUID!]! (scalar)
        if (ec.Includes("hostIds",true))
        {
            if(this.HostIds == null) {

                this.HostIds = new List<System.String>();

            } else {


            }
        }
        else if (this.HostIds != null && ec.Excludes("hostIds",true))
        {
            this.HostIds = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (ec.Includes("primaryClusterUuid",true))
        {
            if(this.PrimaryClusterUuid == null) {

                this.PrimaryClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterUuid != null && ec.Excludes("primaryClusterUuid",true))
        {
            this.PrimaryClusterUuid = null;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
    }


    #endregion

    } // class FailoverGroupWorkload
    
    #endregion

    public static class ListFailoverGroupWorkloadExtensions
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
            this List<FailoverGroupWorkload> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverGroupWorkload> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverGroupWorkload> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverGroupWorkload());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverGroupWorkload> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types