// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MMORPGGame : ModuleRules
{
	public MMORPGGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MMORPGGame",
			"MMORPGGame/Variant_Platforming",
			"MMORPGGame/Variant_Platforming/Animation",
			"MMORPGGame/Variant_Combat",
			"MMORPGGame/Variant_Combat/AI",
			"MMORPGGame/Variant_Combat/Animation",
			"MMORPGGame/Variant_Combat/Gameplay",
			"MMORPGGame/Variant_Combat/Interfaces",
			"MMORPGGame/Variant_Combat/UI",
			"MMORPGGame/Variant_SideScrolling",
			"MMORPGGame/Variant_SideScrolling/AI",
			"MMORPGGame/Variant_SideScrolling/Gameplay",
			"MMORPGGame/Variant_SideScrolling/Interfaces",
			"MMORPGGame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
