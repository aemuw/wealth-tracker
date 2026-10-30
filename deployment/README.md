# Інсталятор WealthTracker

Виконав: Богун А.Д. Варіант 1.

Потрібні .NET SDK 8+ та NSIS 3.x. З кореня репозиторію:

```powershell
.\deployment\build-installer.ps1 -MakeNSIS 'C:\Program Files (x86)\NSIS\makensis.exe'
```

Для наявного локального кешу пакетів додайте `-Offline`; за потреби задайте `-PackageCache 'шлях\до\packages'`.

Результат: `artifacts/installer/dist/WealthTracker-1.0.0-win-x64-setup.exe`. Пакет автономний, Windows 10 x64+, .NET 8.0.21 входить до складу. Особиста база до пакета не включається. Встановлення для поточного користувача: `%LOCALAPPDATA%\Programs\WealthTracker`; видалення зберігає `%LOCALAPPDATA%\WealthTracker\wealth-tracker.db`.
