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
            this List<PatchDb2DatabaseReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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