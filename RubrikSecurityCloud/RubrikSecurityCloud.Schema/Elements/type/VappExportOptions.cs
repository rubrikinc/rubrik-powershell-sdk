// VappExportOptions.cs
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
    #region VappExportOptions
    public class VappExportOptions: BaseType
    {
        #region members

        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        [JsonProperty("allChildVmsWithDefaultNetworkConnections")]
        public List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections { get; set; }

        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        [JsonProperty("availableStoragePolicies")]
        public List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies { get; set; }

        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        [JsonProperty("restorableNetworks")]
        public List<CreateVappNetworkParams>? RestorableNetworks { get; set; }

        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        [JsonProperty("targetVappNetworks")]
        public List<VappNetworkSummary>? TargetVappNetworks { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappExportOptions";
    }

    public VappExportOptions Set(
        List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections = null,
        List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies = null,
        List<CreateVappNetworkParams>? RestorableNetworks = null,
        List<VappNetworkSummary>? TargetVappNetworks = null
    ) 
    {
        if ( AllChildVmsWithDefaultNetworkConnections != null ) {
            this.AllChildVmsWithDefaultNetworkConnections = AllChildVmsWithDefaultNetworkConnections;
        }
        if ( AvailableStoragePolicies != null ) {
            this.AvailableStoragePolicies = AvailableStoragePolicies;
        }
        if ( RestorableNetworks != null ) {
            this.RestorableNetworks = RestorableNetworks;
        }
        if ( TargetVappNetworks != null ) {
            this.TargetVappNetworks = TargetVappNetworks;
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
        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        if (this.AllChildVmsWithDefaultNetworkConnections != null) {
            var fspec = this.AllChildVmsWithDefaultNetworkConnections.AsFieldSpec(conf.Child("allChildVmsWithDefaultNetworkConnections"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allChildVmsWithDefaultNetworkConnections" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (this.AvailableStoragePolicies != null) {
            var fspec = this.AvailableStoragePolicies.AsFieldSpec(conf.Child("availableStoragePolicies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availableStoragePolicies" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        if (this.RestorableNetworks != null) {
            var fspec = this.RestorableNetworks.AsFieldSpec(conf.Child("restorableNetworks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "restorableNetworks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        if (this.TargetVappNetworks != null) {
            var fspec = this.TargetVappNetworks.AsFieldSpec(conf.Child("targetVappNetworks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetVappNetworks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VappVmRestoreSpec>? AllChildVmsWithDefaultNetworkConnections
        // GraphQL -> allChildVmsWithDefaultNetworkConnections: [VappVmRestoreSpec!]! (type)
        if (ec.Includes("allChildVmsWithDefaultNetworkConnections",false))
        {
            if(this.AllChildVmsWithDefaultNetworkConnections == null) {

                this.AllChildVmsWithDefaultNetworkConnections = new List<VappVmRestoreSpec>();
                this.AllChildVmsWithDefaultNetworkConnections.ApplyExploratoryFieldSpec(ec.NewChild("allChildVmsWithDefaultNetworkConnections"));

            } else {

                this.AllChildVmsWithDefaultNetworkConnections.ApplyExploratoryFieldSpec(ec.NewChild("allChildVmsWithDefaultNetworkConnections"));

            }
        }
        else if (this.AllChildVmsWithDefaultNetworkConnections != null && ec.Excludes("allChildVmsWithDefaultNetworkConnections",false))
        {
            this.AllChildVmsWithDefaultNetworkConnections = null;
        }
        //      C# -> List<VcdOrgVdcStorageProfile>? AvailableStoragePolicies
        // GraphQL -> availableStoragePolicies: [VcdOrgVdcStorageProfile!]! (type)
        if (ec.Includes("availableStoragePolicies",false))
        {
            if(this.AvailableStoragePolicies == null) {

                this.AvailableStoragePolicies = new List<VcdOrgVdcStorageProfile>();
                this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));

            } else {

                this.AvailableStoragePolicies.ApplyExploratoryFieldSpec(ec.NewChild("availableStoragePolicies"));

            }
        }
        else if (this.AvailableStoragePolicies != null && ec.Excludes("availableStoragePolicies",false))
        {
            this.AvailableStoragePolicies = null;
        }
        //      C# -> List<CreateVappNetworkParams>? RestorableNetworks
        // GraphQL -> restorableNetworks: [CreateVappNetworkParams!]! (type)
        if (ec.Includes("restorableNetworks",false))
        {
            if(this.RestorableNetworks == null) {

                this.RestorableNetworks = new List<CreateVappNetworkParams>();
                this.RestorableNetworks.ApplyExploratoryFieldSpec(ec.NewChild("restorableNetworks"));

            } else {

                this.RestorableNetworks.ApplyExploratoryFieldSpec(ec.NewChild("restorableNetworks"));

            }
        }
        else if (this.RestorableNetworks != null && ec.Excludes("restorableNetworks",false))
        {
            this.RestorableNetworks = null;
        }
        //      C# -> List<VappNetworkSummary>? TargetVappNetworks
        // GraphQL -> targetVappNetworks: [VappNetworkSummary!]! (type)
        if (ec.Includes("targetVappNetworks",false))
        {
            if(this.TargetVappNetworks == null) {

                this.TargetVappNetworks = new List<VappNetworkSummary>();
                this.TargetVappNetworks.ApplyExploratoryFieldSpec(ec.NewChild("targetVappNetworks"));

            } else {

                this.TargetVappNetworks.ApplyExploratoryFieldSpec(ec.NewChild("targetVappNetworks"));

            }
        }
        else if (this.TargetVappNetworks != null && ec.Excludes("targetVappNetworks",false))
        {
            this.TargetVappNetworks = null;
        }
    }


    #endregion

    } // class VappExportOptions
    
    #endregion

    public static class ListVappExportOptionsExtensions
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
            this List<VappExportOptions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VappExportOptions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappExportOptions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappExportOptions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappExportOptions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types