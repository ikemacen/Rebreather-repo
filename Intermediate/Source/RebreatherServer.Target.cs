using UnrealBuildTool;

public class RebreatherServerTarget : TargetRules
{
	public RebreatherServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Rebreather");
	}
}
