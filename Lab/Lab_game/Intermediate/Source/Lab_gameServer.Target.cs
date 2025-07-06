using UnrealBuildTool;

public class Lab_gameServerTarget : TargetRules
{
	public Lab_gameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Lab_game");
	}
}
