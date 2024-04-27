VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5115
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   9600
   LinkTopic       =   "Form1"
   ScaleHeight     =   5115
   ScaleWidth      =   9600
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton btnKeluar 
      Caption         =   "Keluar"
      Height          =   855
      Left            =   2880
      TabIndex        =   1
      Top             =   3720
      Width           =   3255
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Tekan"
      Height          =   735
      Left            =   2760
      TabIndex        =   0
      Top             =   2640
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btnKeluar_Click()
Dim response As Integer
    response = MsgBox("Apakah Anda yakin ingin keluar?", vbQuestion + vbYesNo, "Konfirmasi Keluar")
    
    If response = vbYes Then
        Unload Me 'Menutup form'
    End If
End Sub

Private Sub Command1_Click()
Dim nama As String
nama = InputBox("Masukkan nama anda :")

If nama <> "" Then
 MsgBox ("Halo," & nama & "selamat belajar")
 Else
 MsgBox ("Nama Tidak boleh kosong")
 End If
 
End Sub

