echo off
SET SOURCE_DIR=%~dp0
SET DES_DIR=C:\Users\%USERNAME%\AppData\Local\Packages\A278AB0D.LegoLegacyHeroesUnboxed_h6adky7gbf63m\LocalState
if exist %DES_DIR% ( 
	if exist %DES_DIR%\3416\go.txt (
		echo Deug stuff avaiable. Not need to run this script anymore
		goto :endprocess
	) else (
		xcopy /e /v %SOURCE_DIR%\GoStuffs %DES_DIR%
		echo Copy debug stuffs successful. Go to %DES_DIR%\3416 to get ProfileEffect... 
		goto :endprocess
	)
) else (
	echo Game not be installed? 
	goto :endprocess
)

pause

:endprocess
	pause 
	:END
