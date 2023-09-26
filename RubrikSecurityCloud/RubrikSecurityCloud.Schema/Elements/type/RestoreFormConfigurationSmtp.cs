// RestoreFormConfigurationSmtp.cs
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
    #region RestoreFormConfigurationSmtp
    public class RestoreFormConfigurationSmtp: BaseType
    {
        #region members

        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        [JsonProperty("fromEmailId")]
        public System.String? FromEmailId { get; set; }

        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        [JsonProperty("smtpHostname")]
        public System.String? SmtpHostname { get; set; }

        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        [JsonProperty("smtpPort")]
        public System.Int64? SmtpPort { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RestoreFormConfigurationSmtp";
    }

    public RestoreFormConfigurationSmtp Set(
        System.String? FromEmailId = null,
        System.String? SmtpHostname = null,
        System.Int64? SmtpPort = null
    ) 
    {
        if ( FromEmailId != null ) {
            this.FromEmailId = FromEmailId;
        }
        if ( SmtpHostname != null ) {
            this.SmtpHostname = SmtpHostname;
        }
        if ( SmtpPort != null ) {
            this.SmtpPort = SmtpPort;
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
        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        if (this.FromEmailId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fromEmailId\n" ;
            } else {
                s += ind + "fromEmailId\n" ;
            }
        }
        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        if (this.SmtpHostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smtpHostname\n" ;
            } else {
                s += ind + "smtpHostname\n" ;
            }
        }
        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        if (this.SmtpPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smtpPort\n" ;
            } else {
                s += ind + "smtpPort\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        if (ec.Includes("fromEmailId",true))
        {
            if(this.FromEmailId == null) {

                this.FromEmailId = "FETCH";

            } else {


            }
        }
        else if (this.FromEmailId != null && ec.Excludes("fromEmailId",true))
        {
            this.FromEmailId = null;
        }
        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        if (ec.Includes("smtpHostname",true))
        {
            if(this.SmtpHostname == null) {

                this.SmtpHostname = "FETCH";

            } else {


            }
        }
        else if (this.SmtpHostname != null && ec.Excludes("smtpHostname",true))
        {
            this.SmtpHostname = null;
        }
        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        if (ec.Includes("smtpPort",true))
        {
            if(this.SmtpPort == null) {

                this.SmtpPort = new System.Int64();

            } else {


            }
        }
        else if (this.SmtpPort != null && ec.Excludes("smtpPort",true))
        {
            this.SmtpPort = null;
        }
    }


    #endregion

    } // class RestoreFormConfigurationSmtp
    
    #endregion

    public static class ListRestoreFormConfigurationSmtpExtensions
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
            this List<RestoreFormConfigurationSmtp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationSmtp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationSmtp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RestoreFormConfigurationSmtp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types