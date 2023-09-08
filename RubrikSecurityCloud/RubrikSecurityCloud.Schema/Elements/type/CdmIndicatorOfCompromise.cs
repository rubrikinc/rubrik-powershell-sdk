// CdmIndicatorOfCompromise.cs
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
    #region CdmIndicatorOfCompromise
    public class CdmIndicatorOfCompromise: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseType? IocType
        // GraphQL -> iocType: IndicatorOfCompromiseType! (enum)
        [JsonProperty("iocType")]
        public IndicatorOfCompromiseType? IocType { get; set; }

        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        [JsonProperty("iocValue")]
        public System.String? IocValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmIndicatorOfCompromise";
    }

    public CdmIndicatorOfCompromise Set(
        IndicatorOfCompromiseType? IocType = null,
        System.String? IocValue = null
    ) 
    {
        if ( IocType != null ) {
            this.IocType = IocType;
        }
        if ( IocValue != null ) {
            this.IocValue = IocValue;
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
        //      C# -> IndicatorOfCompromiseType? IocType
        // GraphQL -> iocType: IndicatorOfCompromiseType! (enum)
        if (this.IocType != null) {
            s += ind + "iocType\n" ;
        }
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        if (this.IocValue != null) {
            s += ind + "iocValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IndicatorOfCompromiseType? IocType
        // GraphQL -> iocType: IndicatorOfCompromiseType! (enum)
        if (this.IocType == null && ec.Includes("iocType",true))
        {
            this.IocType = new IndicatorOfCompromiseType();
        }
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        if (this.IocValue == null && ec.Includes("iocValue",true))
        {
            this.IocValue = "FETCH";
        }
    }


    #endregion

    } // class CdmIndicatorOfCompromise
    
    #endregion

    public static class ListCdmIndicatorOfCompromiseExtensions
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
            this List<CdmIndicatorOfCompromise> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmIndicatorOfCompromise> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmIndicatorOfCompromise());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CdmIndicatorOfCompromise> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types