FileMove
========
### About
Based on the setting file (setting.xml), move files for each file type (extension).

### How to setting
Edit setting file(setting.xml) with reference to "setting_sample.xml".  
You can set the following.
* Folder(Copy from).
* Folder(Copy to).
* Extension.
* Move or Copy.

### How to use
Set setting.xml and FileMove.exe on same folder.

### How to use on Mac
You can do this not only on Windows but also on Mac(with Mono)
[http://www.mono-project.com/Main_Page](http://www.mono-project.com/Main_Page,http://www.mono-project.com/Main_Page)

You can compile this with following command.
`dmcs -r:System.Xml.Linq.dll FileMove.cs`
And also can use this.
`Compile_FileMove.command`

You can do this on Mac(with Mono) by using following.
`mono FileMove.exe`
And also can use this.
`FileMove_on_Mac.command`

If you can not run ".command" file,Please do following command.
`chmod u+x Compile.command`
`chmod u+x FileMove_on_Mac.command`
