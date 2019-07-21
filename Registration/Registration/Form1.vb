Imports System.Data.OleDb
Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class frmRegistration
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim id As String = txtid.Text
        Dim srno As Integer = Val(txtsr.Text)
        Dim app As String = txtap.Text
        Dim cust_nm As String = txtcust.Text
        Dim date_instaal As Date = CDate(date_inst.Text)
        Dim req_code As String = txtreq.Text
        Dim active_data As String = txtactive.Text
        Dim mobile As Integer = Val(txtmob.Text)
        Dim email As String = txtemail.Text
        Dim no_client As Integer = Val(txtnoclient.Text)
        Dim sub_date As Date = txtsub.Text
        Dim mob_app As Integer = CBool(mobapp.Text)
        Dim int_date As Date = Me.int_date.Text
        Dim sql As String



        Dim ds As New DataSet
        ds = New DataSet("users")
        Dim OleConn As OleDb.OleDbConnection
        OleConn = New OleDb.OleDbConnection
        OleConn.ConnectionString = "Provider=PROVIDER; Data Source=PUT_DATA_SRC;Initial Catalog=;User Id=MY_USERNAME;Password=MY_PSWDS;"
			' Put your ConnectionString Here

	   MsgBox("Connection open")
       
        sql = "INSERT INTO Registration (AutoID,SrNo,AppName,CustName,DoI,ReqCode,ActivationKey,MobileNo,email,Client,ValidTill, MobileAppInt,IntegrationDate)
                                        VALUES(" & id & "," & srno & ",'" & app & "','" & cust_nm & "','" & date_instaal & "','" & req_code & "','" & active_data & "'," & mobile & ",'" & email & "'," & no_client & ",'" & sub_date & "'," & mob_app & ",'" & int_date & "')"
			 'Put Insert Command here
        MsgBox(sql)
        Dim dataAdptr As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Try
            OleConn.Open()
            dataAdptr.InsertCommand = New OleDbCommand(sql, OleConn)
            dataAdptr.InsertCommand.ExecuteNonQuery()
            MsgBox("Row(s) Inserted !! ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '
        OleConn.Close()
     End Sub
End Class
