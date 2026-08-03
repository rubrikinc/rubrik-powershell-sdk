// UserAppAccessData.cs
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
    #region UserAppAccessData
    public class UserAppAccessData: BaseType
    {
        #region members

        //      C# -> List<AppNode>? DirectAppSet
        // GraphQL -> directAppSet: [AppNode!]! (type)
        [JsonProperty("directAppSet")]
        public List<AppNode>? DirectAppSet { get; set; }

        //      C# -> List<GroupNode>? GroupsWithApps
        // GraphQL -> groupsWithApps: [GroupNode!]! (type)
        [JsonProperty("groupsWithApps")]
        public List<GroupNode>? GroupsWithApps { get; set; }

        //      C# -> List<AppNode>? IndirectAppSet
        // GraphQL -> indirectAppSet: [AppNode!]! (type)
        [JsonProperty("indirectAppSet")]
        public List<AppNode>? IndirectAppSet { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UserAppAccessData";
    }

    public UserAppAccessData Set(
        List<AppNode>? DirectAppSet = null,
        List<GroupNode>? GroupsWithApps = null,
        List<AppNode>? IndirectAppSet = null
    ) 
    {
        if ( DirectAppSet != null ) {
            this.DirectAppSet = DirectAppSet;
        }
        if ( GroupsWithApps != null ) {
            this.GroupsWithApps = GroupsWithApps;
        }
        if ( IndirectAppSet != null ) {
            this.IndirectAppSet = IndirectAppSet;
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
        //      C# -> List<AppNode>? DirectAppSet
        // GraphQL -> directAppSet: [AppNode!]! (type)
        if (this.DirectAppSet != null) {
            var fspec = this.DirectAppSet.AsFieldSpec(conf.Child("directAppSet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "directAppSet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<GroupNode>? GroupsWithApps
        // GraphQL -> groupsWithApps: [GroupNode!]! (type)
        if (this.GroupsWithApps != null) {
            var fspec = this.GroupsWithApps.AsFieldSpec(conf.Child("groupsWithApps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupsWithApps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AppNode>? IndirectAppSet
        // GraphQL -> indirectAppSet: [AppNode!]! (type)
        if (this.IndirectAppSet != null) {
            var fspec = this.IndirectAppSet.AsFieldSpec(conf.Child("indirectAppSet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "indirectAppSet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AppNode>? DirectAppSet
        // GraphQL -> directAppSet: [AppNode!]! (type)
        if (ec.Includes("directAppSet",false))
        {
            if(this.DirectAppSet == null) {

                this.DirectAppSet = new List<AppNode>();
                this.DirectAppSet.ApplyExploratoryFieldSpec(ec.NewChild("directAppSet"));

            } else {

                this.DirectAppSet.ApplyExploratoryFieldSpec(ec.NewChild("directAppSet"));

            }
        }
        else if (this.DirectAppSet != null && ec.Excludes("directAppSet",false))
        {
            this.DirectAppSet = null;
        }
        //      C# -> List<GroupNode>? GroupsWithApps
        // GraphQL -> groupsWithApps: [GroupNode!]! (type)
        if (ec.Includes("groupsWithApps",false))
        {
            if(this.GroupsWithApps == null) {

                this.GroupsWithApps = new List<GroupNode>();
                this.GroupsWithApps.ApplyExploratoryFieldSpec(ec.NewChild("groupsWithApps"));

            } else {

                this.GroupsWithApps.ApplyExploratoryFieldSpec(ec.NewChild("groupsWithApps"));

            }
        }
        else if (this.GroupsWithApps != null && ec.Excludes("groupsWithApps",false))
        {
            this.GroupsWithApps = null;
        }
        //      C# -> List<AppNode>? IndirectAppSet
        // GraphQL -> indirectAppSet: [AppNode!]! (type)
        if (ec.Includes("indirectAppSet",false))
        {
            if(this.IndirectAppSet == null) {

                this.IndirectAppSet = new List<AppNode>();
                this.IndirectAppSet.ApplyExploratoryFieldSpec(ec.NewChild("indirectAppSet"));

            } else {

                this.IndirectAppSet.ApplyExploratoryFieldSpec(ec.NewChild("indirectAppSet"));

            }
        }
        else if (this.IndirectAppSet != null && ec.Excludes("indirectAppSet",false))
        {
            this.IndirectAppSet = null;
        }
    }


    #endregion

    } // class UserAppAccessData
    
    #endregion

    public static class ListUserAppAccessDataExtensions
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
            this List<UserAppAccessData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserAppAccessData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserAppAccessData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserAppAccessData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserAppAccessData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types