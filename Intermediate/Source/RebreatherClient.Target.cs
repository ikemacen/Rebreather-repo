using UnrealBuildTool;

public class RebreatherClientTarget : TargetRules
{
	public RebreatherClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Rebreather");
	}
}
