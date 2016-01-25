using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace ZSSRichTextEditorBinding
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
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
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
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //

    // @interface ZSSRichTextEditor : UIViewController <UIWebViewDelegate, HRColorPickerViewControllerDelegate, UITextViewDelegate>
    [BaseType (typeof(UIViewController))]
    interface ZSSRichTextEditor : IUIWebViewDelegate, IUITextViewDelegate// IHRColorPickerViewControllerDelegate, IUITextViewDelegate
    {
        // @property (nonatomic, strong) NSURL * baseURL;
        [Export ("baseURL", ArgumentSemantic.Strong)]
        NSUrl BaseURL { get; set; }

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
        string HTML { get; }

        // -(NSString *)getText;
        [Export ("getText")]
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
//        [Export ("addCustomToolbarItem:")]
//        void AddCustomToolbarItem (ZSSBarButtonItem item);

        // -(void)editorDidScrollWithPosition:(NSInteger)position;
        [Export ("editorDidScrollWithPosition:")]
        void EditorDidScrollWithPosition (nint position);
    }
}