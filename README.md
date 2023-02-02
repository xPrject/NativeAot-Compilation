# NativeAot
Right Click Project > Edit Project File
append to project file to enable native code compilation
### \<PublishAot>true\</PublishAot>

## Console Application


## WinForms Application
Install nuget package
### WinFormsComInterop

Edit Program.cs and add
### ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);

Edit Project File and append
### \<_SuppressWinFormsTrimError>true</_SuppressWinFormsTrimError>
to suppress trimming error warning on compilation

### \<BuiltInComInteropSupport>true\</BuiltInComInteropSupport>
restore comsupport for WinForms


