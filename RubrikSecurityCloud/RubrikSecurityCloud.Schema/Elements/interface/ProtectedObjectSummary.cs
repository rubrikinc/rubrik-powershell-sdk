// ProtectedObjectSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:35.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ProtectedObjectSummary
    public interface ProtectedObjectSummary: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        System.String? Name { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? EffectiveSlaOpt
        // GraphQL -> effectiveSlaOpt: String (scalar)
        [JsonProperty("effectiveSlaOpt")]
        System.String? EffectiveSlaOpt { get; set; }

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType (enum)
        [JsonProperty("objectType")]
        ManagedObjectType? ObjectType { get; set; }

        #endregion

    } // class ProtectedObjectSummary
    #endregion

    public static class ListProtectedObjectSummaryExtensions
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
            this List<ProtectedObjectSummary> list,
            int indent=0)
        {
            string fragments = "";
            foreach (ProtectedObjectSummary item in list) 
            {
                string typename = item.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);

                fragments += String.Format("... on {0}\n", typename);

                fragments += "{\n" +
                item.AsFragment(indent+1) +
                "}\n";
            }
            return fragments;
        }

        public static void ApplyExploratoryFragment(
            this List<ProtectedObjectSummary> list, 
            String parent = "")
        {
            var item = (ProtectedObjectSummary)InterfaceHelper.CreateInstanceOfFirstType(typeof(ProtectedObjectSummary));
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types