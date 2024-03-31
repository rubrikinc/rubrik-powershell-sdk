// ManagedVolumeExportChannel.cs
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
    #region ManagedVolumeExportChannel
    public class ManagedVolumeExportChannel: BaseType
    {
        #region members

        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        [JsonProperty("exportDate")]
        public DateTime? ExportDate { get; set; }

        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        [JsonProperty("floatingIpAddress")]
        public System.String? FloatingIpAddress { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        [JsonProperty("channelStats")]
        public ManagedVolumeExportChannelStats? ChannelStats { get; set; }

        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        [JsonProperty("mountSpec")]
        public ManagedVolumeMountSpec? MountSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeExportChannel";
    }

    public ManagedVolumeExportChannel Set(
        DateTime? ExportDate = null,
        System.String? FloatingIpAddress = null,
        System.String? Id = null,
        System.String? MountPath = null,
        ManagedVolumeExportChannelStats? ChannelStats = null,
        ManagedVolumeMountSpec? MountSpec = null
    ) 
    {
        if ( ExportDate != null ) {
            this.ExportDate = ExportDate;
        }
        if ( FloatingIpAddress != null ) {
            this.FloatingIpAddress = FloatingIpAddress;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( ChannelStats != null ) {
            this.ChannelStats = ChannelStats;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
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
        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        if (this.ExportDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exportDate\n" ;
            } else {
                s += ind + "exportDate\n" ;
            }
        }
        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        if (this.FloatingIpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "floatingIpAddress\n" ;
            } else {
                s += ind + "floatingIpAddress\n" ;
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
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        if (this.MountPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPath\n" ;
            } else {
                s += ind + "mountPath\n" ;
            }
        }
        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        if (this.ChannelStats != null) {
            var fspec = this.ChannelStats.AsFieldSpec(conf.Child("channelStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "channelStats {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        if (this.MountSpec != null) {
            var fspec = this.MountSpec.AsFieldSpec(conf.Child("mountSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mountSpec {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        if (ec.Includes("exportDate",true))
        {
            if(this.ExportDate == null) {

                this.ExportDate = new DateTime();

            } else {


            }
        }
        else if (this.ExportDate != null && ec.Excludes("exportDate",true))
        {
            this.ExportDate = null;
        }
        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        if (ec.Includes("floatingIpAddress",true))
        {
            if(this.FloatingIpAddress == null) {

                this.FloatingIpAddress = "FETCH";

            } else {


            }
        }
        else if (this.FloatingIpAddress != null && ec.Excludes("floatingIpAddress",true))
        {
            this.FloatingIpAddress = null;
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
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        if (ec.Includes("mountPath",true))
        {
            if(this.MountPath == null) {

                this.MountPath = "FETCH";

            } else {


            }
        }
        else if (this.MountPath != null && ec.Excludes("mountPath",true))
        {
            this.MountPath = null;
        }
        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        if (ec.Includes("channelStats",false))
        {
            if(this.ChannelStats == null) {

                this.ChannelStats = new ManagedVolumeExportChannelStats();
                this.ChannelStats.ApplyExploratoryFieldSpec(ec.NewChild("channelStats"));

            } else {

                this.ChannelStats.ApplyExploratoryFieldSpec(ec.NewChild("channelStats"));

            }
        }
        else if (this.ChannelStats != null && ec.Excludes("channelStats",false))
        {
            this.ChannelStats = null;
        }
        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        if (ec.Includes("mountSpec",false))
        {
            if(this.MountSpec == null) {

                this.MountSpec = new ManagedVolumeMountSpec();
                this.MountSpec.ApplyExploratoryFieldSpec(ec.NewChild("mountSpec"));

            } else {

                this.MountSpec.ApplyExploratoryFieldSpec(ec.NewChild("mountSpec"));

            }
        }
        else if (this.MountSpec != null && ec.Excludes("mountSpec",false))
        {
            this.MountSpec = null;
        }
    }


    #endregion

    } // class ManagedVolumeExportChannel
    
    #endregion

    public static class ListManagedVolumeExportChannelExtensions
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
            this List<ManagedVolumeExportChannel> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeExportChannel> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeExportChannel> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeExportChannel());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeExportChannel> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types