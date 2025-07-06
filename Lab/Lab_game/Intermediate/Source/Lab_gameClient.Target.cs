using UnrealBuildTool;

public class Lab_gameClientTarget : TargetRules
{
	public Lab_gameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Lab_game");
	}
}
