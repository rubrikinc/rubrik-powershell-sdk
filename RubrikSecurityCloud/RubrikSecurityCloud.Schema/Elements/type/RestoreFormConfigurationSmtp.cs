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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        if (this.FromEmailId != null) {
            s += ind + "fromEmailId\n" ;
        }
        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        if (this.SmtpHostname != null) {
            s += ind + "smtpHostname\n" ;
        }
        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        if (this.SmtpPort != null) {
            s += ind + "smtpPort\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        if (this.FromEmailId == null && Exploration.Includes(parent + ".fromEmailId", true))
        {
            this.FromEmailId = "FETCH";
        }
        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        if (this.SmtpHostname == null && Exploration.Includes(parent + ".smtpHostname", true))
        {
            this.SmtpHostname = "FETCH";
        }
        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        if (this.SmtpPort == null && Exploration.Includes(parent + ".smtpPort", true))
        {
            this.SmtpPort = new System.Int64();
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationSmtp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationSmtp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types