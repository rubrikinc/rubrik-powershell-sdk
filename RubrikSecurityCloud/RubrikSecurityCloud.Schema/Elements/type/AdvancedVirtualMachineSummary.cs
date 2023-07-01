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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? ExcludedVmdks
        // GraphQL -> excludedVmdks: [String!]! (scalar)
        if (this.ExcludedVmdks != null) {
            s += ind + "excludedVmdks\n" ;
        }
        //      C# -> VirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
        if (this.PostSnapScript != null) {
            var fspec = this.PostSnapScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postSnapScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "preBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ExcludedVmdks
        // GraphQL -> excludedVmdks: [String!]! (scalar)
        if (this.ExcludedVmdks == null && Exploration.Includes(parent + ".excludedVmdks", true))
        {
            this.ExcludedVmdks = new List<System.String>();
        }
        //      C# -> VirtualMachineScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: VirtualMachineScriptDetail (type)
        if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript"))
        {
            this.PostBackupScript = new VirtualMachineScriptDetail();
            this.PostBackupScript.ApplyExploratoryFieldSpec(parent + ".postBackupScript");
        }
        //      C# -> VirtualMachineScriptDetail? PostSnapScript
        // GraphQL -> postSnapScript: VirtualMachineScriptDetail (type)
        if (this.PostSnapScript == null && Exploration.Includes(parent + ".postSnapScript"))
        {
            this.PostSnapScript = new VirtualMachineScriptDetail();
            this.PostSnapScript.ApplyExploratoryFieldSpec(parent + ".postSnapScript");
        }
        //      C# -> VirtualMachineScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: VirtualMachineScriptDetail (type)
        if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
        {
            this.PreBackupScript = new VirtualMachineScriptDetail();
            this.PreBackupScript.ApplyExploratoryFieldSpec(parent + ".preBackupScript");
        }
    }


    #endregion

    } // class AdvancedVirtualMachineSummary
    
    #endregion

    public static class ListAdvancedVirtualMachineSummaryExtensions
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
            this List<AdvancedVirtualMachineSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AdvancedVirtualMachineSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AdvancedVirtualMachineSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types