// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LobbyTest_4_17_cppEditorTarget : TargetRules
{
	public LobbyTest_4_17_cppEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "LobbyTest_4_17_cpp" } );
	}
}
