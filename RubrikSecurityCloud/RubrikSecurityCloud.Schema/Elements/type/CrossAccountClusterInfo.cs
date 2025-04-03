// CrossAccountClusterInfo.cs
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
    #region CrossAccountClusterInfo
 
    public class CrossAccountClusterInfo: BaseType, DataLocationClusterInfo
    {
        #region members

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> System.String? OriginAccount
        // GraphQL -> originAccount: String! (scalar)
        [JsonProperty("originAccount")]
        public System.String? OriginAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CrossAccountClusterInfo";
    }

    public CrossAccountClusterInfo Set(
        System.Boolean? IsConnected = null,
        System.String? OriginAccount = null
    ) 
    {
        if ( IsConnected != null ) {
            this.IsConnected = IsConnected;
        }
        if ( OriginAccount != null ) {
            this.OriginAccount = OriginAccount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (this.IsConnected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConnected\n" ;
            } else {
                s += ind + "isConnected\n" ;
            }
        }
        //      C# -> System.String? OriginAccount
        // GraphQL -> originAccount: String! (scalar)
        if (this.OriginAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originAccount\n" ;
            } else {
                s += ind + "originAccount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        if (ec.Includes("isConnected",true))
        {
            if(this.IsConnected == null) {

                this.IsConnected = true;

            } else {


            }
        }
        else if (this.IsConnected != null && ec.Excludes("isConnected",true))
        {
            this.IsConnected = null;
        }
        //      C# -> System.String? OriginAccount
        // GraphQL -> originAccount: String! (scalar)
        if (ec.Includes("originAccount",true))
        {
            if(this.OriginAccount == null) {

                this.OriginAccount = "FETCH";

            } else {


            }
        }
        else if (this.OriginAccount != null && ec.Excludes("originAccount",true))
        {
            this.OriginAccount = null;
        }
    }


    #endregion

    } // class CrossAccountClusterInfo
    
    #endregion

    public static class ListCrossAccountClusterInfoExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CrossAccountClusterInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CrossAccountClusterInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrossAccountClusterInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrossAccountClusterInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrossAccountClusterInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types