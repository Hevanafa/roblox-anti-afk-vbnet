; How this works:
; 1. Find the Roblox's game handle
;   - if there's none, exit early
; 
; 2. Reactivate the window
; - Press Esc
; - Minimise the window
; - Sleep script for {sleepTime} minutes
; - Repeat from number 2

; const $sleepTime = 7 ; in minutes

Opt("WinTitleMatchMode", 3)  ; Exact
$hWnd = WinGetHandle("Roblox")

if not $hWnd then
	exit
endif

WinActivate($hWnd)
Send("{ESC}")
WinSetState($hWnd, "", @SW_MINIMIZE)

; sleep($sleepTime * 60000) ; in milliseconds
