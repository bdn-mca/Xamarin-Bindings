# Xamarin-Bindings

Using A/B Testing with this MixPanel library will require you to override and use the 'Window' property in your AppDelegate class.


First you override it:

public override UIWindow Window { get; set; }


Then in FinishedLaunching():

Window = new UIWindow(UIScreen.MainScreen.Bounds);

Window.RootViewController = new MyFirstViewController(true);

Window.MakeKeyAndVisible();



Otherwise it will throw 'Unrecognised selector sent to instance' when you try to create A/B Test.