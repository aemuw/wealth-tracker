; -*- coding: utf-8 -*-
Unicode true
!include "MUI2.nsh"
!include "LogicLib.nsh"
!include "x64.nsh"
!include "WinVer.nsh"
!ifndef PUBLISH_DIR
  !define PUBLISH_DIR "..\artifacts\installer\publish"
!endif
!ifndef OUTPUT_FILE
  !define OUTPUT_FILE "..\artifacts\installer\dist\WealthTracker-1.0.0-win-x64-setup.exe"
!endif
!ifndef UNINSTALL_INCLUDE
  !define UNINSTALL_INCLUDE "..\artifacts\installer\uninstall-files.nsh"
!endif
!define APP_NAME "WealthTracker"
!define APP_EXE "wealth-tracker.exe"
!define UNINSTALL_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\WealthTracker"
Name "${APP_NAME} 1.0.0"
OutFile "${OUTPUT_FILE}"
InstallDir "$LOCALAPPDATA\Programs\WealthTracker"
RequestExecutionLevel user
SetCompressor /SOLID lzma
ShowInstDetails show
ShowUninstDetails show
VIProductVersion "1.0.0.0"
VIAddVersionKey /LANG=1058 "ProductName" "WealthTracker"
VIAddVersionKey /LANG=1058 "FileDescription" "Інсталятор WealthTracker — варіант 1"
VIAddVersionKey /LANG=1058 "FileVersion" "1.0.0"
VIAddVersionKey /LANG=1058 "ProductVersion" "1.0.0"
VIAddVersionKey /LANG=1058 "CompanyName" "Богун А.Д."
VIAddVersionKey /LANG=1058 "LegalCopyright" "Богун А.Д., 2026"
!define MUI_ABORTWARNING
!define MUI_WELCOMEPAGE_TEXT "Майстер встановить WealthTracker — програму обліку особистих фінансів.$\r$\n$\r$\nВиконав: Богун А.Д. Варіант 1.$\r$\n$\r$\nЗакрийте WealthTracker перед продовженням. Ваша база даних зберігається окремо від файлів програми."
!define MUI_LICENSEPAGE_TEXT_TOP "Ознайомтеся з умовами встановлення WealthTracker."
!define MUI_LICENSEPAGE_BUTTON "Далі >"
!define MUI_FINISHPAGE_RUN "$INSTDIR\${APP_EXE}"
!define MUI_FINISHPAGE_RUN_NOTCHECKED
!define MUI_FINISHPAGE_RUN_TEXT "Запустити WealthTracker"
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "INSTALLATION.txt"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH
!insertmacro MUI_LANGUAGE "Ukrainian"

Function .onInit
  SetShellVarContext current
  ${IfNot} ${RunningX64}
    MessageBox MB_ICONSTOP|MB_OK "Потрібна 64-бітна Windows."
    Abort
  ${EndIf}
  ${IfNot} ${AtLeastWin10}
    MessageBox MB_ICONSTOP|MB_OK "Потрібна Windows 10 або новіша."
    Abort
  ${EndIf}
  SetRegView 64
  ReadRegStr $0 HKCU "Software\WealthTracker" "InstallDir"
  StrCmp $0 "" +2
    StrCpy $INSTDIR $0
FunctionEnd

Section "WealthTracker і локальна довідка (обов'язково)" SecCore
  SectionIn RO
  SetShellVarContext current
  SetOutPath "$INSTDIR"
  SetOverwrite on
  File /r "${PUBLISH_DIR}\*.*"
  WriteUninstaller "$INSTDIR\Uninstall.exe"
  WriteRegStr HKCU "Software\WealthTracker" "InstallDir" "$INSTDIR"
  WriteRegStr HKCU "${UNINSTALL_KEY}" "DisplayName" "WealthTracker 1.0.0"
  WriteRegStr HKCU "${UNINSTALL_KEY}" "DisplayVersion" "1.0.0"
  WriteRegStr HKCU "${UNINSTALL_KEY}" "Publisher" "Богун А.Д."
  WriteRegStr HKCU "${UNINSTALL_KEY}" "InstallLocation" "$INSTDIR"
  WriteRegStr HKCU "${UNINSTALL_KEY}" "DisplayIcon" "$INSTDIR\${APP_EXE},0"
  WriteRegStr HKCU "${UNINSTALL_KEY}" "UninstallString" '$\"$INSTDIR\Uninstall.exe$\"'
  WriteRegStr HKCU "${UNINSTALL_KEY}" "QuietUninstallString" '$\"$INSTDIR\Uninstall.exe$\" /S'
  WriteRegDWORD HKCU "${UNINSTALL_KEY}" "NoModify" 1
  WriteRegDWORD HKCU "${UNINSTALL_KEY}" "NoRepair" 1
SectionEnd

Section "Ярлики в меню Пуск" SecStart
  CreateDirectory "$SMPROGRAMS\WealthTracker"
  CreateShortcut "$SMPROGRAMS\WealthTracker\WealthTracker.lnk" "$INSTDIR\${APP_EXE}"
  CreateShortcut "$SMPROGRAMS\WealthTracker\Видалити WealthTracker.lnk" "$INSTDIR\Uninstall.exe"
SectionEnd

Section /o "Ярлик на робочому столі" SecDesktop
  CreateShortcut "$DESKTOP\WealthTracker.lnk" "$INSTDIR\${APP_EXE}"
SectionEnd

!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
!insertmacro MUI_DESCRIPTION_TEXT ${SecCore} "Програма, бібліотеки, автономне середовище .NET 8.0.21 та локальна довідка."
!insertmacro MUI_DESCRIPTION_TEXT ${SecStart} "Ярлики запуску та видалення у меню Пуск поточного користувача."
!insertmacro MUI_DESCRIPTION_TEXT ${SecDesktop} "Необов'язковий ярлик запуску WealthTracker на робочому столі."
!insertmacro MUI_FUNCTION_DESCRIPTION_END

Section "Uninstall"
  SetShellVarContext current
  SetRegView 64
  Delete "$DESKTOP\WealthTracker.lnk"
  Delete "$SMPROGRAMS\WealthTracker\WealthTracker.lnk"
  Delete "$SMPROGRAMS\WealthTracker\Видалити WealthTracker.lnk"
  RMDir "$SMPROGRAMS\WealthTracker"
  ; Never recursively delete the application directory or the personal database.
  !include "${UNINSTALL_INCLUDE}"
  Delete "$INSTDIR\Uninstall.exe"
  RMDir "$INSTDIR"
  DeleteRegKey HKCU "${UNINSTALL_KEY}"
  DeleteRegKey HKCU "Software\WealthTracker"
SectionEnd
