using UnrealBuildTool;

public class Lab_gameEditorTarget : TargetRules
{
	public Lab_gameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Lab_game");
	}
}
