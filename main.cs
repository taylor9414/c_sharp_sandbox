using System;
using System.IO;
using System.Windows.Forms;


namespace HelloWin
{
public class MyForm : Form
{
	private TextBox txtEnter;
	private Label lblDisplay;
	private Button btnOk;
	
	public MyForm()
	{
		this.txtEnter = new TextBox();
		this.lblDisplay = new Label();
		this.btnOk = new Button();
		this.Text = "My HelloWin App!";
		
		this.txtEnter.Location = new System.Drawing.Point(16,32);
		this.txtEnter.Size = new System.Drawing.Size(264,20);
		
		this.lblDisplay.Location = new System.Drawing.Point(16, 72);
		this.lblDisplay.Size = new System.Drawing.Size(264, 128);
		
		this.btnOk.Location = new System.Drawing.Point(88,224);
		this.btnOk.Text = "OK";
		this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
		this.Controls.AddRange(new Control[] {this.txtEnter, this.lblDisplay, this.btnOk});
		
	}
	
	public static void Main ( string[] args)
	{
		
		Console.WriteLine("Hello Man.");
		Application.Run(new MyForm());
	}
	
	private void btnOk_Click(object sender, System.EventArgs e)
	{
		lblDisplay.Text = txtEnter.Text + "\n" + lblDisplay.Text;
	}

}
}