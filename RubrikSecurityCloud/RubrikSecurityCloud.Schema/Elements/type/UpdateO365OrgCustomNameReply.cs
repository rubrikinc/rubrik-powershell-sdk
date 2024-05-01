// UpdateO365OrgCustomNameReply.cs
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
    #region UpdateO365OrgCustomNameReply
    public class UpdateO365OrgCustomNameReply: BaseType
    {
        #region members

        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        [JsonProperty("customName")]
        public System.String? CustomName { get; set; }

        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        [JsonProperty("orgUuid")]
        public System.String? OrgUuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateO365OrgCustomNameReply";
    }

    public UpdateO365OrgCustomNameReply Set(
        System.String? CustomName = null,
        System.String? OrgUuid = null
    ) 
    {
        if ( CustomName != null ) {
            this.CustomName = CustomName;
        }
        if ( OrgUuid != null ) {
            this.OrgUuid = OrgUuid;
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
        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        if (this.CustomName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customName\n" ;
            } else {
                s += ind + "customName\n" ;
            }
        }
        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        if (this.OrgUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgUuid\n" ;
            } else {
                s += ind + "orgUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        if (ec.Includes("customName",true))
        {
            if(this.CustomName == null) {

                this.CustomName = "FETCH";

            } else {


            }
        }
        else if (this.CustomName != null && ec.Excludes("customName",true))
        {
            this.CustomName = null;
        }
        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        if (ec.Includes("orgUuid",true))
        {
            if(this.OrgUuid == null) {

                this.OrgUuid = "FETCH";

            } else {


            }
        }
        else if (this.OrgUuid != null && ec.Excludes("orgUuid",true))
        {
            this.OrgUuid = null;
        }
    }


    #endregion

    } // class UpdateO365OrgCustomNameReply
    
    #endregion

    public static class ListUpdateO365OrgCustomNameReplyExtensions
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
            this List<UpdateO365OrgCustomNameReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateO365OrgCustomNameReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateO365OrgCustomNameReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateO365OrgCustomNameReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateO365OrgCustomNameReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types