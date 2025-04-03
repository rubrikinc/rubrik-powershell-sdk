// ManagedVolumeChannelConfig.cs
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
    #region ManagedVolumeChannelConfig
    public class ManagedVolumeChannelConfig: BaseType
    {
        #region members

        //      C# -> System.String? HostMountPoint
        // GraphQL -> hostMountPoint: String (scalar)
        [JsonProperty("hostMountPoint")]
        public System.String? HostMountPoint { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? MountPoint
        // GraphQL -> mountPoint: String! (scalar)
        [JsonProperty("mountPoint")]
        public System.String? MountPoint { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeChannelConfig";
    }

    public ManagedVolumeChannelConfig Set(
        System.String? HostMountPoint = null,
        System.String? IpAddress = null,
        System.String? MountPoint = null
    ) 
    {
        if ( HostMountPoint != null ) {
            this.HostMountPoint = HostMountPoint;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( MountPoint != null ) {
            this.MountPoint = MountPoint;
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
        //      C# -> System.String? HostMountPoint
        // GraphQL -> hostMountPoint: String (scalar)
        if (this.HostMountPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostMountPoint\n" ;
            } else {
                s += ind + "hostMountPoint\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.String? MountPoint
        // GraphQL -> mountPoint: String! (scalar)
        if (this.MountPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPoint\n" ;
            } else {
                s += ind + "mountPoint\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? HostMountPoint
        // GraphQL -> hostMountPoint: String (scalar)
        if (ec.Includes("hostMountPoint",true))
        {
            if(this.HostMountPoint == null) {

                this.HostMountPoint = "FETCH";

            } else {


            }
        }
        else if (this.HostMountPoint != null && ec.Excludes("hostMountPoint",true))
        {
            this.HostMountPoint = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.String? MountPoint
        // GraphQL -> mountPoint: String! (scalar)
        if (ec.Includes("mountPoint",true))
        {
            if(this.MountPoint == null) {

                this.MountPoint = "FETCH";

            } else {


            }
        }
        else if (this.MountPoint != null && ec.Excludes("mountPoint",true))
        {
            this.MountPoint = null;
        }
    }


    #endregion

    } // class ManagedVolumeChannelConfig
    
    #endregion

    public static class ListManagedVolumeChannelConfigExtensions
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
            this List<ManagedVolumeChannelConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeChannelConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeChannelConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeChannelConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeChannelConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types