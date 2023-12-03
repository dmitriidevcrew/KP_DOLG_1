namespace KP_DOLG_1
{
    public partial class Form1 : Form
    {
        private const int Size = 5;
        private TextBox[,] textBoxesA = new TextBox[Size, Size];
        private TextBox[,] textBoxesB = new TextBox[Size, Size];
        private TextBox[,] textBoxesC = new TextBox[Size, Size];
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxes();
            FillAndMultiplyMatrices();
        }

        private void InitializeTextBoxes()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    textBoxesA[i, j] = CreateTextBox(i, j, 10);
                    textBoxesB[i, j] = CreateTextBox(i, j, 200);
                    textBoxesC[i, j] = CreateTextBox(i, j, 400);

                    this.Controls.Add(textBoxesA[i, j]);
                    this.Controls.Add(textBoxesB[i, j]);
                    this.Controls.Add(textBoxesC[i, j]);
                }
            }
        }

        private TextBox CreateTextBox(int row, int col, int leftOffset)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(leftOffset + col * 30, 30 + row * 30);
            textBox.Size = new System.Drawing.Size(25, 25);
            return textBox;
        }

        private void FillAndMultiplyMatrices()
        {
            int[,] matrixA = new int[Size, Size];
            int[,] matrixB = new int[Size, Size];
            int[,] matrixC = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrixA[i, j] = random.Next(0, 11);
                    matrixB[i, j] = random.Next(0, 11);
                    textBoxesA[i, j].Text = matrixA[i, j].ToString();
                    textBoxesB[i, j].Text = matrixB[i, j].ToString();
                }
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < Size; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                    matrixC[i, j] *= 2;
                    textBoxesC[i, j].Text = matrixC[i, j].ToString();
                }
            }
        }
    }

}
