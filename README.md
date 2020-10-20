# unity-managed-plugin
1. [Konfigurera projekt för Unity](https://gist.github.com/kilathaar/c427025f7669763402f90770a47c72e9)

Exempel-projekt hur man kan anropa externa dll.filer.

Pojektet [vscode-csharp](https://github.com/kilathaar/vscode-csharp) bygger en fristående Applikation som skriver ut texten "Hello World!" i konsollen. Ett av delprojekten bygger en dll-fil - `Entitet.dll` som innhåller klassen [Text](https://github.com/kilathaar/vscode-csharp/blob/main/HelloWorld/Entitet/src/Entitet/Text.cs).

Filen `Entitet.dll` har kopierats till detta projekt och som anropas av C#-scriptet [UseManagedPlugin](https://github.com/kilathaar/unity-managed-plugin/blob/main/unity/Assets/UseManagedPlugin.cs).

Väldigt enkelt att använda *[Managed plugins](https://docs.unity3d.com/Manual/UsingDLL.html)*.
