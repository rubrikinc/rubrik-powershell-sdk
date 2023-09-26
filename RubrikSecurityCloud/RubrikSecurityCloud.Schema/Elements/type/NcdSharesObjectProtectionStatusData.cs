// NcdSharesObjectProtectionStatusData.cs
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
    #region NcdSharesObjectProtectionStatusData
    public class NcdSharesObjectProtectionStatusData: BaseType
    {
        #region members

        //      C# -> System.Int64? NotProtected
        // GraphQL -> notProtected: Long! (scalar)
        [JsonProperty("notProtected")]
        public System.Int64? NotProtected { get; set; }

        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        [JsonProperty("protected")]
        public System.Int64? Protected { get; set; }

        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        [JsonProperty("totalSizeInBytes")]
        public System.Int64? TotalSizeInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdSharesObjectProtectionStatusData";
    }

    public NcdSharesObjectProtectionStatusData Set(
        System.Int64? NotProtected = null,
        System.Int64? Protected = null,
        System.Int64? TotalSizeInBytes = null
    ) 
    {
        if ( NotProtected != null ) {
            this.NotProtected = NotProtected;
        }
        if ( Protected != null ) {
            this.Protected = Protected;
        }
        if ( TotalSizeInBytes != null ) {
            this.TotalSizeInBytes = TotalSizeInBytes;
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
        //      C# -> System.Int64? NotProtected
        // GraphQL -> notProtected: Long! (scalar)
        if (this.NotProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notProtected\n" ;
            } else {
                s += ind + "notProtected\n" ;
            }
        }
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        if (this.Protected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protected\n" ;
            } else {
                s += ind + "protected\n" ;
            }
        }
        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        if (this.TotalSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSizeInBytes\n" ;
            } else {
                s += ind + "totalSizeInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? NotProtected
        // GraphQL -> notProtected: Long! (scalar)
        if (ec.Includes("notProtected",true))
        {
            if(this.NotProtected == null) {

                this.NotProtected = new System.Int64();

            } else {


            }
        }
        else if (this.NotProtected != null && ec.Excludes("notProtected",true))
        {
            this.NotProtected = null;
        }
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        if (ec.Includes("protected",true))
        {
            if(this.Protected == null) {

                this.Protected = new System.Int64();

            } else {


            }
        }
        else if (this.Protected != null && ec.Excludes("protected",true))
        {
            this.Protected = null;
        }
        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        if (ec.Includes("totalSizeInBytes",true))
        {
            if(this.TotalSizeInBytes == null) {

                this.TotalSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSizeInBytes != null && ec.Excludes("totalSizeInBytes",true))
        {
            this.TotalSizeInBytes = null;
        }
    }


    #endregion

    } // class NcdSharesObjectProtectionStatusData
    
    #endregion

    public static class ListNcdSharesObjectProtectionStatusDataExtensions
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
            this List<NcdSharesObjectProtectionStatusData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdSharesObjectProtectionStatusData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdSharesObjectProtectionStatusData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdSharesObjectProtectionStatusData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types