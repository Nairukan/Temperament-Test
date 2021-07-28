using System;
using System.Windows.Forms;
using System.Xml;

namespace FirstTry
{
    public struct Temperaments
    {
        public string m_temp;
        public int m_score;
        public void GetData(string tempNam, int score = 0)
        {
            m_temp = tempNam;
            m_score = score;
        }
    };
    public struct Answer
    {
        public string m_answerText;
        public string m_tempTyp;
    };
    public struct QA
    {
        public string m_question;
        public Answer[] m_answers;
    };
    public partial class Test : Form
    {
        const int AnswersAmount = 4;
        QA[] qAmas;
        Temperaments[] Score;
        string[] tempTypes = new string[AnswersAmount];
        static int counter;
        public Test()
        {
            InitializeComponent();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Test.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if(xnode.Name == "description")
                {
                    seText.Text = xnode.InnerText;
                }
                if (xnode.Name == "head")
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        Text = attr.Value;
                    }
                }
                else if(xnode.Name == "qw")
                {
                    counter = xnode.ChildNodes.Count;
                    qAmas = new QA[counter];
                    Score = new Temperaments[4];
                    Score[0].GetData("sang");
                    Score[1].GetData("phl");
                    Score[2].GetData("mel");
                    Score[3].GetData("chol");
                    for (int t = 0; t < counter; t++)
                    {
                        qAmas[t].m_answers = new Answer[AnswersAmount];
                    }
                    int i = 0;
                   foreach(XmlNode childnode in xnode.ChildNodes)
                   {
                        if(childnode.Name == "q")
                        {
                            XmlNode attribute = childnode.Attributes.GetNamedItem("text");
                            qAmas[i].m_question = attribute.Value;
                            if (childnode.HasChildNodes)
                            {
                                XmlNodeList answersList = childnode.SelectNodes("*");
                                for(int k = 0; k < AnswersAmount; k++)
                                {
                                    XmlNode tT = answersList[k].Attributes.GetNamedItem("tempType");
                                    qAmas[i].m_answers[k].m_answerText = answersList[k].InnerText;
                                    qAmas[i].m_answers[k].m_tempTyp = tT.Value;
                                }
                            }
                        }
                        i++;
                   }
                }
            }
        }
        int num = 0;

        private void snoButton_Click(object sender, EventArgs e)
        {
            RadioButton[] ansList = new RadioButton[AnswersAmount];
            AnswerBox.Controls.CopyTo(ansList, 0);
            if (num == 0)
            {
                Question.Text = qAmas[num].m_question;
                for(int i = 0; i < AnswersAmount; i++)
                {
                    ansList[i].Text = qAmas[num].m_answers[i].m_answerText;
                    tempTypes[i] = qAmas[num].m_answers[i].m_tempTyp;
                }
                Question.Visible = true;
                AnswerBox.Visible = true;
                seText.Visible = false;
                snoButton.Text = "Дальше";
                num++;
            }
            else
            {
                bool isAnswered = false;
                for (int i = 0; i < AnswersAmount; i++)
                {
                    if (ansList[i].Checked)
                    {
                        for(int sc = 0; sc < 4; sc++)
                        {
                            if(Score[sc].m_temp == tempTypes[i])
                            {
                                Score[sc].m_score++;
                                break;
                            }
                        }
                        ansList[i].Checked = false;
                        isAnswered = true;
                        break;
                    }
                }
                if (isAnswered)
                {
                    if (num < counter)
                    {
                        Question.Text = qAmas[num].m_question;
                        for (int i = 0; i < AnswersAmount; i++)
                        {
                            ansList[i].Text = qAmas[num].m_answers[i].m_answerText;
                        }
                        num++;
                    }
                    else if (num >= counter)
                    {
                        int indxMax = 0;
                        for(int i = 1; i < 4; i++)
                        {
                            if(Score[indxMax].m_score < Score[i].m_score)
                            {
                                indxMax = i;
                            }
                        }
                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load("Test.xml");
                        XmlElement xRoot = xDoc.DocumentElement;
                        XmlNode temNode = xRoot.SelectSingleNode("temperaments");
                        XmlNodeList tempList = temNode.SelectNodes("*");
                        AnswerBox.Visible = false;
                        snoButton.Visible = false;
                        Question.Visible = false;
                        exButton.Visible = true;
                        foreach(XmlNode answerTemp in tempList)
                        {
                            if(answerTemp.Name == Score[indxMax].m_temp)
                            {
                                seText.Text = answerTemp.InnerText;
                                break;
                            }
                        }
                        seText.Visible = true;
                    }
                }
            }
            if (num == counter)
            {
                snoButton.Text = "Ok";
            }
        }

        private void exButton_Click(object sender, EventArgs e)
        {
            Test.ActiveForm.Close();
        }
    }
}
