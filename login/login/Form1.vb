Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usertxt.TextChanged

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passtxt.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

{

if (!(usertxt.Text == string.Empty))

{

if (!(pass.Text == string.Empty))

{

String str = "Server=.;Database=store1;Trusted_Connection=True;";

String query = "select * from login where username = '" + usertxt.Text + "'and passwrd = '" + this.passtxt.Text + "'";

SqlConnection con = new SqlConnection(str);

SqlCommand cmd = new SqlCommand(query, con);

SqlDataReader dbr;

con.Open();

dbr = cmd.ExecuteReader();

int count = 0;

                    While (dbr.Read())

{

count = count + 1;

}

if (count == 1)

{

login obj = new login();

orders objmain = new orders();
objmain.Show(); //after login Redirect to second window
this.Hide();//after login hide the  Login window

}

                        ElseIf (count > 1) Then

{

MessageBox.Show("Duplicate username and password", "login page");

}

                        Else

{

MessageBox.Show(" username and password incorrect", "login page");

}

}

else

{

MessageBox.Show(" password empty", "login page");

}

}
else

{

MessageBox.Show(" username empty", "login page");

}

// con.Close();



}

catch (Exception es)

{

MessageBox.Show(es.Message);
}

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
