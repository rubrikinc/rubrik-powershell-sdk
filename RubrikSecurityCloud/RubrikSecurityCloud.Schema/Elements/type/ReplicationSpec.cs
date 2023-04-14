// ReplicationSpec.cs
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
    #region ReplicationSpec
    public class ReplicationSpec: IFragment
    {
        #region members
        //      C# -> SpecificReplicationSpec? SpecificReplicationSpec
        // GraphQL -> specificReplicationSpec: SpecificReplicationSpec (type)
        [JsonProperty("specificReplicationSpec")]
        public SpecificReplicationSpec? SpecificReplicationSpec { get; set; }

        //      C# -> ReplicationType? ReplicationType
        // GraphQL -> replicationType: ReplicationType! (enum)
        [JsonProperty("replicationType")]
        public ReplicationType? ReplicationType { get; set; }

        #endregion

    #region methods

    public ReplicationSpec Set(
        SpecificReplicationSpec? SpecificReplicationSpec = null,
        ReplicationType? ReplicationType = null
    ) 
    {
        if ( SpecificReplicationSpec != null ) {
            this.SpecificReplicationSpec = SpecificReplicationSpec;
        }
        if ( ReplicationType != null ) {
            this.ReplicationType = ReplicationType;
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
            //      C# -> SpecificReplicationSpec? SpecificReplicationSpec
            // GraphQL -> specificReplicationSpec: SpecificReplicationSpec (type)
            if (this.SpecificReplicationSpec != null)
            {
                 s += ind + "specificReplicationSpec\n";

                 s += ind + "{\n" + 
                 this.SpecificReplicationSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationType? ReplicationType
            // GraphQL -> replicationType: ReplicationType! (enum)
            if (this.ReplicationType != null)
            {
                 s += ind + "replicationType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> SpecificReplicationSpec? SpecificReplicationSpec
            // GraphQL -> specificReplicationSpec: SpecificReplicationSpec (type)
            if (this.SpecificReplicationSpec == null && Exploration.Includes(parent + ".specificReplicationSpec"))
            {
                this.SpecificReplicationSpec = new SpecificReplicationSpec();
                this.SpecificReplicationSpec.ApplyExploratoryFragment(parent + ".specificReplicationSpec");
            }
            //      C# -> ReplicationType? ReplicationType
            // GraphQL -> replicationType: ReplicationType! (enum)
            if (this.ReplicationType == null && Exploration.Includes(parent + ".replicationType$"))
            {
                this.ReplicationType = new ReplicationType();
            }
        }


    #endregion

    } // class ReplicationSpec
    #endregion

    public static class ListReplicationSpecExtensions
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
            this List<ReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationSpec> list, 
            String parent = "")
        {
            var item = new ReplicationSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types