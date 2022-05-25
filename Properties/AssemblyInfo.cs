using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(EntangleHit.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(EntangleHit.BuildInfo.Company)]
[assembly: AssemblyProduct(EntangleHit.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + EntangleHit.BuildInfo.Author)]
[assembly: AssemblyTrademark(EntangleHit.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(EntangleHit.BuildInfo.Version)]
[assembly: AssemblyFileVersion(EntangleHit.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(EntangleHit.EntangleHit), EntangleHit.BuildInfo.Name, EntangleHit.BuildInfo.Version, EntangleHit.BuildInfo.Author, EntangleHit.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]