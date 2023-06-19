// AttachmentSpecForEc2Instance.cs
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
    #region AttachmentSpecForEc2Instance
    public class AttachmentSpecForEc2Instance: BaseType
    {
        #region members

        //      C# -> System.String? AwsNativeEbsVolumeId
        // GraphQL -> awsNativeEbsVolumeId: String! (scalar)
        [JsonProperty("awsNativeEbsVolumeId")]
        public System.String? AwsNativeEbsVolumeId { get; set; }

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

    public AttachmentSpecForEc2Instance Set(
        System.String? AwsNativeEbsVolumeId = null,
        System.String? DevicePath = null,
        System.Boolean? IsExcludedFromSnapshot = null,
        System.Boolean? IsRootVolume = null
    ) 
    {
        if ( AwsNativeEbsVolumeId != null ) {
            this.AwsNativeEbsVolumeId = AwsNativeEbsVolumeId;
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
        //      C# -> System.String? AwsNativeEbsVolumeId
        // GraphQL -> awsNativeEbsVolumeId: String! (scalar)
        if (this.AwsNativeEbsVolumeId != null) {
            s += ind + "awsNativeEbsVolumeId\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AwsNativeEbsVolumeId
        // GraphQL -> awsNativeEbsVolumeId: String! (scalar)
        if (this.AwsNativeEbsVolumeId == null && Exploration.Includes(parent + ".awsNativeEbsVolumeId", true))
        {
            this.AwsNativeEbsVolumeId = "FETCH";
        }
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (this.DevicePath == null && Exploration.Includes(parent + ".devicePath", true))
        {
            this.DevicePath = "FETCH";
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot == null && Exploration.Includes(parent + ".isExcludedFromSnapshot", true))
        {
            this.IsExcludedFromSnapshot = true;
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (this.IsRootVolume == null && Exploration.Includes(parent + ".isRootVolume", true))
        {
            this.IsRootVolume = true;
        }
    }


    #endregion

    } // class AttachmentSpecForEc2Instance
    
    #endregion

    public static class ListAttachmentSpecForEc2InstanceExtensions
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
            this List<AttachmentSpecForEc2Instance> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AttachmentSpecForEc2Instance> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AttachmentSpecForEc2Instance());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types