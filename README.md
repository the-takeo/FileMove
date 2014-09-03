FileMove
========
### About
設定ファイル(setting.xml)に基づき、ファイルの種類(拡張子)ごとにファイルを移動します。

### How to setting
設定ファイル(setting.xml)をsetting_sample.xmlを参考に設定してください。   
以下のことが設定できます。   
** 移動（コピー）元ディレクトリ
** 移動（コピー）先ディレクトリ
** 移動（コピー）対象拡張子
** 移動 orコピー

### How to use
設定ファイル(Setting.txt)を実行ファイルと同じディレクトリに保存してください。   
移動元ディレクトリをコマンドライン引数に渡して実行してください。

### How to use on Mac
Windows上でなく、MonoがインストールされていればMac上でも実行できます。   
Monoは[http://www.mono-project.com/Main_Page](http://www.mono-project.com/Main_Page,http://www.mono-project.com/Main_Page)からインストールできます。

FileMove_on_Mac.commandを開き、<ファイルディレクトリ>の箇所をFileMoveのディレクトリに変更してください。   
<対象ディレクトリ>の箇所を移動させるファイルを保存しているディレクトリに変更してください。   
例)`mono /Users/admin/Documents/FileMove /Users/admin/Downloads`
   
そのままでは実行できない場合、以下のコマンドをターミナルから実行してください。  
`chmod u+x ＜ファイル名＞.command`
