// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Soccer_KinectVR_Demo2EditorTarget : TargetRules
{
	public Soccer_KinectVR_Demo2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Soccer_KinectVR_Demo2" } );
	}
}
