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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region VmAppConsistentSpecsInternal
    public class VmAppConsistentSpecsInternal: BaseType
    {
        #region members

        //      C# -> CloudNativeRbaStatusType? RbaStatus
        // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
        [JsonProperty("rbaStatus")]
        public CloudNativeRbaStatusType? RbaStatus { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmAppConsistentSpecsInternal";
    }

    public VmAppConsistentSpecsInternal Set(
        CloudNativeRbaStatusType? RbaStatus = null,
        System.Boolean? CancelBackupIfPreScriptFails = null,
        System.Int32? PostScriptTimeoutInSeconds = null,
        System.String? PostSnapshotScriptPath = null,
        System.Int32? PreScriptTimeoutInSeconds = null,
        System.String? PreSnapshotScriptPath = null
    ) 
    {
        if ( RbaStatus != null ) {
            this.RbaStatus = RbaStatus;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CloudNativeRbaStatusType? RbaStatus
        // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
        if (this.RbaStatus != null) {
            s += ind + "rbaStatus\n" ;
        }
        //      C# -> System.Boolean? CancelBackupIfPreScriptFails
        // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
        if (this.CancelBackupIfPreScriptFails != null) {
            s += ind + "cancelBackupIfPreScriptFails\n" ;
        }
        //      C# -> System.Int32? PostScriptTimeoutInSeconds
        // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
        if (this.PostScriptTimeoutInSeconds != null) {
            s += ind + "postScriptTimeoutInSeconds\n" ;
        }
        //      C# -> System.String? PostSnapshotScriptPath
        // GraphQL -> postSnapshotScriptPath: String! (scalar)
        if (this.PostSnapshotScriptPath != null) {
            s += ind + "postSnapshotScriptPath\n" ;
        }
        //      C# -> System.Int32? PreScriptTimeoutInSeconds
        // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
        if (this.PreScriptTimeoutInSeconds != null) {
            s += ind + "preScriptTimeoutInSeconds\n" ;
        }
        //      C# -> System.String? PreSnapshotScriptPath
        // GraphQL -> preSnapshotScriptPath: String! (scalar)
        if (this.PreSnapshotScriptPath != null) {
            s += ind + "preSnapshotScriptPath\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudNativeRbaStatusType? RbaStatus
        // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
        if (this.RbaStatus == null && Exploration.Includes(parent + ".rbaStatus", true))
        {
            this.RbaStatus = new CloudNativeRbaStatusType();
        }
        //      C# -> System.Boolean? CancelBackupIfPreScriptFails
        // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
        if (this.CancelBackupIfPreScriptFails == null && Exploration.Includes(parent + ".cancelBackupIfPreScriptFails", true))
        {
            this.CancelBackupIfPreScriptFails = true;
        }
        //      C# -> System.Int32? PostScriptTimeoutInSeconds
        // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
        if (this.PostScriptTimeoutInSeconds == null && Exploration.Includes(parent + ".postScriptTimeoutInSeconds", true))
        {
            this.PostScriptTimeoutInSeconds = Int32.MinValue;
        }
        //      C# -> System.String? PostSnapshotScriptPath
        // GraphQL -> postSnapshotScriptPath: String! (scalar)
        if (this.PostSnapshotScriptPath == null && Exploration.Includes(parent + ".postSnapshotScriptPath", true))
        {
            this.PostSnapshotScriptPath = "FETCH";
        }
        //      C# -> System.Int32? PreScriptTimeoutInSeconds
        // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
        if (this.PreScriptTimeoutInSeconds == null && Exploration.Includes(parent + ".preScriptTimeoutInSeconds", true))
        {
            this.PreScriptTimeoutInSeconds = Int32.MinValue;
        }
        //      C# -> System.String? PreSnapshotScriptPath
        // GraphQL -> preSnapshotScriptPath: String! (scalar)
        if (this.PreSnapshotScriptPath == null && Exploration.Includes(parent + ".preSnapshotScriptPath", true))
        {
            this.PreSnapshotScriptPath = "FETCH";
        }
    }


    #endregion

    } // class VmAppConsistentSpecsInternal
    
    #endregion

    public static class ListVmAppConsistentSpecsInternalExtensions
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
            this List<VmAppConsistentSpecsInternal> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmAppConsistentSpecsInternal> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmAppConsistentSpecsInternal());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types