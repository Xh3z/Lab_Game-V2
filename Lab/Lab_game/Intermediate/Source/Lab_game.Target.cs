using UnrealBuildTool;

public class Lab_gameTarget : TargetRules
{
	public Lab_gameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Lab_game");
	}
}
