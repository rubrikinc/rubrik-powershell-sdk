// UpgradeJobReplyWithUuid.cs
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
    #region UpgradeJobReplyWithUuid
    public class UpgradeJobReplyWithUuid: BaseType
    {
        #region members

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> UpgradeJobReply? UpgradeJobReply
        // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
        [JsonProperty("upgradeJobReply")]
        public UpgradeJobReply? UpgradeJobReply { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeJobReplyWithUuid";
    }

    public UpgradeJobReplyWithUuid Set(
        System.String? Uuid = null,
        UpgradeJobReply? UpgradeJobReply = null
    ) 
    {
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( UpgradeJobReply != null ) {
            this.UpgradeJobReply = UpgradeJobReply;
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
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> UpgradeJobReply? UpgradeJobReply
        // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
        if (this.UpgradeJobReply != null) {
            var fspec = this.UpgradeJobReply.AsFieldSpec(conf.Child("upgradeJobReply"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "upgradeJobReply" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> UpgradeJobReply? UpgradeJobReply
        // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
        if (ec.Includes("upgradeJobReply",false))
        {
            if(this.UpgradeJobReply == null) {

                this.UpgradeJobReply = new UpgradeJobReply();
                this.UpgradeJobReply.ApplyExploratoryFieldSpec(ec.NewChild("upgradeJobReply"));

            } else {

                this.UpgradeJobReply.ApplyExploratoryFieldSpec(ec.NewChild("upgradeJobReply"));

            }
        }
        else if (this.UpgradeJobReply != null && ec.Excludes("upgradeJobReply",false))
        {
            this.UpgradeJobReply = null;
        }
    }


    #endregion

    } // class UpgradeJobReplyWithUuid
    
    #endregion

    public static class ListUpgradeJobReplyWithUuidExtensions
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
            this List<UpgradeJobReplyWithUuid> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradeJobReplyWithUuid> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeJobReplyWithUuid> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeJobReplyWithUuid());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeJobReplyWithUuid> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types