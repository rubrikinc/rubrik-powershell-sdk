// ClusterDisk.cs
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
    #region ClusterDisk
    public class ClusterDisk: BaseType
    {
        #region members

        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        [JsonProperty("diskType")]
        public ClusterDiskType? DiskType { get; set; }

        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        [JsonProperty("status")]
        public ClusterDiskStatus? Status { get; set; }

        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        [JsonProperty("capacityBytes")]
        public System.Int64? CapacityBytes { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        [JsonProperty("isResizable")]
        public System.Boolean? IsResizable { get; set; }

        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        [JsonProperty("ledStatus")]
        public System.Boolean? LedStatus { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        [JsonProperty("serial")]
        public System.String? Serial { get; set; }

        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        [JsonProperty("unallocatedBytes")]
        public System.Int64? UnallocatedBytes { get; set; }

        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        [JsonProperty("usableBytes")]
        public System.Int64? UsableBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterDisk";
    }

    public ClusterDisk Set(
        ClusterDiskType? DiskType = null,
        ClusterDiskStatus? Status = null,
        System.Int64? CapacityBytes = null,
        System.String? ClusterId = null,
        System.String? DiskId = null,
        System.String? Id = null,
        System.Boolean? IsEncrypted = null,
        System.Boolean? IsResizable = null,
        System.Boolean? LedStatus = null,
        System.String? NodeId = null,
        System.String? Path = null,
        System.String? Serial = null,
        System.Int64? UnallocatedBytes = null,
        System.Int64? UsableBytes = null
    ) 
    {
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CapacityBytes != null ) {
            this.CapacityBytes = CapacityBytes;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( IsResizable != null ) {
            this.IsResizable = IsResizable;
        }
        if ( LedStatus != null ) {
            this.LedStatus = LedStatus;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Serial != null ) {
            this.Serial = Serial;
        }
        if ( UnallocatedBytes != null ) {
            this.UnallocatedBytes = UnallocatedBytes;
        }
        if ( UsableBytes != null ) {
            this.UsableBytes = UsableBytes;
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
        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        if (this.DiskType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskType\n" ;
            } else {
                s += ind + "diskType\n" ;
            }
        }
        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (this.CapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityBytes\n" ;
            } else {
                s += ind + "capacityBytes\n" ;
            }
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskId\n" ;
            } else {
                s += ind + "diskId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEncrypted\n" ;
            } else {
                s += ind + "isEncrypted\n" ;
            }
        }
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        if (this.IsResizable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isResizable\n" ;
            } else {
                s += ind + "isResizable\n" ;
            }
        }
        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        if (this.LedStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ledStatus\n" ;
            } else {
                s += ind + "ledStatus\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        if (this.Serial != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serial\n" ;
            } else {
                s += ind + "serial\n" ;
            }
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (this.UnallocatedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unallocatedBytes\n" ;
            } else {
                s += ind + "unallocatedBytes\n" ;
            }
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (this.UsableBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usableBytes\n" ;
            } else {
                s += ind + "usableBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        if (ec.Includes("diskType",true))
        {
            if(this.DiskType == null) {

                this.DiskType = new ClusterDiskType();

            } else {


            }
        }
        else if (this.DiskType != null && ec.Excludes("diskType",true))
        {
            this.DiskType = null;
        }
        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ClusterDiskStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (ec.Includes("capacityBytes",true))
        {
            if(this.CapacityBytes == null) {

                this.CapacityBytes = new System.Int64();

            } else {


            }
        }
        else if (this.CapacityBytes != null && ec.Excludes("capacityBytes",true))
        {
            this.CapacityBytes = null;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (ec.Includes("diskId",true))
        {
            if(this.DiskId == null) {

                this.DiskId = "FETCH";

            } else {


            }
        }
        else if (this.DiskId != null && ec.Excludes("diskId",true))
        {
            this.DiskId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (ec.Includes("isEncrypted",true))
        {
            if(this.IsEncrypted == null) {

                this.IsEncrypted = true;

            } else {


            }
        }
        else if (this.IsEncrypted != null && ec.Excludes("isEncrypted",true))
        {
            this.IsEncrypted = null;
        }
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        if (ec.Includes("isResizable",true))
        {
            if(this.IsResizable == null) {

                this.IsResizable = true;

            } else {


            }
        }
        else if (this.IsResizable != null && ec.Excludes("isResizable",true))
        {
            this.IsResizable = null;
        }
        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        if (ec.Includes("ledStatus",true))
        {
            if(this.LedStatus == null) {

                this.LedStatus = true;

            } else {


            }
        }
        else if (this.LedStatus != null && ec.Excludes("ledStatus",true))
        {
            this.LedStatus = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        if (ec.Includes("serial",true))
        {
            if(this.Serial == null) {

                this.Serial = "FETCH";

            } else {


            }
        }
        else if (this.Serial != null && ec.Excludes("serial",true))
        {
            this.Serial = null;
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (ec.Includes("unallocatedBytes",true))
        {
            if(this.UnallocatedBytes == null) {

                this.UnallocatedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UnallocatedBytes != null && ec.Excludes("unallocatedBytes",true))
        {
            this.UnallocatedBytes = null;
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (ec.Includes("usableBytes",true))
        {
            if(this.UsableBytes == null) {

                this.UsableBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UsableBytes != null && ec.Excludes("usableBytes",true))
        {
            this.UsableBytes = null;
        }
    }


    #endregion

    } // class ClusterDisk
    
    #endregion

    public static class ListClusterDiskExtensions
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
            this List<ClusterDisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterDisk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterDisk> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types