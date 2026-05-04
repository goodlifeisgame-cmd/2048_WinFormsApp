namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;
        private int mapSize = 4;
        private int lableSize = 70;
        private static Random random = new Random();
        private int bestScore = 0;
        private User user;

        private Label laberlAnimation;
        private bool revertAnimation;
        private int labelSizeAnimation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            var welcome = new WelcomeMenu();
            welcome.ShowDialog();
            user = new User(welcome.Name);
            Show();

            Hide();
            var settingMap = new SettingMap();
            settingMap.ShowDialog();
            mapSize = settingMap.SizeMap;
            Show();

            InitMap();
            bestScore = ResultStorage.GetBestUser();
            bestScoreLabel.Text = bestScore.ToString();
            GenerateNumber();
        }



        private void InitMap()
        {
            RemoveMap();

            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
            RestartInterface();
        }

        private void RemoveMap()
        {
            if (labelsMap == null)
            {
                return;
            }

            foreach (var label in labelsMap)
            {
                Controls.Remove(label);
            }
        }

        private void GenerateNumber()
        {
            while (FreeLine())
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);

                int indexRow = randomNumberLabel / mapSize;
                int indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    if (random.Next(3) % 2 == 0)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                        labelsMap[indexRow, indexColumn].BackColor = SetColorButton("2");
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                        labelsMap[indexRow, indexColumn].BackColor = SetColorButton("4");
                    }

                    RestartInterface();
                    laberlAnimation = labelsMap[indexRow, indexColumn];
                    revertAnimation = false;
                    labelSizeAnimation = 50;
                    AnimationTimer.Start();
                    return;
                }
            }
        }

        private void ShowScore()
        {
            scoreLabel.Text = user.Score.ToString();

            if (user.Score > bestScore)
            {
                bestScore = user.Score;
                bestScoreLabel.Text = scoreLabel.Text;
            }
        }


        public bool FreeLine()
        {
            var result = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        result = true;
                    }

                    labelsMap[i, j].BackColor = SetColorButton(labelsMap[i, j].Text);
                }
            }

            return result;
        }


        private Color SetColorButton(string value)
        {
            switch (value)
            {
                case "2": return Color.FromArgb(238, 226, 213);
                case "4": return Color.FromArgb(238, 222, 197);
                case "8": return Color.FromArgb(238, 178, 115);
                case "16": return Color.FromArgb(246, 149, 98);
                case "32": return Color.FromArgb(246, 125, 90);
                case "64": return Color.FromArgb(246, 93, 49);
                case "128": return Color.FromArgb(238, 206, 106);
                case "256": return Color.FromArgb(238, 204, 97);
                case "512": return Color.FromArgb(237, 200, 80);
                case "1024": return Color.FromArgb(237, 197, 63);
                case "2048": return Color.FromArgb(237, 194, 46);
                default: return Color.FromArgb(205, 194, 181);
            }
        }



        private Label CreateLabel(int indexRows, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ControlDark;
            label.Font = new Font("Proxima Nova Rg", 10.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.MenuHighlight;
            label.Size = new Size(lableSize, lableSize);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * (lableSize + 10);
            int y = 70 + indexRows * (lableSize + 10);
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }

                        for (int k = j - 1; k >= 0 && labelsMap[i, j].Text != string.Empty; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, k].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text) * 2;
                                    user.Score += number;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }

                        for (int k = j + 1; k < mapSize && labelsMap[i, j].Text != string.Empty; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, k].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text) * 2;
                                    user.Score += number;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }

                    }
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }

                        for (int k = i + 1; k < mapSize && labelsMap[i, j].Text != string.Empty; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text) * 2;
                                    user.Score += number;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }

                    }
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }

                        for (int k = i - 1; k >= 0 && labelsMap[i, j].Text != string.Empty; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text) * 2;
                                    user.Score += number;
                                    labelsMap[i, j].Text = number.ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }

                    }
                }
            }

            GenerateNumber();
            ShowScore();

            if (EndGame())
            {
                if (Win())
                {
                    MessageBox.Show("Вы справились вы прошли 2048");
                    return;
                }
                MessageBox.Show("Игра закончена, вы проиграли");
            }
        }

        private bool EndGame()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Win()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (int.Parse(labelsMap[i, j].Text) >= 2048)
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        private void рестартToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            var settingMap = new SettingMap();
            settingMap.ShowDialog();
            mapSize = settingMap.SizeMap;
            Show();


            InitMap();

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    labelsMap[i, j].Text = string.Empty;
                }
            }

            user.Score = 0;
            GenerateNumber();
        }

        private void правилаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Как играть: Используйте клавиши ваши стрелками, чтобы переместить плитки. Когда два плитки с тем же номером ощупь, они слияния в один!");
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tableRusult = new TableResults();
            tableRusult.ShowDialog();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lableSize = 30;
            RestartInterface();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lableSize = 50;
            RestartInterface();
        }

        private void big150ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lableSize = 70;
            RestartInterface();
        }

        private void RestartInterface()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    labelsMap[i, j].Size = new Size(lableSize, lableSize);
                    int x = 10 + i * (lableSize + 10);
                    int y = 70 + j * (lableSize + 10);
                    labelsMap[j, i].Location = new Point(x, y);
                }
            }

            int widthTemp = 10 * (mapSize + 3) + lableSize * mapSize;
            Width = Math.Max(widthTemp, 225);
            Height = 10 * (mapSize + 3) + lableSize * mapSize + 80;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelSizeAnimation < lableSize + 10 && !revertAnimation)
            {
                labelSizeAnimation += 5;
                laberlAnimation.Size = new Size(labelSizeAnimation, labelSizeAnimation);
            }
            if (labelSizeAnimation >= lableSize + 10)
            {
                revertAnimation = true;
            }
            if (labelSizeAnimation > lableSize && revertAnimation)
            {
                labelSizeAnimation--;
                laberlAnimation.Size = new Size(labelSizeAnimation, labelSizeAnimation);
            }
            if (labelSizeAnimation == lableSize && revertAnimation)
            {
                AnimationTimer.Stop();
            }
        }
    }
}

