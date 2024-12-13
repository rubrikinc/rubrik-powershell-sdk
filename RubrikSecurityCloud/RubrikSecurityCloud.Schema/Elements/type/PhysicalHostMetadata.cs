// PhysicalHostMetadata.cs
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
    #region PhysicalHostMetadata
    public class PhysicalHostMetadata: BaseType
    {
        #region members

        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        [JsonProperty("osType")]
        public GuestOsType? OsType { get; set; }

        //      C# -> System.String? CbtStatus
        // GraphQL -> cbtStatus: String (scalar)
        [JsonProperty("cbtStatus")]
        public System.String? CbtStatus { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.Boolean? DefaultCbt
        // GraphQL -> defaultCbt: Boolean (scalar)
        [JsonProperty("defaultCbt")]
        public System.Boolean? DefaultCbt { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? OsName
        // GraphQL -> osName: String (scalar)
        [JsonProperty("osName")]
        public System.String? OsName { get; set; }

        //      C# -> HostConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public HostConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> MssqlSddDetail? MssqlSddDetail
        // GraphQL -> mssqlSddDetail: MssqlSddDetail (type)
        [JsonProperty("mssqlSddDetail")]
        public MssqlSddDetail? MssqlSddDetail { get; set; }

        //      C# -> OracleSddDetail? OracleSddDetail
        // GraphQL -> oracleSddDetail: OracleSddDetail (type)
        [JsonProperty("oracleSddDetail")]
        public OracleSddDetail? OracleSddDetail { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PhysicalHostMetadata";
    }

    public PhysicalHostMetadata Set(
        GuestOsType? OsType = null,
        System.String? CbtStatus = null,
        System.String? CdmId = null,
        System.Boolean? DefaultCbt = null,
        List<System.String>? IpAddresses = null,
        System.Boolean? IsArchived = null,
        System.String? OsName = null,
        HostConnectionStatus? ConnectionStatus = null,
        MssqlSddDetail? MssqlSddDetail = null,
        OracleSddDetail? OracleSddDetail = null
    ) 
    {
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( CbtStatus != null ) {
            this.CbtStatus = CbtStatus;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( DefaultCbt != null ) {
            this.DefaultCbt = DefaultCbt;
        }
        if ( IpAddresses != null ) {
            this.IpAddresses = IpAddresses;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( OsName != null ) {
            this.OsName = OsName;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( MssqlSddDetail != null ) {
            this.MssqlSddDetail = MssqlSddDetail;
        }
        if ( OracleSddDetail != null ) {
            this.OracleSddDetail = OracleSddDetail;
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
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
            }
        }
        //      C# -> System.String? CbtStatus
        // GraphQL -> cbtStatus: String (scalar)
        if (this.CbtStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cbtStatus\n" ;
            } else {
                s += ind + "cbtStatus\n" ;
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.Boolean? DefaultCbt
        // GraphQL -> defaultCbt: Boolean (scalar)
        if (this.DefaultCbt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultCbt\n" ;
            } else {
                s += ind + "defaultCbt\n" ;
            }
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddresses\n" ;
            } else {
                s += ind + "ipAddresses\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.String? OsName
        // GraphQL -> osName: String (scalar)
        if (this.OsName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osName\n" ;
            } else {
                s += ind + "osName\n" ;
            }
        }
        //      C# -> HostConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlSddDetail? MssqlSddDetail
        // GraphQL -> mssqlSddDetail: MssqlSddDetail (type)
        if (this.MssqlSddDetail != null) {
            var fspec = this.MssqlSddDetail.AsFieldSpec(conf.Child("mssqlSddDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlSddDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleSddDetail? OracleSddDetail
        // GraphQL -> oracleSddDetail: OracleSddDetail (type)
        if (this.OracleSddDetail != null) {
            var fspec = this.OracleSddDetail.AsFieldSpec(conf.Child("oracleSddDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleSddDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = new GuestOsType();

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
        }
        //      C# -> System.String? CbtStatus
        // GraphQL -> cbtStatus: String (scalar)
        if (ec.Includes("cbtStatus",true))
        {
            if(this.CbtStatus == null) {

                this.CbtStatus = "FETCH";

            } else {


            }
        }
        else if (this.CbtStatus != null && ec.Excludes("cbtStatus",true))
        {
            this.CbtStatus = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.Boolean? DefaultCbt
        // GraphQL -> defaultCbt: Boolean (scalar)
        if (ec.Includes("defaultCbt",true))
        {
            if(this.DefaultCbt == null) {

                this.DefaultCbt = true;

            } else {


            }
        }
        else if (this.DefaultCbt != null && ec.Excludes("defaultCbt",true))
        {
            this.DefaultCbt = null;
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (ec.Includes("ipAddresses",true))
        {
            if(this.IpAddresses == null) {

                this.IpAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.IpAddresses != null && ec.Excludes("ipAddresses",true))
        {
            this.IpAddresses = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.String? OsName
        // GraphQL -> osName: String (scalar)
        if (ec.Includes("osName",true))
        {
            if(this.OsName == null) {

                this.OsName = "FETCH";

            } else {


            }
        }
        else if (this.OsName != null && ec.Excludes("osName",true))
        {
            this.OsName = null;
        }
        //      C# -> HostConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new HostConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> MssqlSddDetail? MssqlSddDetail
        // GraphQL -> mssqlSddDetail: MssqlSddDetail (type)
        if (ec.Includes("mssqlSddDetail",false))
        {
            if(this.MssqlSddDetail == null) {

                this.MssqlSddDetail = new MssqlSddDetail();
                this.MssqlSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSddDetail"));

            } else {

                this.MssqlSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSddDetail"));

            }
        }
        else if (this.MssqlSddDetail != null && ec.Excludes("mssqlSddDetail",false))
        {
            this.MssqlSddDetail = null;
        }
        //      C# -> OracleSddDetail? OracleSddDetail
        // GraphQL -> oracleSddDetail: OracleSddDetail (type)
        if (ec.Includes("oracleSddDetail",false))
        {
            if(this.OracleSddDetail == null) {

                this.OracleSddDetail = new OracleSddDetail();
                this.OracleSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("oracleSddDetail"));

            } else {

                this.OracleSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("oracleSddDetail"));

            }
        }
        else if (this.OracleSddDetail != null && ec.Excludes("oracleSddDetail",false))
        {
            this.OracleSddDetail = null;
        }
    }


    #endregion

    } // class PhysicalHostMetadata
    
    #endregion

    public static class ListPhysicalHostMetadataExtensions
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
            this List<PhysicalHostMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PhysicalHostMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PhysicalHostMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PhysicalHostMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PhysicalHostMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types