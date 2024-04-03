// DiskInfo.cs
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
    #region DiskInfo
    public class DiskInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        [JsonProperty("capacityBytes")]
        public System.Int64? CapacityBytes { get; set; }

        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        [JsonProperty("isResizable")]
        public System.Boolean? IsResizable { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        [JsonProperty("unallocatedBytes")]
        public System.Int64? UnallocatedBytes { get; set; }

        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        [JsonProperty("usableBytes")]
        public System.Int64? UsableBytes { get; set; }

        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        [JsonProperty("diskStatus")]
        public DiskStatus? DiskStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DiskInfo";
    }

    public DiskInfo Set(
        System.Int64? CapacityBytes = null,
        System.Boolean? IsResizable = null,
        System.String? Path = null,
        System.Int64? UnallocatedBytes = null,
        System.Int64? UsableBytes = null,
        DiskStatus? DiskStatus = null
    ) 
    {
        if ( CapacityBytes != null ) {
            this.CapacityBytes = CapacityBytes;
        }
        if ( IsResizable != null ) {
            this.IsResizable = IsResizable;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( UnallocatedBytes != null ) {
            this.UnallocatedBytes = UnallocatedBytes;
        }
        if ( UsableBytes != null ) {
            this.UsableBytes = UsableBytes;
        }
        if ( DiskStatus != null ) {
            this.DiskStatus = DiskStatus;
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
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (this.CapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityBytes\n" ;
            } else {
                s += ind + "capacityBytes\n" ;
            }
        }
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        if (this.IsResizable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isResizable\n" ;
            } else {
                s += ind + "isResizable\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (this.UnallocatedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unallocatedBytes\n" ;
            } else {
                s += ind + "unallocatedBytes\n" ;
            }
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (this.UsableBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usableBytes\n" ;
            } else {
                s += ind + "usableBytes\n" ;
            }
        }
        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        if (this.DiskStatus != null) {
            var fspec = this.DiskStatus.AsFieldSpec(conf.Child("diskStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "diskStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (ec.Includes("capacityBytes",true))
        {
            if(this.CapacityBytes == null) {

                this.CapacityBytes = new System.Int64();

            } else {


            }
        }
        else if (this.CapacityBytes != null && ec.Excludes("capacityBytes",true))
        {
            this.CapacityBytes = null;
        }
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        if (ec.Includes("isResizable",true))
        {
            if(this.IsResizable == null) {

                this.IsResizable = true;

            } else {


            }
        }
        else if (this.IsResizable != null && ec.Excludes("isResizable",true))
        {
            this.IsResizable = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (ec.Includes("unallocatedBytes",true))
        {
            if(this.UnallocatedBytes == null) {

                this.UnallocatedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UnallocatedBytes != null && ec.Excludes("unallocatedBytes",true))
        {
            this.UnallocatedBytes = null;
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (ec.Includes("usableBytes",true))
        {
            if(this.UsableBytes == null) {

                this.UsableBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UsableBytes != null && ec.Excludes("usableBytes",true))
        {
            this.UsableBytes = null;
        }
        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        if (ec.Includes("diskStatus",false))
        {
            if(this.DiskStatus == null) {

                this.DiskStatus = new DiskStatus();
                this.DiskStatus.ApplyExploratoryFieldSpec(ec.NewChild("diskStatus"));

            } else {

                this.DiskStatus.ApplyExploratoryFieldSpec(ec.NewChild("diskStatus"));

            }
        }
        else if (this.DiskStatus != null && ec.Excludes("diskStatus",false))
        {
            this.DiskStatus = null;
        }
    }


    #endregion

    } // class DiskInfo
    
    #endregion

    public static class ListDiskInfoExtensions
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
            this List<DiskInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DiskInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DiskInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DiskInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DiskInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types