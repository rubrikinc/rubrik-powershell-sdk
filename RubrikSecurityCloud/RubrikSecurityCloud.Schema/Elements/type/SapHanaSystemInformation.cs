// SapHanaSystemInformation.cs
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
    #region SapHanaSystemInformation
    public class SapHanaSystemInformation: BaseType
    {
        #region members

        //      C# -> SapHanaSystemAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthType! (enum)
        [JsonProperty("authType")]
        public SapHanaSystemAuthType? AuthType { get; set; }

        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        [JsonProperty("hanaVersion")]
        public System.String? HanaVersion { get; set; }

        //      C# -> System.Boolean? IsDtEnabled
        // GraphQL -> isDtEnabled: Boolean! (scalar)
        [JsonProperty("isDtEnabled")]
        public System.Boolean? IsDtEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSystemInformation";
    }

    public SapHanaSystemInformation Set(
        SapHanaSystemAuthType? AuthType = null,
        System.String? HanaVersion = null,
        System.Boolean? IsDtEnabled = null
    ) 
    {
        if ( AuthType != null ) {
            this.AuthType = AuthType;
        }
        if ( HanaVersion != null ) {
            this.HanaVersion = HanaVersion;
        }
        if ( IsDtEnabled != null ) {
            this.IsDtEnabled = IsDtEnabled;
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
        //      C# -> SapHanaSystemAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthType! (enum)
        if (this.AuthType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authType\n" ;
            } else {
                s += ind + "authType\n" ;
            }
        }
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (this.HanaVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hanaVersion\n" ;
            } else {
                s += ind + "hanaVersion\n" ;
            }
        }
        //      C# -> System.Boolean? IsDtEnabled
        // GraphQL -> isDtEnabled: Boolean! (scalar)
        if (this.IsDtEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDtEnabled\n" ;
            } else {
                s += ind + "isDtEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SapHanaSystemAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthType! (enum)
        if (ec.Includes("authType",true))
        {
            if(this.AuthType == null) {

                this.AuthType = new SapHanaSystemAuthType();

            } else {


            }
        }
        else if (this.AuthType != null && ec.Excludes("authType",true))
        {
            this.AuthType = null;
        }
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        if (ec.Includes("hanaVersion",true))
        {
            if(this.HanaVersion == null) {

                this.HanaVersion = "FETCH";

            } else {


            }
        }
        else if (this.HanaVersion != null && ec.Excludes("hanaVersion",true))
        {
            this.HanaVersion = null;
        }
        //      C# -> System.Boolean? IsDtEnabled
        // GraphQL -> isDtEnabled: Boolean! (scalar)
        if (ec.Includes("isDtEnabled",true))
        {
            if(this.IsDtEnabled == null) {

                this.IsDtEnabled = true;

            } else {


            }
        }
        else if (this.IsDtEnabled != null && ec.Excludes("isDtEnabled",true))
        {
            this.IsDtEnabled = null;
        }
    }


    #endregion

    } // class SapHanaSystemInformation
    
    #endregion

    public static class ListSapHanaSystemInformationExtensions
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
            this List<SapHanaSystemInformation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemInformation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemInformation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaSystemInformation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types