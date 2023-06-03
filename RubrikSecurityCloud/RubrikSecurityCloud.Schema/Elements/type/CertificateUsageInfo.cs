// CertificateUsageInfo.cs
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
    #region CertificateUsageInfo
    public class CertificateUsageInfo: BaseType
    {
        #region members

        //      C# -> CertificateUsage? Type
        // GraphQL -> type: CertificateUsage! (enum)
        [JsonProperty("type")]
        public CertificateUsage? Type { get; set; }

        //      C# -> List<CertificateUsageParameter>? Params
        // GraphQL -> params: [CertificateUsageParameter!]! (type)
        [JsonProperty("params")]
        public List<CertificateUsageParameter>? Params { get; set; }


        #endregion

    #region methods

    public CertificateUsageInfo Set(
        CertificateUsage? Type = null,
        List<CertificateUsageParameter>? Params = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Params != null ) {
            this.Params = Params;
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
        //      C# -> CertificateUsage? Type
        // GraphQL -> type: CertificateUsage! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> List<CertificateUsageParameter>? Params
        // GraphQL -> params: [CertificateUsageParameter!]! (type)
        if (this.Params != null) {
            s += ind + "params {\n" + this.Params.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CertificateUsage? Type
        // GraphQL -> type: CertificateUsage! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new CertificateUsage();
        }
        //      C# -> List<CertificateUsageParameter>? Params
        // GraphQL -> params: [CertificateUsageParameter!]! (type)
        if (this.Params == null && Exploration.Includes(parent + ".params"))
        {
            this.Params = new List<CertificateUsageParameter>();
            this.Params.ApplyExploratoryFieldSpec(parent + ".params");
        }
    }


    #endregion

    } // class CertificateUsageInfo
    
    #endregion

    public static class ListCertificateUsageInfoExtensions
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
            this List<CertificateUsageInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CertificateUsageInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CertificateUsageInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types