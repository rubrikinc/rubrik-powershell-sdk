// VappAppMetadata.cs
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
    #region VappAppMetadata
    public class VappAppMetadata: BaseType
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        [JsonProperty("vcdVmMoid")]
        public System.String? VcdVmMoid { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        [JsonProperty("networkConnections")]
        public List<VmNetworkConnection>? NetworkConnections { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappAppMetadata";
    }

    public VappAppMetadata Set(
        System.String? SnapshotId = null,
        System.String? VcdVmMoid = null,
        System.String? VmName = null,
        List<VmNetworkConnection>? NetworkConnections = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( VcdVmMoid != null ) {
            this.VcdVmMoid = VcdVmMoid;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
        }
        if ( NetworkConnections != null ) {
            this.NetworkConnections = NetworkConnections;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (this.VcdVmMoid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcdVmMoid\n" ;
            } else {
                s += ind + "vcdVmMoid\n" ;
            }
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmName\n" ;
            } else {
                s += ind + "vmName\n" ;
            }
        }
        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        if (this.NetworkConnections != null) {
            var fspec = this.NetworkConnections.AsFieldSpec(conf.Child("networkConnections"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkConnections" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (ec.Includes("vcdVmMoid",true))
        {
            if(this.VcdVmMoid == null) {

                this.VcdVmMoid = "FETCH";

            } else {


            }
        }
        else if (this.VcdVmMoid != null && ec.Excludes("vcdVmMoid",true))
        {
            this.VcdVmMoid = null;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (ec.Includes("vmName",true))
        {
            if(this.VmName == null) {

                this.VmName = "FETCH";

            } else {


            }
        }
        else if (this.VmName != null && ec.Excludes("vmName",true))
        {
            this.VmName = null;
        }
        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        if (ec.Includes("networkConnections",false))
        {
            if(this.NetworkConnections == null) {

                this.NetworkConnections = new List<VmNetworkConnection>();
                this.NetworkConnections.ApplyExploratoryFieldSpec(ec.NewChild("networkConnections"));

            } else {

                this.NetworkConnections.ApplyExploratoryFieldSpec(ec.NewChild("networkConnections"));

            }
        }
        else if (this.NetworkConnections != null && ec.Excludes("networkConnections",false))
        {
            this.NetworkConnections = null;
        }
    }


    #endregion

    } // class VappAppMetadata
    
    #endregion

    public static class ListVappAppMetadataExtensions
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
            this List<VappAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VappAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types