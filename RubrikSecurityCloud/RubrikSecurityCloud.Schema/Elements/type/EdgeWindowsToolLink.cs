// EdgeWindowsToolLink.cs
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
    #region EdgeWindowsToolLink
    public class EdgeWindowsToolLink: BaseType
    {
        #region members

        //      C# -> System.String? DownloadLink
        // GraphQL -> downloadLink: String! (scalar)
        [JsonProperty("downloadLink")]
        public System.String? DownloadLink { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EdgeWindowsToolLink";
    }

    public EdgeWindowsToolLink Set(
        System.String? DownloadLink = null
    ) 
    {
        if ( DownloadLink != null ) {
            this.DownloadLink = DownloadLink;
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
        //      C# -> System.String? DownloadLink
        // GraphQL -> downloadLink: String! (scalar)
        if (this.DownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadLink\n" ;
            } else {
                s += ind + "downloadLink\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DownloadLink
        // GraphQL -> downloadLink: String! (scalar)
        if (ec.Includes("downloadLink",true))
        {
            if(this.DownloadLink == null) {

                this.DownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.DownloadLink != null && ec.Excludes("downloadLink",true))
        {
            this.DownloadLink = null;
        }
    }


    #endregion

    } // class EdgeWindowsToolLink
    
    #endregion

    public static class ListEdgeWindowsToolLinkExtensions
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
            this List<EdgeWindowsToolLink> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EdgeWindowsToolLink> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EdgeWindowsToolLink());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EdgeWindowsToolLink> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types