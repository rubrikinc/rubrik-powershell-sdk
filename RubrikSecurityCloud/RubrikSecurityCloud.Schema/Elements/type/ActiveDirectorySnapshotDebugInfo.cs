// ActiveDirectorySnapshotDebugInfo.cs
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
    #region ActiveDirectorySnapshotDebugInfo
    public class ActiveDirectorySnapshotDebugInfo: BaseType
    {
        #region members

        //      C# -> System.String? BackupJobInstanceId
        // GraphQL -> backupJobInstanceId: String (scalar)
        [JsonProperty("backupJobInstanceId")]
        public System.String? BackupJobInstanceId { get; set; }

        //      C# -> System.String? SnapshotJobInstanceId
        // GraphQL -> snapshotJobInstanceId: String (scalar)
        [JsonProperty("snapshotJobInstanceId")]
        public System.String? SnapshotJobInstanceId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectorySnapshotDebugInfo";
    }

    public ActiveDirectorySnapshotDebugInfo Set(
        System.String? BackupJobInstanceId = null,
        System.String? SnapshotJobInstanceId = null
    ) 
    {
        if ( BackupJobInstanceId != null ) {
            this.BackupJobInstanceId = BackupJobInstanceId;
        }
        if ( SnapshotJobInstanceId != null ) {
            this.SnapshotJobInstanceId = SnapshotJobInstanceId;
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
        //      C# -> System.String? BackupJobInstanceId
        // GraphQL -> backupJobInstanceId: String (scalar)
        if (this.BackupJobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupJobInstanceId\n" ;
            } else {
                s += ind + "backupJobInstanceId\n" ;
            }
        }
        //      C# -> System.String? SnapshotJobInstanceId
        // GraphQL -> snapshotJobInstanceId: String (scalar)
        if (this.SnapshotJobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotJobInstanceId\n" ;
            } else {
                s += ind + "snapshotJobInstanceId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? BackupJobInstanceId
        // GraphQL -> backupJobInstanceId: String (scalar)
        if (ec.Includes("backupJobInstanceId",true))
        {
            if(this.BackupJobInstanceId == null) {

                this.BackupJobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.BackupJobInstanceId != null && ec.Excludes("backupJobInstanceId",true))
        {
            this.BackupJobInstanceId = null;
        }
        //      C# -> System.String? SnapshotJobInstanceId
        // GraphQL -> snapshotJobInstanceId: String (scalar)
        if (ec.Includes("snapshotJobInstanceId",true))
        {
            if(this.SnapshotJobInstanceId == null) {

                this.SnapshotJobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotJobInstanceId != null && ec.Excludes("snapshotJobInstanceId",true))
        {
            this.SnapshotJobInstanceId = null;
        }
    }


    #endregion

    } // class ActiveDirectorySnapshotDebugInfo
    
    #endregion

    public static class ListActiveDirectorySnapshotDebugInfoExtensions
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
            this List<ActiveDirectorySnapshotDebugInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectorySnapshotDebugInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectorySnapshotDebugInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectorySnapshotDebugInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectorySnapshotDebugInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types