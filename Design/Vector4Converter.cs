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
using System.ComponentModel;
using System.Globalization;
#endregion

namespace Microsoft.Xna.Framework.Design
{
	public class Vector4Converter : TypeConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (VectorConversion.CanConvertTo(context, destinationType))
			{
				return true;
			}
			if (destinationType == typeof(string))
			{
				return true;
			}

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			Vector4 vec = (Vector4) value;

			if (VectorConversion.CanConvertTo(context, destinationType))
			{
				return VectorConversion.ConvertToFromVector4(context, culture, vec, destinationType);
			}

			if (destinationType == typeof(string))
			{
				string[] terms = new string[3];
				terms[0] = vec.X.ToString(culture);
				terms[1] = vec.Y.ToString(culture);
				terms[2] = vec.Z.ToString(culture);
				terms[3] = vec.W.ToString(culture);

				return string.Join(culture.NumberFormat.NumberGroupSeparator, terms);
			}

			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == typeof(string))
			{
				return true;
			}

			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			Type sourceType = value.GetType();
			Vector4 vec = Vector4.Zero;

			if (sourceType == typeof(string))
			{
				string str = (string) value;
				string[] words = str.Split(culture.NumberFormat.NumberGroupSeparator.ToCharArray());

				vec.X = float.Parse(words[0], culture);
				vec.Y = float.Parse(words[1], culture);
				vec.Z = float.Parse(words[2], culture);
				vec.W = float.Parse(words[3], culture);

				return vec;
			}

			return base.ConvertFrom(context, culture, value);
		}
	}
}
