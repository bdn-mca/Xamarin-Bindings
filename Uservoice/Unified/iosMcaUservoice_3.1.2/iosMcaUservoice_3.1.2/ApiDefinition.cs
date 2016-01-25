using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace iosMcaUservoice_3_1_2
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, nint index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//
	[BaseType (typeof (NSObject))]
	public partial interface UVConfig {

		[Static, Export ("configWithSite:")]
		UVConfig ConfigWithSite (string site);

		[Static, Export ("configWithSite:andKey:andSecret:")]
		UVConfig ConfigWithSite (string site, string key, string secret);

		[Static, Export ("configWithSite:andKey:andSecret:andSSOToken:")]
		UVConfig ConfigWithSite (string site, string key, string secret, string token);

		[Static, Export ("configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		UVConfig ConfigWithSite (string site, string key, string secret, string email, string displayName, string guid);

		[Export ("site", ArgumentSemantic.Retain)]
		string Site { get; set; }

		[Export ("key", ArgumentSemantic.Retain)]
		string Key { get; set; }

		[Export ("secret", ArgumentSemantic.Retain)]
		string Secret { get; set; }

		[Export ("ssoToken", ArgumentSemantic.Retain)]
		string SsoToken { get; set; }

		[Export ("displayName", ArgumentSemantic.Retain)]
		string DisplayName { get; set; }

		[Export ("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export ("guid", ArgumentSemantic.Retain)]
		string Guid { get; set; }

		[Export ("customFields", ArgumentSemantic.Retain)]
		NSDictionary CustomFields { get; set; }

		[Export ("topicId")]
		nint TopicId { get; set; }

		[Export ("forumId")]
		nint ForumId { get; set; }

		[Export ("showForum")]
		bool ShowForum { get; set; }

		[Export ("showPostIdea")]
		bool ShowPostIdea { get; set; }

		[Export ("showContactUs")]
		bool ShowContactUs { get; set; }

		[Export ("showKnowledgeBase")]
		bool ShowKnowledgeBase { get; set; }

		[Export ("extraTicketInfo", ArgumentSemantic.Retain)]
		string ExtraTicketInfo { get; set; }

		[Export ("userTraits", ArgumentSemantic.Retain)]
		NSDictionary UserTraits { get; set; }

		[Export ("identifyUserWithEmail:name:guid:")]
		void IdentifyUserWithEmail (string email, string name, string guid);

		[Export ("traits")]
		NSDictionary Traits { get; }

		[Export ("addAttachmentNamed:contentType:base64EncodedData:")]
		void AddAttachmentNamed (string fileName, string contentType, string data);

		[Export ("attachments")]
		NSObject [] Attachments { get; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface UVDelegate {

		[Export ("userVoiceWasDismissed")]
		void UserVoiceWasDismissed ();

		[Export ("userVoiceRequestsDismissal")]
		void UserVoiceRequestsDismissal ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface UVStyleSheet {

		[Static, Export ("instance")]
		UVStyleSheet Instance { get; }

		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		[Export ("tableViewBackgroundColor", ArgumentSemantic.Retain)]
		UIColor TableViewBackgroundColor { get; set; }

		[Export ("navigationBarBackgroundColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarBackgroundColor { get; set; }

		[Export ("navigationBarTextColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarTextColor { get; set; }

		[Export ("navigationBarTextShadowColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarTextShadowColor { get; set; }

		[Export ("navigationBarBackgroundImage", ArgumentSemantic.Retain)]
		UIImage NavigationBarBackgroundImage { get; set; }

		[Export ("navigationBarFont", ArgumentSemantic.Retain)]
		UIFont NavigationBarFont { get; set; }

		[Export ("navigationBarTintColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarTintColor { get; set; }

		[Export ("navigationBarActivityIndicatorColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarActivityIndicatorColor { get; set; }

		[Export ("loadingViewBackgroundColor", ArgumentSemantic.Retain)]
		UIColor LoadingViewBackgroundColor { get; set; }

		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface UserVoice {

		[Static, Export ("initialize:")]
		void Initialize (UVConfig config);

		[Static, Export ("presentUserVoiceInterfaceForParentViewController:")]
		void PresentUserVoiceInterfaceForParentViewController (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceContactUsFormForParentViewController:")]
		void PresentUserVoiceContactUsFormForParentViewController (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceNewIdeaFormForParentViewController:")]
		void PresentUserVoiceNewIdeaFormForParentViewController (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceForumForParentViewController:")]
		void PresentUserVoiceForumForParentViewController (UIViewController parentViewController);

		[Static, Export ("getUserVoiceContactUsFormForModalDisplay")]
		UIViewController GetUserVoiceContactUsFormForModalDisplay { get; }

		[Static, Export ("delegate")]
		UVDelegate Delegate { get; set; }

		[Static, Export ("bundle")]
		NSBundle Bundle { get; }

		[Static, Export ("version")]
		string Version { get; }

		[Static, Export ("setExternalId:forScope:")]
		void SetExternalId (string identifier, string scope);

		[Static, Export ("track:")]
		void Track (string eventProp);

		[Static, Export ("track:properties:")]
		void Track (string eventProp, NSDictionary properties);

		[Static, Export ("presentUserVoiceInterfaceForParentViewController:andConfig:")]
		void PresentUserVoiceInterfaceForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceContactUsFormForParentViewController:andConfig:")]
		void PresentUserVoiceContactUsFormForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceNewIdeaFormForParentViewController:andConfig:")]
		void PresentUserVoiceNewIdeaFormForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceForumForParentViewController:andConfig:")]
		void PresentUserVoiceForumForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:")]
		void PresentUserVoiceModalViewControllerForParent (UIViewController viewController, string site, string key, string secret);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:")]
		void PresentUserVoiceModalViewControllerForParent (UIViewController viewController, string site, string key, string secret, string token);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		void PresentUserVoiceModalViewControllerForParent (UIViewController viewController, string site, string key, string secret, string email, string displayName, string guid);
	}
}