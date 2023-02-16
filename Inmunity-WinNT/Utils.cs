// (c) 2023 and onwards The vChewing Project (MIT License).
// ====================
// This code is released under the MIT license (SPDX-License-Identifier: MIT)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Inmunity_WinNT {
internal struct Utils {
  private static (String, String) SpecialSymbols = ("（(「『《“‘",
                                                    "」』》”’，。：:,.)）");
  private static String[] NewLineSymbols = { "\n",     "\r",     "\u000b",
                                             "\u000c", "\u0085", "\u2028",
                                             "\u2029", "\r\n" };
  public static String Inmunify(String raw) {
    if (String.IsNullOrEmpty(raw))
      return raw;
    StringBuilder result = new();
    String previousChar = "";

    bool IsASCII(String target) {
      if (String.IsNullOrEmpty(target))
        return false;
      var x = Encoding.UTF8.GetBytes(target)[0];
      if (x > 0x30 && x < 0x3A)
        return false;
      return x < 0x80;
    }

    GetU8Elements(raw).ForEach(delegate(string theChar) {
      if (NewLineSymbols.Contains(theChar))
        return;
      bool previousIsASpace = previousChar == " ";
      bool previousIsASCII = IsASCII(previousChar);
      bool currentIsASCII = IsASCII(theChar);
      bool isLastCharSpecial = String.IsNullOrEmpty(previousChar);
      if (!isLastCharSpecial)
        isLastCharSpecial = SpecialSymbols.Item1.Contains(previousChar);
      bool isCurrentCharSpecial = SpecialSymbols.Item2.Contains(theChar);
      if (result.Length != 0 && !previousIsASpace &&
          !(currentIsASCII && previousIsASCII) && !isCurrentCharSpecial &&
          !isLastCharSpecial && theChar != " ") {
        result.Append(" ");
      }
      result.Append(theChar);
      previousChar = theChar;
    });

    return result.ToString();
  }

  public static List<string> GetU8Elements(string text) {
    List<string> result = new();
    TextElementEnumerator charEnum = StringInfo.GetTextElementEnumerator(text);
    while (charEnum.MoveNext()) {
      result.Add(charEnum.GetTextElement());
    }
    return result;
  }
}
}
