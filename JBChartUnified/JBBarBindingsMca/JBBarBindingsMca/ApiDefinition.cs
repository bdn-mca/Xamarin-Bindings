using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace JBBarBindingsMca
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






	[BaseType (typeof (UIView)) ]
	public partial interface JBChartView {

		[Export ("dataSource", ArgumentSemantic.Assign)]
		JBChartViewDataSource DataSource { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		JBChartViewDelegate Delegate { get; set; }

		[Export ("footerView", ArgumentSemantic.Retain)]
		UIView FooterView { get; set; }

		[Export ("headerView", ArgumentSemantic.Retain)]
		UIView HeaderView { get; set; }

		[Export ("headerPadding")]
		nfloat HeaderPadding { get; set; }

		[Export ("footerPadding")]
		nfloat FooterPadding { get; set; }

		[Export ("minimumValue")]
		nfloat MinimumValue { get; set; }

		[Export ("maximumValue")]
		nfloat MaximumValue { get; set; }

		[Export ("resetMinimumValue")]
		void ResetMinimumValue ();

		[Export ("resetMaximumValue")]
		void ResetMaximumValue ();

		[Export ("state")]
		JBChartViewState State { get; set; }

		[Export ("reloadData")]
		void ReloadData ();

		//		[Export ("setState:animated:force:callback:")]
		//		void SetState (JBChartViewState state, bool animated, bool force, Delegate callback);
		//
		//		[Export ("setState:animated:callback:")]
		//		void SetState (JBChartViewState state, bool animated, Delegate callback);

		[Export ("setState:animated:")]
		void SetState (JBChartViewState state, bool animated);
	}



    [Model, Protocol, BaseType (typeof (NSObject))]
	public partial interface JBBarChartViewDataSource : JBChartViewDataSource {

		[Export ("numberOfBarsInBarChartView:")]
		uint NumberOfBarsInBarChartView (JBBarChartView barChartView);

		[Export ("barChartView:barViewAtIndex:")]
		UIView BarChartView (JBBarChartView barChartView, uint index);
	}



    [Model, Protocol, BaseType (typeof (NSObject))]
	public partial interface JBBarChartViewDelegate : JBChartViewDelegate {

		[Export ("barChartView:heightForBarViewAtIndex:")]
		nfloat HeightForBarViewAtIndex (JBBarChartView barChartView, uint index);

		[Export ("barChartView:didSelectBarAtIndex:touchPoint:")]
		void DidSelectBarAtIndex (JBBarChartView barChartView, uint index, PointF touchPoint);

		[Export ("barChartView:didSelectBarAtIndex:")]
		void DidSelectBarAtIndex (JBBarChartView barChartView, uint index);

		[Export ("didDeselectBarChartView:")]
		void  DidDeselectBarChartView(JBBarChartView barChartView);

		[Export ("barChartView:colorForBarViewAtIndex:")]
		UIColor ColorForBarViewAtIndex (JBBarChartView barChartView, uint index);

		[Export ("barSelectionColorForBarChartView:")]
		UIColor BarSelectionColorForBarChartView (JBBarChartView barChartView);

		[Export ("barPaddingForBarChartView:")]
		nfloat  BarPaddingForBarChartView(JBBarChartView barChartView);
	}

	[BaseType (typeof (JBChartView))]
	public partial interface JBBarChartView {


		[Export ("dataSource", ArgumentSemantic.Assign)]
		JBBarChartViewDataSource DataSource { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		JBBarChartViewDelegate Delegate { get; set;  }

		[Export ("showsVerticalSelection")]
		bool ShowsVerticalSelection { get; set; }

		[Export ("inverted")]
		bool Inverted { [Bind ("isInverted")] get; set; }

		[Field ("kJBChartViewDefaultAnimationDuration","__Internal")]
		nfloat JBChartViewDefaultAnimationDuration { get; }
	}


	[Model, BaseType (typeof (NSObject))] //Addwed
	public partial interface JBChartViewDataSource {

		[Export ("shouldExtendSelectionViewIntoHeaderPaddingForChartView:")]
		bool ShouldExtendSelectionViewIntoHeaderPaddingForChartView (JBChartView chartView);

		[Export ("shouldExtendSelectionViewIntoFooterPaddingForChartView:")]
		bool ShouldExtendSelectionViewIntoFooterPaddingForChartView (JBChartView chartView);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface JBChartViewDelegate {


	}


	[BaseType (typeof (UIView))]
	public partial interface JBChartVerticalSelectionView {

		[Export ("bgColor", ArgumentSemantic.Retain)]
		UIColor BgColor { get; set; }

		[Field ("kJBChartViewDefaultAnimationDuration","__Internal")]
		nfloat JBChartViewDefaultAnimationDuration { get; }
	}





	[Model, BaseType (typeof (NSObject))] //Added
	public partial interface JBLineChartViewDataSource : JBChartViewDataSource {

		[Export ("numberOfLinesInLineChartView:")]
		uint NumberOfLinesInLineChartView (JBLineChartView lineChartView);

		[Export ("lineChartView:numberOfVerticalValuesAtLineIndex:")]
		uint LineChartViewNumberOfVerticalValuesAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:showsDotsForLineAtLineIndex:")]
		bool LineChartViewShowDotsAtLineIndex(JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:smoothLineAtLineIndex:")]
		bool LineChartViewSmoothLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:dotViewAtHorizontalIndex:atLineIndex:")]
		UIView LineChartViewdotViewAtHorizontalIndex (JBLineChartView lineChartView, uint horizontalIndex, uint lineIndex);

		[Export ("lineChartView:shouldHideDotViewOnSelectionAtHorizontalIndex:atLineIndex:")]
		bool LineChartViewshouldHideDotViewOnSelectionAtHorizontalIndex (JBLineChartView lineChartView, uint horizontalIndex, uint lineIndex);
	}

	[Model, BaseType (typeof (NSObject))] //Added
	public partial interface JBLineChartViewDelegate : JBChartViewDelegate {

		[Export ("lineChartView:verticalValueForHorizontalIndex:atLineIndex:")]
		nfloat VerticalValueForHorizontalIndex (JBLineChartView lineChartView, uint horizontalIndex, uint lineIndex);

		[Export ("lineChartView:didSelectLineAtIndex:horizontalIndex:touchPoint:")]
		void DidSelectLineAtIndex (JBLineChartView lineChartView, uint lineIndex, uint horizontalIndex, PointF touchPoint);

		[Export ("lineChartView:didSelectLineAtIndex:horizontalIndex:")]
		void DidSelectLineAtIndex (JBLineChartView lineChartView, uint lineIndex, uint horizontalIndex);

		[Export ("didDeselectLineInLineChartView:")]
		void  DidDeselectLineInLineChartView(JBLineChartView lineChartView);

		[Export ("lineChartView:colorForLineAtLineIndex:")]
		UIColor ColorForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:fillColorForLineAtLineIndex:")]
		UIColor FillColorForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:colorForDotAtHorizontalIndex:atLineIndex:")]
		UIColor ColorForDotAtHorizontalIndex (JBLineChartView lineChartView, uint horizontalIndex, uint lineIndex);

		[Export ("lineChartView:widthForLineAtLineIndex:")]
		nfloat WidthForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:dotRadiusForDotAtHorizontalIndex:atLineIndex:")]
		nfloat DotRadiusForDotAtHorizontalIndex (JBLineChartView lineChartView, uint horizontalIndex, uint lineIndex);

		[Export ("verticalSelectionWidthForLineChartView:")]
		nfloat  VerticalSelectionWidthForLineChartView(JBLineChartView lineChartView);

		[Export ("lineChartView:verticalSelectionColorForLineAtLineIndex:")]
		UIColor VerticalSelectionColorForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:selectionColorForLineAtLineIndex:")]
		UIColor SelectionColorForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:selectionFillColorForLineAtLineIndex:")]
		UIColor SelectionFillColorForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);

		[Export ("lineChartView:selectionColorForDotAtHorizontalIndex:atLineIndex:")]
		UIColor SelectionColorForDotAtHorizontalIndex (JBLineChartView lineChartView, uint horizontalIndex, uint lineIndex);

		[Export ("lineChartView:lineStyleForLineAtLineIndex:")]
		JBLineChartViewLineStyle LineStyleForLineAtLineIndex (JBLineChartView lineChartView, uint lineIndex);
	}

	[BaseType (typeof (JBChartView))]
	public partial interface JBLineChartView {

		[Export ("dataSource", ArgumentSemantic.Assign)]
		JBLineChartViewDataSource DataSource { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		JBLineChartViewDelegate Delegate { get; set; }

		[Export ("showsVerticalSelection")]
		bool ShowsVerticalSelection { get; set; }

		[Export ("showsLineSelection")]
		bool ShowsLineSelection { get; set; }
	}


	[BaseType (typeof (UIView))]
	public partial interface JBChartTooltipView {

		[Export ("text")]
		string Text { set; }

		[Field ("kJBChartViewDefaultAnimationDuration","__Internal")]
		nfloat JBChartViewDefaultAnimationDuration { get; }
	}
}

