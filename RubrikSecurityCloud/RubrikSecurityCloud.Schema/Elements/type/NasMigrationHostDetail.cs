// NasMigrationHostDetail.cs
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
    #region NasMigrationHostDetail
    public class NasMigrationHostDetail: BaseType
    {
        #region members

        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String! (scalar)
        [JsonProperty("hostCdmId")]
        public System.String? HostCdmId { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String! (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? MappedDataSourceCdmId
        // GraphQL -> mappedDataSourceCdmId: String! (scalar)
        [JsonProperty("mappedDataSourceCdmId")]
        public System.String? MappedDataSourceCdmId { get; set; }

        //      C# -> System.String? MappedDataSourceFid
        // GraphQL -> mappedDataSourceFid: String! (scalar)
        [JsonProperty("mappedDataSourceFid")]
        public System.String? MappedDataSourceFid { get; set; }

        //      C# -> System.String? MappedDataSourceName
        // GraphQL -> mappedDataSourceName: String! (scalar)
        [JsonProperty("mappedDataSourceName")]
        public System.String? MappedDataSourceName { get; set; }

        //      C# -> System.String? MappedDataSourceType
        // GraphQL -> mappedDataSourceType: String! (scalar)
        [JsonProperty("mappedDataSourceType")]
        public System.String? MappedDataSourceType { get; set; }

        //      C# -> List<NasMigrationShareDetail>? Shares
        // GraphQL -> shares: [NasMigrationShareDetail!]! (type)
        [JsonProperty("shares")]
        public List<NasMigrationShareDetail>? Shares { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasMigrationHostDetail";
    }

    public NasMigrationHostDetail Set(
        System.String? HostCdmId = null,
        System.String? HostFid = null,
        System.String? Hostname = null,
        System.String? MappedDataSourceCdmId = null,
        System.String? MappedDataSourceFid = null,
        System.String? MappedDataSourceName = null,
        System.String? MappedDataSourceType = null,
        List<NasMigrationShareDetail>? Shares = null
    ) 
    {
        if ( HostCdmId != null ) {
            this.HostCdmId = HostCdmId;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( MappedDataSourceCdmId != null ) {
            this.MappedDataSourceCdmId = MappedDataSourceCdmId;
        }
        if ( MappedDataSourceFid != null ) {
            this.MappedDataSourceFid = MappedDataSourceFid;
        }
        if ( MappedDataSourceName != null ) {
            this.MappedDataSourceName = MappedDataSourceName;
        }
        if ( MappedDataSourceType != null ) {
            this.MappedDataSourceType = MappedDataSourceType;
        }
        if ( Shares != null ) {
            this.Shares = Shares;
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
        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String! (scalar)
        if (this.HostCdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostCdmId\n" ;
            } else {
                s += ind + "hostCdmId\n" ;
            }
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String! (scalar)
        if (this.HostFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostFid\n" ;
            } else {
                s += ind + "hostFid\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.String? MappedDataSourceCdmId
        // GraphQL -> mappedDataSourceCdmId: String! (scalar)
        if (this.MappedDataSourceCdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedDataSourceCdmId\n" ;
            } else {
                s += ind + "mappedDataSourceCdmId\n" ;
            }
        }
        //      C# -> System.String? MappedDataSourceFid
        // GraphQL -> mappedDataSourceFid: String! (scalar)
        if (this.MappedDataSourceFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedDataSourceFid\n" ;
            } else {
                s += ind + "mappedDataSourceFid\n" ;
            }
        }
        //      C# -> System.String? MappedDataSourceName
        // GraphQL -> mappedDataSourceName: String! (scalar)
        if (this.MappedDataSourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedDataSourceName\n" ;
            } else {
                s += ind + "mappedDataSourceName\n" ;
            }
        }
        //      C# -> System.String? MappedDataSourceType
        // GraphQL -> mappedDataSourceType: String! (scalar)
        if (this.MappedDataSourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedDataSourceType\n" ;
            } else {
                s += ind + "mappedDataSourceType\n" ;
            }
        }
        //      C# -> List<NasMigrationShareDetail>? Shares
        // GraphQL -> shares: [NasMigrationShareDetail!]! (type)
        if (this.Shares != null) {
            var fspec = this.Shares.AsFieldSpec(conf.Child("shares"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "shares" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String! (scalar)
        if (ec.Includes("hostCdmId",true))
        {
            if(this.HostCdmId == null) {

                this.HostCdmId = "FETCH";

            } else {


            }
        }
        else if (this.HostCdmId != null && ec.Excludes("hostCdmId",true))
        {
            this.HostCdmId = null;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String! (scalar)
        if (ec.Includes("hostFid",true))
        {
            if(this.HostFid == null) {

                this.HostFid = "FETCH";

            } else {


            }
        }
        else if (this.HostFid != null && ec.Excludes("hostFid",true))
        {
            this.HostFid = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.String? MappedDataSourceCdmId
        // GraphQL -> mappedDataSourceCdmId: String! (scalar)
        if (ec.Includes("mappedDataSourceCdmId",true))
        {
            if(this.MappedDataSourceCdmId == null) {

                this.MappedDataSourceCdmId = "FETCH";

            } else {


            }
        }
        else if (this.MappedDataSourceCdmId != null && ec.Excludes("mappedDataSourceCdmId",true))
        {
            this.MappedDataSourceCdmId = null;
        }
        //      C# -> System.String? MappedDataSourceFid
        // GraphQL -> mappedDataSourceFid: String! (scalar)
        if (ec.Includes("mappedDataSourceFid",true))
        {
            if(this.MappedDataSourceFid == null) {

                this.MappedDataSourceFid = "FETCH";

            } else {


            }
        }
        else if (this.MappedDataSourceFid != null && ec.Excludes("mappedDataSourceFid",true))
        {
            this.MappedDataSourceFid = null;
        }
        //      C# -> System.String? MappedDataSourceName
        // GraphQL -> mappedDataSourceName: String! (scalar)
        if (ec.Includes("mappedDataSourceName",true))
        {
            if(this.MappedDataSourceName == null) {

                this.MappedDataSourceName = "FETCH";

            } else {


            }
        }
        else if (this.MappedDataSourceName != null && ec.Excludes("mappedDataSourceName",true))
        {
            this.MappedDataSourceName = null;
        }
        //      C# -> System.String? MappedDataSourceType
        // GraphQL -> mappedDataSourceType: String! (scalar)
        if (ec.Includes("mappedDataSourceType",true))
        {
            if(this.MappedDataSourceType == null) {

                this.MappedDataSourceType = "FETCH";

            } else {


            }
        }
        else if (this.MappedDataSourceType != null && ec.Excludes("mappedDataSourceType",true))
        {
            this.MappedDataSourceType = null;
        }
        //      C# -> List<NasMigrationShareDetail>? Shares
        // GraphQL -> shares: [NasMigrationShareDetail!]! (type)
        if (ec.Includes("shares",false))
        {
            if(this.Shares == null) {

                this.Shares = new List<NasMigrationShareDetail>();
                this.Shares.ApplyExploratoryFieldSpec(ec.NewChild("shares"));

            } else {

                this.Shares.ApplyExploratoryFieldSpec(ec.NewChild("shares"));

            }
        }
        else if (this.Shares != null && ec.Excludes("shares",false))
        {
            this.Shares = null;
        }
    }


    #endregion

    } // class NasMigrationHostDetail
    
    #endregion

    public static class ListNasMigrationHostDetailExtensions
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
            this List<NasMigrationHostDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasMigrationHostDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationHostDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationHostDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasMigrationHostDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types