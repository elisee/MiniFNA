#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2014 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

#region Using Statements
using System;
#endregion

namespace Microsoft.Xna.Framework.Input
{
	/// <summary>
	/// Enumerates input device buttons.
	/// </summary>
	[Flags]
	public enum Buttons
	{
		/// <summary>
		/// Directional pad down
		/// </summary>
		DPadUp = 1,
		/// <summary>
		/// Directional pad up
		/// </summary>
		DPadDown = 2,
		/// <summary>
		/// Directional pad left
		/// </summary>
		DPadLeft = 4,
		/// <summary>
		/// Directional pad right
		/// </summary>
		DPadRight = 8,
		/// <summary>
		/// START button
		/// </summary>
		Start = 16,
		/// <summary>
		/// BACK button
		/// </summary>
		Back = 32,
		/// <summary>
		/// Left stick button (pressing the left stick)
		/// </summary>
		LeftStick = 64,
		/// <summary>
		/// Right stick button (pressing the right stick)
		/// </summary>
		RightStick = 128,
		/// <summary>
		/// Left bumper (shoulder) button
		/// </summary>
		LeftShoulder = 256,
		/// <summary>
		/// Right bumper (shoulder) button
		/// </summary>
		RightShoulder = 512,
		/// <summary>
		/// Big button
		/// </summary>
		BigButton = 2048,
		/// <summary>
		/// A button
		/// </summary>
		A = 4096,
		/// <summary>
		/// B button
		/// </summary>
		B = 8192,
		/// <summary>
		/// X button
		/// </summary>
		X = 16384,
		/// <summary>
		/// Y button
		/// </summary>
		Y = 32768,
		/// <summary>
		/// Left stick is towards the left
		/// </summary>
		LeftThumbstickLeft = 2097152,
		/// <summary>
		/// Right trigger
		/// </summary>
		RightTrigger = 4194304,
		/// <summary>
		/// Left trigger
		/// </summary>
		LeftTrigger = 8388608,
		/// <summary>
		/// Right stick is towards up
		/// </summary>
		RightThumbstickUp = 16777216,
		/// <summary>
		/// Right stick is towards down
		/// </summary>
		RightThumbstickDown = 33554432,
		/// <summary>
		/// Right stick is towards the right
		/// </summary>
		RightThumbstickRight = 67108864,
		/// <summary>
		/// Right stick is towards the left
		/// </summary>
		RightThumbstickLeft = 134217728,
		/// <summary>
		/// Left stick is towards up
		/// </summary>
		LeftThumbstickUp = 268435456,
		/// <summary>
		/// Left stick is towards down
		/// </summary>
		LeftThumbstickDown = 536870912,
		/// <summary>
		/// Left stick is towards the right
		/// </summary>
		LeftThumbstickRight = 1073741824,
	}
}
