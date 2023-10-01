// ClusterLicenseInfo.cs
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
    #region ClusterLicenseInfo
    public class ClusterLicenseInfo: BaseType
    {
        #region members

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        [JsonProperty("type")]
        public ClusterLicenseInfoType? Type { get; set; }

        //      C# -> DateTime? MaxTermEndDate
        // GraphQL -> maxTermEndDate: DateTime (scalar)
        [JsonProperty("maxTermEndDate")]
        public DateTime? MaxTermEndDate { get; set; }

        //      C# -> System.Single? RequestedCapacityBytes
        // GraphQL -> requestedCapacityBytes: Float! (scalar)
        [JsonProperty("requestedCapacityBytes")]
        public System.Single? RequestedCapacityBytes { get; set; }

        //      C# -> System.Single? TotalCapacityBytes
        // GraphQL -> totalCapacityBytes: Float! (scalar)
        [JsonProperty("totalCapacityBytes")]
        public System.Single? TotalCapacityBytes { get; set; }

        //      C# -> System.Single? UsableCapacityBytes
        // GraphQL -> usableCapacityBytes: Float! (scalar)
        [JsonProperty("usableCapacityBytes")]
        public System.Single? UsableCapacityBytes { get; set; }

        //      C# -> System.Single? UsedCapacityBytes
        // GraphQL -> usedCapacityBytes: Float! (scalar)
        [JsonProperty("usedCapacityBytes")]
        public System.Single? UsedCapacityBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterLicenseInfo";
    }

    public ClusterLicenseInfo Set(
        Product? Product = null,
        ClusterLicenseInfoType? Type = null,
        DateTime? MaxTermEndDate = null,
        System.Single? RequestedCapacityBytes = null,
        System.Single? TotalCapacityBytes = null,
        System.Single? UsableCapacityBytes = null,
        System.Single? UsedCapacityBytes = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( MaxTermEndDate != null ) {
            this.MaxTermEndDate = MaxTermEndDate;
        }
        if ( RequestedCapacityBytes != null ) {
            this.RequestedCapacityBytes = RequestedCapacityBytes;
        }
        if ( TotalCapacityBytes != null ) {
            this.TotalCapacityBytes = TotalCapacityBytes;
        }
        if ( UsableCapacityBytes != null ) {
            this.UsableCapacityBytes = UsableCapacityBytes;
        }
        if ( UsedCapacityBytes != null ) {
            this.UsedCapacityBytes = UsedCapacityBytes;
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
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product != null) {
            if (conf.Flat) {
                s += conf.Prefix + "product\n" ;
            } else {
                s += ind + "product\n" ;
            }
        }
        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? MaxTermEndDate
        // GraphQL -> maxTermEndDate: DateTime (scalar)
        if (this.MaxTermEndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxTermEndDate\n" ;
            } else {
                s += ind + "maxTermEndDate\n" ;
            }
        }
        //      C# -> System.Single? RequestedCapacityBytes
        // GraphQL -> requestedCapacityBytes: Float! (scalar)
        if (this.RequestedCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestedCapacityBytes\n" ;
            } else {
                s += ind + "requestedCapacityBytes\n" ;
            }
        }
        //      C# -> System.Single? TotalCapacityBytes
        // GraphQL -> totalCapacityBytes: Float! (scalar)
        if (this.TotalCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCapacityBytes\n" ;
            } else {
                s += ind + "totalCapacityBytes\n" ;
            }
        }
        //      C# -> System.Single? UsableCapacityBytes
        // GraphQL -> usableCapacityBytes: Float! (scalar)
        if (this.UsableCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usableCapacityBytes\n" ;
            } else {
                s += ind + "usableCapacityBytes\n" ;
            }
        }
        //      C# -> System.Single? UsedCapacityBytes
        // GraphQL -> usedCapacityBytes: Float! (scalar)
        if (this.UsedCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedCapacityBytes\n" ;
            } else {
                s += ind + "usedCapacityBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (ec.Includes("product",true))
        {
            if(this.Product == null) {

                this.Product = new Product();

            } else {


            }
        }
        else if (this.Product != null && ec.Excludes("product",true))
        {
            this.Product = null;
        }
        //      C# -> ClusterLicenseInfoType? Type
        // GraphQL -> type: ClusterLicenseInfoType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ClusterLicenseInfoType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? MaxTermEndDate
        // GraphQL -> maxTermEndDate: DateTime (scalar)
        if (ec.Includes("maxTermEndDate",true))
        {
            if(this.MaxTermEndDate == null) {

                this.MaxTermEndDate = new DateTime();

            } else {


            }
        }
        else if (this.MaxTermEndDate != null && ec.Excludes("maxTermEndDate",true))
        {
            this.MaxTermEndDate = null;
        }
        //      C# -> System.Single? RequestedCapacityBytes
        // GraphQL -> requestedCapacityBytes: Float! (scalar)
        if (ec.Includes("requestedCapacityBytes",true))
        {
            if(this.RequestedCapacityBytes == null) {

                this.RequestedCapacityBytes = new System.Single();

            } else {


            }
        }
        else if (this.RequestedCapacityBytes != null && ec.Excludes("requestedCapacityBytes",true))
        {
            this.RequestedCapacityBytes = null;
        }
        //      C# -> System.Single? TotalCapacityBytes
        // GraphQL -> totalCapacityBytes: Float! (scalar)
        if (ec.Includes("totalCapacityBytes",true))
        {
            if(this.TotalCapacityBytes == null) {

                this.TotalCapacityBytes = new System.Single();

            } else {


            }
        }
        else if (this.TotalCapacityBytes != null && ec.Excludes("totalCapacityBytes",true))
        {
            this.TotalCapacityBytes = null;
        }
        //      C# -> System.Single? UsableCapacityBytes
        // GraphQL -> usableCapacityBytes: Float! (scalar)
        if (ec.Includes("usableCapacityBytes",true))
        {
            if(this.UsableCapacityBytes == null) {

                this.UsableCapacityBytes = new System.Single();

            } else {


            }
        }
        else if (this.UsableCapacityBytes != null && ec.Excludes("usableCapacityBytes",true))
        {
            this.UsableCapacityBytes = null;
        }
        //      C# -> System.Single? UsedCapacityBytes
        // GraphQL -> usedCapacityBytes: Float! (scalar)
        if (ec.Includes("usedCapacityBytes",true))
        {
            if(this.UsedCapacityBytes == null) {

                this.UsedCapacityBytes = new System.Single();

            } else {


            }
        }
        else if (this.UsedCapacityBytes != null && ec.Excludes("usedCapacityBytes",true))
        {
            this.UsedCapacityBytes = null;
        }
    }


    #endregion

    } // class ClusterLicenseInfo
    
    #endregion

    public static class ListClusterLicenseInfoExtensions
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
            this List<ClusterLicenseInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterLicenseInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterLicenseInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterLicenseInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterLicenseInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types