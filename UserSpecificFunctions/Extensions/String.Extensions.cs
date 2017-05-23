﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace UserSpecificFunctions.Extensions
{
	/// <summary>
	/// Provides extensions for the <see cref="String"/> type.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Attempts to parse a color from the given string.
		/// </summary>
		/// <param name="color">The color.</param>
		/// <returns>A <see cref="Color"/> object.</returns>
		public static Color ParseColor(this string color)
		{
			byte r, g, b;
			string[] colorPayload = color.Split(',');
			if (colorPayload.Length != 3)
			{
				throw new ArgumentException("The color provided was not in the correct format.", nameof(color));
			}
			else if (!byte.TryParse(colorPayload[0], out r))
			{
				throw new ArgumentException("The color provided was not in the correct format.", nameof(color));
			}
			else if (!byte.TryParse(colorPayload[1], out g))
			{
				throw new ArgumentException("The color provided was not in the correct format.", nameof(color));
			}
			else if (!byte.TryParse(colorPayload[2], out b))
			{
				throw new ArgumentException("The color provided was not in the correct format.", nameof(color));
			}
			else
			{
				return new Color(r, g, b);
			}
		}
	}
}