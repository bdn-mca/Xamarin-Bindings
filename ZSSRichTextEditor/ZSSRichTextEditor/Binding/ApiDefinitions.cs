using System;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface ZSSRichTextEditor : UIViewController <UIWebViewDelegate, HRColorPickerViewControllerDelegate, UITextViewDelegate>
[BaseType (typeof(UIViewController))]
interface ZSSRichTextEditor : IUIWebViewDelegate, IHRColorPickerViewControllerDelegate, IUITextViewDelegate
{
	// @property (nonatomic, strong) NSURL * baseURL;
	[Export ("baseURL", ArgumentSemantic.Strong)]
	NSURL BaseURL { get; set; }

	// @property (nonatomic) BOOL formatHTML;
	[Export ("formatHTML")]
	bool FormatHTML { get; set; }

	// @property (nonatomic) BOOL shouldShowKeyboard;
	[Export ("shouldShowKeyboard")]
	bool ShouldShowKeyboard { get; set; }

	// @property (nonatomic, strong) NSString * placeholder;
	[Export ("placeholder", ArgumentSemantic.Strong)]
	string Placeholder { get; set; }

	// @property (nonatomic, strong) NSArray * enabledToolbarItems;
	[Export ("enabledToolbarItems", ArgumentSemantic.Strong)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] EnabledToolbarItems { get; set; }

	// @property (nonatomic, strong) UIColor * toolbarItemTintColor;
	[Export ("toolbarItemTintColor", ArgumentSemantic.Strong)]
	UIColor ToolbarItemTintColor { get; set; }

	// @property (nonatomic, strong) UIColor * toolbarItemSelectedTintColor;
	[Export ("toolbarItemSelectedTintColor", ArgumentSemantic.Strong)]
	UIColor ToolbarItemSelectedTintColor { get; set; }

	// -(void)setHTML:(NSString *)html;
	[Export ("setHTML:")]
	void SetHTML (string html);

	// -(NSString *)getHTML;
	[Export ("getHTML")]
	[Verify (MethodToProperty)]
	string HTML { get; }

	// -(NSString *)getText;
	[Export ("getText")]
	[Verify (MethodToProperty)]
	string Text { get; }

	// -(void)insertHTML:(NSString *)html;
	[Export ("insertHTML:")]
	void InsertHTML (string html);

	// -(void)focusTextEditor;
	[Export ("focusTextEditor")]
	void FocusTextEditor ();

	// -(void)blurTextEditor;
	[Export ("blurTextEditor")]
	void BlurTextEditor ();

	// -(void)showInsertImageDialogWithLink:(NSString *)url alt:(NSString *)alt;
	[Export ("showInsertImageDialogWithLink:alt:")]
	void ShowInsertImageDialogWithLink (string url, string alt);

	// -(void)insertImage:(NSString *)url alt:(NSString *)alt;
	[Export ("insertImage:alt:")]
	void InsertImage (string url, string alt);

	// -(void)showInsertLinkDialogWithLink:(NSString *)url title:(NSString *)title;
	[Export ("showInsertLinkDialogWithLink:title:")]
	void ShowInsertLinkDialogWithLink (string url, string title);

	// -(void)insertLink:(NSString *)url title:(NSString *)title;
	[Export ("insertLink:title:")]
	void InsertLink (string url, string title);

	// -(void)showInsertURLAlternatePicker;
	[Export ("showInsertURLAlternatePicker")]
	void ShowInsertURLAlternatePicker ();

	// -(void)showInsertImageAlternatePicker;
	[Export ("showInsertImageAlternatePicker")]
	void ShowInsertImageAlternatePicker ();

	// -(void)dismissAlertView;
	[Export ("dismissAlertView")]
	void DismissAlertView ();

	// -(void)addCustomToolbarItemWithButton:(UIButton *)button;
	[Export ("addCustomToolbarItemWithButton:")]
	void AddCustomToolbarItemWithButton (UIButton button);

	// -(void)addCustomToolbarItem:(ZSSBarButtonItem *)item;
	[Export ("addCustomToolbarItem:")]
	void AddCustomToolbarItem (ZSSBarButtonItem item);

	// -(void)editorDidScrollWithPosition:(NSInteger)position;
	[Export ("editorDidScrollWithPosition:")]
	void EditorDidScrollWithPosition (nint position);
}
