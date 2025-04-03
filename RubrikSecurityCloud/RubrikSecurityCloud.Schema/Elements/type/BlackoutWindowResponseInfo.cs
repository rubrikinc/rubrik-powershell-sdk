// BlackoutWindowResponseInfo.cs
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
    #region BlackoutWindowResponseInfo
    public class BlackoutWindowResponseInfo: BaseType
    {
        #region members

        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        [JsonProperty("blackoutWindowStatus")]
        public BlackoutWindowStatus? BlackoutWindowStatus { get; set; }

        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        [JsonProperty("blackoutWindows")]
        public BlackoutWindows? BlackoutWindows { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlackoutWindowResponseInfo";
    }

    public BlackoutWindowResponseInfo Set(
        BlackoutWindowStatus? BlackoutWindowStatus = null,
        BlackoutWindows? BlackoutWindows = null
    ) 
    {
        if ( BlackoutWindowStatus != null ) {
            this.BlackoutWindowStatus = BlackoutWindowStatus;
        }
        if ( BlackoutWindows != null ) {
            this.BlackoutWindows = BlackoutWindows;
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
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        if (this.BlackoutWindowStatus != null) {
            var fspec = this.BlackoutWindowStatus.AsFieldSpec(conf.Child("blackoutWindowStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindowStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        if (this.BlackoutWindows != null) {
            var fspec = this.BlackoutWindows.AsFieldSpec(conf.Child("blackoutWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindows" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        if (ec.Includes("blackoutWindowStatus",false))
        {
            if(this.BlackoutWindowStatus == null) {

                this.BlackoutWindowStatus = new BlackoutWindowStatus();
                this.BlackoutWindowStatus.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowStatus"));

            } else {

                this.BlackoutWindowStatus.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowStatus"));

            }
        }
        else if (this.BlackoutWindowStatus != null && ec.Excludes("blackoutWindowStatus",false))
        {
            this.BlackoutWindowStatus = null;
        }
        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        if (ec.Includes("blackoutWindows",false))
        {
            if(this.BlackoutWindows == null) {

                this.BlackoutWindows = new BlackoutWindows();
                this.BlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindows"));

            } else {

                this.BlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindows"));

            }
        }
        else if (this.BlackoutWindows != null && ec.Excludes("blackoutWindows",false))
        {
            this.BlackoutWindows = null;
        }
    }


    #endregion

    } // class BlackoutWindowResponseInfo
    
    #endregion

    public static class ListBlackoutWindowResponseInfoExtensions
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
            this List<BlackoutWindowResponseInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BlackoutWindowResponseInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindowResponseInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindowResponseInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlackoutWindowResponseInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types