// (c) 2021 and onwards The vChewing Project (MIT License).
// ====================
// This code is released under the MIT license (SPDX-License-Identifier: MIT)

import Cocoa

public enum Utils {
  static let specialSymbols: (String, String) = ("（(「『《“‘", "」』》”’，。：:,.)）")

  public static func inmunify(_ raw: String) -> String {
    let result = NSMutableString()
    var isPreviousASpace: Bool {
      result.description.last?.isWhitespace ?? false
    }
    var isPreviousASCII: Bool {
      guard let theLastScalars = result.description.last?.unicodeScalars else { return false }
      if theLastScalars.count > 1 { return false }
      guard let theFirstScalar = theLastScalars.first else { return false }
      return theFirstScalar.value < 0x80 && !(0x30 ... 0x3A).contains(theFirstScalar.value)
    }
    func isCurrentASCII(_ target: String.Element) -> Bool {
      let theLastScalars = target.unicodeScalars
      if theLastScalars.count > 1 { return false }
      guard let theFirstScalar = theLastScalars.first else { return false }
      return theFirstScalar.value < 0x80 && !(0x30 ... 0x3A).contains(theFirstScalar.value)
    }
    raw.forEach { theChar in
      if theChar.isNewline { return }
      let previousIsASpace = isPreviousASpace
      let previousIsASCII = isPreviousASCII
      let currentIsASCII = isCurrentASCII(theChar)
      let isLastCharSpecial: Bool = {
        guard let lastChar = result.description.last else { return true }
        return Self.specialSymbols.0.contains(lastChar)
      }()
      let isCurrentCharSpecial: Bool = Self.specialSymbols.1.contains(theChar)

      if !result.description.isEmpty, theChar != " ",
         !previousIsASpace, !(currentIsASCII && previousIsASCII), !isCurrentCharSpecial, !isLastCharSpecial
      {
        result.append(" ")
      }
      result.append(theChar.description)
    }
    return result.description
  }
}
