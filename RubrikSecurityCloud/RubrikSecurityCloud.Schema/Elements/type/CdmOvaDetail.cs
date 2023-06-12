// CdmOvaDetail.cs
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
    #region CdmOvaDetail
    public class CdmOvaDetail: BaseType
    {
        #region members

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        [JsonProperty("ovaDownloadLink")]
        public System.String? OvaDownloadLink { get; set; }

        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        [JsonProperty("ovaSize")]
        public System.String? OvaSize { get; set; }


        #endregion

    #region methods

    public CdmOvaDetail Set(
        System.String? CdmVersion = null,
        System.String? OvaDownloadLink = null,
        System.String? OvaSize = null
    ) 
    {
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( OvaDownloadLink != null ) {
            this.OvaDownloadLink = OvaDownloadLink;
        }
        if ( OvaSize != null ) {
            this.OvaSize = OvaSize;
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
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            s += ind + "cdmVersion\n" ;
        }
        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        if (this.OvaDownloadLink != null) {
            s += ind + "ovaDownloadLink\n" ;
        }
        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        if (this.OvaSize != null) {
            s += ind + "ovaSize\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion", true))
        {
            this.CdmVersion = "FETCH";
        }
        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        if (this.OvaDownloadLink == null && Exploration.Includes(parent + ".ovaDownloadLink", true))
        {
            this.OvaDownloadLink = "FETCH";
        }
        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        if (this.OvaSize == null && Exploration.Includes(parent + ".ovaSize", true))
        {
            this.OvaSize = "FETCH";
        }
    }


    #endregion

    } // class CdmOvaDetail
    
    #endregion

    public static class ListCdmOvaDetailExtensions
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
            this List<CdmOvaDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmOvaDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmOvaDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types