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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudNativeRbaStatusType? RbaStatus
        // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
        if (this.RbaStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rbaStatus\n" ;
            } else {
                s += ind + "rbaStatus\n" ;
            }
        }
        //      C# -> System.Boolean? CancelBackupIfPreScriptFails
        // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
        if (this.CancelBackupIfPreScriptFails != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cancelBackupIfPreScriptFails\n" ;
            } else {
                s += ind + "cancelBackupIfPreScriptFails\n" ;
            }
        }
        //      C# -> System.Int32? PostScriptTimeoutInSeconds
        // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
        if (this.PostScriptTimeoutInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postScriptTimeoutInSeconds\n" ;
            } else {
                s += ind + "postScriptTimeoutInSeconds\n" ;
            }
        }
        //      C# -> System.String? PostSnapshotScriptPath
        // GraphQL -> postSnapshotScriptPath: String! (scalar)
        if (this.PostSnapshotScriptPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postSnapshotScriptPath\n" ;
            } else {
                s += ind + "postSnapshotScriptPath\n" ;
            }
        }
        //      C# -> System.Int32? PreScriptTimeoutInSeconds
        // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
        if (this.PreScriptTimeoutInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preScriptTimeoutInSeconds\n" ;
            } else {
                s += ind + "preScriptTimeoutInSeconds\n" ;
            }
        }
        //      C# -> System.String? PreSnapshotScriptPath
        // GraphQL -> preSnapshotScriptPath: String! (scalar)
        if (this.PreSnapshotScriptPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preSnapshotScriptPath\n" ;
            } else {
                s += ind + "preSnapshotScriptPath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudNativeRbaStatusType? RbaStatus
        // GraphQL -> rbaStatus: CloudNativeRbaStatusType! (enum)
        if (ec.Includes("rbaStatus",true))
        {
            if(this.RbaStatus == null) {

                this.RbaStatus = new CloudNativeRbaStatusType();

            } else {


            }
        }
        else if (this.RbaStatus != null && ec.Excludes("rbaStatus",true))
        {
            this.RbaStatus = null;
        }
        //      C# -> System.Boolean? CancelBackupIfPreScriptFails
        // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
        if (ec.Includes("cancelBackupIfPreScriptFails",true))
        {
            if(this.CancelBackupIfPreScriptFails == null) {

                this.CancelBackupIfPreScriptFails = true;

            } else {


            }
        }
        else if (this.CancelBackupIfPreScriptFails != null && ec.Excludes("cancelBackupIfPreScriptFails",true))
        {
            this.CancelBackupIfPreScriptFails = null;
        }
        //      C# -> System.Int32? PostScriptTimeoutInSeconds
        // GraphQL -> postScriptTimeoutInSeconds: Int! (scalar)
        if (ec.Includes("postScriptTimeoutInSeconds",true))
        {
            if(this.PostScriptTimeoutInSeconds == null) {

                this.PostScriptTimeoutInSeconds = Int32.MinValue;

            } else {


            }
        }
        else if (this.PostScriptTimeoutInSeconds != null && ec.Excludes("postScriptTimeoutInSeconds",true))
        {
            this.PostScriptTimeoutInSeconds = null;
        }
        //      C# -> System.String? PostSnapshotScriptPath
        // GraphQL -> postSnapshotScriptPath: String! (scalar)
        if (ec.Includes("postSnapshotScriptPath",true))
        {
            if(this.PostSnapshotScriptPath == null) {

                this.PostSnapshotScriptPath = "FETCH";

            } else {


            }
        }
        else if (this.PostSnapshotScriptPath != null && ec.Excludes("postSnapshotScriptPath",true))
        {
            this.PostSnapshotScriptPath = null;
        }
        //      C# -> System.Int32? PreScriptTimeoutInSeconds
        // GraphQL -> preScriptTimeoutInSeconds: Int! (scalar)
        if (ec.Includes("preScriptTimeoutInSeconds",true))
        {
            if(this.PreScriptTimeoutInSeconds == null) {

                this.PreScriptTimeoutInSeconds = Int32.MinValue;

            } else {


            }
        }
        else if (this.PreScriptTimeoutInSeconds != null && ec.Excludes("preScriptTimeoutInSeconds",true))
        {
            this.PreScriptTimeoutInSeconds = null;
        }
        //      C# -> System.String? PreSnapshotScriptPath
        // GraphQL -> preSnapshotScriptPath: String! (scalar)
        if (ec.Includes("preSnapshotScriptPath",true))
        {
            if(this.PreSnapshotScriptPath == null) {

                this.PreSnapshotScriptPath = "FETCH";

            } else {


            }
        }
        else if (this.PreSnapshotScriptPath != null && ec.Excludes("preSnapshotScriptPath",true))
        {
            this.PreSnapshotScriptPath = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VmAppConsistentSpecsInternal> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmAppConsistentSpecsInternal> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmAppConsistentSpecsInternal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmAppConsistentSpecsInternal> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types