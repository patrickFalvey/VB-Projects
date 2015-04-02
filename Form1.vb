Public Class Form1

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        Dim Web As New HtmlAgilityPack.HtmlWeb
        Dim Doc As New HtmlAgilityPack.HtmlDocument
        Dim htmlDoc = New HtmlAgilityPack.HtmlDocument()
        Dim awayteam As New List(Of String)

        Doc = Web.Load("http://sports.yahoo.com/nba/scoreboard/?date=2015-04-03")
        For Each table In Doc.DocumentNode.SelectNodes("//td[@class='home']")
            ListBox1.Items.Add(table.InnerText)


        Next
    End Sub


    Private Sub awayButton_Click(sender As Object, e As EventArgs) Handles awayButton.Click
        Dim Web As New HtmlAgilityPack.HtmlWeb
        Dim Doc As New HtmlAgilityPack.HtmlDocument
        Dim htmlDoc = New HtmlAgilityPack.HtmlDocument()

        Doc = Web.Load("http://sports.yahoo.com/nba/scoreboard/?date=2015-04-03")
        For Each table As HtmlAgilityPack.HtmlNode In Doc.DocumentNode.SelectNodes("//td[@class='away']")
            ListBox2.Items.Add(table.InnerText)
        Next
    End Sub


    Private Sub timeButton_Click(sender As Object, e As EventArgs) Handles timeButton.Click
        Dim Web As New HtmlAgilityPack.HtmlWeb
        Dim Doc As New HtmlAgilityPack.HtmlDocument
        Dim htmlDoc = New HtmlAgilityPack.HtmlDocument()

        Doc = Web.Load("http://sports.yahoo.com/nba/scoreboard/?date=2015-04-03")
        For Each table As HtmlAgilityPack.HtmlNode In Doc.DocumentNode.SelectNodes("//span[@class='time']")
            ListBox4.Items.Add(table.InnerText)
        Next
    End Sub

    Private Sub dateButton_Click(sender As Object, e As EventArgs) Handles dateButton.Click
        Dim Web As New HtmlAgilityPack.HtmlWeb
        Dim Doc As New HtmlAgilityPack.HtmlDocument
        Dim htmlDoc = New HtmlAgilityPack.HtmlDocument()

        Doc = Web.Load("http://sports.yahoo.com/nba/scoreboard/?date=2015-04-03")
        For Each table As HtmlAgilityPack.HtmlNode In Doc.DocumentNode.SelectNodes("//tr[@class='date']")
            ListBox3.Items.Add(table.InnerText)
        Next
    End Sub
End Class
