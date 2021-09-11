using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private bool mGameMode = true;
        private bool mPlayerTour = true;
        private int mPlayerXScore = 0;
        private int mPlayerOScore = 0;
        private int cnt = 0;
        private Button[,] mGameTable;
        public struct Move
        {
            public int row, column;
        }
        public Form1()
        {
            InitializeComponent();

            mGameTable = new Button[3, 3];

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    mGameTable[i, j] = new Button();

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    mGameTable[i, j] = mTableLayoutPanel.GetControlFromPosition(i, j) as Button;

        }

        public static bool isAnyMoveLeft(Button[,] gameTable)
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (gameTable[i, j].Text == "") return true;
            return false;
        }

        public static int evaluate(Button[,] gameTable)
        {
            for(int i = 0; i < 3; ++i)
                if (gameTable[i, 0].Text == gameTable[i, 1].Text && 
                    gameTable[i, 1].Text == gameTable[i, 2].Text)
                {
                    if (gameTable[i, 0].Text == "X") return 10;
                    else if (gameTable[i, 0].Text == "O") return -10;
                }

            for(int j = 0; j < 3; ++j)
                if (gameTable[0, j].Text == gameTable[1, j].Text && 
                    gameTable[1, j].Text == gameTable[2, j].Text)
                {
                    if (gameTable[0, j].Text == "X") return 10;
                    else if (gameTable[0, j].Text == "O") return -10;
                }

            if (gameTable[0, 0].Text == gameTable[1, 1].Text &&
                gameTable[1, 1].Text == gameTable[2, 2].Text)
            {
                if (gameTable[1, 1].Text == "X") return 10;
                else if (gameTable[1, 1].Text == "O") return -10;
            }
            if (gameTable[0, 2].Text == gameTable[1, 1].Text &&
                gameTable[1, 1].Text == gameTable[2, 0].Text)
            {
                if (gameTable[1, 1].Text == "X") return 10;
                else if (gameTable[1, 1].Text == "O") return -10;
            }

            return 0;
        }

        public static int minimaxAlgorithm(Button[,] gameTable, int depth, bool playerTour)
        {
            int score = evaluate(gameTable);

            if (score == 10) return score;
            if (score == -10) return score;
            if (!isAnyMoveLeft(gameTable)) return 0;

            if (playerTour)
            {
                int best = -1000;

                for(int i = 0; i < 3; ++i)
                    for(int j = 0; j < 3; ++j)
                        if (gameTable[i, j].Text == "")
                        {
                            gameTable[i, j].Text = "X";
                            best = Math.Max(best, minimaxAlgorithm(gameTable, depth + 1, !playerTour));
                            gameTable[i, j].Text = "";
                        }
                return best;
            }
            else
            {
                int best = 1000;

                for (int i = 0; i < 3; ++i)
                    for (int j = 0; j < 3; ++j)
                        if (gameTable[i, j].Text == "")
                        {
                            gameTable[i, j].Text = "O";
                            best = Math.Min(best, minimaxAlgorithm(gameTable, depth + 1, !playerTour));
                            gameTable[i, j].Text = "";
                        }
                return best;
            }
        }

        public static Move findBestMove(Button[,] gameTable)
        { 
            int bestVal = 1000;
            Move bestMove;
            int moveVal = -1;
            bestMove.row = -1;
            bestMove.column = -1;

            for(int i = 0; i < 3; ++i)
                for(int j = 0; j < 3; ++j)
                    if(gameTable[i, j].Text == "")
                    {
                        gameTable[i, j].Text = "O";

                        if (evaluate(gameTable) == -10)
                        {
                            bestMove.row = i;
                            bestMove.column = j;
                            return bestMove;
                        }

                        moveVal = minimaxAlgorithm(gameTable, 0, true);
                        gameTable[i, j].Text = "";
                        if (moveVal < bestVal)
                        {
                            bestMove.row = i;
                            bestMove.column = j;
                            bestVal = moveVal;
                        }
                    }
            return bestMove;
        }

        private void restartGame()
        {
            mPlayerTour = true;
            mLabel3.Text = "Turn: Player X";

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    mGameTable[i, j].Text = "";
            cnt = 0;
        }
        private void mButton_Click(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            if (buttonSender.Text != "") return;
            if (!mGameMode)
            {
                cnt++;
                buttonSender.Text = "X";

                switch (evaluate(mGameTable))
                {
                    case 10:
                        mPlayerXScore++;
                        mLabel4.Text = "Player X Score: " + mPlayerXScore.ToString();
                        restartGame();
                        return;
                        break;
                    case -10:
                        mPlayerOScore++;
                        mLabel5.Text = "Player O Score: " + mPlayerOScore.ToString();
                        restartGame();
                        return;
                        break;
                    case 0:
                        if (!isAnyMoveLeft(mGameTable))
                        {
                            restartGame();
                            return;
                        }
                        break;
                    default:
                        break;
                }

                if (cnt > 1)
                {
                    Move bestMove = findBestMove(mGameTable);
                    mGameTable[bestMove.row, bestMove.column].Text = "O";
                }
                else if (cnt == 1)
                {
                    if (buttonSender == mButton1 || buttonSender == mButton3 || buttonSender == mButton7 || buttonSender == mButton9) mButton5.Text = "O";
                    else if (buttonSender == mButton2 || buttonSender == mButton4 || buttonSender == mButton5) mButton1.Text = "O";
                    else if (buttonSender == mButton6) mButton3.Text = "O";
                    else if (buttonSender == mButton8) mButton2.Text = "O";
                }

                switch (evaluate(mGameTable))
                {
                    case 10:
                        mPlayerXScore++;
                        mLabel4.Text = "Player X Score: " + mPlayerXScore.ToString();
                        restartGame();
                        return;
                        break;
                    case -10:
                        mPlayerOScore++;
                        mLabel5.Text = "Player O Score: " + mPlayerOScore.ToString();
                        restartGame();
                        return;
                        break;
                    case 0:
                        if (!isAnyMoveLeft(mGameTable))
                        {
                            restartGame();
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (mPlayerTour)
                {
                    buttonSender.Text = "X";
                    mLabel3.Text = "Turn: Player O";
                }
                else
                {
                    buttonSender.Text = "O";
                    mLabel3.Text = "Turn: Player X";
                }
                mPlayerTour = !mPlayerTour;

                switch (evaluate(mGameTable))
                {
                    case 10:
                        mPlayerXScore++;
                        mLabel4.Text = "Player X Score: " + mPlayerXScore.ToString();
                        restartGame();
                        return;
                        break;
                    case -10:
                        mPlayerOScore++;
                        mLabel5.Text = "Player O Score: " + mPlayerOScore.ToString();
                        restartGame();
                        return;
                        break;
                    case 0:
                        if (!isAnyMoveLeft(mGameTable))
                        {
                            restartGame();
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void mSinglePlayerButton_Click(object sender, EventArgs e)
        {
            mGameMode = false;
            restartGame();
            mLabel2.Text = "Gamemode: Singleplayer";
            mLabel4.Text = "Player X Score: 0";
            mLabel5.Text = "Player O Score: 0";
            mPlayerXScore = 0;
            mPlayerOScore = 0;
        }

        private void mMultiPlayerButton_Click(object sender, EventArgs e)
        {
            mGameMode = true;
            restartGame();
            mLabel2.Text = "Gamemode: Multiplayer";
            mLabel4.Text = "Player X Score: 0";
            mLabel5.Text = "Player O Score: 0";
            mPlayerXScore = 0;
            mPlayerOScore = 0;
        }

        private void mExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}