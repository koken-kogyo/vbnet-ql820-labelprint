# QL-820NWB ラベル印刷 プロジェクト  

- [Kxx xxx xx] QL-820NWB ラベル印刷  


## 概要  

- KEYENCE BT-Wシリーズ ハンディターミナル アプリケーション  
  - 社内品番を読み取り、ラベルプリンターへ印刷指示を行う  
  - BluetoothSPP通信にてBDAddressに、P-touchTemplateコマンドを送信する  


## 開発環境  

- Microsoft .Net Compact Framework 3.5  
- Visual Studio 2008 Professional SP1 (Visual Basic.NET)  
- Windows Embedded Compact 7 Update for Visual Studio 2008 SP1   
- Windows Mobile デバイスセンター 6.1  
- BT-WHD1 BT-W_Series SDK for HandyTerminal  
- USB-COM Driver [BT-W Series] (※本体ファームウェアVer3.000 以前の場合)  


## PCデバッグ環境 (実機を用いない開発に必要なモジュール群)  

- BT-WHD1 BT-W_Series SDK for Device emulator (Win10/7)  
- BT-WHD1 BT-W_Series SDK for PCSimulator (WinXP/Vista)  
- コマンドサービス (BT-WHD1 のCD 内にある「BTWCommandService\setup.exe」)  
- PCシミュレータ (BT-WHD1 のCD 内にある「BTWPCSimulator\setup.exe」)  
- ループバックアダプタ (ネットワークアダプタ＞「Microsoft Loopback Adapter」)  


## プロジェクト構成  

- プロジェクトの種類  
  - スマートデバイス  
- ターゲットプラットフォーム  
  - Windows CE  
- .NET Compact Frameworkバージョン  
  - .NET Compact Framework 3.5  
- テンプレート (アプリケーションの種類)  
  - デバイスアプリケーション (Windows フォーム アプリケーション)  


## 参照ドキュメント  

- brother_QL-820NWB_Manual\Brother Manuals  
  - 39_★P-touch テンプレートマニュアル  コマンドリファレンス★.pdf  

## メンバー  

- y.watanabae  


## ディレクトリ構成  

~~~
./
│  .gitignore							# ソース管理除外対象  
│  BluetoothAddress.txt				# BDアドレス情報  
│  SmartDeviceLabelPrintProject.sln	# プロジェクトファイル  
│  README.md							# このファイル  
│  ReleaseNote.txt						# リリース情報  
│  
├─ SmartDeviceLabelPrintProject  
│  │  FormLabelPrint.vb				# 印刷画面  
│  │  FormMain.vb						# トップ画面  
│  │  FormProgress.vb					# 印刷中ダイアログ  
│  │  FormSetting.vb					# ラベルプリンター選択画面  
│  │  Koken-16x16-32x32.ico			# プロジェクトアイコン  
│  │  LabelPrint.vbproj				# プロジェクトファイル  
│  │  LabelPrint.vbproj.user			# プロジェクトオプション設定ファイル  
│  │  ModuleCommon.vb					# 設定ファイル取得モジュール  
│  │  ModuleScan.vb					# 読み取り制御モジュール  
│  │          
│  └─My Project  
│          AssemblyInfo.vb  
│          Resources.Designer.vb  
│          Resources.resx  
│          
├─ modules  
│      btCommLibNet.dll			# 通信制御ライブラリ  
│      btFileLibNet.dll			# ファイル制御ライブラリ  
│      btLibDefNet.dll				# .NET用データ定義  
│      btScanLibNet.dll			# 読み取り制御ライブラリ  
│      btSysLibNet.dll				# システム制御ライブラリ  
│      
└─ specification  
        [物流現場] 品番照合 機能仕様書_Ver.1.0.0.0.xlsx  
        
~~~


## 設定ファイル  

- LabelPrint.ini  (印刷設定ファイル)  


## アセンブリ情報  

- 著作権： © 2023 koken-kogyo CO,LTD.


