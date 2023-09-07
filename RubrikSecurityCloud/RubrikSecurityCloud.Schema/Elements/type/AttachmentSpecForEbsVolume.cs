// AttachmentSpecForEbsVolume.cs
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
    #region AttachmentSpecForEbsVolume
    public class AttachmentSpecForEbsVolume: BaseType
    {
        #region members

        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
        [JsonProperty("awsNativeEc2InstanceId")]
        public System.String? AwsNativeEc2InstanceId { get; set; }

        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        [JsonProperty("devicePath")]
        public System.String? DevicePath { get; set; }

        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        [JsonProperty("isExcludedFromSnapshot")]
        public System.Boolean? IsExcludedFromSnapshot { get; set; }

        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        [JsonProperty("isRootVolume")]
        public System.Boolean? IsRootVolume { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AttachmentSpecForEbsVolume";
    }

    public AttachmentSpecForEbsVolume Set(
        System.String? AwsNativeEc2InstanceId = null,
        System.String? DevicePath = null,
        System.Boolean? IsExcludedFromSnapshot = null,
        System.Boolean? IsRootVolume = null
    ) 
    {
        if ( AwsNativeEc2InstanceId != null ) {
            this.AwsNativeEc2InstanceId = AwsNativeEc2InstanceId;
        }
        if ( DevicePath != null ) {
            this.DevicePath = DevicePath;
        }
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
        }
        if ( IsRootVolume != null ) {
            this.IsRootVolume = IsRootVolume;
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
        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
        if (this.AwsNativeEc2InstanceId != null) {
            s += ind + "awsNativeEc2InstanceId\n" ;
        }
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (this.DevicePath != null) {
            s += ind + "devicePath\n" ;
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot != null) {
            s += ind + "isExcludedFromSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (this.IsRootVolume != null) {
            s += ind + "isRootVolume\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
        if (this.AwsNativeEc2InstanceId == null && ec.Includes("awsNativeEc2InstanceId",true))
        {
            this.AwsNativeEc2InstanceId = "FETCH";
        }
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (this.DevicePath == null && ec.Includes("devicePath",true))
        {
            this.DevicePath = "FETCH";
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot == null && ec.Includes("isExcludedFromSnapshot",true))
        {
            this.IsExcludedFromSnapshot = true;
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (this.IsRootVolume == null && ec.Includes("isRootVolume",true))
        {
            this.IsRootVolume = true;
        }
    }


    #endregion

    } // class AttachmentSpecForEbsVolume
    
    #endregion

    public static class ListAttachmentSpecForEbsVolumeExtensions
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
            this List<AttachmentSpecForEbsVolume> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AttachmentSpecForEbsVolume> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AttachmentSpecForEbsVolume());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AttachmentSpecForEbsVolume> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types