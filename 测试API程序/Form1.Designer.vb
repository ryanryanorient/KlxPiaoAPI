﻿Imports KlxPiaoAPI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits KlxPiaoForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.KlxPiaoButton1 = New KlxPiaoAPI.KlxPiaoButton()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.PointBar1 = New KlxPiaoAPI.PointBar()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.KlxPiaoPanel1 = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoProgressBar1 = New KlxPiaoAPI.KlxPiaoProgressBar()
        Me.KlxPiaoLabel1 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.KlxPiaoButton4 = New KlxPiaoAPI.KlxPiaoButton()
        Me.KlxPiaoButton3 = New KlxPiaoAPI.KlxPiaoButton()
        Me.KlxPiaoButton2 = New KlxPiaoAPI.KlxPiaoButton()
        Me.KlxPiaoPanel16 = New KlxPiaoAPI.KlxPiaoPanel()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.KlxPiaoPanel17 = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel10 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.最小化按钮前景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.最小化按钮背景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.关闭按钮按下Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.关闭按钮前景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel18 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel17 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel14 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.关闭按钮移入Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel13 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel16 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel11 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.最小化按钮移入Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel15 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel12 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.关闭按钮背景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.最小化按钮按下Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel9 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel7 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel4 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.缩放按钮背景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.缩放按钮前景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel5 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel6 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.缩放按钮移入Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel8 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.缩放按钮按下Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.背景Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.主题Panel = New KlxPiaoAPI.KlxPiaoPanel()
        Me.KlxPiaoLabel3 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel2 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.KlxPiaoLabel19 = New KlxPiaoAPI.KlxPiaoLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.KlxPiaoPanel16.SuspendLayout()
        Me.KlxPiaoPanel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "自定义属性名"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 23)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 23)
        Me.TextBox2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "类型"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 47)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "生成"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 68)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(168, 23)
        Me.TextBox4.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "默认值"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 397)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(668, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "自定义属性代码生成器"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(267, 13)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(395, 321)
        Me.TextBox3.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(668, 367)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "调整窗体属性"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 21)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "启用缩放动画"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "窗体拖动位置"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"仅标题框", "整个窗体", "不启用拖动"})
        Me.ComboBox3.Location = New System.Drawing.Point(129, 142)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox3.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"左", "居中", "右"})
        Me.ComboBox2.Location = New System.Drawing.Point(129, 111)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "标题位置"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "窗体按钮显示方式"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"全部显示", "显示关闭和最小化", "仅显示关闭", "不显示"})
        Me.ComboBox1.Location = New System.Drawing.Point(129, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 7
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(22, 45)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(123, 21)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "窗体可以调整大小"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.KlxPiaoButton1)
        Me.TabPage3.Controls.Add(Me.CheckBox4)
        Me.TabPage3.Controls.Add(Me.PointBar1)
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.KlxPiaoPanel1)
        Me.TabPage3.Controls.Add(Me.KlxPiaoProgressBar1)
        Me.TabPage3.Controls.Add(Me.KlxPiaoLabel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(668, 367)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "KlxPiao控件"
        '
        'KlxPiaoButton1
        '
        Me.KlxPiaoButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.KlxPiaoButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.KlxPiaoButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.KlxPiaoButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KlxPiaoButton1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoButton1.Location = New System.Drawing.Point(463, 176)
        Me.KlxPiaoButton1.Name = "KlxPiaoButton1"
        Me.KlxPiaoButton1.Size = New System.Drawing.Size(110, 40)
        Me.KlxPiaoButton1.TabIndex = 20
        Me.KlxPiaoButton1.Text = "KlxPiaoButton1"
        Me.KlxPiaoButton1.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(453, 63)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox4.TabIndex = 19
        Me.CheckBox4.Text = "颜色减淡"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'PointBar1
        '
        Me.PointBar1.BackColor = System.Drawing.Color.White
        Me.PointBar1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.PointBar1.Location = New System.Drawing.Point(555, 20)
        Me.PointBar1.Name = "PointBar1"
        Me.PointBar1.Size = New System.Drawing.Size(88, 88)
        Me.PointBar1.TabIndex = 17
        Me.PointBar1.Text = "PointBar1"
        Me.PointBar1.值 = New System.Drawing.Point(0, 0)
        Me.PointBar1.准星大小 = 5
        Me.PointBar1.准星颜色 = System.Drawing.Color.Red
        Me.PointBar1.坐标显示位置 = System.Drawing.ContentAlignment.TopLeft
        Me.PointBar1.坐标轴颜色 = System.Drawing.Color.LightPink
        Me.PointBar1.显示坐标 = True
        Me.PointBar1.显示坐标轴 = True
        Me.PointBar1.最大值 = New System.Drawing.Point(40, 40)
        Me.PointBar1.最小值 = New System.Drawing.Point(-20, -20)
        Me.PointBar1.边框大小 = 1
        Me.PointBar1.边框颜色 = System.Drawing.Color.Gray
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(453, 36)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "投影连线"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'KlxPiaoPanel1
        '
        Me.KlxPiaoPanel1.BackColor = System.Drawing.Color.White
        Me.KlxPiaoPanel1.Location = New System.Drawing.Point(28, 123)
        Me.KlxPiaoPanel1.Name = "KlxPiaoPanel1"
        Me.KlxPiaoPanel1.Size = New System.Drawing.Size(340, 173)
        Me.KlxPiaoPanel1.TabIndex = 4
        Me.KlxPiaoPanel1.启用投影 = True
        Me.KlxPiaoPanel1.投影长度 = 5
        Me.KlxPiaoPanel1.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.KlxPiaoPanel1.边框大小 = 1
        Me.KlxPiaoPanel1.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoProgressBar1
        '
        Me.KlxPiaoProgressBar1.BackColor = System.Drawing.Color.White
        Me.KlxPiaoProgressBar1.ForeColor = System.Drawing.Color.PowderBlue
        Me.KlxPiaoProgressBar1.Location = New System.Drawing.Point(6, 349)
        Me.KlxPiaoProgressBar1.Name = "KlxPiaoProgressBar1"
        Me.KlxPiaoProgressBar1.Size = New System.Drawing.Size(656, 12)
        Me.KlxPiaoProgressBar1.TabIndex = 3
        Me.KlxPiaoProgressBar1.边框大小 = 1
        Me.KlxPiaoProgressBar1.边框颜色 = System.Drawing.Color.LightGray
        '
        'KlxPiaoLabel1
        '
        Me.KlxPiaoLabel1.AutoSize = False
        Me.KlxPiaoLabel1.BackColor = System.Drawing.Color.White
        Me.KlxPiaoLabel1.Font = New System.Drawing.Font("微软雅黑 Light", 50.0!)
        Me.KlxPiaoLabel1.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel1.Location = New System.Drawing.Point(13, 20)
        Me.KlxPiaoLabel1.Name = "KlxPiaoLabel1"
        Me.KlxPiaoLabel1.Size = New System.Drawing.Size(413, 88)
        Me.KlxPiaoLabel1.TabIndex = 2
        Me.KlxPiaoLabel1.Text = "KlxPiaoLabel"
        Me.KlxPiaoLabel1.偏移量 = New System.Drawing.Point(5, 5)
        Me.KlxPiaoLabel1.启用投影 = True
        Me.KlxPiaoLabel1.投影连线 = True
        Me.KlxPiaoLabel1.投影颜色 = System.Drawing.Color.Black
        Me.KlxPiaoLabel1.颜色减淡 = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(668, 367)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "KlxPiaoForm函数"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 156)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(174, 44)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "导出主题文件"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 106)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(174, 44)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "加载主题文件"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 56)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(174, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "设置 WindowState"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "加载本地字体（很容易闪退卡死）"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.KlxPiaoLabel19)
        Me.TabPage5.Controls.Add(Me.KlxPiaoButton4)
        Me.TabPage5.Controls.Add(Me.KlxPiaoButton3)
        Me.TabPage5.Controls.Add(Me.KlxPiaoButton2)
        Me.TabPage5.Controls.Add(Me.KlxPiaoPanel16)
        Me.TabPage5.Controls.Add(Me.背景Panel)
        Me.TabPage5.Controls.Add(Me.主题Panel)
        Me.TabPage5.Controls.Add(Me.KlxPiaoLabel3)
        Me.TabPage5.Controls.Add(Me.KlxPiaoLabel2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(668, 367)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "皮肤编辑器"
        '
        'KlxPiaoButton4
        '
        Me.KlxPiaoButton4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.KlxPiaoButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.KlxPiaoButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.KlxPiaoButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KlxPiaoButton4.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoButton4.Location = New System.Drawing.Point(543, 24)
        Me.KlxPiaoButton4.Name = "KlxPiaoButton4"
        Me.KlxPiaoButton4.Size = New System.Drawing.Size(97, 40)
        Me.KlxPiaoButton4.TabIndex = 32
        Me.KlxPiaoButton4.Text = "导入"
        Me.KlxPiaoButton4.UseVisualStyleBackColor = True
        '
        'KlxPiaoButton3
        '
        Me.KlxPiaoButton3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.KlxPiaoButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.KlxPiaoButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.KlxPiaoButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KlxPiaoButton3.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoButton3.Location = New System.Drawing.Point(436, 24)
        Me.KlxPiaoButton3.Name = "KlxPiaoButton3"
        Me.KlxPiaoButton3.Size = New System.Drawing.Size(97, 40)
        Me.KlxPiaoButton3.TabIndex = 31
        Me.KlxPiaoButton3.Text = "导出"
        Me.KlxPiaoButton3.UseVisualStyleBackColor = True
        '
        'KlxPiaoButton2
        '
        Me.KlxPiaoButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.KlxPiaoButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.KlxPiaoButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.KlxPiaoButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KlxPiaoButton2.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoButton2.Location = New System.Drawing.Point(259, 24)
        Me.KlxPiaoButton2.Name = "KlxPiaoButton2"
        Me.KlxPiaoButton2.Size = New System.Drawing.Size(167, 40)
        Me.KlxPiaoButton2.TabIndex = 30
        Me.KlxPiaoButton2.Text = "根据主题色一键生成"
        Me.KlxPiaoButton2.UseVisualStyleBackColor = True
        '
        'KlxPiaoPanel16
        '
        Me.KlxPiaoPanel16.BackColor = System.Drawing.Color.White
        Me.KlxPiaoPanel16.Controls.Add(Me.CheckBox5)
        Me.KlxPiaoPanel16.Controls.Add(Me.KlxPiaoPanel17)
        Me.KlxPiaoPanel16.Controls.Add(Me.KlxPiaoLabel7)
        Me.KlxPiaoPanel16.Controls.Add(Me.KlxPiaoLabel4)
        Me.KlxPiaoPanel16.Controls.Add(Me.缩放按钮背景Panel)
        Me.KlxPiaoPanel16.Controls.Add(Me.缩放按钮前景Panel)
        Me.KlxPiaoPanel16.Controls.Add(Me.KlxPiaoLabel5)
        Me.KlxPiaoPanel16.Controls.Add(Me.KlxPiaoLabel6)
        Me.KlxPiaoPanel16.Controls.Add(Me.缩放按钮移入Panel)
        Me.KlxPiaoPanel16.Controls.Add(Me.KlxPiaoLabel8)
        Me.KlxPiaoPanel16.Controls.Add(Me.缩放按钮按下Panel)
        Me.KlxPiaoPanel16.Location = New System.Drawing.Point(23, 92)
        Me.KlxPiaoPanel16.Name = "KlxPiaoPanel16"
        Me.KlxPiaoPanel16.Size = New System.Drawing.Size(624, 256)
        Me.KlxPiaoPanel16.TabIndex = 29
        Me.KlxPiaoPanel16.启用投影 = True
        Me.KlxPiaoPanel16.投影长度 = 5
        Me.KlxPiaoPanel16.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.KlxPiaoPanel16.边框大小 = 1
        Me.KlxPiaoPanel16.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(27, 8)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(207, 21)
        Me.CheckBox5.TabIndex = 30
        Me.CheckBox5.Text = "统一按钮配色（以缩放按钮为准）"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'KlxPiaoPanel17
        '
        Me.KlxPiaoPanel17.BackColor = System.Drawing.Color.White
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel10)
        Me.KlxPiaoPanel17.Controls.Add(Me.最小化按钮前景Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.最小化按钮背景Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.关闭按钮按下Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.关闭按钮前景Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel18)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel17)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel14)
        Me.KlxPiaoPanel17.Controls.Add(Me.关闭按钮移入Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel13)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel16)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel11)
        Me.KlxPiaoPanel17.Controls.Add(Me.最小化按钮移入Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel15)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel12)
        Me.KlxPiaoPanel17.Controls.Add(Me.关闭按钮背景Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.最小化按钮按下Panel)
        Me.KlxPiaoPanel17.Controls.Add(Me.KlxPiaoLabel9)
        Me.KlxPiaoPanel17.Location = New System.Drawing.Point(18, 99)
        Me.KlxPiaoPanel17.Name = "KlxPiaoPanel17"
        Me.KlxPiaoPanel17.Size = New System.Drawing.Size(587, 115)
        Me.KlxPiaoPanel17.TabIndex = 30
        Me.KlxPiaoPanel17.启用投影 = False
        Me.KlxPiaoPanel17.投影长度 = 5
        Me.KlxPiaoPanel17.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.KlxPiaoPanel17.边框大小 = 0
        Me.KlxPiaoPanel17.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel10
        '
        Me.KlxPiaoLabel10.AutoSize = False
        Me.KlxPiaoLabel10.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel10.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel10.Location = New System.Drawing.Point(3, 0)
        Me.KlxPiaoLabel10.Name = "KlxPiaoLabel10"
        Me.KlxPiaoLabel10.Size = New System.Drawing.Size(100, 50)
        Me.KlxPiaoLabel10.TabIndex = 19
        Me.KlxPiaoLabel10.Text = "关闭按钮"
        Me.KlxPiaoLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel10.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel10.启用投影 = False
        Me.KlxPiaoLabel10.投影连线 = True
        Me.KlxPiaoLabel10.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel10.颜色减淡 = False
        '
        '最小化按钮前景Panel
        '
        Me.最小化按钮前景Panel.BackColor = System.Drawing.Color.White
        Me.最小化按钮前景Panel.Location = New System.Drawing.Point(265, 56)
        Me.最小化按钮前景Panel.Name = "最小化按钮前景Panel"
        Me.最小化按钮前景Panel.Size = New System.Drawing.Size(50, 50)
        Me.最小化按钮前景Panel.TabIndex = 24
        Me.最小化按钮前景Panel.启用投影 = False
        Me.最小化按钮前景Panel.投影长度 = 5
        Me.最小化按钮前景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.最小化按钮前景Panel.边框大小 = 1
        Me.最小化按钮前景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '最小化按钮背景Panel
        '
        Me.最小化按钮背景Panel.BackColor = System.Drawing.Color.White
        Me.最小化按钮背景Panel.Location = New System.Drawing.Point(159, 56)
        Me.最小化按钮背景Panel.Name = "最小化按钮背景Panel"
        Me.最小化按钮背景Panel.Size = New System.Drawing.Size(50, 50)
        Me.最小化按钮背景Panel.TabIndex = 21
        Me.最小化按钮背景Panel.启用投影 = False
        Me.最小化按钮背景Panel.投影长度 = 5
        Me.最小化按钮背景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.最小化按钮背景Panel.边框大小 = 1
        Me.最小化按钮背景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '关闭按钮按下Panel
        '
        Me.关闭按钮按下Panel.BackColor = System.Drawing.Color.White
        Me.关闭按钮按下Panel.Location = New System.Drawing.Point(477, 0)
        Me.关闭按钮按下Panel.Name = "关闭按钮按下Panel"
        Me.关闭按钮按下Panel.Size = New System.Drawing.Size(50, 50)
        Me.关闭按钮按下Panel.TabIndex = 18
        Me.关闭按钮按下Panel.启用投影 = False
        Me.关闭按钮按下Panel.投影长度 = 5
        Me.关闭按钮按下Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.关闭按钮按下Panel.边框大小 = 1
        Me.关闭按钮按下Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '关闭按钮前景Panel
        '
        Me.关闭按钮前景Panel.BackColor = System.Drawing.Color.White
        Me.关闭按钮前景Panel.Location = New System.Drawing.Point(265, 0)
        Me.关闭按钮前景Panel.Name = "关闭按钮前景Panel"
        Me.关闭按钮前景Panel.Size = New System.Drawing.Size(50, 50)
        Me.关闭按钮前景Panel.TabIndex = 15
        Me.关闭按钮前景Panel.启用投影 = False
        Me.关闭按钮前景Panel.投影长度 = 5
        Me.关闭按钮前景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.关闭按钮前景Panel.边框大小 = 1
        Me.关闭按钮前景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel18
        '
        Me.KlxPiaoLabel18.AutoSize = False
        Me.KlxPiaoLabel18.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel18.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel18.Location = New System.Drawing.Point(109, 56)
        Me.KlxPiaoLabel18.Name = "KlxPiaoLabel18"
        Me.KlxPiaoLabel18.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel18.TabIndex = 20
        Me.KlxPiaoLabel18.Text = "背景"
        Me.KlxPiaoLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel18.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel18.启用投影 = False
        Me.KlxPiaoLabel18.投影连线 = True
        Me.KlxPiaoLabel18.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel18.颜色减淡 = False
        '
        'KlxPiaoLabel17
        '
        Me.KlxPiaoLabel17.AutoSize = False
        Me.KlxPiaoLabel17.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel17.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel17.Location = New System.Drawing.Point(321, 56)
        Me.KlxPiaoLabel17.Name = "KlxPiaoLabel17"
        Me.KlxPiaoLabel17.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel17.TabIndex = 23
        Me.KlxPiaoLabel17.Text = "移入"
        Me.KlxPiaoLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel17.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel17.启用投影 = False
        Me.KlxPiaoLabel17.投影连线 = True
        Me.KlxPiaoLabel17.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel17.颜色减淡 = False
        '
        'KlxPiaoLabel14
        '
        Me.KlxPiaoLabel14.AutoSize = False
        Me.KlxPiaoLabel14.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel14.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel14.Location = New System.Drawing.Point(215, 56)
        Me.KlxPiaoLabel14.Name = "KlxPiaoLabel14"
        Me.KlxPiaoLabel14.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel14.TabIndex = 22
        Me.KlxPiaoLabel14.Text = "前景"
        Me.KlxPiaoLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel14.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel14.启用投影 = False
        Me.KlxPiaoLabel14.投影连线 = True
        Me.KlxPiaoLabel14.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel14.颜色减淡 = False
        '
        '关闭按钮移入Panel
        '
        Me.关闭按钮移入Panel.BackColor = System.Drawing.Color.White
        Me.关闭按钮移入Panel.Location = New System.Drawing.Point(371, 0)
        Me.关闭按钮移入Panel.Name = "关闭按钮移入Panel"
        Me.关闭按钮移入Panel.Size = New System.Drawing.Size(50, 50)
        Me.关闭按钮移入Panel.TabIndex = 16
        Me.关闭按钮移入Panel.启用投影 = False
        Me.关闭按钮移入Panel.投影长度 = 5
        Me.关闭按钮移入Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.关闭按钮移入Panel.边框大小 = 1
        Me.关闭按钮移入Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel13
        '
        Me.KlxPiaoLabel13.AutoSize = False
        Me.KlxPiaoLabel13.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel13.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel13.Location = New System.Drawing.Point(109, 0)
        Me.KlxPiaoLabel13.Name = "KlxPiaoLabel13"
        Me.KlxPiaoLabel13.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel13.TabIndex = 11
        Me.KlxPiaoLabel13.Text = "背景"
        Me.KlxPiaoLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel13.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel13.启用投影 = False
        Me.KlxPiaoLabel13.投影连线 = True
        Me.KlxPiaoLabel13.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel13.颜色减淡 = False
        '
        'KlxPiaoLabel16
        '
        Me.KlxPiaoLabel16.AutoSize = False
        Me.KlxPiaoLabel16.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel16.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel16.Location = New System.Drawing.Point(427, 56)
        Me.KlxPiaoLabel16.Name = "KlxPiaoLabel16"
        Me.KlxPiaoLabel16.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel16.TabIndex = 26
        Me.KlxPiaoLabel16.Text = "按下"
        Me.KlxPiaoLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel16.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel16.启用投影 = False
        Me.KlxPiaoLabel16.投影连线 = True
        Me.KlxPiaoLabel16.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel16.颜色减淡 = False
        '
        'KlxPiaoLabel11
        '
        Me.KlxPiaoLabel11.AutoSize = False
        Me.KlxPiaoLabel11.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel11.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel11.Location = New System.Drawing.Point(427, 0)
        Me.KlxPiaoLabel11.Name = "KlxPiaoLabel11"
        Me.KlxPiaoLabel11.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel11.TabIndex = 17
        Me.KlxPiaoLabel11.Text = "按下"
        Me.KlxPiaoLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel11.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel11.启用投影 = False
        Me.KlxPiaoLabel11.投影连线 = True
        Me.KlxPiaoLabel11.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel11.颜色减淡 = False
        '
        '最小化按钮移入Panel
        '
        Me.最小化按钮移入Panel.BackColor = System.Drawing.Color.White
        Me.最小化按钮移入Panel.Location = New System.Drawing.Point(371, 56)
        Me.最小化按钮移入Panel.Name = "最小化按钮移入Panel"
        Me.最小化按钮移入Panel.Size = New System.Drawing.Size(50, 50)
        Me.最小化按钮移入Panel.TabIndex = 25
        Me.最小化按钮移入Panel.启用投影 = False
        Me.最小化按钮移入Panel.投影长度 = 5
        Me.最小化按钮移入Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.最小化按钮移入Panel.边框大小 = 1
        Me.最小化按钮移入Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel15
        '
        Me.KlxPiaoLabel15.AutoSize = False
        Me.KlxPiaoLabel15.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel15.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel15.Location = New System.Drawing.Point(3, 56)
        Me.KlxPiaoLabel15.Name = "KlxPiaoLabel15"
        Me.KlxPiaoLabel15.Size = New System.Drawing.Size(100, 50)
        Me.KlxPiaoLabel15.TabIndex = 28
        Me.KlxPiaoLabel15.Text = "最小化按钮"
        Me.KlxPiaoLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel15.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel15.启用投影 = False
        Me.KlxPiaoLabel15.投影连线 = True
        Me.KlxPiaoLabel15.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel15.颜色减淡 = False
        '
        'KlxPiaoLabel12
        '
        Me.KlxPiaoLabel12.AutoSize = False
        Me.KlxPiaoLabel12.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel12.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel12.Location = New System.Drawing.Point(321, 0)
        Me.KlxPiaoLabel12.Name = "KlxPiaoLabel12"
        Me.KlxPiaoLabel12.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel12.TabIndex = 14
        Me.KlxPiaoLabel12.Text = "移入"
        Me.KlxPiaoLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel12.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel12.启用投影 = False
        Me.KlxPiaoLabel12.投影连线 = True
        Me.KlxPiaoLabel12.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel12.颜色减淡 = False
        '
        '关闭按钮背景Panel
        '
        Me.关闭按钮背景Panel.BackColor = System.Drawing.Color.White
        Me.关闭按钮背景Panel.Location = New System.Drawing.Point(159, 0)
        Me.关闭按钮背景Panel.Name = "关闭按钮背景Panel"
        Me.关闭按钮背景Panel.Size = New System.Drawing.Size(50, 50)
        Me.关闭按钮背景Panel.TabIndex = 12
        Me.关闭按钮背景Panel.启用投影 = False
        Me.关闭按钮背景Panel.投影长度 = 5
        Me.关闭按钮背景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.关闭按钮背景Panel.边框大小 = 1
        Me.关闭按钮背景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '最小化按钮按下Panel
        '
        Me.最小化按钮按下Panel.BackColor = System.Drawing.Color.White
        Me.最小化按钮按下Panel.Location = New System.Drawing.Point(477, 56)
        Me.最小化按钮按下Panel.Name = "最小化按钮按下Panel"
        Me.最小化按钮按下Panel.Size = New System.Drawing.Size(50, 50)
        Me.最小化按钮按下Panel.TabIndex = 27
        Me.最小化按钮按下Panel.启用投影 = False
        Me.最小化按钮按下Panel.投影长度 = 5
        Me.最小化按钮按下Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.最小化按钮按下Panel.边框大小 = 1
        Me.最小化按钮按下Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel9
        '
        Me.KlxPiaoLabel9.AutoSize = False
        Me.KlxPiaoLabel9.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel9.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel9.Location = New System.Drawing.Point(215, 0)
        Me.KlxPiaoLabel9.Name = "KlxPiaoLabel9"
        Me.KlxPiaoLabel9.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel9.TabIndex = 13
        Me.KlxPiaoLabel9.Text = "前景"
        Me.KlxPiaoLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel9.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel9.启用投影 = False
        Me.KlxPiaoLabel9.投影连线 = True
        Me.KlxPiaoLabel9.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel9.颜色减淡 = False
        '
        'KlxPiaoLabel7
        '
        Me.KlxPiaoLabel7.AutoSize = False
        Me.KlxPiaoLabel7.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel7.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel7.Location = New System.Drawing.Point(21, 44)
        Me.KlxPiaoLabel7.Name = "KlxPiaoLabel7"
        Me.KlxPiaoLabel7.Size = New System.Drawing.Size(100, 50)
        Me.KlxPiaoLabel7.TabIndex = 10
        Me.KlxPiaoLabel7.Text = "缩放按钮"
        Me.KlxPiaoLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel7.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel7.启用投影 = False
        Me.KlxPiaoLabel7.投影连线 = True
        Me.KlxPiaoLabel7.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel7.颜色减淡 = False
        '
        'KlxPiaoLabel4
        '
        Me.KlxPiaoLabel4.AutoSize = False
        Me.KlxPiaoLabel4.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel4.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel4.Location = New System.Drawing.Point(127, 44)
        Me.KlxPiaoLabel4.Name = "KlxPiaoLabel4"
        Me.KlxPiaoLabel4.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel4.TabIndex = 4
        Me.KlxPiaoLabel4.Text = "背景"
        Me.KlxPiaoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel4.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel4.启用投影 = False
        Me.KlxPiaoLabel4.投影连线 = True
        Me.KlxPiaoLabel4.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel4.颜色减淡 = False
        '
        '缩放按钮背景Panel
        '
        Me.缩放按钮背景Panel.BackColor = System.Drawing.Color.White
        Me.缩放按钮背景Panel.Location = New System.Drawing.Point(177, 44)
        Me.缩放按钮背景Panel.Name = "缩放按钮背景Panel"
        Me.缩放按钮背景Panel.Size = New System.Drawing.Size(50, 50)
        Me.缩放按钮背景Panel.TabIndex = 5
        Me.缩放按钮背景Panel.启用投影 = False
        Me.缩放按钮背景Panel.投影长度 = 5
        Me.缩放按钮背景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.缩放按钮背景Panel.边框大小 = 1
        Me.缩放按钮背景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '缩放按钮前景Panel
        '
        Me.缩放按钮前景Panel.BackColor = System.Drawing.Color.White
        Me.缩放按钮前景Panel.Location = New System.Drawing.Point(283, 44)
        Me.缩放按钮前景Panel.Name = "缩放按钮前景Panel"
        Me.缩放按钮前景Panel.Size = New System.Drawing.Size(50, 50)
        Me.缩放按钮前景Panel.TabIndex = 7
        Me.缩放按钮前景Panel.启用投影 = False
        Me.缩放按钮前景Panel.投影长度 = 5
        Me.缩放按钮前景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.缩放按钮前景Panel.边框大小 = 1
        Me.缩放按钮前景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel5
        '
        Me.KlxPiaoLabel5.AutoSize = False
        Me.KlxPiaoLabel5.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel5.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel5.Location = New System.Drawing.Point(339, 44)
        Me.KlxPiaoLabel5.Name = "KlxPiaoLabel5"
        Me.KlxPiaoLabel5.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel5.TabIndex = 6
        Me.KlxPiaoLabel5.Text = "移入"
        Me.KlxPiaoLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel5.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel5.启用投影 = False
        Me.KlxPiaoLabel5.投影连线 = True
        Me.KlxPiaoLabel5.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel5.颜色减淡 = False
        '
        'KlxPiaoLabel6
        '
        Me.KlxPiaoLabel6.AutoSize = False
        Me.KlxPiaoLabel6.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel6.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel6.Location = New System.Drawing.Point(445, 44)
        Me.KlxPiaoLabel6.Name = "KlxPiaoLabel6"
        Me.KlxPiaoLabel6.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel6.TabIndex = 8
        Me.KlxPiaoLabel6.Text = "按下"
        Me.KlxPiaoLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel6.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel6.启用投影 = False
        Me.KlxPiaoLabel6.投影连线 = True
        Me.KlxPiaoLabel6.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel6.颜色减淡 = False
        '
        '缩放按钮移入Panel
        '
        Me.缩放按钮移入Panel.BackColor = System.Drawing.Color.White
        Me.缩放按钮移入Panel.Location = New System.Drawing.Point(389, 44)
        Me.缩放按钮移入Panel.Name = "缩放按钮移入Panel"
        Me.缩放按钮移入Panel.Size = New System.Drawing.Size(50, 50)
        Me.缩放按钮移入Panel.TabIndex = 7
        Me.缩放按钮移入Panel.启用投影 = False
        Me.缩放按钮移入Panel.投影长度 = 5
        Me.缩放按钮移入Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.缩放按钮移入Panel.边框大小 = 1
        Me.缩放按钮移入Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel8
        '
        Me.KlxPiaoLabel8.AutoSize = False
        Me.KlxPiaoLabel8.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel8.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel8.Location = New System.Drawing.Point(233, 44)
        Me.KlxPiaoLabel8.Name = "KlxPiaoLabel8"
        Me.KlxPiaoLabel8.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel8.TabIndex = 6
        Me.KlxPiaoLabel8.Text = "前景"
        Me.KlxPiaoLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel8.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel8.启用投影 = False
        Me.KlxPiaoLabel8.投影连线 = True
        Me.KlxPiaoLabel8.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel8.颜色减淡 = False
        '
        '缩放按钮按下Panel
        '
        Me.缩放按钮按下Panel.BackColor = System.Drawing.Color.White
        Me.缩放按钮按下Panel.Location = New System.Drawing.Point(495, 44)
        Me.缩放按钮按下Panel.Name = "缩放按钮按下Panel"
        Me.缩放按钮按下Panel.Size = New System.Drawing.Size(50, 50)
        Me.缩放按钮按下Panel.TabIndex = 9
        Me.缩放按钮按下Panel.启用投影 = False
        Me.缩放按钮按下Panel.投影长度 = 5
        Me.缩放按钮按下Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.缩放按钮按下Panel.边框大小 = 1
        Me.缩放按钮按下Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '背景Panel
        '
        Me.背景Panel.BackColor = System.Drawing.Color.White
        Me.背景Panel.Location = New System.Drawing.Point(176, 19)
        Me.背景Panel.Name = "背景Panel"
        Me.背景Panel.Size = New System.Drawing.Size(50, 50)
        Me.背景Panel.TabIndex = 3
        Me.背景Panel.启用投影 = False
        Me.背景Panel.投影长度 = 5
        Me.背景Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.背景Panel.边框大小 = 1
        Me.背景Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        '主题Panel
        '
        Me.主题Panel.BackColor = System.Drawing.Color.White
        Me.主题Panel.Location = New System.Drawing.Point(70, 19)
        Me.主题Panel.Name = "主题Panel"
        Me.主题Panel.Size = New System.Drawing.Size(50, 50)
        Me.主题Panel.TabIndex = 1
        Me.主题Panel.启用投影 = False
        Me.主题Panel.投影长度 = 5
        Me.主题Panel.投影颜色 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.主题Panel.边框大小 = 1
        Me.主题Panel.边框颜色 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'KlxPiaoLabel3
        '
        Me.KlxPiaoLabel3.AutoSize = False
        Me.KlxPiaoLabel3.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel3.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel3.Location = New System.Drawing.Point(126, 19)
        Me.KlxPiaoLabel3.Name = "KlxPiaoLabel3"
        Me.KlxPiaoLabel3.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel3.TabIndex = 2
        Me.KlxPiaoLabel3.Text = "背景"
        Me.KlxPiaoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel3.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel3.启用投影 = False
        Me.KlxPiaoLabel3.投影连线 = True
        Me.KlxPiaoLabel3.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel3.颜色减淡 = False
        '
        'KlxPiaoLabel2
        '
        Me.KlxPiaoLabel2.AutoSize = False
        Me.KlxPiaoLabel2.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel2.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel2.Location = New System.Drawing.Point(20, 19)
        Me.KlxPiaoLabel2.Name = "KlxPiaoLabel2"
        Me.KlxPiaoLabel2.Size = New System.Drawing.Size(44, 50)
        Me.KlxPiaoLabel2.TabIndex = 0
        Me.KlxPiaoLabel2.Text = "主题"
        Me.KlxPiaoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KlxPiaoLabel2.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel2.启用投影 = False
        Me.KlxPiaoLabel2.投影连线 = True
        Me.KlxPiaoLabel2.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel2.颜色减淡 = False
        '
        'KlxPiaoLabel19
        '
        Me.KlxPiaoLabel19.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.KlxPiaoLabel19.ForeColor = System.Drawing.Color.Black
        Me.KlxPiaoLabel19.Location = New System.Drawing.Point(286, 65)
        Me.KlxPiaoLabel19.Name = "KlxPiaoLabel19"
        Me.KlxPiaoLabel19.Size = New System.Drawing.Size(116, 17)
        Me.KlxPiaoLabel19.TabIndex = 33
        Me.KlxPiaoLabel19.Text = "（仅适用浅色主题）"
        Me.KlxPiaoLabel19.偏移量 = New System.Drawing.Point(2, 2)
        Me.KlxPiaoLabel19.启用投影 = False
        Me.KlxPiaoLabel19.投影连线 = True
        Me.KlxPiaoLabel19.投影颜色 = System.Drawing.Color.DarkGray
        Me.KlxPiaoLabel19.颜色减淡 = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.关闭按钮背景色 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.关闭按钮鼠标按下背景色 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.关闭按钮鼠标移入背景色 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.最小化按钮背景色 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.最小化按钮鼠标按下背景色 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.最小化按钮鼠标移入背景色 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.标题框颜色 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.缩放按钮背景色 = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.缩放按钮鼠标按下背景色 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.缩放按钮鼠标移入背景色 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.KlxPiaoPanel16.ResumeLayout(False)
        Me.KlxPiaoPanel16.PerformLayout()
        Me.KlxPiaoPanel17.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents KlxPiaoLabel1 As KlxPiaoLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents KlxPiaoProgressBar1 As KlxPiaoProgressBar
    Friend WithEvents KlxPiaoPanel1 As KlxPiaoPanel
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PointBar1 As PointBar
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents KlxPiaoLabel2 As KlxPiaoLabel
    Friend WithEvents 主题Panel As KlxPiaoPanel
    Friend WithEvents 背景Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel3 As KlxPiaoLabel
    Friend WithEvents 缩放按钮背景Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel4 As KlxPiaoLabel
    Friend WithEvents 缩放按钮按下Panel As KlxPiaoPanel
    Friend WithEvents 缩放按钮移入Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel6 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel5 As KlxPiaoLabel
    Friend WithEvents 缩放按钮前景Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel8 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel7 As KlxPiaoLabel
    Friend WithEvents 最小化按钮前景Panel As KlxPiaoPanel
    Friend WithEvents 关闭按钮前景Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel14 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel15 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel9 As KlxPiaoLabel
    Friend WithEvents 最小化按钮按下Panel As KlxPiaoPanel
    Friend WithEvents 最小化按钮移入Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel16 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel10 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel17 As KlxPiaoLabel
    Friend WithEvents 最小化按钮背景Panel As KlxPiaoPanel
    Friend WithEvents 关闭按钮按下Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel18 As KlxPiaoLabel
    Friend WithEvents 关闭按钮移入Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel11 As KlxPiaoLabel
    Friend WithEvents KlxPiaoLabel12 As KlxPiaoLabel
    Friend WithEvents 关闭按钮背景Panel As KlxPiaoPanel
    Friend WithEvents KlxPiaoLabel13 As KlxPiaoLabel
    Friend WithEvents KlxPiaoPanel16 As KlxPiaoPanel
    Friend WithEvents KlxPiaoPanel17 As KlxPiaoPanel
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents KlxPiaoButton2 As KlxPiaoButton
    Friend WithEvents KlxPiaoButton4 As KlxPiaoButton
    Friend WithEvents KlxPiaoButton3 As KlxPiaoButton
    Friend WithEvents KlxPiaoButton1 As KlxPiaoButton
    Friend WithEvents KlxPiaoLabel19 As KlxPiaoLabel
End Class
