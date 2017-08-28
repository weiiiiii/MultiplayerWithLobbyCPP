// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LobbyTest_4_17_cppTarget : TargetRules
{
	public LobbyTest_4_17_cppTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "LobbyTest_4_17_cpp" } );
	}
}
