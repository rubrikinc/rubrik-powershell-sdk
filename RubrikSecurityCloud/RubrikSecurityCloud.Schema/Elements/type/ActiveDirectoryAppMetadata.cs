// ActiveDirectoryAppMetadata.cs
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
    #region ActiveDirectoryAppMetadata
    public class ActiveDirectoryAppMetadata: BaseType
    {
        #region members

        //      C# -> System.String? RubrikBackupServiceDataDirPath
        // GraphQL -> rubrikBackupServiceDataDirPath: String (scalar)
        [JsonProperty("rubrikBackupServiceDataDirPath")]
        public System.String? RubrikBackupServiceDataDirPath { get; set; }

        //      C# -> WindowsDiskLayoutDetails? DiskLayoutDetailsOpt
        // GraphQL -> diskLayoutDetailsOpt: WindowsDiskLayoutDetails (type)
        [JsonProperty("diskLayoutDetailsOpt")]
        public WindowsDiskLayoutDetails? DiskLayoutDetailsOpt { get; set; }

        //      C# -> NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt
        // GraphQL -> ntdsDatabaseConsistencyOpt: NtdsDatabaseConsistency (type)
        [JsonProperty("ntdsDatabaseConsistencyOpt")]
        public NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt { get; set; }

        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        [JsonProperty("objectsCount")]
        public ActiveDirectoryObjectsCount? ObjectsCount { get; set; }

        //      C# -> OsDetails? OsDetailsOpt
        // GraphQL -> osDetailsOpt: OsDetails (type)
        [JsonProperty("osDetailsOpt")]
        public OsDetails? OsDetailsOpt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryAppMetadata";
    }

    public ActiveDirectoryAppMetadata Set(
        System.String? RubrikBackupServiceDataDirPath = null,
        WindowsDiskLayoutDetails? DiskLayoutDetailsOpt = null,
        NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt = null,
        ActiveDirectoryObjectsCount? ObjectsCount = null,
        OsDetails? OsDetailsOpt = null
    ) 
    {
        if ( RubrikBackupServiceDataDirPath != null ) {
            this.RubrikBackupServiceDataDirPath = RubrikBackupServiceDataDirPath;
        }
        if ( DiskLayoutDetailsOpt != null ) {
            this.DiskLayoutDetailsOpt = DiskLayoutDetailsOpt;
        }
        if ( NtdsDatabaseConsistencyOpt != null ) {
            this.NtdsDatabaseConsistencyOpt = NtdsDatabaseConsistencyOpt;
        }
        if ( ObjectsCount != null ) {
            this.ObjectsCount = ObjectsCount;
        }
        if ( OsDetailsOpt != null ) {
            this.OsDetailsOpt = OsDetailsOpt;
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
        //      C# -> System.String? RubrikBackupServiceDataDirPath
        // GraphQL -> rubrikBackupServiceDataDirPath: String (scalar)
        if (this.RubrikBackupServiceDataDirPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikBackupServiceDataDirPath\n" ;
            } else {
                s += ind + "rubrikBackupServiceDataDirPath\n" ;
            }
        }
        //      C# -> WindowsDiskLayoutDetails? DiskLayoutDetailsOpt
        // GraphQL -> diskLayoutDetailsOpt: WindowsDiskLayoutDetails (type)
        if (this.DiskLayoutDetailsOpt != null) {
            var fspec = this.DiskLayoutDetailsOpt.AsFieldSpec(conf.Child("diskLayoutDetailsOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "diskLayoutDetailsOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt
        // GraphQL -> ntdsDatabaseConsistencyOpt: NtdsDatabaseConsistency (type)
        if (this.NtdsDatabaseConsistencyOpt != null) {
            var fspec = this.NtdsDatabaseConsistencyOpt.AsFieldSpec(conf.Child("ntdsDatabaseConsistencyOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ntdsDatabaseConsistencyOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        if (this.ObjectsCount != null) {
            var fspec = this.ObjectsCount.AsFieldSpec(conf.Child("objectsCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectsCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OsDetails? OsDetailsOpt
        // GraphQL -> osDetailsOpt: OsDetails (type)
        if (this.OsDetailsOpt != null) {
            var fspec = this.OsDetailsOpt.AsFieldSpec(conf.Child("osDetailsOpt"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "osDetailsOpt" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? RubrikBackupServiceDataDirPath
        // GraphQL -> rubrikBackupServiceDataDirPath: String (scalar)
        if (ec.Includes("rubrikBackupServiceDataDirPath",true))
        {
            if(this.RubrikBackupServiceDataDirPath == null) {

                this.RubrikBackupServiceDataDirPath = "FETCH";

            } else {


            }
        }
        else if (this.RubrikBackupServiceDataDirPath != null && ec.Excludes("rubrikBackupServiceDataDirPath",true))
        {
            this.RubrikBackupServiceDataDirPath = null;
        }
        //      C# -> WindowsDiskLayoutDetails? DiskLayoutDetailsOpt
        // GraphQL -> diskLayoutDetailsOpt: WindowsDiskLayoutDetails (type)
        if (ec.Includes("diskLayoutDetailsOpt",false))
        {
            if(this.DiskLayoutDetailsOpt == null) {

                this.DiskLayoutDetailsOpt = new WindowsDiskLayoutDetails();
                this.DiskLayoutDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("diskLayoutDetailsOpt"));

            } else {

                this.DiskLayoutDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("diskLayoutDetailsOpt"));

            }
        }
        else if (this.DiskLayoutDetailsOpt != null && ec.Excludes("diskLayoutDetailsOpt",false))
        {
            this.DiskLayoutDetailsOpt = null;
        }
        //      C# -> NtdsDatabaseConsistency? NtdsDatabaseConsistencyOpt
        // GraphQL -> ntdsDatabaseConsistencyOpt: NtdsDatabaseConsistency (type)
        if (ec.Includes("ntdsDatabaseConsistencyOpt",false))
        {
            if(this.NtdsDatabaseConsistencyOpt == null) {

                this.NtdsDatabaseConsistencyOpt = new NtdsDatabaseConsistency();
                this.NtdsDatabaseConsistencyOpt.ApplyExploratoryFieldSpec(ec.NewChild("ntdsDatabaseConsistencyOpt"));

            } else {

                this.NtdsDatabaseConsistencyOpt.ApplyExploratoryFieldSpec(ec.NewChild("ntdsDatabaseConsistencyOpt"));

            }
        }
        else if (this.NtdsDatabaseConsistencyOpt != null && ec.Excludes("ntdsDatabaseConsistencyOpt",false))
        {
            this.NtdsDatabaseConsistencyOpt = null;
        }
        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        if (ec.Includes("objectsCount",false))
        {
            if(this.ObjectsCount == null) {

                this.ObjectsCount = new ActiveDirectoryObjectsCount();
                this.ObjectsCount.ApplyExploratoryFieldSpec(ec.NewChild("objectsCount"));

            } else {

                this.ObjectsCount.ApplyExploratoryFieldSpec(ec.NewChild("objectsCount"));

            }
        }
        else if (this.ObjectsCount != null && ec.Excludes("objectsCount",false))
        {
            this.ObjectsCount = null;
        }
        //      C# -> OsDetails? OsDetailsOpt
        // GraphQL -> osDetailsOpt: OsDetails (type)
        if (ec.Includes("osDetailsOpt",false))
        {
            if(this.OsDetailsOpt == null) {

                this.OsDetailsOpt = new OsDetails();
                this.OsDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("osDetailsOpt"));

            } else {

                this.OsDetailsOpt.ApplyExploratoryFieldSpec(ec.NewChild("osDetailsOpt"));

            }
        }
        else if (this.OsDetailsOpt != null && ec.Excludes("osDetailsOpt",false))
        {
            this.OsDetailsOpt = null;
        }
    }


    #endregion

    } // class ActiveDirectoryAppMetadata
    
    #endregion

    public static class ListActiveDirectoryAppMetadataExtensions
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
            this List<ActiveDirectoryAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types