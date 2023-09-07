// GcpNativeAttachmentDetails.cs
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
    #region GcpNativeAttachmentDetails
    public class GcpNativeAttachmentDetails: BaseType
    {
        #region members

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        [JsonProperty("instanceZone")]
        public System.String? InstanceZone { get; set; }

        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        [JsonProperty("isBootDisk")]
        public System.Boolean? IsBootDisk { get; set; }

        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        [JsonProperty("isExcluded")]
        public System.Boolean? IsExcluded { get; set; }

        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        [JsonProperty("sizeInGiBs")]
        public System.Int32? SizeInGiBs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeAttachmentDetails";
    }

    public GcpNativeAttachmentDetails Set(
        System.String? DeviceName = null,
        System.String? DiskId = null,
        System.String? DiskName = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.String? InstanceZone = null,
        System.Boolean? IsBootDisk = null,
        System.Boolean? IsExcluded = null,
        System.Int32? SizeInGiBs = null
    ) 
    {
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceZone != null ) {
            this.InstanceZone = InstanceZone;
        }
        if ( IsBootDisk != null ) {
            this.IsBootDisk = IsBootDisk;
        }
        if ( IsExcluded != null ) {
            this.IsExcluded = IsExcluded;
        }
        if ( SizeInGiBs != null ) {
            this.SizeInGiBs = SizeInGiBs;
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
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName != null) {
            s += ind + "deviceName\n" ;
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            s += ind + "diskId\n" ;
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            s += ind + "diskName\n" ;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            s += ind + "instanceId\n" ;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            s += ind + "instanceName\n" ;
        }
        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        if (this.InstanceZone != null) {
            s += ind + "instanceZone\n" ;
        }
        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        if (this.IsBootDisk != null) {
            s += ind + "isBootDisk\n" ;
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (this.IsExcluded != null) {
            s += ind + "isExcluded\n" ;
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (this.SizeInGiBs != null) {
            s += ind + "sizeInGiBs\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName == null && ec.Includes("deviceName",true))
        {
            this.DeviceName = "FETCH";
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId == null && ec.Includes("diskId",true))
        {
            this.DiskId = "FETCH";
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName == null && ec.Includes("diskName",true))
        {
            this.DiskName = "FETCH";
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId == null && ec.Includes("instanceId",true))
        {
            this.InstanceId = "FETCH";
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName == null && ec.Includes("instanceName",true))
        {
            this.InstanceName = "FETCH";
        }
        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        if (this.InstanceZone == null && ec.Includes("instanceZone",true))
        {
            this.InstanceZone = "FETCH";
        }
        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        if (this.IsBootDisk == null && ec.Includes("isBootDisk",true))
        {
            this.IsBootDisk = true;
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (this.IsExcluded == null && ec.Includes("isExcluded",true))
        {
            this.IsExcluded = true;
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (this.SizeInGiBs == null && ec.Includes("sizeInGiBs",true))
        {
            this.SizeInGiBs = Int32.MinValue;
        }
    }


    #endregion

    } // class GcpNativeAttachmentDetails
    
    #endregion

    public static class ListGcpNativeAttachmentDetailsExtensions
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
            this List<GcpNativeAttachmentDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeAttachmentDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeAttachmentDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GcpNativeAttachmentDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types