// OracleAcoValueErrorDetail.cs
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
    #region OracleAcoValueErrorDetail
    public class OracleAcoValueErrorDetail: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.String? Parameter
        // GraphQL -> parameter: String! (scalar)
        [JsonProperty("parameter")]
        public System.String? Parameter { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleAcoValueErrorDetail";
    }

    public OracleAcoValueErrorDetail Set(
        System.String? Error = null,
        System.String? Parameter = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( Parameter != null ) {
            this.Parameter = Parameter;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.String? Parameter
        // GraphQL -> parameter: String! (scalar)
        if (this.Parameter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parameter\n" ;
            } else {
                s += ind + "parameter\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.String? Parameter
        // GraphQL -> parameter: String! (scalar)
        if (ec.Includes("parameter",true))
        {
            if(this.Parameter == null) {

                this.Parameter = "FETCH";

            } else {


            }
        }
        else if (this.Parameter != null && ec.Excludes("parameter",true))
        {
            this.Parameter = null;
        }
    }


    #endregion

    } // class OracleAcoValueErrorDetail
    
    #endregion

    public static class ListOracleAcoValueErrorDetailExtensions
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
            this List<OracleAcoValueErrorDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<OracleAcoValueErrorDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleAcoValueErrorDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleAcoValueErrorDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleAcoValueErrorDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types