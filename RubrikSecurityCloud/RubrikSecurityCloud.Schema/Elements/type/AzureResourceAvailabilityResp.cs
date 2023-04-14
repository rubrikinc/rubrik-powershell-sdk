// AzureResourceAvailabilityResp.cs
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
    #region AzureResourceAvailabilityResp
    public class AzureResourceAvailabilityResp: IFragment
    {
        #region members
        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        [JsonProperty("available")]
        public System.Boolean? Available { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }

        #endregion

    #region methods

    public AzureResourceAvailabilityResp Set(
        System.Boolean? Available = null,
        System.String? Reason = null
    ) 
    {
        if ( Available != null ) {
            this.Available = Available;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
            //      C# -> System.Boolean? Available
            // GraphQL -> available: Boolean! (scalar)
            if (this.Available != null)
            {
                 s += ind + "available\n";

            }
            //      C# -> System.String? Reason
            // GraphQL -> reason: String! (scalar)
            if (this.Reason != null)
            {
                 s += ind + "reason\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? Available
            // GraphQL -> available: Boolean! (scalar)
            if (this.Available == null && Exploration.Includes(parent + ".available$"))
            {
                this.Available = new System.Boolean();
            }
            //      C# -> System.String? Reason
            // GraphQL -> reason: String! (scalar)
            if (this.Reason == null && Exploration.Includes(parent + ".reason$"))
            {
                this.Reason = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureResourceAvailabilityResp
    #endregion

    public static class ListAzureResourceAvailabilityRespExtensions
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
            this List<AzureResourceAvailabilityResp> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureResourceAvailabilityResp> list, 
            String parent = "")
        {
            var item = new AzureResourceAvailabilityResp();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types