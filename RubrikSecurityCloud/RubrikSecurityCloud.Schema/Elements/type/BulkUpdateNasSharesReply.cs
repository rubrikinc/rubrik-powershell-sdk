// BulkUpdateNasSharesReply.cs
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
    #region BulkUpdateNasSharesReply
    public class BulkUpdateNasSharesReply: BaseType
    {
        #region members

        //      C# -> List<AsyncRequestStatus>? RefreshNasSharesStatuses
        // GraphQL -> refreshNasSharesStatuses: [AsyncRequestStatus!]! (type)
        [JsonProperty("refreshNasSharesStatuses")]
        public List<AsyncRequestStatus>? RefreshNasSharesStatuses { get; set; }

        //      C# -> List<NasShareDetail>? ShareDetails
        // GraphQL -> shareDetails: [NasShareDetail!]! (type)
        [JsonProperty("shareDetails")]
        public List<NasShareDetail>? ShareDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkUpdateNasSharesReply";
    }

    public BulkUpdateNasSharesReply Set(
        List<AsyncRequestStatus>? RefreshNasSharesStatuses = null,
        List<NasShareDetail>? ShareDetails = null
    ) 
    {
        if ( RefreshNasSharesStatuses != null ) {
            this.RefreshNasSharesStatuses = RefreshNasSharesStatuses;
        }
        if ( ShareDetails != null ) {
            this.ShareDetails = ShareDetails;
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
        //      C# -> List<AsyncRequestStatus>? RefreshNasSharesStatuses
        // GraphQL -> refreshNasSharesStatuses: [AsyncRequestStatus!]! (type)
        if (this.RefreshNasSharesStatuses != null) {
            var fspec = this.RefreshNasSharesStatuses.AsFieldSpec(conf.Child("refreshNasSharesStatuses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "refreshNasSharesStatuses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<NasShareDetail>? ShareDetails
        // GraphQL -> shareDetails: [NasShareDetail!]! (type)
        if (this.ShareDetails != null) {
            var fspec = this.ShareDetails.AsFieldSpec(conf.Child("shareDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "shareDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AsyncRequestStatus>? RefreshNasSharesStatuses
        // GraphQL -> refreshNasSharesStatuses: [AsyncRequestStatus!]! (type)
        if (ec.Includes("refreshNasSharesStatuses",false))
        {
            if(this.RefreshNasSharesStatuses == null) {

                this.RefreshNasSharesStatuses = new List<AsyncRequestStatus>();
                this.RefreshNasSharesStatuses.ApplyExploratoryFieldSpec(ec.NewChild("refreshNasSharesStatuses"));

            } else {

                this.RefreshNasSharesStatuses.ApplyExploratoryFieldSpec(ec.NewChild("refreshNasSharesStatuses"));

            }
        }
        else if (this.RefreshNasSharesStatuses != null && ec.Excludes("refreshNasSharesStatuses",false))
        {
            this.RefreshNasSharesStatuses = null;
        }
        //      C# -> List<NasShareDetail>? ShareDetails
        // GraphQL -> shareDetails: [NasShareDetail!]! (type)
        if (ec.Includes("shareDetails",false))
        {
            if(this.ShareDetails == null) {

                this.ShareDetails = new List<NasShareDetail>();
                this.ShareDetails.ApplyExploratoryFieldSpec(ec.NewChild("shareDetails"));

            } else {

                this.ShareDetails.ApplyExploratoryFieldSpec(ec.NewChild("shareDetails"));

            }
        }
        else if (this.ShareDetails != null && ec.Excludes("shareDetails",false))
        {
            this.ShareDetails = null;
        }
    }


    #endregion

    } // class BulkUpdateNasSharesReply
    
    #endregion

    public static class ListBulkUpdateNasSharesReplyExtensions
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
            this List<BulkUpdateNasSharesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkUpdateNasSharesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkUpdateNasSharesReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkUpdateNasSharesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkUpdateNasSharesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types