﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb")> _
		Public ReadOnly Property nwindConnectionString() As String
			Get
				Return (CStr(Me("nwindConnectionString")))
			End Get
		End Property

		<Global.System.Configuration.UserScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.DefaultSettingValueAttribute("")> _
		Public Property gridView1ActiveFilterString() As String
			Get
				Return (CStr(Me("gridView1ActiveFilterString")))
			End Get
			Set(ByVal value As String)
				Me("gridView1ActiveFilterString") = value
			End Set
		End Property

		<Global.System.Configuration.UserScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.DefaultSettingValueAttribute("Left")> _
		Public Property dockPanel1Dock() As Global.DevExpress.XtraBars.Docking.DockingStyle
			Get
				Return (CType(Me("dockPanel1Dock"), Global.DevExpress.XtraBars.Docking.DockingStyle))
			End Get
			Set(ByVal value As DevExpress.XtraBars.Docking.DockingStyle)
				Me("dockPanel1Dock") = value
			End Set
		End Property
	End Class
End Namespace
