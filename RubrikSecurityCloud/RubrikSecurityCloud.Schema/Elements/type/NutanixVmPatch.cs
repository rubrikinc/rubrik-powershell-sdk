// NutanixVmPatch.cs
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
    #region NutanixVmPatch
    public class NutanixVmPatch: BaseType
    {
        #region members

        //      C# -> CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!]! (scalar)
        [JsonProperty("excludedDiskIds")]
        public List<System.String>? ExcludedDiskIds { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> NutanixVirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: NutanixVirtualMachineScriptDetail (type)
        [JsonProperty("postBackupScript")]
        public NutanixVirtualMachineScriptDetail? PostBackupScript { get; set; }

        //      C# -> NutanixVirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: NutanixVirtualMachineScriptDetail (type)
        [JsonProperty("postSnapScript")]
        public NutanixVirtualMachineScriptDetail? PostSnapScript { get; set; }

        //      C# -> NutanixVirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: NutanixVirtualMachineScriptDetail (type)
        [JsonProperty("preBackupScript")]
        public NutanixVirtualMachineScriptDetail? PreBackupScript { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmPatch";
    }

    public NutanixVmPatch Set(
        CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate = null,
        System.String? ConfiguredSlaDomainId = null,
        List<System.String>? ExcludedDiskIds = null,
        System.Boolean? IsPaused = null,
        NutanixVirtualMachineScriptDetail? PostBackupScript = null,
        NutanixVirtualMachineScriptDetail? PostSnapScript = null,
        NutanixVirtualMachineScriptDetail? PreBackupScript = null
    ) 
    {
        if ( SnapshotConsistencyMandate != null ) {
            this.SnapshotConsistencyMandate = SnapshotConsistencyMandate;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ExcludedDiskIds != null ) {
            this.ExcludedDiskIds = ExcludedDiskIds;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PostSnapScript != null ) {
            this.PostSnapScript = PostSnapScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
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
        //      C# -> CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate (enum)
        if (this.SnapshotConsistencyMandate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotConsistencyMandate\n" ;
            } else {
                s += ind + "snapshotConsistencyMandate\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!]! (scalar)
        if (this.ExcludedDiskIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedDiskIds\n" ;
            } else {
                s += ind + "excludedDiskIds\n" ;
            }
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        if (this.IsPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPaused\n" ;
            } else {
                s += ind + "isPaused\n" ;
            }
        }
        //      C# -> NutanixVirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: NutanixVirtualMachineScriptDetail (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(conf.Child("postBackupScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixVirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: NutanixVirtualMachineScriptDetail (type)
        if (this.PostSnapScript != null) {
            var fspec = this.PostSnapScript.AsFieldSpec(conf.Child("postSnapScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postSnapScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixVirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: NutanixVirtualMachineScriptDetail (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(conf.Child("preBackupScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdmNutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate (enum)
        if (ec.Includes("snapshotConsistencyMandate",true))
        {
            if(this.SnapshotConsistencyMandate == null) {

                this.SnapshotConsistencyMandate = new CdmNutanixSnapshotConsistencyMandate();

            } else {


            }
        }
        else if (this.SnapshotConsistencyMandate != null && ec.Excludes("snapshotConsistencyMandate",true))
        {
            this.SnapshotConsistencyMandate = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!]! (scalar)
        if (ec.Includes("excludedDiskIds",true))
        {
            if(this.ExcludedDiskIds == null) {

                this.ExcludedDiskIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedDiskIds != null && ec.Excludes("excludedDiskIds",true))
        {
            this.ExcludedDiskIds = null;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        if (ec.Includes("isPaused",true))
        {
            if(this.IsPaused == null) {

                this.IsPaused = true;

            } else {


            }
        }
        else if (this.IsPaused != null && ec.Excludes("isPaused",true))
        {
            this.IsPaused = null;
        }
        //      C# -> NutanixVirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: NutanixVirtualMachineScriptDetail (type)
        if (ec.Includes("postBackupScript",false))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = new NutanixVirtualMachineScriptDetail();
                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            } else {

                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",false))
        {
            this.PostBackupScript = null;
        }
        //      C# -> NutanixVirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: NutanixVirtualMachineScriptDetail (type)
        if (ec.Includes("postSnapScript",false))
        {
            if(this.PostSnapScript == null) {

                this.PostSnapScript = new NutanixVirtualMachineScriptDetail();
                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            } else {

                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            }
        }
        else if (this.PostSnapScript != null && ec.Excludes("postSnapScript",false))
        {
            this.PostSnapScript = null;
        }
        //      C# -> NutanixVirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: NutanixVirtualMachineScriptDetail (type)
        if (ec.Includes("preBackupScript",false))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = new NutanixVirtualMachineScriptDetail();
                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            } else {

                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",false))
        {
            this.PreBackupScript = null;
        }
    }


    #endregion

    } // class NutanixVmPatch
    
    #endregion

    public static class ListNutanixVmPatchExtensions
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
            this List<NutanixVmPatch> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmPatch> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmPatch> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmPatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmPatch> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types