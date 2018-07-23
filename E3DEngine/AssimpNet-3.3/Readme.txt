==Instructions==

No special instructions - just unzip and use the .NET assembly as a reference in Visual studio. There are both .NET 2.0 and 4.5 assemblies. Ensure the
respective Assimp DLL is in the same directory as the .NET assembly or provide a custom path to the unmanaged DLL in your app. Default out-of-the-box behavior
has the managed assembly always looking in the same folder for the unmanaged Assimp DLL. Enjoy!

As a new user, your starting point should be the AssimpContext class. This allows you to import or export models, and from
there the documentation should be able to guide you through the model data structure.