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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? ExportId
        // GraphQL -> exportId: Int! (scalar)
        if (this.ExportId != null) {
            s += ind + "exportId\n" ;
        }
        //      C# -> System.String? Share
        // GraphQL -> share: String! (scalar)
        if (this.Share != null) {
            s += ind + "share\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? ExportId
        // GraphQL -> exportId: Int! (scalar)
        if (this.ExportId == null && Exploration.Includes(parent + ".exportId", true))
        {
            this.ExportId = Int32.MinValue;
        }
        //      C# -> System.String? Share
        // GraphQL -> share: String! (scalar)
        if (this.Share == null && Exploration.Includes(parent + ".share", true))
        {
            this.Share = "FETCH";
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ShareExportIdPair> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ShareExportIdPair());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types