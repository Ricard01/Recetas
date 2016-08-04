Option Explicit On
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text

Module SDK_AdminPAQ

    '__________________DECLARACIÓN DE LAS FUNCIONES DEL SDK______________________

    ' ***** Funciones Generales del SDK *****
    ' Inicialización/Terminación

    Public Declare Ansi Function fInicializaSDK Lib "MGW_SDK.DLL" () As Integer
    Public Declare Ansi Sub fTerminaSDK Lib "MGW_SDK.DLL" ()
    ' Manejo de errores
    'utilizando StrinBuilder en lugar de pedir un valor. 
    'Public Declare Ansi Sub fError Lib "MGW_SDK.DLL" (ByVal aNumError As Integer, ByVal aError As String, ByVal aLen As Integer)
    ' Public Declare Sub fError Lib "MGW_SDK.DLL" (ByVal aNumError As Integer, <MarshalAs(UnmanagedType.LPStr)> aMensaje As StringBuilder, ByVal aLen As Integer)

    Public Declare Sub fError Lib "MGW_SDK.DLL" (ByVal aNumError As Integer, <MarshalAs(UnmanagedType.LPStr)> aMensaje As StringBuilder, ByVal aLen As Integer)

    ' ***** Funciones de Empresas *****
    ' Navegación
    Declare Ansi Function fPosPrimerEmpresa Lib "MGW_SDK.DLL" (ByRef aIdEmpresa As Integer, aNombreEmpresa As StringBuilder, aDirectorioEmpresa As StringBuilder) As Integer
    Declare Ansi Function fPosSiguienteEmpresa Lib "MGW_SDK.DLL" (ByRef aIdEmpresa As Integer, aNombreEmpresa As StringBuilder, aDirectorioEmpresa As StringBuilder) As Integer
    ' Apertura/Cierre
    Public Declare Function fAbreEmpresa Lib "MGW_SDK.DLL" (ByVal aEmpresa As String) As Integer
    Public Declare Sub fCierraEmpresa Lib "MGW_SDK.DLL" ()

End Module
