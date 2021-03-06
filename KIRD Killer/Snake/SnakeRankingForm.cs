﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace robot.Snake
{
    public partial class SnakeRankingForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        int highestScore = 0;
        static public Label highScoreLabel;

        public SnakeRankingForm(Point parentLocation, int highestScore)
        {
            InitializeComponent();

            this.highestScore = highestScore;
            highScoreLabel = highestScoreLabel;

            nameLabel.Text = Program.id;
            highestScoreLabel.Text = highestScore.ToString();

            getScore();
        }

        public void setScore(int score)
        {
            highScoreLabel.Text = score.ToString();
        }

        public void getScore()
        {
            while (rankingGrid.Rows.Count != 0)
            {
                rankingGrid.Rows.RemoveAt(0);
            }

            // 악용하지 말아주세요 :)
            browser.Navigate("http://carpedm20.net76.net/snake_ranking.php");

            while (browser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

            HtmlDocument doc = browser.Document as HtmlDocument;

            IEnumerable<HtmlElement> scores = ElementsByClass(doc, "score");
            IEnumerable<HtmlElement> names = ElementsByClass(doc, "name");

            for (int i = 0; i < scores.Count(); i++)
            {
                String[] rows=new string[3];

                rows[0] = (i + 1).ToString();
                rows[1] = names.ElementAt(i).InnerText;
                rows[2] = scores.ElementAt(i).InnerText;

                rankingGrid.Rows.Add(rows);
            }
        }

        static IEnumerable<HtmlElement> ElementsByClass(HtmlDocument doc, string className)
        {
            foreach (HtmlElement e in doc.All)
                if (e.GetAttribute("className") == className)
                    yield return e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            // 악용하지 말아주세요 :)
            browser.Navigate("http://carpedm20.net76.net/snake_insert.php?name="+Program.id+"&score="+highestScore.ToString());

            while (browser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

            getScore();

            button1.Enabled = true;
        }

        private void SnakeRankingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SnakeForm.isRakingFormExist = false;
        }
    }
}
