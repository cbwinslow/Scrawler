﻿' Copyright (C) 2022  Andy
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY
Imports PersonalUtilities.Tools.WEB
Namespace EncryptCookies
    Friend Module EncryptFunction
        Friend CookiesEncrypted As Boolean = False
        Friend Sub ValidateCookiesEncrypt(ByRef Responser As Response)
            If Not Responser Is Nothing Then
                Dim b As Boolean = False
                With Responser
                    If Not .Cookies Is Nothing Then
                        With .Cookies
                            If .EncryptKey.IsEmptyString Then .EncryptKey = SettingsCLS.CookieEncryptKey : b = .Count > 0
                        End With
                    End If
                    If .CookiesEncryptKey.IsEmptyString Then .CookiesEncryptKey = SettingsCLS.CookieEncryptKey : b = True
                    If b Then .SaveSettings()
                End With
            End If
        End Sub
    End Module
End Namespace