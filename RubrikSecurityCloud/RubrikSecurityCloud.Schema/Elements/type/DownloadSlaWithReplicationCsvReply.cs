// DownloadSlaWithReplicationCsvReply.cs
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
    #region DownloadSlaWithReplicationCsvReply
    public class DownloadSlaWithReplicationCsvReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? DoesSlaExists
        // GraphQL -> doesSlaExists: Boolean! (scalar)
        [JsonProperty("doesSlaExists")]
        public System.Boolean? DoesSlaExists { get; set; }

        //      C# -> System.Boolean? IsDownloadSuccessful
        // GraphQL -> isDownloadSuccessful: Boolean! (scalar)
        [JsonProperty("isDownloadSuccessful")]
        public System.Boolean? IsDownloadSuccessful { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DownloadSlaWithReplicationCsvReply";
    }

    public DownloadSlaWithReplicationCsvReply Set(
        System.Boolean? DoesSlaExists = null,
        System.Boolean? IsDownloadSuccessful = null
    ) 
    {
        if ( DoesSlaExists != null ) {
            this.DoesSlaExists = DoesSlaExists;
        }
        if ( IsDownloadSuccessful != null ) {
            this.IsDownloadSuccessful = IsDownloadSuccessful;
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
        //      C# -> System.Boolean? DoesSlaExists
        // GraphQL -> doesSlaExists: Boolean! (scalar)
        if (this.DoesSlaExists != null) {
            s += ind + "doesSlaExists\n" ;
        }
        //      C# -> System.Boolean? IsDownloadSuccessful
        // GraphQL -> isDownloadSuccessful: Boolean! (scalar)
        if (this.IsDownloadSuccessful != null) {
            s += ind + "isDownloadSuccessful\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? DoesSlaExists
        // GraphQL -> doesSlaExists: Boolean! (scalar)
        if (this.DoesSlaExists == null && Exploration.Includes(parent + ".doesSlaExists", true))
        {
            this.DoesSlaExists = true;
        }
        //      C# -> System.Boolean? IsDownloadSuccessful
        // GraphQL -> isDownloadSuccessful: Boolean! (scalar)
        if (this.IsDownloadSuccessful == null && Exploration.Includes(parent + ".isDownloadSuccessful", true))
        {
            this.IsDownloadSuccessful = true;
        }
    }


    #endregion

    } // class DownloadSlaWithReplicationCsvReply
    
    #endregion

    public static class ListDownloadSlaWithReplicationCsvReplyExtensions
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
            this List<DownloadSlaWithReplicationCsvReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DownloadSlaWithReplicationCsvReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadSlaWithReplicationCsvReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types