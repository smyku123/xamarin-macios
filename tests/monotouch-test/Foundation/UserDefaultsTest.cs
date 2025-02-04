//
// Unit tests for NSUserDefaults
//
// Authors:
//	Sebastien Pouliot <sebastien@xamarin.com>
//
// Copyright 2012 Xamarin Inc. All rights reserved.
//

using System;
using System.Diagnostics;
using Foundation;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif
using ObjCRuntime;
using NUnit.Framework;
using Xamarin.Utils;

namespace MonoTouchFixtures.Foundation {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class UserDefaultsTest {

		[Test]
		public void SetString ()
		{
			// confusing API for .NET developers since the parameters are 'value', 'key'
			// http://stackoverflow.com/q/12415054/220643
			NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;
			var keyName = $"spid-{Process.GetCurrentProcess ().Id}";
			defaults.RemoveObject (keyName);
			Assert.Null (defaults.StringForKey (keyName), "StringForKey-1");
			defaults.SetString ("coucou", keyName);
			defaults.Synchronize ();
			Assert.That (defaults.StringForKey (keyName), Is.EqualTo ("coucou"), "StringForKey-2");
		}

		[Test]
		public void Ctor_UserName ()
		{
			var userName = $"username-{Process.GetCurrentProcess ().Id}";
			// initWithUser:
			using (var ud = new NSUserDefaults (userName)) {
				Assert.That (ud.RetainCount, Is.EqualTo ((nuint) 1), "RetainCount");
				ud.SetString ("value", "key");
				ud.Synchronize ();
			}

			using (var ud = new NSUserDefaults (userName, NSUserDefaultsType.UserName)) {
				Assert.That (ud.RetainCount, Is.EqualTo ((nuint) 1), "RetainCount");
				Assert.That (ud ["key"].ToString (), Is.EqualTo ("value"), "[key]-1");
				ud.RemoveObject ("key");
				ud.Synchronize ();
				Assert.Null (ud ["key"], "[key]-2");
			}
		}

		[Test]
		public void Ctor_SuiteName ()
		{
			TestRuntime.AssertXcodeVersion (5, 0);
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);

			// initWithSuiteName:
			var suiteName = $"suitename-{Process.GetCurrentProcess ().Id}";
			using (var ud = new NSUserDefaults (suiteName, NSUserDefaultsType.SuiteName)) {
				Assert.That (ud.RetainCount, Is.EqualTo ((nuint) 1), "RetainCount");
			}
		}
	}
}
