// SlaIdToObjectCount.cs
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
    #region SlaIdToObjectCount
    public class SlaIdToObjectCount: IFragment
    {
        #region members
        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        [JsonProperty("objectCount")]
        public System.Int32? ObjectCount { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        #endregion

    #region methods

    public SlaIdToObjectCount Set(
        System.Int32? ObjectCount = null,
        System.String? SlaId = null
    ) 
    {
        if ( ObjectCount != null ) {
            this.ObjectCount = ObjectCount;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
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
            //      C# -> System.Int32? ObjectCount
            // GraphQL -> objectCount: Int! (scalar)
            if (this.ObjectCount != null)
            {
                 s += ind + "objectCount\n";

            }
            //      C# -> System.String? SlaId
            // GraphQL -> slaId: String! (scalar)
            if (this.SlaId != null)
            {
                 s += ind + "slaId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? ObjectCount
            // GraphQL -> objectCount: Int! (scalar)
            if (this.ObjectCount == null && Exploration.Includes(parent + ".objectCount$"))
            {
                this.ObjectCount = new System.Int32();
            }
            //      C# -> System.String? SlaId
            // GraphQL -> slaId: String! (scalar)
            if (this.SlaId == null && Exploration.Includes(parent + ".slaId$"))
            {
                this.SlaId = new System.String("FETCH");
            }
        }


    #endregion

    } // class SlaIdToObjectCount
    #endregion

    public static class ListSlaIdToObjectCountExtensions
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
            this List<SlaIdToObjectCount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaIdToObjectCount> list, 
            String parent = "")
        {
            var item = new SlaIdToObjectCount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types