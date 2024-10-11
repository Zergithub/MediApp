Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the about text
        RichTextBox1.Text = "WHAT IS MEDIAPP?" + vbNewLine + vbNewLine
        RichTextBox1.Text += "it is a medication reminder app that is usually for old people,patients, people who cannot take care of themselves or suffer from memory loss or live by themselves. It is like guardian that takes care or the person virtually." + vbNewLine + vbNewLine
        RichTextBox1.Text += "WHAT KIND OF INFORMATION D OWE COLLECT?" + vbNewLine + vbNewLine
        RichTextBox1.Text += "We collect the content, communications and other information you provide when you use our Products, including when you sign up for an account, create or share content, and message or communicate with others. This can include information in or about the content you provide (like metadata), such as the location of a photo or the date a file was created. It can also include what you see through features we provide, such as our camera." + vbNewLine + vbNewLine
        RichTextBox1.Text += "DEVELOPING AND USING TECHNOLOGIES THAT HELP US CONSISTENTLY SERVE OUR GROWING COMMUNITY" + vbNewLine + vbNewLine
        RichTextBox1.Text += "Organizing and analyzing information for our growing community is central to our Service. A big part of our Service is creating and using cutting-edge technologies that help us personalize, protect, and improve our Service on an incredibly large scale for a broad global community. Technologies like artificial intelligence and machine learning give us the power to apply complex processes across our Service. Automated technologies also help us ensure the functionality and integrity of our Service" + vbNewLine + vbNewLine
        RichTextBox1.Text += "ADDITIONAL RIGHTS WE RETAIN" + vbNewLine + vbNewLine
        RichTextBox1.Text += "If you select a username or similar identifier for your account, we may change it if we believe it is appropriate or necessary (for example, if it infringes someone's intellectual property or impersonates another user)" + vbNewLine
        RichTextBox1.Text += "You must obtain written permission from us or under an open source license to modify, create derivative works of, decompile, or otherwise attempt to extract source code from us."
    End Sub
End Class