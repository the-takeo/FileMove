FileMove
========
### About
設定ファイル(Setting.txt)に基づき、ファイルの種類(拡張子)ごとにファイルを移動します。

### How to setting
設定ファイル(Setting.txt)を以下の形式で作成します。   
<移動元ディレクトリ>   
<移動先ディレクトリ>,<対象拡張子>,<対象拡張子>...   
<移動先ディレクトリ>,<対象拡張子>,<対象拡張子>...   
...

### How to use
設定ファイル(Setting.txt)を実行ファイルと同じディレクトリに保存し、実行してください。

### How to use on Mac
Windows上でなく、MonoがインストールされていればMac上でも実行できます。   
Monoは[http://www.mono-project.com/Main_Page](http://www.mono-project.com/Main_Page,http://www.mono-project.com/Main_Page)からインストールできます。

FileMove_on_Mac.commandを開き、"<ファイルディレクトリ>"の箇所をFileMoveのディレクトリに変更してください。   
例)`mono /Users/admin/Documents/FileMove`
   
そのままでは実行できない場合、以下のコマンドをターミナルから実行してください。  
`chmod u+x ＜ファイル名＞.command`