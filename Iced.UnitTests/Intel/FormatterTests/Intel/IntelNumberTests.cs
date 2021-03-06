/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelNumberTests : NumberTests {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, object number, string formattedString) => FormatBase(index, number, formattedString, IntelFormatterFactory.Create_Numbers());
		public static IEnumerable<object[]> Format_Data => GetFormatData(allNumbers, formattedStrings);

		static readonly string[] formattedStrings = new string[allNumbersCount] {
			"-0x80",
			"0x7f",
			"-0x8000",
			"0x7fff",
			"-0x80000000",
			"0x7fffffff",
			"-0x8000000000000000",
			"0x7fffffffffffffff",
			"0xff",
			"0xffff",
			"0xffffffff",
			"0xffffffffffffffff",
		};
	}
}
#endif
