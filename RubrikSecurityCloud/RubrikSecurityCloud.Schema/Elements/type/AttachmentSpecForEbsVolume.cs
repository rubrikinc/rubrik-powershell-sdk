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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
        if (this.AwsNativeEc2InstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsNativeEc2InstanceId\n" ;
            } else {
                s += ind + "awsNativeEc2InstanceId\n" ;
            }
        }
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (this.DevicePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "devicePath\n" ;
            } else {
                s += ind + "devicePath\n" ;
            }
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcludedFromSnapshot\n" ;
            } else {
                s += ind + "isExcludedFromSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (this.IsRootVolume != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRootVolume\n" ;
            } else {
                s += ind + "isRootVolume\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
        if (ec.Includes("awsNativeEc2InstanceId",true))
        {
            if(this.AwsNativeEc2InstanceId == null) {

                this.AwsNativeEc2InstanceId = "FETCH";

            } else {


            }
        }
        else if (this.AwsNativeEc2InstanceId != null && ec.Excludes("awsNativeEc2InstanceId",true))
        {
            this.AwsNativeEc2InstanceId = null;
        }
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (ec.Includes("devicePath",true))
        {
            if(this.DevicePath == null) {

                this.DevicePath = "FETCH";

            } else {


            }
        }
        else if (this.DevicePath != null && ec.Excludes("devicePath",true))
        {
            this.DevicePath = null;
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (ec.Includes("isExcludedFromSnapshot",true))
        {
            if(this.IsExcludedFromSnapshot == null) {

                this.IsExcludedFromSnapshot = true;

            } else {


            }
        }
        else if (this.IsExcludedFromSnapshot != null && ec.Excludes("isExcludedFromSnapshot",true))
        {
            this.IsExcludedFromSnapshot = null;
        }
        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        if (ec.Includes("isRootVolume",true))
        {
            if(this.IsRootVolume == null) {

                this.IsRootVolume = true;

            } else {


            }
        }
        else if (this.IsRootVolume != null && ec.Excludes("isRootVolume",true))
        {
            this.IsRootVolume = null;
        }
    }


    #endregion

    } // class AttachmentSpecForEbsVolume
    
    #endregion

    public static class ListAttachmentSpecForEbsVolumeExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AttachmentSpecForEbsVolume> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AttachmentSpecForEbsVolume> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AttachmentSpecForEbsVolume> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types