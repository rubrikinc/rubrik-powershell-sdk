// PerLocationMigrationInfo.cs
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
    #region PerLocationMigrationInfo
    public class PerLocationMigrationInfo: BaseType
    {
        #region members

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? RcvBucket
        // GraphQL -> rcvBucket: String! (scalar)
        [JsonProperty("rcvBucket")]
        public System.String? RcvBucket { get; set; }

        //      C# -> DataMigratorSpecificInfoOneof? DataMigratorSpecificInfo
        // GraphQL -> dataMigratorSpecificInfo: DataMigratorSpecificInfoOneof (type)
        [JsonProperty("dataMigratorSpecificInfo")]
        public DataMigratorSpecificInfoOneof? DataMigratorSpecificInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PerLocationMigrationInfo";
    }

    public PerLocationMigrationInfo Set(
        System.String? LocationId = null,
        System.String? RcvBucket = null,
        DataMigratorSpecificInfoOneof? DataMigratorSpecificInfo = null
    ) 
    {
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( RcvBucket != null ) {
            this.RcvBucket = RcvBucket;
        }
        if ( DataMigratorSpecificInfo != null ) {
            this.DataMigratorSpecificInfo = DataMigratorSpecificInfo;
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
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? RcvBucket
        // GraphQL -> rcvBucket: String! (scalar)
        if (this.RcvBucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rcvBucket\n" ;
            } else {
                s += ind + "rcvBucket\n" ;
            }
        }
        //      C# -> DataMigratorSpecificInfoOneof? DataMigratorSpecificInfo
        // GraphQL -> dataMigratorSpecificInfo: DataMigratorSpecificInfoOneof (type)
        if (this.DataMigratorSpecificInfo != null) {
            var fspec = this.DataMigratorSpecificInfo.AsFieldSpec(conf.Child("dataMigratorSpecificInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataMigratorSpecificInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? RcvBucket
        // GraphQL -> rcvBucket: String! (scalar)
        if (ec.Includes("rcvBucket",true))
        {
            if(this.RcvBucket == null) {

                this.RcvBucket = "FETCH";

            } else {


            }
        }
        else if (this.RcvBucket != null && ec.Excludes("rcvBucket",true))
        {
            this.RcvBucket = null;
        }
        //      C# -> DataMigratorSpecificInfoOneof? DataMigratorSpecificInfo
        // GraphQL -> dataMigratorSpecificInfo: DataMigratorSpecificInfoOneof (type)
        if (ec.Includes("dataMigratorSpecificInfo",false))
        {
            if(this.DataMigratorSpecificInfo == null) {

                this.DataMigratorSpecificInfo = new DataMigratorSpecificInfoOneof();
                this.DataMigratorSpecificInfo.ApplyExploratoryFieldSpec(ec.NewChild("dataMigratorSpecificInfo"));

            } else {

                this.DataMigratorSpecificInfo.ApplyExploratoryFieldSpec(ec.NewChild("dataMigratorSpecificInfo"));

            }
        }
        else if (this.DataMigratorSpecificInfo != null && ec.Excludes("dataMigratorSpecificInfo",false))
        {
            this.DataMigratorSpecificInfo = null;
        }
    }


    #endregion

    } // class PerLocationMigrationInfo
    
    #endregion

    public static class ListPerLocationMigrationInfoExtensions
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
            this List<PerLocationMigrationInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PerLocationMigrationInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PerLocationMigrationInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PerLocationMigrationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PerLocationMigrationInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types