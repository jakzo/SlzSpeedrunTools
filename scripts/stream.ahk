Loop
{
  IfWinExist, BONELAB
  {
    MsgBox, Start
    IfWinNotExist, ahk_exe obs64.exe
    {
      Run "C:\Program Files\obs-studio\bin\64bit\obs64.exe" "--enable-gpu" "--enable-media-stream" "--startstreaming" "--startvirtualcam", C:\Program Files\obs-studio\bin\64bit
      WinWait, No Broadcast Configured, , 10
      If ErrorLevel
      {
        MsgBox, Could not find "No Broadcast Configured" window
      }
      Else
      {
        WinActivate, No Broadcast Configured
        Send, {Tab}{Tab}{Enter}
        WinWait, YouTube Broadcast Setup - Channel: jakzo, , 5
        If ErrorLevel
        {
          MsgBox, Could not find "YouTube Broadcast Setup" window
        }
        Else
        {
          WinActivate, YouTube Broadcast Setup - Channel: jakzo
          Send, +{Tab}{Enter}
        }
      }
    }

    Loop
    {
      If !WinExist("BONELAB")
      {
        start := A_TickCount
        While !WinExist("BONELAB")
        {
          If A_TickCount - start >= 60000
            break
          Sleep 1000
        }
        If A_TickCount - start >= 60000
        {
          WinClose, ahk_exe obs64.exe
          WinWait, Exit OBS?, , 5
          If !ErrorLevel
          {
            WinActivate, Exit OBS?
            Send, {Tab}{Tab}{Enter}
          }
          WinWaitClose, ahk_exe obs64.exe, , 20
          If ErrorLevel
          {
            MsgBox, OBS did not close
          }
          break
        }
      }
      Sleep 1000
    }
  }
  Sleep 1000
}