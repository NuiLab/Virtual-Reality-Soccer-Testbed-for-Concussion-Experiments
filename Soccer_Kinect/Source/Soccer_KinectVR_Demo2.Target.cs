// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Soccer_KinectVR_Demo2Target : TargetRules
{
	public Soccer_KinectVR_Demo2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Soccer_KinectVR_Demo2" } );
	}
}
