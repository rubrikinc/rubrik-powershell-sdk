// BulkAddNasSharesReply.cs
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
    #region BulkAddNasSharesReply
    public class BulkAddNasSharesReply: BaseType
    {
        #region members

        //      C# -> System.String? NasSourceId
        // GraphQL -> nasSourceId: String! (scalar)
        [JsonProperty("nasSourceId")]
        public System.String? NasSourceId { get; set; }

        //      C# -> List<NasShareDetail>? NasShareDetails
        // GraphQL -> nasShareDetails: [NasShareDetail!]! (type)
        [JsonProperty("nasShareDetails")]
        public List<NasShareDetail>? NasShareDetails { get; set; }

        //      C# -> AsyncRequestStatus? RefreshNasSharesStatus
        // GraphQL -> refreshNasSharesStatus: AsyncRequestStatus (type)
        [JsonProperty("refreshNasSharesStatus")]
        public AsyncRequestStatus? RefreshNasSharesStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkAddNasSharesReply";
    }

    public BulkAddNasSharesReply Set(
        System.String? NasSourceId = null,
        List<NasShareDetail>? NasShareDetails = null,
        AsyncRequestStatus? RefreshNasSharesStatus = null
    ) 
    {
        if ( NasSourceId != null ) {
            this.NasSourceId = NasSourceId;
        }
        if ( NasShareDetails != null ) {
            this.NasShareDetails = NasShareDetails;
        }
        if ( RefreshNasSharesStatus != null ) {
            this.RefreshNasSharesStatus = RefreshNasSharesStatus;
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
        //      C# -> System.String? NasSourceId
        // GraphQL -> nasSourceId: String! (scalar)
        if (this.NasSourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasSourceId\n" ;
            } else {
                s += ind + "nasSourceId\n" ;
            }
        }
        //      C# -> List<NasShareDetail>? NasShareDetails
        // GraphQL -> nasShareDetails: [NasShareDetail!]! (type)
        if (this.NasShareDetails != null) {
            var fspec = this.NasShareDetails.AsFieldSpec(conf.Child("nasShareDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nasShareDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AsyncRequestStatus? RefreshNasSharesStatus
        // GraphQL -> refreshNasSharesStatus: AsyncRequestStatus (type)
        if (this.RefreshNasSharesStatus != null) {
            var fspec = this.RefreshNasSharesStatus.AsFieldSpec(conf.Child("refreshNasSharesStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "refreshNasSharesStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? NasSourceId
        // GraphQL -> nasSourceId: String! (scalar)
        if (ec.Includes("nasSourceId",true))
        {
            if(this.NasSourceId == null) {

                this.NasSourceId = "FETCH";

            } else {


            }
        }
        else if (this.NasSourceId != null && ec.Excludes("nasSourceId",true))
        {
            this.NasSourceId = null;
        }
        //      C# -> List<NasShareDetail>? NasShareDetails
        // GraphQL -> nasShareDetails: [NasShareDetail!]! (type)
        if (ec.Includes("nasShareDetails",false))
        {
            if(this.NasShareDetails == null) {

                this.NasShareDetails = new List<NasShareDetail>();
                this.NasShareDetails.ApplyExploratoryFieldSpec(ec.NewChild("nasShareDetails"));

            } else {

                this.NasShareDetails.ApplyExploratoryFieldSpec(ec.NewChild("nasShareDetails"));

            }
        }
        else if (this.NasShareDetails != null && ec.Excludes("nasShareDetails",false))
        {
            this.NasShareDetails = null;
        }
        //      C# -> AsyncRequestStatus? RefreshNasSharesStatus
        // GraphQL -> refreshNasSharesStatus: AsyncRequestStatus (type)
        if (ec.Includes("refreshNasSharesStatus",false))
        {
            if(this.RefreshNasSharesStatus == null) {

                this.RefreshNasSharesStatus = new AsyncRequestStatus();
                this.RefreshNasSharesStatus.ApplyExploratoryFieldSpec(ec.NewChild("refreshNasSharesStatus"));

            } else {

                this.RefreshNasSharesStatus.ApplyExploratoryFieldSpec(ec.NewChild("refreshNasSharesStatus"));

            }
        }
        else if (this.RefreshNasSharesStatus != null && ec.Excludes("refreshNasSharesStatus",false))
        {
            this.RefreshNasSharesStatus = null;
        }
    }


    #endregion

    } // class BulkAddNasSharesReply
    
    #endregion

    public static class ListBulkAddNasSharesReplyExtensions
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
            this List<BulkAddNasSharesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkAddNasSharesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkAddNasSharesReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkAddNasSharesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkAddNasSharesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types