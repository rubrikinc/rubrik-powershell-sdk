// AdvancedVirtualMachineSummary.cs
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
    #region AdvancedVirtualMachineSummary
    public class AdvancedVirtualMachineSummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? ExcludedVmdks
        // GraphQL -> excludedVmdks: [String!]! (scalar)
        [JsonProperty("excludedVmdks")]
        public List<System.String>? ExcludedVmdks { get; set; }

        //      C# -> VirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
        [JsonProperty("postBackupScript")]
        public VirtualMachineScriptDetail? PostBackupScript { get; set; }

        //      C# -> VirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
        [JsonProperty("postSnapScript")]
        public VirtualMachineScriptDetail? PostSnapScript { get; set; }

        //      C# -> VirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
        [JsonProperty("preBackupScript")]
        public VirtualMachineScriptDetail? PreBackupScript { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdvancedVirtualMachineSummary";
    }

    public AdvancedVirtualMachineSummary Set(
        List<System.String>? ExcludedVmdks = null,
        VirtualMachineScriptDetail? PostBackupScript = null,
        VirtualMachineScriptDetail? PostSnapScript = null,
        VirtualMachineScriptDetail? PreBackupScript = null
    ) 
    {
        if ( ExcludedVmdks != null ) {
            this.ExcludedVmdks = ExcludedVmdks;
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
        //      C# -> List<System.String>? ExcludedVmdks
        // GraphQL -> excludedVmdks: [String!]! (scalar)
        if (this.ExcludedVmdks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedVmdks\n" ;
            } else {
                s += ind + "excludedVmdks\n" ;
            }
        }
        //      C# -> VirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
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
        //      C# -> VirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
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
        //      C# -> VirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
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
        //      C# -> List<System.String>? ExcludedVmdks
        // GraphQL -> excludedVmdks: [String!]! (scalar)
        if (ec.Includes("excludedVmdks",true))
        {
            if(this.ExcludedVmdks == null) {

                this.ExcludedVmdks = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedVmdks != null && ec.Excludes("excludedVmdks",true))
        {
            this.ExcludedVmdks = null;
        }
        //      C# -> VirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
        if (ec.Includes("postBackupScript",false))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = new VirtualMachineScriptDetail();
                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            } else {

                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",false))
        {
            this.PostBackupScript = null;
        }
        //      C# -> VirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
        if (ec.Includes("postSnapScript",false))
        {
            if(this.PostSnapScript == null) {

                this.PostSnapScript = new VirtualMachineScriptDetail();
                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            } else {

                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            }
        }
        else if (this.PostSnapScript != null && ec.Excludes("postSnapScript",false))
        {
            this.PostSnapScript = null;
        }
        //      C# -> VirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
        if (ec.Includes("preBackupScript",false))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = new VirtualMachineScriptDetail();
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

    } // class AdvancedVirtualMachineSummary
    
    #endregion

    public static class ListAdvancedVirtualMachineSummaryExtensions
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
            this List<AdvancedVirtualMachineSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdvancedVirtualMachineSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdvancedVirtualMachineSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdvancedVirtualMachineSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdvancedVirtualMachineSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types