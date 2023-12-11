<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rbtRojoEncender = New System.Windows.Forms.Button()
        Me.rbtRojoApagar = New System.Windows.Forms.Button()
        Me.rbtVerdeEncender = New System.Windows.Forms.Button()
        Me.rbtVerdeApagar = New System.Windows.Forms.Button()
        Me.rbtAmarilloEncender = New System.Windows.Forms.Button()
        Me.rbtAmarilloApagar = New System.Windows.Forms.Button()
        Me.COM4 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtRojoEncender
        '
        Me.rbtRojoEncender.BackColor = System.Drawing.Color.Gray
        Me.rbtRojoEncender.BackgroundImage = CType(resources.GetObject("rbtRojoEncender.BackgroundImage"), System.Drawing.Image)
        Me.rbtRojoEncender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtRojoEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtRojoEncender.ForeColor = System.Drawing.Color.Gray
        Me.rbtRojoEncender.Location = New System.Drawing.Point(23, 80)
        Me.rbtRojoEncender.Name = "rbtRojoEncender"
        Me.rbtRojoEncender.Size = New System.Drawing.Size(83, 43)
        Me.rbtRojoEncender.TabIndex = 0
        Me.rbtRojoEncender.UseVisualStyleBackColor = False
        '
        'rbtRojoApagar
        '
        Me.rbtRojoApagar.BackgroundImage = CType(resources.GetObject("rbtRojoApagar.BackgroundImage"), System.Drawing.Image)
        Me.rbtRojoApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtRojoApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtRojoApagar.ForeColor = System.Drawing.Color.Gray
        Me.rbtRojoApagar.Location = New System.Drawing.Point(23, 129)
        Me.rbtRojoApagar.Name = "rbtRojoApagar"
        Me.rbtRojoApagar.Size = New System.Drawing.Size(83, 43)
        Me.rbtRojoApagar.TabIndex = 1
        Me.rbtRojoApagar.UseVisualStyleBackColor = True
        '
        'rbtVerdeEncender
        '
        Me.rbtVerdeEncender.BackgroundImage = CType(resources.GetObject("rbtVerdeEncender.BackgroundImage"), System.Drawing.Image)
        Me.rbtVerdeEncender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtVerdeEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtVerdeEncender.ForeColor = System.Drawing.Color.Gray
        Me.rbtVerdeEncender.Location = New System.Drawing.Point(23, 196)
        Me.rbtVerdeEncender.Name = "rbtVerdeEncender"
        Me.rbtVerdeEncender.Size = New System.Drawing.Size(83, 43)
        Me.rbtVerdeEncender.TabIndex = 2
        Me.rbtVerdeEncender.UseVisualStyleBackColor = True
        '
        'rbtVerdeApagar
        '
        Me.rbtVerdeApagar.BackgroundImage = CType(resources.GetObject("rbtVerdeApagar.BackgroundImage"), System.Drawing.Image)
        Me.rbtVerdeApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtVerdeApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtVerdeApagar.ForeColor = System.Drawing.Color.Gray
        Me.rbtVerdeApagar.Location = New System.Drawing.Point(23, 245)
        Me.rbtVerdeApagar.Name = "rbtVerdeApagar"
        Me.rbtVerdeApagar.Size = New System.Drawing.Size(83, 43)
        Me.rbtVerdeApagar.TabIndex = 3
        Me.rbtVerdeApagar.UseVisualStyleBackColor = True
        '
        'rbtAmarilloEncender
        '
        Me.rbtAmarilloEncender.BackgroundImage = CType(resources.GetObject("rbtAmarilloEncender.BackgroundImage"), System.Drawing.Image)
        Me.rbtAmarilloEncender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtAmarilloEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtAmarilloEncender.ForeColor = System.Drawing.Color.Gray
        Me.rbtAmarilloEncender.Location = New System.Drawing.Point(23, 312)
        Me.rbtAmarilloEncender.Name = "rbtAmarilloEncender"
        Me.rbtAmarilloEncender.Size = New System.Drawing.Size(83, 43)
        Me.rbtAmarilloEncender.TabIndex = 4
        Me.rbtAmarilloEncender.UseVisualStyleBackColor = True
        '
        'rbtAmarilloApagar
        '
        Me.rbtAmarilloApagar.BackgroundImage = CType(resources.GetObject("rbtAmarilloApagar.BackgroundImage"), System.Drawing.Image)
        Me.rbtAmarilloApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtAmarilloApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtAmarilloApagar.ForeColor = System.Drawing.Color.Gray
        Me.rbtAmarilloApagar.Location = New System.Drawing.Point(23, 361)
        Me.rbtAmarilloApagar.Name = "rbtAmarilloApagar"
        Me.rbtAmarilloApagar.Size = New System.Drawing.Size(83, 43)
        Me.rbtAmarilloApagar.TabIndex = 5
        Me.rbtAmarilloApagar.UseVisualStyleBackColor = True
        '
        'COM4
        '
        Me.COM4.PortName = "COM4"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(155, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(155, 312)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Blueberry Personal Use", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 35)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SEMAFORO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(294, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtAmarilloApagar)
        Me.Controls.Add(Me.rbtAmarilloEncender)
        Me.Controls.Add(Me.rbtVerdeApagar)
        Me.Controls.Add(Me.rbtVerdeEncender)
        Me.Controls.Add(Me.rbtRojoApagar)
        Me.Controls.Add(Me.rbtRojoEncender)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SEMAFORO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtRojoEncender As Button
    Friend WithEvents rbtRojoApagar As Button
    Friend WithEvents rbtVerdeEncender As Button
    Friend WithEvents rbtVerdeApagar As Button
    Friend WithEvents rbtAmarilloEncender As Button
    Friend WithEvents rbtAmarilloApagar As Button
    Friend WithEvents COM4 As IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
