// NcdFrontEndCapacity.cs
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
    #region NcdFrontEndCapacity
    public class NcdFrontEndCapacity: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveFetb
        // GraphQL -> archiveFetb: Long! (scalar)
        [JsonProperty("archiveFetb")]
        public System.Int64? ArchiveFetb { get; set; }

        //      C# -> System.Int64? BackupFetb
        // GraphQL -> backupFetb: Long! (scalar)
        [JsonProperty("backupFetb")]
        public System.Int64? BackupFetb { get; set; }

        //      C# -> System.Int64? UsageInBytes
        // GraphQL -> usageInBytes: Long! (scalar)
        [JsonProperty("usageInBytes")]
        public System.Int64? UsageInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdFrontEndCapacity";
    }

    public NcdFrontEndCapacity Set(
        System.Int64? ArchiveFetb = null,
        System.Int64? BackupFetb = null,
        System.Int64? UsageInBytes = null
    ) 
    {
        if ( ArchiveFetb != null ) {
            this.ArchiveFetb = ArchiveFetb;
        }
        if ( BackupFetb != null ) {
            this.BackupFetb = BackupFetb;
        }
        if ( UsageInBytes != null ) {
            this.UsageInBytes = UsageInBytes;
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
        //      C# -> System.Int64? ArchiveFetb
        // GraphQL -> archiveFetb: Long! (scalar)
        if (this.ArchiveFetb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveFetb\n" ;
            } else {
                s += ind + "archiveFetb\n" ;
            }
        }
        //      C# -> System.Int64? BackupFetb
        // GraphQL -> backupFetb: Long! (scalar)
        if (this.BackupFetb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupFetb\n" ;
            } else {
                s += ind + "backupFetb\n" ;
            }
        }
        //      C# -> System.Int64? UsageInBytes
        // GraphQL -> usageInBytes: Long! (scalar)
        if (this.UsageInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usageInBytes\n" ;
            } else {
                s += ind + "usageInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ArchiveFetb
        // GraphQL -> archiveFetb: Long! (scalar)
        if (ec.Includes("archiveFetb",true))
        {
            if(this.ArchiveFetb == null) {

                this.ArchiveFetb = new System.Int64();

            } else {


            }
        }
        else if (this.ArchiveFetb != null && ec.Excludes("archiveFetb",true))
        {
            this.ArchiveFetb = null;
        }
        //      C# -> System.Int64? BackupFetb
        // GraphQL -> backupFetb: Long! (scalar)
        if (ec.Includes("backupFetb",true))
        {
            if(this.BackupFetb == null) {

                this.BackupFetb = new System.Int64();

            } else {


            }
        }
        else if (this.BackupFetb != null && ec.Excludes("backupFetb",true))
        {
            this.BackupFetb = null;
        }
        //      C# -> System.Int64? UsageInBytes
        // GraphQL -> usageInBytes: Long! (scalar)
        if (ec.Includes("usageInBytes",true))
        {
            if(this.UsageInBytes == null) {

                this.UsageInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UsageInBytes != null && ec.Excludes("usageInBytes",true))
        {
            this.UsageInBytes = null;
        }
    }


    #endregion

    } // class NcdFrontEndCapacity
    
    #endregion

    public static class ListNcdFrontEndCapacityExtensions
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
            this List<NcdFrontEndCapacity> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdFrontEndCapacity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdFrontEndCapacity> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdFrontEndCapacity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdFrontEndCapacity> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types