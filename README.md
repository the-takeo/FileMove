FileMove
========
### About
設定ファイル(setting.xml)に基づき、ファイルの種類(拡張子)ごとにファイルを移動します。

### How to setting
設定ファイル(setting.xml)をsetting_sample.xmlを参考に設定してください。   
以下のことが設定できます。   
* 移動（コピー）元ディレクトリ
* 移動（コピー）先ディレクトリ
* 移動（コピー）対象拡張子
* 移動 orコピー

### How to use
設定ファイル(setting.xml)を実行ファイル(FileMove.exe)と同じディレクトリに保存してください。

### How to use on Mac
Windows上でなく、MonoがインストールされていればMac上でも実行できます。   
Monoは[http://www.mono-project.com/Main_Page](http://www.mono-project.com/Main_Page,http://www.mono-project.com/Main_Page)からインストールできます。

Monoがインストールされていれば`dmcs -r:System.Xml.Linq.dll FileMove.cs`でコンパイルできます。

FileMove_on_Mac.commandを開き、<ファイルディレクトリ>の箇所をFileMove.exeのディレクトリに変更してください。 
例)`mono /Users/admin/Documents/FileMove`
   
通常、そのままではFileMove_on_Mac.commandは実行できません。   
その場合、以下のコマンドをターミナルから実行してください。  
`chmod u+x FileMove_on_Mac.command`
