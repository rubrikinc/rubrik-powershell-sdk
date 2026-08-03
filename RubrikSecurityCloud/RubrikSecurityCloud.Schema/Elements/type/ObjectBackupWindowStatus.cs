// ObjectBackupWindowStatus.cs
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
    #region ObjectBackupWindowStatus
    public class ObjectBackupWindowStatus: BaseType
    {
        #region members

        //      C# -> PendingBackupWindowAssignmentStatus? PendingBackupWindowStatus
        // GraphQL -> pendingBackupWindowStatus: PendingBackupWindowAssignmentStatus! (enum)
        [JsonProperty("pendingBackupWindowStatus")]
        public PendingBackupWindowAssignmentStatus? PendingBackupWindowStatus { get; set; }

        //      C# -> BackupWindowScope? Scope
        // GraphQL -> scope: BackupWindowScope! (enum)
        [JsonProperty("scope")]
        public BackupWindowScope? Scope { get; set; }

        //      C# -> System.Boolean? IsObjectBackupWindowConfigured
        // GraphQL -> isObjectBackupWindowConfigured: Boolean! (scalar)
        [JsonProperty("isObjectBackupWindowConfigured")]
        public System.Boolean? IsObjectBackupWindowConfigured { get; set; }

        //      C# -> BackupWindowSpec? BackupWindowGroup
        // GraphQL -> backupWindowGroup: BackupWindowSpec (type)
        [JsonProperty("backupWindowGroup")]
        public BackupWindowSpec? BackupWindowGroup { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectBackupWindowStatus";
    }

    public ObjectBackupWindowStatus Set(
        PendingBackupWindowAssignmentStatus? PendingBackupWindowStatus = null,
        BackupWindowScope? Scope = null,
        System.Boolean? IsObjectBackupWindowConfigured = null,
        BackupWindowSpec? BackupWindowGroup = null
    ) 
    {
        if ( PendingBackupWindowStatus != null ) {
            this.PendingBackupWindowStatus = PendingBackupWindowStatus;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
        }
        if ( IsObjectBackupWindowConfigured != null ) {
            this.IsObjectBackupWindowConfigured = IsObjectBackupWindowConfigured;
        }
        if ( BackupWindowGroup != null ) {
            this.BackupWindowGroup = BackupWindowGroup;
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
        //      C# -> PendingBackupWindowAssignmentStatus? PendingBackupWindowStatus
        // GraphQL -> pendingBackupWindowStatus: PendingBackupWindowAssignmentStatus! (enum)
        if (this.PendingBackupWindowStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingBackupWindowStatus\n" ;
            } else {
                s += ind + "pendingBackupWindowStatus\n" ;
            }
        }
        //      C# -> BackupWindowScope? Scope
        // GraphQL -> scope: BackupWindowScope! (enum)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
            }
        }
        //      C# -> System.Boolean? IsObjectBackupWindowConfigured
        // GraphQL -> isObjectBackupWindowConfigured: Boolean! (scalar)
        if (this.IsObjectBackupWindowConfigured != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isObjectBackupWindowConfigured\n" ;
            } else {
                s += ind + "isObjectBackupWindowConfigured\n" ;
            }
        }
        //      C# -> BackupWindowSpec? BackupWindowGroup
        // GraphQL -> backupWindowGroup: BackupWindowSpec (type)
        if (this.BackupWindowGroup != null) {
            var fspec = this.BackupWindowGroup.AsFieldSpec(conf.Child("backupWindowGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupWindowGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PendingBackupWindowAssignmentStatus? PendingBackupWindowStatus
        // GraphQL -> pendingBackupWindowStatus: PendingBackupWindowAssignmentStatus! (enum)
        if (ec.Includes("pendingBackupWindowStatus",true))
        {
            if(this.PendingBackupWindowStatus == null) {

                this.PendingBackupWindowStatus = new PendingBackupWindowAssignmentStatus();

            } else {


            }
        }
        else if (this.PendingBackupWindowStatus != null && ec.Excludes("pendingBackupWindowStatus",true))
        {
            this.PendingBackupWindowStatus = null;
        }
        //      C# -> BackupWindowScope? Scope
        // GraphQL -> scope: BackupWindowScope! (enum)
        if (ec.Includes("scope",true))
        {
            if(this.Scope == null) {

                this.Scope = new BackupWindowScope();

            } else {


            }
        }
        else if (this.Scope != null && ec.Excludes("scope",true))
        {
            this.Scope = null;
        }
        //      C# -> System.Boolean? IsObjectBackupWindowConfigured
        // GraphQL -> isObjectBackupWindowConfigured: Boolean! (scalar)
        if (ec.Includes("isObjectBackupWindowConfigured",true))
        {
            if(this.IsObjectBackupWindowConfigured == null) {

                this.IsObjectBackupWindowConfigured = true;

            } else {


            }
        }
        else if (this.IsObjectBackupWindowConfigured != null && ec.Excludes("isObjectBackupWindowConfigured",true))
        {
            this.IsObjectBackupWindowConfigured = null;
        }
        //      C# -> BackupWindowSpec? BackupWindowGroup
        // GraphQL -> backupWindowGroup: BackupWindowSpec (type)
        if (ec.Includes("backupWindowGroup",false))
        {
            if(this.BackupWindowGroup == null) {

                this.BackupWindowGroup = new BackupWindowSpec();
                this.BackupWindowGroup.ApplyExploratoryFieldSpec(ec.NewChild("backupWindowGroup"));

            } else {

                this.BackupWindowGroup.ApplyExploratoryFieldSpec(ec.NewChild("backupWindowGroup"));

            }
        }
        else if (this.BackupWindowGroup != null && ec.Excludes("backupWindowGroup",false))
        {
            this.BackupWindowGroup = null;
        }
    }


    #endregion

    } // class ObjectBackupWindowStatus
    
    #endregion

    public static class ListObjectBackupWindowStatusExtensions
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
            this List<ObjectBackupWindowStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectBackupWindowStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectBackupWindowStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectBackupWindowStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectBackupWindowStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types