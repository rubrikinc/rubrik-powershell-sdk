// VmwareSnapshotVmConfig.cs
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
    #region VmwareSnapshotVmConfig
    public class VmwareSnapshotVmConfig: BaseType
    {
        #region members

        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        [JsonProperty("networkConfig")]
        public VmwareNetworkConfig? NetworkConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareSnapshotVmConfig";
    }

    public VmwareSnapshotVmConfig Set(
        VmwareNetworkConfig? NetworkConfig = null
    ) 
    {
        if ( NetworkConfig != null ) {
            this.NetworkConfig = NetworkConfig;
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
        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        if (this.NetworkConfig != null) {
            var fspec = this.NetworkConfig.AsFieldSpec(conf.Child("networkConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        if (ec.Includes("networkConfig",false))
        {
            if(this.NetworkConfig == null) {

                this.NetworkConfig = new VmwareNetworkConfig();
                this.NetworkConfig.ApplyExploratoryFieldSpec(ec.NewChild("networkConfig"));

            } else {

                this.NetworkConfig.ApplyExploratoryFieldSpec(ec.NewChild("networkConfig"));

            }
        }
        else if (this.NetworkConfig != null && ec.Excludes("networkConfig",false))
        {
            this.NetworkConfig = null;
        }
    }


    #endregion

    } // class VmwareSnapshotVmConfig
    
    #endregion

    public static class ListVmwareSnapshotVmConfigExtensions
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
            this List<VmwareSnapshotVmConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VmwareSnapshotVmConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareSnapshotVmConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareSnapshotVmConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareSnapshotVmConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types