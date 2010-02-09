THIS IS THE C# TARGET RUNTIME DISTRIBUTION FOR ANTLR 3.1.3.

Please be aware that the maintainer wasn't able to create
neither a .chm file from the .xml files nor separate
assemblies for .NET 1.1 users. Anyone has to compile the
source code themselves. The maintainer would appreciate if
the assemblies are send to him, so he can update the runtime
distribution.

For the compilation one has to update the VS 2003 file as
described in the following:

UnwantedTokenException.cs and MissingTokenException.cs have to
be added to the "Antlr.Runtime" directory of the
Antlr3.Runtime project (they are in the associated directory)
and CommonErrorNode.cs has to be added to the
"Antlr.Runtime.Tree" directory.

To update the distribution correctly the following files are
required:

- The changed VS 2003 project file. (A working project file
should be in the repository.)

- The assemblies Antlr3.Runtime.dll and Antlr3.Utility.dll
generated via release mode.

- The associated .pdb and .xml files for stack traces and
intellisense.

- If possible, also the .chm file created from the .xml
files. There are some differences between the .NET 1.1 and
.NET 2.0 versions which can confuse users otherwise.

Thanks in advance!
Johannes Luber
Maintainer
jaluber AT gmx DOT de