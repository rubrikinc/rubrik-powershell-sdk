// ProtectedObjectTypeToSla.cs
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
    #region ProtectedObjectTypeToSla
    public class ProtectedObjectTypeToSla: IFragment
    {
        #region members
        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        [JsonProperty("slaAssignment")]
        public AzureNativeResourceGroupSlaAssignment? SlaAssignment { get; set; }

        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("protectedObjectType")]
        public WorkloadLevelHierarchy? ProtectedObjectType { get; set; }

        #endregion

    #region methods

    public ProtectedObjectTypeToSla Set(
        AzureNativeResourceGroupSlaAssignment? SlaAssignment = null,
        WorkloadLevelHierarchy? ProtectedObjectType = null
    ) 
    {
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ProtectedObjectType != null ) {
            this.ProtectedObjectType = ProtectedObjectType;
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
            //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
            // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

                 s += ind + "{\n" + 
                 this.SlaAssignment.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
            // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
            if (this.ProtectedObjectType != null)
            {
                 s += ind + "protectedObjectType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
            // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment"))
            {
                this.SlaAssignment = new AzureNativeResourceGroupSlaAssignment();
                this.SlaAssignment.ApplyExploratoryFragment(parent + ".slaAssignment");
            }
            //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
            // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
            if (this.ProtectedObjectType == null && Exploration.Includes(parent + ".protectedObjectType$"))
            {
                this.ProtectedObjectType = new WorkloadLevelHierarchy();
            }
        }


    #endregion

    } // class ProtectedObjectTypeToSla
    #endregion

    public static class ListProtectedObjectTypeToSlaExtensions
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
            this List<ProtectedObjectTypeToSla> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ProtectedObjectTypeToSla> list, 
            String parent = "")
        {
            var item = new ProtectedObjectTypeToSla();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types