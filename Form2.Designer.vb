<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.txtBurgerStock = New System.Windows.Forms.TextBox()
        Me.txtBeefBurgerStock = New System.Windows.Forms.TextBox()
        Me.txtCheeseBurgerStock = New System.Windows.Forms.TextBox()
        Me.btnBurgerAdd = New System.Windows.Forms.Button()
        Me.btnCheeseBurgerAdd = New System.Windows.Forms.Button()
        Me.btnBeefBurgerAdd = New System.Windows.Forms.Button()
        Me.burger = New System.Windows.Forms.Button()
        Me.Cheeseburger = New System.Windows.Forms.Button()
        Me.beefburger = New System.Windows.Forms.Button()
        Me.Doublepatty = New System.Windows.Forms.Button()
        Me.Hotcheese = New System.Windows.Forms.Button()
        Me.Spicyburger = New System.Windows.Forms.Button()
        Me.txtSpicyBurgerStock = New System.Windows.Forms.TextBox()
        Me.txtHotCheeseStock = New System.Windows.Forms.TextBox()
        Me.txtDoublePattyStock = New System.Windows.Forms.TextBox()
        Me.btnSpicyBurgerAdd = New System.Windows.Forms.Button()
        Me.btnHotCheeseAdd = New System.Windows.Forms.Button()
        Me.btnDoublePattyAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Title4)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 53)
        Me.Panel1.TabIndex = 2
        '
        'Title4
        '
        Me.Title4.AutoSize = True
        Me.Title4.Font = New System.Drawing.Font("Mistral", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title4.ForeColor = System.Drawing.Color.Black
        Me.Title4.Location = New System.Drawing.Point(381, 5)
        Me.Title4.Name = "Title4"
        Me.Title4.Size = New System.Drawing.Size(315, 48)
        Me.Title4.TabIndex = 0
        Me.Title4.Text = "BURGERU(Inventory)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Location = New System.Drawing.Point(2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(206, 612)
        Me.Panel2.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(63, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 37)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Orange
        Me.btnHome.Location = New System.Drawing.Point(63, 142)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(69, 37)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'txtBurgerStock
        '
        Me.txtBurgerStock.Location = New System.Drawing.Point(494, 108)
        Me.txtBurgerStock.Name = "txtBurgerStock"
        Me.txtBurgerStock.Size = New System.Drawing.Size(169, 22)
        Me.txtBurgerStock.TabIndex = 5
        '
        'txtBeefBurgerStock
        '
        Me.txtBeefBurgerStock.Location = New System.Drawing.Point(494, 220)
        Me.txtBeefBurgerStock.Name = "txtBeefBurgerStock"
        Me.txtBeefBurgerStock.Size = New System.Drawing.Size(169, 22)
        Me.txtBeefBurgerStock.TabIndex = 6
        '
        'txtCheeseBurgerStock
        '
        Me.txtCheeseBurgerStock.Location = New System.Drawing.Point(494, 165)
        Me.txtCheeseBurgerStock.Name = "txtCheeseBurgerStock"
        Me.txtCheeseBurgerStock.Size = New System.Drawing.Size(169, 22)
        Me.txtCheeseBurgerStock.TabIndex = 7
        '
        'btnBurgerAdd
        '
        Me.btnBurgerAdd.Location = New System.Drawing.Point(699, 108)
        Me.btnBurgerAdd.Name = "btnBurgerAdd"
        Me.btnBurgerAdd.Size = New System.Drawing.Size(43, 24)
        Me.btnBurgerAdd.TabIndex = 8
        Me.btnBurgerAdd.Text = "+"
        Me.btnBurgerAdd.UseVisualStyleBackColor = True
        '
        'btnCheeseBurgerAdd
        '
        Me.btnCheeseBurgerAdd.Location = New System.Drawing.Point(699, 165)
        Me.btnCheeseBurgerAdd.Name = "btnCheeseBurgerAdd"
        Me.btnCheeseBurgerAdd.Size = New System.Drawing.Size(43, 24)
        Me.btnCheeseBurgerAdd.TabIndex = 9
        Me.btnCheeseBurgerAdd.Text = "+"
        Me.btnCheeseBurgerAdd.UseVisualStyleBackColor = True
        '
        'btnBeefBurgerAdd
        '
        Me.btnBeefBurgerAdd.Location = New System.Drawing.Point(699, 221)
        Me.btnBeefBurgerAdd.Name = "btnBeefBurgerAdd"
        Me.btnBeefBurgerAdd.Size = New System.Drawing.Size(43, 24)
        Me.btnBeefBurgerAdd.TabIndex = 10
        Me.btnBeefBurgerAdd.Text = "+"
        Me.btnBeefBurgerAdd.UseVisualStyleBackColor = True
        '
        'burger
        '
        Me.burger.BackColor = System.Drawing.Color.DarkOrange
        Me.burger.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.burger.Location = New System.Drawing.Point(273, 98)
        Me.burger.Name = "burger"
        Me.burger.Size = New System.Drawing.Size(150, 41)
        Me.burger.TabIndex = 11
        Me.burger.Text = "Burger"
        Me.burger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.burger.UseVisualStyleBackColor = False
        '
        'Cheeseburger
        '
        Me.Cheeseburger.BackColor = System.Drawing.Color.DarkOrange
        Me.Cheeseburger.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cheeseburger.Location = New System.Drawing.Point(273, 156)
        Me.Cheeseburger.Name = "Cheeseburger"
        Me.Cheeseburger.Size = New System.Drawing.Size(150, 41)
        Me.Cheeseburger.TabIndex = 12
        Me.Cheeseburger.Text = "CheeseBurger"
        Me.Cheeseburger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Cheeseburger.UseVisualStyleBackColor = False
        '
        'beefburger
        '
        Me.beefburger.BackColor = System.Drawing.Color.DarkOrange
        Me.beefburger.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beefburger.ForeColor = System.Drawing.Color.Black
        Me.beefburger.Location = New System.Drawing.Point(273, 213)
        Me.beefburger.Name = "beefburger"
        Me.beefburger.Size = New System.Drawing.Size(150, 41)
        Me.beefburger.TabIndex = 13
        Me.beefburger.Text = "BeefBurger"
        Me.beefburger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.beefburger.UseVisualStyleBackColor = False
        '
        'Doublepatty
        '
        Me.Doublepatty.BackColor = System.Drawing.Color.DarkOrange
        Me.Doublepatty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doublepatty.Location = New System.Drawing.Point(273, 269)
        Me.Doublepatty.Name = "Doublepatty"
        Me.Doublepatty.Size = New System.Drawing.Size(150, 41)
        Me.Doublepatty.TabIndex = 14
        Me.Doublepatty.Text = "DoublePatty"
        Me.Doublepatty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Doublepatty.UseVisualStyleBackColor = False
        '
        'Hotcheese
        '
        Me.Hotcheese.BackColor = System.Drawing.Color.DarkOrange
        Me.Hotcheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hotcheese.Location = New System.Drawing.Point(273, 325)
        Me.Hotcheese.Name = "Hotcheese"
        Me.Hotcheese.Size = New System.Drawing.Size(150, 41)
        Me.Hotcheese.TabIndex = 15
        Me.Hotcheese.Text = "Hot&Cheese"
        Me.Hotcheese.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Hotcheese.UseVisualStyleBackColor = False
        '
        'Spicyburger
        '
        Me.Spicyburger.BackColor = System.Drawing.Color.DarkOrange
        Me.Spicyburger.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spicyburger.Location = New System.Drawing.Point(273, 383)
        Me.Spicyburger.Name = "Spicyburger"
        Me.Spicyburger.Size = New System.Drawing.Size(150, 41)
        Me.Spicyburger.TabIndex = 16
        Me.Spicyburger.Text = "SpicyBurger"
        Me.Spicyburger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Spicyburger.UseVisualStyleBackColor = False
        '
        'txtSpicyBurgerStock
        '
        Me.txtSpicyBurgerStock.Location = New System.Drawing.Point(494, 392)
        Me.txtSpicyBurgerStock.Name = "txtSpicyBurgerStock"
        Me.txtSpicyBurgerStock.Size = New System.Drawing.Size(169, 22)
        Me.txtSpicyBurgerStock.TabIndex = 17
        '
        'txtHotCheeseStock
        '
        Me.txtHotCheeseStock.Location = New System.Drawing.Point(494, 334)
        Me.txtHotCheeseStock.Name = "txtHotCheeseStock"
        Me.txtHotCheeseStock.Size = New System.Drawing.Size(169, 22)
        Me.txtHotCheeseStock.TabIndex = 18
        '
        'txtDoublePattyStock
        '
        Me.txtDoublePattyStock.Location = New System.Drawing.Point(494, 278)
        Me.txtDoublePattyStock.Name = "txtDoublePattyStock"
        Me.txtDoublePattyStock.Size = New System.Drawing.Size(169, 22)
        Me.txtDoublePattyStock.TabIndex = 19
        '
        'btnSpicyBurgerAdd
        '
        Me.btnSpicyBurgerAdd.Location = New System.Drawing.Point(699, 392)
        Me.btnSpicyBurgerAdd.Name = "btnSpicyBurgerAdd"
        Me.btnSpicyBurgerAdd.Size = New System.Drawing.Size(43, 24)
        Me.btnSpicyBurgerAdd.TabIndex = 20
        Me.btnSpicyBurgerAdd.Text = "+"
        Me.btnSpicyBurgerAdd.UseVisualStyleBackColor = True
        '
        'btnHotCheeseAdd
        '
        Me.btnHotCheeseAdd.Location = New System.Drawing.Point(699, 333)
        Me.btnHotCheeseAdd.Name = "btnHotCheeseAdd"
        Me.btnHotCheeseAdd.Size = New System.Drawing.Size(43, 24)
        Me.btnHotCheeseAdd.TabIndex = 21
        Me.btnHotCheeseAdd.Text = "+"
        Me.btnHotCheeseAdd.UseVisualStyleBackColor = True
        '
        'btnDoublePattyAdd
        '
        Me.btnDoublePattyAdd.Location = New System.Drawing.Point(699, 278)
        Me.btnDoublePattyAdd.Name = "btnDoublePattyAdd"
        Me.btnDoublePattyAdd.Size = New System.Drawing.Size(43, 24)
        Me.btnDoublePattyAdd.TabIndex = 22
        Me.btnDoublePattyAdd.Text = "+"
        Me.btnDoublePattyAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Stocks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(702, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 22)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "add"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Foods"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 455)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDoublePattyAdd)
        Me.Controls.Add(Me.btnHotCheeseAdd)
        Me.Controls.Add(Me.btnSpicyBurgerAdd)
        Me.Controls.Add(Me.txtDoublePattyStock)
        Me.Controls.Add(Me.txtHotCheeseStock)
        Me.Controls.Add(Me.txtSpicyBurgerStock)
        Me.Controls.Add(Me.Spicyburger)
        Me.Controls.Add(Me.Hotcheese)
        Me.Controls.Add(Me.Doublepatty)
        Me.Controls.Add(Me.beefburger)
        Me.Controls.Add(Me.Cheeseburger)
        Me.Controls.Add(Me.burger)
        Me.Controls.Add(Me.btnBeefBurgerAdd)
        Me.Controls.Add(Me.btnCheeseBurgerAdd)
        Me.Controls.Add(Me.btnBurgerAdd)
        Me.Controls.Add(Me.txtCheeseBurgerStock)
        Me.Controls.Add(Me.txtBeefBurgerStock)
        Me.Controls.Add(Me.txtBurgerStock)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Title4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBurgerStock As TextBox
    Friend WithEvents txtBeefBurgerStock As TextBox
    Friend WithEvents txtCheeseBurgerStock As TextBox
    Friend WithEvents btnBurgerAdd As Button
    Friend WithEvents btnCheeseBurgerAdd As Button
    Friend WithEvents btnBeefBurgerAdd As Button
    Friend WithEvents burger As Button
    Friend WithEvents Cheeseburger As Button
    Friend WithEvents beefburger As Button
    Friend WithEvents Doublepatty As Button
    Friend WithEvents Hotcheese As Button
    Friend WithEvents Spicyburger As Button
    Friend WithEvents txtSpicyBurgerStock As TextBox
    Friend WithEvents txtHotCheeseStock As TextBox
    Friend WithEvents txtDoublePattyStock As TextBox
    Friend WithEvents btnSpicyBurgerAdd As Button
    Friend WithEvents btnHotCheeseAdd As Button
    Friend WithEvents btnDoublePattyAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
