// FilterPreviewResult.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FilterPreviewResult
    public class FilterPreviewResult: BaseType
    {
        #region members

        //      C# -> System.String? FilterCondition
        // GraphQL -> filterCondition: String! (scalar)
        [JsonProperty("filterCondition")]
        public System.String? FilterCondition { get; set; }

        //      C# -> VirtualMachineSummary? VirtualMachineSummary
        // GraphQL -> virtualMachineSummary: VirtualMachineSummary (type)
        [JsonProperty("virtualMachineSummary")]
        public VirtualMachineSummary? VirtualMachineSummary { get; set; }


        #endregion

    #region methods

    public FilterPreviewResult Set(
        System.String? FilterCondition = null,
        VirtualMachineSummary? VirtualMachineSummary = null
    ) 
    {
        if ( FilterCondition != null ) {
            this.FilterCondition = FilterCondition;
        }
        if ( VirtualMachineSummary != null ) {
            this.VirtualMachineSummary = VirtualMachineSummary;
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
        //      C# -> System.String? FilterCondition
        // GraphQL -> filterCondition: String! (scalar)
        if (this.FilterCondition != null) {
            s += ind + "filterCondition\n" ;
        }
        //      C# -> VirtualMachineSummary? VirtualMachineSummary
        // GraphQL -> virtualMachineSummary: VirtualMachineSummary (type)
        if (this.VirtualMachineSummary != null) {
            s += ind + "virtualMachineSummary {\n" + this.VirtualMachineSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FilterCondition
        // GraphQL -> filterCondition: String! (scalar)
        if (this.FilterCondition == null && Exploration.Includes(parent + ".filterCondition", true))
        {
            this.FilterCondition = new System.String("FETCH");
        }
        //      C# -> VirtualMachineSummary? VirtualMachineSummary
        // GraphQL -> virtualMachineSummary: VirtualMachineSummary (type)
        if (this.VirtualMachineSummary == null && Exploration.Includes(parent + ".virtualMachineSummary"))
        {
            this.VirtualMachineSummary = new VirtualMachineSummary();
            this.VirtualMachineSummary.ApplyExploratoryFieldSpec(parent + ".virtualMachineSummary");
        }
    }


    #endregion

    } // class FilterPreviewResult
    
    #endregion

    public static class ListFilterPreviewResultExtensions
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
            this List<FilterPreviewResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilterPreviewResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilterPreviewResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types