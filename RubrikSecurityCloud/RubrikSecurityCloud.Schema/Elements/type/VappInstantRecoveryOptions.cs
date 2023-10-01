// VappInstantRecoveryOptions.cs
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
    #region VappInstantRecoveryOptions
    public class VappInstantRecoveryOptions: BaseType
    {
        #region members

        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        [JsonProperty("availableVappNetworks")]
        public List<VappNetworkSummary>? AvailableVappNetworks { get; set; }

        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        [JsonProperty("restorableVms")]
        public List<VappVmRestoreSpec>? RestorableVms { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappInstantRecoveryOptions";
    }

    public VappInstantRecoveryOptions Set(
        List<VappNetworkSummary>? AvailableVappNetworks = null,
        List<VappVmRestoreSpec>? RestorableVms = null
    ) 
    {
        if ( AvailableVappNetworks != null ) {
            this.AvailableVappNetworks = AvailableVappNetworks;
        }
        if ( RestorableVms != null ) {
            this.RestorableVms = RestorableVms;
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
        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        if (this.AvailableVappNetworks != null) {
            var fspec = this.AvailableVappNetworks.AsFieldSpec(conf.Child("availableVappNetworks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availableVappNetworks {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        if (this.RestorableVms != null) {
            var fspec = this.RestorableVms.AsFieldSpec(conf.Child("restorableVms"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "restorableVms {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        if (ec.Includes("availableVappNetworks",false))
        {
            if(this.AvailableVappNetworks == null) {

                this.AvailableVappNetworks = new List<VappNetworkSummary>();
                this.AvailableVappNetworks.ApplyExploratoryFieldSpec(ec.NewChild("availableVappNetworks"));

            } else {

                this.AvailableVappNetworks.ApplyExploratoryFieldSpec(ec.NewChild("availableVappNetworks"));

            }
        }
        else if (this.AvailableVappNetworks != null && ec.Excludes("availableVappNetworks",false))
        {
            this.AvailableVappNetworks = null;
        }
        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        if (ec.Includes("restorableVms",false))
        {
            if(this.RestorableVms == null) {

                this.RestorableVms = new List<VappVmRestoreSpec>();
                this.RestorableVms.ApplyExploratoryFieldSpec(ec.NewChild("restorableVms"));

            } else {

                this.RestorableVms.ApplyExploratoryFieldSpec(ec.NewChild("restorableVms"));

            }
        }
        else if (this.RestorableVms != null && ec.Excludes("restorableVms",false))
        {
            this.RestorableVms = null;
        }
    }


    #endregion

    } // class VappInstantRecoveryOptions
    
    #endregion

    public static class ListVappInstantRecoveryOptionsExtensions
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
            this List<VappInstantRecoveryOptions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VappInstantRecoveryOptions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappInstantRecoveryOptions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappInstantRecoveryOptions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappInstantRecoveryOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types