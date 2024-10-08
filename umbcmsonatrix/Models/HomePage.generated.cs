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
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// About Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutButton")]
		public virtual string AboutButton => this.Value<string>(_publishedValueFallback, "aboutButton");

		///<summary>
		/// About Form Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutFormHeadline")]
		public virtual string AboutFormHeadline => this.Value<string>(_publishedValueFallback, "aboutFormHeadline");

		///<summary>
		/// About Form Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutFormText")]
		public virtual string AboutFormText => this.Value<string>(_publishedValueFallback, "aboutFormText");

		///<summary>
		/// About Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutHeadline")]
		public virtual string AboutHeadline => this.Value<string>(_publishedValueFallback, "aboutHeadline");

		///<summary>
		/// About Input Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutInputEmail")]
		public virtual string AboutInputEmail => this.Value<string>(_publishedValueFallback, "aboutInputEmail");

		///<summary>
		/// About Input Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutInputName")]
		public virtual string AboutInputName => this.Value<string>(_publishedValueFallback, "aboutInputName");

		///<summary>
		/// About Input Phone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutInputPhone")]
		public virtual string AboutInputPhone => this.Value<string>(_publishedValueFallback, "aboutInputPhone");

		///<summary>
		/// About Quote
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutQuote")]
		public virtual string AboutQuote => this.Value<string>(_publishedValueFallback, "aboutQuote");

		///<summary>
		/// About - Section Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSectionTitle")]
		public virtual string AboutSectionTitle => this.Value<string>(_publishedValueFallback, "aboutSectionTitle");

		///<summary>
		/// About Select - Option One
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSelectOptionOne")]
		public virtual string AboutSelectOptionOne => this.Value<string>(_publishedValueFallback, "aboutSelectOptionOne");

		///<summary>
		/// About Select - Option Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSelectOptionThree")]
		public virtual string AboutSelectOptionThree => this.Value<string>(_publishedValueFallback, "aboutSelectOptionThree");

		///<summary>
		/// About Select - Option Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSelectOptionTwo")]
		public virtual string AboutSelectOptionTwo => this.Value<string>(_publishedValueFallback, "aboutSelectOptionTwo");

		///<summary>
		/// About Signature
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSignature")]
		public virtual string AboutSignature => this.Value<string>(_publishedValueFallback, "aboutSignature");

		///<summary>
		/// About - Signature Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSignatureImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AboutSignatureImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "aboutSignatureImage");

		///<summary>
		/// About Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutText")]
		public virtual string AboutText => this.Value<string>(_publishedValueFallback, "aboutText");

		///<summary>
		/// Choose - Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("chooseButton")]
		public virtual string ChooseButton => this.Value<string>(_publishedValueFallback, "chooseButton");

		///<summary>
		/// Choose - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("chooseHeadline")]
		public virtual string ChooseHeadline => this.Value<string>(_publishedValueFallback, "chooseHeadline");

		///<summary>
		/// Choose - Headline Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("chooseHeadlineTwo")]
		public virtual string ChooseHeadlineTwo => this.Value<string>(_publishedValueFallback, "chooseHeadlineTwo");

		///<summary>
		/// Choose - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("chooseImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ChooseImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "chooseImage");

		///<summary>
		/// Choose - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("chooseText")]
		public virtual string ChooseText => this.Value<string>(_publishedValueFallback, "chooseText");

		///<summary>
		/// Footer - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerHeadline")]
		public virtual string FooterHeadline => this.Value<string>(_publishedValueFallback, "footerHeadline");

		///<summary>
		/// Footer - Headline Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerHeadlineTwo")]
		public virtual string FooterHeadlineTwo => this.Value<string>(_publishedValueFallback, "footerHeadlineTwo");

		///<summary>
		/// Header - About Nav Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerAboutNavText")]
		public virtual string HeaderAboutNavText => this.Value<string>(_publishedValueFallback, "headerAboutNavText");

		///<summary>
		/// Header - About Nav Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerAboutNavUrl")]
		public virtual string HeaderAboutNavUrl => this.Value<string>(_publishedValueFallback, "headerAboutNavUrl");

		///<summary>
		/// Header - Address Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerAddressText")]
		public virtual string HeaderAddressText => this.Value<string>(_publishedValueFallback, "headerAddressText");

		///<summary>
		/// Header - Contact Nav Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerContactNavText")]
		public virtual string HeaderContactNavText => this.Value<string>(_publishedValueFallback, "headerContactNavText");

		///<summary>
		/// Header - Contact Nav Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerContactNavUrl")]
		public virtual string HeaderContactNavUrl => this.Value<string>(_publishedValueFallback, "headerContactNavUrl");

		///<summary>
		/// Header - Home Nav Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerHomeNavUrl")]
		public virtual string HeaderHomeNavUrl => this.Value<string>(_publishedValueFallback, "headerHomeNavUrl");

		///<summary>
		/// Header - Onatrix Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerOnatrixImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderOnatrixImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "headerOnatrixImage");

		///<summary>
		/// Header - Projects Nav Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerProjectsNavText")]
		public virtual string HeaderProjectsNavText => this.Value<string>(_publishedValueFallback, "headerProjectsNavText");

		///<summary>
		/// Header - Projects Nav Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerProjectsNavUrl")]
		public virtual string HeaderProjectsNavUrl => this.Value<string>(_publishedValueFallback, "headerProjectsNavUrl");

		///<summary>
		/// Header - Service Nav Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerServiceNavText")]
		public virtual string HeaderServiceNavText => this.Value<string>(_publishedValueFallback, "headerServiceNavText");

		///<summary>
		/// Header - Services Nav Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerServicesNavUrl")]
		public virtual string HeaderServicesNavUrl => this.Value<string>(_publishedValueFallback, "headerServicesNavUrl");

		///<summary>
		/// Hero - Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroButton")]
		public virtual string HeroButton => this.Value<string>(_publishedValueFallback, "heroButton");

		///<summary>
		/// Hero - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroHeadline")]
		public virtual string HeroHeadline => this.Value<string>(_publishedValueFallback, "heroHeadline");

		///<summary>
		/// Hero - Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeroImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "heroImg");

		///<summary>
		/// Hero - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroText")]
		public virtual string HeroText => this.Value<string>(_publishedValueFallback, "heroText");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Partner - Image Five
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnerImageFive")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnerImageFive => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnerImageFive");

		///<summary>
		/// Partner - Image Four
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnerImageFour")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnerImageFour => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnerImageFour");

		///<summary>
		/// Partner - Image One
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnerImageOne")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnerImageOne => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnerImageOne");

		///<summary>
		/// Partner - Image Six
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnerImageSix")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnerImageSix => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnerImageSix");

		///<summary>
		/// Partner - Image Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnerImageThree")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnerImageThree => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnerImageThree");

		///<summary>
		/// Partner - Image Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("partnerImageTwo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PartnerImageTwo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "partnerImageTwo");

		///<summary>
		/// Project - Card Headline Four
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardHeadlineFour")]
		public virtual string ProjectCardHeadlineFour => this.Value<string>(_publishedValueFallback, "projectCardHeadlineFour");

		///<summary>
		/// Project - Card Headline One
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardHeadlineOne")]
		public virtual string ProjectCardHeadlineOne => this.Value<string>(_publishedValueFallback, "projectCardHeadlineOne");

		///<summary>
		/// Project - Card Headline Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardHeadlineThree")]
		public virtual string ProjectCardHeadlineThree => this.Value<string>(_publishedValueFallback, "projectCardHeadlineThree");

		///<summary>
		/// Project - Card Headline Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardHeadlineTwo")]
		public virtual string ProjectCardHeadlineTwo => this.Value<string>(_publishedValueFallback, "projectCardHeadlineTwo");

		///<summary>
		/// Project - Card Image Four
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardImageFour")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectCardImageFour => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectCardImageFour");

		///<summary>
		/// Project - Card Image One
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardImageOne")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectCardImageOne => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectCardImageOne");

		///<summary>
		/// Project - Card Image Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardImageThree")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectCardImageThree => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectCardImageThree");

		///<summary>
		/// Project - Card Image Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardImageTwo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectCardImageTwo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectCardImageTwo");

		///<summary>
		/// Project - Card Text Four
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardTextFour")]
		public virtual string ProjectCardTextFour => this.Value<string>(_publishedValueFallback, "projectCardTextFour");

		///<summary>
		/// Project - Card Text One
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardTextOne")]
		public virtual string ProjectCardTextOne => this.Value<string>(_publishedValueFallback, "projectCardTextOne");

		///<summary>
		/// Project - Card Text Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardTextThree")]
		public virtual string ProjectCardTextThree => this.Value<string>(_publishedValueFallback, "projectCardTextThree");

		///<summary>
		/// Project - Card Text Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectCardTextTwo")]
		public virtual string ProjectCardTextTwo => this.Value<string>(_publishedValueFallback, "projectCardTextTwo");

		///<summary>
		/// Project - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectHeadline")]
		public virtual string ProjectHeadline => this.Value<string>(_publishedValueFallback, "projectHeadline");

		///<summary>
		/// Project - Section Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectSectionTitle")]
		public virtual string ProjectSectionTitle => this.Value<string>(_publishedValueFallback, "projectSectionTitle");

		///<summary>
		/// Service - Five Card Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceFiveCardHeadline")]
		public virtual string ServiceFiveCardHeadline => this.Value<string>(_publishedValueFallback, "serviceFiveCardHeadline");

		///<summary>
		/// Service - Five Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceFiveCardImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceFiveCardImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceFiveCardImage");

		///<summary>
		/// Service - Five Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceFiveCardText")]
		public virtual string ServiceFiveCardText => this.Value<string>(_publishedValueFallback, "serviceFiveCardText");

		///<summary>
		/// Service - Four Card Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceFourCardHeadline")]
		public virtual string ServiceFourCardHeadline => this.Value<string>(_publishedValueFallback, "serviceFourCardHeadline");

		///<summary>
		/// Service - Four Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceFourCardImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceFourCardImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceFourCardImage");

		///<summary>
		/// Service - Four Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceFourCardText")]
		public virtual string ServiceFourCardText => this.Value<string>(_publishedValueFallback, "serviceFourCardText");

		///<summary>
		/// Service - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceHeadline")]
		public virtual string ServiceHeadline => this.Value<string>(_publishedValueFallback, "serviceHeadline");

		///<summary>
		/// Service - Headline Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceHeadlineTwo")]
		public virtual string ServiceHeadlineTwo => this.Value<string>(_publishedValueFallback, "serviceHeadlineTwo");

		///<summary>
		/// Service - One Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceOneCardImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceOneCardImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceOneCardImage");

		///<summary>
		/// Service - One Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceOneCardText")]
		public virtual string ServiceOneCardText => this.Value<string>(_publishedValueFallback, "serviceOneCardText");

		///<summary>
		/// Service - Section Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSectionTitle")]
		public virtual string ServiceSectionTitle => this.Value<string>(_publishedValueFallback, "serviceSectionTitle");

		///<summary>
		/// Service - Six Card Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSixCardHeadline")]
		public virtual string ServiceSixCardHeadline => this.Value<string>(_publishedValueFallback, "serviceSixCardHeadline");

		///<summary>
		/// Service - Six Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSixCardImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceSixCardImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceSixCardImage");

		///<summary>
		/// Service - Six Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSixCardText")]
		public virtual string ServiceSixCardText => this.Value<string>(_publishedValueFallback, "serviceSixCardText");

		///<summary>
		/// Services - One Card Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesOneCardHeadline")]
		public virtual string ServicesOneCardHeadline => this.Value<string>(_publishedValueFallback, "servicesOneCardHeadline");

		///<summary>
		/// Service - Three Card Headline 
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceThreeCardHeadline")]
		public virtual string ServiceThreeCardHeadline => this.Value<string>(_publishedValueFallback, "serviceThreeCardHeadline");

		///<summary>
		/// Service - Three Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceThreeCardImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceThreeCardImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceThreeCardImage");

		///<summary>
		/// Service - Three Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceThreeCardText")]
		public virtual string ServiceThreeCardText => this.Value<string>(_publishedValueFallback, "serviceThreeCardText");

		///<summary>
		/// Service - Two Card Headline 
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceTwoCardHeadline")]
		public virtual string ServiceTwoCardHeadline => this.Value<string>(_publishedValueFallback, "serviceTwoCardHeadline");

		///<summary>
		/// Service - Two Card Image 
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceTwoCardImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceTwoCardImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceTwoCardImage");

		///<summary>
		/// Service - Two Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceTwoCardText")]
		public virtual string ServiceTwoCardText => this.Value<string>(_publishedValueFallback, "serviceTwoCardText");

		///<summary>
		/// Success - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successHeadline")]
		public virtual string SuccessHeadline => this.Value<string>(_publishedValueFallback, "successHeadline");

		///<summary>
		/// Success - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SuccessImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "successImage");

		///<summary>
		/// Success - Section Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successSectionTitle")]
		public virtual string SuccessSectionTitle => this.Value<string>(_publishedValueFallback, "successSectionTitle");

		///<summary>
		/// Success - Story Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryHeadline")]
		public virtual string SuccessStoryHeadline => this.Value<string>(_publishedValueFallback, "successStoryHeadline");

		///<summary>
		/// Success - Story Headline Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryHeadlineThree")]
		public virtual string SuccessStoryHeadlineThree => this.Value<string>(_publishedValueFallback, "successStoryHeadlineThree");

		///<summary>
		/// Success - Story Headline Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryHeadlineTwo")]
		public virtual string SuccessStoryHeadlineTwo => this.Value<string>(_publishedValueFallback, "successStoryHeadlineTwo");

		///<summary>
		/// Success - Story Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryText")]
		public virtual string SuccessStoryText => this.Value<string>(_publishedValueFallback, "successStoryText");

		///<summary>
		/// Success - Story Text Three
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryTextThree")]
		public virtual string SuccessStoryTextThree => this.Value<string>(_publishedValueFallback, "successStoryTextThree");

		///<summary>
		/// Success - Story Text Two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryTextTwo")]
		public virtual string SuccessStoryTextTwo => this.Value<string>(_publishedValueFallback, "successStoryTextTwo");
	}
}
