using UnrealBuildTool;

public class RebreatherEditorTarget : TargetRules
{
	public RebreatherEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Rebreather");
	}
}
