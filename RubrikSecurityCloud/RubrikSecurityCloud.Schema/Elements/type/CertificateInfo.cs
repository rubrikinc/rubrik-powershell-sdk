// CertificateInfo.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CertificateInfo
    public class CertificateInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        [JsonProperty("certificateId")]
        public System.Int64? CertificateId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public CertificateInfo Set(
        System.Int64? CertificateId = null,
        System.String? Name = null
    ) 
    {
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        if (this.CertificateId != null) {
            s += ind + "certificateId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        if (this.CertificateId == null && Exploration.Includes(parent + ".certificateId", true))
        {
            this.CertificateId = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class CertificateInfo
    
    #endregion

    public static class ListCertificateInfoExtensions
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
            this List<CertificateInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CertificateInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CertificateInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types