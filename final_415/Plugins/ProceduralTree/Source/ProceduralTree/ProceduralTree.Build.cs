//==========================================================================//
// Copyright Elhoussine Mehnik (ue4resources@gmail.com). All Rights Reserved.
//================== http://unrealengineresources.com/ =====================//

namespace UnrealBuildTool.Rules
{
	public class ProceduralTree : ModuleRules
	{
        public ProceduralTree(ReadOnlyTargetRules Target) : base(Target)
		{
			PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;   /*PCHUsage = ModuleRules.PCHUsageMode.NoPCHs; bUseUnity = false;*/


			PrivateIncludePaths.Add("ProceduralTree/Private");

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "RenderCore",
                    "RHI",
					"PhysicsCore"
				}
				);
		}
	}
}
