// QuarantineInfo.cs
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
    #region QuarantineInfo
    public class QuarantineInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? ContainsQuarantinedFiles
        // GraphQL -> containsQuarantinedFiles: Boolean! (scalar)
        [JsonProperty("containsQuarantinedFiles")]
        public System.Boolean? ContainsQuarantinedFiles { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "QuarantineInfo";
    }

    public QuarantineInfo Set(
        System.Boolean? ContainsQuarantinedFiles = null,
        System.Boolean? IsQuarantined = null
    ) 
    {
        if ( ContainsQuarantinedFiles != null ) {
            this.ContainsQuarantinedFiles = ContainsQuarantinedFiles;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
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
        //      C# -> System.Boolean? ContainsQuarantinedFiles
        // GraphQL -> containsQuarantinedFiles: Boolean! (scalar)
        if (this.ContainsQuarantinedFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containsQuarantinedFiles\n" ;
            } else {
                s += ind + "containsQuarantinedFiles\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantined\n" ;
            } else {
                s += ind + "isQuarantined\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? ContainsQuarantinedFiles
        // GraphQL -> containsQuarantinedFiles: Boolean! (scalar)
        if (ec.Includes("containsQuarantinedFiles",true))
        {
            if(this.ContainsQuarantinedFiles == null) {

                this.ContainsQuarantinedFiles = true;

            } else {


            }
        }
        else if (this.ContainsQuarantinedFiles != null && ec.Excludes("containsQuarantinedFiles",true))
        {
            this.ContainsQuarantinedFiles = null;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (ec.Includes("isQuarantined",true))
        {
            if(this.IsQuarantined == null) {

                this.IsQuarantined = true;

            } else {


            }
        }
        else if (this.IsQuarantined != null && ec.Excludes("isQuarantined",true))
        {
            this.IsQuarantined = null;
        }
    }


    #endregion

    } // class QuarantineInfo
    
    #endregion

    public static class ListQuarantineInfoExtensions
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
            this List<QuarantineInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<QuarantineInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new QuarantineInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<QuarantineInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types