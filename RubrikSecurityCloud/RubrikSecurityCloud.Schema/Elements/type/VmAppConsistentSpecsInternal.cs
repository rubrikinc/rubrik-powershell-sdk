// VmAppConsistentSpecsInternal.cs
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
    #region VmAppConsistentSpecsInternal
    public class VmAppConsistentSpecsInternal: IFragment
    {
        #region members
        //      C# -> System.Boolean? CancelBackupIfPreScriptFails
        // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
        [JsonProperty("cancelBackupIfPreScriptFails")]
        public System.Boolean? CancelBackupIfPreScriptFails { get; set; }

        //      C# -> System.Int32? PostScriptTimeoutInSeconds
        // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
        [JsonProperty("postScriptTimeoutInSeconds")]
        public System.Int32? PostScriptTimeoutInSeconds { get; set; }

        //      C# -> System.String? PostSnapshotScriptPath
        // GraphQL -> postSnapshotScriptPath: String! (scalar)
        [JsonProperty("postSnapshotScriptPath")]
        public System.String? PostSnapshotScriptPath { get; set; }

        //      C# -> System.Int32? PreScriptTimeoutInSeconds
        // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
        [JsonProperty("preScriptTimeoutInSeconds")]
        public System.Int32? PreScriptTimeoutInSeconds { get; set; }

        //      C# -> System.String? PreSnapshotScriptPath
        // GraphQL -> preSnapshotScriptPath: String! (scalar)
        [JsonProperty("preSnapshotScriptPath")]
        public System.String? PreSnapshotScriptPath { get; set; }

        //      C# -> CloudNativeRbaStatusType? RbaStatus
        // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
        [JsonProperty("rbaStatus")]
        public CloudNativeRbaStatusType? RbaStatus { get; set; }

        #endregion

    #region methods

    public VmAppConsistentSpecsInternal Set(
        System.Boolean? CancelBackupIfPreScriptFails = null,
        System.Int32? PostScriptTimeoutInSeconds = null,
        System.String? PostSnapshotScriptPath = null,
        System.Int32? PreScriptTimeoutInSeconds = null,
        System.String? PreSnapshotScriptPath = null,
        CloudNativeRbaStatusType? RbaStatus = null
    ) 
    {
        if ( CancelBackupIfPreScriptFails != null ) {
            this.CancelBackupIfPreScriptFails = CancelBackupIfPreScriptFails;
        }
        if ( PostScriptTimeoutInSeconds != null ) {
            this.PostScriptTimeoutInSeconds = PostScriptTimeoutInSeconds;
        }
        if ( PostSnapshotScriptPath != null ) {
            this.PostSnapshotScriptPath = PostSnapshotScriptPath;
        }
        if ( PreScriptTimeoutInSeconds != null ) {
            this.PreScriptTimeoutInSeconds = PreScriptTimeoutInSeconds;
        }
        if ( PreSnapshotScriptPath != null ) {
            this.PreSnapshotScriptPath = PreSnapshotScriptPath;
        }
        if ( RbaStatus != null ) {
            this.RbaStatus = RbaStatus;
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
            //      C# -> System.Boolean? CancelBackupIfPreScriptFails
            // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
            if (this.CancelBackupIfPreScriptFails != null)
            {
                 s += ind + "cancelBackupIfPreScriptFails\n";

            }
            //      C# -> System.Int32? PostScriptTimeoutInSeconds
            // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
            if (this.PostScriptTimeoutInSeconds != null)
            {
                 s += ind + "postScriptTimeoutInSeconds\n";

            }
            //      C# -> System.String? PostSnapshotScriptPath
            // GraphQL -> postSnapshotScriptPath: String! (scalar)
            if (this.PostSnapshotScriptPath != null)
            {
                 s += ind + "postSnapshotScriptPath\n";

            }
            //      C# -> System.Int32? PreScriptTimeoutInSeconds
            // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
            if (this.PreScriptTimeoutInSeconds != null)
            {
                 s += ind + "preScriptTimeoutInSeconds\n";

            }
            //      C# -> System.String? PreSnapshotScriptPath
            // GraphQL -> preSnapshotScriptPath: String! (scalar)
            if (this.PreSnapshotScriptPath != null)
            {
                 s += ind + "preSnapshotScriptPath\n";

            }
            //      C# -> CloudNativeRbaStatusType? RbaStatus
            // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
            if (this.RbaStatus != null)
            {
                 s += ind + "rbaStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? CancelBackupIfPreScriptFails
            // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
            if (this.CancelBackupIfPreScriptFails == null && Exploration.Includes(parent + ".cancelBackupIfPreScriptFails$"))
            {
                this.CancelBackupIfPreScriptFails = new System.Boolean();
            }
            //      C# -> System.Int32? PostScriptTimeoutInSeconds
            // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
            if (this.PostScriptTimeoutInSeconds == null && Exploration.Includes(parent + ".postScriptTimeoutInSeconds$"))
            {
                this.PostScriptTimeoutInSeconds = new System.Int32();
            }
            //      C# -> System.String? PostSnapshotScriptPath
            // GraphQL -> postSnapshotScriptPath: String! (scalar)
            if (this.PostSnapshotScriptPath == null && Exploration.Includes(parent + ".postSnapshotScriptPath$"))
            {
                this.PostSnapshotScriptPath = new System.String("FETCH");
            }
            //      C# -> System.Int32? PreScriptTimeoutInSeconds
            // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
            if (this.PreScriptTimeoutInSeconds == null && Exploration.Includes(parent + ".preScriptTimeoutInSeconds$"))
            {
                this.PreScriptTimeoutInSeconds = new System.Int32();
            }
            //      C# -> System.String? PreSnapshotScriptPath
            // GraphQL -> preSnapshotScriptPath: String! (scalar)
            if (this.PreSnapshotScriptPath == null && Exploration.Includes(parent + ".preSnapshotScriptPath$"))
            {
                this.PreSnapshotScriptPath = new System.String("FETCH");
            }
            //      C# -> CloudNativeRbaStatusType? RbaStatus
            // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
            if (this.RbaStatus == null && Exploration.Includes(parent + ".rbaStatus$"))
            {
                this.RbaStatus = new CloudNativeRbaStatusType();
            }
        }


    #endregion

    } // class VmAppConsistentSpecsInternal
    #endregion

    public static class ListVmAppConsistentSpecsInternalExtensions
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
            this List<VmAppConsistentSpecsInternal> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmAppConsistentSpecsInternal> list, 
            String parent = "")
        {
            var item = new VmAppConsistentSpecsInternal();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types