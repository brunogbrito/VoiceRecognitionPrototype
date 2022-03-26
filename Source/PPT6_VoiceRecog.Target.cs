// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class PPT6_VoiceRecogTarget : TargetRules
{
	public PPT6_VoiceRecogTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "PPT6_VoiceRecog" } );
	}
}
