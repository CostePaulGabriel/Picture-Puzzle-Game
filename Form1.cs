using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Picture_Puzzle_Game
{
	public partial class Form1 : Form
	{
		int min = 0, sec = 60, totalTime; //totalTime used to store the remaining time
		int score = 0;
		string[] image = { "1.jpg", "2.png", "3.png", "4.png", "5.png", "6.jpg", "7.jpg", "8.jpg" };
		int[] pieceOrder = { 0, 1, 2, 3, 4, 5, 6, 7 }; //correct order of the image parts
		Point emptyPice; //defining the empty slot
		ArrayList imgParts = new ArrayList(); //a list with all the image crops
		int moves = 1;
		public Form1()
		{
			emptyPice.X = 180;
			emptyPice.Y = 180;
			InitializeComponent();
			panel1.Visible = false;
			autoSolve_btn.Visible = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (totalTime > 0)
			{
				totalTime--; 
				int remainingMin = totalTime / 60; 
				int remainingSec = totalTime - (remainingMin * 60); 
				timer_label.Text = $"00:" + (remainingMin > 9 ? remainingMin : "0" + remainingMin) //display digits
									+ ":" + (remainingSec > 9 ? remainingSec : "0" + remainingSec);

				if (totalTime < 30) 
				{
					autoSolve_btn.Visible = true;
					timer_label.ForeColor = Color.Red;
				}
			}
			else
			{
				timer1.Stop();
				timer_label.ForeColor = Color.Black;
				MessageBox.Show("Times is up!");
				play_btn.Visible = true;
			}
		}

		private void play_btn_Click(object sender, EventArgs e)
		{
			moves = 1;
			play_btn.Visible = false;
			timer_label.ForeColor = Color.Black;
			totalTime = (min * 60) + sec;

			//restart the timer every time Play is clicked
			if (totalTime != null)
			{
				timer1.Stop();
				timer1.Start();
			}	
			timer1.Interval = 1000; //1sec
			timer1.Enabled = true;
			panel1.Visible = true;

			foreach (Button button in panel1.Controls)
			{
				button.Enabled = true;
				Debug.WriteLine(button.Name + " : "+ button.Location);
			}

			Random r = new Random(); 
			int randomImg = r.Next(0, image.Length);
			Image original = Image.FromFile($@"E:/Programare GameDevelopment C++ C#/Puzzle Game C#/Picture Puzzle Game/img/{image[randomImg]}");

			imgParts.Clear();

			LoadExampleImage(original);

			CropImageToPieces(original, 270,270);

			AddImageToButtons(imgParts);	
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			MovePiece((Button)sender);
		}

		private void LoadExampleImage(Image image)
		{
			example_pictureBox.Image = image;
		}
		private void AddImageToButtons(ArrayList images)
		{
			int i = 0;
			pieceOrder = suffle(pieceOrder); 

			foreach (Button button in panel1.Controls)
			{
				if (i < pieceOrder.Length)
				{
					button.Image = (Image)images[pieceOrder[i]];
					i++;
				}
			}
		}

		private void autoSolve_btn_Click(object sender, EventArgs e)
		{
			Array.Sort(pieceOrder);

			button1.Location = new Point(0, 0);
			button2.Location = new Point(90, 0);
			button3.Location = new Point(180, 0);
			button4.Location = new Point(0, 90);
			button5.Location = new Point(90, 90);
			button6.Location = new Point(180, 90);
			button7.Location = new Point(0, 180);
			button8.Location = new Point(90, 180);
			emptyPice = new Point(180, 180);
			button1.Image = (Image)imgParts[pieceOrder[0]];	
			button2.Image = (Image)imgParts[pieceOrder[1]];	
			button3.Image = (Image)imgParts[pieceOrder[2]];	
			button4.Image = (Image)imgParts[pieceOrder[3]];	
			button5.Image = (Image)imgParts[pieceOrder[4]];	
			button6.Image = (Image)imgParts[pieceOrder[5]];	
			button7.Image = (Image)imgParts[pieceOrder[6]];	
			button8.Image = (Image)imgParts[pieceOrder[7]]; 

			MessageBox.Show("Puzzle auto solved!");
			foreach (Button button in panel1.Controls)
			{
				Debug.WriteLine("After auto-solve!");
				Debug.WriteLine(button.Name + " : " + button.Location);
				button.Enabled = false;
			}
			timer1.Stop();
			timer_label.Text = "00:00:00";
			timer_label.ForeColor = Color.Black;
			play_btn.Visible = true;
			autoSolve_btn.Visible = false;
			moves = 0;
			moves_label.Text = "Moves: " + moves;
		}
		private int[] suffle(int[] arr) //suffle images
		{
			Random rand = new Random();
			arr = arr.OrderBy(x => rand.Next()).ToArray(); //use System.Linq 
			return arr;
		}

		private void CropImageToPieces(Image image, int width, int height)
		{
			Bitmap bmp = new Bitmap(width, height); //bitmap of the image

			Graphics graphic = Graphics.FromImage(bmp);
			graphic.DrawImage(image, 0, 0, width, height);
			graphic.Dispose();

			int movr = 0, movd = 0; // get the crop by moving right or down

			for (int position = 0; position < 8; position++)
			{
				Bitmap piece = new Bitmap(90, 90); //make a bitmap of the piece size

				for (int i = 0; i < 90; i++)
					for (int j = 0; j < 90; j++)
						piece.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd)); //draw image part pixel by pixel

				imgParts.Add(piece);

				movr += 90; //move to the next piece by changing the X,Y location

				if (movr == 270)
				{
					movr = 0;
					movd += 90;
				}
			}
		}

		private void MovePiece(Button piece)
		{
			Debug.WriteLine("Moving " + piece.Name + "l " + piece.Location);

			//check if I can move the piece by finding the emptyPiece location
			if (((piece.Location.X == emptyPice.X - 90 || piece.Location.X == emptyPice.X + 90)
				&& piece.Location.Y == emptyPice.Y)
				|| (piece.Location.Y == emptyPice.Y - 90 || piece.Location.Y == emptyPice.Y + 90)
				&& piece.Location.X == emptyPice.X)
			{
				//swap between piece and empty space
				Point swap = piece.Location;
				piece.Location = emptyPice;
				emptyPice = swap;

				moves_label.Text = "Moves: " + moves++; //update the moves //+ "Button name: " + (btnId) + "Position: " + pieceNewIndex;
			}

			if (emptyPice.X == 180 && emptyPice.Y == 180)
			{
				IsPuzzleFinished();
			}
		}

		private void IsPuzzleFinished()
		{
			//find if all the buttons have the correct image
			int validPice = 0, index;
			foreach (Button btn in panel1.Controls)
			{
				index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90; //calculate the index of the piece
				if (imgParts[index] == btn.Image)
					validPice++;
			}
			if (validPice == 8)
			{
				timer1.Stop();
				timer_label.ForeColor = Color.Black;
				timer_label.Text = "00:00:00";
				moves = 0;
				moves_label.Text = "Moves" + moves;
				MessageBox.Show("Congratulations, You win!");
				score += 100;
				score_label.Text = "Score:" + score;
			}
		}
	}
}