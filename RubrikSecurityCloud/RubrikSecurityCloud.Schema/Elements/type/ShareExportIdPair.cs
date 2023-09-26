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
            this List<ShareExportIdPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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