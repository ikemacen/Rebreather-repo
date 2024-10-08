using UnrealBuildTool;

public class RebreatherTarget : TargetRules
{
	public RebreatherTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Rebreather");
	}
}
