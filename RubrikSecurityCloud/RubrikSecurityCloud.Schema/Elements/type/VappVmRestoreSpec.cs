// VappVmRestoreSpec.cs
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
    #region VappVmRestoreSpec
    public class VappVmRestoreSpec: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        [JsonProperty("storagePolicyId")]
        public System.String? StoragePolicyId { get; set; }

        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        [JsonProperty("vcdMoid")]
        public System.String? VcdMoid { get; set; }

        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        [JsonProperty("networkConnections")]
        public List<VappVmNetworkConnection>? NetworkConnections { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappVmRestoreSpec";
    }

    public VappVmRestoreSpec Set(
        System.String? Name = null,
        System.String? StoragePolicyId = null,
        System.String? VcdMoid = null,
        List<VappVmNetworkConnection>? NetworkConnections = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( StoragePolicyId != null ) {
            this.StoragePolicyId = StoragePolicyId;
        }
        if ( VcdMoid != null ) {
            this.VcdMoid = VcdMoid;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        if (this.StoragePolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storagePolicyId\n" ;
            } else {
                s += ind + "storagePolicyId\n" ;
            }
        }
        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        if (this.VcdMoid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcdMoid\n" ;
            } else {
                s += ind + "vcdMoid\n" ;
            }
        }
        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        if (this.NetworkConnections != null) {
            var fspec = this.NetworkConnections.AsFieldSpec(conf.Child("networkConnections"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkConnections {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        if (ec.Includes("storagePolicyId",true))
        {
            if(this.StoragePolicyId == null) {

                this.StoragePolicyId = "FETCH";

            } else {


            }
        }
        else if (this.StoragePolicyId != null && ec.Excludes("storagePolicyId",true))
        {
            this.StoragePolicyId = null;
        }
        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        if (ec.Includes("vcdMoid",true))
        {
            if(this.VcdMoid == null) {

                this.VcdMoid = "FETCH";

            } else {


            }
        }
        else if (this.VcdMoid != null && ec.Excludes("vcdMoid",true))
        {
            this.VcdMoid = null;
        }
        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        if (ec.Includes("networkConnections",false))
        {
            if(this.NetworkConnections == null) {

                this.NetworkConnections = new List<VappVmNetworkConnection>();
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

    } // class VappVmRestoreSpec
    
    #endregion

    public static class ListVappVmRestoreSpecExtensions
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
            this List<VappVmRestoreSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VappVmRestoreSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappVmRestoreSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappVmRestoreSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappVmRestoreSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types