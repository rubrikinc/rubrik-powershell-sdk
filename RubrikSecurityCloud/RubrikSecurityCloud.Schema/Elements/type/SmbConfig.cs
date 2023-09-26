// SmbConfig.cs
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
    #region SmbConfig
    public class SmbConfig: BaseType
    {
        #region members

        //      C# -> System.Boolean? EnforceSmbSecurity
        // GraphQL -> enforceSmbSecurity: Boolean! (scalar)
        [JsonProperty("enforceSmbSecurity")]
        public System.Boolean? EnforceSmbSecurity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SmbConfig";
    }

    public SmbConfig Set(
        System.Boolean? EnforceSmbSecurity = null
    ) 
    {
        if ( EnforceSmbSecurity != null ) {
            this.EnforceSmbSecurity = EnforceSmbSecurity;
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
        //      C# -> System.Boolean? EnforceSmbSecurity
        // GraphQL -> enforceSmbSecurity: Boolean! (scalar)
        if (this.EnforceSmbSecurity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enforceSmbSecurity\n" ;
            } else {
                s += ind + "enforceSmbSecurity\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? EnforceSmbSecurity
        // GraphQL -> enforceSmbSecurity: Boolean! (scalar)
        if (ec.Includes("enforceSmbSecurity",true))
        {
            if(this.EnforceSmbSecurity == null) {

                this.EnforceSmbSecurity = true;

            } else {


            }
        }
        else if (this.EnforceSmbSecurity != null && ec.Excludes("enforceSmbSecurity",true))
        {
            this.EnforceSmbSecurity = null;
        }
    }


    #endregion

    } // class SmbConfig
    
    #endregion

    public static class ListSmbConfigExtensions
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
            this List<SmbConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SmbConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SmbConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SmbConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types