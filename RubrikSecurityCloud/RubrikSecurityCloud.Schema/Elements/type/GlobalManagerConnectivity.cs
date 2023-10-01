// GlobalManagerConnectivity.cs
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
    #region GlobalManagerConnectivity
    public class GlobalManagerConnectivity: BaseType
    {
        #region members

        //      C# -> List<GlobalManagerUrl>? Urls
        // GraphQL -> urls: [GlobalManagerUrl!]! (type)
        [JsonProperty("urls")]
        public List<GlobalManagerUrl>? Urls { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalManagerConnectivity";
    }

    public GlobalManagerConnectivity Set(
        List<GlobalManagerUrl>? Urls = null
    ) 
    {
        if ( Urls != null ) {
            this.Urls = Urls;
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
        //      C# -> List<GlobalManagerUrl>? Urls
        // GraphQL -> urls: [GlobalManagerUrl!]! (type)
        if (this.Urls != null) {
            var fspec = this.Urls.AsFieldSpec(conf.Child("urls"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "urls {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<GlobalManagerUrl>? Urls
        // GraphQL -> urls: [GlobalManagerUrl!]! (type)
        if (ec.Includes("urls",false))
        {
            if(this.Urls == null) {

                this.Urls = new List<GlobalManagerUrl>();
                this.Urls.ApplyExploratoryFieldSpec(ec.NewChild("urls"));

            } else {

                this.Urls.ApplyExploratoryFieldSpec(ec.NewChild("urls"));

            }
        }
        else if (this.Urls != null && ec.Excludes("urls",false))
        {
            this.Urls = null;
        }
    }


    #endregion

    } // class GlobalManagerConnectivity
    
    #endregion

    public static class ListGlobalManagerConnectivityExtensions
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
            this List<GlobalManagerConnectivity> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GlobalManagerConnectivity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GlobalManagerConnectivity> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalManagerConnectivity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalManagerConnectivity> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types