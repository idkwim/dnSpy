﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnSpy.Contracts.Hex;

namespace dnSpy.AsmEditor.Hex.Nodes {
	static class NormalizedHexChangeCollectionExtensions {
		public static bool OverlapsWith(this NormalizedHexChangeCollection changes, HexSpan span) {
			foreach (var change in changes) {
				if (change.OldSpan.OverlapsWith(span))
					return true;
			}
			return false;
		}
	}
}
