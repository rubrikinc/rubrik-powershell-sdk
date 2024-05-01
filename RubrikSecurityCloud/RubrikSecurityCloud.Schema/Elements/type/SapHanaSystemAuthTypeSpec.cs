// SapHanaSystemAuthTypeSpec.cs
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
    #region SapHanaSystemAuthTypeSpec
    public class SapHanaSystemAuthTypeSpec: BaseType
    {
        #region members

        //      C# -> SapHanaSystemAuthTypeSpecAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthTypeSpecAuthType! (enum)
        [JsonProperty("authType")]
        public SapHanaSystemAuthTypeSpecAuthType? AuthType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSystemAuthTypeSpec";
    }

    public SapHanaSystemAuthTypeSpec Set(
        SapHanaSystemAuthTypeSpecAuthType? AuthType = null
    ) 
    {
        if ( AuthType != null ) {
            this.AuthType = AuthType;
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
        //      C# -> SapHanaSystemAuthTypeSpecAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthTypeSpecAuthType! (enum)
        if (this.AuthType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authType\n" ;
            } else {
                s += ind + "authType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SapHanaSystemAuthTypeSpecAuthType? AuthType
        // GraphQL -> authType: SapHanaSystemAuthTypeSpecAuthType! (enum)
        if (ec.Includes("authType",true))
        {
            if(this.AuthType == null) {

                this.AuthType = new SapHanaSystemAuthTypeSpecAuthType();

            } else {


            }
        }
        else if (this.AuthType != null && ec.Excludes("authType",true))
        {
            this.AuthType = null;
        }
    }


    #endregion

    } // class SapHanaSystemAuthTypeSpec
    
    #endregion

    public static class ListSapHanaSystemAuthTypeSpecExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SapHanaSystemAuthTypeSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaSystemAuthTypeSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSystemAuthTypeSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSystemAuthTypeSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaSystemAuthTypeSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types