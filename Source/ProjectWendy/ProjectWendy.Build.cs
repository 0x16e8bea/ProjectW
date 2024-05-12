// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjectWendy : ModuleRules
{
	public ProjectWendy(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
