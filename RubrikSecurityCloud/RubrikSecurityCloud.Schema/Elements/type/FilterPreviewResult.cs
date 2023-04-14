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

namespace Rubrik.SecurityCloud.Types
{
    #region FilterPreviewResult
    public class FilterPreviewResult: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? FilterCondition
            // GraphQL -> filterCondition: String! (scalar)
            if (this.FilterCondition != null)
            {
                 s += ind + "filterCondition\n";

            }
            //      C# -> VirtualMachineSummary? VirtualMachineSummary
            // GraphQL -> virtualMachineSummary: VirtualMachineSummary (type)
            if (this.VirtualMachineSummary != null)
            {
                 s += ind + "virtualMachineSummary\n";

                 s += ind + "{\n" + 
                 this.VirtualMachineSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FilterCondition
            // GraphQL -> filterCondition: String! (scalar)
            if (this.FilterCondition == null && Exploration.Includes(parent + ".filterCondition$"))
            {
                this.FilterCondition = new System.String("FETCH");
            }
            //      C# -> VirtualMachineSummary? VirtualMachineSummary
            // GraphQL -> virtualMachineSummary: VirtualMachineSummary (type)
            if (this.VirtualMachineSummary == null && Exploration.Includes(parent + ".virtualMachineSummary"))
            {
                this.VirtualMachineSummary = new VirtualMachineSummary();
                this.VirtualMachineSummary.ApplyExploratoryFragment(parent + ".virtualMachineSummary");
            }
        }


    #endregion

    } // class FilterPreviewResult
    #endregion

    public static class ListFilterPreviewResultExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<FilterPreviewResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilterPreviewResult> list, 
            String parent = "")
        {
            var item = new FilterPreviewResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types