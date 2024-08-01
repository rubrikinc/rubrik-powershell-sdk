// NasMigrationShareDetail.cs
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
    #region NasMigrationShareDetail
    public class NasMigrationShareDetail: BaseType
    {
        #region members

        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        [JsonProperty("exportPoint")]
        public System.String? ExportPoint { get; set; }

        //      C# -> System.String? HostShareCdmId
        // GraphQL -> hostShareCdmId: String! (scalar)
        [JsonProperty("hostShareCdmId")]
        public System.String? HostShareCdmId { get; set; }

        //      C# -> System.String? HostShareFid
        // GraphQL -> hostShareFid: String! (scalar)
        [JsonProperty("hostShareFid")]
        public System.String? HostShareFid { get; set; }

        //      C# -> System.String? MappedNasShareExportPoint
        // GraphQL -> mappedNasShareExportPoint: String! (scalar)
        [JsonProperty("mappedNasShareExportPoint")]
        public System.String? MappedNasShareExportPoint { get; set; }

        //      C# -> System.String? MappedNasShareFid
        // GraphQL -> mappedNasShareFid: String! (scalar)
        [JsonProperty("mappedNasShareFid")]
        public System.String? MappedNasShareFid { get; set; }

        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        [JsonProperty("shareType")]
        public System.String? ShareType { get; set; }

        //      C# -> List<NasMigrationFilesetDetail>? Filesets
        // GraphQL -> filesets: [NasMigrationFilesetDetail!]! (type)
        [JsonProperty("filesets")]
        public List<NasMigrationFilesetDetail>? Filesets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasMigrationShareDetail";
    }

    public NasMigrationShareDetail Set(
        System.String? ExportPoint = null,
        System.String? HostShareCdmId = null,
        System.String? HostShareFid = null,
        System.String? MappedNasShareExportPoint = null,
        System.String? MappedNasShareFid = null,
        System.String? ShareType = null,
        List<NasMigrationFilesetDetail>? Filesets = null
    ) 
    {
        if ( ExportPoint != null ) {
            this.ExportPoint = ExportPoint;
        }
        if ( HostShareCdmId != null ) {
            this.HostShareCdmId = HostShareCdmId;
        }
        if ( HostShareFid != null ) {
            this.HostShareFid = HostShareFid;
        }
        if ( MappedNasShareExportPoint != null ) {
            this.MappedNasShareExportPoint = MappedNasShareExportPoint;
        }
        if ( MappedNasShareFid != null ) {
            this.MappedNasShareFid = MappedNasShareFid;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( Filesets != null ) {
            this.Filesets = Filesets;
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
        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        if (this.ExportPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exportPoint\n" ;
            } else {
                s += ind + "exportPoint\n" ;
            }
        }
        //      C# -> System.String? HostShareCdmId
        // GraphQL -> hostShareCdmId: String! (scalar)
        if (this.HostShareCdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostShareCdmId\n" ;
            } else {
                s += ind + "hostShareCdmId\n" ;
            }
        }
        //      C# -> System.String? HostShareFid
        // GraphQL -> hostShareFid: String! (scalar)
        if (this.HostShareFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostShareFid\n" ;
            } else {
                s += ind + "hostShareFid\n" ;
            }
        }
        //      C# -> System.String? MappedNasShareExportPoint
        // GraphQL -> mappedNasShareExportPoint: String! (scalar)
        if (this.MappedNasShareExportPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedNasShareExportPoint\n" ;
            } else {
                s += ind + "mappedNasShareExportPoint\n" ;
            }
        }
        //      C# -> System.String? MappedNasShareFid
        // GraphQL -> mappedNasShareFid: String! (scalar)
        if (this.MappedNasShareFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedNasShareFid\n" ;
            } else {
                s += ind + "mappedNasShareFid\n" ;
            }
        }
        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        if (this.ShareType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareType\n" ;
            } else {
                s += ind + "shareType\n" ;
            }
        }
        //      C# -> List<NasMigrationFilesetDetail>? Filesets
        // GraphQL -> filesets: [NasMigrationFilesetDetail!]! (type)
        if (this.Filesets != null) {
            var fspec = this.Filesets.AsFieldSpec(conf.Child("filesets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        if (ec.Includes("exportPoint",true))
        {
            if(this.ExportPoint == null) {

                this.ExportPoint = "FETCH";

            } else {


            }
        }
        else if (this.ExportPoint != null && ec.Excludes("exportPoint",true))
        {
            this.ExportPoint = null;
        }
        //      C# -> System.String? HostShareCdmId
        // GraphQL -> hostShareCdmId: String! (scalar)
        if (ec.Includes("hostShareCdmId",true))
        {
            if(this.HostShareCdmId == null) {

                this.HostShareCdmId = "FETCH";

            } else {


            }
        }
        else if (this.HostShareCdmId != null && ec.Excludes("hostShareCdmId",true))
        {
            this.HostShareCdmId = null;
        }
        //      C# -> System.String? HostShareFid
        // GraphQL -> hostShareFid: String! (scalar)
        if (ec.Includes("hostShareFid",true))
        {
            if(this.HostShareFid == null) {

                this.HostShareFid = "FETCH";

            } else {


            }
        }
        else if (this.HostShareFid != null && ec.Excludes("hostShareFid",true))
        {
            this.HostShareFid = null;
        }
        //      C# -> System.String? MappedNasShareExportPoint
        // GraphQL -> mappedNasShareExportPoint: String! (scalar)
        if (ec.Includes("mappedNasShareExportPoint",true))
        {
            if(this.MappedNasShareExportPoint == null) {

                this.MappedNasShareExportPoint = "FETCH";

            } else {


            }
        }
        else if (this.MappedNasShareExportPoint != null && ec.Excludes("mappedNasShareExportPoint",true))
        {
            this.MappedNasShareExportPoint = null;
        }
        //      C# -> System.String? MappedNasShareFid
        // GraphQL -> mappedNasShareFid: String! (scalar)
        if (ec.Includes("mappedNasShareFid",true))
        {
            if(this.MappedNasShareFid == null) {

                this.MappedNasShareFid = "FETCH";

            } else {


            }
        }
        else if (this.MappedNasShareFid != null && ec.Excludes("mappedNasShareFid",true))
        {
            this.MappedNasShareFid = null;
        }
        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        if (ec.Includes("shareType",true))
        {
            if(this.ShareType == null) {

                this.ShareType = "FETCH";

            } else {


            }
        }
        else if (this.ShareType != null && ec.Excludes("shareType",true))
        {
            this.ShareType = null;
        }
        //      C# -> List<NasMigrationFilesetDetail>? Filesets
        // GraphQL -> filesets: [NasMigrationFilesetDetail!]! (type)
        if (ec.Includes("filesets",false))
        {
            if(this.Filesets == null) {

                this.Filesets = new List<NasMigrationFilesetDetail>();
                this.Filesets.ApplyExploratoryFieldSpec(ec.NewChild("filesets"));

            } else {

                this.Filesets.ApplyExploratoryFieldSpec(ec.NewChild("filesets"));

            }
        }
        else if (this.Filesets != null && ec.Excludes("filesets",false))
        {
            this.Filesets = null;
        }
    }


    #endregion

    } // class NasMigrationShareDetail
    
    #endregion

    public static class ListNasMigrationShareDetailExtensions
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
            this List<NasMigrationShareDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasMigrationShareDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationShareDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationShareDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasMigrationShareDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types