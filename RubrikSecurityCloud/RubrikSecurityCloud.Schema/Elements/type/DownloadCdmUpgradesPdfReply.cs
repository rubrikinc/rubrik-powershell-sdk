// DownloadCdmUpgradesPdfReply.cs
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
    #region DownloadCdmUpgradesPdfReply
    public class DownloadCdmUpgradesPdfReply: BaseType
    {
        #region members

        //      C# -> System.String? DownloadLink
        // GraphQL -> downloadLink: String! (scalar)
        [JsonProperty("downloadLink")]
        public System.String? DownloadLink { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DownloadCdmUpgradesPdfReply";
    }

    public DownloadCdmUpgradesPdfReply Set(
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

    } // class DownloadCdmUpgradesPdfReply
    
    #endregion

    public static class ListDownloadCdmUpgradesPdfReplyExtensions
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
            this List<DownloadCdmUpgradesPdfReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DownloadCdmUpgradesPdfReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DownloadCdmUpgradesPdfReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadCdmUpgradesPdfReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DownloadCdmUpgradesPdfReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types