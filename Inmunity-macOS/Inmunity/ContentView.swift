// (c) 2021 and onwards The vChewing Project (MIT License).
// ====================
// This code is released under the MIT license (SPDX-License-Identifier: MIT)

import SwiftUI

struct ContentView: View {
  @State var editingArea = ""
  @State var disabled = false
  var body: some View {
    VStack {
      TextEditor(text: $editingArea).disabled(disabled).font(.system(size: 16))
      Button("Inmunify") {
        DispatchQueue.main.async {
          disabled = true
          var result = editingArea
          editingArea = "⌛⌛⌛"
          result = Utils.inmunify(result)
          editingArea = result
          disabled = false
        }
      }.disabled(disabled)
    }
    .padding().frame(minWidth: 320, minHeight: 240)
  }
}

struct ContentView_Previews: PreviewProvider {
  static var previews: some View {
    ContentView()
  }
}
