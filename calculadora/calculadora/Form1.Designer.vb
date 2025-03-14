<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbresultado = New Label()
        tb_valor1 = New TextBox()
        tb_valor2 = New TextBox()
        btn_calcular = New Button()
        btn_division = New Button()
        btn_suma = New Button()
        btn_multiplicacion = New Button()
        btn_resta = New Button()
        SuspendLayout()
        ' 
        ' lbresultado
        ' 
        lbresultado.AutoSize = True
        lbresultado.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lbresultado.BorderStyle = BorderStyle.Fixed3D
        lbresultado.Font = New Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbresultado.ForeColor = Color.White
        lbresultado.Location = New Point(4, 22)
        lbresultado.Name = "lbresultado"
        lbresultado.Size = New Size(155, 26)
        lbresultado.TabIndex = 0
        lbresultado.Text = "(resultado)"
        lbresultado.TextAlign = ContentAlignment.MiddleCenter
        lbresultado.Visible = False
        ' 
        ' tb_valor1
        ' 
        tb_valor1.AccessibleRole = AccessibleRole.None
        tb_valor1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        tb_valor1.Font = New Font("MS Gothic", 14.25F, FontStyle.Bold)
        tb_valor1.Location = New Point(13, 123)
        tb_valor1.Name = "tb_valor1"
        tb_valor1.Size = New Size(130, 26)
        tb_valor1.TabIndex = 1
        ' 
        ' tb_valor2
        ' 
        tb_valor2.BackColor = Color.White
        tb_valor2.Font = New Font("MS Gothic", 14.25F, FontStyle.Bold)
        tb_valor2.Location = New Point(13, 75)
        tb_valor2.Name = "tb_valor2"
        tb_valor2.Size = New Size(130, 26)
        tb_valor2.TabIndex = 2
        ' 
        ' btn_calcular
        ' 
        btn_calcular.BackColor = Color.FromArgb(CByte(6), CByte(6), CByte(6))
        btn_calcular.Cursor = Cursors.Hand
        btn_calcular.Enabled = False
        btn_calcular.FlatStyle = FlatStyle.Flat
        btn_calcular.Font = New Font("MS Gothic", 26.25F, FontStyle.Bold)
        btn_calcular.ForeColor = Color.White
        btn_calcular.Location = New Point(13, 180)
        btn_calcular.Name = "btn_calcular"
        btn_calcular.Size = New Size(130, 42)
        btn_calcular.TabIndex = 3
        btn_calcular.Text = "="
        btn_calcular.UseVisualStyleBackColor = False
        ' 
        ' btn_division
        ' 
        btn_division.BackColor = Color.FromArgb(CByte(6), CByte(6), CByte(6))
        btn_division.BackgroundImageLayout = ImageLayout.None
        btn_division.Cursor = Cursors.Hand
        btn_division.FlatStyle = FlatStyle.Flat
        btn_division.Font = New Font("MS Gothic", 26.25F, FontStyle.Bold)
        btn_division.ForeColor = Color.White
        btn_division.Location = New Point(165, 180)
        btn_division.Name = "btn_division"
        btn_division.Size = New Size(40, 40)
        btn_division.TabIndex = 4
        btn_division.Text = "/"
        btn_division.UseVisualStyleBackColor = False
        ' 
        ' btn_suma
        ' 
        btn_suma.BackColor = Color.FromArgb(CByte(6), CByte(6), CByte(6))
        btn_suma.Cursor = Cursors.Hand
        btn_suma.FlatStyle = FlatStyle.Flat
        btn_suma.Font = New Font("MS Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_suma.ForeColor = Color.White
        btn_suma.Location = New Point(165, 10)
        btn_suma.Name = "btn_suma"
        btn_suma.Size = New Size(40, 40)
        btn_suma.TabIndex = 5
        btn_suma.Text = "+"
        btn_suma.UseVisualStyleBackColor = False
        ' 
        ' btn_multiplicacion
        ' 
        btn_multiplicacion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_multiplicacion.BackColor = Color.FromArgb(CByte(6), CByte(6), CByte(6))
        btn_multiplicacion.Cursor = Cursors.Hand
        btn_multiplicacion.FlatStyle = FlatStyle.Flat
        btn_multiplicacion.Font = New Font("MS Gothic", 26.25F, FontStyle.Bold)
        btn_multiplicacion.ForeColor = Color.White
        btn_multiplicacion.Location = New Point(165, 121)
        btn_multiplicacion.Name = "btn_multiplicacion"
        btn_multiplicacion.Size = New Size(40, 40)
        btn_multiplicacion.TabIndex = 6
        btn_multiplicacion.Text = "x"
        btn_multiplicacion.UseVisualStyleBackColor = False
        ' 
        ' btn_resta
        ' 
        btn_resta.BackColor = Color.FromArgb(CByte(6), CByte(6), CByte(6))
        btn_resta.Cursor = Cursors.Hand
        btn_resta.FlatStyle = FlatStyle.Flat
        btn_resta.Font = New Font("MS Gothic", 26.25F, FontStyle.Bold)
        btn_resta.ForeColor = Color.White
        btn_resta.Location = New Point(165, 66)
        btn_resta.Name = "btn_resta"
        btn_resta.Size = New Size(40, 40)
        btn_resta.TabIndex = 7
        btn_resta.Text = "-"
        btn_resta.UseVisualStyleBackColor = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(31))
        ClientSize = New Size(220, 233)
        Controls.Add(btn_resta)
        Controls.Add(btn_multiplicacion)
        Controls.Add(btn_suma)
        Controls.Add(btn_division)
        Controls.Add(btn_calcular)
        Controls.Add(tb_valor2)
        Controls.Add(tb_valor1)
        Controls.Add(lbresultado)
        Cursor = Cursors.Hand
        Name = "form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbresultado As Label
    Friend WithEvents tb_valor1 As TextBox
    Friend WithEvents tb_valor2 As TextBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_suma As Button
    Friend WithEvents btn_multiplicacion As Button
    Friend WithEvents btn_resta As Button

End Class
