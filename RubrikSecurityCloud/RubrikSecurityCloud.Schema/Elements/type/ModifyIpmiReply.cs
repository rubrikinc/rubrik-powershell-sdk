// ModifyIpmiReply.cs
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
    #region ModifyIpmiReply
    public class ModifyIpmiReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        [JsonProperty("isAvailable")]
        public System.Boolean? IsAvailable { get; set; }

        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        [JsonProperty("access")]
        public IpmiAccess? Access { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ModifyIpmiReply";
    }

    public ModifyIpmiReply Set(
        System.Boolean? IsAvailable = null,
        IpmiAccess? Access = null
    ) 
    {
        if ( IsAvailable != null ) {
            this.IsAvailable = IsAvailable;
        }
        if ( Access != null ) {
            this.Access = Access;
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
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (this.IsAvailable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAvailable\n" ;
            } else {
                s += ind + "isAvailable\n" ;
            }
        }
        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        if (this.Access != null) {
            var fspec = this.Access.AsFieldSpec(conf.Child("access"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "access {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (ec.Includes("isAvailable",true))
        {
            if(this.IsAvailable == null) {

                this.IsAvailable = true;

            } else {


            }
        }
        else if (this.IsAvailable != null && ec.Excludes("isAvailable",true))
        {
            this.IsAvailable = null;
        }
        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        if (ec.Includes("access",false))
        {
            if(this.Access == null) {

                this.Access = new IpmiAccess();
                this.Access.ApplyExploratoryFieldSpec(ec.NewChild("access"));

            } else {

                this.Access.ApplyExploratoryFieldSpec(ec.NewChild("access"));

            }
        }
        else if (this.Access != null && ec.Excludes("access",false))
        {
            this.Access = null;
        }
    }


    #endregion

    } // class ModifyIpmiReply
    
    #endregion

    public static class ListModifyIpmiReplyExtensions
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
            this List<ModifyIpmiReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ModifyIpmiReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ModifyIpmiReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ModifyIpmiReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ModifyIpmiReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types