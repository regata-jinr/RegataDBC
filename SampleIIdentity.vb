Public Class SampleIIdentity
    Implements System.Security.Principal.IIdentity

    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole

    Public ReadOnly Property AuthenticationType As String Implements System.Security.Principal.IIdentity.AuthenticationType
        Get
            Return "Custom Authentication"

        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements System.Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue

        End Get
    End Property

    Public ReadOnly Property Name As String Implements System.Security.Principal.IIdentity.Name
        Get
            Return nameValue

        End Get
    End Property

    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal password As String)
        ' The name is not case sensitive, but the password is.
        If IsValidNameAndPassword(name, password) Then
            nameValue = name
            authenticatedValue = True
            roleValue = ApplicationServices.BuiltInRole.Administrator
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    Private Function IsValidNameAndPassword(
    ByVal username As String,
    ByVal password As String) As Boolean

        ' Look up the stored hashed password and salt for the username.
        Dim storedHashedPW As String = GetHashedPassword(username)
        Dim salt As String = GetSalt(username)

        'Create the salted hash.
        Dim rawSalted As String = salt & Trim(password)
        Dim saltedPwBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.
            SHA1CryptoServiceProvider
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)

        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)
        Debug.Print(Convert.ToBase64String(hashedPwBytes))
        ' Compare the hashed password with the stored password.
        Return hashedPw = storedHashedPW
    End Function

    Private Function GetHashedPassword(ByVal username As String) As String
        ' Code that gets the user's hashed password goes here.
        ' This example uses a hard-coded hashed passcode.
        ' In general, the hashed passcode should be stored 
        ' outside of the application.
        If Trim(username).ToLower = "testuser" Then
            Return "ZFFzgfsGjgtmExzWBRmZI5S4w6o="

        ElseIf Trim(username).ToLower = "pavlov" Then
            Return "DVOZUIQnznlVbNpxkYAgwejRW1M="
        ElseIf Trim(username).ToLower = "mvf" Then
            Return "uUlo3gGz10xNV7aMcPdZEe1D8Mk="
        ElseIf Trim(username).ToLower = "1" Then
            Return "8GrmQ75v+4KwQDtK5B1w+PZoPN4="
        ElseIf Trim(username).ToLower = "zig" Then
            Return "SsKs4mbKHWF9zr7LrN0BNzPFR2c="
        ElseIf Trim(username).ToLower = "vergel" Then
            Return "slBbmDm54mB9Ht+hUVoOzPQxAvA="
        ElseIf Trim(username).ToLower = "iiz" Then
            Return "OpaVDQgKqRUNgIbwtQ5DOcmrk7k="
        ElseIf Trim(username).ToLower = "yva" Then
            Return "5y4RPdy9e5bGR2Hn6MVDaRsVs7M="
        ElseIf Trim(username).ToLower = "tmo" Then
            Return "UiHEIsYeU7o7O+caoAy6xpRtM/I="
        ElseIf Trim(username).ToLower = "sfg" Then
            Return "KbSmuFnheCmqCdIisq8RcsIjuno="
        ElseIf Trim(username).ToLower = "lps" Then
            Return "gDIM0oKJQ1la5n2RkDInmWeo9TY="
        ElseIf Trim(username).ToLower = "okr" Then
            Return "3cwv2DrxYZjBe0fh4MDhW3brtFs="
        ElseIf Trim(username).ToLower = "tmv" Then
            Return "uPWvyY1fwJhGtX4acxWsIC97Twc="
        ElseIf Trim(username).ToLower = "ajm" Then
            Return "1EGw1Jt+jpGpbwtS8J5JZyb9tew="
        ElseIf Trim(username).ToLower = "nbm" Then
            Return "2xf5OPHVlgbry83u5xijjQBY434="
        ElseIf Trim(username).ToLower = "cia" Then
            Return "3e+7VkmcUZ73/lCs7e0g/Hks7Vk="
        ElseIf Trim(username).ToLower = "coe" Then
            Return "MvzQP4tIYXst4C2+9nHlZJ1oUzk="
        ElseIf Trim(username).ToLower = "psn" Then
            Return "fGcORWjTvbEA6hSptuBwfQH+Z1U="
        ElseIf Trim(username).ToLower = "avk" Then
            Return "u2YeiL6SJ2HIgjphRsnrw4YrcBg="
        ElseIf Trim(username).ToLower = "nsy" Then
            Return "6SMB5gijogtzfejK6bIgaT2LBOE="
        ElseIf Trim(username).ToLower = "g" Then
            Return "lw1UZrHvKpU1DVe3etpY4ZLijdc="
        ElseIf Trim(username).ToLower = "gerihris" Then
            Return "h6G1CaOX6sEsfK5FVGHfLhrd/Lo="
        ElseIf Trim(username).ToLower = "wael" Then
            Return "9yPyo/RXAodw8Mov1VGoNXigHvc="
        ElseIf Trim(username).ToLower = "guest" Then
            Return "GCDsSO6d4wemp59XwQ/bPa6QACQ="
        ElseIf Trim(username).ToLower = "ynik" Then
            Return "OlvVZOYmKE/eIdUv0lL5cLlm28A="
        ElseIf Trim(username).ToLower = "cia" Then
            Return "HxmgePS7l28KXst4sBZQoW5oJkE="
        ElseIf Trim(username).ToLower = "atanas" Then
            Return "acy/GQYCnIUwCdv8IgI9nz5/DfE="
        ElseIf Trim(username).ToLower = "margarita" Then
            Return "tET0deqiEFrRsL9lc6i/tb9am/s="
        ElseIf Trim(username).ToLower = "o.lash041" Then
            Return "EIGZEpk0bhbBuFtpDYZD2aC8TJ4="
        ElseIf Trim(username).ToLower = "madadzada" Then
            Return "aLtG4qEXs9NZbe/7fV+b09C9dZY="
        ElseIf Trim(username).ToLower = "o.chaligava" Then
            Return "FVLvhAGv4pLIE1++I7WLD4EtaSY="
        Else
            Return ""
        End If
    End Function

    Private Function GetSalt(ByVal username As String) As String
        ' Code that gets the user's salt goes here.
        ' This example uses a hard-coded salt.
        ' In general, the salt should be stored 
        ' outside of the application.
        If Trim(username).ToLower = "testuser" Then
            Return "Should be a different random value for each user"
        Else
            Return ""
        End If
    End Function
End Class
