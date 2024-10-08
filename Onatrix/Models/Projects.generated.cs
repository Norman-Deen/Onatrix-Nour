//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Projects</summary>
	[PublishedModel("projects")]
	public partial class Projects : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "projects";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Projects, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Projects(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// LOur Projects Date 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsDate01")]
		public virtual string LOurProjectsDate01 => this.Value<string>(_publishedValueFallback, "lOurProjectsDate01");

		///<summary>
		/// LOur Projects Date 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsDate02")]
		public virtual string LOurProjectsDate02 => this.Value<string>(_publishedValueFallback, "lOurProjectsDate02");

		///<summary>
		/// LOur Projects Date 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsDate03")]
		public virtual string LOurProjectsDate03 => this.Value<string>(_publishedValueFallback, "lOurProjectsDate03");

		///<summary>
		/// LOur Projects Date 04
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsDate04")]
		public virtual string LOurProjectsDate04 => this.Value<string>(_publishedValueFallback, "lOurProjectsDate04");

		///<summary>
		/// LOur Projects Headline 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsHeadline01")]
		public virtual string LOurProjectsHeadline01 => this.Value<string>(_publishedValueFallback, "lOurProjectsHeadline01");

		///<summary>
		/// LOur Projects Headline 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsHeadline02")]
		public virtual string LOurProjectsHeadline02 => this.Value<string>(_publishedValueFallback, "lOurProjectsHeadline02");

		///<summary>
		/// LOur Projects Headline 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsHeadline03")]
		public virtual string LOurProjectsHeadline03 => this.Value<string>(_publishedValueFallback, "lOurProjectsHeadline03");

		///<summary>
		/// LOur Projects Headline 04
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsHeadline04")]
		public virtual string LOurProjectsHeadline04 => this.Value<string>(_publishedValueFallback, "lOurProjectsHeadline04");

		///<summary>
		/// LOur Projects Image 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsImage01")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LOurProjectsImage01 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "lOurProjectsImage01");

		///<summary>
		/// LOur Projects Image 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsImage02")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LOurProjectsImage02 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "lOurProjectsImage02");

		///<summary>
		/// LOur Projects Image 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsImage03")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LOurProjectsImage03 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "lOurProjectsImage03");

		///<summary>
		/// LOur Projects Image 04
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsImage04")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LOurProjectsImage04 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "lOurProjectsImage04");

		///<summary>
		/// LOur Projects TextP 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsTextP01")]
		public virtual string LOurProjectsTextP01 => this.Value<string>(_publishedValueFallback, "lOurProjectsTextP01");

		///<summary>
		/// LOur Projects TextP 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsTextP02")]
		public virtual string LOurProjectsTextP02 => this.Value<string>(_publishedValueFallback, "lOurProjectsTextP02");

		///<summary>
		/// LOur Projects TextP 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsTextP03")]
		public virtual string LOurProjectsTextP03 => this.Value<string>(_publishedValueFallback, "lOurProjectsTextP03");

		///<summary>
		/// LOur Projects TextP 04
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lOurProjectsTextP04")]
		public virtual string LOurProjectsTextP04 => this.Value<string>(_publishedValueFallback, "lOurProjectsTextP04");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Projects- Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectsBackgroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectsBackgroundImage");

		///<summary>
		/// Projects Details Link 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsDetailsLink01")]
		public virtual string ProjectsDetailsLink01 => this.Value<string>(_publishedValueFallback, "projectsDetailsLink01");

		///<summary>
		/// Projects- Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsHeadline")]
		public virtual string ProjectsHeadline => this.Value<string>(_publishedValueFallback, "projectsHeadline");

		///<summary>
		/// Projects- Link 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsLink1")]
		public virtual string ProjectsLink1 => this.Value<string>(_publishedValueFallback, "projectsLink1");

		///<summary>
		/// Projects- Link 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsLink2")]
		public virtual string ProjectsLink2 => this.Value<string>(_publishedValueFallback, "projectsLink2");

		///<summary>
		/// Projects- Link Text 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsLinkText1")]
		public virtual string ProjectsLinkText1 => this.Value<string>(_publishedValueFallback, "projectsLinkText1");

		///<summary>
		/// Projects- Link Text 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsLinkText2")]
		public virtual string ProjectsLinkText2 => this.Value<string>(_publishedValueFallback, "projectsLinkText2");

		///<summary>
		/// Right - Tag 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag01")]
		public virtual string RightTag01 => this.Value<string>(_publishedValueFallback, "rightTag01");

		///<summary>
		/// Right - Tag 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag02")]
		public virtual string RightTag02 => this.Value<string>(_publishedValueFallback, "rightTag02");

		///<summary>
		/// Right - Tag 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag03")]
		public virtual string RightTag03 => this.Value<string>(_publishedValueFallback, "rightTag03");

		///<summary>
		/// Right - Tag 04
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag04")]
		public virtual string RightTag04 => this.Value<string>(_publishedValueFallback, "rightTag04");

		///<summary>
		/// Right - Tag 05
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag05")]
		public virtual string RightTag05 => this.Value<string>(_publishedValueFallback, "rightTag05");

		///<summary>
		/// Right - Tag 06
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag06")]
		public virtual string RightTag06 => this.Value<string>(_publishedValueFallback, "rightTag06");

		///<summary>
		/// Right - Tag 07
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag07")]
		public virtual string RightTag07 => this.Value<string>(_publishedValueFallback, "rightTag07");

		///<summary>
		/// Right - Tag 08
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTag08")]
		public virtual string RightTag08 => this.Value<string>(_publishedValueFallback, "rightTag08");

		///<summary>
		/// Right - Tag HeadLine
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightTagHeadLine")]
		public virtual string RightTagHeadLine => this.Value<string>(_publishedValueFallback, "rightTagHeadLine");
	}
}
