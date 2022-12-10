// ReplicationToCloudLocationSpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    #region ReplicationToCloudLocationSpec
    public class ReplicationToCloudLocationSpec: IFragment
    {
        #region members
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        [JsonProperty("retentionDuration")]
        public Duration? RetentionDuration { get; set; }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        [JsonProperty("targetMapping")]
        public TargetMapping? TargetMapping { get; set; }

        #endregion

    #region methods

    public ReplicationToCloudLocationSpec Set(
        Duration? RetentionDuration = null,
        TargetMapping? TargetMapping = null
    ) 
    {
        if ( RetentionDuration != null ) {
            this.RetentionDuration = RetentionDuration;
        }
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
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
            //      C# -> Duration? RetentionDuration
            // GraphQL -> retentionDuration: Duration (type)
            if (this.RetentionDuration != null)
            {
                 s += ind + "retentionDuration\n";

                 s += ind + "{\n" + 
                 this.RetentionDuration.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TargetMapping? TargetMapping
            // GraphQL -> targetMapping: TargetMapping (type)
            if (this.TargetMapping != null)
            {
                 s += ind + "targetMapping\n";

                 s += ind + "{\n" + 
                 this.TargetMapping.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Duration? RetentionDuration
            // GraphQL -> retentionDuration: Duration (type)
            if (this.RetentionDuration == null && Exploration.Includes(parent + ".retentionDuration"))
            {
                this.RetentionDuration = new Duration();
                this.RetentionDuration.ApplyExploratoryFragment(parent + ".retentionDuration");
            }
            //      C# -> TargetMapping? TargetMapping
            // GraphQL -> targetMapping: TargetMapping (type)
            if (this.TargetMapping == null && Exploration.Includes(parent + ".targetMapping"))
            {
                this.TargetMapping = new TargetMapping();
                this.TargetMapping.ApplyExploratoryFragment(parent + ".targetMapping");
            }
        }


    #endregion

    } // class ReplicationToCloudLocationSpec
    #endregion

    public static class ListReplicationToCloudLocationSpecExtensions
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
            this List<ReplicationToCloudLocationSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationToCloudLocationSpec> list, 
            String parent = "")
        {
            var item = new ReplicationToCloudLocationSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types