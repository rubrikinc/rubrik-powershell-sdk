// PatchDb2DatabaseReply.cs
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
    #region PatchDb2DatabaseReply
    public class PatchDb2DatabaseReply: BaseType
    {
        #region members

        //      C# -> System.Int32? BackupParallelism
        // GraphQL -> backupParallelism: Int (scalar)
        [JsonProperty("backupParallelism")]
        public System.Int32? BackupParallelism { get; set; }

        //      C# -> System.Int32? BackupSessions
        // GraphQL -> backupSessions: Int (scalar)
        [JsonProperty("backupSessions")]
        public System.Int32? BackupSessions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PatchDb2DatabaseReply";
    }

    public PatchDb2DatabaseReply Set(
        System.Int32? BackupParallelism = null,
        System.Int32? BackupSessions = null
    ) 
    {
        if ( BackupParallelism != null ) {
            this.BackupParallelism = BackupParallelism;
        }
        if ( BackupSessions != null ) {
            this.BackupSessions = BackupSessions;
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
        //      C# -> System.Int32? BackupParallelism
        // GraphQL -> backupParallelism: Int (scalar)
        if (this.BackupParallelism != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupParallelism\n" ;
            } else {
                s += ind + "backupParallelism\n" ;
            }
        }
        //      C# -> System.Int32? BackupSessions
        // GraphQL -> backupSessions: Int (scalar)
        if (this.BackupSessions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupSessions\n" ;
            } else {
                s += ind + "backupSessions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? BackupParallelism
        // GraphQL -> backupParallelism: Int (scalar)
        if (ec.Includes("backupParallelism",true))
        {
            if(this.BackupParallelism == null) {

                this.BackupParallelism = Int32.MinValue;

            } else {


            }
        }
        else if (this.BackupParallelism != null && ec.Excludes("backupParallelism",true))
        {
            this.BackupParallelism = null;
        }
        //      C# -> System.Int32? BackupSessions
        // GraphQL -> backupSessions: Int (scalar)
        if (ec.Includes("backupSessions",true))
        {
            if(this.BackupSessions == null) {

                this.BackupSessions = Int32.MinValue;

            } else {


            }
        }
        else if (this.BackupSessions != null && ec.Excludes("backupSessions",true))
        {
            this.BackupSessions = null;
        }
    }


    #endregion

    } // class PatchDb2DatabaseReply
    
    #endregion

    public static class ListPatchDb2DatabaseReplyExtensions
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
            this List<PatchDb2DatabaseReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PatchDb2DatabaseReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PatchDb2DatabaseReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PatchDb2DatabaseReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PatchDb2DatabaseReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types