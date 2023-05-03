using UnrealBuildTool;

public class FirstProjectTarget : TargetRules
{
	public FirstProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FirstProject");
	}
}
