// DataLocationsPerKmipServer.cs
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
    #region DataLocationsPerKmipServer
    public class DataLocationsPerKmipServer: BaseType
    {
        #region members

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: UUID! (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> System.String? CertificateName
        // GraphQL -> certificateName: String! (scalar)
        [JsonProperty("certificateName")]
        public System.String? CertificateName { get; set; }

        //      C# -> System.String? KmipServerNaturalId
        // GraphQL -> kmipServerNaturalId: String! (scalar)
        [JsonProperty("kmipServerNaturalId")]
        public System.String? KmipServerNaturalId { get; set; }

        //      C# -> DataLocationInfo? ClusterInfo
        // GraphQL -> clusterInfo: DataLocationInfo (type)
        [JsonProperty("clusterInfo")]
        public DataLocationInfo? ClusterInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataLocationsPerKmipServer";
    }

    public DataLocationsPerKmipServer Set(
        System.String? CertificateId = null,
        System.String? CertificateName = null,
        System.String? KmipServerNaturalId = null,
        DataLocationInfo? ClusterInfo = null
    ) 
    {
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( CertificateName != null ) {
            this.CertificateName = CertificateName;
        }
        if ( KmipServerNaturalId != null ) {
            this.KmipServerNaturalId = KmipServerNaturalId;
        }
        if ( ClusterInfo != null ) {
            this.ClusterInfo = ClusterInfo;
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
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: UUID! (scalar)
        if (this.CertificateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateId\n" ;
            } else {
                s += ind + "certificateId\n" ;
            }
        }
        //      C# -> System.String? CertificateName
        // GraphQL -> certificateName: String! (scalar)
        if (this.CertificateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateName\n" ;
            } else {
                s += ind + "certificateName\n" ;
            }
        }
        //      C# -> System.String? KmipServerNaturalId
        // GraphQL -> kmipServerNaturalId: String! (scalar)
        if (this.KmipServerNaturalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmipServerNaturalId\n" ;
            } else {
                s += ind + "kmipServerNaturalId\n" ;
            }
        }
        //      C# -> DataLocationInfo? ClusterInfo
        // GraphQL -> clusterInfo: DataLocationInfo (type)
        if (this.ClusterInfo != null) {
            var fspec = this.ClusterInfo.AsFieldSpec(conf.Child("clusterInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: UUID! (scalar)
        if (ec.Includes("certificateId",true))
        {
            if(this.CertificateId == null) {

                this.CertificateId = "FETCH";

            } else {


            }
        }
        else if (this.CertificateId != null && ec.Excludes("certificateId",true))
        {
            this.CertificateId = null;
        }
        //      C# -> System.String? CertificateName
        // GraphQL -> certificateName: String! (scalar)
        if (ec.Includes("certificateName",true))
        {
            if(this.CertificateName == null) {

                this.CertificateName = "FETCH";

            } else {


            }
        }
        else if (this.CertificateName != null && ec.Excludes("certificateName",true))
        {
            this.CertificateName = null;
        }
        //      C# -> System.String? KmipServerNaturalId
        // GraphQL -> kmipServerNaturalId: String! (scalar)
        if (ec.Includes("kmipServerNaturalId",true))
        {
            if(this.KmipServerNaturalId == null) {

                this.KmipServerNaturalId = "FETCH";

            } else {


            }
        }
        else if (this.KmipServerNaturalId != null && ec.Excludes("kmipServerNaturalId",true))
        {
            this.KmipServerNaturalId = null;
        }
        //      C# -> DataLocationInfo? ClusterInfo
        // GraphQL -> clusterInfo: DataLocationInfo (type)
        if (ec.Includes("clusterInfo",false))
        {
            if(this.ClusterInfo == null) {

                this.ClusterInfo = new DataLocationInfo();
                this.ClusterInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterInfo"));

            } else {

                this.ClusterInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterInfo"));

            }
        }
        else if (this.ClusterInfo != null && ec.Excludes("clusterInfo",false))
        {
            this.ClusterInfo = null;
        }
    }


    #endregion

    } // class DataLocationsPerKmipServer
    
    #endregion

    public static class ListDataLocationsPerKmipServerExtensions
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
            this List<DataLocationsPerKmipServer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataLocationsPerKmipServer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataLocationsPerKmipServer> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataLocationsPerKmipServer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataLocationsPerKmipServer> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types