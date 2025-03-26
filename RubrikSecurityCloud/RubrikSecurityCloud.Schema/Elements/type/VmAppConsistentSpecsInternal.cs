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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VmAppConsistentSpecsInternal> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmAppConsistentSpecsInternal> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmAppConsistentSpecsInternal> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmAppConsistentSpecsInternal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmAppConsistentSpecsInternal> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types