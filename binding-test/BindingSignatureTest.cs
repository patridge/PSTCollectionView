//
// BindingSignatureTest.cs
//
// Author:
//       Stephane Delcroix <stephane@delcroix.org>
//
// Copyright (c) 2013 S. Delcroix
//
using System;

using TouchUnit.Bindings;
using NUnit.Framework;

using PSTCollectionView;

namespace bindingtest
{
	[TestFixture]
	public class BindingSignatureTest : ApiSignatureTest
	{
		public BindingSignatureTest ()
		{
			LogProgress = true;

			ContinueOnFailure = true;
		}

		
		protected override System.Reflection.Assembly Assembly {
			get {
				return typeof (PSTCollectionView.PSTCollectionView).Assembly;
			}
		}
	}
}

