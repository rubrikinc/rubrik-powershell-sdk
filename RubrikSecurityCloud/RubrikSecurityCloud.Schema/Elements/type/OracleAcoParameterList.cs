// OracleAcoParameterList.cs
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
    #region OracleAcoParameterList
    public class OracleAcoParameterList: BaseType
    {
        #region members

        //      C# -> List<System.String>? Parameters
        // GraphQL -> parameters: [String!]! (scalar)
        [JsonProperty("parameters")]
        public List<System.String>? Parameters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleAcoParameterList";
    }

    public OracleAcoParameterList Set(
        List<System.String>? Parameters = null
    ) 
    {
        if ( Parameters != null ) {
            this.Parameters = Parameters;
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
        //      C# -> List<System.String>? Parameters
        // GraphQL -> parameters: [String!]! (scalar)
        if (this.Parameters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parameters\n" ;
            } else {
                s += ind + "parameters\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Parameters
        // GraphQL -> parameters: [String!]! (scalar)
        if (ec.Includes("parameters",true))
        {
            if(this.Parameters == null) {

                this.Parameters = new List<System.String>();

            } else {


            }
        }
        else if (this.Parameters != null && ec.Excludes("parameters",true))
        {
            this.Parameters = null;
        }
    }


    #endregion

    } // class OracleAcoParameterList
    
    #endregion

    public static class ListOracleAcoParameterListExtensions
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
            this List<OracleAcoParameterList> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleAcoParameterList> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleAcoParameterList());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleAcoParameterList> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types