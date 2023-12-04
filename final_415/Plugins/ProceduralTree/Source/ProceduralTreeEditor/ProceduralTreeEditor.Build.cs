//==========================================================================//
// Copyright Elhoussine Mehnik (ue4resources@gmail.com). All Rights Reserved.
//================== http://unrealengineresources.com/ =====================//

namespace UnrealBuildTool.Rules
{
	public class ProceduralTreeEditor : ModuleRules
	{
        public ProceduralTreeEditor(ReadOnlyTargetRules Target) : base(Target)
		{
            PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;   /*PCHUsage = ModuleRules.PCHUsageMode.NoPCHs; bUseUnity = false;*/


            PrivateIncludePaths.Add("ProceduralTreeEditor/Private");

            PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Slate",
                    "SlateCore",
                    "Engine",
                    "UnrealEd",
                    "PropertyEditor",
                    "RenderCore",
                    "RHI",
                    "ProceduralTree",
                    "RawMesh",
                    "AssetTools",
                    "AssetRegistry"
                }
				);
		}
	}
}
