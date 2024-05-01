// ShareExportIdPair.cs
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
    #region ShareExportIdPair
    public class ShareExportIdPair: BaseType
    {
        #region members

        //      C# -> System.Int32? ExportId
        // GraphQL -> exportId: Int! (scalar)
        [JsonProperty("exportId")]
        public System.Int32? ExportId { get; set; }

        //      C# -> System.String? Share
        // GraphQL -> share: String! (scalar)
        [JsonProperty("share")]
        public System.String? Share { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ShareExportIdPair";
    }

    public ShareExportIdPair Set(
        System.Int32? ExportId = null,
        System.String? Share = null
    ) 
    {
        if ( ExportId != null ) {
            this.ExportId = ExportId;
        }
        if ( Share != null ) {
            this.Share = Share;
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
        //      C# -> System.Int32? ExportId
        // GraphQL -> exportId: Int! (scalar)
        if (this.ExportId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exportId\n" ;
            } else {
                s += ind + "exportId\n" ;
            }
        }
        //      C# -> System.String? Share
        // GraphQL -> share: String! (scalar)
        if (this.Share != null) {
            if (conf.Flat) {
                s += conf.Prefix + "share\n" ;
            } else {
                s += ind + "share\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ExportId
        // GraphQL -> exportId: Int! (scalar)
        if (ec.Includes("exportId",true))
        {
            if(this.ExportId == null) {

                this.ExportId = Int32.MinValue;

            } else {


            }
        }
        else if (this.ExportId != null && ec.Excludes("exportId",true))
        {
            this.ExportId = null;
        }
        //      C# -> System.String? Share
        // GraphQL -> share: String! (scalar)
        if (ec.Includes("share",true))
        {
            if(this.Share == null) {

                this.Share = "FETCH";

            } else {


            }
        }
        else if (this.Share != null && ec.Excludes("share",true))
        {
            this.Share = null;
        }
    }


    #endregion

    } // class ShareExportIdPair
    
    #endregion

    public static class ListShareExportIdPairExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ShareExportIdPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ShareExportIdPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ShareExportIdPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ShareExportIdPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ShareExportIdPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types