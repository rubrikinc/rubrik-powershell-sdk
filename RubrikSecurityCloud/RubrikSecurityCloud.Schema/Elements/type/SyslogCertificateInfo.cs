// SyslogCertificateInfo.cs
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
    #region SyslogCertificateInfo
    public class SyslogCertificateInfo: BaseType
    {
        #region members

        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        [JsonProperty("serverCertificate")]
        public System.String? ServerCertificate { get; set; }

        //      C# -> System.String? ServerCertificateName
        // GraphQL -> serverCertificateName: String (scalar)
        [JsonProperty("serverCertificateName")]
        public System.String? ServerCertificateName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyslogCertificateInfo";
    }

    public SyslogCertificateInfo Set(
        System.String? ServerCertificate = null,
        System.String? ServerCertificateName = null
    ) 
    {
        if ( ServerCertificate != null ) {
            this.ServerCertificate = ServerCertificate;
        }
        if ( ServerCertificateName != null ) {
            this.ServerCertificateName = ServerCertificateName;
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
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        if (this.ServerCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverCertificate\n" ;
            } else {
                s += ind + "serverCertificate\n" ;
            }
        }
        //      C# -> System.String? ServerCertificateName
        // GraphQL -> serverCertificateName: String (scalar)
        if (this.ServerCertificateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverCertificateName\n" ;
            } else {
                s += ind + "serverCertificateName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        if (ec.Includes("serverCertificate",true))
        {
            if(this.ServerCertificate == null) {

                this.ServerCertificate = "FETCH";

            } else {


            }
        }
        else if (this.ServerCertificate != null && ec.Excludes("serverCertificate",true))
        {
            this.ServerCertificate = null;
        }
        //      C# -> System.String? ServerCertificateName
        // GraphQL -> serverCertificateName: String (scalar)
        if (ec.Includes("serverCertificateName",true))
        {
            if(this.ServerCertificateName == null) {

                this.ServerCertificateName = "FETCH";

            } else {


            }
        }
        else if (this.ServerCertificateName != null && ec.Excludes("serverCertificateName",true))
        {
            this.ServerCertificateName = null;
        }
    }


    #endregion

    } // class SyslogCertificateInfo
    
    #endregion

    public static class ListSyslogCertificateInfoExtensions
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
            this List<SyslogCertificateInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SyslogCertificateInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogCertificateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SyslogCertificateInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types