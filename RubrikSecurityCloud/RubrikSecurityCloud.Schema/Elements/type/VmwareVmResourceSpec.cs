// VmwareVmResourceSpec.cs
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
    #region VmwareVmResourceSpec
    public class VmwareVmResourceSpec: BaseType
    {
        #region members

        //      C# -> List<VmwareVmNetworkInterface>? NetworkInterfaces
        // GraphQL -> networkInterfaces: [VmwareVmNetworkInterface!]! (type)
        [JsonProperty("networkInterfaces")]
        public List<VmwareVmNetworkInterface>? NetworkInterfaces { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVmResourceSpec";
    }

    public VmwareVmResourceSpec Set(
        List<VmwareVmNetworkInterface>? NetworkInterfaces = null
    ) 
    {
        if ( NetworkInterfaces != null ) {
            this.NetworkInterfaces = NetworkInterfaces;
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
        //      C# -> List<VmwareVmNetworkInterface>? NetworkInterfaces
        // GraphQL -> networkInterfaces: [VmwareVmNetworkInterface!]! (type)
        if (this.NetworkInterfaces != null) {
            var fspec = this.NetworkInterfaces.AsFieldSpec(conf.Child("networkInterfaces"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkInterfaces {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VmwareVmNetworkInterface>? NetworkInterfaces
        // GraphQL -> networkInterfaces: [VmwareVmNetworkInterface!]! (type)
        if (ec.Includes("networkInterfaces",false))
        {
            if(this.NetworkInterfaces == null) {

                this.NetworkInterfaces = new List<VmwareVmNetworkInterface>();
                this.NetworkInterfaces.ApplyExploratoryFieldSpec(ec.NewChild("networkInterfaces"));

            } else {

                this.NetworkInterfaces.ApplyExploratoryFieldSpec(ec.NewChild("networkInterfaces"));

            }
        }
        else if (this.NetworkInterfaces != null && ec.Excludes("networkInterfaces",false))
        {
            this.NetworkInterfaces = null;
        }
    }


    #endregion

    } // class VmwareVmResourceSpec
    
    #endregion

    public static class ListVmwareVmResourceSpecExtensions
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
            this List<VmwareVmResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VmwareVmResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmResourceSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVmResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types