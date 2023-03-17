Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboModRAM.Items.Add(1)
        cboModRAM.Items.Add(2)
        cboModRAM.Items.Add(3)
        cboModRAM.Items.Add(4)
        cboModRAM.SelectedIndex = 0
        cboModRAM.Enabled = False

        cboModHDD.Items.Add(1)
        cboModHDD.Items.Add(2)
        cboModHDD.Items.Add(3)
        cboModHDD.Items.Add(4)
        cboModHDD.SelectedIndex = 0
        cboModHDD.Enabled = False

        lstQuote.Items.Add(vbTab & vbTab & vbTab & vbTab & "      COMPUTER QUOTATION")
        lstQuote.Items.Add("><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><")
        lstQuote.Items.Add("")

        txtMouse.Enabled = False
        txtMouse.Text = 0

        txtMonitor.Enabled = False
        txtMonitor.Text = 0

        txtKeyboard.Enabled = False
        txtKeyboard.Text = 0

        txtSpeaker.Enabled = False
        txtSpeaker.Text = 0

        lblPrices.Visible = False

    End Sub

    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click

        Dim strName As String
        Dim strSurname As String
        Dim strModel As String

        'Declaring Constants
        Const decVAT As Decimal = 1.15D
        Const decMarkup As Decimal = 1.4D

        Dim decCompPrice As Decimal

        Dim decHDDSpec As Decimal
        Dim decRAMSpec As Decimal

        Dim decAddPeripherals As Decimal
        Dim decTotalPrice As Decimal
        Dim decPrice As Decimal


        Dim decMouse As Decimal
        Dim decKeyboard As Decimal
        Dim decMonitor As Decimal
        Dim decSpeaker As Decimal


        decCompPrice = 3722 * decMarkup * decVAT

        strName = txtName.Text
        strSurname = txtSurname.Text

        'Adding Outputs To Listbox
        lstQuote.Items.Add(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> CUSTOMER INFORMATION <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<")
        lstQuote.Items.Add("_______________________________________________________________________________________________________________________________________________")
        lstQuote.Items.Add("")
        lstQuote.Items.Add("NAME" & vbTab & vbTab & vbTab & vbTab & " : " & vbTab & strName)
        lstQuote.Items.Add("SURNAME" & vbTab & vbTab & vbTab & " : " & vbTab & strSurname)
        lstQuote.Items.Add("_______________________________________________________________________________________________________________________________________________")
        lstQuote.Items.Add("")
        If strName = "" Then
            MessageBox.Show("Please Enter Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            lstQuote.Items.Clear()
            lstQuote.Items.Add(vbTab & vbTab & vbTab & vbTab & "      COMPUTER QUOTATION")
            lstQuote.Items.Add("><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><")
            Exit Sub

        End If

        If strSurname = "" Then
            MessageBox.Show("Please Enter Surname", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSurname.Focus()
            lstQuote.Items.Clear()
            lstQuote.Items.Add(vbTab & vbTab & vbTab & vbTab & "      COMPUTER QUOTATION")
            lstQuote.Items.Add("><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><")
            Exit Sub

        End If

        '>>>>>>>>>>>>>>>>>>>>> GROUP BOX 1 <<<<<<<<<<<<<<<<<<<<<<<<


        If chkStandard.Checked = True Then
            decPrice = decCompPrice
            strModel = "Standard Computer"

            'Adding Outputs To Listbox
            lstQuote.Items.Add(">>>>>>>>>>>>>>>>>>>>>>>>>>> QUOTE & COMPUTER DESCRIPTION <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<")
            lstQuote.Items.Add("_______________________________________________________________________________________________________________________________________________")
            lstQuote.Items.Add("")
            lstQuote.Items.Add("COMPUTER TYPE" & vbTab & vbTab & vbTab & " : " & vbTab & strModel)
            lstQuote.Items.Add("COMPUTER SPEC" & vbTab & vbTab & vbTab & " : " & vbTab & "500GB HDD " & " ; " & " 4GB DDR-4 RAM " & " ; " & " Intel Celeron G4930 ")
            lstQuote.Items.Add("COMPUTER PRICE" & vbTab & vbTab & " : " & vbTab & decPrice.ToString("C2"))
            lstQuote.Items.Add("_______________________________________________________________________________________________________________________________________________")
        End If
        lstQuote.Items.Add("")

        Select Case cboModRAM.SelectedIndex
            Case 0
                decRAMSpec = 0 * decMarkup * decVAT

            Case 1
                decRAMSpec = 429 * decMarkup * decVAT
                lstQuote.Items.Add("RAM TOTAL" & vbTab & vbTab & vbTab & " : " & vbTab & decRAMSpec.ToString("C2"))
            Case 2
                decRAMSpec = 858 * decMarkup * decVAT
                lstQuote.Items.Add("RAM TOTAL" & vbTab & vbTab & vbTab & " : " & vbTab & decRAMSpec.ToString("C2"))
            Case 3
                decRAMSpec = 1287 * decMarkup * decVAT
                lstQuote.Items.Add("RAM TOTAL" & vbTab & vbTab & vbTab & " : " & vbTab & decRAMSpec.ToString("C2"))
        End Select


        Select Case cboModHDD.SelectedIndex
            Case 0
                decHDDSpec = 0 * decMarkup * decVAT

            Case 1
                decHDDSpec = 940 * decMarkup * decVAT
                lstQuote.Items.Add("HDD TOTAL" & vbTab & vbTab & vbTab & " : " & vbTab & decHDDSpec.ToString("C2"))
            Case 2
                decHDDSpec = 1880 * decMarkup * decVAT
                lstQuote.Items.Add("HDD TOTAL" & vbTab & vbTab & vbTab & " : " & vbTab & decHDDSpec.ToString("C2"))
            Case 3
                decHDDSpec = 2820 * decMarkup * decVAT
                lstQuote.Items.Add("HDD TOTAL" & vbTab & vbTab & vbTab & " : " & vbTab & decHDDSpec.ToString("C2"))
        End Select

        lstQuote.Items.Add("_______________________________________________________________________________________________________________________________________________")
        lstQuote.Items.Add("")

        '>>>>>>>>>>>>>>>>>>>>> GROUP BOX 2 <<<<<<<<<<<<<<<<<<<<<<<<

        Dim intMouseNo As Integer
        Dim intMonitorNo As Integer
        Dim intKeyboardNo As Integer
        Dim intSpeakerNo As Integer

        intMouseNo = txtMouse.Text
        intMonitorNo = txtMonitor.Text
        intKeyboardNo = txtKeyboard.Text
        intSpeakerNo = txtKeyboard.Text

        If chkMouse.Checked = True Then
            decMouse = 99 * decMarkup * decVAT * intMouseNo
            lstQuote.Items.Add("MOUSE " & " x " & intMouseNo & vbTab & vbTab & vbTab & " : " & vbTab & decMouse.ToString("C2"))
        End If

        If chkKeyboard.Checked = True Then
            decKeyboard = 115 * decMarkup * decVAT * intKeyboardNo
            lstQuote.Items.Add("KEYBOARD " & " x " & intKeyboardNo & vbTab & vbTab & vbTab & " : " & vbTab & decKeyboard.ToString("C2"))
        End If

        If chkMonitor.Checked = True Then
            decMonitor = 1020 * decMarkup * decVAT * intMonitorNo
            lstQuote.Items.Add("MONITOR " & " x " & intMonitorNo & vbTab & vbTab & vbTab & " : " & vbTab & decMonitor.ToString("C2"))
        End If

        If chkSpeaker.Checked = True Then
            decSpeaker = 249 * decMarkup * decVAT * intSpeakerNo
            lstQuote.Items.Add("SPEAKER " & " x " & intSpeakerNo & vbTab & vbTab & vbTab & " : " & vbTab & decSpeaker.ToString("C2"))
        End If

        'Calculating Total Additional Items
        decAddPeripherals = decMouse + decKeyboard + decMonitor + decSpeaker

        'Adding Outputs To Listbox
        lstQuote.Items.Add("")
        lstQuote.Items.Add("TOTAL ADDITIONAL PERIPHERALS" & vbTab & " : " & vbTab & decAddPeripherals.ToString("C2"))

        'Calculating Total Price
        decTotalPrice = decPrice + decAddPeripherals + decHDDSpec + decRAMSpec

        'Adding Outputs To Listbox
        lstQuote.Items.Add("")
        lstQuote.Items.Add("===============================================================================================================================================")
        lstQuote.Items.Add("")
        lstQuote.Items.Add("TOTAL PRICE" & vbTab & vbTab & vbTab & " : " & vbTab & decTotalPrice.ToString("C2"))
        lstQuote.Items.Add("===============================================================================================================================================")

    End Sub

    Private Sub chkRAM_CheckedChanged(sender As Object, e As EventArgs) Handles chkRAM.CheckedChanged

        'Enabling & Disabling RAM Combobox
        If chkRAM.Checked = True Then
            cboModRAM.Enabled = True
        Else cboModRAM.Enabled = False
            cboModRAM.SelectedIndex = 0
        End If

    End Sub

    Private Sub chkHDD_CheckedChanged(sender As Object, e As EventArgs) Handles chkHDD.CheckedChanged

        'Enabling & Disabling HDD Combobox
        If chkHDD.Checked = True Then
            cboModHDD.Enabled = True
        Else cboModHDD.Enabled = False
            cboModHDD.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Textboxes
        txtName.Text = ""
        txtSurname.Text = ""

        'Clear & Disable Comboboxes
        cboModHDD.Enabled = False
        cboModRAM.Enabled = False
        cboModHDD.SelectedIndex = 0
        cboModRAM.SelectedIndex = 0

        'Clear Computer Checkboxes
        chkStandard.Checked = False
        chkHDD.Checked = False
        chkRAM.Checked = False

        'Clear Additional Peripherals Checkboxes
        chkSpeaker.Checked = False
        chkMonitor.Checked = False
        chkKeyboard.Checked = False
        chkMouse.Checked = False

        'Clear & Reset ListBox
        lstQuote.Items.Clear()
        lstQuote.Items.Add("                                                                            COMPUTER QUOTATION                                                             ")
        lstQuote.Items.Add("><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><")
        lstQuote.Items.Add("")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exit Program
        Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim iSave As New SaveFileDialog
        iSave.Filter = "txt files (*.txt) |*.txt"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, lstQuote.Text)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim iSave As New SaveFileDialog
        iSave.Filter = "txt files (*.txt) |*.txt"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False



        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, lstQuote.Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        'Clear Textboxes
        txtName.Text = ""
        txtSurname.Text = ""

        'Clear & Disable Comboboxes
        cboModHDD.Enabled = False
        cboModRAM.Enabled = False
        cboModHDD.SelectedIndex = 0
        cboModRAM.SelectedIndex = 0

        'Clear Computer Checkboxes
        chkStandard.Checked = False
        chkHDD.Checked = False
        chkRAM.Checked = False

        'Clear Additional Peripherals Checkboxes
        chkSpeaker.Checked = False
        chkMonitor.Checked = False
        chkKeyboard.Checked = False
        chkMouse.Checked = False

        'Clear & Reset ListBox
        lstQuote.Items.Clear()
        lstQuote.Items.Add("                                                                            COMPUTER QUOTATION                                                             ")
        lstQuote.Items.Add("><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><")
        lstQuote.Items.Add("")

    End Sub

    Private Sub chkMouse_CheckedChanged(sender As Object, e As EventArgs) Handles chkMouse.CheckedChanged

        If chkMouse.Checked = True Then
            txtMouse.Enabled = True
            txtMouse.Text = 1
            txtMouse.Focus()
        Else txtMouse.Enabled = False
            txtMouse.Text = 0
        End If

    End Sub

    Private Sub chkMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles chkMonitor.CheckedChanged
        If chkMonitor.Checked = True Then
            txtMonitor.Enabled = True
            txtMonitor.Text = 1
            txtMonitor.Focus()
        Else txtMonitor.Enabled = False
            txtMonitor.Text = 0
        End If

    End Sub

    Private Sub chkKeyboard_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeyboard.CheckedChanged
        If chkKeyboard.Checked = True Then
            txtKeyboard.Enabled = True
            txtKeyboard.Text = 1
            txtKeyboard.Focus()
        Else txtKeyboard.Enabled = False
            txtKeyboard.Text = 0
        End If

    End Sub

    Private Sub chkSpeaker_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpeaker.CheckedChanged
        If chkSpeaker.Checked = True Then
            txtSpeaker.Enabled = True
            txtSpeaker.Text = 1
            txtSpeaker.Focus()
        Else txtSpeaker.Enabled = False
            txtSpeaker.Text = 0
        End If

    End Sub

    Private Sub chkPrices_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrices.CheckedChanged

        If chkPrices.Checked = True Then
            lblPrices.Visible = True
        Else lblPrices.Visible = False

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
