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
	/// <summary>Settings </summary>
	[PublishedModel("settingsPage")]
	public partial class SettingsPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "settingsPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SettingsPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SettingsPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// call-back-button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackButton")]
		public virtual string CallBackButton => this.Value<string>(_publishedValueFallback, "callBackButton");

		///<summary>
		/// call-back-button-type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackButtonType")]
		public virtual string CallBackButtonType => this.Value<string>(_publishedValueFallback, "callBackButtonType");

		///<summary>
		/// call-back-Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackHeadline")]
		public virtual string CallBackHeadline => this.Value<string>(_publishedValueFallback, "callBackHeadline");

		///<summary>
		/// call-back-options 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackOptions01")]
		public virtual string CallBackOptions01 => this.Value<string>(_publishedValueFallback, "callBackOptions01");

		///<summary>
		/// call-back-options 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackOptions02")]
		public virtual string CallBackOptions02 => this.Value<string>(_publishedValueFallback, "callBackOptions02");

		///<summary>
		/// call-back-options 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackOptions03")]
		public virtual string CallBackOptions03 => this.Value<string>(_publishedValueFallback, "callBackOptions03");

		///<summary>
		/// call-back-P
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackP")]
		public virtual string CallBackP => this.Value<string>(_publishedValueFallback, "callBackP");

		///<summary>
		/// call-back-placeholder 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackPlaceholder01")]
		public virtual string CallBackPlaceholder01 => this.Value<string>(_publishedValueFallback, "callBackPlaceholder01");

		///<summary>
		/// call-back-placeholder 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackPlaceholder02")]
		public virtual string CallBackPlaceholder02 => this.Value<string>(_publishedValueFallback, "callBackPlaceholder02");

		///<summary>
		/// call-back-placeholder 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackPlaceholder03")]
		public virtual string CallBackPlaceholder03 => this.Value<string>(_publishedValueFallback, "callBackPlaceholder03");

		///<summary>
		/// call-back-placeholder 04
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackPlaceholder04")]
		public virtual string CallBackPlaceholder04 => this.Value<string>(_publishedValueFallback, "callBackPlaceholder04");

		///<summary>
		/// call-back-type 01
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackType01")]
		public virtual string CallBackType01 => this.Value<string>(_publishedValueFallback, "callBackType01");

		///<summary>
		/// call-back-type 02
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackType02")]
		public virtual string CallBackType02 => this.Value<string>(_publishedValueFallback, "callBackType02");

		///<summary>
		/// call-back-type 03
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callBackType03")]
		public virtual string CallBackType03 => this.Value<string>(_publishedValueFallback, "callBackType03");

		///<summary>
		/// Footer - Company Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerCompanyName")]
		public virtual string FooterCompanyName => this.Value<string>(_publishedValueFallback, "footerCompanyName");

		///<summary>
		/// Footer - Rights
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerRights")]
		public virtual string FooterRights => this.Value<string>(_publishedValueFallback, "footerRights");

		///<summary>
		/// Footer - Rights Mobile
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerRightsMobile")]
		public virtual string FooterRightsMobile => this.Value<string>(_publishedValueFallback, "footerRightsMobile");

		///<summary>
		/// Header - Facebook - Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerFacebookLink")]
		public virtual string HeaderFacebookLink => this.Value<string>(_publishedValueFallback, "headerFacebookLink");

		///<summary>
		/// Header - Instagram - Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerInstagramLink")]
		public virtual string HeaderInstagramLink => this.Value<string>(_publishedValueFallback, "headerInstagramLink");

		///<summary>
		/// Header - Link -1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLink1")]
		public virtual string HeaderLink1 => this.Value<string>(_publishedValueFallback, "headerLink1");

		///<summary>
		/// Header - Link - 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLink2")]
		public virtual string HeaderLink2 => this.Value<string>(_publishedValueFallback, "headerLink2");

		///<summary>
		/// Header - Link - 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLink3")]
		public virtual string HeaderLink3 => this.Value<string>(_publishedValueFallback, "headerLink3");

		///<summary>
		/// Header - Link - 4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLink4")]
		public virtual string HeaderLink4 => this.Value<string>(_publishedValueFallback, "headerLink4");

		///<summary>
		/// Header - Link Text - 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLinkText1")]
		public virtual string HeaderLinkText1 => this.Value<string>(_publishedValueFallback, "headerLinkText1");

		///<summary>
		/// Header - Link Text - 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLinkText2")]
		public virtual string HeaderLinkText2 => this.Value<string>(_publishedValueFallback, "headerLinkText2");

		///<summary>
		/// Header - Link Text - 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLinkText3")]
		public virtual string HeaderLinkText3 => this.Value<string>(_publishedValueFallback, "headerLinkText3");

		///<summary>
		/// Header - Link Text - 4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLinkText4")]
		public virtual string HeaderLinkText4 => this.Value<string>(_publishedValueFallback, "headerLinkText4");

		///<summary>
		/// Header - X - Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerXLink")]
		public virtual string HeaderXlink => this.Value<string>(_publishedValueFallback, "headerXLink");

		///<summary>
		/// Np - Image - Background
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npImageBackground")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops NpImageBackground => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "npImageBackground");

		///<summary>
		/// Np - Image - Dot
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npImageDot")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops NpImageDot => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "npImageDot");

		///<summary>
		/// Np - Image - Human
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npImageHuman")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops NpImageHuman => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "npImageHuman");

		///<summary>
		/// Np - P - Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npPEmail")]
		public virtual string NpPemail => this.Value<string>(_publishedValueFallback, "npPEmail");

		///<summary>
		/// Np - P - Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npPLocation")]
		public virtual string NpPlocation => this.Value<string>(_publishedValueFallback, "npPLocation");

		///<summary>
		/// Np - P - Phone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npPPhone")]
		public virtual string NpPphone => this.Value<string>(_publishedValueFallback, "npPPhone");

		///<summary>
		/// Np - Text - Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npTextEmail")]
		public virtual string NpTextEmail => this.Value<string>(_publishedValueFallback, "npTextEmail");

		///<summary>
		/// Np - Text - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npTextHeadline")]
		public virtual string NpTextHeadline => this.Value<string>(_publishedValueFallback, "npTextHeadline");

		///<summary>
		/// Np - Text - Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npTextLocation")]
		public virtual string NpTextLocation => this.Value<string>(_publishedValueFallback, "npTextLocation");

		///<summary>
		/// Np - Text - Phone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("npTextPhone")]
		public virtual string NpTextPhone => this.Value<string>(_publishedValueFallback, "npTextPhone");

		///<summary>
		/// Office Email Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("officeEmailAddress")]
		public virtual string OfficeEmailAddress => this.Value<string>(_publishedValueFallback, "officeEmailAddress");

		///<summary>
		/// Office Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("officeLocation")]
		public virtual string OfficeLocation => this.Value<string>(_publishedValueFallback, "officeLocation");

		///<summary>
		/// Office Phone Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("officePhoneNumber")]
		public virtual string OfficePhoneNumber => this.Value<string>(_publishedValueFallback, "officePhoneNumber");

		///<summary>
		/// Page Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageDescription")]
		public virtual string PageDescription => this.Value<string>(_publishedValueFallback, "pageDescription");

		///<summary>
		/// Partners - Image 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnersImage1")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnersImage1 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnersImage1");

		///<summary>
		/// Partners - Image 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnersImage2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnersImage2 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnersImage2");

		///<summary>
		/// Partners - Image 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnersImage3")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnersImage3 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnersImage3");

		///<summary>
		/// Partners - Image 4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnersImage4")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnersImage4 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnersImage4");

		///<summary>
		/// Partners - Image 5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnersImage5")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnersImage5 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnersImage5");

		///<summary>
		/// Partners - Image 6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnersImage6")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnersImage6 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnersImage6");

		///<summary>
		/// Site Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SiteLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "siteLogo");

		///<summary>
		/// Site Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteName")]
		public virtual string SiteName => this.Value<string>(_publishedValueFallback, "siteName");

		///<summary>
		/// site Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteTag")]
		public virtual global::System.Collections.Generic.IEnumerable<string> SiteTag => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "siteTag");

		///<summary>
		/// we help you Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("weHelpYouHeadline")]
		public virtual string WeHelpYouHeadline => this.Value<string>(_publishedValueFallback, "weHelpYouHeadline");

		///<summary>
		/// we help you Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("weHelpYouImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops WeHelpYouImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "weHelpYouImage");

		///<summary>
		/// we help you Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("weHelpYouText")]
		public virtual string WeHelpYouText => this.Value<string>(_publishedValueFallback, "weHelpYouText");
	}
}
