﻿using System.Data.Entity.SqlServer;
using System.Reflection;
using System.Runtime.InteropServices;


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AABC.DomainServices.Tests.Unit")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("AABC.DomainServices.Tests.Unit")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("583800c2-f14d-42cf-b795-3b9f79dfc6fa")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]



internal static class MissingDllHack
{
    // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
    // included in the output folder of referencing projects without requiring a direct 
    // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
    private static SqlProviderServices instance = SqlProviderServices.Instance;
}