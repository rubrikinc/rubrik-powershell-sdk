// BackupWindowSpec.cs
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
    #region BackupWindowSpec
    public class BackupWindowSpec: BaseType
    {
        #region members

        //      C# -> System.Boolean? TerminateBackupsExceedingBackupWindow
        // GraphQL -> terminateBackupsExceedingBackupWindow: Boolean! (scalar)
        [JsonProperty("terminateBackupsExceedingBackupWindow")]
        public System.Boolean? TerminateBackupsExceedingBackupWindow { get; set; }

        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        [JsonProperty("backupWindows")]
        public List<BackupWindow>? BackupWindows { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupWindowSpec";
    }

    public BackupWindowSpec Set(
        System.Boolean? TerminateBackupsExceedingBackupWindow = null,
        List<BackupWindow>? BackupWindows = null
    ) 
    {
        if ( TerminateBackupsExceedingBackupWindow != null ) {
            this.TerminateBackupsExceedingBackupWindow = TerminateBackupsExceedingBackupWindow;
        }
        if ( BackupWindows != null ) {
            this.BackupWindows = BackupWindows;
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
        //      C# -> System.Boolean? TerminateBackupsExceedingBackupWindow
        // GraphQL -> terminateBackupsExceedingBackupWindow: Boolean! (scalar)
        if (this.TerminateBackupsExceedingBackupWindow != null) {
            if (conf.Flat) {
                s += conf.Prefix + "terminateBackupsExceedingBackupWindow\n" ;
            } else {
                s += ind + "terminateBackupsExceedingBackupWindow\n" ;
            }
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows != null) {
            var fspec = this.BackupWindows.AsFieldSpec(conf.Child("backupWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupWindows" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? TerminateBackupsExceedingBackupWindow
        // GraphQL -> terminateBackupsExceedingBackupWindow: Boolean! (scalar)
        if (ec.Includes("terminateBackupsExceedingBackupWindow",true))
        {
            if(this.TerminateBackupsExceedingBackupWindow == null) {

                this.TerminateBackupsExceedingBackupWindow = true;

            } else {


            }
        }
        else if (this.TerminateBackupsExceedingBackupWindow != null && ec.Excludes("terminateBackupsExceedingBackupWindow",true))
        {
            this.TerminateBackupsExceedingBackupWindow = null;
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (ec.Includes("backupWindows",false))
        {
            if(this.BackupWindows == null) {

                this.BackupWindows = new List<BackupWindow>();
                this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));

            } else {

                this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));

            }
        }
        else if (this.BackupWindows != null && ec.Excludes("backupWindows",false))
        {
            this.BackupWindows = null;
        }
    }


    #endregion

    } // class BackupWindowSpec
    
    #endregion

    public static class ListBackupWindowSpecExtensions
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
            this List<BackupWindowSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BackupWindowSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupWindowSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupWindowSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupWindowSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types