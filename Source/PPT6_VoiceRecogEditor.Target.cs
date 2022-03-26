// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class PPT6_VoiceRecogEditorTarget : TargetRules
{
	public PPT6_VoiceRecogEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "PPT6_VoiceRecog" } );
	}
}
