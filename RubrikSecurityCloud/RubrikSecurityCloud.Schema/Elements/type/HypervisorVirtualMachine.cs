// HypervisorVirtualMachine.cs
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
    #region HypervisorVirtualMachine
    public class HypervisorVirtualMachine: BaseType
    {
        #region members

        //      C# -> SlaAssignmentType? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentType! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentType? SlaAssignment { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? HypervisorVmId
        // GraphQL -> hypervisorVmId: UUID! (scalar)
        [JsonProperty("hypervisorVmId")]
        public System.String? HypervisorVmId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> HypervisorSlaDomainInfo? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: HypervisorSlaDomainInfo (type)
        [JsonProperty("effectiveSlaDomain")]
        public HypervisorSlaDomainInfo? EffectiveSlaDomain { get; set; }

        //      C# -> HypervisorVirtualMachineDetails? HypervisorVmDetails
        // GraphQL -> hypervisorVmDetails: HypervisorVirtualMachineDetails (type)
        [JsonProperty("hypervisorVmDetails")]
        public HypervisorVirtualMachineDetails? HypervisorVmDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervisorVirtualMachine";
    }

    public HypervisorVirtualMachine Set(
        SlaAssignmentType? SlaAssignment = null,
        System.String? Fid = null,
        System.String? HypervisorVmId = null,
        System.String? Name = null,
        System.String? PrimaryClusterUuid = null,
        HypervisorSlaDomainInfo? EffectiveSlaDomain = null,
        HypervisorVirtualMachineDetails? HypervisorVmDetails = null
    ) 
    {
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( HypervisorVmId != null ) {
            this.HypervisorVmId = HypervisorVmId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( HypervisorVmDetails != null ) {
            this.HypervisorVmDetails = HypervisorVmDetails;
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
        //      C# -> SlaAssignmentType? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentType! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.String? HypervisorVmId
        // GraphQL -> hypervisorVmId: UUID! (scalar)
        if (this.HypervisorVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hypervisorVmId\n" ;
            } else {
                s += ind + "hypervisorVmId\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (this.PrimaryClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterUuid\n" ;
            } else {
                s += ind + "primaryClusterUuid\n" ;
            }
        }
        //      C# -> HypervisorSlaDomainInfo? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: HypervisorSlaDomainInfo (type)
        if (this.EffectiveSlaDomain != null) {
            var fspec = this.EffectiveSlaDomain.AsFieldSpec(conf.Child("effectiveSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HypervisorVirtualMachineDetails? HypervisorVmDetails
        // GraphQL -> hypervisorVmDetails: HypervisorVirtualMachineDetails (type)
        if (this.HypervisorVmDetails != null) {
            var fspec = this.HypervisorVmDetails.AsFieldSpec(conf.Child("hypervisorVmDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervisorVmDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SlaAssignmentType? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentType! (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignmentType();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.String? HypervisorVmId
        // GraphQL -> hypervisorVmId: UUID! (scalar)
        if (ec.Includes("hypervisorVmId",true))
        {
            if(this.HypervisorVmId == null) {

                this.HypervisorVmId = "FETCH";

            } else {


            }
        }
        else if (this.HypervisorVmId != null && ec.Excludes("hypervisorVmId",true))
        {
            this.HypervisorVmId = null;
        }
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
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (ec.Includes("primaryClusterUuid",true))
        {
            if(this.PrimaryClusterUuid == null) {

                this.PrimaryClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterUuid != null && ec.Excludes("primaryClusterUuid",true))
        {
            this.PrimaryClusterUuid = null;
        }
        //      C# -> HypervisorSlaDomainInfo? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: HypervisorSlaDomainInfo (type)
        if (ec.Includes("effectiveSlaDomain",false))
        {
            if(this.EffectiveSlaDomain == null) {

                this.EffectiveSlaDomain = new HypervisorSlaDomainInfo();
                this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));

            } else {

                this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> HypervisorVirtualMachineDetails? HypervisorVmDetails
        // GraphQL -> hypervisorVmDetails: HypervisorVirtualMachineDetails (type)
        if (ec.Includes("hypervisorVmDetails",false))
        {
            if(this.HypervisorVmDetails == null) {

                this.HypervisorVmDetails = new HypervisorVirtualMachineDetails();
                this.HypervisorVmDetails.ApplyExploratoryFieldSpec(ec.NewChild("hypervisorVmDetails"));

            } else {

                this.HypervisorVmDetails.ApplyExploratoryFieldSpec(ec.NewChild("hypervisorVmDetails"));

            }
        }
        else if (this.HypervisorVmDetails != null && ec.Excludes("hypervisorVmDetails",false))
        {
            this.HypervisorVmDetails = null;
        }
    }


    #endregion

    } // class HypervisorVirtualMachine
    
    #endregion

    public static class ListHypervisorVirtualMachineExtensions
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
            this List<HypervisorVirtualMachine> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervisorVirtualMachine> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervisorVirtualMachine> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervisorVirtualMachine());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervisorVirtualMachine> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types