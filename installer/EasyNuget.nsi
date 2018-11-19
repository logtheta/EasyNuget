Section "SetVersion"
	!ifdef version
		!define PRODUCT_VERSION ${version}
	!else
		!define PRODUCT_VERSION "1.0.0.0"
	!endif
SectionEnd

!define PRODUCT_PUBLISHER "EasyNuget"
!define PRODUCT_WEB_SITE "https://github.com/logtheta/EasyNuget"
!define APP_ROOT ""

!define PRODUCT_NAME "EasyNuget"
!define APP_NAME "EasyNuget"
!define SOURCE_PATH "..\src\bin\Release"
!define MUI_ICON "..\src\bin\Release\NuGet.ico"

;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------

; The name of the installer
Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"

; The file to write
OutFile "${APP_NAME}_ver${PRODUCT_VERSION}.exe"
;----------------------
; Require Admin provileges
RequestExecutionLevel admin ;Require admin rights on NT6+ (When UAC is turned on)
!include LogicLib.nsh

Function .onInit
UserInfo::GetAccountType
pop $0
${If} $0 != "admin" ;Require admin rights on NT4+
    MessageBox mb_iconstop "Administrator rights required!"
    SetErrorLevel 740 ;ERROR_ELEVATION_REQUIRED
    Quit
${EndIf}
; Set installation directory and registry key
${If} $INSTDIR == "" ; /D not used
    StrCpy $INSTDIR "$PROGRAMFILES\${APP_ROOT}\${APP_NAME}${PRODUCT_VERSION}"
${EndIf}
FunctionEnd
;-------------------------

!include x64.nsh
InstallDir "$INSTDIR"
InstallDirRegKey HKLM "Software\${APP_ROOT}\${APP_NAME}${PRODUCT_VERSION}" "Install_Dir"
AutoCloseWindow false
ShowInstDetails show
ShowUnInstDetails show
;BGGradient 000000 800000 FFFFFF
BGGradient 359FDC 000030 FFFFFF
InstallColors 359FDC 000030
SilentInstall normal
XPStyle on
CheckBitmap "${NSISDIR}\Contrib\Graphics\Checks\classic-cross.bmp"
InstProgressFlags smooth colored
BrandingText " "
AllowRootDirInstall false

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
; Pages

;Page directory
;Page instfiles
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

;UninstPage uninstConfirm
;UninstPage instfiles

;--------------------------------

;Languages

  !insertmacro MUI_LANGUAGE "English"

;--------------------------------

; The stuff to install
Section "" ;No components page, name is not important

  SectionIn RO

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR

  ; Put file there
    !define REG_UN_PATH "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP_NAME}${PRODUCT_VERSION}"
  File  /x *.vshost.exe.* /x *.pdb /x *.xml /x *.dll.config ${SOURCE_PATH}\*
  
  
  ; Write the installation path into the registry
  WriteRegStr HKLM "SOFTWARE\${APP_ROOT}\${APP_NAME}${PRODUCT_VERSION}" "Install_Dir" "$INSTDIR"

  ; Write the uninstall keys for Windows
  WriteRegStr HKLM ${REG_UN_PATH} "DisplayName" "${APP_NAME} ${PRODUCT_VERSION}"
  WriteRegStr HKLM ${REG_UN_PATH} "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr HKLM ${REG_UN_PATH} "DisplayIcon" "$INSTDIR\${APP_NAME}.exe,0"
  WriteRegDWORD HKLM ${REG_UN_PATH} "EstimatedSize" 8400
  WriteRegStr HKLM ${REG_UN_PATH} "Publisher" "Logtheta"
  WriteRegStr HKLM ${REG_UN_PATH} "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM ${REG_UN_PATH} "NoModify" 1
  WriteRegDWORD HKLM ${REG_UN_PATH} "NoRepair" 1
  WriteUninstaller "uninstall.exe"

  
SectionEnd ; end the section

;--------------------------------

; Uninstaller

Section "Uninstall"

 
  ; Remove registry keys
  DeleteRegKey HKLM ${REG_UN_PATH}
  ;DeleteRegKey HKLM SOFTWARE\${APP_ROOT}\${APP_NAME}

  ;Delete Event Log
  DeleteRegKey HKEY_LOCAL_MACHINE "SYSTEM\CurrentControlSet\Services\EventLog\${APP_NAME}Log\${APP_NAME}Log"
  DeleteRegKey HKEY_LOCAL_MACHINE "SYSTEM\CurrentControlSet\Services\EventLog\${APP_NAME}Log"

  ; Remove directories used
  RMDir /r $INSTDIR

SectionEnd
