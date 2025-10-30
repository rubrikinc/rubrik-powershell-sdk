// GetArchivalReaderInfoResp.cs
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
    #region GetArchivalReaderInfoResp
    public class GetArchivalReaderInfoResp: BaseType
    {
        #region members

        //      C# -> List<System.String>? ActiveOwnerLocationIds
        // GraphQL -> activeOwnerLocationIds: [String!]! (scalar)
        [JsonProperty("activeOwnerLocationIds")]
        public List<System.String>? ActiveOwnerLocationIds { get; set; }

        //      C# -> List<System.String>? ActiveReaderLocationIds
        // GraphQL -> activeReaderLocationIds: [String!]! (scalar)
        [JsonProperty("activeReaderLocationIds")]
        public List<System.String>? ActiveReaderLocationIds { get; set; }

        //      C# -> ReaderRefreshStatus? ReaderRefreshStatus
        // GraphQL -> readerRefreshStatus: ReaderRefreshStatus (type)
        [JsonProperty("readerRefreshStatus")]
        public ReaderRefreshStatus? ReaderRefreshStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetArchivalReaderInfoResp";
    }

    public GetArchivalReaderInfoResp Set(
        List<System.String>? ActiveOwnerLocationIds = null,
        List<System.String>? ActiveReaderLocationIds = null,
        ReaderRefreshStatus? ReaderRefreshStatus = null
    ) 
    {
        if ( ActiveOwnerLocationIds != null ) {
            this.ActiveOwnerLocationIds = ActiveOwnerLocationIds;
        }
        if ( ActiveReaderLocationIds != null ) {
            this.ActiveReaderLocationIds = ActiveReaderLocationIds;
        }
        if ( ReaderRefreshStatus != null ) {
            this.ReaderRefreshStatus = ReaderRefreshStatus;
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
        //      C# -> List<System.String>? ActiveOwnerLocationIds
        // GraphQL -> activeOwnerLocationIds: [String!]! (scalar)
        if (this.ActiveOwnerLocationIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeOwnerLocationIds\n" ;
            } else {
                s += ind + "activeOwnerLocationIds\n" ;
            }
        }
        //      C# -> List<System.String>? ActiveReaderLocationIds
        // GraphQL -> activeReaderLocationIds: [String!]! (scalar)
        if (this.ActiveReaderLocationIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeReaderLocationIds\n" ;
            } else {
                s += ind + "activeReaderLocationIds\n" ;
            }
        }
        //      C# -> ReaderRefreshStatus? ReaderRefreshStatus
        // GraphQL -> readerRefreshStatus: ReaderRefreshStatus (type)
        if (this.ReaderRefreshStatus != null) {
            var fspec = this.ReaderRefreshStatus.AsFieldSpec(conf.Child("readerRefreshStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "readerRefreshStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ActiveOwnerLocationIds
        // GraphQL -> activeOwnerLocationIds: [String!]! (scalar)
        if (ec.Includes("activeOwnerLocationIds",true))
        {
            if(this.ActiveOwnerLocationIds == null) {

                this.ActiveOwnerLocationIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ActiveOwnerLocationIds != null && ec.Excludes("activeOwnerLocationIds",true))
        {
            this.ActiveOwnerLocationIds = null;
        }
        //      C# -> List<System.String>? ActiveReaderLocationIds
        // GraphQL -> activeReaderLocationIds: [String!]! (scalar)
        if (ec.Includes("activeReaderLocationIds",true))
        {
            if(this.ActiveReaderLocationIds == null) {

                this.ActiveReaderLocationIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ActiveReaderLocationIds != null && ec.Excludes("activeReaderLocationIds",true))
        {
            this.ActiveReaderLocationIds = null;
        }
        //      C# -> ReaderRefreshStatus? ReaderRefreshStatus
        // GraphQL -> readerRefreshStatus: ReaderRefreshStatus (type)
        if (ec.Includes("readerRefreshStatus",false))
        {
            if(this.ReaderRefreshStatus == null) {

                this.ReaderRefreshStatus = new ReaderRefreshStatus();
                this.ReaderRefreshStatus.ApplyExploratoryFieldSpec(ec.NewChild("readerRefreshStatus"));

            } else {

                this.ReaderRefreshStatus.ApplyExploratoryFieldSpec(ec.NewChild("readerRefreshStatus"));

            }
        }
        else if (this.ReaderRefreshStatus != null && ec.Excludes("readerRefreshStatus",false))
        {
            this.ReaderRefreshStatus = null;
        }
    }


    #endregion

    } // class GetArchivalReaderInfoResp
    
    #endregion

    public static class ListGetArchivalReaderInfoRespExtensions
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
            this List<GetArchivalReaderInfoResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetArchivalReaderInfoResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetArchivalReaderInfoResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetArchivalReaderInfoResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetArchivalReaderInfoResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types