# EasyNuget

EasyNuget is a simple application to improve development workflows involving nuget packages. The use case we are trying to optimize is:

- You are developing a .Net (full or core) application referencing multiple nuget packages and you need to apply some changes in the referenced packages
- You have the referenced package source code locally to build after making some code changes
- You want to debug the changes that you just made in the referenced package
- You don't want to wait your build system to buid and deploy a new package version beacuse it takes a while and you have many packages to change

What EasyNuget does is to provide an interface to add the libraries that you need to change and automate the build as per your need

## Development Technology

- Microsoft .Net Full Framework 4.6.1
- Visual Studio 2017, you cannot use VS Code (unfortunately)
- Windows Forms
- NSIS 2.51 (installer builder)

## Features

- Select and build nuget packages sources
- Built packages can be debugged
- Enable/Disable specific packages
- Saves packages list in a json file easy to share and edit off-line
- Build just the selected packages
- Build command line is external, you can change it without recompile the code
- **TODO**
    -  Respect pacakges inter-depencences
    -  Allow user to order the build sequence
    -  Allow user to customize build command line

## How does it work?



## Supported OS

Windows

## FAQ



## License

MIT