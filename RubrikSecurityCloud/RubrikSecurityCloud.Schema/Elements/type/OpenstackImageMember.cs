// OpenstackImageMember.cs
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
    #region OpenstackImageMember
    public class OpenstackImageMember: BaseType
    {
        #region members

        //      C# -> OpenstackImageMemberStatus? Status
        // GraphQL -> status: OpenstackImageMemberStatus! (enum)
        [JsonProperty("status")]
        public OpenstackImageMemberStatus? Status { get; set; }

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.String? MemberId
        // GraphQL -> memberId: String! (scalar)
        [JsonProperty("memberId")]
        public System.String? MemberId { get; set; }

        //      C# -> OpenstackProject? Project
        // GraphQL -> project: OpenstackProject (type)
        [JsonProperty("project")]
        public OpenstackProject? Project { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OpenstackImageMember";
    }

    public OpenstackImageMember Set(
        OpenstackImageMemberStatus? Status = null,
        System.String? ImageId = null,
        System.String? MemberId = null,
        OpenstackProject? Project = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ImageId != null ) {
            this.ImageId = ImageId;
        }
        if ( MemberId != null ) {
            this.MemberId = MemberId;
        }
        if ( Project != null ) {
            this.Project = Project;
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
        //      C# -> OpenstackImageMemberStatus? Status
        // GraphQL -> status: OpenstackImageMemberStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "imageId\n" ;
            } else {
                s += ind + "imageId\n" ;
            }
        }
        //      C# -> System.String? MemberId
        // GraphQL -> memberId: String! (scalar)
        if (this.MemberId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memberId\n" ;
            } else {
                s += ind + "memberId\n" ;
            }
        }
        //      C# -> OpenstackProject? Project
        // GraphQL -> project: OpenstackProject (type)
        if (this.Project != null) {
            var fspec = this.Project.AsFieldSpec(conf.Child("project"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "project" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> OpenstackImageMemberStatus? Status
        // GraphQL -> status: OpenstackImageMemberStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new OpenstackImageMemberStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (ec.Includes("imageId",true))
        {
            if(this.ImageId == null) {

                this.ImageId = "FETCH";

            } else {


            }
        }
        else if (this.ImageId != null && ec.Excludes("imageId",true))
        {
            this.ImageId = null;
        }
        //      C# -> System.String? MemberId
        // GraphQL -> memberId: String! (scalar)
        if (ec.Includes("memberId",true))
        {
            if(this.MemberId == null) {

                this.MemberId = "FETCH";

            } else {


            }
        }
        else if (this.MemberId != null && ec.Excludes("memberId",true))
        {
            this.MemberId = null;
        }
        //      C# -> OpenstackProject? Project
        // GraphQL -> project: OpenstackProject (type)
        if (ec.Includes("project",false))
        {
            if(this.Project == null) {

                this.Project = new OpenstackProject();
                this.Project.ApplyExploratoryFieldSpec(ec.NewChild("project"));

            } else {

                this.Project.ApplyExploratoryFieldSpec(ec.NewChild("project"));

            }
        }
        else if (this.Project != null && ec.Excludes("project",false))
        {
            this.Project = null;
        }
    }


    #endregion

    } // class OpenstackImageMember
    
    #endregion

    public static class ListOpenstackImageMemberExtensions
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
            this List<OpenstackImageMember> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OpenstackImageMember> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OpenstackImageMember> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OpenstackImageMember());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OpenstackImageMember> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types