// O365PdlAndWorkloadPair.cs
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
    #region O365PdlAndWorkloadPair
    public class O365PdlAndWorkloadPair: IFragment
    {
        #region members
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        [JsonProperty("pdl")]
        public System.String? Pdl { get; set; }

        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        [JsonProperty("workload")]
        public WorkloadLevelHierarchy? Workload { get; set; }

        #endregion

    #region methods

    public O365PdlAndWorkloadPair Set(
        System.String? Pdl = null,
        WorkloadLevelHierarchy? Workload = null
    ) 
    {
        if ( Pdl != null ) {
            this.Pdl = Pdl;
        }
        if ( Workload != null ) {
            this.Workload = Workload;
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
            //      C# -> System.String? Pdl
            // GraphQL -> pdl: String! (scalar)
            if (this.Pdl != null)
            {
                 s += ind + "pdl\n";

            }
            //      C# -> WorkloadLevelHierarchy? Workload
            // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
            if (this.Workload != null)
            {
                 s += ind + "workload\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Pdl
            // GraphQL -> pdl: String! (scalar)
            if (this.Pdl == null && Exploration.Includes(parent + ".pdl$"))
            {
                this.Pdl = new System.String("FETCH");
            }
            //      C# -> WorkloadLevelHierarchy? Workload
            // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
            if (this.Workload == null && Exploration.Includes(parent + ".workload$"))
            {
                this.Workload = new WorkloadLevelHierarchy();
            }
        }


    #endregion

    } // class O365PdlAndWorkloadPair
    #endregion

    public static class ListO365PdlAndWorkloadPairExtensions
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
            this List<O365PdlAndWorkloadPair> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365PdlAndWorkloadPair> list, 
            String parent = "")
        {
            var item = new O365PdlAndWorkloadPair();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types