# Inmunity

(c) 2021 and onwards The vChewing Project (MIT License).

該工具將一段文字整理成 INMU 格式，方便 Sibelius / Dorico / Finale 中文歌詞製作。

## Windows 版本

支援 Windows 7 / 8 / 10 的 AMD 64 位元版本（市售電腦 CPU 應該都能跑），要求安裝 .NET 6。但敝倉庫所提供之程式碼可用於建置 32 位元版本、建置 ARM CPU 專用版本。

P.S.: 因作者個人能力有限，Windows 版本尚未引入多執行緒處理特性。所幸，歌詞這種東西，篇幅不會很大，使用者應該不會感到 lag 才對。

## macOS 版本

因為用到了 SwiftUI App 前端，所以該工具要求作業系統版本至少為 macOS 11 Big Sur。然而，本專案當中的 Converter.swift 業務邏輯檔案當中的內容可以用於更舊的 macOS 系統（理論上可以在 macOS 10.9 系統內使用），只不過整個前端 GUI 需要改用 Cocoa 重寫。

## 测试用文字段落

```
Je t'aimais 刻骨銘心的只有我自己
好不容易交出真心的勇氣
你沉默的回應 是善意
123apple測試
```
