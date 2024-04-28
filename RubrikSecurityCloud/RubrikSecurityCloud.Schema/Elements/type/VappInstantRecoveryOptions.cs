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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<VappNetworkSummary>? AvailableVappNetworks
        // GraphQL -> availableVappNetworks: [VappNetworkSummary!]! (type)
        if (this.AvailableVappNetworks != null) {
            var fspec = this.AvailableVappNetworks.AsFieldSpec(conf.Child("availableVappNetworks"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availableVappNetworks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VappVmRestoreSpec>? RestorableVms
        // GraphQL -> restorableVms: [VappVmRestoreSpec!]! (type)
        if (this.RestorableVms != null) {
            var fspec = this.RestorableVms.AsFieldSpec(conf.Child("restorableVms"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "restorableVms" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<VappInstantRecoveryOptions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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