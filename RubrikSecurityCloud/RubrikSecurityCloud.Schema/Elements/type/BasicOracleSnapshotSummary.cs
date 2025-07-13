// BasicOracleSnapshotSummary.cs
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
    #region BasicOracleSnapshotSummary
    public class BasicOracleSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Boolean? IsOnDemand
        // GraphQL -> isOnDemand: Boolean! (scalar)
        [JsonProperty("isOnDemand")]
        public System.Boolean? IsOnDemand { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BasicOracleSnapshotSummary";
    }

    public BasicOracleSnapshotSummary Set(
        System.String? CdmId = null,
        DateTime? Date = null,
        System.String? Fid = null,
        System.Boolean? IsOnDemand = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( IsOnDemand != null ) {
            this.IsOnDemand = IsOnDemand;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnDemand
        // GraphQL -> isOnDemand: Boolean! (scalar)
        if (this.IsOnDemand != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnDemand\n" ;
            } else {
                s += ind + "isOnDemand\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
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
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Boolean? IsOnDemand
        // GraphQL -> isOnDemand: Boolean! (scalar)
        if (ec.Includes("isOnDemand",true))
        {
            if(this.IsOnDemand == null) {

                this.IsOnDemand = true;

            } else {


            }
        }
        else if (this.IsOnDemand != null && ec.Excludes("isOnDemand",true))
        {
            this.IsOnDemand = null;
        }
    }


    #endregion

    } // class BasicOracleSnapshotSummary
    
    #endregion

    public static class ListBasicOracleSnapshotSummaryExtensions
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
            this List<BasicOracleSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BasicOracleSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BasicOracleSnapshotSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BasicOracleSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BasicOracleSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types