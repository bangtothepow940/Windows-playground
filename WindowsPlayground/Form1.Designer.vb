<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(720, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(679, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Windows playground"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 103)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open link"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1132, 620)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 103)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Teleport cursor to random position"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(611, 620)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(515, 79)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Start progress bar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 608)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(257, 103)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit the program"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(272, 38)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(267, 78)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "TTS the text"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(10, 38)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(257, 78)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Say the text in a box the text"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(291, 398)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(267, 103)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Open another instance of window"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(529, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "i like this playground!"
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(10, 122)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(529, 45)
        Me.TrackBar1.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(611, 705)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(515, 18)
        Me.ProgressBar1.TabIndex = 12
        '
        'Timer1
        '
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.375!)
        Me.Button9.Location = New System.Drawing.Point(611, 485)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(787, 117)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Random number between 0 and 1000000"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 39)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(369, 39)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Number of track bar is:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(847, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(417, 108)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "00:00:00"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(904, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 42)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Click cluck OWO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsPlayground.My.Resources.Resources.H
        Me.PictureBox1.Location = New System.Drawing.Point(820, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsPlayground.My.Resources.Resources.jotaro_chibi_dancing_rainbow
        Me.PictureBox2.Location = New System.Drawing.Point(1054, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(188, 200)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 739)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Windows Playground"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button9 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
