// O365PdlGroupsReply.cs
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
    #region O365PdlGroupsReply
    public class O365PdlGroupsReply: BaseType
    {
        #region members

        //      C# -> List<O365PdlGroup>? Groups
        // GraphQL -> groups: [O365PdlGroup!]! (type)
        [JsonProperty("groups")]
        public List<O365PdlGroup>? Groups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365PdlGroupsReply";
    }

    public O365PdlGroupsReply Set(
        List<O365PdlGroup>? Groups = null
    ) 
    {
        if ( Groups != null ) {
            this.Groups = Groups;
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
        //      C# -> List<O365PdlGroup>? Groups
        // GraphQL -> groups: [O365PdlGroup!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(conf.Child("groups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groups {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<O365PdlGroup>? Groups
        // GraphQL -> groups: [O365PdlGroup!]! (type)
        if (ec.Includes("groups",false))
        {
            if(this.Groups == null) {

                this.Groups = new List<O365PdlGroup>();
                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            } else {

                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            }
        }
        else if (this.Groups != null && ec.Excludes("groups",false))
        {
            this.Groups = null;
        }
    }


    #endregion

    } // class O365PdlGroupsReply
    
    #endregion

    public static class ListO365PdlGroupsReplyExtensions
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
            this List<O365PdlGroupsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<O365PdlGroupsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365PdlGroupsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365PdlGroupsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365PdlGroupsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types